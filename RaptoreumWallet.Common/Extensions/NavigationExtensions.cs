using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RaptoreumWallet.Common.Extensions
{
    public static class NavigationExtensions
    {
        public static async Task<INavigationResult> NavigatePopup(this INavigationService navigationService, Uri uri)
        {
            await navigationService.GoBackAsync();
            return await navigationService.NavigateAsync(uri);
        }

        public static async Task<INavigationResult> NavigatePopup(this INavigationService navigationService, Uri uri, INavigationParameters parameters)
        {
            await navigationService.GoBackAsync(parameters);
            return await navigationService.NavigateAsync(uri, parameters);
        }

        public static Task<INavigationResult> NavigateAnimatedAsync(this INavigationService navigationService, string name, INavigationParameters parameters)
        {
            return navigationService.NavigateAsync(name, parameters, true, false);
        }

        public static Task<INavigationResult> NavigateAnimatedAsync(this INavigationService navigationService, string name)
        {
            return NavigateAnimatedAsync(navigationService, name, new NavigationParameters());
        }

        public static Task<INavigationResult> NavigateAnimatedAsync(this INavigationService navigationService, Uri name, INavigationParameters parameters)
        {
            return navigationService.NavigateAsync(name, parameters, true, false);
        }

        public static Task<INavigationResult> NavigateAnimatedAsync(this INavigationService navigationService, Uri name)
        {
            return NavigateAnimatedAsync(navigationService, name, new NavigationParameters());
        }
    }
}
