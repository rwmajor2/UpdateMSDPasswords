using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;
using ESRI.ArcGIS.DataSourcesGDB;

namespace UpdateMSDpwds
{
    public partial class analyzeForm : Form
    {
        public analyzeForm()
        {
            InitializeComponent();
        }

        private void btnSelSDEFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "MDS Files (.msd)|*.msd";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtMSD.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAnalyzeMSD_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "SDE Files (.sde)|*.sde";
                ofd.FilterIndex = 1;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtMSD.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateDBConnection(string msdFilepath, string sde)
        {
            IWorkspaceFactory2 wf = new SdeWorkspaceFactoryClass();
            IWorkspace ws = wf.OpenFromFile(sde, 0);
            IDataset ds = (IDataset)ws;
            IWorkspaceName2 wn = (IWorkspaceName2)ds.FullName;
            string conn = wn.ConnectionString;

            IMSDHelper helper = new MSDHelper();
            helper.Open(msdFilepath);
            var maps = helper.GetMaps();
            for (var i = 0; i < maps.Count; i++)
            {
                var layers = helper.GetLayers(maps.Element[i]);
                for (var j = 0; j < layers.Count; j++)
                {
                    helper.PutWorkspaceConnectionStringInLayer(layers.Element[i], conn, false);
                }
            }
        }
        private void printMSDConnections(string msd)
        {
            try
            {
                IMSDHelper helper = new MSDHelper();
                helper.Open(msd);
                var maps = helper.GetMaps();
                for (var i = 0; i < maps.Count; i++)
                {
                    var layers = helper.GetLayers(maps.Element[i]);
                    for (var j = 0; j < layers.Count; j++)
                    {
                        List<string> dbconns = helper.GetWorkspaceConnectionStringFromLayer(layers.Element[j]).Split(';').ToList<string>();
                        foreach (string param in dbconns)
                        {
                            this.richTextBox1.Text += param + "\n";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printSDEConnections(string sde)
        {
            try
            {
                // We use IWorkspacename2 so that it returns a ENCRYPTED_PASSWORD required
                // for the connection string in an MSD.

                IWorkspaceFactory2 wf = new SdeWorkspaceFactoryClass();
                IWorkspace ws = wf.OpenFromFile(txtSDE.Text, 0);
                IDataset ds = (IDataset)ws;
                IWorkspaceName2 wn = (IWorkspaceName2)ds.FullName;
                List<string> dbconns = wn.ConnectionString.Split(';').ToList<string>();
                foreach (string param in dbconns)
                {
                    this.richTextBox2.Text += param + "\n";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
