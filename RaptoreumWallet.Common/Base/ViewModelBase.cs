using Acr.UserDialogs;
using Prism.AppModel;
using Prism.Ioc;
using Prism.Mvvm;
using Prism.Navigation;
using RaptoreumWallet.Common.Localizations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.CommunityToolkit.ObjectModel;
using Xamarin.Forms;

namespace RaptoreumWallet.Common.Base
{
    public interface IHasNavigationService
    {
        INavigationService NavigationService { get; }
    }
    public class ViewModelBase : BindableBase, INavigationAware, IPageLifecycleAware, IInitialize, IDestructible, IInitializeAsync, IHasNavigationService
    {
        public INavigationService NavigationService => _navigation;

        INavigationService _navigation;
        IUserDialogs _userDialogs;
        public ViewModelBase(/*IEventAggregator eventAggregator*/)
        {
            var container = (Application.Current as Prism.DryIoc.PrismApplication).Container;
            _navigation = container.Resolve<INavigationService>();
            _userDialogs = container.Resolve<IUserDialogs>();
        }

        public virtual string L(string resourceKey, params string[] objects)
        {
            return LocalizedResourceHelper.GetText(resourceKey, objects);
        }


        ICommand _CloseCommand;
        public virtual ICommand CloseCommand => _CloseCommand = _CloseCommand ?? new AsyncCommand(ExecuteCloseCommand);
        public async virtual Task ExecuteCloseCommand()
        {
            var result = await NavigationService.GoBackAsync(new NavigationParameters(), useModalNavigation: true, animated: false);
        }

        public virtual bool IsBusy { set; get; }

        public void OnIsBusyChanged()
        {
            if (IsBusy)
            {
                ShowLoading();
            }
            else
            {
                HideLoading();
            }
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }
        public virtual async void Toast(string message)
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Task.Delay(10);
            }
            _userDialogs.Toast(message);
        }

        public virtual void ShowLoading()
        {
            _userDialogs.ShowLoading("", MaskType.Gradient);
        }

        public async void HideLoading()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                await Task.Delay(100);
            }
            Device.BeginInvokeOnMainThread(() => _userDialogs.HideLoading());
        }


        public virtual void Destroy()
        {
        }

        public virtual void OnAppearing()
        {
        }

        public virtual void OnDisappearing()
        {
        } 
    }
}
