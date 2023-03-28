using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_praktickytest
{
    internal class Hernipostava
    {
        private string jmenohrace;
        public string Jmeno
        {
            get { return jmenohrace; }
            set
            {
                if (value.Length > 10)
                {
                    label2.Text += "Příliš dlouhé jméno!";
                }
                else
                {
                    jmenohrace = value;
                }
            }
        }
        public int level = 1;
        public int PoziceX { get; private set; } = 0;
        public int PoziceY { get; private set; } = 0;

        public Hernipostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public void ZmenaPozice(int novaX, int novaY)
        {
            PoziceX = novaX;
            PoziceY = novaY;
        }

        public override string ToString()
        {
            return "Jméno: {0}, Level: {1}, Pozice X: {2}, Pozice Y: {3}";
        }

        public void LevelUP()
        {
            level++;
        }
    }
}
