﻿using HttpClient_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///这是 handleTest 的测试类，旨在
    ///包含所有 handleTest 单元测试
    ///</summary>
    [TestClass()]
    public class handleTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///GetWarningTotalDetail 的测试
        ///</summary>
        [TestMethod()]
        public void GetWarningTotalDetailTest()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string year = string.Empty; // TODO: 初始化为适当的值
            string month = string.Empty; // TODO: 初始化为适当的值
            string ID = string.Empty; // TODO: 初始化为适当的值
            target.GetWarningTotalDetail();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///GetCurrentWarnings 的测试
        ///</summary>
        [TestMethod()]
        public void GetCurrentWarningsTest()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            target.GetCurrentWarnings();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///GetElectric 的测试
        ///</summary>
        [TestMethod()]
        public void GetElectricTest()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string deviceID = string.Empty; // TODO: 初始化为适当的值
            target.GetElectric();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Init 的测试
        ///</summary>
        [TestMethod()]
        public void InitTest()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            target.Init();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Login 的测试
        ///</summary>
        [TestMethod()]
        public void LoginTest()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string name = string.Empty; // TODO: 初始化为适当的值
            string pwd = string.Empty; // TODO: 初始化为适当的值
            target.Login();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Init 的测试
        ///</summary>
        [TestMethod()]
        public void InitTest1()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            target.Init();
            Assert.Inconclusive("无法验证不返回值的方法。");
        }

        /// <summary>
        ///Login 的测试
        ///</summary>
        [TestMethod()]
        public void LoginTest1()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.Login();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///GetWarningTotalDetail 的测试
        ///</summary>
        [TestMethod()]
        public void GetWarningTotalDetailTest1()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.GetWarningTotalDetail();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///GetElectric 的测试
        ///</summary>
        [TestMethod()]
        public void GetElectricTest1()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.GetElectric();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }

        /// <summary>
        ///GetCurrentWarnings 的测试
        ///</summary>
        [TestMethod()]
        public void GetCurrentWarningsTest1()
        {
            handle target = new handle(); // TODO: 初始化为适当的值
            string expected = string.Empty; // TODO: 初始化为适当的值
            string actual;
            actual = target.GetCurrentWarnings();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("验证此测试方法的正确性。");
        }
    }
}
