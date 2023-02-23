using System;
using System.Collections.Generic;
using CalculateServices.CostService.Entity;

namespace facade
{
	public class CostService
	{

        public decimal GetCostService(int typeService)
		{
            var result = ApiCallServiceCost();
            return result.Find(c => c.IdService.Equals(typeService)).CostByHour;
        }

        private List<Services> ApiCallServiceCost() {

            List<Services> services = new List<Services>();

            services.AddRange(new List<Services>{
                new Services(1,"Fontanero",7),
                new Services(2,"Carpintero",9),
                new Services(3,"Electricista",8),
            });

            return services;
        }
	}
}

