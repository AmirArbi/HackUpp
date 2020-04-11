using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Text;
using HackUpp.Models;

namespace HackUpp.Services
{
    class AdresService
    {

        public List<postVM> GetAdress()
        {
            var post = new List<postVM>
        {
            new postVM
            {
                Date = new DateTime(2019,12,27),
                Photo = ImageSource.FromResource("HackUpp.images.coronavirus.jpg"),
                Title = "COVID-19",
                Publisher = new User(){
                    PhotoProfil = ImageSource.FromResource("HackUpp.images.fekiyoussef.png"),
                    Username = "AmirElArbi",
                    Sid9 = 9
                },
                Vote = 500,
                Description = "https://www.who.int/fr/emergencies/diseases/novel-coronavirus-2019 \n" +
                "https://www.who.int/fr/emergencies/diseases/novel-coronavirus-2019/advice-for-public",
                Subtitle = "Le premier infecterpar un nouveautype de coronavirus qui apparut de nouveau dans le monde. Un grand risque d'aprés l'Organisation mondiale de santé" 
        },
            new postVM
            {
                Date = new DateTime(2020,4,10),
                Photo = ImageSource.FromResource("HackUpp.images.azaz.png"),
                Publisher = new User(){
                    PhotoProfil = ImageSource.FromResource("HackUpp.images.lajmi.png"),
                    Username = "Chalba9ElFonFon",
                    Sid9 = 7
                },
                Title = "COVID-19 Pondémie",
                Description = "https://gisanddata.maps.arcgis.com/apps/opsdashboard/index.html#/bda7594740fd40299423467b48e9ecf6" ,
                Subtitle = "Le nombre des infectées se grandisent de jour aprés jours. Aujourd'hui on eteidre 1.650.210 infectés"
            },
            new postVM
            {
                Date = new DateTime(2020,4,1),
                Photo = ImageSource.FromResource("HackUpp.images.noimage.png"),
                Publisher = new User(){
                    PhotoProfil = ImageSource.FromResource("HackUpp.images.kallel.png"),
                    Username = "MohamedKallel",
                    Sid9 = 3
                },
                Title = "L'education en Tunisie",
                Description = "https://www.facebook.com/lyceena/photos/a.535182186634738/1566759186810361/?type=3&theater" ,
                Subtitle = "Une fierté"
            },
            new postVM
            {
                Date = new DateTime(2020,3,1),
                Photo = ImageSource.FromResource("HackUpp.images.fikar.jpg"),
                Publisher = new User(){
                    PhotoProfil = ImageSource.FromResource("HackUpp.images.houssem.png"),
                    Username = "HossemAyedi",
                    Sid9 = 8
                },
                Title = "Feji3a Tounisiya!! Allah Ya7fadhna ",
                Description = "https://www.tunisienumerique.com/tunisie-bonnes-nouvelles-sur-le-premier-cas-infecte-au-coronavirus-hospitalise-a-sousse/" ,
                Subtitle = "Ta7chelna"
            },
            new postVM
            {
                Date = new DateTime(2020,3,01),
                Photo = ImageSource.FromResource("HackUpp.images.fikar.jpg"),
                Publisher = new User(){
                    PhotoProfil = ImageSource.FromResource("HackUpp.images.fekiyoussef.png"),
                    Username = "Youssef.Feki01",
                    Sid9 = 1
                },
                Title = "Endhor ila 9it yata7adath",
                Description = "https://www.tunisienumerique.com/tunisie-bonnes-nouvelles-sur-le-premier-cas-infecte-au-coronavirus-hospitalise-a-sousse/" ,
                Subtitle = "wioiiiiiiiiiiiiiiiiiiiiw"
            },
        };

            return post;
        }
    }
}
