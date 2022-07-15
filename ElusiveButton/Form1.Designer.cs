namespace ElusiveButton
{
    partial class MainForm
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
            this.ElusiveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ElusiveButton
            // 
            this.ElusiveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ElusiveButton.Location = new System.Drawing.Point(276, 219);
            this.ElusiveButton.Name = "ElusiveButton";
            this.ElusiveButton.Size = new System.Drawing.Size(72, 36);
            this.ElusiveButton.TabIndex = 0;
            this.ElusiveButton.Text = "Button";
            this.ElusiveButton.UseVisualStyleBackColor = true;
            this.ElusiveButton.MouseEnter += new System.EventHandler(this.ElusiveButton_MouseEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 533);
            this.Controls.Add(this.ElusiveButton);
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Elusive Button";
            this.ResumeLayout(false);

        }

        #endregion

        private Button ElusiveButton;
    }
}