namespace TestRTFPagination.Views
{
    partial class frmRTFView
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
            this.richTxtRTF = new System.Windows.Forms.RichTextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.pnlNavigator = new System.Windows.Forms.Panel();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.lblPageIndex = new System.Windows.Forms.Label();
            this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.pnlNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTxtRTF
            // 
            this.richTxtRTF.Location = new System.Drawing.Point(1, 0);
            this.richTxtRTF.Name = "richTxtRTF";
            this.richTxtRTF.Size = new System.Drawing.Size(796, 430);
            this.richTxtRTF.TabIndex = 0;
            this.richTxtRTF.Text = "";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(672, 436);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(122, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load RTF Document";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // pnlNavigator
            // 
            this.pnlNavigator.Controls.Add(this.lblPageIndex);
            this.pnlNavigator.Controls.Add(this.btnPrevPage);
            this.pnlNavigator.Controls.Add(this.btnNextPage);
            this.pnlNavigator.Location = new System.Drawing.Point(202, 433);
            this.pnlNavigator.Name = "pnlNavigator";
            this.pnlNavigator.Size = new System.Drawing.Size(390, 31);
            this.pnlNavigator.TabIndex = 2;
            this.pnlNavigator.Visible = false;
            // 
            // btnNextPage
            // 
            this.btnNextPage.Location = new System.Drawing.Point(278, 4);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(108, 23);
            this.btnNextPage.TabIndex = 2;
            this.btnNextPage.Text = "Next Page >>";
            this.btnNextPage.UseVisualStyleBackColor = true;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);
            // 
            // btnPrevPage
            // 
            this.btnPrevPage.Location = new System.Drawing.Point(4, 4);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(108, 23);
            this.btnPrevPage.TabIndex = 1;
            this.btnPrevPage.Text = "<< Previous Page";
            this.btnPrevPage.UseVisualStyleBackColor = true;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);
            // 
            // lblPageIndex
            // 
            this.lblPageIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageIndex.Location = new System.Drawing.Point(118, 4);
            this.lblPageIndex.Name = "lblPageIndex";
            this.lblPageIndex.Size = new System.Drawing.Size(154, 23);
            this.lblPageIndex.TabIndex = 2;
            this.lblPageIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dlgOpenFile
            // 
            this.dlgOpenFile.FileName = "openFileDialog1";
            // 
            // frmRTFView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.pnlNavigator);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.richTxtRTF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmRTFView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View RTF Document";
            this.pnlNavigator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtRTF;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel pnlNavigator;
        private System.Windows.Forms.Label lblPageIndex;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    }
}