using System; 
using Prism;
using Prism.Ioc;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaptoreumWallet.Common.Localizations
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension<string>
    {
        public string Text { get; set; }

        object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider)
        {
            return ProvideValue(serviceProvider);
        }
         
        public string ProvideValue(IServiceProvider serviceProvider)
        { 
            if (string.IsNullOrWhiteSpace(Text))
            {
                return string.Empty;
            } 
           var container = (Application.Current as PrismApplicationBase).Container;
            var resource = container.Resolve<IResourceManagerProvider>(); 
            return LocalizedResourceHelper.GetText(resource.ResourceManager, Text);
        }
    }
}
