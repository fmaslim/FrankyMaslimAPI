using FrankyMaslimAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FrankyMaslimAPI.Models
{
	public class Repository : IRepository
	{
		private FrankyMaslimContext _azureDbContext;
		public FrankyMaslimContext AzureDbContext
		{
			get
			{
				return _azureDbContext;
			}
			private set
			{
				_azureDbContext = value;
			}
		}
		public Repository(FrankyMaslimContext azureDbContext)
		{
			AzureDbContext = azureDbContext;
		}

		public IList<Main> GetMainRecord()
		{
			return AzureDbContext.Main.Include(x => x.Qualifications).ToList();
		}

		public IList<Qualifications> GetQualificationsByMainID(int mainID)
		{
			return AzureDbContext.Qualifications.Where(item => item.MainId == mainID).ToList();
		}

		public IList<Qualifications> GetQualifications()
		{
			return AzureDbContext.Qualifications.Include(x => x.Main).ToList();
		}

		public IList<JobTitles> GetJobTitles()
		{
			return AzureDbContext.JobTitles.Include(x => x.Experiences).ToList();
		}

		public IList<Education> GetEducation()
		{
			return AzureDbContext.Education.ToList();
		}

		public IList<ExperienceDescriptions> GetExperienceDescriptions()
		{
			return AzureDbContext.ExperienceDescriptions.Include(x => x.Experience).ToList();
		}

		public IList<Experiences> GetExperiences()
		{
			return AzureDbContext.Experiences.Include(x => x.ExperienceDescriptions).ToList();
		}

		public IList<ProjectDescriptions> GetProjectDescriptions()
		{
			return AzureDbContext.ProjectDescriptions.ToList();
		}

		public IList<Projects> GetProjects()
		{
			return AzureDbContext.Projects.Include(x => x.ProjectDescriptions).ToList();
		}

		public IList<TechnicalSkillCategories> GetTechnicalSkillCategories()
		{
			return AzureDbContext.TechnicalSkillCategories.Include(x => x.TechnicalSkills).ToList();
		}

		public IList<TechnicalSkills> GetTechnicalSkills()
		{
			return AzureDbContext.TechnicalSkills.Include(x => x.TechnicalSkillCategory).ToList();
		}
	}
}
