
namespace lab2z1
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
            this.lblWzrost = new System.Windows.Forms.Label();
            this.lblPlec = new System.Windows.Forms.Label();
            this.grpWaga = new System.Windows.Forms.GroupBox();
            this.cbStandardowa = new System.Windows.Forms.CheckBox();
            this.cbIdealna = new System.Windows.Forms.CheckBox();
            this.tbWzrost = new System.Windows.Forms.TextBox();
            this.rdoKobieta = new System.Windows.Forms.RadioButton();
            this.btnLicz = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.rdoMezczyzna = new System.Windows.Forms.RadioButton();
            this.grpWaga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWzrost
            // 
            this.lblWzrost.AutoSize = true;
            this.lblWzrost.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWzrost.Location = new System.Drawing.Point(12, 21);
            this.lblWzrost.Name = "lblWzrost";
            this.lblWzrost.Size = new System.Drawing.Size(136, 20);
            this.lblWzrost.TabIndex = 0;
            this.lblWzrost.Text = "Podaj wzrost [cm]";
            // 
            // lblPlec
            // 
            this.lblPlec.AutoSize = true;
            this.lblPlec.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlec.Location = new System.Drawing.Point(12, 63);
            this.lblPlec.Name = "lblPlec";
            this.lblPlec.Size = new System.Drawing.Size(81, 20);
            this.lblPlec.TabIndex = 1;
            this.lblPlec.Text = "Podaj płeć";
            // 
            // grpWaga
            // 
            this.grpWaga.Controls.Add(this.cbStandardowa);
            this.grpWaga.Controls.Add(this.cbIdealna);
            this.grpWaga.Location = new System.Drawing.Point(320, 21);
            this.grpWaga.Name = "grpWaga";
            this.grpWaga.Size = new System.Drawing.Size(139, 78);
            this.grpWaga.TabIndex = 2;
            this.grpWaga.TabStop = false;
            this.grpWaga.Text = "Waga";
            // 
            // cbStandardowa
            // 
            this.cbStandardowa.AutoSize = true;
            this.cbStandardowa.Location = new System.Drawing.Point(6, 22);
            this.cbStandardowa.Name = "cbStandardowa";
            this.cbStandardowa.Size = new System.Drawing.Size(95, 19);
            this.cbStandardowa.TabIndex = 2;
            this.cbStandardowa.Text = "Standardowa";
            this.cbStandardowa.UseVisualStyleBackColor = true;
            this.cbStandardowa.CheckedChanged += new System.EventHandler(this.cbStandardowa_CheckedChanged);
            // 
            // cbIdealna
            // 
            this.cbIdealna.AutoSize = true;
            this.cbIdealna.Location = new System.Drawing.Point(6, 47);
            this.cbIdealna.Name = "cbIdealna";
            this.cbIdealna.Size = new System.Drawing.Size(64, 19);
            this.cbIdealna.TabIndex = 1;
            this.cbIdealna.Text = "Idealna";
            this.cbIdealna.UseVisualStyleBackColor = true;
            this.cbIdealna.CheckedChanged += new System.EventHandler(this.cbIdealna_CheckedChanged);
            // 
            // tbWzrost
            // 
            this.tbWzrost.Location = new System.Drawing.Point(156, 22);
            this.tbWzrost.Name = "tbWzrost";
            this.tbWzrost.Size = new System.Drawing.Size(100, 23);
            this.tbWzrost.TabIndex = 3;
            // 
            // rdoKobieta
            // 
            this.rdoKobieta.AutoSize = true;
            this.rdoKobieta.Location = new System.Drawing.Point(156, 65);
            this.rdoKobieta.Name = "rdoKobieta";
            this.rdoKobieta.Size = new System.Drawing.Size(65, 19);
            this.rdoKobieta.TabIndex = 4;
            this.rdoKobieta.TabStop = true;
            this.rdoKobieta.Text = "Kobieta";
            this.rdoKobieta.UseVisualStyleBackColor = true;
            // 
            // btnLicz
            // 
            this.btnLicz.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLicz.Location = new System.Drawing.Point(143, 114);
            this.btnLicz.Name = "btnLicz";
            this.btnLicz.Size = new System.Drawing.Size(137, 44);
            this.btnLicz.TabIndex = 6;
            this.btnLicz.Text = "Oblicz";
            this.btnLicz.UseVisualStyleBackColor = true;
            this.btnLicz.Click += new System.EventHandler(this.btnLicz_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(12, 180);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(40, 15);
            this.lblWynik.TabIndex = 7;
            this.lblWynik.Text = "Wynik";
            // 
            // rdoMezczyzna
            // 
            this.rdoMezczyzna.AutoSize = true;
            this.rdoMezczyzna.Location = new System.Drawing.Point(227, 65);
            this.rdoMezczyzna.Name = "rdoMezczyzna";
            this.rdoMezczyzna.Size = new System.Drawing.Size(82, 19);
            this.rdoMezczyzna.TabIndex = 8;
            this.rdoMezczyzna.TabStop = true;
            this.rdoMezczyzna.Text = "Mężczyzna";
            this.rdoMezczyzna.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 217);
            this.Controls.Add(this.rdoMezczyzna);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnLicz);
            this.Controls.Add(this.rdoKobieta);
            this.Controls.Add(this.tbWzrost);
            this.Controls.Add(this.grpWaga);
            this.Controls.Add(this.lblPlec);
            this.Controls.Add(this.lblWzrost);
            this.Name = "Form1";
            this.Text = "Form w61895";
            this.grpWaga.ResumeLayout(false);
            this.grpWaga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWzrost;
        private System.Windows.Forms.Label lblPlec;
        private System.Windows.Forms.GroupBox grpWaga;
        private System.Windows.Forms.TextBox tbWzrost;
        private System.Windows.Forms.CheckBox cbIdealna;
        private System.Windows.Forms.RadioButton rdoKobieta;
        private System.Windows.Forms.Button btnLicz;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.RadioButton rdoMezczyzna;
        private System.Windows.Forms.CheckBox cbStandardowa;
    }
}

