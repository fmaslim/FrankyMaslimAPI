using FrankyMaslimAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
			return AzureDbContext.Main.ToList();
		}

		public IList<Qualifications> GetQualificationsByMainID(int mainID)
		{
			return AzureDbContext.Qualifications.Where(item => item.MainId == mainID).ToList();
		}

		public IList<Qualifications> GetQualifications()
		{
			return AzureDbContext.Qualifications.ToList();
		}
	}
}
