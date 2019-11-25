namespace Antra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.prisijungimasButton = new System.Windows.Forms.Button();
            this.registracijaButton = new System.Windows.Forms.Button();
            this.pamirstasSlaptazodis = new System.Windows.Forms.Button();
            this.iseitiButton = new System.Windows.Forms.Button();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // prisijungimasButton
            // 
            this.prisijungimasButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prisijungimasButton.Location = new System.Drawing.Point(170, 118);
            this.prisijungimasButton.Name = "prisijungimasButton";
            this.prisijungimasButton.Size = new System.Drawing.Size(79, 23);
            this.prisijungimasButton.TabIndex = 1;
            this.prisijungimasButton.Text = "Prisijungti";
            this.prisijungimasButton.UseVisualStyleBackColor = true;
            this.prisijungimasButton.Click += new System.EventHandler(this.PrisijungimasButton_Click);
            // 
            // registracijaButton
            // 
            this.registracijaButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.registracijaButton.Location = new System.Drawing.Point(255, 118);
            this.registracijaButton.Name = "registracijaButton";
            this.registracijaButton.Size = new System.Drawing.Size(87, 23);
            this.registracijaButton.TabIndex = 2;
            this.registracijaButton.Text = "Registracija";
            this.registracijaButton.UseVisualStyleBackColor = true;
            this.registracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // pamirstasSlaptazodis
            // 
            this.pamirstasSlaptazodis.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.pamirstasSlaptazodis.Location = new System.Drawing.Point(197, 147);
            this.pamirstasSlaptazodis.Name = "pamirstasSlaptazodis";
            this.pamirstasSlaptazodis.Size = new System.Drawing.Size(111, 52);
            this.pamirstasSlaptazodis.TabIndex = 3;
            this.pamirstasSlaptazodis.Text = "Pamiršote slaptažodį?";
            this.pamirstasSlaptazodis.UseVisualStyleBackColor = true;
            this.pamirstasSlaptazodis.Click += new System.EventHandler(this.PamirstasSlaptazodis_Click_1);
            // 
            // iseitiButton
            // 
            this.iseitiButton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.iseitiButton.Location = new System.Drawing.Point(403, 218);
            this.iseitiButton.Name = "iseitiButton";
            this.iseitiButton.Size = new System.Drawing.Size(75, 23);
            this.iseitiButton.TabIndex = 4;
            this.iseitiButton.Text = "Išeiti";
            this.iseitiButton.UseVisualStyleBackColor = true;
            this.iseitiButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(30, 12);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(431, 100);
            this.PictureBox.TabIndex = 5;
            this.PictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 253);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.iseitiButton);
            this.Controls.Add(this.pamirstasSlaptazodis);
            this.Controls.Add(this.registracijaButton);
            this.Controls.Add(this.prisijungimasButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button prisijungimasButton;
        private System.Windows.Forms.Button registracijaButton;
        private System.Windows.Forms.Button pamirstasSlaptazodis;
        private System.Windows.Forms.Button iseitiButton;
        private System.Windows.Forms.PictureBox PictureBox;
    }
}

