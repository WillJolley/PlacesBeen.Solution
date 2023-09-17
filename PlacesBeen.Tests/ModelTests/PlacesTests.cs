using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests 
{
  [TestClass]
  public class PlacesTests
  {
    [TestMethod]
    public void PlaceConstructor_CreatesInstanceOfPlace_Place()
    {
      Place somePlace = new Place();
      Assert.AreEqual(typeof(Place), somePlace.GetType());
    }
  }
}