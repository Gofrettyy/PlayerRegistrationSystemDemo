using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Abstract;

public interface IPlayerCheckService
{
    bool CheckIfRealPerson(Player player);
}