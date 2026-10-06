namespace hwlesson_1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxArgum = new System.Windows.Forms.TextBox();
            this.btnSendArgumen = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();


            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(400, 300);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;


            this.txtBoxArgum.Location = new System.Drawing.Point(430, 12);
            this.txtBoxArgum.Name = "txtBoxArgum";
            this.txtBoxArgum.Size = new System.Drawing.Size(150, 23);
            this.txtBoxArgum.TabIndex = 1;


            this.btnSendArgumen.Location = new System.Drawing.Point(430, 45);
            this.btnSendArgumen.Name = "btnSendArgumen";
            this.btnSendArgumen.Size = new System.Drawing.Size(150, 30);
            this.btnSendArgumen.TabIndex = 2;
            this.btnSendArgumen.Text = "Start the process";
            this.btnSendArgumen.UseVisualStyleBackColor = true;
            this.btnSendArgumen.Click += new System.EventHandler(this.btnSendArgumen_Click);


            this.btnSaveFile.Location = new System.Drawing.Point(430, 85);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(150, 30);
            this.btnSaveFile.TabIndex = 3;
            this.btnSaveFile.Text = "Save to file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);


            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.btnSendArgumen);
            this.Controls.Add(this.txtBoxArgum);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Processes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtBoxArgum;
        private System.Windows.Forms.Button btnSendArgumen;
        private System.Windows.Forms.Button btnSaveFile;
    }
}