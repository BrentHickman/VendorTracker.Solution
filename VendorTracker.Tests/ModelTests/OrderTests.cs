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
      Order.ClearAll();
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
      string title = "Order 1";
      //Act
      Order newOrder = new Order(title);
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Order 1";
      Order newOrder = new Order(title);
      //Act
      string updatedTitle = "Order 2";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };
      // Act
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title01 = "Order 1";
      string title02 = "Order 2";
      Order newOrder1 = new Order(title01);
      Order newOrder2 = new Order(title02);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "Order 1";
      Order newOrder = new Order(title);
      //Act
      int result = newOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
        [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "Order 1";
      string title02 = "Order 2";
      Order newOrder1 = new Order(title01);
      Order newOrder2 = new Order(title02);
      //Act
      Order result = Order.Find(2);
      //Assert
      Assert.AreEqual(newOrder2, result);
    }
  }
}