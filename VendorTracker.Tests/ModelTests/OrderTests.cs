using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
    public void Dispose()
    {
      // Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
        Order newOrder = new Order("test vendor");
        Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Walk the dog.";
      //Act
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
  }
}