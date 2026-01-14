using VRMS.Database.Seeders;
using VRMS.Enums;
using VRMS.Services.Rental;

namespace VRMS.Database.Seeders.Rental;

public class ReservationSeeder : ISeeder
{
    public string Name => nameof(ReservationSeeder);

    private readonly ReservationService _reservationService;

    public ReservationSeeder(ReservationService reservationService)
    {
        _reservationService = reservationService;
    }

    public void Run()
    {
        // Customer 1 reserves Vehicle 1
        var r1 = _reservationService.CreateReservation(
            customerId: 1,
            vehicleId: 1,
            startDate: DateTime.Today.AddDays(1),
            endDate: DateTime.Today.AddDays(4)
        );

        _reservationService.ConfirmReservation(r1);

        // Customer 2 reserves Vehicle 2 (pending only)
        _reservationService.CreateReservation(
            customerId: 2,
            vehicleId: 2,
            startDate: DateTime.Today.AddDays(3),
            endDate: DateTime.Today.AddDays(6)
        );

        // Customer 3 reserves Vehicle 3 and confirms
        var r3 = _reservationService.CreateReservation(
            customerId: 3,
            vehicleId: 3,
            startDate: DateTime.Today.AddDays(2),
            endDate: DateTime.Today.AddDays(5)
        );

        _reservationService.ConfirmReservation(r3);
    }
}