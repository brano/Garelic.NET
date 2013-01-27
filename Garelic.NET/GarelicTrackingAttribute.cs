using System;
using System.Text;
using System.Web.Mvc;

namespace Garelic.NET
{
    public class GarelicTrackingAttribute : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            string controllerName = actionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = actionDescriptor.ActionName;
            string timeStamp = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            string routeId = filterContext.RouteData.Values["id"] != null ? filterContext.RouteData.Values["id"].ToString() : string.Empty;

            StringBuilder message = new StringBuilder();
            message.Append("Controller=");
            message.Append(controllerName + "|");
            message.Append("Action=");
            message.Append(actionName + "|");

            if (!string.IsNullOrEmpty(routeId))
            {
                message.Append("Route=");
                message.Append(routeId + "|");
            }

            message.Append("Date=");
            message.Append(timeStamp);

            //System.Diagnostics.Debug.WriteLine(message.ToString());

            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionDescriptor = filterContext.ActionDescriptor;
            string controllerName = actionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = actionDescriptor.ActionName;
            string timeStamp = string.Format("{0:yyyy-MM-dd HH:mm:ss}", DateTime.Now);
            string routeId = filterContext.RouteData.Values["id"] != null ? filterContext.RouteData.Values["id"].ToString() : string.Empty;

            StringBuilder message = new StringBuilder();
            message.Append("Controller=");
            message.Append(controllerName + "|");
            message.Append("Action=");
            message.Append(actionName + "|");

            if (!string.IsNullOrEmpty(routeId))
            {
                message.Append("Route=");
                message.Append(routeId + "|");
            }

            message.Append("Date=");
            message.Append(timeStamp);

            //System.Diagnostics.Debug.WriteLine(message.ToString());

            base.OnActionExecuted(filterContext);
        }
    }
}