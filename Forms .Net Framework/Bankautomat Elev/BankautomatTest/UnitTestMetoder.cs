using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bankautomat;

namespace BankautomatTest
{
    [TestClass]
    public class UnitTestMetoder
    {
        [TestMethod]
        public void TestaHämtaInmatatMed123()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "123";

            // Act
            bank.Inmatning(Läge.Inloggning, 1);
            bank.Inmatning(Läge.Inloggning, 2);
            bank.Inmatning(Läge.Inloggning, 3);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningMedPin5()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "5";

            // Act
            bank.Inmatning(Läge.Inloggning, 5);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningMedPin45()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "45";

            // Act
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 5);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningMedPin4548()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "4548";

            // Act
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 5);
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 8);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningMedPin45482()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "4548";

            // Act
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 5);
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 8);
            bank.Inmatning(Läge.Inloggning, 2);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningMedMinus1()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "454";

            // Act
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 5);
            bank.Inmatning(Läge.Inloggning, 4);
            bank.Inmatning(Läge.Inloggning, 8);
            bank.Inmatning(Läge.Inloggning, -1);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningMedMinus1OchTom()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "";

            // Act
            bank.Inmatning(Läge.Inloggning, -1);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningUtloggadMed0Först()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "0";

            // Act
            bank.Inmatning(Läge.Inloggning, 0);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningInloggadMed0Först()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "";

            // Act
            bank.Inmatning(Läge.Insättning, 0);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatningInloggadMed48921()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "48921";

            // Act
            bank.Inmatning(Läge.Insättning, 4);
            bank.Inmatning(Läge.Insättning, 8);
            bank.Inmatning(Läge.Insättning, 9);
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 1);

            // Assert
            string actual = bank.HämtaInmatat();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatatÄrTomEfterRättPIN()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "";

            // Act
            bank.Inmatning(Läge.Inloggning, 1);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 7);
            bank.Bekräfta(Läge.Inloggning, out string msg);
            string actual = bank.HämtaInmatat();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatatÄrTomEfterFelPIN()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "";

            // Act
            bank.Inmatning(Läge.Inloggning, 1);
            bank.Inmatning(Läge.Inloggning, 2);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 4);

            bank.Bekräfta(Läge.Inloggning, out string msg);
            string actual = bank.HämtaInmatat();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaKontrolleraPinkodMed1337()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            bank.Inmatning(Läge.Inloggning, 1);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 7);

            // Act
            bool actual = bank.Bekräfta(Läge.Inloggning, out string msg);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestaKontrolleraPinkodMed9876()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bank.Inmatning(Läge.Inloggning, 9);
            bank.Inmatning(Läge.Inloggning, 8);
            bank.Inmatning(Läge.Inloggning, 7);
            bank.Inmatning(Läge.Inloggning, 6);

            bool actual = bank.Bekräfta(Läge.Inloggning, out string msg);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaKontrolleraPinkodMed1234()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bank.Inmatning(Läge.Inloggning, 1);
            bank.Inmatning(Läge.Inloggning, 2);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 4);
            bool actual = bank.Bekräfta(Läge.Inloggning, out string msg);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestaKontrolleraPinkodMed0000()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = false;

            // Act
            bank.Inmatning(Läge.Inloggning, 0);
            bank.Inmatning(Läge.Inloggning, 0);
            bank.Inmatning(Läge.Inloggning, 0);
            bank.Inmatning(Läge.Inloggning, 0);
            bool actual = bank.Bekräfta(Läge.Inloggning, out string msg);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatatEfterInsättning()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "";

            // Act
            bank.Inmatning(Läge.Insättning, 6);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);

            bank.Bekräfta(Läge.Insättning, out string msg);
            string actual = bank.HämtaInmatat();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInmatatEfterUttag()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "";

            // Act
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 2);
            bank.Bekräfta(Läge.Insättning, out string msg1);
            bank.Inmatning(Läge.Uttag, 2);
            bank.Bekräfta(Läge.Uttag, out string msg);
            string actual = bank.HämtaInmatat();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInsättningMed100()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bank.Inmatning(Läge.Insättning, 1);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);

            bool actual = bank.Bekräfta(Läge.Insättning, out string msg);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInsättningsUtskriftMed100()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "Insättning: 100kr";

            // Act
            bank.Inmatning(Läge.Insättning, 1);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Bekräfta(Läge.Insättning, out string msg);
            string actual = msg;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaUttagsUtskriftMed100Av100()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "Uttag: 100kr";

            // Act
            bank.Inmatning(Läge.Insättning, 1);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Bekräfta(Läge.Insättning, out string msg1);
            bank.Inmatning(Läge.Uttag, 1);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Bekräfta(Läge.Uttag, out string msg);
            string actual = msg;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaUttagsUtskriftMed100Av50()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "Otillräckligt saldo";

            // Act
            bank.Inmatning(Läge.Insättning, 5);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Bekräfta(Läge.Insättning, out string msg1);
            bank.Inmatning(Läge.Uttag, 1);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Bekräfta(Läge.Uttag, out string msg);
            string actual = msg;

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestaUttag100Med200kvar()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Bekräfta(Läge.Insättning, out string msg);
            bank.Inmatning(Läge.Uttag, 1);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Inmatning(Läge.Uttag, 0);
            bool actual = bank.Bekräfta(Läge.Uttag, out string msg1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaUttag200Med200kvar()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Bekräfta(Läge.Insättning, out string msg);
            bank.Inmatning(Läge.Uttag, 2);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Inmatning(Läge.Uttag, 0);
            bool actual = bank.Bekräfta(Läge.Uttag, out string msg1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaUttag300Med200kvar()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = false;

            // Act
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Inmatning(Läge.Insättning, 0);
            bank.Bekräfta(Läge.Insättning, out string msg);
            bank.Inmatning(Läge.Uttag, 3);
            bank.Inmatning(Läge.Uttag, 0);
            bank.Inmatning(Läge.Uttag, 0);
            bool actual = bank.Bekräfta(Läge.Uttag, out string msg1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaUttagMedIngenting()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bool actual = bank.Bekräfta(Läge.Uttag, out string msg1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaInsättningMedIngenting()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = true;

            // Act
            bool actual = bank.Bekräfta(Läge.Uttag, out string msg1);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaVisaSaldoMedInsättning()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "Saldo: 234kr";

            // Act
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 3);
            bank.Inmatning(Läge.Insättning, 4);
            bank.Bekräfta(Läge.Insättning, out string msg1);
            string actual = bank.VisaSaldo(Läge.Insättning);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaVisaSaldoMedUttag()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            string expected = "Saldo: 234kr";

            // Act
            bank.Inmatning(Läge.Insättning, 2);
            bank.Inmatning(Läge.Insättning, 3);
            bank.Inmatning(Läge.Insättning, 4);
            bank.Bekräfta(Läge.Insättning, out string msg1);
            string actual = bank.VisaSaldo(Läge.Uttag);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestaBekräftaPINMed234()
        {
            // Arrange
            BANKappLogic bank = new BANKappLogic();
            bool expected = false;

            // Act
            bank.Inmatning(Läge.Inloggning, 2);
            bank.Inmatning(Läge.Inloggning, 3);
            bank.Inmatning(Läge.Inloggning, 4);
            bool actual = bank.Bekräfta(Läge.Inloggning, out string msg);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
