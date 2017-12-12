using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace TorrentRSSXMLParser
{
    class NetworkUtils
    {
        string url;
        private HttpClient client = new HttpClient();

        public NetworkUtils()
        {

        }

        public async Task<string> Get()
        {
            string body;
            HttpResponseMessage result;

            try
            {
                result = await client.GetAsync(url);

                if (result.IsSuccessStatusCode)
                {
                    body = await result.Content.ReadAsStringAsync();
                    return body;
                }
                else
                {
                    return result.StatusCode.ToString();
                }
            }
            catch (Exception e)
            {
                return e.Message;

            }

        }

        public string Url { get => url; set => url = value; }
    }
}
