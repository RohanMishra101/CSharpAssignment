namespace CSharpAssignment
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.getName = new System.Windows.Forms.TextBox();
            this.getAddress = new System.Windows.Forms.TextBox();
            this.getSalary = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.getId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.getId1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(628, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "salary";
            // 
            // getName
            // 
            this.getName.Location = new System.Drawing.Point(94, 72);
            this.getName.Name = "getName";
            this.getName.Size = new System.Drawing.Size(276, 23);
            this.getName.TabIndex = 4;
            this.getName.TextChanged += new System.EventHandler(this.getName_TextChanged);
            // 
            // getAddress
            // 
            this.getAddress.Location = new System.Drawing.Point(94, 105);
            this.getAddress.Name = "getAddress";
            this.getAddress.Size = new System.Drawing.Size(276, 23);
            this.getAddress.TabIndex = 5;
            // 
            // getSalary
            // 
            this.getSalary.Location = new System.Drawing.Point(94, 139);
            this.getSalary.Name = "getSalary";
            this.getSalary.Size = new System.Drawing.Size(276, 23);
            this.getSalary.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(363, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 47);
            this.button3.TabIndex = 11;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(539, 166);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 47);
            this.button4.TabIndex = 12;
            this.button4.Text = "Modify";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // getId
            // 
            this.getId.Location = new System.Drawing.Point(426, 42);
            this.getId.Name = "getId";
            this.getId.Size = new System.Drawing.Size(276, 23);
            this.getId.TabIndex = 14;
            this.getId.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(57, -1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 40);
            this.label5.TabIndex = 15;
            this.label5.Text = "Add Data to Database";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(480, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 40);
            this.label6.TabIndex = 16;
            this.label6.Text = "Delete Data";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(480, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(163, 47);
            this.button5.TabIndex = 17;
            this.button5.Text = "Show Data";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // getId1
            // 
            this.getId1.Location = new System.Drawing.Point(94, 42);
            this.getId1.Name = "getId1";
            this.getId1.Size = new System.Drawing.Size(276, 23);
            this.getId1.TabIndex = 19;
            this.getId1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Id";
            // 
            // dataGridShow
            // 
            this.dataGridShow.Location = new System.Drawing.Point(489, 123);
            this.dataGridShow.Name = "dataGridShow";
            this.dataGridShow.Size = new System.Drawing.Size(149, 26);
            this.dataGridShow.TabIndex = 20;
            this.dataGridShow.Text = "show";
            this.dataGridShow.UseVisualStyleBackColor = true;
            this.dataGridShow.Click += new System.EventHandler(this.dataGridShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 629);
            this.Controls.Add(this.dataGridShow);
            this.Controls.Add(this.getId1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.getId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.getSalary);
            this.Controls.Add(this.getAddress);
            this.Controls.Add(this.getName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "C# Assignment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox getName;
        private TextBox getAddress;
        private TextBox getSalary;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox getId;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button5;
        private TextBox getId1;
        private Label label7;
        private Button dataGridShow;
    }
}