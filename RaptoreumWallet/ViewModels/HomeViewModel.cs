using RaptoreumWallet.Common.Base;
using RaptoreumWallet.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RaptoreumWallet.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public List<TransactionModel> Transactions { get; set; }
        public HomeViewModel()
        {
            Transactions = new List<TransactionModel>
            {
                new TransactionModel
                {
                    Value = 123,
                    Usd = 4,
                    Time = DateTime.Now,
                    TransactionType = TransactionType.Receive
                },
                 new TransactionModel
                {
                    Value = 123,
                    Usd = 4,
                    Time = DateTime.Now,
                    TransactionType = TransactionType.Receive
                },
                  new TransactionModel
                {
                    Value = 123,
                    Usd = 4,
                    Time = DateTime.Now,
                    TransactionType = TransactionType.Send
                }
            };
        }




        ICommand _SendCommand;
        public ICommand SendCommand => _SendCommand = _SendCommand ?? new Command(ExecuteSendCommand);
        void ExecuteSendCommand()
        {
            NavigationService.NavigateAsync(Routes.Send);
        }




        ICommand _ReceiveCommand;
        public ICommand ReceiveCommand => _ReceiveCommand = _ReceiveCommand ?? new Command(ExecuteReceiveCommand);
        void ExecuteReceiveCommand()
        {
            NavigationService.NavigateAsync(Routes.Receive);
        }




        ICommand _AddressCommand;
        public ICommand AddressCommand => _AddressCommand = _AddressCommand ?? new Command(ExecuteAddressCommand);
        void ExecuteAddressCommand()
        {
           
        }





        ICommand _SettingCommand;
        public ICommand SettingCommand => _SettingCommand = _SettingCommand ?? new Command(ExecuteSettingCommand);
        void ExecuteSettingCommand()
        { 
        }

    }
}
