using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoMauiClient.Models;

namespace ToDoMauiClient.DataServices
{
    public class IRestLoginService : IRestDataService
    {
        public async Task<UserInfo> Login(string UserName, string Password)
        {
            var UserInfo = new List<UserInfo>();
            var client = new HttpClient();

            string url = "http://10.0.2.2:5054/api/login/" + UserName + "/" + Password;
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode) 
            {
                string content = response.Content.ReadAsStringAsync().Result;
                
                UserInfo = JsonConvert.DeserializeObject<List<UserInfo>>(content);
                
                return

            }

        }
    }
}
