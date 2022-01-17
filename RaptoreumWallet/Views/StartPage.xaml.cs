using RaptoreumWallet.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaptoreumWallet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StartPage : ContentPage
    {
        const int BottomMinimum = 360;
        public StartPage()
        { 
            InitializeComponent();
            if (DisplayUtils.ScreenHeight >= BottomMinimum * 2)
            {
                container.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
                container.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
            }
            else
            {
                container.RowDefinitions.Add(new RowDefinition { Height = GridLength.Star });
                container.RowDefinitions.Add(new RowDefinition { Height = new GridLength(BottomMinimum) });
            }
        }
    }
}