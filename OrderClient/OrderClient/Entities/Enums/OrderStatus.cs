namespace OrderClient.Entities.Enums
{
    enum OrderStatus : int
    {
        Peding_Payment,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
