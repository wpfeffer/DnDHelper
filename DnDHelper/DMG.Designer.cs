namespace DnDHelper
{
    partial class DMG
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
            this.btnFormOfGovernment = new System.Windows.Forms.Button();
            this.lblFormOfGovernment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("AquilineTwo", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(883, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(604, 284);
            this.label1.TabIndex = 0;
            this.label1.Text = "World Building";
            // 
            // btnFormOfGovernment
            // 
            this.btnFormOfGovernment.Location = new System.Drawing.Point(213, 88);
            this.btnFormOfGovernment.Name = "btnFormOfGovernment";
            this.btnFormOfGovernment.Size = new System.Drawing.Size(200, 34);
            this.btnFormOfGovernment.TabIndex = 1;
            this.btnFormOfGovernment.Text = "Form Of Government";
            this.btnFormOfGovernment.UseVisualStyleBackColor = true;
            this.btnFormOfGovernment.Click += new System.EventHandler(this.btnFormOfGovernment_Click);
            // 
            // lblFormOfGovernment
            // 
            this.lblFormOfGovernment.AutoSize = true;
            this.lblFormOfGovernment.Location = new System.Drawing.Point(214, 126);
            this.lblFormOfGovernment.Name = "lblFormOfGovernment";
            this.lblFormOfGovernment.Size = new System.Drawing.Size(59, 25);
            this.lblFormOfGovernment.TabIndex = 2;
            this.lblFormOfGovernment.Text = "label2";
            // 
            // DMG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2619, 1426);
            this.Controls.Add(this.lblFormOfGovernment);
            this.Controls.Add(this.btnFormOfGovernment);
            this.Controls.Add(this.label1);
            this.Name = "DMG";
            this.Text = "Dungeon Master\'s Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnFormOfGovernment;
        private Label lblFormOfGovernment;
    }
}