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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.cbCarril = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbArma = new System.Windows.Forms.ComboBox();
            this.cbRegion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(367, 384);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "btnCalcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.Location = new System.Drawing.Point(322, 171);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(120, 95);
            this.lbInfo.TabIndex = 1;
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbRegion);
            this.Controls.Add(this.cbArma);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.cbCarril);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.ComboBox cbCarril;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbArma;
        private System.Windows.Forms.ComboBox cbRegion;
    }
}

