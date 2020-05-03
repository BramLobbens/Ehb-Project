using AppXamShell.Services;
using AppXamShell.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppXamShell
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public bool DataHasChanged { get; set; }
        public AppShell()
        {
            InitializeComponent();
        }

        // extra event functionality to check if will use
        //protected override void OnNavigating(ShellNavigatingEventArgs args)
        //{
        //    base.OnNavigating(args);

        //    // Cancel back navigation if data is unsaved
        //    if (args.Source == ShellNavigationSource.Pop && DataHasChanged)
        //    {
        //        args.Cancel();
        //    }
        //}

        //protected override void OnNavigated(ShellNavigatedEventArgs args)
        //{
        //    base.OnNavigated(args);

        //    //if (ThisUser.NotLoggedIn)
        //    //{
        //    //    //someting
        //    //}
        //    MockDataStore ds = new MockDataStore();
        //    if (!ds.GetLoggedStatus())
        //    {
        //        Navigation.PushModalAsync(new NavigationPage(new TestPage()));
        //    }
        //}

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            FlyoutIsPresented = false;
            DisplayAlert("Clicked", "You clicked a menu item.", "Ok");
        }
    }
}
