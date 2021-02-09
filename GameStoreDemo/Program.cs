using GameStoreDemo.Abstract;
using GameStoreDemo.Adapters;
using GameStoreDemo.Concrete;
using GameStoreDemo.Entities;
using System;

namespace GameStoreDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Gereksinimler:
             * Oyun satış yönetimi için bir sistem geliştirme
             
              1.Oyuncuların sisteme kayıt olabileceği, bilgilerini güncelleyebileceği, kayıtlarını silebileceği bir ortamı simule ediniz. 
             Müşteri bilgilerinin doğruluğunu e-devlet sistemlerini kullanarak doğrulama yapmak istiyoruz. 
             (E-devlet sistemlerinde doğrulama TcNo, Ad, Soyad, DoğumYılı bilgileriyle yapılır. Bunu yapacak servisi simule etmeniz yeterlidir.)

              2.Oyun satışı yapılabilecek satış ortamını simule ediniz.(Yapılan satışlar oyuncu ile ilişkilendirilmelidir. Oyuncunun parametre olarak metotta olması)

              3.Sisteme yeni kampanya girişi, kampanyanın silinmesi ve güncellenmesi imkanlarını simule ediniz.

              4.Satışlarda kampanya entegrasyonunu simule ediniz.

            */

            BasePlayerManager playerManager = new SteamPlayerManager(new MernisServiceAdapter());
            //playerManager.Register(new Player() { DateOfBirth = new DateTime(1997, 1, 5).Year, PlayerId = 0, FirstName = "İrem", LastName = "Çalışkan", NationalityId = 12345678912 });
            // correct NationalityId is working!

            BasePlayerManager playerManager1 = new EpicGamesPlayerManager();
            playerManager1.Register(new Player() { DateOfBirth = new DateTime(2000, 1, 5).Year, PlayerId = 0, FirstName = "Sinan", LastName = "Fen", NationalityId = 12345678912 });
            playerManager1.UpdateInformation(new Player() { DateOfBirth = new DateTime(2000, 1, 5).Year, PlayerId = 0, FirstName = "Sinan", LastName = "Fen", NationalityId = 12345678912});
            playerManager1.DeleteAccount(new Player() { DateOfBirth = new DateTime(2000, 1, 5).Year, PlayerId = 0, FirstName = "Sinan", LastName = "Fen", NationalityId = 12345678912 });

            Player player1 = new Player()
            {
                PlayerId = 1,
                FirstName = "Mert ",
                LastName = "Celil",
                DateOfBirth = new DateTime(1996,11,16).Year,
                NationalityId = 1234567891

            };

            Game game1 = new Game()
            {
                GameId = 0,
                Name = "Knight Online",
                Price = 50
            };

            Campaign campaign1 = new Campaign()
            {
                CampaignId = 0,
                Name = "Huge discount on the weekend",
                Discount = 50
            };

            Sale sale1 = new Sale()
            {
                SaleId = 0,
                GameName = "Knight Online",
                PlayerName = "Mert"
            };


            GameManager gameManager = new GameManager();
            gameManager.Save(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            SaleManager saleManager = new SaleManager();
            saleManager.DiscountSend(player1,game1,campaign1);
            saleManager.Sale(player1,game1,campaign1);

        }
    }
}
