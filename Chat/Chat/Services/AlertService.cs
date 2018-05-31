using Chat.Interfaces;
using System.Threading.Tasks;

namespace Chat.Services
{
    public class AlertService : IAlertService
    {
        public async Task ShowAsync(string title, string message, string buttonOk)
        {
            await App.Current.MainPage.DisplayAlert(title, message, buttonOk);
        }

        public async Task<bool> ShowAsyncConfirm(string title, string message, string buttonOk, string buttonCancel)
        {
            bool retorno = await App.Current.MainPage.DisplayAlert(title, message, buttonOk, buttonCancel);

            return retorno;
        }
    }
}
