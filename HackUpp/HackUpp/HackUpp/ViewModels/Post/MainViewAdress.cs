using HackUpp.Models;
using HackUpp.Services;
using System.Collections.Generic;

namespace HackUpp.ViewModels.Post
{
    class MainViewAdress : BaseViewModel
    {
        public MainViewAdress() {
            var adress = new AdresService();

            AdressList = adress.GetAdress();
        }

        private List<postVM> adressList;

        public List<postVM> AdressList
        {
            get { return adressList; }
            set { adressList = value; this.NotifyPropertyChanged(); }
        }

    }

    
}
