namespace EmailApplication
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.Catre3 = new System.Windows.Forms.TextBox();
            this.Catre2 = new System.Windows.Forms.TextBox();
            this.Mesaj = new System.Windows.Forms.RichTextBox();
            this.Subiect = new System.Windows.Forms.TextBox();
            this.Catre1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(66, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(503, 242);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(495, 202);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inbox";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(495, 202);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Outbox";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.Catre3);
            this.tabPage3.Controls.Add(this.Catre2);
            this.tabPage3.Controls.Add(this.Mesaj);
            this.tabPage3.Controls.Add(this.Subiect);
            this.tabPage3.Controls.Add(this.Catre1);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(495, 216);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compose";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Trimiteti";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Catre3
            // 
            this.Catre3.Location = new System.Drawing.Point(241, 61);
            this.Catre3.Name = "Catre3";
            this.Catre3.Size = new System.Drawing.Size(136, 20);
            this.Catre3.TabIndex = 7;
            this.Catre3.Visible = false;
            // 
            // Catre2
            // 
            this.Catre2.Location = new System.Drawing.Point(241, 22);
            this.Catre2.Name = "Catre2";
            this.Catre2.Size = new System.Drawing.Size(136, 20);
            this.Catre2.TabIndex = 6;
            this.Catre2.Visible = false;
            // 
            // Mesaj
            // 
            this.Mesaj.Location = new System.Drawing.Point(28, 101);
            this.Mesaj.Name = "Mesaj";
            this.Mesaj.Size = new System.Drawing.Size(349, 98);
            this.Mesaj.TabIndex = 5;
            this.Mesaj.Text = "";
            // 
            // Subiect
            // 
            this.Subiect.Location = new System.Drawing.Point(80, 61);
            this.Subiect.Name = "Subiect";
            this.Subiect.Size = new System.Drawing.Size(136, 20);
            this.Subiect.TabIndex = 4;
            // 
            // Catre1
            // 
            this.Catre1.Location = new System.Drawing.Point(80, 22);
            this.Catre1.Name = "Catre1";
            this.Catre1.Size = new System.Drawing.Size(136, 20);
            this.Catre1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Mai multi destinatari";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subiect:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 348);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Catre3;
        private System.Windows.Forms.TextBox Catre2;
        private System.Windows.Forms.RichTextBox Mesaj;
        private System.Windows.Forms.TextBox Subiect;
        private System.Windows.Forms.TextBox Catre1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

