using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SearchEngine.Controllers;

namespace SearchEngine.Tests
{
    [TestClass]
    public class HomeControllerUnitTest
    {
        [TestMethod]
        public void TestPositiveSearchResults()
        {
            try
            {
                var controller = new HomeController();
                var results = controller.PerformSearchResults(new Models.SearchCriteria("Testing", "News"));
                Assert.IsTrue(results != null);
            }
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void TestNegativeSearchResults()
        {
            try
            {
                var controller = new HomeController();
                var results = controller.PerformSearchResults(new Models.SearchCriteria("", ""));
                Assert.IsTrue(results == null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod]
        public void TestNullSearchResults()
        {
            try
            {
                var controller = new HomeController();
                var results = controller.PerformSearchResults(null);
                Assert.IsTrue(results == null);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
