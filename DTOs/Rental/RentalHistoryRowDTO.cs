using VRMS.Enums;

namespace VRMS.DTOs.Rental;

public class RentalHistoryRowDto
{
    // -------------------------
    // REQUIRED BY RentalService
    // -------------------------

    public int RentalId { get; set; }

    public DateTime PickupDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    // Service still writes to this
    public int DurationDays { get; set; }

    // Service still writes to this
    public RentalStatus Status { get; set; }

    // Service provides nullable
    public decimal? TotalAmount { get; set; }

    // -------------------------
    // UI-FRIENDLY PROPERTIES
    // (NO service dependency)
    // -------------------------

    // Designer grid expects this
    public int DaysRented => DurationDays;

    // Safe non-null amount for UI binding
    public decimal TotalAmountSafe => TotalAmount ?? 0m;

    // Optional display helpers (won’t break anything)
    public string StatusDisplay => Status.ToString();

    // Future-proof placeholders (UI can bind later)
    public string? RentalNumber { get; set; }
    public string? VehicleName { get; set; }
    public string? PlateNumber { get; set; }
    public string? Category { get; set; }
}
