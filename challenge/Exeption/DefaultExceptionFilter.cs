using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using log4net;
using log4net.Config;

namespace challenge.Exeption
{
    public class DefaultExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            actionExecutedContext.Response =
                actionExecutedContext.Request.CreateResponse(HttpStatusCode.BadRequest,
                new
                {
                    error = "Could not decode request: JSON parsing failed"
                });
            ILog log = LogManager.GetLogger(typeof(DefaultExceptionFilter));
            log.Error(actionExecutedContext.Exception.Message + "\n" + actionExecutedContext.Exception.StackTrace);
        }
    }
}