using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using HackUpp.ViewModel;

namespace instagram.serveces
{
    class AdresService
    {

        public List<postVM> GetAdress()
        {
            var post = new List<postVM>
        {
            new postVM
            {
                Date = "27/12/2019",
                ImageSourc = ImageSource.FromResource("HackUpp.images.coronavirus.jpg"),
                PhotoProfil = ImageSource.FromResource("HackUpp.images.fekiyoussef.png"),
                Title = "COVID-19",
                UserName = "AmirElarbi",
                sid9 = 9,
                Description = "https://www.who.int/fr/emergencies/diseases/novel-coronavirus-2019" +
                "https://www.who.int/fr/emergencies/diseases/novel-coronavirus-2019/advice-for-public",
                Subtitle = "Le premier infecterpar un nouveautype de coronavirus qui apparut de nouveau dans le monde. Un grand risque d'aprés l'Organisation mondiale de santé" 
        },
            new postVM
            {
                Date = "10/04/2020",
                ImageSourc = ImageSource.FromResource("HackUpp.images.azaz.png"),
                PhotoProfil = ImageSource.FromResource("HackUpp.images.lajmi.png"),
                Title = "COVID-19 Pondémie",
                sid9 = 7,
                UserName = "Chalba9ElFonFon",
                Description = "https://gisanddata.maps.arcgis.com/apps/opsdashboard/index.html#/bda7594740fd40299423467b48e9ecf6" ,
                Subtitle = "Le nombre des infectées se grandisent de jour aprés jours. Aujourd'hui on eteidre 1.650.210 infectés"
            },
            new postVM
            {
                Date = "01/04/2020",
                ImageSourc = ImageSource.FromResource("HackUpp.images.fekiyoussef.png"),
                PhotoProfil = ImageSource.FromResource("HackUpp.images.kallel.png"),
                sid9 = 3,
                Title = "L'education en Tunisie",
                UserName = "MohamedKallel",
                Description = "https://www.facebook.com/lyceena/photos/a.535182186634738/1566759186810361/?type=3&theater" ,
                Subtitle = "Une fierté"
            },
            new postVM
            {
                Date = "01/03/2020",
                ImageSourc = ImageSource.FromResource("HackUpp.images.fikar.jpg"),
                PhotoProfil = ImageSource.FromResource("HackUpp.images.houssem.png"),
                Title = "Feji3a Tounisiya!! Allah Ya7fadhna",
                sid9 = 8,
                UserName = "HossemAyedi",
                Description = "https://www.tunisienumerique.com/tunisie-bonnes-nouvelles-sur-le-premier-cas-infecte-au-coronavirus-hospitalise-a-sousse/" ,
                Subtitle = "Ta7chelna"
            },
            new postVM
            {
                Date = "01/03/2020",
                ImageSourc = ImageSource.FromResource("HackUpp.images.fikar.jpg"),
                PhotoProfil = ImageSource.FromResource("HackUpp.images.fekiyoussef.png"),
                Title = "Endhor ila 9it yata7adath",
                sid9 = 1,
                UserName = "Youssef.Feki01",
                Description = "https://www.tunisienumerique.com/tunisie-bonnes-nouvelles-sur-le-premier-cas-infecte-au-coronavirus-hospitalise-a-sousse/" ,
                Subtitle = "wioiiiiiiiiiiiiiiiiiiiiw"
            },
        };

            return post;
        }
    }
}
