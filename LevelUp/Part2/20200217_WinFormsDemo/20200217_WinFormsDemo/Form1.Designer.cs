namespace _20200217_WinFormsDemo
{
    partial class frmMain
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnToLeft = new System.Windows.Forms.Button();
            this.chbxCancelButton = new System.Windows.Forms.CheckBox();
            this.btnToLeftSecond = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrOk = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(632, 415);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(713, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnToLeft
            // 
            this.btnToLeft.Location = new System.Drawing.Point(558, 386);
            this.btnToLeft.Name = "btnToLeft";
            this.btnToLeft.Size = new System.Drawing.Size(75, 23);
            this.btnToLeft.TabIndex = 2;
            this.btnToLeft.Text = "<---";
            this.btnToLeft.UseVisualStyleBackColor = true;
            this.btnToLeft.Click += new System.EventHandler(this.btnToLeft_Click);
            this.btnToLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnToLeft_MouseMove);
            // 
            // chbxCancelButton
            // 
            this.chbxCancelButton.AutoSize = true;
            this.chbxCancelButton.Checked = true;
            this.chbxCancelButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbxCancelButton.Location = new System.Drawing.Point(323, 162);
            this.chbxCancelButton.Name = "chbxCancelButton";
            this.chbxCancelButton.Size = new System.Drawing.Size(124, 17);
            this.chbxCancelButton.TabIndex = 3;
            this.chbxCancelButton.Text = "Show/hide \"Cancel\"";
            this.chbxCancelButton.UseVisualStyleBackColor = true;
            this.chbxCancelButton.Click += new System.EventHandler(this.chbxCancelButton_Click);
            // 
            // btnToLeftSecond
            // 
            this.btnToLeftSecond.Location = new System.Drawing.Point(558, 357);
            this.btnToLeftSecond.Name = "btnToLeftSecond";
            this.btnToLeftSecond.Size = new System.Drawing.Size(75, 23);
            this.btnToLeftSecond.TabIndex = 4;
            this.btnToLeftSecond.Text = "<---";
            this.btnToLeftSecond.UseVisualStyleBackColor = true;
            this.btnToLeftSecond.Click += new System.EventHandler(this.btnToLeft_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(632, 156);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create button";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(96, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // tmrOk
            // 
            this.tmrOk.Interval = 1000;
            this.tmrOk.Tick += new System.EventHandler(this.tmrOk_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnToLeftSecond);
            this.Controls.Add(this.chbxCancelButton);
            this.Controls.Add(this.btnToLeft);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnToLeft;
        private System.Windows.Forms.CheckBox chbxCancelButton;
        private System.Windows.Forms.Button btnToLeftSecond;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Timer tmrOk;
    }
}

