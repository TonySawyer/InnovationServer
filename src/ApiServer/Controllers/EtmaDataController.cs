namespace ApiServer.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    using ApiServer.Models;

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

        [HttpPost]
        [Route("Submit")]
        public IActionResult SubmitTma(string data)
        {
            this.logger.LogInformation("Submitting document");
            if (!string.IsNullOrWhiteSpace(data))
            {
                this.logger.LogInformation(data);
            }

            Thread.Sleep(TimeSpan.FromSeconds(3));
            return this.Ok(new SubmissionResponse());
        }

        [HttpGet]
        [Route("User")]
        public IActionResult GetUser()
        {
            this.logger.LogInformation("Getting user information for user <x>");
            return this.Ok(new User() { Name = "Ian Brown", Pi = "A1234567" });
        }

        [HttpGet]
        [Route("Courses")]
        public IActionResult GetCourses()
        {
            this.logger.LogInformation("Getting user information for user <x>");
            return this.Ok(new List<Course>()
                               {
                                   new Course()
                                       {
                                           Code = "L192",
                                           Title = "L192 Beginners French",
                                           TutorDetails = new Contact()
                                                              {
                                                                  Name = "Mrs Barbara Tutor",
                                                                  Email = "http://python.open.ac.uk/students/contacttutor.aspx?id=01700207&c=L192",
                                                                  Voip = "mrstutor@open.ac.uk"
                                                              },
                                           Tmas = new List<TeacherMarkedAssessment>()
                                                      {
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA01",
                                                                  Url = "http://dummyousite20160426.azurewebsites.net/Home/TMA01",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA02",
                                                                  Url = "http://dummyousite20160426.azurewebsites.net/Home/TMA02",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA03",
                                                                  Url = "http://dummyousite20160426.azurewebsites.net/Home/TMA03",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA04",
                                                                  Url = "http://dummyousite20160426.azurewebsites.net/Home/TMA04",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "EMA",
                                                                  Url = "http://dummyousite20160426.azurewebsites.net/Home/EMA",
                                                                  WordCountRequired = 500,
                                                              },
                                                      }
                                       }
                               });
        }


    }
}