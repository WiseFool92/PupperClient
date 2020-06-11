using System.Threading.Tasks;
using RestSharp;

namespace PupperClient.Models
{
  class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5005/api");
      RestRequest request = new RestRequest($"doggo", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5005/api");
      RestRequest request = new RestRequest($"doggo/{id}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }

    public static async Task Post(string newDoggo)
    {
      RestClient client = new RestClient("http://localhost:5005/api");
      RestRequest request = new RestRequest($"doggo", Method.POST);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDoggo);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Put(int id, string newDoggo)
    {
      RestClient client = new RestClient("http://localhost:5005/api");
      RestRequest request = new RestRequest($"doggo/{id}", Method.PUT);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDoggo);
      var response = await client.ExecuteTaskAsync(request);
    }

    public static async Task Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5005/api");
      RestRequest request = new RestRequest($"doggo/{id}", Method.DELETE);
      request.AddHeader("Content-Type", "application/json");
      var response = await client.ExecuteTaskAsync(request);
    }
  }
}