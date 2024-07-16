namespace giuaky
{
    partial class FormGK2
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
            this.gb_ttsv = new System.Windows.Forms.GroupBox();
            this.rb_tatca = new System.Windows.Forms.RadioButton();
            this.rb_ctdt = new System.Windows.Forms.RadioButton();
            this.cb_ctdt = new System.Windows.Forms.ComboBox();
            this.dgv_data = new System.Windows.Forms.DataGridView();
            this.gb_ttsv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_ttsv
            // 
            this.gb_ttsv.Controls.Add(this.dgv_data);
            this.gb_ttsv.Controls.Add(this.cb_ctdt);
            this.gb_ttsv.Controls.Add(this.rb_ctdt);
            this.gb_ttsv.Controls.Add(this.rb_tatca);
            this.gb_ttsv.Location = new System.Drawing.Point(12, 12);
            this.gb_ttsv.Name = "gb_ttsv";
            this.gb_ttsv.Size = new System.Drawing.Size(876, 558);
            this.gb_ttsv.TabIndex = 0;
            this.gb_ttsv.TabStop = false;
            this.gb_ttsv.Text = "Thông tin sinh viên";
            this.gb_ttsv.Enter += new System.EventHandler(this.gb_ttsv_Enter);
            // 
            // rb_tatca
            // 
            this.rb_tatca.AutoSize = true;
            this.rb_tatca.Location = new System.Drawing.Point(89, 80);
            this.rb_tatca.Name = "rb_tatca";
            this.rb_tatca.Size = new System.Drawing.Size(66, 20);
            this.rb_tatca.TabIndex = 0;
            this.rb_tatca.TabStop = true;
            this.rb_tatca.Text = "Tất cả";
            this.rb_tatca.UseVisualStyleBackColor = true;
            this.rb_tatca.CheckedChanged += new System.EventHandler(this.rb_tatca_CheckedChanged);
            // 
            // rb_ctdt
            // 
            this.rb_ctdt.AutoSize = true;
            this.rb_ctdt.Location = new System.Drawing.Point(307, 80);
            this.rb_ctdt.Name = "rb_ctdt";
            this.rb_ctdt.Size = new System.Drawing.Size(99, 20);
            this.rb_ctdt.TabIndex = 0;
            this.rb_ctdt.TabStop = true;
            this.rb_ctdt.Text = "Theo CTĐT";
            this.rb_ctdt.UseVisualStyleBackColor = true;
            this.rb_ctdt.CheckedChanged += new System.EventHandler(this.rb_ctdt_CheckedChanged);
            // 
            // cb_ctdt
            // 
            this.cb_ctdt.FormattingEnabled = true;
            this.cb_ctdt.Location = new System.Drawing.Point(425, 76);
            this.cb_ctdt.Name = "cb_ctdt";
            this.cb_ctdt.Size = new System.Drawing.Size(138, 24);
            this.cb_ctdt.TabIndex = 1;
            this.cb_ctdt.SelectedIndexChanged += new System.EventHandler(this.cb_ctdt_SelectedIndexChanged);
            // 
            // dgv_data
            // 
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.Location = new System.Drawing.Point(6, 124);
            this.dgv_data.Name = "dgv_data";
            this.dgv_data.RowHeadersWidth = 51;
            this.dgv_data.RowTemplate.Height = 24;
            this.dgv_data.Size = new System.Drawing.Size(864, 428);
            this.dgv_data.TabIndex = 2;
            this.dgv_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_data_CellContentClick);
            // 
            // FormGK2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 582);
            this.Controls.Add(this.gb_ttsv);
            this.Name = "FormGK2";
            this.Text = "FormGK2";
            this.Load += new System.EventHandler(this.FormGK2_Load);
            this.gb_ttsv.ResumeLayout(false);
            this.gb_ttsv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ttsv;
        private System.Windows.Forms.DataGridView dgv_data;
        private System.Windows.Forms.ComboBox cb_ctdt;
        private System.Windows.Forms.RadioButton rb_ctdt;
        private System.Windows.Forms.RadioButton rb_tatca;
    }
}

