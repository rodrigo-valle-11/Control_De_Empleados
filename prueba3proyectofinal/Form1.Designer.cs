namespace prueba3proyectofinal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guardreg = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ape = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.suel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGGS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IRTRA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emp = new System.Windows.Forms.Label();
            this.ST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guardreg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guardreg
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.guardreg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guardreg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guardreg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.guardreg.BackgroundColor = System.Drawing.Color.Snow;
            this.guardreg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guardreg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guardreg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.APELLIDO,
            this.SUELDO,
            this.ISR,
            this.IGGS,
            this.IRTRA,
            this.ST});
            this.guardreg.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guardreg.Location = new System.Drawing.Point(-4, 216);
            this.guardreg.Name = "guardreg";
            this.guardreg.Size = new System.Drawing.Size(732, 208);
            this.guardreg.TabIndex = 0;
            this.guardreg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.guardreg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(210, 9);
            label1.Name = "label1";
            label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            label1.Size = new System.Drawing.Size(335, 18);
            label1.TabIndex = 1;
            label1.Text = "CONTROL DE EMPLEADOS \"EL CHISPUDO\"";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.emp);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.suel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ape);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(8, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INGRESO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(109, 36);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(100, 22);
            this.nom.TabIndex = 1;
            this.nom.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "APELLIDO";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // ape
            // 
            this.ape.Location = new System.Drawing.Point(109, 83);
            this.ape.Name = "ape";
            this.ape.Size = new System.Drawing.Size(100, 22);
            this.ape.TabIndex = 1;
            this.ape.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "SUELDO";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // suel
            // 
            this.suel.Location = new System.Drawing.Point(109, 136);
            this.suel.Name = "suel";
            this.suel.Size = new System.Drawing.Size(100, 22);
            this.suel.TabIndex = 1;
            this.suel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.suel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.suel_KeyPress);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(477, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "SALIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(477, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "ELIMINAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(477, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "GUARDAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Empleado";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 109;
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "APELLIDO EMPLEADO";
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.Width = 133;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO EMPLEADO";
            this.SUELDO.Name = "SUELDO";
            this.SUELDO.Width = 126;
            // 
            // ISR
            // 
            this.ISR.HeaderText = "ISR";
            this.ISR.Name = "ISR";
            this.ISR.Width = 50;
            // 
            // IGGS
            // 
            this.IGGS.HeaderText = "IGGS";
            this.IGGS.Name = "IGGS";
            this.IGGS.Width = 58;
            // 
            // IRTRA
            // 
            this.IRTRA.HeaderText = "IRTRA";
            this.IRTRA.Name = "IRTRA";
            this.IRTRA.Width = 65;
            // 
            // emp
            // 
            this.emp.AutoSize = true;
            this.emp.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp.Location = new System.Drawing.Point(273, 129);
            this.emp.Name = "emp";
            this.emp.Size = new System.Drawing.Size(115, 25);
            this.emp.TabIndex = 3;
            this.emp.Text = "EMPLEADO";
            // 
            // ST
            // 
            this.ST.HeaderText = "Sueldo Total";
            this.ST.Name = "ST";
            this.ST.Width = 85;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.guardreg);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.guardreg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView guardreg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox nom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox suel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISR;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGGS;
        private System.Windows.Forms.DataGridViewTextBoxColumn IRTRA;
        private System.Windows.Forms.Label emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ST;
    }
}

