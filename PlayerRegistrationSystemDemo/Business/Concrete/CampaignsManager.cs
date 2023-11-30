using PlayerRegistrationSystemDemo.Business.Abstract;
using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Concrete;

public class CampaignsManager:ICampaignService
{
    public void Add(Campaigns campaigns)
    {
        Console.WriteLine("Kampanya eklendi");
    }

    public void Delete(Campaigns campaigns)
    {
       Console.WriteLine("Kampanya Silindi");
    }

    public void Update(Campaigns campaigns)
    {
       Console.WriteLine("Kampanya Güncellendi");
    }
}