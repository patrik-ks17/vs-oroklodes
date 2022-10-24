using System.Diagnostics.Tracing;
using System.Text;

namespace peti002_oroklodes
{
    internal abstract class Allat 
        // abstract: nem lehet osztályt létrehozni
    {
        protected string nev;
        protected int kx, ky;
        // Egyik konstruktor - csak a nevet tudjuk állítani
        public Allat(string nev)
        {
            this.nev = nev;
            this.kx = 0;
            this.ky = 0;
        }
        // Másik konstruktor - a nevet és a koordinátát is be tudjuk állítani
        public Allat(string nev, int x, int y) : this(nev)
        {
            this.kx = x;
            this.ky = y;
        }
        public void mozog(int x, int y)
        {
            this.kx += x;
            this.ky += y;
        }
    }

    internal class Kutya : Allat
    {
        public Kutya(string neve) : base(neve)
        {
            this.nev += " kutya";
        }
        public Kutya(string neve, int x, int y) : base(neve, x, y)
        {
            this.nev += " kutya";
            this.kx = x;
            this.ky = y;
        }
        public void ugat() => Console.WriteLine("{0} ugat.", this.nev);
    }
    internal class Macska : Allat
    {
        public Macska(string neve) : base(neve)
        {
            nev += " cica";
        }
        public Macska(string neve, int x, int y) : base(neve, x, y)
        {
            nev += " cica";
            kx = x;
            ky = y;
        }
        public void nyavog()
        {
            Console.WriteLine($"{nev} nyávog.");
        }
    }
    internal class Papagaj : Allat
    {
        protected int kz;
        public Papagaj(string nev) : base(nev)
        {
            this.kz = 0;
            this.nev += " papagáj";
        }
        public Papagaj(string nev, int x, int y, int z) : base(nev, x, y)
        {
            this.nev += " papagáj";
            kx = x;
            ky = y;
            kz = z;
        }
        public virtual void mozog(int x, int y, int z)
        {
            mozog(x, y);
            this.kz += z;
            if (this.kz < 0)
                this.kz = 0;
        }
    }

    internal class Banyaszpapagaj : Papagaj
    {
        public Banyaszpapagaj(string nev) : base(nev) {}
        public Banyaszpapagaj(string nev, int x, int y, int z) : base(nev, x, y, z) {}
        public override void mozog(int x, int y, int z) // Papagaj mozog fugg felülirasa (csak virtualis fuggv-t)
        {
            mozog(x, y);
            this.kz += z;
        }
    }

}
