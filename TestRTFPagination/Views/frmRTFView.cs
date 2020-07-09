using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRTFPagination.Views
{
    public partial class frmRTFView : Form
    {
        //Variable to store pages of the RTF document
        private String[] pages;

        //Variable to store the document header
        private String[] documentHeader = new String[2];

        //Variable to store the currentPageIndex
        private int currentPageIndex = 0;

        public frmRTFView()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Select RTF file 
            String fileName = null;
            try
            {
                fileName = SelectFileToOpen();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No document was selected", "Select RTF file to view",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            //Try to load the selected RTF document
            try
            {
                //Load document
                LoadDocument(fileName);
                //Load document header
                LoadDocumentHeader();
                //Show the content in the control
                ShowPageContent();
                //Modify navigation panel
                ShowNavigationPanel();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Could not parse the document. Reason: " + ex.Message, "Parse error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void LoadDocument(String fileName)
        {
            //Best way to load the content of an RTF document is using the Rich Textbox Control

            //Load the file into Rich Textbox Control
            richTxtRTF.LoadFile(fileName);
            this.Text = "Viewing file: " + fileName;

            //Get the String content from the Rich Textbox Control
            String content = richTxtRTF.Rtf;

            //Split the content on the basis of pagebreak markers
            //And prepare the pages array
            //Each element of the array will be a separate page of the document
            String[] separatingStrings = { @"\page\par" };
            this.pages = content.Split(separatingStrings, System.StringSplitOptions.None);
        }
        private void LoadDocumentHeader()
        {
            String[] separatingStrings = { "\r\n" };

            String[] lines = pages[0].Split(separatingStrings, System.StringSplitOptions.None);

            //First two lines contain document header
            int lineNumber = 0;
            foreach (String line in lines)
            {
                this.documentHeader[lineNumber] = line;
                lineNumber++;
                if (lineNumber > 1)
                {
                    break;
                }
            }
        }

        private String SelectFileToOpen()
        {
            dlgOpenFile = new OpenFileDialog
            {

                InitialDirectory = Directory.GetCurrentDirectory(),

                Title = "Select RTF file to view",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "rtf",
                Filter = "RTF (*.rtf)|*.rtf|All (*.*)|*.*",
                FilterIndex = 0,
                RestoreDirectory = true,

                ReadOnlyChecked = false,
                ShowReadOnly = false
            };

            if (dlgOpenFile.ShowDialog() == DialogResult.OK)
            {
                return dlgOpenFile.FileName;
            }
            else
            {
                throw new Exception("No files selected");
            }
        }

        private void ShowPageContent()
        {
            if (this.currentPageIndex == 0)
            {
                //Do not add header, because header is already available in the first page
                richTxtRTF.Rtf = pages[this.currentPageIndex];
            }
            else
            {
                //Add the document header
                richTxtRTF.Rtf = this.documentHeader[0] + this.documentHeader[1] + this.pages[this.currentPageIndex];
            }
        }

        private void ShowNavigationPanel()
        {
            pnlNavigator.Visible = true;
            if(this.currentPageIndex == 0) //First page
            {
                btnPrevPage.Enabled = false;
            }

            if(this.currentPageIndex == (this.pages.Length - 1)) //Last page
            {
                btnNextPage.Enabled = false;
            }

            if (this.currentPageIndex < (this.pages.Length - 1)) //Not the last page
            {
                btnNextPage.Enabled = true;
            }

            if (this.currentPageIndex > 0) //Not the first page
            {
                btnPrevPage.Enabled = true;
            }

            lblPageIndex.Text = "Current page #" + (this.currentPageIndex + 1) + " of " + this.pages.Length;
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            this.currentPageIndex++;
            ShowPageContent();
            ShowNavigationPanel();
        }

        private void btnPrevPage_Click(object sender, EventArgs e)
        {
            this.currentPageIndex--;
            ShowPageContent();
            ShowNavigationPanel();

        }
    }
}
