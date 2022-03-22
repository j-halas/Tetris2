namespace Tetris_2
{
    partial class NowyRekord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NowyRekord));
            this.NowyRekord_label = new System.Windows.Forms.Label();
            this.DodajWynikButton = new System.Windows.Forms.Button();
            this.NickTextBox = new System.Windows.Forms.TextBox();
            this.NowyRekord_DobryWynikLabel = new System.Windows.Forms.Label();
            this.NowyRekord_ErrorLabel = new System.Windows.Forms.Label();
            this.BrzydkiAleDebugowy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NowyRekord_label
            // 
            this.NowyRekord_label.AutoSize = true;
            this.NowyRekord_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowyRekord_label.ForeColor = System.Drawing.Color.White;
            this.NowyRekord_label.Location = new System.Drawing.Point(55, 55);
            this.NowyRekord_label.Name = "NowyRekord_label";
            this.NowyRekord_label.Size = new System.Drawing.Size(334, 17);
            this.NowyRekord_label.TabIndex = 0;
            this.NowyRekord_label.Text = "Gratulacje! Podaj swój nick do tabeli wyników";
            // 
            // DodajWynikButton
            // 
            this.DodajWynikButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.DodajWynikButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DodajWynikButton.ForeColor = System.Drawing.Color.White;
            this.DodajWynikButton.Location = new System.Drawing.Point(296, 114);
            this.DodajWynikButton.Name = "DodajWynikButton";
            this.DodajWynikButton.Size = new System.Drawing.Size(118, 38);
            this.DodajWynikButton.TabIndex = 1;
            this.DodajWynikButton.Text = "Dodaj wynik";
            this.DodajWynikButton.UseVisualStyleBackColor = false;
            this.DodajWynikButton.Click += new System.EventHandler(this.DodajWynikButton_Click);
            // 
            // NickTextBox
            // 
            this.NickTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.NickTextBox.ForeColor = System.Drawing.Color.White;
            this.NickTextBox.Location = new System.Drawing.Point(55, 86);
            this.NickTextBox.MaxLength = 12;
            this.NickTextBox.Name = "NickTextBox";
            this.NickTextBox.Size = new System.Drawing.Size(334, 22);
            this.NickTextBox.TabIndex = 2;
            // 
            // NowyRekord_DobryWynikLabel
            // 
            this.NowyRekord_DobryWynikLabel.AutoSize = true;
            this.NowyRekord_DobryWynikLabel.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowyRekord_DobryWynikLabel.ForeColor = System.Drawing.Color.White;
            this.NowyRekord_DobryWynikLabel.Location = new System.Drawing.Point(109, 9);
            this.NowyRekord_DobryWynikLabel.Name = "NowyRekord_DobryWynikLabel";
            this.NowyRekord_DobryWynikLabel.Size = new System.Drawing.Size(251, 34);
            this.NowyRekord_DobryWynikLabel.TabIndex = 3;
            this.NowyRekord_DobryWynikLabel.Text = "Dobry wynik";
            // 
            // NowyRekord_ErrorLabel
            // 
            this.NowyRekord_ErrorLabel.AutoSize = true;
            this.NowyRekord_ErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowyRekord_ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.NowyRekord_ErrorLabel.Location = new System.Drawing.Point(12, 123);
            this.NowyRekord_ErrorLabel.Name = "NowyRekord_ErrorLabel";
            this.NowyRekord_ErrorLabel.Size = new System.Drawing.Size(214, 20);
            this.NowyRekord_ErrorLabel.TabIndex = 4;
            this.NowyRekord_ErrorLabel.Text = "Nick nie może być pusty";
            this.NowyRekord_ErrorLabel.Visible = false;
            // 
            // BrzydkiAleDebugowy
            // 
            this.BrzydkiAleDebugowy.Location = new System.Drawing.Point(22, 86);
            this.BrzydkiAleDebugowy.Name = "BrzydkiAleDebugowy";
            this.BrzydkiAleDebugowy.Size = new System.Drawing.Size(27, 22);
            this.BrzydkiAleDebugowy.TabIndex = 5;
            this.BrzydkiAleDebugowy.Text = "I tak nie widac";
            this.BrzydkiAleDebugowy.UseVisualStyleBackColor = true;
            this.BrzydkiAleDebugowy.Click += new System.EventHandler(this.BrzydkiAleDebugowy_Click);
            // 
            // NowyRekord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(426, 164);
            this.Controls.Add(this.BrzydkiAleDebugowy);
            this.Controls.Add(this.NowyRekord_ErrorLabel);
            this.Controls.Add(this.NowyRekord_DobryWynikLabel);
            this.Controls.Add(this.NickTextBox);
            this.Controls.Add(this.DodajWynikButton);
            this.Controls.Add(this.NowyRekord_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NowyRekord";
            this.Text = "Dobry wynik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NowyRekord_label;
        private System.Windows.Forms.Button DodajWynikButton;
        private System.Windows.Forms.TextBox NickTextBox;
        private System.Windows.Forms.Label NowyRekord_DobryWynikLabel;
        private System.Windows.Forms.Label NowyRekord_ErrorLabel;
        private System.Windows.Forms.Button BrzydkiAleDebugowy;
    }
}