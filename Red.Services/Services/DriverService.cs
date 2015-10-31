using System;
using UnitOfWorkApplication.Model.Entities;
using System.Collections.Generic;

namespace Red.Services.Services
{
	public class DriverService
	{
		public const string RedCabsAPI = "http://redcabsapi.azurewebsites.net/api/";

		public List<Driver> GetDrivers()
		{
			string apiUrl = RedCabsAPI + "Driver";
			var drivers = APIHelper.GetAPIResponse<List<Driver>> (apiUrl);
			return drivers;
		}
	}
}

