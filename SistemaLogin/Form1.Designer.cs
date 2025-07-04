namespace SistemaLogin
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
        private void InitializeComponent() {
            labelBoasVindas = new Label();
            SuspendLayout();
            // 
            // labelBoasVindas
            // 
            labelBoasVindas.BackColor = SystemColors.ActiveBorder;
            labelBoasVindas.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBoasVindas.Location = new Point(12, 9);
            labelBoasVindas.Name = "labelBoasVindas";
            labelBoasVindas.Size = new Size(776, 432);
            labelBoasVindas.TabIndex = 0;
            labelBoasVindas.Text = "Tela inicial";
            labelBoasVindas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(labelBoasVindas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicío";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label labelBoasVindas;
    }
}
