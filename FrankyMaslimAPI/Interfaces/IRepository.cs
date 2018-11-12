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
		IList<Qualifications> GetQualificiationsByMainID(int mainID);
	}
}
