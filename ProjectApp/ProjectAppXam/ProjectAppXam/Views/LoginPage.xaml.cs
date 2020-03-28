using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjectAppXam.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public string clientId { get; set; } = "750992037042-o6v8t098a6r1ik7tt3tpinsg117240be.apps.googleusercontent.com";
        public LoginPage()
        {
            InitializeComponent();

            //var authenticator = new OAuth2Authenticator(
            //                            clientId,
            //                            Constants.Scope,
            //                            new Uri(Constants.AuthorizeUrl),
            //                            new Uri(redirectUri),
            //                            true
            //                            );

            //authenticator.Completed += OnAuthCompleted;
        }

        void OnAuthCompleted(object sender, EventArgs eventArgs)
        {
            //
        }
    }
}