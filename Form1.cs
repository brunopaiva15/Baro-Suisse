// © Copyright Bruno Paiva. Tous droits réservés.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bareme_Suisse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            try
            {
                tbxPointsObtenus.Text = tbxPointsObtenus.Text.Replace('.', ',');
                tbxPointsTotaux.Text = tbxPointsTotaux.Text.Replace('.', ',');
                double dblResultatFinal = Math.Round(((Convert.ToDouble(tbxPointsObtenus.Text) / Convert.ToDouble(tbxPointsTotaux.Text)) * 5 + 1) * 2, MidpointRounding.AwayFromZero) / 2;
                double dblResultatFinalPrecis = Math.Round((Convert.ToDouble(tbxPointsObtenus.Text) / Convert.ToDouble(tbxPointsTotaux.Text)) * 5 + 1, 2);

                if (Convert.ToDouble(tbxPointsTotaux.Text) != 0)
                {
                    if (Convert.ToDouble(tbxPointsObtenus.Text) > Convert.ToDouble(tbxPointsTotaux.Text))
                    {
                        MessageBox.Show("Erreur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (Convert.ToDouble(tbxPointsObtenus.Text) == 1)
                        {
                            lblNote.Text = $"Note : 1 (1)";
                        }
                        else
                        {
                            lblNote.Text = $"Note : {dblResultatFinal} ({dblResultatFinalPrecis})";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Erreur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                double dblRes = 1;
                double dblPoints = Convert.ToDouble(tbxPointsTotaux.Text);

                dblRes = Math.Round((dblPoints - dblPoints * 0.95) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote15.Text = $"Points pour avoir 1.5 :    {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.85) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote2.Text = $"Points pour avoir 2 :       {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.75) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote25.Text = $"Points pour avoir 2.5 :    {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.65) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote3.Text = $"Points pour avoir 3 :       {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.55) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote35.Text = $"Points pour avoir 3.5 :    {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.45) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote4.Text = $"Points pour avoir 4 :       {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.35) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote45.Text = $"Points pour avoir 4.5 :    {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.25) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote5.Text = $"Points pour avoir 5 :       {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.15) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote55.Text = $"Points pour avoir 5.5 :    {dblRes}";

                dblRes = Math.Round((dblPoints - dblPoints * 0.05) * 2, MidpointRounding.AwayFromZero) / 2;
                lblNote6.Text = $"Points pour avoir 6 :       {dblRes}";
            }
            catch
            {
                MessageBox.Show("Erreur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
