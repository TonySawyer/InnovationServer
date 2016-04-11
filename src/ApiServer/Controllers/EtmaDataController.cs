namespace ApiServer.Controllers
{
    using System.Collections.Generic;

    using Microsoft.AspNet.Mvc;
    using Microsoft.Extensions.Logging;

    [Route("api/[controller]")]
    public class EtmaDataController : Controller
    {
        private readonly ILogger<EtmaDataController> logger;

        public EtmaDataController(ILogger<EtmaDataController> logger)
        {
            this.logger = logger;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            this.logger.LogInformation("Getting information for user <x>");
            return new string[] { "value1", "value2" };
        }
    }
}