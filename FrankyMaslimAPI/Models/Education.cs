using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class Education
    {
        public int EducationId { get; set; }
        public string EducationName { get; set; }
        public string CollegeName { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Notes { get; set; }

		public override string ToString()
		{
			return $"ID: { EducationId }. Major: { EducationName }. College: { CollegeName }";
		}
	}
}
