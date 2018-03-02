using DictionaryCompareTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// test that comparing BaseObjects (of the same type) works ok
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            Class1 object1;
            Class1 object2;
            bool result;

            object1 = new Class1();
            object2 = new Class1();

            // the two objects will have different Id's, so the compare should fail
            result = object1.Equals(object2);

            Assert.IsFalse(result);
        }
    }
}