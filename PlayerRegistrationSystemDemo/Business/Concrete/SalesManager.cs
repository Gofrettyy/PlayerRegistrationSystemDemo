using PlayerRegistrationSystemDemo.Business.Abstract;
using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Concrete;

public class SalesManager:ISalesService
{
    public void Sale(Sales sales, Player player, Campaigns campaigns)
    {
       Console.WriteLine($"{sales.GameName} oyunu {player.FirstName} {player.LastName} müşterisine {campaigns.CampaignName} kampanyasıyla yüzde {campaigns.Rate} indirim oranı ile {sales.Price-(sales.Price * (campaigns.Rate/100))} tlye satıldı."   );
    }
    
    public void Update(Sales sales)
    {
       Console.WriteLine("Satış güncellendi");
    }

    public void Delete(Sales sales)
    {
      Console.WriteLine("Satış silindi");
    }
}