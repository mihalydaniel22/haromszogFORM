using haromszog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace haromszogek
{
    public partial class frmfo : Form
    {
        private int aoldal;
        private int boldal;
        private int coldal;



        public frmfo()
        {
            aoldal = 0;
            boldal = 0;
            coldal = 0;

            InitializeComponent();

            tbAoldal.Text = aoldal.ToString();
            tbBoldal.Text = boldal.ToString();
            tbColdal.Text = coldal.ToString();
            lbHaromszoglista.Items.Clear();
        }

        private void BTNkilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSzamol_Click(object sender, EventArgs e)
        {
            aoldal = Convert.ToInt32(tbAoldal.Text);
            boldal = Convert.ToInt32(tbBoldal.Text);
            coldal = Convert.ToInt32(tbColdal.Text);
            
            if (aoldal == 0 || boldal == 0 || coldal == 0)
            {
                MessageBox.Show("Nem lehet nulla a háromszög oldala", "HIBA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var h = new Haromszog(aoldal, boldal, coldal);
               

                List<string> adatok = h.AdatokSzoveg();

                foreach (var a in adatok)
                {
                    lbHaromszoglista.Items.Add(a);
                }
            }
        }

        private void frmfo_Load(object sender, EventArgs e)
        {

        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHaromszoglista.Items.Count > 0)
            {
                lbHaromszoglista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs mit törölni");
            }
            
        }
    }
}
