namespace DataAccess.Entities;

public class UserTours : Entity
{
    public int UserId { get; set; }

    public UserEntity? User { get; set; }

    public int TourId { get; set; }

    public TourEntity? Tour { get; set; }

    public UserTourPaymentState PaymentState { get; private set; } = UserTourPaymentState.Pending;

    public DateTime PaymentUpdate { get; private set; } = DateTime.UtcNow;

    public void PaymentCompleted()
    {
        PaymentState = UserTourPaymentState.Paid;
        PaymentUpdate = DateTime.UtcNow;
    }
}

public enum UserTourPaymentState
{
    Pending,
    Paid
}
