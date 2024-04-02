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
    public partial class Klient : Form
    {
        public Klient()
        {
            InitializeComponent();
        }

        private void Klient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceDataSet.Klient". При необходимости она может быть перемещена или удалена.
            //this.klientTableAdapter.Fill(this.serviceDataSet.Klient);

        }
    }
}
