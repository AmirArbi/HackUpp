using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HackUpp.ViewModel
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected bool SetProperty<T>(ref T storage, T value, [CallerMomberName] string propertyName = null)
        {
            if (Object.Equals(storage, value)) return false;
            
            storage = value;
            OnPropertyChanged(propertyName);
            return true;

        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
