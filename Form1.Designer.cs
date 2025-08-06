
namespace SqlScriptRunner
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtInputPath = new System.Windows.Forms.TextBox();
            this.pbProcess = new System.Windows.Forms.ProgressBar();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            this.dgvFileList.AllowUserToResizeColumns = false;
            this.dgvFileList.AllowUserToResizeRows = false;
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileList.Location = new System.Drawing.Point(0, 0);
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.ReadOnly = true;
            this.dgvFileList.RowHeadersVisible = false;
            this.dgvFileList.RowTemplate.Height = 25;
            this.dgvFileList.ShowEditingIcon = false;
            this.dgvFileList.Size = new System.Drawing.Size(736, 504);
            this.dgvFileList.TabIndex = 0;
            this.dgvFileList.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvFileList);
            this.splitContainer1.Size = new System.Drawing.Size(1108, 504);
            this.splitContainer1.SplitterDistance = 368;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtConnectionString);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.txtInputPath);
            this.panel1.Controls.Add(this.pbProcess);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 116);
            this.panel1.TabIndex = 10;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.ForeColor = System.Drawing.Color.Navy;
            this.txtConnectionString.Location = new System.Drawing.Point(3, 14);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.PlaceholderText = "Connection String ...";
            this.txtConnectionString.Size = new System.Drawing.Size(355, 23);
            this.txtConnectionString.TabIndex = 7;
            this.txtConnectionString.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(165, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtInputPath
            // 
            this.txtInputPath.ForeColor = System.Drawing.Color.DarkGreen;
            this.txtInputPath.Location = new System.Drawing.Point(3, 43);
            this.txtInputPath.Name = "txtInputPath";
            this.txtInputPath.PlaceholderText = "Initial Path";
            this.txtInputPath.Size = new System.Drawing.Size(355, 23);
            this.txtInputPath.TabIndex = 1;
            this.txtInputPath.TabStop = false;
            // 
            // pbProcess
            // 
            this.pbProcess.BackColor = System.Drawing.Color.DarkRed;
            this.pbProcess.ForeColor = System.Drawing.Color.Tan;
            this.pbProcess.Location = new System.Drawing.Point(5, 102);
            this.pbProcess.MarqueeAnimationSpeed = 10;
            this.pbProcess.Name = "pbProcess";
            this.pbProcess.Size = new System.Drawing.Size(355, 8);
            this.pbProcess.Step = 1;
            this.pbProcess.TabIndex = 8;
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRun.Location = new System.Drawing.Point(84, 73);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(283, 72);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.ForeColor = System.Drawing.Color.Magenta;
            this.btnBrowse.Location = new System.Drawing.Point(3, 72);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOutput.Location = new System.Drawing.Point(0, 0);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(368, 388);
            this.txtOutput.TabIndex = 6;
            this.txtOutput.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtOutput);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(368, 388);
            this.panel2.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 504);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sql Script Runner";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtInputPath;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.ProgressBar pbProcess;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

