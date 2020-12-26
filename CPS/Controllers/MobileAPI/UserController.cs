using CPS.Infrastructure.Helpers;
using CPS.ViewModels.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CPS.Controllers.MobileAPI
{
    public class UserController : ApiController
    {
        public HttpResponseMessage Post(UserViewModel model)
        {

            var validator = new UserViewModelValidator();

            var result = validator.Validate(model);

            if(!result.IsValid)
            {
                var errors = ValidationHelper.GetErrors(result);

                return Request.CreateResponse(HttpStatusCode.BadRequest, new CustomResponse() {

                    IsSuccess = false,
                    StatusCode = "400",
                    ResultObject = null,
                    Errors = errors
                });
            }
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
