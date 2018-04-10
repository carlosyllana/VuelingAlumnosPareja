namespace Vueling.Presentation.WinSite
{
    partial class AlumnosShowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshowjson = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buscar = new System.Windows.Forms.Label();
            this.btnshowxml = new System.Windows.Forms.Button();
            this.btnShowTxt = new System.Windows.Forms.Button();
            this.btnAñadirAlumnos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(162, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnshowjson
            // 
            this.btnshowjson.Location = new System.Drawing.Point(343, 59);
            this.btnshowjson.Name = "btnshowjson";
            this.btnshowjson.Size = new System.Drawing.Size(75, 23);
            this.btnshowjson.TabIndex = 4;
            this.btnshowjson.Text = "Show json";
            this.btnshowjson.UseVisualStyleBackColor = true;
            this.btnshowjson.Click += new System.EventHandler(this.btnshowjson_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buscar
            // 
            this.buscar.AutoSize = true;
            this.buscar.Location = new System.Drawing.Point(243, 23);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(40, 13);
            this.buscar.TabIndex = 6;
            this.buscar.Text = "Buscar";
            // 
            // btnshowxml
            // 
            this.btnshowxml.Location = new System.Drawing.Point(456, 59);
            this.btnshowxml.Name = "btnshowxml";
            this.btnshowxml.Size = new System.Drawing.Size(75, 23);
            this.btnshowxml.TabIndex = 7;
            this.btnshowxml.Text = "Show xml";
            this.btnshowxml.UseVisualStyleBackColor = true;
            this.btnshowxml.Click += new System.EventHandler(this.btnshowxml_Click);
            // 
            // btnShowTxt
            // 
            this.btnShowTxt.Location = new System.Drawing.Point(246, 59);
            this.btnShowTxt.Name = "btnShowTxt";
            this.btnShowTxt.Size = new System.Drawing.Size(75, 23);
            this.btnShowTxt.TabIndex = 8;
            this.btnShowTxt.Text = "Show txt";
            this.btnShowTxt.UseVisualStyleBackColor = true;
            this.btnShowTxt.Click += new System.EventHandler(this.btnShowTxt_Click);
            // 
            // btnAñadirAlumnos
            // 
            this.btnAñadirAlumnos.Location = new System.Drawing.Point(343, 335);
            this.btnAñadirAlumnos.Name = "btnAñadirAlumnos";
            this.btnAñadirAlumnos.Size = new System.Drawing.Size(75, 23);
            this.btnAñadirAlumnos.TabIndex = 9;
            this.btnAñadirAlumnos.Text = "Añadir alumnos";
            this.btnAñadirAlumnos.UseVisualStyleBackColor = true;
            this.btnAñadirAlumnos.Click += new System.EventHandler(this.btnAñadirAlumnos_Click);
            // 
            // AlumnosShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.btnAñadirAlumnos);
            this.Controls.Add(this.btnShowTxt);
            this.Controls.Add(this.btnshowxml);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnshowjson);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AlumnosShowForm";
            this.Text = "AlumnosShowForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshowjson;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label buscar;
        private System.Windows.Forms.Button btnshowxml;
        private System.Windows.Forms.Button btnShowTxt;
        private System.Windows.Forms.Button btnAñadirAlumnos;
    }
}