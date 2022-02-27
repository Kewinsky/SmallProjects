namespace call_log_management
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Leelawadee", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign Up";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(12, 115);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Jan Kowalski";
            this.textBox1.Size = new System.Drawing.Size(426, 40);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(12, 235);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Phone number";
            this.textBox3.Size = new System.Drawing.Size(426, 40);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(12, 175);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "jankowalski@gmail.com";
            this.textBox2.Size = new System.Drawing.Size(426, 40);
            this.textBox2.TabIndex = 4;
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown_1);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(596, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm ✓";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(12, 295);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Password";
            this.textBox4.Size = new System.Drawing.Size(426, 40);
            this.textBox4.TabIndex = 7;
            this.textBox4.UseSystemPasswordChar = true;
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox4_KeyDown);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox4;
        private ErrorProvider errorProvider1;
    }
}