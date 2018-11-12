using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class Experiences
    {
        public Experiences()
        {
            ExperienceDescriptions = new HashSet<ExperienceDescriptions>();
        }

        public int ExperienceId { get; set; }
        public int JobTitleId { get; set; }
        public string WorkplaceName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int? SortOrder { get; set; }

        public JobTitles JobTitle { get; set; }
        public ICollection<ExperienceDescriptions> ExperienceDescriptions { get; set; }

		public override string ToString()
		{
			return $"ID: { ExperienceId }. Workplace: { WorkplaceName }";
		}

	}
}
