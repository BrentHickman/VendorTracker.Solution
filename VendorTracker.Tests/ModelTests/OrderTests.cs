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
  }
}