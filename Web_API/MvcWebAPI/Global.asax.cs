using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Microsoft.Practices.Unity;
using MvcWebAPI.Models;
using MvcWebAPI.ProcessUrl;
using MvcWebAPI.Factory;

namespace MvcWebAPI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            UnityContainer _unity = new UnityContainer();
            _unity.RegisterType<Iweather, clsForcast>();
            _unity.RegisterType<Iweather, clsTimeMachine>();
            //_unity.RegisterType<IProcessData, clsJsonToObject>();
            
            clsProcessData _clsProcessData = _unity.Resolve<clsProcessData>();
            clsWeatherFactory iwaether = _unity.Resolve<clsWeatherFactory>();
           // _unity.Resolve<Iweather, clsTimeMachine>();
        }
    }
}