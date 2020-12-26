using CPS.Infrastructure.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Filters;

namespace CPS.Infrastructure.Filters
{
    public class ApiExceptionFilterAttribute : ExceptionFilterAttribute, IExceptionFilter
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            //Check the Exception Type

            if (actionExecutedContext.Exception is System.Exception)
            {
                //The Response Message Set by the Action During Ececution
                var exceptionMessage = actionExecutedContext.Exception.Message;
                var stackTrace = actionExecutedContext.Exception.StackTrace;
                var controllerName = actionExecutedContext.ActionContext.ControllerContext.RouteData.Values["controller"].ToString();
                // var actionName = actionExecutedContext.ActionContext.ControllerContext.RouteData.Values["action"].ToString();

                string Message = "Date :" + DateTime.Now.ToString() + ", Controller: " + controllerName + ", Action:" +
                                 "Error Message : " + exceptionMessage
                                + Environment.NewLine + "Stack Trace : " + stackTrace;
                //saving the data in a text file called Log.txt
                //You can also save this in a dabase
                //File.AppendAllText(HttpContext.Current.Server.MapPath("~/ErrosLogs/ErrorLog.txt"), Message);
                Logger.LogFileWrite(Message);
                var res = actionExecutedContext.Exception.Message;


                //Define the Response Message
                var resp = "{\"status\":\"Error\",\"ResultObject\":Internal Server Error Response}";  // TEST !!!!!           

                JsonSerializer ser = new JsonSerializer();
                string jsonresp = JsonConvert.SerializeObject(resp);
                HttpResponseMessage response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(resp, System.Text.Encoding.UTF8, "application/json")
                };


                //Create the Error Response

                actionExecutedContext.Response = response;
            }
        }
    }
}