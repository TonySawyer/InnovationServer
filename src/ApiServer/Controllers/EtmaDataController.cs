namespace ApiServer.Controllers
{
    using System.Collections.Generic;
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

        [HttpGet]
        [Route("User")]
        public IActionResult GetUser()
        {
            this.logger.LogInformation("Getting user information for user <x>");
            return this.Ok(new User() { Name = "Ian Brown", Pi = "E2762956" });
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
                                                                  Name = "Mrs Tutor",
                                                                  Email = "https://msds.open.ac.uk/students/contacttutor.aspx?id=01700207&c=L192",
                                                                  Voip = "mrstutor@open.ac.uk"
                                                              },
                                           Tmas = new List<TeacherMarkedAssessment>()
                                                      {
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA01",
                                                                  Url = "https://learn2.open.ac.uk/mod/oucontent/view.php?id=764144",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA02",
                                                                  Url = "https://learn2.open.ac.uk/mod/oucontent/view.php?id=764174",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA03",
                                                                  Url = "https://learn2.open.ac.uk/mod/oucontent/view.php?id=764189",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "TMA04",
                                                                  Url = "https://learn2.open.ac.uk/mod/oucontent/view.php?id=764367",
                                                                  WordCountRequired = 250,
                                                              },
                                                          new TeacherMarkedAssessment()
                                                              {
                                                                  Title = "EMA",
                                                                  Url = "https://learn2.open.ac.uk/mod/oucontent/view.php?id=764196",
                                                                  WordCountRequired = 500,
                                                              },
                                                      }
                                       }
                               });
        }


    }
}