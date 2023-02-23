using System;
namespace facade
{
	public class CalculateFacade: ICalculateFacade
    {
        //protected Trm _trm;

        /*protected CostService _costService;

        public Facade(Trm trm,CostService costService)
		{
			this._trm = trm;
			this._costService = costService;
		}


        public double Operation(double hours)
        {
            double resultCal = _trm.GetTrm() * (_costService.GetCostService(1)* hours);

            return resultCal;
        }*/

        public string Operation(decimal hours, int typeService)
        {
            
            Trm _trm = new Trm();
            CostService _costService = new CostService();

            decimal operationA = _trm.GetTrm();
            decimal operationB = _costService.GetCostService(typeService);

            decimal resultCal = operationA * (operationB * hours);

            string formattedNumber = resultCal.ToString("0.000");

            return formattedNumber;
        }

    }
}

