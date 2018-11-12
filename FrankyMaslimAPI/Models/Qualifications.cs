using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class Qualifications
    {
        public int QualificationId { get; set; }
        public string Description { get; set; }
        public int? SortOrder { get; set; }

		public int MainId { get; set; }
		public Main Main { get; set; }

		public override string ToString()
		{
			return $"ID: { QualificationId }. MainID: { MainId }. Description: { Description }";
		}
	}
}
