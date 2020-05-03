using AppXamShell.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXamShell.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        public bool loggedIn { get; set; }
        public TestPage()
        {
            InitializeComponent();

            var ds = new MockDataStore();
            loggedIn = ds.GetLoggedStatus();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!loggedIn)
            {
                var ds = new MockDataStore();
                ds.SetLoggedStatus(true);
                Navigation.PopModalAsync();
            }
        }
    }
}