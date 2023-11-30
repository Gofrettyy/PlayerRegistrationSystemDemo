using PlayerRegistrationSystemDemo.Entities.Abstract;

namespace PlayerRegistrationSystemDemo.Entities.Concrete;

public class Player:IEntity
{
    public int PlayerId { get; set; }
    public string NationaltyId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}