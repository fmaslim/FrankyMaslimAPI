using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class Projects
    {
        public Projects()
        {
            ProjectDescriptions = new HashSet<ProjectDescriptions>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Url { get; set; }
        public int? SortOrder { get; set; }

        public ICollection<ProjectDescriptions> ProjectDescriptions { get; set; }
		public override string ToString()
		{
			return $"ID: { ProjectId }. Name: { ProjectName }";
		}
	}
}
