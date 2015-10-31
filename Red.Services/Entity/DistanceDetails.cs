﻿using System;
using System.Collections.Generic;

namespace Red.Services
{
	public class DistanceDetails
	{
		public string status { get; set; }
		public List<string> origin_addresses { get; set; }
		public List<string> destination_addresses { get; set; }
		public List<Row> rows { get; set; }

	}

	public class Duration
	{
		public int value { get; set; }
		public string text { get; set; }
	}

	public class Distance
	{
		public int value { get; set; }
		public string text { get; set; }
	}

	public class Element
	{
		public string status { get; set; }
		public Duration duration { get; set; }
		public Distance distance { get; set; }
	}

	public class Row
	{
		public List<Element> elements { get; set; }
	}		
}

