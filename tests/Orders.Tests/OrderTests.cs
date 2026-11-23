using Orders.Domain;

namespace Orders.Tests;

public class OrderTests
{
    [Fact]
    public void New_order_keeps_amount()
    {
        var order = new Order(42m);
        Assert.Equal(42m, order.Amount);
    }

    // Lab P0: deliberately wrong expectation, so the required "test" check fails.
    [Fact]
    public void New_order_rejects_negative_amount()
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Order(-1m));
    }
}
