using System; 
using EduGame.Api; 
using Prism.Ioc;
using Prism.Modularity;

namespace EduGame.Api
{
    public class RaptoreumWalletApiModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {  
            //containerRegistry.Register<ISocketIOService, SocketIOService>();
        }
    }
}
