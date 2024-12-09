using DolgozatProject;

namespace TestDolgozatProject
{
    public class Tests
    {
        [Test]
        public void Test_PontFelvesz_ArgumentExceptions()
        {
            Dolgozat dolgozat = new();
            
            Assert.DoesNotThrow(()=> { dolgozat.PontFelvesz(-1); });
            Assert.DoesNotThrow(()=> { dolgozat.PontFelvesz(0); });
            Assert.DoesNotThrow(()=> { dolgozat.PontFelvesz(35); });
            Assert.DoesNotThrow(()=> { dolgozat.PontFelvesz(100); });

            Assert.Throws<ArgumentException>(()=> { dolgozat.PontFelvesz(101); });
            Assert.Throws<ArgumentException>(()=> { dolgozat.PontFelvesz(-101); });
        }
        
        [Test]
        public void Test_Gyanus_ArgumentExceptions()
        {
            Dolgozat dolgozat = new();

            Assert.DoesNotThrow(() => { dolgozat.Gyanus(0); });
            Assert.DoesNotThrow(() => { dolgozat.Gyanus(10); });
            Assert.DoesNotThrow(() => { dolgozat.Gyanus(35); });
            Assert.DoesNotThrow(() => { dolgozat.Gyanus(100); });
            Assert.DoesNotThrow(() => { dolgozat.Gyanus(254342); });

            Assert.Throws<ArgumentException>(() => { dolgozat.Gyanus(-1); }); 
            Assert.Throws<ArgumentException>(() => { dolgozat.Gyanus(-10); }); 
            Assert.Throws<ArgumentException>(() => { dolgozat.Gyanus(-1254); });
        }


        [Test]
        public void Test_CountInts()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(-1);

            //Bukás
            dolgozat.PontFelvesz(0);
            dolgozat.PontFelvesz(35);
            dolgozat.PontFelvesz(49);

            //Elégséges
            dolgozat.PontFelvesz(50);
            dolgozat.PontFelvesz(60);

            //Közepes
            dolgozat.PontFelvesz(61);
            dolgozat.PontFelvesz(70);

            //Jó
            dolgozat.PontFelvesz(71);
            dolgozat.PontFelvesz(80);

            //Jeles
            dolgozat.PontFelvesz(81);
            dolgozat.PontFelvesz(94);
            dolgozat.PontFelvesz(100);

            Assert.That(dolgozat.Bukas == 3);
            Assert.That(dolgozat.Elegseges == 2);
            Assert.That(dolgozat.Kozepes == 2);
            Assert.That(dolgozat.Jo == 2);
            Assert.That(dolgozat.Jeles == 3);
        }


        [Test]
        public void Test_Gyanus_ShouldBeTrue()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(81);
            dolgozat.PontFelvesz(90);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(60);

            Assert.That(dolgozat.Gyanus(0));
        }

        [Test]
        public void Test_Gyanus_ShouldBeFalse()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(81);
            dolgozat.PontFelvesz(90);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(60);

            Assert.That(dolgozat.Gyanus(2) == false);
        }

        [Test]
        public void Test_Ervenytelen_ShouldBeTrue()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(0);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(100);

            Assert.That(dolgozat.Ervenytelen);
        }

        [Test]
        public void Test_Ervenytelen_ShouldBeFalse()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(1);
            dolgozat.PontFelvesz(1);
            dolgozat.PontFelvesz(1);
            dolgozat.PontFelvesz(1);
            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(0);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(100);

            Assert.That(dolgozat.Ervenytelen == false);
        }

        [Test]
        public void Test_MindenkiMegirta_ShouldBeTrue()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(42);
            dolgozat.PontFelvesz(65);
            dolgozat.PontFelvesz(87);
            dolgozat.PontFelvesz(34);
            dolgozat.PontFelvesz(0);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(100);

            Assert.That(dolgozat.MindenkiMegirta());
        }

        [Test]
        public void Test_MindenkiMegirta_ShouldBeFalse()
        {
            Dolgozat dolgozat = new();

            dolgozat.PontFelvesz(-1);
            dolgozat.PontFelvesz(42);
            dolgozat.PontFelvesz(65);
            dolgozat.PontFelvesz(87);
            dolgozat.PontFelvesz(34);
            dolgozat.PontFelvesz(0);
            dolgozat.PontFelvesz(10);
            dolgozat.PontFelvesz(100);

            Assert.That(dolgozat.MindenkiMegirta() == false);
        }

        
        //Empty list tests
        [Test]
        public void Test_Empty_CountInts()
        {
            Dolgozat dolgozat = new();

            Assert.That(dolgozat.Bukas == 0);
            Assert.That(dolgozat.Elegseges == 0);
            Assert.That(dolgozat.Kozepes == 0);
            Assert.That(dolgozat.Jo == 0);
            Assert.That(dolgozat.Jeles == 0);
        }

        [Test]
        public void Test_Empty_Gyanus()
        {
            Dolgozat dolgozat = new();

            Assert.That(dolgozat.Gyanus(0) == false);
        }

        [Test]
        public void Test_Empty_Ervenytelen()
        {
            Dolgozat dolgozat = new();

            Assert.That(dolgozat.Ervenytelen == false);
        }

        [Test]
        public void Test_Empty_MindenkiMegirta()
        {
            Dolgozat dolgozat = new();

            Assert.That(dolgozat.MindenkiMegirta());
        }
    }
}