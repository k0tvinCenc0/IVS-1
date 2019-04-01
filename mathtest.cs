using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatematicTridaTest
{
    [TestClass]
    public class MatematicTrida
    {
        # private MatematicTrida matematic

        [TestInitialize]
        public void Inicializace()
        {
            matematic = new MatematicTrida();
        }

        [TestMethod]
        public void ScitaniTest()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Scitani(0, 0));
            Assert.AreEqual(1, matematic.Scitani(0, 1));
            Assert.AreEqual(-5, matematic.Scitani(0, -5));
            Assert.AreEqual(3, matematic.Scitani(3, 0));
            Assert.AreEqual(-82, matematic.Scitani(-32, -50));
            Assert.AreEqual(108, matematic.Scitani(74, 34));
            Assert.AreEqual(50, matematic.Scitani(80, -30));
            Assert.AreEqual(781480, matematic.Scitani(120700, 660780));
            Assert.AreEqual(-781480, matematic.Scitani(-120700, -660780));
            Assert.AreEqual(-540080, matematic.Scitani(120700, -660780));
            Assert.AreEqual(832000000, matematic.Scitani(780000000, 52000000));
            Assert.AreEqual(-832000000, matematic.Scitani(-780000000, -52000000));
            Assert.AreEqual(728000000, matematic.Scitani(780000000, -52000000));
            //Testování desetinných čísel
            Assert.AreEqual(1, matematic.Scitani(0.78, 0.22));
            Assert.AreEqual(4.58545454, matematic.Scitani(4.58545454, 0));
            Assert.AreEqual(4.58545454, matematic.Scitani(0, 4.58545454));
            Assert.AreEqual(2.4, matematic.Scitani(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Scitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Scitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Scitani(0.78, 0.22));
            Assert.AreNotEqual(7.555 , matematic.Scitani(-2.4, 4.8));
        }

        [TestMethod]
        public void Odcitani()
        {   
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Odcitani(0, 0));
            Assert.AreEqual(-1, matematic.Odcitani(0, 1));
            Assert.AreEqual(5, matematic.Odcitani(0, -5));
            Assert.AreEqual(3, matematic.Odcitani(3, 0));
            Assert.AreEqual(18, matematic.Odcitani(-32, -50));
            Assert.AreEqual(40, matematic.Odcitani(74, 34));
            Assert.AreEqual(110, matematic.Odcitani(80, -30));
            Assert.AreEqual(-540080, matematic.Odcitani(120700, 660780));
            Assert.AreEqual(540080, matematic.Odcitani(-120700, -660780));
            Assert.AreEqual(781480, matematic.Odcitani(120700, -660780));
            Assert.AreEqual(728000000, matematic.Odcitani(780000000, 52000000));
            Assert.AreEqual(-728000000, matematic.Odcitani(-780000000, -52000000));
            Assert.AreEqual(728000000, matematic.Odcitani(832000000, -52000000));
          
            //Testování desetinných čísel
            Assert.AreEqual(0.56, matematic.Odcitani(0.78, 0.22));
            Assert.AreEqual(4.58545454, matematic.Odcitani(4.58545454, 0));
            Assert.AreEqual(-4.58545454, matematic.Odcitani(0, 4.58545454));
            Assert.AreEqual(-7.2, matematic.Odcitani(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Odcitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Odcitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Odcitani(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Odcitani(-2.4, 4.8));
        }

        [TestMethod]
        public void Nasobeni()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Nasobeni(0, 0));
            Assert.AreEqual(0, matematic.Nasobeni(0, 1));
            Assert.AreEqual(0, matematic.Nasobeni(0, -5));
            Assert.AreEqual(0, matematic.Nasobeni(3, 0));
            Assert.AreEqual(1600, matematic.Nasobeni(-32, -50));
            Assert.AreEqual(2516, matematic.Nasobeni(74, 34));
            Assert.AreEqual(-2400, matematic.Nasobeni(80, -30));
            Assert.AreEqual(796620000, matematic.Nasobeni(120700, 6600));
            Assert.AreEqual(796620000, matematic.Nasobeni(-120700, -6600));
            

            //Testování desetinných čísel
            Assert.AreEqual(0.1716, matematic.Nasobeni(0.78, 0.22));
            Assert.AreEqual(0, matematic.Nasobeni(4.58545454, 0));
            Assert.AreEqual(0, matematic.Nasobeni(0, 4.58545454));
            Assert.AreEqual(-11.52, matematic.Nasobeni(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Scitani(-32, -50));
            Assert.AreNotEqual(5000, matematic.Scitani(120700, 660780));
            Assert.AreNotEqual(70, matematic.Scitani(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Scitani(-2.4, 4.8));
        }

        [TestMethod]
        public void Deleni()
        {
            //Testování celých čísel
            Assert.AreEqual(0, matematic.Deleni(0, 1));
            Assert.AreEqual(0, matematic.Deleni(0, -5));
            Assert.AreEqual(0, matematic.Deleni(0, 0));
            Assert.AreEqual(0, matematic.Deleni(3, 0));
            Assert.AreEqual(1, matematic.Deleni(5, -5));
            Assert.AreEqual(1600, matematic.Deleni(-32, -50));
            Assert.AreEqual(2516, matematic.Deleni(74, 34));
            Assert.AreEqual(-2400, matematic.Deleni(80, -30));
            Assert.AreEqual(159, matematic.Deleni(1049400, 6600));
            Assert.AreEqual(1560, matematic.Deleni(-8268000, -5300));
            Assert.AreEqual(-1560, matematic.Deleni(8268000, -5300));

            //Testování desetinných čísel
            Assert.AreEqual(4, matematic.Deleni(0.88, 0.22));
            Assert.AreEqual(0, matematic.Deleni(0, 4.58545454));
            Assert.AreEqual(-0.5, matematic.Deleni(-2.4, 4.8));

            //Testovaní nerovnání součtu
            Assert.AreNotEqual(160, matematic.Deleni(-32, -50));
            Assert.AreNotEqual(5000, matematic.Deleni(120700, 660780));
            Assert.AreNotEqual(70, matematic.Deleni(0.78, 0.22));
            Assert.AreNotEqual(7.555, matematic.Deleni(-2.4, 4.8));

            //Testování vyhození výjímky
            const string Vyjimka = "Výjimky nenastala, avšak byla očekávána.";
            try
            {
                matematic.Deleni(28.51561651, 0);
                Assert.Fail(Vyjimka);
            }
            catch (VyjimkaDeleni0)
            {
            }
            try
            {
                this.math.Div(-23, 0);
                Assert.Fail(Vyjimka);
            }
            catch (VyjimkaDeleni0)
            {
            }
        }
    }
