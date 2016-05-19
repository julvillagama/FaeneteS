using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaeneteS
{
    public partial class InformeCorreos : Form
    {

        private DataTable datos;

        public InformeCorreos(DataTable datos)
        {
            InitializeComponent();
            this.datos = datos;
        }

        private void InformeCorreos_Load(object sender, EventArgs e)
        {
            // Creamos objeto del informe
            CrystalReport1 Informe = new CrystalReport1();

            // Pasamos los datos al informe
            Informe.SetDataSource(datos);

            // Le pasamos el informe al visor
            this.crystalReportViewer1.ReportSource = Informe;
        }
    }
}
