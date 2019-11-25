namespace Antra
{
    partial class PatvirtinimasIseiti
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
            this.iseitiButton = new System.Windows.Forms.Button();
            this.atsauktiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // iseitiButton
            // 
            this.iseitiButton.Location = new System.Drawing.Point(83, 35);
            this.iseitiButton.Name = "iseitiButton";
            this.iseitiButton.Size = new System.Drawing.Size(80, 24);
            this.iseitiButton.TabIndex = 0;
            this.iseitiButton.Text = "Išeiti";
            this.iseitiButton.UseVisualStyleBackColor = true;
            // 
            // atsauktiButton
            // 
            this.atsauktiButton.Location = new System.Drawing.Point(83, 105);
            this.atsauktiButton.Name = "atsauktiButton";
            this.atsauktiButton.Size = new System.Drawing.Size(80, 24);
            this.atsauktiButton.TabIndex = 1;
            this.atsauktiButton.Text = "Atšaukti";
            this.atsauktiButton.UseVisualStyleBackColor = true;
            // 
            // PatvirtinimasIseiti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 141);
            this.Controls.Add(this.atsauktiButton);
            this.Controls.Add(this.iseitiButton);
            this.Name = "PatvirtinimasIseiti";
            this.Text = "Ar tikrai norite išeiti?";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button iseitiButton;
        private System.Windows.Forms.Button atsauktiButton;
    }
}