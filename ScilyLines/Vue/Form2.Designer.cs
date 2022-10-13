namespace ScilyLines.Vue
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.arrive = new System.Windows.Forms.TextBox();
            this.arriveee = new System.Windows.Forms.TextBox();
            this.ajouter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.duree = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.id_sec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.arv = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.arv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.id_sec);
            this.panel1.Controls.Add(this.arrive);
            this.panel1.Controls.Add(this.arriveee);
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.duree);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 378);
            this.panel1.TabIndex = 0;
            // 
            // arrive
            // 
            this.arrive.Location = new System.Drawing.Point(249, 168);
            this.arrive.Name = "arrive";
            this.arrive.Size = new System.Drawing.Size(100, 20);
            this.arrive.TabIndex = 9;
            // 
            // arriveee
            // 
            this.arriveee.Location = new System.Drawing.Point(3, 432);
            this.arriveee.Name = "arriveee";
            this.arriveee.Size = new System.Drawing.Size(10, 20);
            this.arriveee.TabIndex = 8;
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.RosyBrown;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(405, 329);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(100, 34);
            this.ajouter.TabIndex = 7;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "DUREE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "PORT ARRIVEE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PORT DEPART";
            // 
            // duree
            // 
            this.duree.Location = new System.Drawing.Point(249, 238);
            this.duree.Name = "duree";
            this.duree.Size = new System.Drawing.Size(100, 20);
            this.duree.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUTER UNE LIAISON";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // id_sec
            // 
            this.id_sec.Location = new System.Drawing.Point(249, 132);
            this.id_sec.Name = "id_sec";
            this.id_sec.Size = new System.Drawing.Size(100, 20);
            this.id_sec.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ID secteur";
            // 
            // arv
            // 
            this.arv.Location = new System.Drawing.Point(249, 203);
            this.arv.Name = "arv";
            this.arv.Size = new System.Drawing.Size(100, 20);
            this.arv.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 375);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox duree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.TextBox arrive;
        private System.Windows.Forms.TextBox arriveee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox id_sec;
        private System.Windows.Forms.TextBox arv;
    }
}