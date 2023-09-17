using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests 
{
  [TestClass]
  public class PlacesTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
    
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place somePlace = new Place("Boise");
      Assert.AreEqual(typeof(Place), somePlace.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlaceList()
    {
      string cityName1 = "Manila";
      string cityName2 = "Sofia";
      Place somePlace1 = new Place(cityName1);
      Place somePlace2 = new Place(cityName2);
      List<Place> newList = new List<Place> { somePlace1, somePlace2 };
      List<Place> result = Place.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}