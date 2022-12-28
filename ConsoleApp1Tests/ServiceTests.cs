using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void 測試測試功能是否正常()
        {
            Assert.AreEqual(1, 1);
        }
        [TestMethod()]
        public void 測試addTest是否正常()
        {
            string[] args = { "8", "7" };
            int result = ConsoleApp1.MyService.add(args);
            Assert.AreEqual(result, 15);
        }
    }
}