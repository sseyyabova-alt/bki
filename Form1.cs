using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BKIApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesabla_Click(object sender, EventArgs e)
        {
            double boy;
            double kilo;

            // Boy və çəkini yoxlayırıq
            if (!double.TryParse(txtBoy.Text, out boy))
            {
                MessageBox.Show(
                    "Boyu düzgün daxil edin!\nMəsələn: 1.75",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtBoy.Focus();
                return;
            }

            if (!double.TryParse(txtKilo.Text, out kilo))
            {
                MessageBox.Show(
                    "Çəkini düzgün daxil edin!\nMəsələn: 70",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtKilo.Focus();
                return;
            }

            // 0 və mənfi qiymətlərin qarşısını alırıq
            if (boy <= 0)
            {
                MessageBox.Show(
                    "Boy 0-dan böyük olmalıdır!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtBoy.Focus();
                return;
            }

            if (kilo <= 0)
            {
                MessageBox.Show(
                    "Çəki 0-dan böyük olmalıdır!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtKilo.Focus();
                return;
            }

            // BKİ hesablanması
            double bki = kilo / (boy * boy);

            // BKİ-ni göstəririk
            lblBKI.Text = "BMI: " + bki.ToString("0.00");

            // Nəticəni təyin edirik
            if (bki < 18.5)
            {
                // ARIQ
                lblNetice.Text = "Underweight";
                lblNetice.ForeColor = Color.Orange;

                pictureBox1.Image = Properties.Resources.arig;
            }
            else if (bki < 25)
            {
                // NORMAL
                lblNetice.Text = "Normal weight";
                lblNetice.ForeColor = Color.Green;

                pictureBox1.Image = Properties.Resources.normal;
            }
            else if (bki < 30)
            {
                // ARTIQ ÇƏKI
                lblNetice.Text = "Overweight";
                lblNetice.ForeColor = Color.OrangeRed;

                pictureBox1.Image = Properties.Resources.artiq;
            }
            else
            {
                // OBEZ
                lblNetice.Text = "Obese";
                lblNetice.ForeColor = Color.Red;

                pictureBox1.Image = Properties.Resources.obez;
            }

            // Şəkilin PictureBox-a uyğun yerləşməsi
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}
