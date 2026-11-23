namespace Orders.Domain;

/// <summary>An order. Its amount can never be negative.</summary>
public sealed class Order
{
    public Guid Id { get; } = Guid.NewGuid();
    public decimal Amount { get; }

    public Order(decimal amount)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(amount);
        Amount = amount;
    }
}
