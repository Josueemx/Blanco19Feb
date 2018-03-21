using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blanco19Feb.Models;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Contact_Fullname_Has_No_Name()
        {
            var c = new Contact();
            Assert.AreEqual("[No Name]", c.GetFullName());
        }

        [TestMethod]
        public void Contact_Fullname_Is_Name_And_Lastname()
        {
            var c = new Contact()
            {
                Name = "Han",
                LastName = "Solo"
            };

            Assert.AreEqual("Han Solo", c.GetFullName());
        }
    }
}
