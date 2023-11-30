

using PlayerRegistrationSystemDemo.Adaptors;
using PlayerRegistrationSystemDemo.Business.Concrete;
using PlayerRegistrationSystemDemo.Entities.Concrete;

PlayerManager playerManager = new PlayerManager(new MernisServiceAdaptor());
playerManager.Add((new Player{DateOfBirth = new DateTime(1998,06,16),
    FirstName = "Umut",LastName = "Elmas",
    NationaltyId = "232343243"}));