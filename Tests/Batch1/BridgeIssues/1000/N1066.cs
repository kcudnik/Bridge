using System;
using System.Collections.Generic;
using Bridge.Test;

namespace Bridge.ClientTest.BridgeIssues
{
    [Category(Constants.MODULE_ISSUES)]
    [TestFixture(TestNameFormat = "#1066 - {0}")]
    public class Bridge1066
    {
        [Test]
        public static void TestInlinePopertyWithValue()
        {
           var dict = new MyDictionary();
           Assert.NotNull(dict["getAccessor"]);
           Assert.NotNull(dict["setAccessor"]);
           Assert.AreEqual(1, dict[0]);
        }

        class MyDictionary : Dictionary<int, int>
        {
            public new int this[int key]
            {
                [Name("getAccessor")]
                get
                {
                    return 1;
                }
                [Name("setAccessor")]
                set
                {

                }
            }
        }
    }
}