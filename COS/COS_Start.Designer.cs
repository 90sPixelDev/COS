namespace COS
{
    partial class COS_Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(COS_Start));
            this.edit_charasheet_btn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cos_icon = new System.Windows.Forms.PictureBox();
            this.lienfont_2020_lbl = new System.Windows.Forms.Label();
            this.subtitle_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cos_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // edit_charasheet_btn
            // 
            this.edit_charasheet_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_charasheet_btn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_charasheet_btn.Location = new System.Drawing.Point(93, 281);
            this.edit_charasheet_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edit_charasheet_btn.Name = "edit_charasheet_btn";
            this.edit_charasheet_btn.Size = new System.Drawing.Size(187, 42);
            this.edit_charasheet_btn.TabIndex = 0;
            this.edit_charasheet_btn.Text = "Edit Character Sheet";
            this.edit_charasheet_btn.UseVisualStyleBackColor = true;
            this.edit_charasheet_btn.Click += new System.EventHandler(this.new_charasheet_btn_Click);
            // 
            // cos_icon
            // 
            this.cos_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cos_icon.BackgroundImage")));
            this.cos_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cos_icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("cos_icon.InitialImage")));
            this.cos_icon.Location = new System.Drawing.Point(93, 12);
            this.cos_icon.Name = "cos_icon";
            this.cos_icon.Size = new System.Drawing.Size(187, 187);
            this.cos_icon.TabIndex = 2;
            this.cos_icon.TabStop = false;
            // 
            // lienfont_2020_lbl
            // 
            this.lienfont_2020_lbl.AutoSize = true;
            this.lienfont_2020_lbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lienfont_2020_lbl.Location = new System.Drawing.Point(12, 397);
            this.lienfont_2020_lbl.Name = "lienfont_2020_lbl";
            this.lienfont_2020_lbl.Size = new System.Drawing.Size(108, 16);
            this.lienfont_2020_lbl.TabIndex = 3;
            this.lienfont_2020_lbl.Text = "Lien Font © 2020";
            // 
            // subtitle_lbl
            // 
            this.subtitle_lbl.AutoSize = true;
            this.subtitle_lbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtitle_lbl.Location = new System.Drawing.Point(67, 202);
            this.subtitle_lbl.Name = "subtitle_lbl";
            this.subtitle_lbl.Size = new System.Drawing.Size(273, 18);
            this.subtitle_lbl.TabIndex = 4;
            this.subtitle_lbl.Text = "A Character Organizer Sheet Program";
            // 
            // COS_Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(0F, 0F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 422);
            this.Controls.Add(this.subtitle_lbl);
            this.Controls.Add(this.lienfont_2020_lbl);
            this.Controls.Add(this.cos_icon);
            this.Controls.Add(this.edit_charasheet_btn);
            this.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "COS_Start";
            this.Text = "COS";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.COS_Start_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.cos_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button edit_charasheet_btn;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox cos_icon;
        private System.Windows.Forms.Label lienfont_2020_lbl;
        private System.Windows.Forms.Label subtitle_lbl;
    }
}

