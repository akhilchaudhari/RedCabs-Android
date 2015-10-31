using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Red.Service
{
	public class APIHelper
	{
		public const string RedCabsAPI = "http://redcabsapi.azurewebsites.net/api/";
		public static T GetAPIResponse<T> (string apiUrl)
		{			
			try
			{				
				apiUrl = RedCabsAPI + apiUrl;
				WebRequest webRequest = System.Net.HttpWebRequest.Create(apiUrl);
				webRequest.Method = "GET";

				using (WebResponse response = webRequest.GetResponse())
				{
					StreamReader stream = new StreamReader(response.GetResponseStream());
					T result = JsonConvert.DeserializeObject<T> (stream.ReadToEnd());
					return result;
				}
			}
			catch(Exception ex)
			{
				return default(T);
			}
		}			
	}
}

