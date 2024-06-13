using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ZODIAKS.Views;

namespace ZODIAKS
{
    public partial class AppShel : Shell
    {
        public AppShel()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ZodiakAddingPage), typeof(ZodiakAddingPage));
        }
    }
}