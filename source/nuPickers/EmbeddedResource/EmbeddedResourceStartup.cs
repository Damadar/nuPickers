﻿namespace nuPickers.EmbeddedResource
{
    using ClientDependency.Core;
    using System.Web.Routing;
    using Umbraco.Core;

    public class EmbeddedResourceStartup : ApplicationEventHandler
    {
        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            base.ApplicationStarted(umbracoApplication, applicationContext);
            RouteBuilder.BuildRoutes(RouteTable.Routes);
            FileWriters.AddWriterForExtension(".nu", new EmbeddedResourceWriter());
        }

        protected override bool ExecuteWhenApplicationNotConfigured
        {
            get { return true; }
        }
    }
}
