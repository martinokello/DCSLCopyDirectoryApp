using CopyDirectoryEngine.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCSLCopyDirectoryApp
{
    public partial class CopyFacility : Form
    {
        delegate void Method(object progress);
        public CopyFacility()
        {
            InitializeComponent();
        }

        private void CopyFacility_Load(object sender, EventArgs e)
        { 
            progressBar.Value = 0;
            SourceFolder = new FolderBrowserDialog();
            DestinationFolder = new FolderBrowserDialog();
            SourceFolder.RootFolder = Environment.SpecialFolder.Desktop;
            DestinationFolder.RootFolder = Environment.SpecialFolder.Desktop;
        }
        public void RunFunction(object progress){
           
                progressBar.Value = (progress as OperationProgress).Progress; 
        }
        private void CopyButton_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar.Minimum = 0;
                progressBar.Maximum = 100;

                var progress = new OperationProgress();
                progressBar.Value = (int)progress.Progress;
                
                progress.PropertyChanged += (prog, evt) =>
                {
                    if (evt.PropertyName.ToLower().Equals("progress"))
                    {
                        Method funcToRun = RunFunction;
                        progressBar.Invoke(funcToRun, progress);
                    } 
                };

                    var copyEngine = new CopyDirectoryEngine.DirectoryCopyEngine();

                    Task.Run(() =>
                        copyEngine.StartCopy(SourceFolderPath.Text, DestinationFolderPath.Text, progress)).ConfigureAwait(true).GetAwaiter().OnCompleted(
                            () => {
                                MessageBox.Show("Completed Successfully!");
                            });
                MessageBox.Show("Task running");
                

                
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SourceFolder_HelpRequest(object sender, EventArgs e)
        {

        }

        private void SourceDirectoryBtn_Click(object sender, EventArgs e)
        {
            SourceFolder.ShowDialog();
            SourceFolderPath.Text = SourceFolder.SelectedPath;
        }

        private void DestinationDirectoryBtn_Click(object sender, EventArgs e)
        {
            DestinationFolder.ShowDialog();
            DestinationFolderPath.Text = DestinationFolder.SelectedPath;
        }
    }
}
