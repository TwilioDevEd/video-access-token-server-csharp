using System.Configuration;
using System.Web.Mvc;
using Twilio.Auth;
using Faker;

namespace VideoQuickstart.Controllers
{
    public class TokenController : Controller
    {
        // GET: /token
        public ActionResult Index()
        {
            // Load Twilio configuration from Web.config
            var accountSid = ConfigurationManager.AppSettings["TwilioAccountSid"];
            var apiKey = ConfigurationManager.AppSettings["TwilioApiKey"];
            var apiSecret = ConfigurationManager.AppSettings["TwilioApiSecret"];
            var videoConfigSid = ConfigurationManager.AppSettings["TwilioConfigurationSid"];

            // Create a random identity for the client
            var identity = Internet.UserName();

            // Create an Access Token generator
            var token = new AccessToken(accountSid, apiKey, apiSecret);
            token.Identity = identity;

            // Create a video grant for this token
            var grant = new VideoGrant();
            grant.ConfigurationProfileSid = videoConfigSid;
            token.AddGrant(grant);

            return Json(new
            {
                identity,
                token = token.ToJWT()
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
