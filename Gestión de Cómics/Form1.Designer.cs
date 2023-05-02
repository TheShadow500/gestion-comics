namespace Gestión_de_Cómics
{
    partial class fr_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_MenuPrincipal));
            lb_Version = new Label();
            SuspendLayout();
            // 
            // lb_Version
            // 
            lb_Version.AutoSize = true;
            lb_Version.BackColor = Color.Transparent;
            lb_Version.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Version.Location = new Point(12, 954);
            lb_Version.Name = "lb_Version";
            lb_Version.Size = new Size(62, 22);
            lb_Version.TabIndex = 0;
            lb_Version.Text = "Version";
            lb_Version.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // fr_MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1350, 729);
            Controls.Add(lb_Version);
            Name = "fr_MenuPrincipal";
            Text = "Gestión de Cómics v0.1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Version;
    }
}