using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
  [TestClass]
  public class CategoryTest
  {
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
      {
        Category newCategory = new Category("test category");
        Assert.AreEqual(typeof(Category), newCategory.GetType());
      }

      [TestMethod]
      public void GetId_ReturnsCategoryId_Int()
      {
        string name = "Test Category";
        Category newCategory = new Category(name);

        int result = newCategory.Id;

        Assert.AreEqual(1, result);
      }
  }
}