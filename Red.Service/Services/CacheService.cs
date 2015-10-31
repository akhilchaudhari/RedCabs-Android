using System;
using UnitOfWorkApplication.Model.Entities;
using System.Collections.Generic;

namespace Red.Service
{
	public class CacheService
	{
		private List<CarType> carType = new List<CarType>();

		public List<CarType> GetCarTypes()
		{
			if (this.carType.Count == 0) 
			{
				carType = APIHelper.GetAPIResponse<List<CarType>> ("CarType");
			}
			return carType;
		}
	}
}

