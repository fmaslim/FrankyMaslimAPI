using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class ExperienceDescriptions
    {
        public int ExperienceDescriptionId { get; set; }
        public int ExperienceId { get; set; }
        public string Description { get; set; }
        public string SortOrder { get; set; }

        public Experiences Experience { get; set; }
    }
}
