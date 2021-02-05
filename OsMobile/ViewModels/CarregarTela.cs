using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using OsMobile.Models;

namespace OsMobile.ViewModels
{
    public class CampanhaViewModel : BaseViewModel
    {


        private ObservableCollection<GreatPlace> items;

        public ObservableCollection<GreatPlace> Places
        {
            get { return items; }
            set { SetProperty(ref items, value); }
        }

        protected override async void OnLoadCommandExecute()
        {
            var title = "xxxxxxxxxxx";

            

           

            

            this.Places = new ObservableCollection<GreatPlace>(new List<GreatPlace> {
                new GreatPlace
                {
                    Title = "Fiji Getaway",
                    Handle = "@beachcomber",
                    ViewCount = 2654,
                    HeroImage = "Fiji.jpg",
                    ProfileImage = "Person_1.jpg"
                },
                new GreatPlace
                {
                    Title = "A Hipster day out",
                    Handle = "@handlebar",
                    ViewCount = 124,
                    HeroImage = "Hipster.jpg",
                    ProfileImage = "Person_4.jpg"
                                },
                new GreatPlace
                {
                    Title = "Mediteranian Bliss",
                    Handle = "@greekdude",
                    ViewCount = 562,
                    HeroImage = "greekisland.jpg",
                    ProfileImage = "Person_5.jpg"
                },
                new GreatPlace
                {
                    Title = "Down the slopes",
                    Handle = "@skibunny",
                    ViewCount = 132,
                    HeroImage = "snow.jpg",
                    ProfileImage = "Person_2.jpg"
                                },
                new GreatPlace
                {
                    Title = "Wide open road",
                    Handle = "@vroom",
                    ViewCount = 3221,
                    HeroImage = "combi.jpg",
                    ProfileImage = "Person_3.jpg"
                                },
            });

            this.IsBusy = true;
            await Task.Delay(2500);
            this.IsBusy = false;
        }
    }
}




