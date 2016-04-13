namespace ApiServer.Models
{
    using System.Collections.Generic;

    public class Course
    {
        public string Title { get; set; }

        public string Code { get; set; }

        public Contact TutorDetails { get; set; }

        public IEnumerable<TeacherMarkedAssessment> Tmas { get; set; }
    }
}