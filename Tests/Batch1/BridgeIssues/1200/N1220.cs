using System;
using Bridge.Test;
using System.Collections.Generic;

namespace Bridge.ClientTest.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#1220 - {0}")]
    public class Bridge1220
    {
        public class Class1<T>
        {
            public const int Const1 = 1;
        }

        [Test]
        public static void TestConstInGenericClass()
        {
            Assert.AreEqual(1, Class1<int>.Const1);
        }
    }
}