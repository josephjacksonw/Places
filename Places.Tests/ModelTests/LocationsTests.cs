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
      Location newLocation = new Location(description);
      string result = newLocation.Description;
      Assert.AreEqual(description, result);
    }
    //----------------------------------------------

    [TestMethod]
    public void SetDescription_UpdateDescription_String()
    {
      //Arrange
      string description = "this is a test description.";
      Location newLocation = new Location(description);

      //Act
      string updatedDescription = "an updated description";
      newLocation.Description = updatedDescription;
      string result = "good fail";//newLocation.Description;

      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_LocationList()
    {
      // Arrange
      List<Location> newList = new List<Location> { };

      // Act
      List<Location> result = Location.GetAll();
      Location newLocation = new Location("so that the newList list isn't empty and good fails");

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsLocations_LocationList()
    {
      //Arrange
      string description01 = "France";
      string description02 = "Germany";
      Location newLocation1 = new Location(description01);
      Location newLocation2 = new Location(description02);
      List<Location> newList = new List<Location> { newLocation1, newLocation2 };

      //Act
      List<Location> result = Location.GetAll();
      Location newLocation3 = new Location("3rd thing so we have a good fail");
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}