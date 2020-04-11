using HackUpp.Models;
using HackUpp.Services;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using System;
using System.Diagnostics;

namespace HackUpp.ViewModels.Post
{
    class MainViewAdress : BaseViewModel
    {
        public MainViewAdress() {
            var adress = new AdresService();
            
            AdressList = adress.GetAdress();
            VoteUp = new Command<postVM>((model) => {
                AdressList[AdressList.IndexOf(model)].Vote++;
                AdressList.Add(new postVM
                {
                    Date = new DateTime(2019, 12, 27),
                    Photo = ImageSource.FromResource("HackUpp.images.coronavirus.jpg"),
                    Title = "COVID-18",
                    Publisher = new User()
                    {
                        PhotoProfil = ImageSource.FromResource("HackUpp.images.fekiyoussef.png"),
                        Username = "AmirElArbi",
                        Sid9 = 9
                    },
                    Vote = 500,
                    Description = "https://www.who.int/fr/emergencies/diseases/novel-coronavirus-2019 \n" +
                "https://www.who.int/fr/emergencies/diseases/novel-coronavirus-2019/advice-for-public",
                    Subtitle = "Le premier infecterpar un nouveautype de coronavirus qui apparut de nouveau dans le monde. Un grand risque d'aprés l'Organisation mondiale de santé"
                });
                AdressList = AdressList;
            });
            VoteDown = new Command<postVM>((model) => {
                AdressList[AdressList.IndexOf(model)].Vote--;
            });
        }

        private List<postVM> adressList;

        public List<postVM> AdressList
        {
            get { return adressList; }
            set { adressList = value; NotifyPropertyChanged(); }
        }
        public ICommand VoteUp { get; set; }
        public ICommand VoteDown { get; set; }
    }


}
