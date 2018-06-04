using Chat.Models;
using Xamarin.Forms;

namespace Chat.CustomCells
{
    public class SelectorDataTemplate : DataTemplateSelector
    {
        private readonly DataTemplate textInDataTemplate;
        private readonly DataTemplate textOutDataTemplate;

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var messageVm = item as Mensagem;
            if (messageVm == null) return null;

            if (messageVm.CHA_CVS_OGM.Equals("P")) return this.textOutDataTemplate;
            else return this.textInDataTemplate;
        }

        public SelectorDataTemplate()
        {
            this.textInDataTemplate = new DataTemplate(typeof(TextInViewCell));
            this.textOutDataTemplate = new DataTemplate(typeof(TextOutViewCell));
        }
    }
}
