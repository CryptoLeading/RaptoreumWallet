using SkiaSharp;
using SkiaSharp.QrCode;
using System;
using System.Collections.Generic;
using System.Drawing; 
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaptoreumWallet.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReceivePage : ContentPage
    {
        public ReceivePage()
        {
            InitializeComponent();
            try
            {
                using (var generator = new QRCodeGenerator())
                {
                    // Generate QrCode
                    var qr = generator.CreateQrCode("binh do", ECCLevel.L); 
                }
            }
            catch(Exception ex)
            {

            }
        }
    }
}