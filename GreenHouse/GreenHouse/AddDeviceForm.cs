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
    public partial class AddDeviceForm : Form,IAddDeviceForm
    {
        public int SelectedDeviceId { get => listView1.SelectedIndices[0]; }

        public AddDeviceForm()
        {
            InitializeComponent();
            listView1.MouseDoubleClick += new MouseEventHandler(listView1_MouseDoubleClick);
        }

        public event Action AddDevice;


        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddDeviceForm_Load(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, EventArgs e)
        {
            AddDevice?.Invoke();
        }
    }
}
