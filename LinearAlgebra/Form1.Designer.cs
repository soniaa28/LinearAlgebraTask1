namespace LinearAlgebraTask1
{
    partial class Form1
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
            this.CreateMatrix1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NumN = new System.Windows.Forms.NumericUpDown();
            this.NumM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.NumMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumMax = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ReadMatrix1 = new System.Windows.Forms.Button();
            this.ReadMatrix2 = new System.Windows.Forms.Button();
            this.labelNormA = new System.Windows.Forms.Label();
            this.labelNormB = new System.Windows.Forms.Label();
            this.labelNormC = new System.Windows.Forms.Label();
            this.WriteButton = new System.Windows.Forms.Button();
            this.labelModuleA = new System.Windows.Forms.Label();
            this.labelModuleB = new System.Windows.Forms.Label();
            this.labelModuleC = new System.Windows.Forms.Label();
            this.CreateMatrix2 = new System.Windows.Forms.Button();
            this.SubtractionButton = new System.Windows.Forms.Button();
            this.textBoxVector1 = new System.Windows.Forms.TextBox();
            this.textBoxVector2 = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMax)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateMatrix1
            // 
            this.CreateMatrix1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateMatrix1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateMatrix1.Location = new System.Drawing.Point(149, 169);
            this.CreateMatrix1.Margin = new System.Windows.Forms.Padding(2);
            this.CreateMatrix1.Name = "CreateMatrix1";
            this.CreateMatrix1.Size = new System.Drawing.Size(122, 28);
            this.CreateMatrix1.TabIndex = 1;
            this.CreateMatrix1.Text = "Create matrix A";
            this.CreateMatrix1.UseVisualStyleBackColor = true;
            this.CreateMatrix1.Click += new System.EventHandler(this.CreateMatrix1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 150);
            this.textBox1.TabIndex = 2;
            // 
            // NumN
            // 
            this.NumN.Location = new System.Drawing.Point(41, 24);
            this.NumN.Margin = new System.Windows.Forms.Padding(2);
            this.NumN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumN.Name = "NumN";
            this.NumN.Size = new System.Drawing.Size(69, 20);
            this.NumN.TabIndex = 3;
            this.NumN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumM
            // 
            this.NumM.Location = new System.Drawing.Point(41, 51);
            this.NumM.Margin = new System.Windows.Forms.Padding(2);
            this.NumM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumM.Name = "NumM";
            this.NumM.Size = new System.Drawing.Size(69, 20);
            this.NumM.TabIndex = 4;
            this.NumM.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "N =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "M =";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(437, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 150);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(676, 11);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(249, 150);
            this.textBox3.TabIndex = 8;
            // 
            // NumMin
            // 
            this.NumMin.Location = new System.Drawing.Point(68, 107);
            this.NumMin.Margin = new System.Windows.Forms.Padding(2);
            this.NumMin.Name = "NumMin";
            this.NumMin.Size = new System.Drawing.Size(69, 20);
            this.NumMin.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Element Value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Minimun:";
            // 
            // NumMax
            // 
            this.NumMax.Location = new System.Drawing.Point(68, 133);
            this.NumMax.Margin = new System.Windows.Forms.Padding(2);
            this.NumMax.Name = "NumMax";
            this.NumMax.Size = new System.Drawing.Size(69, 20);
            this.NumMax.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Maximum:";
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Location = new System.Drawing.Point(676, 171);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(76, 29);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MultiplyButton.Location = new System.Drawing.Point(756, 171);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(2);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(76, 29);
            this.MultiplyButton.TabIndex = 15;
            this.MultiplyButton.Text = "Multiply";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 211);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(112, 20);
            this.textBox4.TabIndex = 16;
            this.textBox4.Text = "Input.txt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 187);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "File name:";
            // 
            // ReadMatrix1
            // 
            this.ReadMatrix1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadMatrix1.Location = new System.Drawing.Point(275, 168);
            this.ReadMatrix1.Margin = new System.Windows.Forms.Padding(2);
            this.ReadMatrix1.Name = "ReadMatrix1";
            this.ReadMatrix1.Size = new System.Drawing.Size(104, 31);
            this.ReadMatrix1.TabIndex = 18;
            this.ReadMatrix1.Text = "Read to matrix A";
            this.ReadMatrix1.UseVisualStyleBackColor = true;
            this.ReadMatrix1.Click += new System.EventHandler(this.ReadMatrix1_Click);
            // 
            // ReadMatrix2
            // 
            this.ReadMatrix2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ReadMatrix2.Location = new System.Drawing.Point(543, 169);
            this.ReadMatrix2.Margin = new System.Windows.Forms.Padding(2);
            this.ReadMatrix2.Name = "ReadMatrix2";
            this.ReadMatrix2.Size = new System.Drawing.Size(104, 31);
            this.ReadMatrix2.TabIndex = 19;
            this.ReadMatrix2.Text = "Read to matrix B";
            this.ReadMatrix2.UseVisualStyleBackColor = true;
            this.ReadMatrix2.Click += new System.EventHandler(this.ReadMatrix2_Click);
            // 
            // labelNormA
            // 
            this.labelNormA.AutoSize = true;
            this.labelNormA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormA.Location = new System.Drawing.Point(146, 242);
            this.labelNormA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNormA.Name = "labelNormA";
            this.labelNormA.Size = new System.Drawing.Size(54, 15);
            this.labelNormA.TabIndex = 20;
            this.labelNormA.Text = "Norma:";
            // 
            // labelNormB
            // 
            this.labelNormB.AutoSize = true;
            this.labelNormB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormB.Location = new System.Drawing.Point(444, 242);
            this.labelNormB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNormB.Name = "labelNormB";
            this.labelNormB.Size = new System.Drawing.Size(54, 15);
            this.labelNormB.TabIndex = 21;
            this.labelNormB.Text = "Norma:";
            // 
            // labelNormC
            // 
            this.labelNormC.AutoSize = true;
            this.labelNormC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNormC.Location = new System.Drawing.Point(720, 242);
            this.labelNormC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNormC.Name = "labelNormC";
            this.labelNormC.Size = new System.Drawing.Size(54, 15);
            this.labelNormC.TabIndex = 22;
            this.labelNormC.Text = "Norma:";
            // 
            // WriteButton
            // 
            this.WriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WriteButton.Location = new System.Drawing.Point(938, 80);
            this.WriteButton.Margin = new System.Windows.Forms.Padding(2);
            this.WriteButton.Name = "WriteButton";
            this.WriteButton.Size = new System.Drawing.Size(76, 30);
            this.WriteButton.TabIndex = 23;
            this.WriteButton.Text = "Write to file";
            this.WriteButton.UseVisualStyleBackColor = true;
            this.WriteButton.Click += new System.EventHandler(this.WriteButton_Click);
            // 
            // labelModuleA
            // 
            this.labelModuleA.AutoSize = true;
            this.labelModuleA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModuleA.Location = new System.Drawing.Point(144, 216);
            this.labelModuleA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModuleA.Name = "labelModuleA";
            this.labelModuleA.Size = new System.Drawing.Size(90, 15);
            this.labelModuleA.TabIndex = 25;
            this.labelModuleA.Text = "Max module:";
            // 
            // labelModuleB
            // 
            this.labelModuleB.AutoSize = true;
            this.labelModuleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModuleB.Location = new System.Drawing.Point(434, 216);
            this.labelModuleB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModuleB.Name = "labelModuleB";
            this.labelModuleB.Size = new System.Drawing.Size(90, 15);
            this.labelModuleB.TabIndex = 26;
            this.labelModuleB.Text = "Max module:";
            // 
            // labelModuleC
            // 
            this.labelModuleC.AutoSize = true;
            this.labelModuleC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModuleC.Location = new System.Drawing.Point(705, 218);
            this.labelModuleC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelModuleC.Name = "labelModuleC";
            this.labelModuleC.Size = new System.Drawing.Size(90, 15);
            this.labelModuleC.TabIndex = 27;
            this.labelModuleC.Text = "Max module:";
            // 
            // CreateMatrix2
            // 
            this.CreateMatrix2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateMatrix2.Location = new System.Drawing.Point(417, 171);
            this.CreateMatrix2.Margin = new System.Windows.Forms.Padding(2);
            this.CreateMatrix2.Name = "CreateMatrix2";
            this.CreateMatrix2.Size = new System.Drawing.Size(122, 26);
            this.CreateMatrix2.TabIndex = 28;
            this.CreateMatrix2.Text = "Create matrix B";
            this.CreateMatrix2.UseVisualStyleBackColor = true;
            this.CreateMatrix2.Click += new System.EventHandler(this.CreateMatrix2_Click);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SubtractionButton.Location = new System.Drawing.Point(836, 172);
            this.SubtractionButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(76, 28);
            this.SubtractionButton.TabIndex = 29;
            this.SubtractionButton.Text = "Subtraction";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.Click += new System.EventHandler(this.SubtractionButton_Click);
            // 
            // textBoxVector1
            // 
            this.textBoxVector1.Location = new System.Drawing.Point(23, 324);
            this.textBoxVector1.Name = "textBoxVector1";
            this.textBoxVector1.Size = new System.Drawing.Size(100, 20);
            this.textBoxVector1.TabIndex = 30;
            // 
            // textBoxVector2
            // 
            this.textBoxVector2.Location = new System.Drawing.Point(23, 363);
            this.textBoxVector2.Name = "textBoxVector2";
            this.textBoxVector2.Size = new System.Drawing.Size(100, 20);
            this.textBoxVector2.TabIndex = 31;
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(279, 339);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(100, 20);
            this.textBoxSum.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 33;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1048, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxVector2);
            this.Controls.Add(this.textBoxVector1);
            this.Controls.Add(this.SubtractionButton);
            this.Controls.Add(this.CreateMatrix2);
            this.Controls.Add(this.labelModuleC);
            this.Controls.Add(this.labelModuleB);
            this.Controls.Add(this.labelModuleA);
            this.Controls.Add(this.WriteButton);
            this.Controls.Add(this.labelNormC);
            this.Controls.Add(this.labelNormB);
            this.Controls.Add(this.labelNormA);
            this.Controls.Add(this.ReadMatrix2);
            this.Controls.Add(this.ReadMatrix1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.MultiplyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NumMax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumMin);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumM);
            this.Controls.Add(this.NumN);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CreateMatrix1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateMatrix1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown NumN;
        private System.Windows.Forms.NumericUpDown NumM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown NumMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumMax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MultiplyButton;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ReadMatrix1;
        private System.Windows.Forms.Button ReadMatrix2;
        private System.Windows.Forms.Label labelNormA;
        private System.Windows.Forms.Label labelNormB;
        private System.Windows.Forms.Label labelNormC;
        private System.Windows.Forms.Button WriteButton;
        private System.Windows.Forms.Label labelModuleA;
        private System.Windows.Forms.Label labelModuleB;
        private System.Windows.Forms.Label labelModuleC;
        private System.Windows.Forms.Button CreateMatrix2;
        private System.Windows.Forms.Button SubtractionButton;
        private System.Windows.Forms.TextBox textBoxVector1;
        private System.Windows.Forms.TextBox textBoxVector2;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button button1;
    }
}

