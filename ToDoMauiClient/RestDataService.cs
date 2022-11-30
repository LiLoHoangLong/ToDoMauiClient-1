//using System.Text;
//using System.Text.Json;
//using System.Diagnostics;
//using ToDoMauiClient.DataServices;
//using ToDoMauiClient.Models;
//using System.Collections;
//using System.Threading.Tasks;


//namespace ToDoMauiClient
//{
//    class RestDataService : IRestDataService
//    {
//        private readonly HttpClient _httpClient;
//        private readonly string _baseAddress;
//        private readonly string _url;
//        private readonly JsonSerializerOptions _jsonSerializerOptions;

       

//        public RestDataService()
//        {
//            _httpClient = new HttpClient();
//            _baseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5054" : "https://localhost:7178";
//            _url = $"{_baseAddress}/api";

//            _jsonSerializerOptions = new JsonSerializerOptions
//            {
//                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
//            };
//        }

//        public async Task AddToDoAsync(ToDo toDo)
//        {
//            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
//            {
//                Debug.WriteLine("---> No internet access...");
//                return;
//            }
//            try
//            {
//                string jsonToDo = JsonSerializer.Serialize<ToDo>(toDo, _jsonSerializerOptions);
//                StringContent content = new StringContent(jsonToDo, Encoding.UTF8, "application/json");

//                HttpResponseMessage response = await _httpClient.PostAsync($"{_url}/todo", content);

//                if (response.IsSuccessStatusCode)
//                {
//                    Debug.WriteLine("Successfully created ToDo");
//                }
//                else
//                {
//                    Debug.WriteLine("--->Non Http 2xx response");
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine($"Whoops exception: {ex.Message}");
//            }
//            return;
//        }
//        public async Task DeleteToDoAsync(int id)
//        {
//            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
//            {
//                Debug.WriteLine("---> No internet access...");
//                return;
//            }

//            try
//            {
//                HttpResponseMessage response = await _httpClient.DeleteAsync($"{_url}/todo{id}");


//                if (response.IsSuccessStatusCode)
//                {

//                }
//                else
//                {
//                    Debug.WriteLine("--->Non Http 2xx response");
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine($"Whoops exception: {ex.Message}");
//            }

//            return;
//        }

//        public async Task<List<ToDo>> AllToDosAsync()
//        {
//            List<ToDo> todos = new List<ToDo>();

//            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
//            {
//                Debug.WriteLine("---> No internet access...");
//                return todos;
//            }

//            try
//            {
//                HttpResponseMessage response = await _httpClient.GetAsync($"{_url}/todo");

//                if (response.IsSuccessStatusCode)
//                {
//                    response.EnsureSuccessStatusCode();
//                    string responseBody = await response.Content.ReadAsStringAsync();
//                    List<ToDo> toDos = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ToDo>>(responseBody);
//                    var model = toDos;
//                    todos = model;
//                    return todos;
//                }
//                else
//                {
//                    Debug.WriteLine("--->Non Http 2xx response");
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine($"Whoops exception: {ex.Message}");
//            }

//            return todos;
//        }

//        public Task<List<ToDo>> GettAllToDosAsync()
//        {
//            throw new NotImplementedException();
//        }

//        public async Task UpdateToDoAsync(ToDo toDo)
//        {
//            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
//            {
//                Debug.WriteLine("---> No internet access...");
//                return;
//            }
//            try
//            {
//                string jsonToDo = JsonSerializer.Serialize<ToDo>(toDo, _jsonSerializerOptions);
//                StringContent content = new StringContent(jsonToDo, Encoding.UTF8, "application/json");

//                HttpResponseMessage response = await _httpClient.PutAsync($"{_url}/todo/{toDo.Id}", content);

//                if (response.IsSuccessStatusCode)
//                {
//                    Debug.WriteLine("Successfully created ToDo");
//                }
//                else
//                {
//                    Debug.WriteLine("--->Non Http 2xx response");
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.WriteLine($"Whoops exception: {ex.Message}");
//            }
//            return;
//        }
//    }
//}