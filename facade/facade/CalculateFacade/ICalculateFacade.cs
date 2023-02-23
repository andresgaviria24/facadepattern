using System;
namespace facade
{
	public interface ICalculateFacade
	{
        string Operation(decimal hours, int typeService);
    }
}

