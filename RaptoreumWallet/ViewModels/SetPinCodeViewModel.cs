using RaptoreumWallet.Common.Base;
using RaptoreumWallet.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RaptoreumWallet.ViewModels
{
    public class SetPinCodeViewModel : ViewModelBase
    {
        public string Pin { get; set; } = string.Empty;
        public SetPinCodeViewModel()
        {

        }

        ICommand _SelectCommand;
        public ICommand SelectCommand => _SelectCommand = _SelectCommand ?? new Command<string>(ExecuteSelectCommand);
        void ExecuteSelectCommand(string value)
        {
            if (Pin == null)
            {
                Pin = value;
                return;
            }

            if (Pin.Length >= 6)
            {
                return;
            }

            Pin += value;
        }

        ICommand _ActionCommand;
        public ICommand ActionCommand => _ActionCommand = _ActionCommand ?? new Command<NumPadAction>(ExecuteActionCommand);
        void ExecuteActionCommand(NumPadAction action)
        {
            switch (action)
            {
                case NumPadAction.Delete:
                    if (Pin.Length == 0)
                    {
                        return;
                    }
                    Pin = Pin.Substring(0, Pin.Length - 1);
                    break;
                case NumPadAction.FingerPrint:
                    break;
            }
        }
    }
}
