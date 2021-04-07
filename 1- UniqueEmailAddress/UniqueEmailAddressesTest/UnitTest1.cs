using Microsoft.VisualStudio.TestTools.UnitTesting;
using UniqueEmailAddress;

namespace UniqueEmailAddressesTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRemovePeriods()
        {
            string[] emails = new string[] { "first.m.last@somewhere.com", "firstmlast@somewhere.com", "first.mlast@somewhere.com" };
            var eh = new EmailHelper();
            var result = eh.NumberOfUniqueEmailAddresses(emails);
            var expectedUniqueNum = 1;

            Assert.AreEqual(expectedUniqueNum, result);
        }

        [TestMethod]
        public void TestIgnoreAfterPlus()
        {
            string[] emails = new string[] { "team1+bob@somewhere.com", "team1+jill+bob@somewhere.com" };
            var eh = new EmailHelper();
            var result = eh.NumberOfUniqueEmailAddresses(emails);
            var expectedUniqueNum = 1;

            Assert.AreEqual(expectedUniqueNum, result);
        }

        [TestMethod]
        public void TestSameNameDifferentDomain()
        {
            string[] emails = new string[] { "team2@somewhere.com", "team2@some.where.com" };
            var eh = new EmailHelper();
            var result = eh.NumberOfUniqueEmailAddresses(emails);
            var expectedUniqueNum = 2;

            Assert.AreEqual(expectedUniqueNum, result);
        }

        [TestMethod]
        public void TestEmptyArray()
        {
            string[] emails = new string[] { };
            var eh = new EmailHelper();
            var result = eh.NumberOfUniqueEmailAddresses(emails);
            var expectedUniqueNum = 0;

            Assert.AreEqual(expectedUniqueNum, result);
        }
    }
}
