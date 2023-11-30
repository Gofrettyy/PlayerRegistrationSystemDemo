using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Business.Abstract;

public interface ICampaignService
{
    public void Add(Campaigns campaigns);

    public void Delete(Campaigns campaigns);

    public void Update(Campaigns campaigns);
}