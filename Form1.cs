using FluentMigrator.Runner.BatchParser;
using FluentMigrator.Runner.BatchParser.Sources;
using FluentMigrator.Runner.BatchParser.SpecialTokenSearchers;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SqlScriptRunner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtInputPath.Text = @"E:\DigitalFactory\ifactory-core-application\src\db\up";
            txtConnectionString.Text = @"Server = localhost; Database = PhoenixDBTest; Trusted_Connection = True;";
            this.dgvFileList.DataSource = null;
            this.dgvFileList.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.btnClear_Click(null, null);
            if (string.IsNullOrEmpty(txtInputPath.Text))
            {
                txtInputPath.Text = @"C:\";
            }
            OpenFileDialog objOpenFileDialog = new OpenFileDialog
            {
                InitialDirectory = txtInputPath.Text,
                Title = "Browse Sql Script Files",
                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "sql",
                Filter = "sql Script files (*.sql)|*.sql|All files (*.*)|*.*",
                RestoreDirectory = true,
                Multiselect = true
            };

            if (objOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (objOpenFileDialog.FileNames.Length > 0)
                {
                    this.dgvFileList.Visible = true;
                    this.dgvFileList.Columns.Add("SrNo", "Sr. No.");
                    this.dgvFileList.Columns.Add("FileName", "File Name");
                    this.dgvFileList.Columns.Add("FilePath", "File Path");
                    this.dgvFileList.Columns[2].Visible = false;
                    this.dgvFileList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                }
                int i = 0;
                foreach (String file in objOpenFileDialog.FileNames)
                {
                    i++;
                    this.dgvFileList.Rows.Add(i, Path.GetFileName(file), file);
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConnectionString.Text))
            {
                txtConnectionString.Focus();
            }
            else
            {
                dgvFileList.SelectAll();
                dgvFileList.Sort(dgvFileList.Columns["SrNo"], ListSortDirection.Descending);
                int Progress = dgvFileList.SelectedRows.Count;
                int FileProcessed = 0;

                foreach (DataGridViewRow row in dgvFileList.SelectedRows)
                {
                    try
                    {
                        string Query = File.ReadAllText(row.Cells[2].Value.ToString());

                        ExecuteBatchNonQuery(txtConnectionString.Text, Query);

                        dgvFileList.Rows.RemoveAt(row.Index);
                        txtOutput.Text += Environment.NewLine + " P=> " + row.Cells[0].Value + " : " + row.Cells[1].Value;

                        FileProcessed++;
                        pbProcess.Value = (FileProcessed * 100) / Progress;
                    }
                    catch (Exception ex)
                    {
                        txtOutput.Text += Environment.NewLine + " F=> " + row.Cells[0].Value + " : " + row.Cells[1].Value;
                        txtOutput.Text += Environment.NewLine + ex.Message;
                    }
                    finally
                    {
                        dgvFileList.Refresh();
                        txtOutput.Refresh();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dgvFileList.Rows.Clear();
            this.dgvFileList.Refresh();
            txtOutput.Clear();
            pbProcess.Value = 0;
        }

        public static void ExecuteBatchNonQuery(string ConnectionString, string sql)
        {
            var sqlBatch = string.Empty;
            var conn = new SqlConnection(ConnectionString);
            conn.Open();

            try
            {
                var parser = new SqlServerBatchParser();
                parser.SqlText += (sender, args) => { sqlBatch = args.SqlText.Trim(); };
                parser.SpecialToken += (sender, args) =>
                {
                    if (string.IsNullOrEmpty(sqlBatch))
                        return;

                    if (args.Opaque is GoSearcher.GoSearcherParameters goParams)
                    {
                        using (var command = conn.CreateCommand())
                        {
                            command.CommandText = sqlBatch;

                            for (var i = 0; i != goParams.Count; ++i)
                            {
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    sqlBatch = null;
                };

                using (var source = new TextReaderSource(new StringReader(sql), true))
                {
                    parser.Process(source, stripComments: true);
                }

                if (!string.IsNullOrEmpty(sqlBatch))
                {
                    using (var command = conn.CreateCommand())
                    {
                        command.CommandText = sqlBatch;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                using (var message = new StringWriter())
                {
                    message.WriteLine("The error was {0}", ex.Message);
                    throw new Exception(message.ToString(), ex);
                }
            }
            finally
            {
                conn?.Dispose();
            }
        }
    }
}
