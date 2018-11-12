using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class TechnicalSkillCategories
    {
        public TechnicalSkillCategories()
        {
            TechnicalSkills = new HashSet<TechnicalSkills>();
        }

        public int TechnicalSkillCategoryId { get; set; }
        public string TechnicalSkillCategoryName { get; set; }
        public int? SortOrder { get; set; }

        public ICollection<TechnicalSkills> TechnicalSkills { get; set; }
    }
}
