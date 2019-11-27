using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Forms;

namespace GreenHouse
{
    public partial class MainForm : Form,IMainForm
    {
        public MainForm(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
            _applicationContext.MainForm = this;
            InitializeComponent();
        }

        private readonly ApplicationContext _applicationContext;

        public event Action AddNewDevice;
        public event Action SetCurrentGrowingPlant;
        public event Action StartCycle;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartCycle?.Invoke();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SetCurrentGrowingPlant?.Invoke();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNewDevice?.Invoke();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
