using ServiceCentr.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCentr.Forms
{
    public partial class FormZakaz : Form
    {
        public FormZakaz()
        {
            InitializeComponent();
            LoadTheme();
        }

        public int MidnightBlue { get; private set; }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondColor;

                }
            }
            label1.ForeColor = ThemeColor.SecondColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormZakaz_Load(object sender, EventArgs e)
        {

        }

        private void panelZakaza_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
