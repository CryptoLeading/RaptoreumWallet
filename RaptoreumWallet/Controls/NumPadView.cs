using RaptoreumWallet.Common.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RaptoreumWallet.Controls
{
    public enum NumPadAction
    {
        Delete, FingerPrint
    }

    public class NumPadView : Grid
    {
        public const int Size = 48;
        public static readonly BindableProperty CommandProperty = BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(NumPadView), default(ICommand));
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        public static readonly BindableProperty ActionCommandProperty = BindableProperty.Create(nameof(ActionCommand), typeof(ICommand), typeof(NumPadView), default(ICommand));
        public ICommand ActionCommand
        {
            get => (ICommand)GetValue(ActionCommandProperty);
            set => SetValue(ActionCommandProperty, value);
        }

        public static readonly BindableProperty HasFingerPrintProperty = BindableProperty.Create(nameof(HasFingerPrint), typeof(bool), typeof(NumPadView), default(bool), propertyChanged: Init);

        private static void Init(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is NumPadView v)
            {
                v.ChangeFinger();
            }
        }

        public bool HasFingerPrint
        {
            get => (bool)GetValue(HasFingerPrintProperty);
            set => SetValue(HasFingerPrintProperty, value);
        }


        TapGestureRecognizer tap;
        public NumPadView()
        {
            tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            InitUI();
            ColumnSpacing = 12;
            RowSpacing = 12;
        }

        private void Tap_Tapped(object sender, EventArgs e)
        {
            if (sender is NumView nv)
            {
                StartAnim(nv, nv.Num);
                if (Command?.CanExecute(nv.Num) == true)
                {
                    Command.Execute(nv.Num);
                }
                return;
            }
            if (sender is ActionNumView nav)
            {
                StartAnim(nav, "num" + nav.Action);
                if (ActionCommand?.CanExecute(nav.Action) == true)
                {
                    ActionCommand.Execute(nav.Action);
                }
                return;
            }
        }
        const int NUM_COL = 3;
        const int NUM_ROW = 4;
        void InitUI()
        {
            RowDefinitions.Clear();
            ColumnDefinitions.Clear();

            RowDefinitions = new RowDefinitionCollection { new RowDefinition { Height = new GridLength(Size) }, new RowDefinition { Height = new GridLength(Size) }, new RowDefinition { Height = new GridLength(Size) }, new RowDefinition { Height = new GridLength(Size) } };
            ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition { Width = new GridLength(Size) }, new ColumnDefinition { Width = new GridLength(Size) }, new ColumnDefinition { Width = new GridLength(Size) } };
            Children.Clear();
            for (int i = 0; i < NUM_ROW - 1; i++)
            {
                for (int j = 0; j < NUM_COL; j++)
                {
                    var v = new NumView((j * NUM_COL + i + 1).ToString());
                    v.GestureRecognizers.Add(tap);
                    Children.Add(v, i, j);
                    continue;
                }
            }
            var num0 = new NumView("0");
            num0.GestureRecognizers.Add(tap);
            Children.Add(num0, 1, 3);
            ActionNumView delete = new ActionNumView(NumPadAction.Delete);
            delete.GestureRecognizers.Add(tap);
            Children.Add(delete, 2, 3);

            ActionNumView finger = new ActionNumView(NumPadAction.FingerPrint);
            finger.GestureRecognizers.Add(tap);
            finger.IsVisible = HasFingerPrint;
            Children.Add(finger, 0, 3);
        }

        void ChangeFinger()
        {
            var fing = Children.FirstOrDefault(d => d is ActionNumView v && v.Action == NumPadAction.FingerPrint);
            if (fing == null)
            {
                return;
            }
            fing.IsVisible = HasFingerPrint;
        }

        static Color BlendColors(Color from, Color to, double ratio)
        {
            double inverseRatio = 1d - ratio;
            double r = to.R * ratio + from.R * inverseRatio;
            double g = to.G * ratio + from.G * inverseRatio;
            double b = to.B * ratio + from.B * inverseRatio;
            return Color.FromRgb(r, g, b);
        }

        public static void StartAnim(View v, string name)
        {
            Animation anim = new Animation((d) => v.BackgroundColor = NumPadView.BlendColors(Colors.OrangeColor, Colors.SurfaceColor, d), 0, 1);
            anim.Commit(v, name, 16, 250);
        }
    }

    public class NumView : Frame
    {
        public string Num { get; set; }
        public NumView(string text)
        {
            Num = text;
            Padding = new Thickness(0);
            Content = new Label
            {
                Text = text,
                Style = LabelStyles.NormalLabel,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;
            HeightRequest = NumPadView.Size;
            WidthRequest = NumPadView.Size;
            CornerRadius = NumPadView.Size / 2;
        }
        public void StartAnim()
        {
            Animation anim = new Animation((d) => this.BackgroundColor = Color.FromRgba(d, d, d, 1), 0, 1);
            anim.Commit(this, Num, 16, 250);
        }
    }

    public class ActionNumView : Frame
    {
        public NumPadAction Action { get; private set; }
        public ActionNumView(NumPadAction _action)
        {
            Action = _action;
            Padding = new Thickness(0);
            Content = new Image
            {
                Source = _action == NumPadAction.Delete ? "ic_backspace" : "ic_fingerprint",
                Margin = new Thickness(12)
            }; HorizontalOptions = LayoutOptions.Center;
            VerticalOptions = LayoutOptions.Center;
            HeightRequest = NumPadView.Size;
            WidthRequest = NumPadView.Size;
            CornerRadius = NumPadView.Size / 2;
        }
    }
}
