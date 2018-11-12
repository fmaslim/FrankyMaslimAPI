using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class TechnicalSkills
    {
        public int TechnicalSkillId { get; set; }
        public string TechnicalSkillName { get; set; }
        public int? TechnicalSkillCategoryId { get; set; }
        public int? SortOrder { get; set; }

        public TechnicalSkillCategories TechnicalSkillCategory { get; set; }

		public override string ToString()
		{
			return $"ID: { TechnicalSkillId }. Category: { TechnicalSkillCategory.TechnicalSkillCategoryName }. Skill: { TechnicalSkillName }";
		}
	}
}
