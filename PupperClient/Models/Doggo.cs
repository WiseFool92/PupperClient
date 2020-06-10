using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace PupperClient.Models
{
  public class Doggo
  {
    public int DoggoId { get; set; }
    [Required]
    [StringLength(20, ErrorMessage = "Sorry this Doggos name can be longer than 20 characters")]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    public string Breed { get; set; }
    [Required]
    [Range(0, 29, ErrorMessage = "Age must be between 0 and 29")]
    public int Age { get; set; }
    public string PicUrl { get; set; }
    [Required]
    public string Gender { get; set; }

     public static List<Doggo> GetDoggos()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Doggo> doggoList = JsonConvert.DeserializeObject<List<Doggo>>(jsonResponse.ToString());

      return doggoList;
    }

    public static Doggo GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Doggo doggo = JsonConvert.DeserializeObject<Doggo>(jsonResponse.ToString());

      return doggo;
    }
  }
}