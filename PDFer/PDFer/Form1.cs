using Microsoft.Office.Interop.Word;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.IO;
using System.Windows.Forms;

//add a reference to Microsoft.Office.Interop.Word 

namespace PDFer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cmdDir_Click(object sender, EventArgs e)
        {
        //    using (var fbd = new FolderBrowserDialog())
        //    {
        //        //DialogResult result = fbd.ShowDialog();

        //        //var dlg1 = new Ionic.Utils.FolderBrowserDialogEx();
        //        //dlg1.Description = "Select a folder to extract to:";
        //        //dlg1.ShowNewFolderButton = true;
        //        //dlg1.ShowEditBox = true;
        //        ////dlg1.NewStyle = false;
        //        //dlg1.SelectedPath = "";//txtExtractDirectory.Text;
        //        //dlg1.ShowFullPathInEditBox = true;
        //        //dlg1.RootFolder = System.Environment.SpecialFolder.MyComputer;

        //        //DialogResult result = null;
        //        //CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        //        ////dialog.InitialDirectory = txtFolder.Text;
        //        //dialog.IsFolderPicker = true;
        //        //if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
        //        //{
        //        //    result = dialog.FileName;
        //        //}


        //        //// Show the FolderBrowserDialog.
        //        //DialogResult result = dialog.ShowDialog();
        //        ////if (result == DialogResult.OK)
        //        ////{
        //        ////    txtExtractDirectory.Text = dlg1.SelectedPath;
        //        ////}

        //        if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
        //        {
        //            //string[] files = Directory.GetFiles(fbd.SelectedPath);

        //            //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");

        //            // Create a new Microsoft Word application object
        //            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

        //            // C# doesn't have optional arguments so we'll need a dummy value
        //            object oMissing = System.Reflection.Missing.Value;

        //            // Get list of Word files in specified directory
        //            //DirectoryInfo dirInfo = new DirectoryInfo(@"\\server\folder"); fbd.SelectedPath
        //            DirectoryInfo dirInfo = new DirectoryInfo(fbd.SelectedPath); 
        //            FileInfo[] wordFiles = dirInfo.GetFiles("*.docx");

        //            word.Visible = false;
        //            word.ScreenUpdating = false;

        //            foreach (FileInfo wordFile in wordFiles)
        //            {
        //                // Cast as Object for word Open method
        //                Object filename = (Object)wordFile.FullName;

        //                // Use the dummy value as a placeholder for optional arguments
        //                Document doc = word.Documents.Open(ref filename, ref oMissing,
        //                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
        //                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
        //                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
        //                doc.Activate();

        //                object outputFileName = wordFile.FullName.Replace(".doc", ".pdf");
        //                object fileFormat = WdSaveFormat.wdFormatPDF;

        //                // Save document into PDF Format
        //                doc.SaveAs(ref outputFileName,
        //                    ref fileFormat, ref oMissing, ref oMissing,
        //                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
        //                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
        //                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

        //                // Close the Word document, but leave the Word application open.
        //                // doc has to be cast to type _Document so that it will find the
        //                // correct Close method.                
        //                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
        //                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
        //                doc = null;
        //            }

        //            // word has to be cast to type _Application so that it will find
        //            // the correct Quit method.
        //            ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
        //            word = null;


        //        }
        //    }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

            
                        // Create a new Microsoft Word application object
                        Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();

                        // C# doesn't have optional arguments so we'll need a dummy value
                        object oMissing = System.Reflection.Missing.Value;

                        // Get list of Word files in specified directory
                        DirectoryInfo dirInfo = new DirectoryInfo(txtFolder.Text);
                        FileInfo[] wordFiles = dirInfo.GetFiles("*.doc*");

                        word.Visible = false;
                        word.ScreenUpdating = false;

                        foreach (FileInfo wordFile in wordFiles)
                        {
                            //object outputFileName = wordFile.FullName.Replace(".doc", ".pdf");
                            string extension = wordFile.FullName.Substring(wordFile.FullName.IndexOf("."));
                            object outputFileName = wordFile.FullName.Replace(extension, ".pdf");

                            if (!File.Exists(outputFileName.ToString()))
                            {
                                richTextBox1.AppendText("\nConverting file: " + outputFileName.ToString());

                                // Cast as Object for word Open method
                                Object filename = (Object)wordFile.FullName;

                                // Use the dummy value as a placeholder for optional arguments
                                Document doc = word.Documents.Open(ref filename, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);
                                doc.Activate();

                                object fileFormat = WdSaveFormat.wdFormatPDF;

                                // Save document into PDF Format
                                doc.SaveAs(ref outputFileName,
                                    ref fileFormat, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing,
                                    ref oMissing, ref oMissing, ref oMissing, ref oMissing);

                                // Close the Word document, but leave the Word application open.
                                // doc has to be cast to type _Document so that it will find the
                                // correct Close method.                
                                object saveChanges = WdSaveOptions.wdDoNotSaveChanges;
                                ((_Document)doc).Close(ref saveChanges, ref oMissing, ref oMissing);
                                doc = null;

                                // word has to be cast to type _Application so that it will find
                                // the correct Quit method.
                                ((_Application)word).Quit(ref oMissing, ref oMissing, ref oMissing);
                                word = null;
                            }
                            else
                            {
                                richTextBox1.AppendText("\nFile exists: " + outputFileName.ToString());
                            }
                
                        }
            }
            catch (Exception ex)
            {
                richTextBox1.AppendText("\n\nERROR: " + ex + "\n");
                //throw;
            }
        }
    }
}
