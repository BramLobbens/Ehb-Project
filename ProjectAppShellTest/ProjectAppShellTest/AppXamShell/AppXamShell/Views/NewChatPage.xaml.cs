using AppXamShell.ViewModels;
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
    public partial class NewChatPage : ContentPage
    {
        public NewChatPage()
        {
            this.BindingContext = new TestViewModel();
            InitializeComponent();
        }
    }
}