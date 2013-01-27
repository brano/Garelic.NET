using System.Configuration;
using System.Text;

namespace System.Web.Mvc
{
    public static partial class HtmlHelpers    
    {
        public static HtmlString GoogleAnalytics(this HtmlHelper htmlHelper, string trackingId, string domainName)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<script type='text/javascript'>");
            sb.Append("  var _gaq = _gaq || [];");
            sb.Append(" _gaq.push(['_setAccount', '" + trackingId + "']);");
            sb.Append(" _gaq.push(['_setDomainName', '" + domainName + "']);");
            sb.Append(" _gaq.push(['_trackPageview']);");
            sb.Append("  (function() {");
            sb.Append("   var ga = document.createElement('script'); ga.type = 'text/javascript'; ga.async = true;");
            sb.Append("    ga.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';");
            sb.Append("   var s = document.getElementsByTagName('script')[0]; s.parentNode.insertBefore(ga, s);");
            sb.Append("  })();");
            sb.Append("</script>");

            return new HtmlString(sb.ToString());
        }

        public static HtmlString GoogleAnalytics(this HtmlHelper htmlHelper)
        {
            string urchin = ConfigurationManager.AppSettings["GA:TrackingId"];
            string domainName = ConfigurationManager.AppSettings["GA:DomainName"];
            return GoogleAnalytics(htmlHelper, urchin, domainName);
        }
    }
}