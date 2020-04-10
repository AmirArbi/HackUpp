using HackUpp.ViewModel;
using HackUpp.serveces;
using System;
using System.Collections.Generic;
using System.Text;

namespace HackUpp.serveces
{
    class MainViewAdress : ViewModelBase
    {
        public MainViewAdress() {
            var adress = new AdresService();

            AdressList = adress.GetAdress();
        }

        private List<postVM> adressList;

        public List<postVM> AdressList
        {
            get { return adressList; }
            set { SetProperty(ref adressList, value); }
        }

    }

    
}
