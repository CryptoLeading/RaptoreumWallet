using Acr.UserDialogs;
using RaptoreumWallet.AppResources;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using RaptoreumWallet.Common;
using RaptoreumWallet.Common.Localizations;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using RaptoreumWallet.Views;
using Xamarin.CommunityToolkit.Effects;
using RaptoreumWallet.ViewModels;
using Prism.Behaviors;
using RaptoreumWallet.Common.Base;
using RaptoreumWallet.Controls;

namespace RaptoreumWallet
{
    public partial class App : PrismApplication, IResourceManagerProvider
    {
        const string ResourceId = "RaptoreumWallet.Resources.RaptoreumWalletResource";
        static ResourceManager _resourceManager;
        public ResourceManager ResourceManager => _resourceManager = _resourceManager ?? new ResourceManager(ResourceId, typeof(App).GetTypeInfo().Assembly);

        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer)
        {
            RaptoreumWalletResource.Culture = CultureInfo.InstalledUICulture;
        }

        protected async override void OnInitialized()
        {
            InitializeComponent();
            VersionTracking.Track();
            var result = await NavigationService.NavigateAsync(Routes.Home);
        }

        protected override void OnStart()
        {
            base.OnStart();
            // AppCenter.Start("android=ff9085a0-5b3d-427f-8003-4005cfef9339;ios=7a5ae654-4193-4e5e-9525-663f5ededef0", typeof(Analytics), typeof(Crashes)); 
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<RaptoreumWalletCommonModule>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterExternalService(containerRegistry);
            RegisterForNavigation(containerRegistry);
            RegisterService(containerRegistry);
        }

        void RegisterForNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<StartPage>();
            containerRegistry.RegisterForNavigation<GenerateAccountPage, GenerateAccountViewModel>();
            containerRegistry.RegisterForNavigation<ImportWalletPage, ImportWaleltViewModel>();
            containerRegistry.RegisterForNavigation<SetPinCodePage, SetPinCodeViewModel>();
            containerRegistry.RegisterForNavigation<ConfirmPinCodePage, ConfirmPinCodeViewModel>();
            containerRegistry.RegisterForNavigation<ReceivePage, ReceiveViewModel>();
            containerRegistry.RegisterForNavigation<SendPage, SendViewModel>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
        }

        void RegisterService(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IResourceManagerProvider>(this);
            containerRegistry.RegisterSingleton<IPageBehaviorFactory, RPageBehaviorFactory>();
            //containerRegistry.RegisterPopupNavigationService();

        }
        void RegisterExternalService(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance(UserDialogs.Instance);
        }
    }

    public sealed partial class Routes
    {
        public const string Welcome = "";
        public const string Start = nameof(StartPage);
        public const string GenerateAccount = nameof(GenerateAccountPage);
        public const string ImportWallet = nameof(ImportWalletPage);
        public const string SetPinCode = nameof(SetPinCodePage);
        public const string ConfirmPinCode = nameof(ConfirmPinCodePage);
        public const string Receive = nameof(ReceivePage);
        public const string Send = nameof(SendPage);
        public const string Home = nameof(HomePage);
    }

    public class NavigationKey
    {
        public const string ExistUser = "_MyDoctor_ExistUser_Key_";
    }
}
