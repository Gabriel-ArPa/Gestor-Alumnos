namespace GestorAlumnos
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtDes = new System.Windows.Forms.RadioButton();
            this.rbtApro = new System.Windows.Forms.RadioButton();
            this.rbtTod = new System.Windows.Forms.RadioButton();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.lblProm = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblApe = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAgregar = new System.Windows.Forms.ToolStripButton();
            this.btnListar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnModificar = new System.Windows.Forms.ToolStripButton();
            this.btnMostarHombres = new System.Windows.Forms.ToolStripButton();
            this.btnMostarMujeres = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cbxSex);
            this.groupBox1.Controls.Add(this.txtProm);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.txtCod);
            this.groupBox1.Controls.Add(this.lblProm);
            this.groupBox1.Controls.Add(this.lblSex);
            this.groupBox1.Controls.Add(this.lblApe);
            this.groupBox1.Controls.Add(this.lblNom);
            this.groupBox1.Controls.Add(this.lblCod);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ALUMNOS";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtDes);
            this.groupBox2.Controls.Add(this.rbtApro);
            this.groupBox2.Controls.Add(this.rbtTod);
            this.groupBox2.Location = new System.Drawing.Point(357, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(154, 117);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "GRUPOS";
            // 
            // rbtDes
            // 
            this.rbtDes.AutoSize = true;
            this.rbtDes.Location = new System.Drawing.Point(22, 86);
            this.rbtDes.Name = "rbtDes";
            this.rbtDes.Size = new System.Drawing.Size(122, 21);
            this.rbtDes.TabIndex = 2;
            this.rbtDes.TabStop = true;
            this.rbtDes.Text = "Desaprobados";
            this.rbtDes.UseVisualStyleBackColor = true;
            // 
            // rbtApro
            // 
            this.rbtApro.AutoSize = true;
            this.rbtApro.Location = new System.Drawing.Point(22, 57);
            this.rbtApro.Name = "rbtApro";
            this.rbtApro.Size = new System.Drawing.Size(98, 21);
            this.rbtApro.TabIndex = 1;
            this.rbtApro.TabStop = true;
            this.rbtApro.Text = "Aprobados";
            this.rbtApro.UseVisualStyleBackColor = true;
            // 
            // rbtTod
            // 
            this.rbtTod.AutoSize = true;
            this.rbtTod.Location = new System.Drawing.Point(22, 30);
            this.rbtTod.Name = "rbtTod";
            this.rbtTod.Size = new System.Drawing.Size(69, 21);
            this.rbtTod.TabIndex = 0;
            this.rbtTod.TabStop = true;
            this.rbtTod.Text = "Todos";
            this.rbtTod.UseVisualStyleBackColor = true;
            // 
            // cbxSex
            // 
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cbxSex.Location = new System.Drawing.Point(147, 125);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(135, 24);
            this.cbxSex.TabIndex = 9;
            // 
            // txtProm
            // 
            this.txtProm.Location = new System.Drawing.Point(146, 159);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(79, 22);
            this.txtProm.TabIndex = 8;
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(147, 96);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(135, 22);
            this.txtApe.TabIndex = 7;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(147, 66);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(135, 22);
            this.txtNom.TabIndex = 6;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(147, 36);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(135, 22);
            this.txtCod.TabIndex = 5;
            // 
            // lblProm
            // 
            this.lblProm.AutoSize = true;
            this.lblProm.Location = new System.Drawing.Point(55, 162);
            this.lblProm.Name = "lblProm";
            this.lblProm.Size = new System.Drawing.Size(68, 17);
            this.lblProm.TabIndex = 4;
            this.lblProm.Text = "Promedio";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(55, 128);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(39, 17);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "Sexo";
            // 
            // lblApe
            // 
            this.lblApe.AutoSize = true;
            this.lblApe.Location = new System.Drawing.Point(55, 99);
            this.lblApe.Name = "lblApe";
            this.lblApe.Size = new System.Drawing.Size(58, 17);
            this.lblApe.TabIndex = 2;
            this.lblApe.Text = "Apellido";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(55, 69);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(58, 17);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nombre";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(55, 39);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(52, 17);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Codigo";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAgregar,
            this.btnListar,
            this.btnEliminar,
            this.btnModificar,
            this.btnBuscar,
            this.btnMostarHombres,
            this.btnMostarMujeres,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(767, 71);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAgregar
            // 
            this.btnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(68, 68);
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnListar
            // 
            this.btnListar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnListar.Image = ((System.Drawing.Image)(resources.GetObject("btnListar.Image")));
            this.btnListar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnListar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(68, 68);
            this.btnListar.Text = "Listar";
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 68);
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 68);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(14, 290);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersWidth = 51;
            this.dgvAlumnos.RowTemplate.Height = 24;
            this.dgvAlumnos.Size = new System.Drawing.Size(725, 200);
            this.dgvAlumnos.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(68, 68);
            this.btnEliminar.Text = "Eliminar Alumno";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(68, 68);
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnMostarHombres
            // 
            this.btnMostarHombres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMostarHombres.Image = ((System.Drawing.Image)(resources.GetObject("btnMostarHombres.Image")));
            this.btnMostarHombres.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMostarHombres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostarHombres.Name = "btnMostarHombres";
            this.btnMostarHombres.Size = new System.Drawing.Size(68, 68);
            this.btnMostarHombres.Text = "Listar Varones";
            this.btnMostarHombres.Click += new System.EventHandler(this.btnMostarHombres_Click);
            // 
            // btnMostarMujeres
            // 
            this.btnMostarMujeres.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMostarMujeres.Image = ((System.Drawing.Image)(resources.GetObject("btnMostarMujeres.Image")));
            this.btnMostarMujeres.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMostarMujeres.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostarMujeres.Name = "btnMostarMujeres";
            this.btnMostarMujeres.Size = new System.Drawing.Size(68, 68);
            this.btnMostarMujeres.Text = "Listar Mujeres";
            this.btnMostarMujeres.Click += new System.EventHandler(this.btnMostarMujeres_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(767, 504);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtDes;
        private System.Windows.Forms.RadioButton rbtApro;
        private System.Windows.Forms.RadioButton rbtTod;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label lblProm;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblApe;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAgregar;
        private System.Windows.Forms.ToolStripButton btnListar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnModificar;
        private System.Windows.Forms.ToolStripButton btnMostarHombres;
        private System.Windows.Forms.ToolStripButton btnMostarMujeres;
    }
}

