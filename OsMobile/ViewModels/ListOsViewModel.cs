
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using OsMobile.Models;
using Xamarin.Forms;

namespace OsMobile.ViewModels
{
    public class ListOsViewModel : BaseViewModel
    {
        private ObservableCollection<OrdemServico> ordems;
        public Command LoadItemsCommand { get; set; }

        public ObservableCollection<OrdemServico> ListaOs
        {
            get { return ordems; }
            set { SetProperty(ref ordems, value); }
        }

        public ListOsViewModel()
        {

            ListaOs = new ObservableCollection<OrdemServico>();


            LoadItemsCommand = new Command(async () => await OnLoadCommandExecute1());
        }

        protected override async void OnLoadCommandExecute()
        {
            this.ListaOs = new ObservableCollection<OrdemServico>(new List<OrdemServico> {
                new OrdemServico
                {
                    Id = 1,
                    CodigoOS = "NP2923",
                    Nome = "Eric Ceola",
                    Marca = "Apple",
                    Modelo = "IPhone 6",
                    numeroCelular = "(11) 98388-8983"
                },
                 new OrdemServico
                {
                    Id = 2,
                    CodigoOS = "NP2924",
                    Nome = "Thais Silva Queiroz",
                    Marca = "Apple",
                    Modelo = "IPhone XS MAX",
                    numeroCelular = "(11) 98388-8983"
                },
                  new OrdemServico
                {
                    Id = 3,
                    CodigoOS = "NP2925",
                    Nome = "Eder Ceola",
                    Marca = "Motorola",
                    Modelo = "G6 Play",
                    numeroCelular = "(11) 98388-8983"
                },
                   new OrdemServico
                {
                    Id = 4,
                    CodigoOS = "NP2926",
                    Nome = "Keli Ceola",
                    Marca = "Apple",
                    Modelo = "iPhone 11 Pro ",
                    numeroCelular = "(11) 98388-8983"
                },
                    new OrdemServico
                {
                    Id = 5,
                    CodigoOS = "NP2927",
                    Nome = "Larissa Montagna",
                    Marca = "Apple",
                    Modelo = "iPhone 6",
                    numeroCelular = "(11) 98388-8983"
                }

            });

            this.IsBusy = true;
            await Task.Delay(2500);
            this.IsBusy = false;
        }


            async Task OnLoadCommandExecute1()
        {
            var title = "xxxxxxxxxxx";



            this.ListaOs = new ObservableCollection<OrdemServico>(new List<OrdemServico> {
                new OrdemServico
                {
                    Id = 1,
                    CodigoOS = "NP2923",
                    Nome = "Eric Ceola",
                    Marca = "Apple",
                    Modelo = "IPhone 6",
                    numeroCelular = "(11) 98388-8983"
                },
                 new OrdemServico
                {
                    Id = 2,
                    CodigoOS = "NP2924",
                    Nome = "Thais Silva Queiroz",
                    Marca = "Apple",
                    Modelo = "IPhone XS MAX",
                    numeroCelular = "(11) 98388-8983"
                },
                  new OrdemServico
                {
                    Id = 3,
                    CodigoOS = "NP2925",
                    Nome = "Eder Ceola",
                    Marca = "Motorola",
                    Modelo = "G6 Play",
                    numeroCelular = "(11) 98388-8983"
                },
                   new OrdemServico
                {
                    Id = 4,
                    CodigoOS = "NP2926",
                    Nome = "Keli Ceola",
                    Marca = "Apple",
                    Modelo = "iPhone 11 Pro ",
                    numeroCelular = "(11) 98388-8983"
                },
                    new OrdemServico
                {
                    Id = 5,
                    CodigoOS = "NP2927",
                    Nome = "Larissa Montagna",
                    Marca = "Apple",
                    Modelo = "iPhone 6",
                    numeroCelular = "(11) 98388-8983"
                }

            });

            this.IsBusy = true;
            await Task.Delay(2500);
            this.IsBusy = false;
        }
    }
}
