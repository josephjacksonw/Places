using System.Collections.Generic;

namespace Places.Models
{
    public class Location
    {
      public string Description { get; set; }
      public int Id { get; }
      // these 2 new data things need the user to input them itself, optionally
      public int Days { get; set; }
      public string Journal { get; set; }
      private static List<Location> _instances = new List<Location> { };


      public Location(string description, int days, string journal)
      {
          Description = description;
          Days = days;
          Journal = journal;
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

      public string moreDetail(int days, string journal)
      {
        Days = days;
        Journal = journal;
        return Journal;
      }
    }
}