using System;
using System.Collections.Generic;
using UnitOfWorkApplication.Model.Entities;

namespace Red.Service
{
	public class DriverService
	{		
		public List<Driver> GetDrivers()
		{
			var drivers = APIHelper.GetAPIResponse<List<Driver>> ("Driver");
			return drivers;
		}

		public List<Driver> GetDriversByCarType(CarType carType)
		{
			var drivers = APIHelper.GetAPIResponse<List<Driver>> ("Driver/GetDriversByCarType/?" + "carType=" + carType.Type);
			return drivers;
		}
	}
}

