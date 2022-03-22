using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris_2
{
    public partial class NowyRekord : Form
    {
        public NowyRekord(int tenRekord)
        {
            InitializeComponent();
            Rekord = tenRekord;
        }

        int rekord;

        public int Rekord { get => rekord; set => rekord = value; }

        BazaWynikowDataSetTableAdapters.WynikiTableAdapter wynikiTableAdapter = new BazaWynikowDataSetTableAdapters.WynikiTableAdapter();

       

        private void DodajWynikButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NickTextBox.Text))
                NowyRekord_ErrorLabel.Visible = true;
            else
            {
                wynikiTableAdapter.Insert(NickTextBox.Text, Rekord);
                Close();
            }
                
        }

        private void BrzydkiAleDebugowy_Click(object sender, EventArgs e)
        {
            wynikiTableAdapter.Insert("Józio", 1440);
            wynikiTableAdapter.Insert("Hyzio", 40);
            wynikiTableAdapter.Insert("Dyzio", 340);
            wynikiTableAdapter.Insert("Zyzio", 140);
            wynikiTableAdapter.Insert("Ktoś", 3000);
            wynikiTableAdapter.Insert("Miroslaw", 1200);
            wynikiTableAdapter.Insert("Misztrzunio", 12000);
            wynikiTableAdapter.Insert("Kamil Dab", 12000000);
            wynikiTableAdapter.Insert("ssss", 9940);
            wynikiTableAdapter.Insert("hhhh", 1440);
            wynikiTableAdapter.Insert("jjjjj", 16640);
            wynikiTableAdapter.Insert("nos", 1140);
            wynikiTableAdapter.Insert("ts", 10000);
            wynikiTableAdapter.Insert("gsafa", 9860);
            wynikiTableAdapter.Insert("aggag", 73540);
            wynikiTableAdapter.Insert("agagag", 7440);
            wynikiTableAdapter.Insert("aggag", 1940);
            wynikiTableAdapter.Insert("aggagg", 143440);
            wynikiTableAdapter.Insert("gaggag", 145540);
            wynikiTableAdapter.Insert("Jlll", 14430);
            wynikiTableAdapter.Insert("Józio", 11140);
            wynikiTableAdapter.Insert("Pikaczu", 1240);
            wynikiTableAdapter.Insert("Voltorb", 96440);
            wynikiTableAdapter.Insert("Józio", 1300);
            wynikiTableAdapter.Insert("Hyzio", 14400);
        }
    }
}
