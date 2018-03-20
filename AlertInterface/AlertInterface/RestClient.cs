using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpRestClient
{

    public enum HttpVerb
    {
        Get,
        Post,
        Put,
        Delete
    }
    class RestClient
    {
        public string endPoint { get; set; }
        public HttpVerb httpMethod { get; set; }

        public RestClient()
        {
            endPoint = String.Empty;
            httpMethod = HttpVerb.Get;
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    throw new ApplicationException("error code: " + response.StatusCode.ToString());

                }
                //Process the response stream... (could be JSON, XML or HTML etc...)

                using (Stream responseStream = response.GetResponseStream())
                {

                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }//End of Streamreader
                    }

                }//End of using ResponseStream

            }//End of using response

                return strResponseValue;
        }

    }
}
