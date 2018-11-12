using FrankyMaslimAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrankyMaslimAPI.Interfaces
{
	public interface IRepository
	{
		IList<Main> GetMainRecord();
		IList<Qualifications> GetQualificationsByMainID(int mainID);

		IList<Qualifications> GetQualifications();

		IList<JobTitles> GetJobTitles();
		IList<Education> GetEducation();
		IList<ExperienceDescriptions> GetExperienceDescriptions();
		IList<Experiences> GetExperiences();
		IList<ProjectDescriptions> GetProjectDescriptions();
		IList<Projects> GetProjects();
		IList<TechnicalSkillCategories> GetTechnicalSkillCategories();
		IList<TechnicalSkills> GetTechnicalSkills();
	}
}
