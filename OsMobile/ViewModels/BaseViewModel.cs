using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using OsMobile.Models;
using OsMobile.Services;
using Prism.Mvvm;
using Xamarin.Forms;

namespace OsMobile.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public IDataStore<OrdemServico> DataStore => DependencyService.Get<IDataStore<OrdemServico>>();
        bool isBusy = false;

        public bool IsBusy
        {
            get { return isBusy; }
            set { SetProperty(ref isBusy, value); }
        }

      public ICommand LoadCommand => new Command(OnLoadCommandExecute);

       protected abstract void OnLoadCommandExecute();

        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


    }
}
