namespace DotnetExam.WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvMaterias = new DataGridView();
            materiaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            materiaBindingSource = new BindingSource(components);
            dgvAlumnos = new DataGridView();
            txtBuscador = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lblAlumnos = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)materiaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // dgvMaterias
            // 
            dgvMaterias.AutoGenerateColumns = false;
            dgvMaterias.BackgroundColor = SystemColors.ButtonHighlight;
            dgvMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Columns.AddRange(new DataGridViewColumn[] { materiaIdDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn });
            dgvMaterias.DataSource = materiaBindingSource;
            dgvMaterias.Location = new Point(12, 92);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new Size(243, 346);
            dgvMaterias.TabIndex = 1;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            dgvMaterias.CellContentClick += dgvMaterias_CellContentClick;
            // 
            // materiaIdDataGridViewTextBoxColumn
            // 
            materiaIdDataGridViewTextBoxColumn.DataPropertyName = "MateriaId";
            materiaIdDataGridViewTextBoxColumn.HeaderText = "MateriaId";
            materiaIdDataGridViewTextBoxColumn.Name = "materiaIdDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // materiaBindingSource
            // 
            materiaBindingSource.DataSource = typeof(Entities.Materia);
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAlumnos.BackgroundColor = SystemColors.ControlLightLight;
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(314, 92);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowTemplate.Height = 25;
            dgvAlumnos.Size = new Size(360, 346);
            dgvAlumnos.TabIndex = 2;
            dgvAlumnos.CellFormatting += dgvAlumnos_CellFormatting;
            // 
            // txtBuscador
            // 
            txtBuscador.Location = new Point(12, 30);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(360, 23);
            txtBuscador.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese la materia a buscar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 74);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Materias";
            // 
            // lblAlumnos
            // 
            lblAlumnos.AutoSize = true;
            lblAlumnos.Location = new Point(314, 74);
            lblAlumnos.Name = "lblAlumnos";
            lblAlumnos.Size = new Size(171, 15);
            lblAlumnos.TabIndex = 6;
            lblAlumnos.Text = "Alumnos de la materia XXXXXX";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.ActiveCaption;
            btnBuscar.ForeColor = SystemColors.ControlText;
            btnBuscar.Location = new Point(378, 29);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 24);
            btnBuscar.TabIndex = 0;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAlumnos);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBuscador);
            Controls.Add(dgvAlumnos);
            Controls.Add(dgvMaterias);
            Controls.Add(btnBuscar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ((System.ComponentModel.ISupportInitialize)materiaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvMaterias;
        private DataGridView dgvAlumnos;
        private TextBox txtBuscador;
        private Label label1;
        private Label label2;
        private Label lblAlumnos;
        private DataGridViewTextBoxColumn materiaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private BindingSource materiaBindingSource;
        private Button btnBuscar;
    }
}