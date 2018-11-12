using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class ProjectDescriptions
    {
        public int ProjectDescriptionId { get; set; }
        public string ProjectDescriptionName { get; set; }
        public int ProjectId { get; set; }
        public int? SortOrder { get; set; }

        public Projects Project { get; set; }
    }
}
