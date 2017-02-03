using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//my references
using System.IO;
using System.Diagnostics;

namespace JSact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (txtUSPath.Text.Trim() == string.Empty)
            {
                DialogResult dlgresUSPath = fbdFolderBrowser.ShowDialog();

                if (dlgresUSPath == DialogResult.OK)
                {
                    string strSelectedPath = fbdFolderBrowser.SelectedPath;
                    GetXMLFiles(strSelectedPath);

                    //lbxFileList.Text = strFolderContent.ToList().ToString();
                    // MessageBox.Show("Files found: " + strFolderContent.Length.ToString(), "Message");
                }
            }
            else if (txtUSPath.Text.Trim() != string.Empty)
            {
                try
                {
                    string strresult = System.IO.Path.GetFullPath(txtUSPath.Text);
                    if (!Directory.Exists(strresult)) {
                        MessageBox.Show("Invalid Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    };
                }
                catch (Exception exPath)
                {
                    MessageBox.Show("Invalid Path\n" + exPath.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //My Functions
        private void GetXMLFiles(string strPath)
        {
            string[] strFolderContent = Directory.GetFiles(strPath, "*.xml");
            txtUSPath.Text = fbdFolderBrowser.SelectedPath;
            for (int intFiles = 0; intFiles < strFolderContent.Length; intFiles++)
            {
                lbxFileList.Items.Add(strFolderContent[intFiles].Substring(strFolderContent[intFiles].LastIndexOf("\\") + 1));
            }
        }

        private void btnGetJS_Click(object sender, EventArgs e)
        {
            ParseDOM DOMParser = new ParseDOM();
            foreach(string strUpdateSets in lbxFileList.Items)
            {
                DOMParser.GetJScript(txtUSPath.Text + "\\" + strUpdateSets.ToString());
            }
        }
    }
}
