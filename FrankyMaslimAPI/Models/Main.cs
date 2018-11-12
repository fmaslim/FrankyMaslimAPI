using System;
using System.Collections.Generic;

namespace FrankyMaslimAPI.Models
{
    public partial class Main
    {
        public Main()
        {
            Qualifications = new HashSet<Qualifications>();
        }

        public int MainId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Objective { get; set; }

        public ICollection<Qualifications> Qualifications { get; set; }

		public override string ToString()
		{
			return $"ID: { MainId }. Name: { FirstName + ' ' + LastName }. Objective: { Objective }";
		}
	}
}
