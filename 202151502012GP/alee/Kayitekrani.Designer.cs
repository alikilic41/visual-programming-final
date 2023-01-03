namespace alee
{
    partial class Kayitekrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayitekrani));
            this.kytad = new System.Windows.Forms.TextBox();
            this.kytprl2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.kytprl = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // kytad
            // 
            this.kytad.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kytad.Location = new System.Drawing.Point(75, 161);
            this.kytad.Name = "kytad";
            this.kytad.Size = new System.Drawing.Size(172, 21);
            this.kytad.TabIndex = 0;
            this.kytad.Text = "KullanıcıAdı";
            this.kytad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.kytad.Enter += new System.EventHandler(this.textBox1_Enter);
            this.kytad.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // kytprl2
            // 
            this.kytprl2.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kytprl2.Location = new System.Drawing.Point(75, 235);
            this.kytprl2.Name = "kytprl2";
            this.kytprl2.Size = new System.Drawing.Size(172, 21);
            this.kytprl2.TabIndex = 2;
            this.kytprl2.Text = "ParolaTekrarı";
            this.kytprl2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.kytprl2.Enter += new System.EventHandler(this.textBox3_Enter);
            this.kytprl2.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(86, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kayıt Ol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kytprl
            // 
            this.kytprl.Font = new System.Drawing.Font("Corbel", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kytprl.Location = new System.Drawing.Point(75, 201);
            this.kytprl.Name = "kytprl";
            this.kytprl.Size = new System.Drawing.Size(172, 21);
            this.kytprl.TabIndex = 4;
            this.kytprl.Text = "Parola";
            this.kytprl.Enter += new System.EventHandler(this.textBox2_Enter);
            this.kytprl.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.ForeColor = System.Drawing.Color.White;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(19, 359);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(78, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Anasayfaya Git";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Kayitekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(332, 391);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.kytprl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.kytprl2);
            this.Controls.Add(this.kytad);
            this.Name = "Kayitekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.kayitekrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kytad;
        private System.Windows.Forms.TextBox kytprl2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox kytprl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}