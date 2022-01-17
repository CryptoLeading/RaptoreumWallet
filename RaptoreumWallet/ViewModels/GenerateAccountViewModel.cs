using RaptoreumWallet.Common.Base;
using RaptoreumWallet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Internals;

namespace RaptoreumWallet.ViewModels
{
    public class GenerateAccountViewModel : ViewModelBase
    {
        public List<WordModel> Words { set; get; }

        public GenerateAccountViewModel()
        {
            var mn = "clinic rail harsh vicious connect vault roof surprise toe blame slot kid";
            var arr = mn.Split(' ');
            var ws = arr.Select(d => new WordModel { Word = d, Index = arr.IndexOf(d) + 1 });
            Words = new List<WordModel>(ws);
        }
    }
}
