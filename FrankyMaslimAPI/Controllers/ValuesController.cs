using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FrankyMaslimAPI.Interfaces;
using FrankyMaslimAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FrankyMaslimAPI.Controllers
{
	//[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private IRepository _repo;
		public IRepository Repo
		{
			get
			{
				return _repo;
			}
			private set
			{
				_repo = value;
			}
		}

		readonly ILogger<ValuesController> _log;

		public ValuesController(IRepository repo, ILogger<ValuesController> log)
		{
			Repo = repo;
			_log = log;
		}

		// GET api/values
		[Route("api/Values")]
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		[Route("api/Values/{id}")]
		[HttpGet]
		public ActionResult Get(int id)
		{
			try
			{
				var mainObject = Repo.GetMainRecord();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Main object");
				return Ok(mainObject);
			}
			catch(Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest(ex.Message);
			}
		}

		[Route("api/Values/Qualifications")]
		[HttpGet]
		public ActionResult GetQualifications()
		{
			try
			{
				var q = Repo.GetQualifications();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Qualifications"); ;
				return Ok(q);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest(ex.Message);
			}
		}

		[Route("api/Values/JobTitles")]
		[HttpGet]
		public ActionResult GetJobTitles()
		{
			try
			{
				var titles = Repo.GetJobTitles();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Job Titles");
				return Ok(titles);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Job Titles");
			}
			
		}

		[Route("api/Values/Education")]
		[HttpGet]
		public ActionResult GetEducation()
		{
			try
			{
				var education = Repo.GetEducation();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Education");
				return Ok(education);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Education");
			}
		}

		[Route("api/Values/ExperienceDescriptions")]
		[HttpGet]
		public ActionResult GetExperienceDescriptions()
		{
			try
			{
				var descriptions = Repo.GetExperienceDescriptions();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Experience Descriptions");
				return Ok(descriptions);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Experience Descriptions");
			}
		}

		[Route("api/Values/Experiences")]
		[HttpGet]
		public ActionResult GetExperiences()
		{
			try
			{
				var experiences = Repo.GetExperiences();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Experiences");
				return Ok(experiences);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Experiences");
			}
		}

		[Route("api/Values/ProjectDescriptions")]
		[HttpGet]
		public ActionResult GetProjectDescriptions()
		{
			try
			{
				var projectDescriptions = Repo.GetProjectDescriptions();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Project Descriptions");
				return Ok(projectDescriptions);
			}
			catch(Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Project Descriptions");
			}
		}

		[Route("api/Values/Projects")]
		[HttpGet]
		public ActionResult GetProjects()
		{
			try
			{
				var projects = Repo.GetProjects();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Projects");
				return Ok(projects);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Projects");
			}
		}

		[Route("api/Values/TechnicalSkillCategories")]
		[HttpGet]
		public ActionResult GetTechnicalSkillCategories()
		{
			try
			{
				var categories = Repo.GetTechnicalSkillCategories();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Technical Skill Categories");
				return Ok(categories);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Technical Skill Categories");
			}
		}

		[Route("api/Values/TechnicalSkills")]
		[HttpGet]
		public ActionResult GetTechnicalSkills()
		{
			try
			{
				var skills = Repo.GetTechnicalSkills();
				_log.LogCustomInfo(LoggingType.Information, "Successfully retrieved Technical Skills");
				return Ok(skills);
			}
			catch (Exception ex)
			{
				_log.LogCustomInfo(LoggingType.Error, ex);
				return BadRequest("An error occurred retrieving Technical Skills");
			}
		}

		// GET api/values/5
		//[Route("api/Values/{id}")]
		//[HttpGet("{id}")]
		//public ActionResult<string> Get(int id)
		//{
		//	return "value";
		//}

		// POST api/values
		[Route("api/Values")]
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[Route("api/Values")]
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[Route("api/Values")]
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
