using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCoding;
using System;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string resultSentence;
            resultSentence = Process.GetInstance().transform("Smooth");

            Assert.AreEqual(resultSentence, "S3h");

        }
    }
}
