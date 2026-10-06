using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace hwlesson_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            listView1.Columns.Add("СPU name", 150);
            listView1.Columns.Add("ID", 60);
            listView1.Columns.Add("Streams", 70);
            listView1.Columns.Add("Descriptors", 90);

            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            timer1.Start();

            GetProcess();
        }

        private void GetProcess()
        {
            listView1.BeginUpdate();
            listView1.Items.Clear();

            foreach (var proc in Process.GetProcesses())
            {
                try
                {
                    ListViewItem item = new ListViewItem(proc.ProcessName);
                    item.SubItems.Add(proc.Id.ToString());
                    item.SubItems.Add(proc.Threads.Count.ToString());
                    item.SubItems.Add(proc.HandleCount.ToString());

                    listView1.Items.Add(item);
                }
                catch { }
            }

            listView1.EndUpdate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetProcess();
        }

        private void btnSendArgumen_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo("lesson_1.exe")
            {
                Arguments = txtBoxArgum.Text
            };
            Process.Start(startInfo);
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ListViewItem item in listView1.Items)
            {
                sb.AppendLine($"{item.Text}\t{item.SubItems[1].Text}\t{item.SubItems[2].Text}\t{item.SubItems[3].Text}");
            }

            File.WriteAllText("processes.txt", sb.ToString());
            MessageBox.Show("Saved to processes.txt!");
        }
    }
}