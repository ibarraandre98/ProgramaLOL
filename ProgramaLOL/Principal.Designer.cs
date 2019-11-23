namespace ProgramaLOL
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnCalcular = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbCarril = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbArma = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.lvCampeones = new System.Windows.Forms.ListView();
            this.ilCampeones = new System.Windows.Forms.ImageList(this.components);
            this.pbImagenCampeon = new System.Windows.Forms.PictureBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.ilCampeonesCompletos = new System.Windows.Forms.ImageList(this.components);
            this.lbNombreCampeon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCampeon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(61, 285);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "SEXO",
            "femenino",
            "masculino"});
            this.cbSexo.Location = new System.Drawing.Point(43, 37);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(121, 21);
            this.cbSexo.TabIndex = 2;
            // 
            // cbCarril
            // 
            this.cbCarril.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarril.FormattingEnabled = true;
            this.cbCarril.Items.AddRange(new object[] {
            "CARRIL",
            "jungla",
            "top",
            "soporte",
            "adc",
            "mid"});
            this.cbCarril.Location = new System.Drawing.Point(43, 77);
            this.cbCarril.Name = "cbCarril";
            this.cbCarril.Size = new System.Drawing.Size(121, 21);
            this.cbCarril.TabIndex = 3;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "TIPO",
            "luchador",
            "mago",
            "tirador",
            "tanque",
            "asesino"});
            this.cbTipo.Location = new System.Drawing.Point(43, 117);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 4;
            // 
            // cbArma
            // 
            this.cbArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArma.FormattingEnabled = true;
            this.cbArma.Items.AddRange(new object[] {
            "ARMA",
            "espada",
            "baculo",
            "cuchilla_de_mano",
            "dagas",
            "hacha",
            "pistola",
            "instrumento_musical",
            "lanza",
            "arco",
            "maza",
            "martillo",
            "dardos",
            "gancho",
            "brazo",
            "cartas",
            "escudo",
            "garras"});
            this.cbArma.Location = new System.Drawing.Point(43, 159);
            this.cbArma.Name = "cbArma";
            this.cbArma.Size = new System.Drawing.Size(121, 21);
            this.cbArma.TabIndex = 5;
            // 
            // cbRegion
            // 
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FormattingEnabled = true;
            this.cbRegion.Items.AddRange(new object[] {
            "REGION",
            "zaun",
            "jonia",
            "noxus",
            "aguasturbias",
            "freljord",
            "islas_de_las_sombras",
            "bandle",
            "targon",
            "demacia"});
            this.cbRegion.Location = new System.Drawing.Point(43, 203);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(121, 21);
            this.cbRegion.TabIndex = 6;
            // 
            // lvCampeones
            // 
            this.lvCampeones.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvCampeones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lvCampeones.BackgroundImage")));
            this.lvCampeones.BackgroundImageTiled = true;
            this.lvCampeones.Dock = System.Windows.Forms.DockStyle.Right;
            this.lvCampeones.Font = new System.Drawing.Font("Friz Quadrata", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCampeones.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lvCampeones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvCampeones.HideSelection = false;
            this.lvCampeones.Location = new System.Drawing.Point(471, 0);
            this.lvCampeones.Name = "lvCampeones";
            this.lvCampeones.Size = new System.Drawing.Size(329, 450);
            this.lvCampeones.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvCampeones.TabIndex = 7;
            this.lvCampeones.UseCompatibleStateImageBehavior = false;
            this.lvCampeones.View = System.Windows.Forms.View.Details;
            this.lvCampeones.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LvCampeones_MouseDoubleClick);
            // 
            // ilCampeones
            // 
            this.ilCampeones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCampeones.ImageStream")));
            this.ilCampeones.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCampeones.Images.SetKeyName(0, "akali.png");
            this.ilCampeones.Images.SetKeyName(1, "amumu.png");
            this.ilCampeones.Images.SetKeyName(2, "ashe.png");
            this.ilCampeones.Images.SetKeyName(3, "braum.png");
            this.ilCampeones.Images.SetKeyName(4, "darius.png");
            this.ilCampeones.Images.SetKeyName(5, "draven.png");
            this.ilCampeones.Images.SetKeyName(6, "ekko.png");
            this.ilCampeones.Images.SetKeyName(7, "garen.png");
            this.ilCampeones.Images.SetKeyName(8, "graves.png");
            this.ilCampeones.Images.SetKeyName(9, "irelia.png");
            this.ilCampeones.Images.SetKeyName(10, "jarvan_IV.png");
            this.ilCampeones.Images.SetKeyName(11, "jax.png");
            this.ilCampeones.Images.SetKeyName(12, "jayce.png");
            this.ilCampeones.Images.SetKeyName(13, "kaisa.png");
            this.ilCampeones.Images.SetKeyName(14, "kalista.png");
            this.ilCampeones.Images.SetKeyName(15, "katarina.png");
            this.ilCampeones.Images.SetKeyName(16, "kayn.png");
            this.ilCampeones.Images.SetKeyName(17, "leblanc.png");
            this.ilCampeones.Images.SetKeyName(18, "lol_1_1-t2.jpg");
            this.ilCampeones.Images.SetKeyName(19, "lol-logo-rendered-hi-res.png");
            this.ilCampeones.Images.SetKeyName(20, "lucian.png");
            this.ilCampeones.Images.SetKeyName(21, "lux.png");
            this.ilCampeones.Images.SetKeyName(22, "marco.png");
            this.ilCampeones.Images.SetKeyName(23, "miss_fortune.png");
            this.ilCampeones.Images.SetKeyName(24, "mordekaiser.png");
            this.ilCampeones.Images.SetKeyName(25, "nami.png");
            this.ilCampeones.Images.SetKeyName(26, "nautilus.png");
            this.ilCampeones.Images.SetKeyName(27, "neeko.png");
            this.ilCampeones.Images.SetKeyName(28, "nidalee.png");
            this.ilCampeones.Images.SetKeyName(29, "olaf.png");
            this.ilCampeones.Images.SetKeyName(30, "poppy.png");
            this.ilCampeones.Images.SetKeyName(31, "riven.png");
            this.ilCampeones.Images.SetKeyName(32, "senna.png");
            this.ilCampeones.Images.SetKeyName(33, "shen.png");
            this.ilCampeones.Images.SetKeyName(34, "sion.png");
            this.ilCampeones.Images.SetKeyName(35, "sona.png");
            this.ilCampeones.Images.SetKeyName(36, "soraka.png");
            this.ilCampeones.Images.SetKeyName(37, "sylas.png");
            this.ilCampeones.Images.SetKeyName(38, "teemo.png");
            this.ilCampeones.Images.SetKeyName(39, "thresh.png");
            this.ilCampeones.Images.SetKeyName(40, "tryndamere.png");
            this.ilCampeones.Images.SetKeyName(41, "twisted_fate.png");
            this.ilCampeones.Images.SetKeyName(42, "varus.png");
            this.ilCampeones.Images.SetKeyName(43, "warwick.png");
            this.ilCampeones.Images.SetKeyName(44, "xayah.png");
            this.ilCampeones.Images.SetKeyName(45, "yasuo.png");
            this.ilCampeones.Images.SetKeyName(46, "zac.png");
            this.ilCampeones.Images.SetKeyName(47, "zed.png");
            this.ilCampeones.Images.SetKeyName(48, "blitzcranck.png");
            this.ilCampeones.Images.SetKeyName(49, "nunu_y_willum.png");
            // 
            // pbImagenCampeon
            // 
            this.pbImagenCampeon.Location = new System.Drawing.Point(218, 8);
            this.pbImagenCampeon.Name = "pbImagenCampeon";
            this.pbImagenCampeon.Size = new System.Drawing.Size(218, 216);
            this.pbImagenCampeon.TabIndex = 8;
            this.pbImagenCampeon.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(218, 287);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(218, 119);
            this.tbDescripcion.TabIndex = 9;
            // 
            // ilCampeonesCompletos
            // 
            this.ilCampeonesCompletos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilCampeonesCompletos.ImageStream")));
            this.ilCampeonesCompletos.TransparentColor = System.Drawing.Color.Transparent;
            this.ilCampeonesCompletos.Images.SetKeyName(0, "Akali png.png");
            this.ilCampeonesCompletos.Images.SetKeyName(1, "akali.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(2, "amumu_completo.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(3, "ashe.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(4, "asheee.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(5, "atrox.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(6, "blitzcranck.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(7, "cbraum.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(8, "darius.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(9, "draven.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(10, "ekko.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(11, "garen.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(12, "iiii.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(13, "miss_fortune.jpg");
            this.ilCampeonesCompletos.Images.SetKeyName(14, "mumu.jpg");
            // 
            // lbNombreCampeon
            // 
            this.lbNombreCampeon.AutoSize = true;
            this.lbNombreCampeon.Font = new System.Drawing.Font("Friz Quadrata TT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCampeon.Location = new System.Drawing.Point(200, 239);
            this.lbNombreCampeon.Name = "lbNombreCampeon";
            this.lbNombreCampeon.Size = new System.Drawing.Size(256, 33);
            this.lbNombreCampeon.TabIndex = 10;
            this.lbNombreCampeon.Text = "NombreCampeon";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbNombreCampeon);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.pbImagenCampeon);
            this.Controls.Add(this.lvCampeones);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbArma);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbCarril);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCampeon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbCarril;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbArma;
        private System.Windows.Forms.ComboBox cbRegion;
        private System.Windows.Forms.ListView lvCampeones;
        private System.Windows.Forms.ImageList ilCampeones;
        private System.Windows.Forms.PictureBox pbImagenCampeon;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.ImageList ilCampeonesCompletos;
        private System.Windows.Forms.Label lbNombreCampeon;
    }
}

