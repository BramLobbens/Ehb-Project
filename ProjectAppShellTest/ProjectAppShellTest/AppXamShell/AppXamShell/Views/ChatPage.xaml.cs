using AppXamShell.Models;
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
    public partial class ChatPage : ContentPage
    {
        SignalRService signalR;
        ChatViewModel viewModel;

        public ChatPage()
        {
            InitializeComponent();

            viewModel = new ChatViewModel();
            BindingContext = viewModel;

            InitializeHandlers();
        }

        public ChatPage(ChatViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;

            InitializeHandlers();
        }

        private void InitializeHandlers()
        {
            signalR = new SignalRService();
            signalR.Connected += SignalR_ConnectionChanged;
            signalR.ConnectionFailed += SignalR_ConnectionChanged;
            signalR.NewMessageReceived += SignalR_NewMessageReceived;
        }

        #region SignalR Handlers
        void SignalR_ConnectionChanged(object sender, bool success, string message)
        {
            connectButton.Text = "Connect";
            connectButton.IsEnabled = !success;
            sendButton.IsEnabled = success;

            AddMessage($"Server connection changed: {message}");
        }

        void SignalR_NewMessageReceived(object sender, Models.MessageModel message)
        {
            string msg = $"{message.User} ({message.TimeReceived}) - {message.Message}";
            AddMessage(msg);
        }

        void AddMessage(string message)
        {
            // The AddMessage method is often called by event handlers 
            // from outside of the main UI thread, so it forces the UI updates 
            // to occur on the main thread to prevent exceptions.
            Device.BeginInvokeOnMainThread(() =>
            {
                Label label = new Label
                {
                    Text = message,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Start
                };

                messageList.Children.Add(label);
            });
        }
        #endregion

        #region Buttons
        async void ConnectButton_ClickedAsync(object sender, EventArgs e)
        {
            connectButton.Text = "Connecting...";
            connectButton.IsEnabled = false;
            await signalR.ConnectAsync();
        }

        async void SendButton_ClickedAsync(object sender, EventArgs e)
        {
            await signalR.SendMessageAsync(Constants.Username, messageEntry.Text);
            messageEntry.Text = "";
        }
        #endregion
    }
}