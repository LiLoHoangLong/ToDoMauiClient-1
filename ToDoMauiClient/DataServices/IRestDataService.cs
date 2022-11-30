using System.Collections;
using ToDoMauiClient.Models;


namespace ToDoMauiClient.DataServices
{
    public interface IRestDataService
    //{
    //    Task<List<ToDo>> AllToDosAsync();

    //    Task<List<ToDo>> GettAllToDosAsync();
    //    Task AddToDoAsync(ToDo toDo);
    //    Task UpdateToDoAsync(ToDo toDo);
    //    Task DeleteToDoAsync(int id);
    //}
    {
        Task<UserInfo> Login(string Email, string Password);
    }
}
