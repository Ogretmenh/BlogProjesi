namespace BlogProjesi
{
    partial class frmBlog
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTarih = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.grpVeri = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tmrKapat = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.grpVeri.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblTarih);
            this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
            this.flowLayoutPanel1.Controls.Add(this.grpVeri);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(389, 349);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(3, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(71, 15);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "İşlem Tarihi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(80, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // grpVeri
            // 
            this.grpVeri.Controls.Add(this.textBox1);
            this.grpVeri.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grpVeri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpVeri.Location = new System.Drawing.Point(3, 29);
            this.grpVeri.Name = "grpVeri";
            this.grpVeri.Size = new System.Drawing.Size(200, 227);
            this.grpVeri.TabIndex = 2;
            this.grpVeri.TabStop = false;
            this.grpVeri.Text = "Veri Girişi";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 202);
            this.textBox1.TabIndex = 0;
            // 
            // tmrKapat
            // 
            this.tmrKapat.Interval = 60000;
            this.tmrKapat.Tick += new System.EventHandler(this.tmrKapat_Tick);
            // 
            // frmBlog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 349);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "frmBlog";
            this.Text = " Blog Projesi";
            this.Activated += new System.EventHandler(this.frmBlog_Activated);
            this.Deactivate += new System.EventHandler(this.frmBlog_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBlog_FormClosed);
            this.Load += new System.EventHandler(this.frmBlog_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.grpVeri.ResumeLayout(false);
            this.grpVeri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox grpVeri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer tmrKapat;
    }
}