namespace giuaky
{
    partial class FormTimKiem
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
            this.lb_tencot = new System.Windows.Forms.Label();
            this.lb_locdk = new System.Windows.Forms.Label();
            this.tb_locdk = new System.Windows.Forms.TextBox();
            this.lb_huylocdk = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_tencot
            // 
            this.lb_tencot.AutoSize = true;
            this.lb_tencot.Location = new System.Drawing.Point(12, 22);
            this.lb_tencot.Name = "lb_tencot";
            this.lb_tencot.Size = new System.Drawing.Size(105, 16);
            this.lb_tencot.TabIndex = 0;
            this.lb_tencot.Text = "Tên cột được tìm";
            this.lb_tencot.Click += new System.EventHandler(this.lb_tencot_Click);
            // 
            // lb_locdk
            // 
            this.lb_locdk.AutoSize = true;
            this.lb_locdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_locdk.Location = new System.Drawing.Point(12, 83);
            this.lb_locdk.Name = "lb_locdk";
            this.lb_locdk.Size = new System.Drawing.Size(133, 16);
            this.lb_locdk.TabIndex = 1;
            this.lb_locdk.Text = "Lọc theo điều kiện";
            this.lb_locdk.Click += new System.EventHandler(this.lb_locdk_Click);
            // 
            // tb_locdk
            // 
            this.tb_locdk.Location = new System.Drawing.Point(165, 77);
            this.tb_locdk.Name = "tb_locdk";
            this.tb_locdk.Size = new System.Drawing.Size(260, 22);
            this.tb_locdk.TabIndex = 2;
            this.tb_locdk.TextChanged += new System.EventHandler(this.tb_locdk_TextChanged);
            // 
            // lb_huylocdk
            // 
            this.lb_huylocdk.AutoSize = true;
            this.lb_huylocdk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_huylocdk.Location = new System.Drawing.Point(12, 156);
            this.lb_huylocdk.Name = "lb_huylocdk";
            this.lb_huylocdk.Size = new System.Drawing.Size(177, 16);
            this.lb_huylocdk.TabIndex = 1;
            this.lb_huylocdk.Text = "Hủy các điều kiện đã lọc";
            this.lb_huylocdk.Click += new System.EventHandler(this.lb_huylocdk_Click);
            // 
            // FormTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 221);
            this.Controls.Add(this.tb_locdk);
            this.Controls.Add(this.lb_huylocdk);
            this.Controls.Add(this.lb_locdk);
            this.Controls.Add(this.lb_tencot);
            this.Name = "FormTimKiem";
            this.Text = "Tìm kiếm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_tencot;
        private System.Windows.Forms.Label lb_locdk;
        private System.Windows.Forms.TextBox tb_locdk;
        private System.Windows.Forms.Label lb_huylocdk;
    }
}