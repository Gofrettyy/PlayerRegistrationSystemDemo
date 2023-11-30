using PlayerRegistrationSystemDemo.Business.Abstract;
using PlayerRegistrationSystemDemo.Entities.Concrete;

namespace PlayerRegistrationSystemDemo.Adaptors;

public class MernisServiceAdaptor:IPlayerCheckService
{
    public bool CheckIfRealPerson(Player player)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient();
        return client.TcKimlikNoDoğrula(Convert.ToInt64((player.NationaltyId),
            player.FirstName.ToUpper(), player.LastNameToUpper(), player.DateOfBirth));
    }
}