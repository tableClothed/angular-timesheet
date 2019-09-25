using System;

namespace TimeSheet.API.Dto
{
    public class ProjectForListDto
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int CompanyId { get; set; }
        public DateTime? ProjectStart { get; set; }
        public DateTime? Deadline { get; set; }
        public bool IsFinished { get; set; }
    }
}