using SbsSW.SwiPlCs;
using System;
using System.Collections;
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
                String[] p = { "-q", "-f", @"rules.pl" };
                PlEngine.Initialize(p);
                firstElementComboBox();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void firstElementComboBox()
        {
            cbSexo.SelectedIndex = 0;
            cbCarril.SelectedIndex = 0;
            cbTipo.SelectedIndex = 0;
            cbArma.SelectedIndex = 0;
            cbRegion.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lbInfo.DataSource = null;
            lbInfo.Items.Clear();
            //PlQuery cargar = new PlQuery("cargar");
            //cargar.NextSolution();
            //String query = "que_personaje_es(" +
            //    "PERSONAJE," 
            //    + cbSexo.SelectedItem.ToString() + "," 
            //    + cbCarril.SelectedItem.ToString() + "," 
            //    + cbTipo.SelectedItem.ToString() + "," 
            //    + cbArma.SelectedItem.ToString() + "," 
            //    + cbRegion.SelectedItem.ToString() 
            //    + ")";

            String query1 = "que_personaje_es(" +
                "PERSONAJE,"
                + cbSexo.Text.ToString() + ","
                + cbCarril.Text.ToString() + ","
                + cbTipo.Text.ToString() + ","
                + cbArma.Text.ToString() + ","
                + cbRegion.Text.ToString()
                + ")";
            ArrayList arPersonajes = new ArrayList();
            Boolean repetido = false;
            PlQuery consulta = new PlQuery(query1);
            foreach (PlQueryVariables z in consulta.SolutionVariables)
            {
                foreach (var element in arPersonajes)
                {
                    if (element.Equals(z["PERSONAJE"].ToString()))
                    {
                        repetido = true;
                        break;
                    }
                }
                if (repetido == false)
                {
                    arPersonajes.Add(z["PERSONAJE"].ToString());
                }
                repetido = false;
                //lbInfo.Items.Add(z["PERSONAJE"].ToString());
            }
            lbInfo.DataSource = arPersonajes;
        }
    }
}
