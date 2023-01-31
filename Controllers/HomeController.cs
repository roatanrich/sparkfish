using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System;
using WebApplication1.DataTransferObjects;
using WebApplication1.Common;
using System.Net;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }

        [HttpGet("/listify")]
        public AcknowledgementDTO Get(int start, int end, int desiredIndex)
        {
            AcknowledgementDTO result = new AcknowledgementDTO();

            logger.LogInformation("Executing GET");

            try
            {
                IList<int> list = new SparkfishList(start, end);
                result.RandomNumber.SomeValue = list[desiredIndex];
                result.Messages.Add($"Given the input values of [{start}], [{end}] and [{desiredIndex}], the result is {result.RandomNumber.SomeValue}");
            }
            catch (Exception e)
            {
                result.Errors.Add(e.Message);
                result.Messages.Add($"Given the input values of [{start}], [{end}] and [{desiredIndex}], an error occurred, please try again");
                result.Status = HttpStatusCode.BadRequest;
            }

            return result;
        }
    }
}