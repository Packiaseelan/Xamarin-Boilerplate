﻿using Autofac;
using XamarinBoilerplate.Core.Services;
using XamarinBoilerplate.iOS.Service;

namespace XamarinBoilerplate.iOS
{
    public static class IoCiOS
    {
        public static void RegisteriOSDependencies(this ContainerBuilder builder)
        {
            // -- Add your iOS-specific injected services here.
            // builder.RegisterType<Class>().As<IInterface>().SingleInstance();
            builder.RegisterType<SampleServiceiOS>().As<ISampleService>().SingleInstance();
            builder.RegisterType<AssetServiceiOS>().As<IAssetService>().SingleInstance();
        }
    }
}
