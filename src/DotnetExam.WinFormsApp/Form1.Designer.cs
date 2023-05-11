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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(378, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 92);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(360, 346);
            dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(409, 92);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(360, 346);
            dataGridView2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 23);
            textBox1.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(409, 74);
            label3.Name = "label3";
            label3.Size = new Size(171, 15);
            label3.TabIndex = 6;
            label3.Text = "Alumnos de la materia XXXXXX";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}