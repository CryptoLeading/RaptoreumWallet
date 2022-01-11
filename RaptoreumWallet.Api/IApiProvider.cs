﻿using System;
using System.Net.Http;
using EduGame.Api; 
using Prism.DryIoc;
using Prism.Ioc;
using RaptoreumWallet.Api.Utils;
using Refit;
using Xamarin.Forms;

namespace RaptoreumWallet.Api
{
    public interface IApiProvider<T>
    {
        T Api { get; }
    }

    public abstract class ApiProvider<T> : IApiProvider<T>
    {
        public T Api { get; private set; }

        public ApiProvider(RefitSettings setting)
        {
            Api = RestService.For<T>(ApiBase.ServerApi, setting);
        }

        public ApiProvider()
        {
            Api = RestService.For<T>(new HttpClient(new HttpTracer.HttpTracerHandler()) { BaseAddress = new Uri(ApiBase.ServerApi) }, RefitSetting.SnakeCaseNaming);
        }
    }

    //public class AuthApiProvider<T> : IApiProvider<T>
    //{
    //    public T Api { get; private set; }

    //    public AuthApiProvider(IAuthHeaderManager authHeader, RefitSettings setting)
    //    {
    //        Api = RestService.For<T>(new HttpClient(new AuthenticatedHttpClientHandler(() => authHeader.GetBearerToken())) { BaseAddress = new Uri(ApiBase.ServerApi) ,MaxResponseContentBufferSize = 1024 * 1024 * 1024 }, setting);
    //    }

    //    public AuthApiProvider(IAuthHeaderManager authHeader)
    //    {
    //        Api = RestService.For<T>(new HttpClient(new AuthenticatedHttpClientHandler(() => authHeader.GetBearerToken())) { BaseAddress = new Uri(ApiBase.ServerApi), MaxResponseContentBufferSize = 1024 * 1024 * 1024 }, RefitSetting.SnakeCaseNaming);
    //    }

    //    public AuthApiProvider() : this((Application.Current as PrismApplication).Container.Resolve<IAuthHeaderManager>())
    //    {

    //    }
    //}
}