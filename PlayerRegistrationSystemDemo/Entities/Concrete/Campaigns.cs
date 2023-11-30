using PlayerRegistrationSystemDemo.Entities.Abstract;

namespace PlayerRegistrationSystemDemo.Entities.Concrete;

public class Campaigns:IEntity
{
    public int CampaignId { get; set; }
    public string CampaignName { get; set; }
    public double Rate { get; set; }

}