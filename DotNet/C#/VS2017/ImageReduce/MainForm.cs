//*********************************************************************'
//* Copyright 2005-2016 - Accusoft Corporation, Tampa Florida.        *'
//* This sample code is provided to Accusoft licensees "as is"        *'
//* with no restrictions on use or modification. No warranty for      *'
//* use of this sample code is provided by Accusoft.                  *'
//*********************************************************************'
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Accusoft.ImagXpressSdk;

namespace ImageReduce
{
    public partial class MainForm : Form
    {
        static TransformMode _transformMode = TransformMode.None;
        static Int32 _jpegQualityFactor = 22;
        
        private int lastFilterIndex;

        public MainForm()
        {
            InitializeComponent();
        }

        const String TITLE = "ImageReduce";
        const Int32 COLUMN_FILENAME = 0;
        const Int32 COLUMN_FILESIZE = 1;
        const Int32 COLUMN_REDUCEDSIZE = 2;
        const Int32 COLUMN_SAVINGSSIZE = 3;
        const Int32 COLUMN_REMARKS = 4;

        public class ReduceOptions
        {
            public String inputPath;
            public String outputPath;
        }

        public class JpegReduceOptions : ReduceOptions
        {
            public Int32 jpegQualityFactor;
            public TransformMode transformMode;
        }

        public class ReduceResult
        {
            public String inputPath;
            public String outputPath;
            public Boolean isErrorEncountered;
            public String remarks;
        }

        public class JpegReduceResult : ReduceResult
        {
            public JpegReduceResult()
            {

            }

            public JpegReduceResult(ReduceResult baseResult)
            {
                inputPath = baseResult.inputPath;
                outputPath = baseResult.outputPath;
                isErrorEncountered = baseResult.isErrorEncountered;
                remarks = baseResult.remarks;
                jpegQualityFactor = _jpegQualityFactor;
				transformMode = _transformMode;
            }

            public Int32 jpegQualityFactor;
            public TransformMode transformMode;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //***The SetSolutionName, SetSolutionKey and possibly the SetOEMLicenseKey methods must be called to distribute the runtime***
            //_ix.Licensing.SetSolutionName("YourSolutionName");
            //_ix.Licensing.SetSolutionKey(12345,12345,12345,12345);
            //_ix.Licensing.SetOEMLicenseKey("1.0.AStringForOEMLicensingContactAccusoftSalesForMoreInformation…");

            // Bind ImagXpress Hand tool to left mouse button.
            inputImageXView.ToolSet(Tool.Hand, MouseButtons.Left, Keys.None);
            outputImageXView.ToolSet(Tool.Hand, MouseButtons.Left, Keys.None);
        }

        private string DisplayFileSize(long fileLength)
        {
            string fileLengthDisplayed = String.Empty;

            if (fileLength < 1024)
            {
                fileLengthDisplayed = String.Format("{0:N0} Bytes", fileLength);
            }
            else
            {
                fileLengthDisplayed = String.Format("{0:N0} KB", (double)fileLength / 1024);
            }

            return fileLengthDisplayed;
        }

        private void AddFileToReduce(string filename)
        {
            if (0 == listView.Items.Find(filename, true).Length)
            {
                string fileLengthDisplayed = DisplayFileSize(new FileInfo(filename).Length);
                string fullPath = Path.GetFullPath(filename);

                ListViewItem item = new ListViewItem(new string[] { 
                    fullPath, fileLengthDisplayed, String.Empty, String.Empty, String.Empty});
                item.Name = fullPath;
                listView.Items.Add(item);

                reduceButton.Enabled = true;
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "JPEG|*.jpe;*.jpg;*.jpeg|PNG|*.png";
                openFileDialog.FilterIndex = lastFilterIndex;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lastFilterIndex = openFileDialog.FilterIndex;

                    foreach (String path in openFileDialog.FileNames)
                    {
                        AddFileToReduce(path);
                    }
                }
            }
        }

