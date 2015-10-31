using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Red.Services
{
	public class APIHelper
	{
		public static T GetAPIResponse<T> (string apiUrl)
		{			
			try
			{				
				HttpWebRequest webRequest = System.Net.HttpWebRequest.CreateHttp(new Uri(apiUrl));
				webRequest.Method = "GET";

				using (WebResponse response = webRequest.GetResponse())
				{
					StreamReader stream = new StreamReader(response.GetResponseStream());
					T result = JsonConvert.DeserializeObject<T> (stream.ReadToEnd());
					return result;
				}
			}
			catch
			{
				return default(T);
			}
		}			
	}
}

