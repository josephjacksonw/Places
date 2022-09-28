using System.Collections.Generic;

namespace Places.Models
{
    public class Location
    {
      public string Description { get; set; }
      public int Id { get; }
      private static List<Location> _instances = new List<Location> { };


      public Location(string description)
      {
          Description = description;
          _instances.Add(this);
          Id = _instances.Count;
      }
      public static List<Location> GetAll()
      {
          return _instances;
      }

      public static void ClearAll()
      {
          _instances.Clear();
      }
      
      public static Location Find(int searchId)
      {
          return _instances[searchId - 1];
      }
    }
}