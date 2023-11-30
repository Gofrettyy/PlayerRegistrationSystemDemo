using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Abstract;

public interface ISalesService
{
    public  void Sale(Sales sales,Player player,Campaigns campaigns);
    public  void Update(Sales sales);
    public  void Delete(Sales sales);
    
}