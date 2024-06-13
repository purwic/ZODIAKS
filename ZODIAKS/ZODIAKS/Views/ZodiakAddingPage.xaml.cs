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
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public partial class ZodiakAddingPage : ContentPage
    {

        public string ItemId
        {
            set
            {
                LoadZodiak(value);
            }
        }

        private async void LoadZodiak(string value)
        {
            try
            {
                int id = int.Parse(value);
                Zodiak zodiak = await App.ZodiaksDB.GetZodiakAsync(id);
                BindingContext = zodiak;
            }
            catch { }
        }

        public ZodiakAddingPage()
        {
            InitializeComponent();

            BindingContext = new Zodiak();
        }

        private async void OnSaveButton_Clicked(object sender, EventArgs e)
        {
            Zodiak zodiak = (Zodiak)BindingContext;
            zodiak.Symbol = symbol.Text;
            if (!string.IsNullOrWhiteSpace(zodiak.FirstName))
            {
                await App.ZodiaksDB.SaveZodiakAsync(zodiak);
            }

            await Shell.Current.GoToAsync("..");
        }

        private async void OnDeleteButton_Clicked(object sender, EventArgs e)
        {

        }
    }
}