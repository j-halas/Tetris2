using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;

namespace Tetris_2
{
    public class SuperButton : Button
    {
        public SuperButton()
        {
            this.SetStyle(ControlStyles.Selectable, false);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);

        }
    }

    public class SuperTimer : Timer
    {
        int intervalBaza;
        float boostCoef;
        public SuperTimer(IContainer Conteiner) : base()
        {
            intervalBaza = 1024;
            BoostCoef = 1;
        }

        public int IntervalBaza { get => intervalBaza; set { intervalBaza = value; Interval = (int)(IntervalBaza * BoostCoef); } }

        public float BoostCoef { get => boostCoef; set { boostCoef = value; Interval = (int)(IntervalBaza * BoostCoef); } }

    }

    class Kosci
    {
        int il_scian;

        int Il_scian
        {
            set
            {
                il_scian = value;
            }

        }

        public int Rzuc(Random random)
        {
            return random.Next(il_scian);
        }

        public Kosci()
        {
            Il_scian = 6;
        }
        public Kosci(int _il_sc)
        {
            Il_scian = _il_sc;
        }
    }
}