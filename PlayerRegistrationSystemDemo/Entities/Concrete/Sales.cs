using PlayerRegistrationSystemDemo.Entities.Abstract;

namespace PlayerRegistrationSystemDemo.Entities.Concrete;

public class Sales:IEntity
{
    public int SalesId { get; set; }
    public string GameName { get; set; }
    public double Price { get; set; }
}