using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;
using WeatherForcast.WebAPI.Factory;
using WeatherForcast.WebAPI.ProcessUrl;

namespace WeatherForcast.WebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_BeginRequest()
        {
            string[] allowedOrigin = new string[] { "http://localhost:21597","http://localhost:21597" };
            var origin = HttpContext.Current.Request.Headers["Origin"];
            if (origin != null && allowedOrigin.Contains(origin))
            {
               // Response.Headers.Add("Access-Control-Allow-Origin", origin);
                Response.Headers.Add("Access-Control-Allow-Headers",
                  "Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");
                Response.Headers.Add("Access-Control-Allow-Methods", "GET, POST, PUT, DELETE, OPTIONS");
                Response.Headers.Add("Access-Control-Allow-Credentials", "true");
                
            
        }
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
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
