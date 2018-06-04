using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Chat.Models;
using Xamarin.Forms;

namespace Chat.ViewsModels
{
    public class MainViewModel : BaseViewModel
    {
        string _outText = string.Empty;
        public string OutText
        {
            get { return _outText; }
            set { SetProperty(ref _outText, value); }
        }

        public ObservableCollection<Mensagem> ListMessages { get; }
        public ICommand SendCommand { get; set; }

        public MainViewModel()
        {
            ListMessages = new ObservableCollection<Mensagem>();
            SendCommand = new Command(SendMsg);
        }

        void SendMsg()
        {
            var message = new Mensagem
            {
                CHA_ID = 1,
                CHA_CVS_TXT = OutText,
                CHA_CVS_DTA_HOR_LOG = DateTime.Now,
                CHA_CVS_ID = 1,
            };

            if (ListMessages.Count % 2 == 0) message.CHA_CVS_OGM = "P";
            else message.CHA_CVS_OGM = "c";

            ListMessages.Add(message);
            OutText = string.Empty;
        }
    }
}
