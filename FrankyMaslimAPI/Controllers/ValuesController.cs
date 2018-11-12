using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FrankyMaslimAPI.Interfaces;
using FrankyMaslimAPI.Models;
using Microsoft.AspNetCore.Mvc;

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
		public ValuesController(IRepository repo)
		{
			Repo = repo;
		}

		// GET api/values
		[Route("api/Values")]
		[HttpGet]
		public ActionResult<IEnumerable<string>> Get()
		{
			return new string[] { "value1", "value2" };
		}

		[Route("api/Values/{name}")]
		[HttpGet]
		public ActionResult Get(string name)
		{
			var mainObject = Repo.GetMainRecord();
			//mainObject.ToList().ForEach(item => item.Qualifications = Repo.GetQualificiationsByMainID(item.MainId));

			return Ok(mainObject);
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
