using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace RaptoreumWallet.Controls
{
    public class PinIndicatorView : StackLayout
    {
        public const int PinMaxLength = 6;
        public const int Size = 16;
        public static readonly BindableProperty MaxProperty = BindableProperty.Create(nameof(Max), typeof(int), typeof(PinIndicatorView), PinMaxLength);
        public int Max
        {
            get => (int)GetValue(MaxProperty);
            set => SetValue(MaxProperty, value);
        }

        public static readonly BindableProperty PinProperty = BindableProperty.Create(nameof(Pin), typeof(string), typeof(PinIndicatorView), default(string), propertyChanged: HandlePinChanged);

        private static void HandlePinChanged(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is PinIndicatorView v)
            {
                v.UpdateIndicatorColor((string)oldValue, (string)newValue);
            }
        }

        public string Pin
        {
            get => (string)GetValue(PinProperty);
            set => SetValue(PinProperty, value);
        }


        public Color UnselectedColor { set; get; } = Color.Gray;
        public Brush SelectedColor { set; get; }

        public PinIndicatorView()
        {
            Orientation = StackOrientation.Horizontal;
            Spacing = 16;
            InitUI();
        }

        void InitUI()
        {
            Children.Clear();
            int selected = string.IsNullOrWhiteSpace(Pin) ? 0 : Pin.Length;
            for (int i = 0; i < Max; i++)
            {
                if (i < selected)
                {
                    Children.Add(new BoxView { Background = SelectedColor, VerticalOptions = LayoutOptions.Center, HeightRequest = Size, WidthRequest = Size, CornerRadius = Size / 2 });
                    continue;
                }
                Children.Add(new BoxView { BackgroundColor = UnselectedColor, VerticalOptions = LayoutOptions.Center, HeightRequest = Size, WidthRequest = Size, CornerRadius = Size / 2 });
            }
        }

        void UpdateIndicatorColor(string odlVl, string newVl)
        {
            if (odlVl== null || newVl==null || Children.Count < Max - 1)
            {
                return;
            }
            int selected = string.IsNullOrWhiteSpace(newVl) ? 0 : newVl.Length;
            int oldSelected = string.IsNullOrWhiteSpace(odlVl) ? 0 : odlVl.Length;


            if (selected > oldSelected)
            {
                for (int i = oldSelected; i < selected; i++)
                {
                    Children[i].Background = SelectedColor;
                }
            }
            else
            {
                for (int i = oldSelected; i > selected; i--)
                {
                    Children[i-1].Background = null;
                    Children[i-1].BackgroundColor = UnselectedColor;
                }
            }
        }
    }
}
