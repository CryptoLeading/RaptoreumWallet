using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RaptoreumWallet.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UnderlineButton : Grid
    {
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(UnderlineButton), default(ICommand));
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(Text), typeof(string), typeof(UnderlineButton), default(string));
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public UnderlineButton()
        {
            InitializeComponent();
            lblText.SetBinding(Label.TextProperty, new Binding(nameof(Text), source: this));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (Command?.CanExecute(null) == true)
            {
                Command.Execute(null);
            }
        }
    }
}