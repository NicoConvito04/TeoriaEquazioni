using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EquazioneDeterminata()
        {
            double a = 0;
            bool risposta_aspettata = true;
            bool risposta_effettiva = Equazioni.IsDetermined(a);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);

        }

        [TestMethod]
        public void EquazioneIndeterminata()
        {
            double a = 0; double b = 3;
            bool risposta_aspettata = true;
            bool risposta_effettiva = Equazioni.IsInconsisted(a, b);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);
        }


        [TestMethod]
        public void EquazioneSecondoGrado()
        {
            double a = 5;
            bool risposta_aspettata = true;
            bool risposta_effettiva = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);

        }

        [TestMethod]
        public void EquazioneDelta()
        {
            double a = 5;
            double b = 3;
            double c = 2;
            double risposta_aspettata = -31;
            double risposta_effettiva = Equazioni.Delta(a,b,c);
            Assert.AreEqual(risposta_aspettata, risposta_effettiva);

        }
    }
}
