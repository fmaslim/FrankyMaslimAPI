using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class JobTitles
    {
        //public JobTitles()
        //{
        //    Experiences = new HashSet<Experiences>();
        //}

        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; }

        public ICollection<Experiences> Experiences { get; set; }

		public override string ToString()
		{
			return $"ID: { JobTitleId }. Job: { JobTitleName }";
		}
	}
}
