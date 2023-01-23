using Bankautomat;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankautomatTest
{
    [TestClass]
    public class UnitTestListor
    {
        [TestMethod]
        public void TestaSparaInfoEnGång()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bank.inmatat = "1337";
            string expected = "Insättning: 1337kr";

            // Act
            bank.Bekräfta(true, Val.Insättning, out string msg);
            string actual = bank.historikInfo[0];

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaSparaInfoTreGångerMedEttFel()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bank.inmatat = "1337";
            List<string> expected = new List<string>();
            expected.Add("Insättning: 1337kr");
            expected.Add("Uttag: 200kr");

            // Act
            bank.Bekräfta(true, Val.Insättning, out string msg);
            bank.inmatat = "200";
            bank.Bekräfta(true, Val.Uttag, out string msg1);
            bank.inmatat = "20000";
            bank.Bekräfta(true, Val.Uttag, out string msg2);

            List<string> actual = bank.historikInfo;

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
