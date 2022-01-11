using System;
using System.Resources;

namespace RaptoreumWallet.Common.Localizations
{
    public interface IResourceManagerProvider
    { 
        ResourceManager ResourceManager { get; } 
    }

    //public class ResourceManagerProvider : IResourceManagerProvider
    //{
    //    public ResourceManager ResourceManager { get => throw new NotImplementedException(); }
    //}
}
