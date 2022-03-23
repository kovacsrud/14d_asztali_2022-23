
namespace FormDemo
{
    partial class ablak
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSzam1 = new System.Windows.Forms.TextBox();
            this.textBoxSzam2 = new System.Windows.Forms.TextBox();
            this.labelEredmeny = new System.Windows.Forms.Label();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(193, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Szám2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(193, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Szám1:";
            // 
            // textBoxSzam1
            // 
            this.textBoxSzam1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzam1.Location = new System.Drawing.Point(313, 142);
            this.textBoxSzam1.Name = "textBoxSzam1";
            this.textBoxSzam1.Size = new System.Drawing.Size(265, 41);
            this.textBoxSzam1.TabIndex = 2;
            // 
            // textBoxSzam2
            // 
            this.textBoxSzam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSzam2.Location = new System.Drawing.Point(313, 243);
            this.textBoxSzam2.Name = "textBoxSzam2";
            this.textBoxSzam2.Size = new System.Drawing.Size(265, 41);
            this.textBoxSzam2.TabIndex = 3;
            // 
            // labelEredmeny
            // 
            this.labelEredmeny.AutoSize = true;
            this.labelEredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelEredmeny.Location = new System.Drawing.Point(307, 331);
            this.labelEredmeny.MinimumSize = new System.Drawing.Size(300, 0);
            this.labelEredmeny.Name = "labelEredmeny";
            this.labelEredmeny.Size = new System.Drawing.Size(300, 36);
            this.labelEredmeny.TabIndex = 4;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSzamol.Location = new System.Drawing.Point(324, 399);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(139, 39);
            this.buttonSzamol.TabIndex = 5;
            this.buttonSzamol.Text = "Számol";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // ablak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.labelEredmeny);
            this.Controls.Add(this.textBoxSzam2);
            this.Controls.Add(this.textBoxSzam1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ablak";
            this.Text = "Ablak";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSzam1;
        private System.Windows.Forms.TextBox textBoxSzam2;
        private System.Windows.Forms.Label labelEredmeny;
        private System.Windows.Forms.Button buttonSzamol;
    }
}

