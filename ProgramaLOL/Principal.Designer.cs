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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCampeon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.btnCalcular.Location = new System.Drawing.Point(83, 290);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 29);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "BUSCAR";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.cbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSexo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "SEXO",
            "femenino",
            "masculino"});
            this.cbSexo.Location = new System.Drawing.Point(41, 79);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(176, 26);
            this.cbSexo.TabIndex = 2;
            // 
            // cbCarril
            // 
            this.cbCarril.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.cbCarril.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarril.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbCarril.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarril.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbCarril.FormattingEnabled = true;
            this.cbCarril.Items.AddRange(new object[] {
            "CARRIL",
            "jungla",
            "top",
            "soporte",
            "adc",
            "mid"});
            this.cbCarril.Location = new System.Drawing.Point(41, 120);
            this.cbCarril.Name = "cbCarril";
            this.cbCarril.Size = new System.Drawing.Size(176, 26);
            this.cbCarril.TabIndex = 3;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbTipo.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "TIPO",
            "luchador",
            "mago",
            "tirador",
            "tanque",
            "asesino"});
            this.cbTipo.Location = new System.Drawing.Point(41, 159);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(176, 26);
            this.cbTipo.TabIndex = 4;
            // 
            // cbArma
            // 
            this.cbArma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.cbArma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbArma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbArma.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbArma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
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
            this.cbArma.Location = new System.Drawing.Point(41, 201);
            this.cbArma.Name = "cbArma";
            this.cbArma.Size = new System.Drawing.Size(176, 26);
            this.cbArma.TabIndex = 5;
            // 
            // cbRegion
            // 
            this.cbRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.cbRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRegion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbRegion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
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
            this.cbRegion.Location = new System.Drawing.Point(41, 245);
            this.cbRegion.Name = "cbRegion";
            this.cbRegion.Size = new System.Drawing.Size(176, 26);
            this.cbRegion.TabIndex = 6;
            // 
            // lvCampeones
            // 
            this.lvCampeones.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvCampeones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.lvCampeones.BackgroundImageTiled = true;
            this.lvCampeones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvCampeones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvCampeones.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvCampeones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.lvCampeones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvCampeones.HideSelection = false;
            this.lvCampeones.Location = new System.Drawing.Point(0, 0);
            this.lvCampeones.Name = "lvCampeones";
            this.lvCampeones.Size = new System.Drawing.Size(275, 320);
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
            this.pbImagenCampeon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbImagenCampeon.Location = new System.Drawing.Point(82, 4);
            this.pbImagenCampeon.Name = "pbImagenCampeon";
            this.pbImagenCampeon.Size = new System.Drawing.Size(338, 188);
            this.pbImagenCampeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagenCampeon.TabIndex = 8;
            this.pbImagenCampeon.TabStop = false;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.tbDescripcion.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.tbDescripcion.Location = new System.Drawing.Point(67, 262);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(373, 71);
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
            this.lbNombreCampeon.BackColor = System.Drawing.Color.Transparent;
            this.lbNombreCampeon.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombreCampeon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.lbNombreCampeon.Location = new System.Drawing.Point(140, 228);
            this.lbNombreCampeon.Name = "lbNombreCampeon";
            this.lbNombreCampeon.Size = new System.Drawing.Size(213, 29);
            this.lbNombreCampeon.TabIndex = 10;
            this.lbNombreCampeon.Text = "NombreCampeon";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbSexo);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.cbCarril);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.cbArma);
            this.panel1.Controls.Add(this.cbRegion);
            this.panel1.Location = new System.Drawing.Point(34, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 337);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ProgramaLOL.Properties.Resources.content_type_icon_champion__3nwJQ___copia;
            this.pictureBox6.Location = new System.Drawing.Point(4, 27);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(28, 28);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(32, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "CARACTERÍSTICAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pbImagenCampeon);
            this.panel2.Controls.Add(this.tbDescripcion);
            this.panel2.Controls.Add(this.lbNombreCampeon);
            this.panel2.Location = new System.Drawing.Point(275, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 351);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ProgramaLOL.Properties.Resources.Akali_png1;
            this.pictureBox5.Location = new System.Drawing.Point(271, 212);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(279, 1);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ProgramaLOL.Properties.Resources.Akali_png___copia;
            this.pictureBox4.Location = new System.Drawing.Point(-54, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(279, 1);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(270, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(279, 1);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProgramaLOL.Properties.Resources.content_type_icon_universe__14mjH;
            this.pictureBox2.Location = new System.Drawing.Point(229, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvCampeones);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(730, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 320);
            this.panel3.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(106)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(782, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "CAMPEAONES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProgramaLOL.Properties.Resources.content_type_icon_champion__3nwJQ___copia;
            this.pictureBox1.Location = new System.Drawing.Point(748, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(24)))));
            this.BackgroundImage = global::ProgramaLOL.Properties.Resources.marco;
            this.ClientSize = new System.Drawing.Size(1038, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChampionsLOL";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenCampeon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
    }
}

