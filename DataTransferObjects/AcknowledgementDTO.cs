using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;

namespace WebApplication1.DataTransferObjects
{
    public class AcknowledgementDTO
    {
        public HttpStatusCode Status = HttpStatusCode.OK;
        public IList<String> Errors { get; } = new List<String>();
        public IList<String> Messages { get; } = new List<String>();
        public RandomNumberDTO RandomNumber { get; set; } = new RandomNumberDTO();
    }
}