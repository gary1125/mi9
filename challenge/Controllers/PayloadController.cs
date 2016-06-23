using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using challenge.Exeption;
using challenge.Models;
using log4net;
using Newtonsoft.Json.Linq;

namespace challenge.Controllers
{
    public class PayloadController : ApiController
    {
        // POST api/values        
        [DefaultExceptionFilter]
        public HttpResponseMessage Post(JObject jPayloadSummary)
        {
            ILog log = LogManager.GetLogger(typeof(PayloadController));
            log.Info(jPayloadSummary.ToString());
            PayloadSummary payloadSummary = jPayloadSummary.ToObject<PayloadSummary>();
            if (payloadSummary.Payload != null)
            {
                var value = payloadSummary.Payload.Where(x => x.Drm && x.EpisodeCount > 0)
                    .Select(x => new ResponsePayload
                    {
                        Image = x.Image.ShowImage,
                        Slug = x.Slug,
                        Title = x.Title
                    });
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    response = value.ToList()
                });
            }
            return Request.CreateResponse(HttpStatusCode.OK, new
            {
                response = ""
            });
        }
    }
}