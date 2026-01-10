using VRMS.Models.Billing;
using VRMS.Repositories.Billing;

namespace VRMS.Services.Billing;

public class RateService
{
    private readonly RateConfigurationRepository _rateRepo;

    public RateService(RateConfigurationRepository rateRepo)
    {
        _rateRepo = rateRepo;
    }

    // ---------------- BASE RENTAL ----------------

    public decimal CalculateRentalCost(
        DateTime pickup,
        DateTime returnDate,
        int vehicleCategoryId)
    {
        if (returnDate < pickup)
            throw new InvalidOperationException(
                "Return date cannot be before pickup date.");

        var rate =
            _rateRepo.GetByCategory(vehicleCategoryId);

        return CalculateCheapest(
            pickup,
            returnDate,
            rate);
    }

    // ---------------- LATE PENALTY ----------------

    public decimal CalculateLatePenalty(
        DateTime expectedReturn,
        DateTime actualReturn,
        int vehicleCategoryId)
    {
        if (actualReturn <= expectedReturn)
            return 0m;

        var rate =
            _rateRepo.GetByCategory(vehicleCategoryId);

        var lateHours =
            (decimal)(actualReturn - expectedReturn).TotalHours;

        lateHours = Math.Ceiling(lateHours);

        return decimal.Round(
            lateHours * rate.HourlyRate,
            2);
    }

    // ---------------- MILEAGE OVERAGE ----------------

    public decimal CalculateMileageOverage(
        int startOdometer,
        int endOdometer,
        DateTime pickup,
        DateTime returnDate,
        int vehicleCategoryId)
    {
        if (endOdometer <= startOdometer)
            return 0m;

        var rate =
            _rateRepo.GetByCategory(vehicleCategoryId);

        var days =
            Math.Ceiling(
                (returnDate - pickup).TotalDays);

        var included =
            (decimal)days * rate.IncludedMileagePerDay;

        var actual =
            endOdometer - startOdometer;

        var excess =
            Math.Max(0m, actual - included);

        return decimal.Round(
            excess * rate.ExcessMileageRate,
            2);
    }

    // ---------------- INTERNAL ----------------

    private static decimal CalculateCheapest(
        DateTime start,
        DateTime end,
        RateConfiguration rate)
    {
        var hours =
            (decimal)(end - start).TotalHours;

        if (hours <= 0)
            return 0m;

        hours = Math.Ceiling(hours);

        var days = Math.Ceiling(hours / 24m);
        var weeks = Math.Floor(days / 7m);
        var months = Math.Floor(days / 30m);

        decimal best = decimal.MaxValue;

        best = Math.Min(best,
            hours * rate.HourlyRate);

        best = Math.Min(best,
            days * rate.DailyRate);

        best = Math.Min(best,
            weeks * rate.WeeklyRate +
            (days % 7m) * rate.DailyRate);

        best = Math.Min(best,
            months * rate.MonthlyRate +
            Math.Floor((days % 30m) / 7m)
            * rate.WeeklyRate +
            ((days % 30m) % 7m)
            * rate.DailyRate);

        return decimal.Round(best, 2);
    }
}
