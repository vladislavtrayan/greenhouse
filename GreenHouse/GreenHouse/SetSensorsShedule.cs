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
    public partial class SetSensorsShedule : Form,ISetSensorsSchedule
    {
        Action action;

        public SetSensorsShedule()
        {
            InitializeComponent();
            
            textBox3.TextChanged += FieldUpdated;
            this.FormClosed += new FormClosedEventHandler(SetSensorsScheduleFormClosed);
        }

        public string LightSensorOptimalValue => textBox3.Text;

        private void SetSensorsChedule_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FieldUpdated(object sender, EventArgs e)
        {
            action?.Invoke();
            // Add and verify new info in service
        }

        void SetSensorsScheduleFormClosed(object sender, FormClosedEventArgs e)
        {
            // Save all form fields
        }
    }
}
