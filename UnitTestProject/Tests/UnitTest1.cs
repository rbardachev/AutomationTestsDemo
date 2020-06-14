using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.PageObjects;

namespace UnitTestProject.Tests
{
    [TestClass]
    public class UnitTest1 : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            BanerNavigation navigation = new BanerNavigation(Driver);
            navigation.GoToSignInPage();
            Assert.AreEqual(Driver.Title, "Login - My Store");

        }
    }
}
