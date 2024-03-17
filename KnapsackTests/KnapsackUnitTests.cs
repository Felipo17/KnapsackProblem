using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using KnapsackProblem;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace KnapsackUnitTests
{
    //Test na sprawdzenie sytuacji, gdzie co najmniej jeden przedmiot spe³nia ograniczenia
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestAtLeastOneItemFits()
        {
            //Arange
            List<Item> items = new List<Item>
            {
                new Item(1, 4, 6), //id, value, weight
                new Item(2, 7, 8),
                new Item(3, 10, 7)
            };
            int capacity = 6;

            //Act
            Problem problem = new Problem(items.Count, 0, items);
            var result = problem.Solve(capacity);

            //Assert
            Assert.IsTrue(result.ItemsId.Count > 0);
        }
        //Test na sprawdzenie, czy jeœli nic nie spe³nia ograniczeñ to czy zwrócono puste rozwi¹zanie
        [TestMethod]
        public void TestNoItemFits()
        {
            //Arrange
            List<Item> items = new List<Item>
            {
                new Item(1, 7, 9), //id, value, weight
                new Item(2, 4, 10),
                new Item(3, 6, 8)
            };
            int capacity = 6;

            //Act
            Problem problem = new Problem(items.Count, 0, items);
            var result = problem.Solve(capacity);

            //Assert
            CollectionAssert.AreEqual(new List<int>(), result.ItemsId);
        }
        //Test na sprawdzenie wp³ywu kolejnoœci przedmiotów
        [TestMethod]
        public void TestOrderOfItemsChanges()
        {
            List<Item> itemsOrder1 = new List<Item>
            {
                new Item(1, 5, 5), //id, value, weight
                new Item(2, 4, 4),
                new Item(3, 3, 3)
            };

            List<Item> itemsOrder2 = new List<Item>(itemsOrder1);
            itemsOrder2.Reverse();

            int capacity = 10;

            Problem problemOrder1 = new Problem(itemsOrder1.Count, 0, itemsOrder1);
            var resultOrder1 = problemOrder1.Solve(capacity);

            Problem problemOrder2 = new Problem(itemsOrder2.Count, 0, itemsOrder2);
            var resultOrder2 = problemOrder2.Solve(capacity);

            Assert.AreEqual(resultOrder1.ValueSum, resultOrder2.ValueSum);
            Assert.AreEqual(resultOrder1.WeightSum, resultOrder2.WeightSum);
        }
        [TestMethod]
        public void TestSpecificInstance()
        {
            List<Item> items = new List<Item>
            {
                new Item(1, 5, 8), //id, value, weight
                new Item(2, 1, 9),
                new Item(3, 7 ,5),
                new Item(4, 9, 1),
                new Item(5, 2, 7),
                new Item(6, 3, 4),
                new Item(7, 5, 8),
                new Item(8, 4, 5),
                new Item(9, 6, 1),
                new Item(10, 2, 6)
            };
            int capacity = 15;
            var expectedReuslts = new Result(new List<int> { 4, 9, 3, 8 }, 26, 12);

            Problem problem = new Problem(items.Count, 0, items);
            var result = problem.Solve(capacity);

            Assert.AreEqual(expectedReuslts.ToString(), result.ToString());
        }
        //Test na sprawdzenie oczywistego warunku, czy metoda Solve zawsze znajdzie rozwi¹zanie o maksymalnej mo¿liwej wartoœci.
        [TestMethod]
        public void TestMaximumValue()
        {
            List<Item> items = new List<Item>
            {
                new Item(1, 10, 2), //id, value, weight
                new Item(2, 20, 3),
                new Item(3, 19, 3)
            };
            int capacity = 5;
            var expectedValue = 30;

            Problem problem = new Problem(items.Count, 0, items);
            var result = problem.Solve(capacity);

            Assert.AreEqual(expectedValue, result.ValueSum);

        }
        //Test na sprawdzenie braku pojemnoœci w plecaku
        [TestMethod]
        public void TestEmptyKnapsack()
        {
            List<Item> items = new List<Item>
            {
                new Item(1, 13, 4), //id, value, weight
                new Item(2, 6, 9),
                new Item(3, 10, 6)
            };
            int capacity = 0;
            Problem problem = new Problem(items.Count, 0, items);
            var result = problem.Solve(capacity);

            Assert.AreEqual(0, result.ValueSum);
            Assert.AreEqual(0, result.WeightSum);
            Assert.AreEqual(0, result.ItemsId.Count);
        }
    }
}