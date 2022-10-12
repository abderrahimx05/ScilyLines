namespace ScilyLines
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secteur = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.update = new System.Windows.Forms.Button();
            this.duree = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inserer = new System.Windows.Forms.Button();
            this.laison = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(601, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ScilyLines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secteurs";
            // 
            // secteur
            // 
            this.secteur.FormattingEnabled = true;
            this.secteur.ItemHeight = 21;
            this.secteur.Location = new System.Drawing.Point(12, 144);
            this.secteur.Name = "secteur";
            this.secteur.Size = new System.Drawing.Size(122, 130);
            this.secteur.TabIndex = 2;
            this.secteur.MouseClick += new System.Windows.Forms.MouseEventHandler(this.secteur_MouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.Controls.Add(this.update);
            this.panel2.Controls.Add(this.duree);
            this.panel2.Controls.Add(this.modifier);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.inserer);
            this.panel2.Location = new System.Drawing.Point(0, 394);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(721, 63);
            this.panel2.TabIndex = 3;
            // 
            // update
            // 
            this.update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update.Location = new System.Drawing.Point(527, 18);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 28);
            this.update.TabIndex = 4;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Visible = false;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(387, 18);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(125, 28);
            this.duree.TabIndex = 3;
            this.duree.Visible = false;
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Black;
            this.modifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifier.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.modifier.Location = new System.Drawing.Point(266, 18);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(99, 32);
            this.modifier.TabIndex = 2;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(140, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Suprimer";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // inserer
            // 
            this.inserer.BackColor = System.Drawing.Color.Black;
            this.inserer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inserer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inserer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.inserer.Location = new System.Drawing.Point(12, 18);
            this.inserer.Name = "inserer";
            this.inserer.Size = new System.Drawing.Size(100, 32);
            this.inserer.TabIndex = 0;
            this.inserer.Text = "Insérer";
            this.inserer.UseVisualStyleBackColor = false;
            // 
            // laison
            // 
            this.laison.FormattingEnabled = true;
            this.laison.ItemHeight = 21;
            this.laison.Location = new System.Drawing.Point(248, 144);
            this.laison.Name = "laison";
            this.laison.Size = new System.Drawing.Size(449, 130);
            this.laison.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Liaisons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.laison);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.secteur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox secteur;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button inserer;
        private System.Windows.Forms.ListBox laison;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.Button update;
    }
}

