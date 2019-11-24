using SbsSW.SwiPlCs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaLOL
{
    public partial class Principal : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            try
            {
                
                firstElementComboBox();
                propiedadesDeInicioListView();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void inicializarProlog()
        {
            Environment.SetEnvironmentVariable("Path", @"C:\\Program Files (x86)\\pl\\bin");
            String[] p = { "-q", "-f", @"rules.pl" };
            PlEngine.Initialize(p);
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
            
        }

        private void LvCampeones_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void LblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BtnCalcular_Click_1(object sender, EventArgs e)
        {
            inicializarProlog();
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
            PlEngine.PlCleanup();
        }

        private void LvCampeones_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            inicializarProlog();
            String descripcion = null;
            String nombreCampeon = lvCampeones.SelectedItems[0].Text;
            String query = $"que_descripcion_tiene(" +
                $"{nombreCampeon}," +
                $"DESCRIPCION" +
                $")";

            PlQuery consulta1 = new PlQuery(query);

            foreach (var z in consulta1.SolutionVariables)
            {
                descripcion = z["DESCRIPCION"].ToString();
            }
            pbImagenCampeon.Image = (Image)ProgramaLOL.Properties.Resources.ResourceManager.GetObject("c" + nombreCampeon);
            //pbImagenCampeon.Image = ilCampeonesCompletos.Images[$"{nombreCampeon}.jpg"];
            lbNombreCampeon.Text = toUpperCase(nombreCampeon);
            tbDescripcion.Text = descripcion;
            PlEngine.PlCleanup();
        }

        private String toUpperCase(String nombre)
        {
            CultureInfo ci = new CultureInfo("es-MX");
            ci = new CultureInfo("es-MX");
            TextInfo textInfo = ci.TextInfo;
            return textInfo.ToTitleCase(nombre);
        }
    }
}
