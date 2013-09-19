using log4net;

using Umbraco.Core;

namespace umbracoLatest.App_Start
{
    public class DocumentEvents : Umbraco.Core.ApplicationEventHandler
    {
        private readonly ILog _logger = LogManager.GetLogger(typeof(DocumentEvents));

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication, ApplicationContext applicationContext)
        {
            log4net.Config.XmlConfigurator.Configure();
            _logger.Fatal("ApplicationStarted");
        }
    }
}