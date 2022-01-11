using System;
using System.ComponentModel;
using System.Resources;
using Prism.Ioc;
using Prism.Modularity;
using RaptoreumWallet.Common.Localizations;

namespace RaptoreumWallet.Common
{
    public class RaptoreumWalletCommonModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        { 
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<ILocalizedResourceProvider, LocalizedResourceProvider>(); 
        } 
    }
}
