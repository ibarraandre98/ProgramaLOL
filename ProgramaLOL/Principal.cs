using SbsSW.SwiPlCs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaLOL
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\pl\\bin");
                String[] p = { "-q", "-f", @"ejemplo.pl" };
                PlEngine.Initialize(p);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();
            PlQuery cargar = new PlQuery("cargar");
            cargar.NextSolution();
                PlQuery consulta = new PlQuery("amigos(X,Y)");
                foreach (PlQueryVariables z in consulta.SolutionVariables)
                    lbInfo.Items.Add(z["X"].ToString());


                PlEngine.PlCleanup();
            }
    }
}
