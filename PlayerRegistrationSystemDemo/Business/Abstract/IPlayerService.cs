using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Abstract;

public interface IPlayerService
{
  
   public void Add(Player player);
   
   public void Update(Player player);
    
   public void Delete(Player player);
    
    

}