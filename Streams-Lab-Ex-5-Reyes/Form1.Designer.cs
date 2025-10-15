namespace Streams_Lab_Ex_5_Reyes
{
    partial class FrmLab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLab1));
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblCreateFile = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.MistyRose;
            this.txtInput.Location = new System.Drawing.Point(53, 78);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(432, 99);
            this.txtInput.TabIndex = 0;
            // 
            // lblCreateFile
            // 
            this.lblCreateFile.AutoSize = true;
            this.lblCreateFile.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateFile.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateFile.ForeColor = System.Drawing.Color.White;
            this.lblCreateFile.Location = new System.Drawing.Point(55, 37);
            this.lblCreateFile.Name = "lblCreateFile";
            this.lblCreateFile.Size = new System.Drawing.Size(193, 38);
            this.lblCreateFile.TabIndex = 1;
            this.lblCreateFile.Text = "Create A file";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.MistyRose;
            this.btnCreate.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Tomato;
            this.btnCreate.Location = new System.Drawing.Point(195, 212);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(140, 40);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FrmLab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(527, 314);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblCreateFile);
            this.Controls.Add(this.txtInput);
            this.Name = "FrmLab1";
            this.Text = "FrmLab1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblCreateFile;
        private System.Windows.Forms.Button btnCreate;
    }
}

