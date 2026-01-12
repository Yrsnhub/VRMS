using VRMS.Enums;

namespace VRMS.DTOs.Rental;

public class RentalGridRow
{
    public int RentalId { get; init; }
    public DateTime PickupDate { get; init; }
    public DateTime ExpectedReturnDate { get; init; }
    public RentalStatus Status { get; init; }
    public string CustomerName { get; init; } = string.Empty;
}