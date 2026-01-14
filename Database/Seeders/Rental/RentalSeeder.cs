using VRMS.Database.Seeders;
using VRMS.Enums;
using VRMS.Services.Rental;

namespace VRMS.Database.Seeders.Rental;

public class RentalSeeder : ISeeder
{
    public string Name => nameof(RentalSeeder);

    private readonly RentalService _rentalService;

    public RentalSeeder(RentalService rentalService)
    {
        _rentalService = rentalService;
    }

    public void Run()
    {
        // ----------------------------
        // Rental from confirmed reservation
        // ----------------------------

        var rentalId = _rentalService.StartRentalFromReservation(
            reservationId: 1,
            pickupDate: DateTime.Today.AddDays(1),
            startFuelLevel: FuelLevel.Full
        );

        // Complete it normally
        _rentalService.CompleteRental(
            rentalId,
            actualReturnDate: DateTime.Today.AddDays(4),
            endOdometer: 33500,
            endFuelLevel: FuelLevel.Half
        );

        // ----------------------------
        // Walk-in rental (active)
        // ----------------------------

        _rentalService.StartWalkInRental(
            customerId: 2,
            vehicleId: 4,
            pickupDate: DateTime.Today,
            expectedReturnDate: DateTime.Today.AddDays(3),
            startFuelLevel: FuelLevel.Full
        );
    }
}