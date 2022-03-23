using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    public partial class ablak : Form
    {
        public ablak()
        {
            InitializeComponent();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            try
            {
                var szam1 = Convert.ToInt32(textBoxSzam1.Text);
                if (szam1 > 100)
                {
                    throw new ArgumentException("Nem lehet 100-nál nagyobb az első szám!");
                }
                var szam2 = Convert.ToInt32(textBoxSzam2.Text);

                var eredmeny = szam1 + szam2;
                labelEredmeny.Text = eredmeny.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Hiba!",MessageBoxButtons.OK,MessageBoxIcon.Error);                
            }
            

        }
    }
}
