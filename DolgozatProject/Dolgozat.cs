namespace DolgozatProject
{
    public class Dolgozat
    {
        List<int> pontok;
        
        public int Bukas 
        { 
            get
            {
                return Count(0, 49);
            } 
        }

        public int Elegseges
        {
            get
            {
                return Count(50, 60);
            }
        }

        public int Kozepes
        {
            get
            {
                return Count(61, 70);
            }
        }

        public int Jo
        {
            get
            {
                return Count(71, 80);
            }
        }

        public int Jeles
        {
            get
            {
                return Count(81, 100);
            }
        }

        public bool Ervenytelen
        {
            get
            {
                return pontok.Count / 2 < Count(-1,-1);
            }
        }
        
        
        public Dolgozat()
        {
            pontok = new();
        }

        public void PontFelvesz(int x)
        {
            if (x < -1) throw new ArgumentException();
            if (x > 100) throw new ArgumentException();

            pontok.Add(x);
        }

        public bool MindenkiMegirta()
        {
            foreach (int x in pontok)
            {
                if (x == -1) return false;
            }
            
            return true;
        }

        public bool Gyanus(int kivalok)
        {
            if(kivalok < 0) throw new ArgumentException();

            return kivalok < Jeles;
        }

        private int Count(int min, int max)
        {
            return pontok.Count(x => { return x >= min && x <= max; });
        }
    }
}
