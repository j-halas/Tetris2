using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tetris_2
{
    class Klocek
    {
        Image tekstura;
        float rozmiar;
        int bok;            //realna dlugosc boku - rozmiar*bok tekstury
        bool ruchomy;
        bool pusty; // ZERUJ RZAD JESLI SUMA BOOL "PUSTY" ELEMENTOW W RZEDZIE JEST ZERO!!!

        public Klocek(Image _tekstura, bool _ruchomy, bool _pusty)
        {
            Tekstura = _tekstura;
            Ruchomy = _ruchomy;
            Pusty = _pusty;
            Rozmiar = 0.25f;
            Bok = (int)(_tekstura.Height * Rozmiar);

        }

        public Klocek()
        {
            Tekstura = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Tekstury\tlo.png"));
            Ruchomy = false;
            Pusty = true;
            Rozmiar = 0.25f;
            Bok = (int)(Tekstura.Height * Rozmiar);
        }

        public Klocek(Klocek k)
        {
            ZbierzWartosci(k);
        }


        public Image Tekstura { get => tekstura; set => tekstura = value; }
        public float Rozmiar { get => rozmiar; set => rozmiar = value; }
        public int Bok { get => bok; set => bok = value; }
        public bool Ruchomy { get => ruchomy; set => ruchomy = value; }
        public bool Pusty { get => pusty; set => pusty = value; }

        public void Rysuj(Graphics g, int pX, int pY)
        {
            var m = g.Transform;
            g.ScaleTransform(Rozmiar, Rozmiar);
            int rozmiarX = (int)(Tekstura.Width);
            int rozmiarY = (int)(Tekstura.Height);
            int pozX = pX * rozmiarX;
            int pozY = pY * rozmiarY;
            g.DrawImage(Tekstura, pozX, pozY);
            g.Transform = m;
        }
        public void Rysuj(Graphics g, int pX, int pY, int pixelX, int pixelY)
        {
            var m = g.Transform;
            g.ScaleTransform(Rozmiar, Rozmiar);
            int rozmiarX = (int)(Tekstura.Width);
            int rozmiarY = (int)(Tekstura.Height);
            int pozX = pX * rozmiarX;
            int pozY = pY * rozmiarY;
            g.DrawImage(Tekstura, pozX + pixelX, pozY + pixelY);
            g.Transform = m;
        }

        public void ZbierzWartosci(Klocek k)
        {
            Tekstura = k.Tekstura;
            Ruchomy = k.Ruchomy;
            Pusty = k.Pusty;
            Rozmiar = k.Rozmiar;
            Bok = k.Bok;
        }
    }
}
