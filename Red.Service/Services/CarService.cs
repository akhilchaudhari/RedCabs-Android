using System;
using UnitOfWorkApplication.Model.Entities;
using System.Collections.Generic;

namespace Red.Service
{
	public class CarService
	{
		public List<Driver> GetCars()
		{
			var drivers = APIHelper.GetAPIResponse<List<Driver>> ("Driver");
			return drivers;
		}
	}
}

