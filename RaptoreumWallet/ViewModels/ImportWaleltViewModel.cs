using RaptoreumWallet.Common.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RaptoreumWallet.ViewModels
{
    public class ImportWaleltViewModel : ViewModelBase
    {
        public bool UseMnemoic { get; set; } = true;
        public ImportWaleltViewModel()
        {

        }

        ICommand _ChangeTypeCommand;
        public ICommand ChangeTypeCommand => _ChangeTypeCommand = _ChangeTypeCommand ?? new Command(ExecuteChangeTypeCommand);
        void ExecuteChangeTypeCommand()
        {
            UseMnemoic = !UseMnemoic;
        }
    }
}