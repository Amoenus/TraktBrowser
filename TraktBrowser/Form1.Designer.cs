namespace TraktBrowser
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
            this.btnGetJSON = new System.Windows.Forms.Button();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.labelGender = new System.Windows.Forms.Label();
            this.pbScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetJSON
            // 
            this.btnGetJSON.Location = new System.Drawing.Point(405, 24);
            this.btnGetJSON.Name = "btnGetJSON";
            this.btnGetJSON.Size = new System.Drawing.Size(75, 23);
            this.btnGetJSON.TabIndex = 0;
            this.btnGetJSON.Text = "Get Profile";
            this.btnGetJSON.UseVisualStyleBackColor = true;
            this.btnGetJSON.Click += new System.EventHandler(this.btnGetJSON_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.Location = new System.Drawing.Point(13, 13);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(196, 189);
            this.pbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvatar.TabIndex = 1;
            this.pbAvatar.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(216, 13);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(61, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Name Data";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(216, 34);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(49, 13);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "AgeData";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(405, 54);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(75, 23);
            this.btnClearAll.TabIndex = 4;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(216, 54);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(68, 13);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender Data";
            // 
            // pbScreen
            // 
            this.pbScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbScreen.Location = new System.Drawing.Point(13, 209);
            this.pbScreen.Name = "pbScreen";
            this.pbScreen.Size = new System.Drawing.Size(699, 415);
            this.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScreen.TabIndex = 6;
            this.pbScreen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 637);
            this.Controls.Add(this.pbScreen);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.pbAvatar);
            this.Controls.Add(this.btnGetJSON);
            this.MinimumSize = new System.Drawing.Size(740, 675);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScreen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetJSON;
        private System.Windows.Forms.PictureBox pbAvatar;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.PictureBox pbScreen;
    }
}

