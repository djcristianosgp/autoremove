namespace AutoRemove
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
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            txtPastaSelecionada = new System.Windows.Forms.TextBox();
            btnSelecionarPasta = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            panel2 = new System.Windows.Forms.Panel();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(800, 77);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(800, 77);
            label1.TabIndex = 0;
            label1.Text = "Auto Remove";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btnSelecionarPasta);
            groupBox1.Controls.Add(txtPastaSelecionada);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            groupBox1.Location = new System.Drawing.Point(0, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(800, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(97, 15);
            label2.TabIndex = 0;
            label2.Text = "Selecione a pasta";
            // 
            // txtPastaSelecionada
            // 
            txtPastaSelecionada.BackColor = System.Drawing.Color.Silver;
            txtPastaSelecionada.Location = new System.Drawing.Point(6, 37);
            txtPastaSelecionada.Name = "txtPastaSelecionada";
            txtPastaSelecionada.Size = new System.Drawing.Size(327, 23);
            txtPastaSelecionada.TabIndex = 1;
            // 
            // btnSelecionarPasta
            // 
            btnSelecionarPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSelecionarPasta.Location = new System.Drawing.Point(339, 37);
            btnSelecionarPasta.Name = "btnSelecionarPasta";
            btnSelecionarPasta.Size = new System.Drawing.Size(23, 23);
            btnSelecionarPasta.TabIndex = 2;
            btnSelecionarPasta.Text = "...";
            btnSelecionarPasta.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Right;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.Location = new System.Drawing.Point(709, 19);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(88, 78);
            button1.TabIndex = 3;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Location = new System.Drawing.Point(0, 177);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(800, 50);
            panel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Right;
            button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button2.Location = new System.Drawing.Point(712, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(88, 50);
            button2.TabIndex = 4;
            button2.Text = "...";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = System.Windows.Forms.DockStyle.Right;
            button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button3.Location = new System.Drawing.Point(624, 0);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(88, 50);
            button3.TabIndex = 5;
            button3.Text = "...";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            ForeColor = System.Drawing.Color.White;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSelecionarPasta;
        private System.Windows.Forms.TextBox txtPastaSelecionada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}
