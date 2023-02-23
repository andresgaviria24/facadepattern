using System;
using System.Xml.Linq;

namespace CalculateServices.CostService.Entity
{
	public class Services
	{
        public int IdService { get; set; }
        public string Description { get; set; }
        public decimal CostByHour { get; set; }

        public Services(int idService, string description, decimal costByHour) => (IdService, Description, CostByHour) = (idService, description, costByHour);

    }
}

