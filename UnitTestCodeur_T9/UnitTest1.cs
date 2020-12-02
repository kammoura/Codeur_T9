using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeur_T9;
using System;

namespace UnitTestCodeur_T9
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChaineValide()
        {
            string messageChiffrer=ChifferementT9.Chaine("Bonjour");
            Assert.IsNotNull(messageChiffrer);

        }
        [TestMethod]
        public void ChaineNotValide()
        {
            Assert.ThrowsException<ArgumentNullException>(()=> ChifferementT9.Chaine(null));

        }
        [TestMethod]
        public void MessageChiffrerValide()
        {
            string messageChiffrer = ChifferementT9.Chaine("BONJOUR");
            Assert.AreEqual("2665687", messageChiffrer);

        }
        [TestMethod]
        public void MessageAvecSymbolChiffrerValide()
        {
            string messageChiffrer = ChifferementT9.Chaine("BONJ?OUR");
            Assert.AreEqual("26650687", messageChiffrer);

        }
        [TestMethod]
        public void ChaineMajusculeEgaleMiniscule()
        {
            bool Verif = ChifferementT9.VerifierCaracterInChaine("BONJOUR",'r');
            Assert.AreEqual(true, Verif);

        }
    }
}