        private void openDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowseDialog = new FolderBrowserDialog())
            {
                if (folderBrowseDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(folderBrowseDialog.SelectedPath);

                    foreach (string file in files)
                    {
                        if (IsFileExtensionJpeg(file) || IsFileExtensionPng(file))
                        {
                            AddFileToReduce(file);
                        }
                    }
                }
            }
        }

        private void imagXpressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imagXpress1.AboutBox();
        }

        private void reduceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reduceImagesAsync();
        }

        private void buttonReduce_Click(object sender, EventArgs e)
        {
            reduceImagesAsync();
        }

        private bool IsFileExtensionJpeg(string filename)
        {
            string extension = Path.GetExtension(filename);

            if (String.Equals(extension, ".jpg", StringComparison.OrdinalIgnoreCase) || String.Equals(extension, ".jpeg", StringComparison.OrdinalIgnoreCase)
                    || String.Equals(extension, ".jpe", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        private bool IsFileExtensionPng(string filename)
        {
            string extension = Path.GetExtension(filename);

            if (String.Equals(extension, ".png", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }

        private void reduceImagesAsync()
        {
            DisableUIForRun();
            List<ReduceOptions> optionsList = new List<ReduceOptions>();
            foreach (ListViewItem item in listView.Items)
            {
                // Save reduced file to a subdirectory called "Reduced" in the same location 
                // as the input. 
                // e.g. c:\users\public\Accusoft\Common\Images\akuma.jpg -> c:\users\public\Accusoft\Common\Images\Reduced\akuma.jpg
                //
                
                string inputPath = item.SubItems[COLUMN_FILENAME].Text;
                string inputFileName = Path.GetFileName(inputPath);
                string inputDirectory = Path.GetDirectoryName(inputPath);
                string outputDirectory = Path.Combine(inputDirectory, "Reduced");

                if (IsFileExtensionJpeg(inputPath))
                {
                    JpegReduceOptions options = new JpegReduceOptions();
                    options.inputPath = inputPath;
                    options.outputPath = Path.Combine(outputDirectory, inputFileName);
                    options.jpegQualityFactor = _jpegQualityFactor;
					options.transformMode = _transformMode;

                    optionsList.Add(options);
                }
                else if (IsFileExtensionPng(inputPath))
                {
                    ReduceOptions options = new ReduceOptions();
                    options.inputPath = inputPath;
                    options.outputPath = Path.Combine(outputDirectory, inputFileName);

                    optionsList.Add(options);
                }
            }
            backgroundWorker.RunWorkerAsync(optionsList);            
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<ReduceOptions> optionsList = (List<ReduceOptions>)e.Argument;
            Int32 remaining = optionsList.Count;
            foreach (ReduceOptions options in optionsList)
            {
                if (backgroundWorker.CancellationPending)
                {
                    break;
                }

                // Prepare to save reduced image: 
                // - Delete the target file if it already exists
                // - Ensure the host directory exists.
                deleteFileWhenExists(options.outputPath);
                Directory.CreateDirectory(Path.GetDirectoryName(options.outputPath));
              
                JpegReduceOptions jpegReduceOptions = new JpegReduceOptions();
                JpegReduceResult jpegLatestResult = new JpegReduceResult();
                
                ReduceResult latestResult = new ReduceResult();

                // Perform reduction and prepare to report results
                latestResult.inputPath = options.inputPath;
                latestResult.outputPath = options.outputPath;
                latestResult.isErrorEncountered = false;
                latestResult.remarks = String.Empty;

                bool areOptionsForJpeg = (options is JpegReduceOptions) ? true : false;

                if (areOptionsForJpeg)
                {
                    jpegReduceOptions = options as JpegReduceOptions;
                    jpegLatestResult = new JpegReduceResult(latestResult);
                    jpegLatestResult.jpegQualityFactor = jpegReduceOptions.jpegQualityFactor;
					jpegLatestResult.transformMode = jpegReduceOptions.transformMode;
                }

                try
                {
                    if (areOptionsForJpeg)
                    {                        
                        Accusoft.ImagXpressSdk.ImageReduce.JpegReduce(imagXpress1, jpegReduceOptions.inputPath, jpegReduceOptions.outputPath, jpegReduceOptions.jpegQualityFactor);
                    }
                    else
                    {
                        Accusoft.ImagXpressSdk.ImageReduce.PngReduce(imagXpress1, options.inputPath, options.outputPath);
                    }
                }
                catch (ImagXpressException ex)
                {
                    latestResult.isErrorEncountered = true;
                    latestResult.remarks = ex.Message;
                }
                catch (Exception ex)
                {
                    latestResult.isErrorEncountered = true;
                    latestResult.remarks = ex.ToString();
                }

                // Notify UI of a progress update
                int percentComplete = (int)((float)(optionsList.Count - remaining) / optionsList.Count * 100);
                if (areOptionsForJpeg)
                {
                    backgroundWorker.ReportProgress(percentComplete, jpegLatestResult);
                }
                else
                {
                    backgroundWorker.ReportProgress(percentComplete, latestResult);
                }
                remaining--;
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            // Interpret results
            ReduceResult latestResult = (ReduceResult)e.UserState;
            long inputFileLength = 0; 
            if (File.Exists(latestResult.inputPath))
            {
                inputFileLength = new FileInfo(latestResult.inputPath).Length;
            }
            long outputFileLength = 0;
            if (File.Exists(latestResult.outputPath))
            {
                outputFileLength = new FileInfo(latestResult.outputPath).Length;
            }            
            long savingsBytes = 0;
            if (0 != inputFileLength && 0 != outputFileLength)
            {
                savingsBytes = inputFileLength - outputFileLength;
            }
            double savingsPercentage = 0;
            if (0 != inputFileLength)
            {
                savingsPercentage = (double)savingsBytes / inputFileLength;
            }
            String savingsPercentageString = String.Format("{1} ({0:0 %})", savingsPercentage, DisplayFileSize(savingsBytes));
            String outputFileLengthString =  DisplayFileSize(outputFileLength);

            Color reductionColor = Color.FromArgb(255, 0, 232, 0);
            Color growthColor = Color.Red;
            try
            {
                listView.SuspendLayout();

                foreach (ListViewItem item in listView.Items.Find(latestResult.inputPath, true))
                {
                    // Update list view details
                    // Note: For convenience, the path to the reduced image will be carried
                    //      in the Tag property of the file name column.
                    item.SubItems[COLUMN_FILENAME].Tag = latestResult.outputPath;
                    item.SubItems[COLUMN_REDUCEDSIZE].Text = outputFileLengthString;
                    item.SubItems[COLUMN_SAVINGSSIZE].Text = savingsPercentageString;
                    item.SubItems[COLUMN_REMARKS].Text = latestResult.remarks;
                    if (savingsPercentage > 0)
                    {
                        item.SubItems[COLUMN_SAVINGSSIZE].BackColor = reductionColor;
                    }
                    else if (savingsPercentage < 0)
                    {
                        item.SubItems[COLUMN_SAVINGSSIZE].BackColor = growthColor;
                    }                    

                    // Refresh previously selected row
                    if (item.Selected)
                    {
                        refreshSideBySideComparison(item);
                    }
                }
            }
            finally
            {
                listView.ResumeLayout();
            }

            // Report Progress to user
            Text = String.Format("{0}% - {1}", new object[] { e.ProgressPercentage, TITLE });
        }

        private void refreshSideBySideComparison(ListViewItem item)
        {
            Cursor lastCursor = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                inputImageXView.SuspendLayout();
                outputImageXView.SuspendLayout();

                inputFileNameLabel.Text = String.Format("{0}, {1}",
                    new object[] { item.SubItems[COLUMN_FILENAME].Text, item.SubItems[COLUMN_FILESIZE].Text });
                inputImageXView.Image = null;
                if (File.Exists(item.SubItems[COLUMN_FILENAME].Text))
                {
                    inputImageXView.Image = ImageX.FromFile(imagXpress1, item.SubItems[COLUMN_FILENAME].Text);
                }

                outputFileNameLabel.Text = String.Format("{0}, {1}",
                    new object[] { item.SubItems[COLUMN_FILENAME].Tag, item.SubItems[COLUMN_REDUCEDSIZE].Text });
                outputImageXView.Image = null;
                if (File.Exists((String)item.SubItems[COLUMN_FILENAME].Tag))
                {
                    outputImageXView.Image = ImageX.FromFile(imagXpress1, (String)item.SubItems[COLUMN_FILENAME].Tag);
                }
            }
            catch (ImageXException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                inputImageXView.ResumeLayout();
                outputImageXView.ResumeLayout();
                Cursor.Current = lastCursor;
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Int32 index in listView.SelectedIndices)
            {
                refreshSideBySideComparison(listView.Items[index]);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            ReenableUIForAnotherRun();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker.CancelAsync();            
        }

        private void closeFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReenableUIForAnotherRun();
            ResetUI();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OptionsForm optionsForm = new OptionsForm())
            {
                optionsForm.JpegQualityFactor = _jpegQualityFactor;
                optionsForm.TransformMode = _transformMode;
                if (DialogResult.OK == optionsForm.ShowDialog())
                {
                    _jpegQualityFactor = optionsForm.JpegQualityFactor;
                    _transformMode = optionsForm.TransformMode;
                }                
            }
        }

        private void inputImageXView_ScrollEvent(object sender, Accusoft.ImagXpressSdk.ScrollEventArgs e)
        {
            // Sync view between before and after iamges
            outputImageXView.ScrollPosition = inputImageXView.ScrollPosition;
        }
        private void outputImageXView_ScrollEvent(object sender, Accusoft.ImagXpressSdk.ScrollEventArgs e)
        {
            // Sync view between before and after iamges
            inputImageXView.ScrollPosition = outputImageXView.ScrollPosition;
        }
        private void inputImageXView_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
        {
            // Sync view between before and after iamges
            outputImageXView.ZoomFactor = inputImageXView.ZoomFactor;
        }
        private void outputImageXView_ZoomFactorChanged(object sender, ZoomFactorChangedEventArgs e)
        {
            // Sync view between before and after iamges
            inputImageXView.ZoomFactor = outputImageXView.ZoomFactor;
        }

        private void ResetUI()
        {
            listView.Items.Clear();
            reduceButton.Enabled = false;
            inputImageXView.Image = null;
            outputImageXView.Image = null;
            inputFileNameLabel.Text = "Input FileName:";
            outputFileNameLabel.Text = "Output FileName:";
            Text = TITLE;
        }

        private void DisableUIForRun()
        {
            reduceButton.Enabled = false;
            stopButton.Visible = true;
            menuStrip.Enabled = false;
        }

        private void ReenableUIForAnotherRun()
        {
            Text = TITLE;
            reduceButton.Enabled = true;
            stopButton.Visible = false;
            menuStrip.Enabled = true;
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void deleteFileWhenExists(String filePath)
        {
            if (File.Exists(filePath))
            {
                FileAttributes attributes = File.GetAttributes(filePath);
                File.SetAttributes(filePath, attributes & ~FileAttributes.ReadOnly);
                File.Delete(filePath);
            }
        }
    }
}