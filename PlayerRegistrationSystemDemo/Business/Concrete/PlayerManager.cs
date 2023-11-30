using PlayerRegistrationSystemDemo.Business.Abstract;
using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Concrete;

public class PlayerManager:IPlayerService 
{
    private IPlayerCheckService _playerCheckService;

    public PlayerManager(IPlayerCheckService playerCheckService)
    {
        _playerCheckService = playerCheckService;
    }
    public  void  Add(Player player)
    {
        if (_playerCheckService.CheckIfRealPerson(player))
        {
            Console.WriteLine("Oyuncu Eklendi");
        }
        else
        {
            Console.WriteLine("Oyuncu Bilgileri Hatalı");

        }
   
        
    
    }

    public void Update(Player player)
    {
        Console.WriteLine("Player Updated ");
    }

    public void Delete(Player player)
    {
        Console.WriteLine("Player Deleted");
    }
}