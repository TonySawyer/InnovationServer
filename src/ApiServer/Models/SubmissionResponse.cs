namespace ApiServer.Models
{
    using System;

    public class SubmissionResponse
    {
        public SubmissionResponse()
        {
            this.SubmissionId = Guid.NewGuid().ToString();
        }

        public string SubmissionId { get; set; }
    }
}