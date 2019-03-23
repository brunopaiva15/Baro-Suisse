namespace Bareme_Suisse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPointsObtenus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxPointsTotaux = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblNote15 = new System.Windows.Forms.Label();
            this.lblNote2 = new System.Windows.Forms.Label();
            this.lblNote25 = new System.Windows.Forms.Label();
            this.lblNote3 = new System.Windows.Forms.Label();
            this.lblNote35 = new System.Windows.Forms.Label();
            this.lblNote4 = new System.Windows.Forms.Label();
            this.lblNote45 = new System.Windows.Forms.Label();
            this.lblNote5 = new System.Windows.Forms.Label();
            this.lblNote55 = new System.Windows.Forms.Label();
            this.lblNote6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Baro\'Suisse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Points obtenus :";
            // 
            // tbxPointsObtenus
            // 
            this.tbxPointsObtenus.Location = new System.Drawing.Point(102, 70);
            this.tbxPointsObtenus.Name = "tbxPointsObtenus";
            this.tbxPointsObtenus.Size = new System.Drawing.Size(112, 20);
            this.tbxPointsObtenus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Points totaux :";
            // 
            // tbxPointsTotaux
            // 
            this.tbxPointsTotaux.Location = new System.Drawing.Point(102, 100);
            this.tbxPointsTotaux.Name = "tbxPointsTotaux";
            this.tbxPointsTotaux.Size = new System.Drawing.Size(112, 20);
            this.tbxPointsTotaux.TabIndex = 4;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(13, 137);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(137, 23);
            this.btnCalculer.TabIndex = 5;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(13, 178);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(70, 22);
            this.lblNote.TabIndex = 6;
            this.lblNote.Text = "Note : ";
            // 
            // lblNote15
            // 
            this.lblNote15.AutoSize = true;
            this.lblNote15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote15.Location = new System.Drawing.Point(13, 213);
            this.lblNote15.Name = "lblNote15";
            this.lblNote15.Size = new System.Drawing.Size(137, 13);
            this.lblNote15.TabIndex = 7;
            this.lblNote15.Text = "Points pour avoir 1.5 : ";
            // 
            // lblNote2
            // 
            this.lblNote2.AutoSize = true;
            this.lblNote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote2.Location = new System.Drawing.Point(13, 237);
            this.lblNote2.Name = "lblNote2";
            this.lblNote2.Size = new System.Drawing.Size(126, 13);
            this.lblNote2.TabIndex = 8;
            this.lblNote2.Text = "Points pour avoir 2 : ";
            // 
            // lblNote25
            // 
            this.lblNote25.AutoSize = true;
            this.lblNote25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote25.Location = new System.Drawing.Point(13, 261);
            this.lblNote25.Name = "lblNote25";
            this.lblNote25.Size = new System.Drawing.Size(137, 13);
            this.lblNote25.TabIndex = 9;
            this.lblNote25.Text = "Points pour avoir 2.5 : ";
            // 
            // lblNote3
            // 
            this.lblNote3.AutoSize = true;
            this.lblNote3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote3.Location = new System.Drawing.Point(13, 285);
            this.lblNote3.Name = "lblNote3";
            this.lblNote3.Size = new System.Drawing.Size(126, 13);
            this.lblNote3.TabIndex = 10;
            this.lblNote3.Text = "Points pour avoir 3 : ";
            // 
            // lblNote35
            // 
            this.lblNote35.AutoSize = true;
            this.lblNote35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote35.Location = new System.Drawing.Point(13, 309);
            this.lblNote35.Name = "lblNote35";
            this.lblNote35.Size = new System.Drawing.Size(137, 13);
            this.lblNote35.TabIndex = 11;
            this.lblNote35.Text = "Points pour avoir 3.5 : ";
            // 
            // lblNote4
            // 
            this.lblNote4.AutoSize = true;
            this.lblNote4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote4.Location = new System.Drawing.Point(13, 333);
            this.lblNote4.Name = "lblNote4";
            this.lblNote4.Size = new System.Drawing.Size(126, 13);
            this.lblNote4.TabIndex = 12;
            this.lblNote4.Text = "Points pour avoir 4 : ";
            // 
            // lblNote45
            // 
            this.lblNote45.AutoSize = true;
            this.lblNote45.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote45.Location = new System.Drawing.Point(13, 357);
            this.lblNote45.Name = "lblNote45";
            this.lblNote45.Size = new System.Drawing.Size(137, 13);
            this.lblNote45.TabIndex = 13;
            this.lblNote45.Text = "Points pour avoir 4.5 : ";
            // 
            // lblNote5
            // 
            this.lblNote5.AutoSize = true;
            this.lblNote5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote5.Location = new System.Drawing.Point(13, 381);
            this.lblNote5.Name = "lblNote5";
            this.lblNote5.Size = new System.Drawing.Size(126, 13);
            this.lblNote5.TabIndex = 14;
            this.lblNote5.Text = "Points pour avoir 5 : ";
            // 
            // lblNote55
            // 
            this.lblNote55.AutoSize = true;
            this.lblNote55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote55.Location = new System.Drawing.Point(13, 405);
            this.lblNote55.Name = "lblNote55";
            this.lblNote55.Size = new System.Drawing.Size(137, 13);
            this.lblNote55.TabIndex = 15;
            this.lblNote55.Text = "Points pour avoir 5.5 : ";
            // 
            // lblNote6
            // 
            this.lblNote6.AutoSize = true;
            this.lblNote6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote6.Location = new System.Drawing.Point(13, 429);
            this.lblNote6.Name = "lblNote6";
            this.lblNote6.Size = new System.Drawing.Size(126, 13);
            this.lblNote6.TabIndex = 16;
            this.lblNote6.Text = "Points pour avoir 6 : ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bareme_Suisse.Properties.Resources.Logo_Bareme;
            this.pictureBox1.Location = new System.Drawing.Point(160, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Calculateur de barème suisse.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "© Copyright Bruno Paiva. Tous droits réservés.";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(156, 137);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Effacer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 489);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblNote6);
            this.Controls.Add(this.lblNote55);
            this.Controls.Add(this.lblNote5);
            this.Controls.Add(this.lblNote45);
            this.Controls.Add(this.lblNote4);
            this.Controls.Add(this.lblNote35);
            this.Controls.Add(this.lblNote3);
            this.Controls.Add(this.lblNote25);
            this.Controls.Add(this.lblNote2);
            this.Controls.Add(this.lblNote15);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.tbxPointsTotaux);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxPointsObtenus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Baro\'Suisse v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPointsObtenus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxPointsTotaux;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblNote15;
        private System.Windows.Forms.Label lblNote2;
        private System.Windows.Forms.Label lblNote25;
        private System.Windows.Forms.Label lblNote3;
        private System.Windows.Forms.Label lblNote35;
        private System.Windows.Forms.Label lblNote4;
        private System.Windows.Forms.Label lblNote45;
        private System.Windows.Forms.Label lblNote5;
        private System.Windows.Forms.Label lblNote55;
        private System.Windows.Forms.Label lblNote6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
    }
}

