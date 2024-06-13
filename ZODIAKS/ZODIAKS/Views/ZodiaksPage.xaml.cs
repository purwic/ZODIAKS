using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZODIAKS.Models;

namespace ZODIAKS.Views
{
    public partial class ZodiaksPage : ContentPage
    {
        public ZodiaksPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            collectionView.ItemsSource = await App.ZodiaksDB.GetZodiaksAsync();

            base.OnAppearing();
        }

        private async void AddButton_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ZodiakAddingPage));
        }

        private async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection != null)
            {
                Zodiak zodiak = (Zodiak)e.CurrentSelection.FirstOrDefault();
                await Shell.Current.GoToAsync(
                    $"{nameof(ZodiakAddingPage)}?{nameof(ZodiakAddingPage.ItemId)}={zodiak.ID.ToString()}");
                }
            }
        }
    }
}