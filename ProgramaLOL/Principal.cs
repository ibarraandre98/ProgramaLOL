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
                propiedadesDeInicioListView();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void propiedadesDeInicioListView()
        {
            lvCampeones.View = View.Details;
            lvCampeones.Columns.Add("Campeon", 0);
            lvCampeones.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void propiedadesListViewCampeones(ArrayList arCampeones)
        {
            lvCampeones.Items.Clear();
            lvCampeones.SmallImageList = ilCampeones;
            foreach (var itemCampeones in arCampeones)
            {
                lvCampeones.Items.Add(itemCampeones.ToString(), $"{itemCampeones.ToString()}.png");
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
            ArrayList arPersonajes = new ArrayList();
            Boolean repetido = false;


            String query = "que_personaje_es(" +
                "PERSONAJE,"
                + cbSexo.Text.ToString() + ","
                + cbCarril.Text.ToString() + ","
                + cbTipo.Text.ToString() + ","
                + cbArma.Text.ToString() + ","
                + cbRegion.Text.ToString()
                + ")";
            
            PlQuery consulta = new PlQuery(query);
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
            }

            propiedadesListViewCampeones(arPersonajes);
        }

        private void LvCampeones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(lvCampeones.SelectedItems[0].Text);

            String query = $"que_descripcion_tiene(" +
                $"{lvCampeones.SelectedItems[0].Text}," +
                $"DESCRIPCION" +
                $")";

            PlQuery consulta1 = new PlQuery(query);

            foreach (var z in consulta1.SolutionVariables)
            {
                MessageBox.Show(z["DESCRIPCION"].ToString());
            }
        }
    }
}
