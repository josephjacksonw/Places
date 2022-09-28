using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Places.Models;
using System;

namespace Places.TestTools
{
  [TestClass]
  public class LocationsTests
  {
    [TestMethod]
    public void LocationConstructor_CreatesAClass_Location()
    {
      Location newLocation = new Location("France");
      Assert.AreEqual(typeof(Location), newLocation.GetType());
    }

    [TestMethod]
    public void GetDescription_RetrievesDescription_String()
    {
      string description = "this is a test description";
      Location newLocation = new Location("good fail");
      string result = newLocation.Description;
      Assert.AreEqual(description, result);
    }
  }
}