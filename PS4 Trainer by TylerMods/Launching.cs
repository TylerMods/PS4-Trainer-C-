using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace PS4_Trainer_by_TylerMods
{
    public partial class Launching : Form
    {
        public static main main;
        public Launching()
        {
            InitializeComponent();
            timer1.Start();
            this.Activate();

        }

        private void Launching_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flatProgressBar1.Increment(1);

            Run();
        }
        public void Run()
        {
            if (flatProgressBar1.Value == 5)
            {
                this.typeWriter.RunWorkerAsync();
            }

            if (flatProgressBar1.Value == 72)
            {

                main = new main();
                main.Show();


            }
            if (flatProgressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
            }
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void flatProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void lblConnect_Click(object sender, EventArgs e)
        {

        }

        private void typeWriter_DoWork(object sender, DoWorkEventArgs e)
        {
            string TypeWriting = "PS4 Trainer";
            for (int i = 0; i < TypeWriting.Length; i++)
            {
                Invoke(new MethodInvoker(delegate { richTextBox1.AppendText(TypeWriting[i].ToString()); }));
            System.Threading.Thread.Sleep(95);
            }
        }
    }
}
