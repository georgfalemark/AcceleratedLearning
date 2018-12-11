using MethodsAndLists.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsAndLists.Test
{
    [TestClass]
    public class StringToBoolTests
    {
        readonly StringToBool x = new StringToBool();

        //[TestMethod]
        //public void Is_Pandorome()
        //{
        //    bool result = x.Is_Pandorome("abcba");
        //    Assert.IsTrue(result);

        //    bool result2 = x.Is_Pandorome("bbcbb");
        //    Assert.IsTrue(result2);

        //    bool result3 = x.Is_Pandorome("tywif");
        //    Assert.IsFalse(result3);

        //    bool result4 = x.Is_Pandorome("georg");
        //    Assert.IsFalse(result4);
        //}

        //Testmetod för att se om dessa är sanna
        [TestMethod]
        [DataRow("abcba")]
        [DataRow("bbcbb")]
        [DataRow("a")]
        [DataRow("aaaa")]
        [DataRow("åäöäå")]
        public void Is_Pandorome_True(string input)
        {
            bool result = x.Is_Pandorome(input);
            Assert.IsTrue(result);
        }

        //Testmetod för att se om dessa är falska
        [TestMethod]
        [DataRow("abcb")]
        [DataRow("bcbb")]
        [DataRow("ab")]
        [DataRow("abc")]
        [DataRow("+h+")]
        public void Is_Pandorome_False(string input)
        {
            bool result = x.Is_Pandorome(input);
            Assert.IsFalse(result);
        }

        //[TestMethod]
        //public void Is_ZipCode()
        //{
        //    bool result = x.Is_ZipCode("125 56");
        //    Assert.IsTrue(result);

        //    bool result2 = x.Is_ZipCode("111 11");
        //    Assert.IsTrue(result2);

        //    bool result3 = x.Is_ZipCode("Panda");
        //    Assert.IsFalse(result3);

        //    bool result4 = x.Is_ZipCode("45878");
        //    Assert.IsFalse(result4);
        //}

        [TestMethod]
        [DataRow("125 56")]
        [DataRow("111 11")]
        [DataRow("412 74")]
        [DataRow("778 63")]
        [DataRow("558 94")]
        [DataRow("100 00")]
        public void Is_ZipCode_True(string input)
        {
            bool result = x.Is_ZipCode(input);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow("12556")]
        [DataRow("Panda")]
        [DataRow("00423")]
        [DataRow("000 00")]
        [DataRow("Pan da")]
        [DataRow("Pan fksdlfkösdl")]
        [DataRow("anna")]
        public void Is_ZipCode_False(string input)
        {
            bool result = x.Is_ZipCode(input);
            Assert.IsFalse(result);
        }
    }
}
