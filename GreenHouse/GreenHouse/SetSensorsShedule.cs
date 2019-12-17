using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.Entity;
using Presentation.Forms;

namespace GreenHouse
{
    public partial class SetSensorsShedule : Form,ISetSensorsSchedule
    {
        private int _currentDay = -1;

        public event Action FieldUpdate;
        public event Action SaveData;

        public SetSensorsShedule()
        {
            InitializeComponent();

            textBox3.TextChanged += FieldUpdated;
            textBox4.TextChanged += FieldUpdated;
            textBox5.TextChanged += FieldUpdated;
            textBox6.TextChanged += FieldUpdated;
            textBox9.TextChanged += FieldUpdated;
            textBox10.TextChanged += FieldUpdated;
            textBox13.TextChanged += FieldUpdated;
            textBox14.TextChanged += FieldUpdated;
            textBox17.TextChanged += FieldUpdated;
            textBox18.TextChanged += FieldUpdated;
            textBox21.TextChanged += FieldUpdated;
            textBox22.TextChanged += FieldUpdated;
            comboBox1.TextChanged += FieldUpdated;
            comboBox10.TextChanged += FieldUpdated;
            comboBox11.TextChanged += FieldUpdated;
            comboBox12.TextChanged += FieldUpdated;
            comboBox13.TextChanged += FieldUpdated;
            comboBox14.TextChanged += FieldUpdated;
            comboBox15.TextChanged += FieldUpdated;
            comboBox16.TextChanged += FieldUpdated;
            comboBox17.TextChanged += FieldUpdated;
            comboBox18.TextChanged += FieldUpdated;
            comboBox19.TextChanged += FieldUpdated;
            comboBox2.TextChanged += FieldUpdated;
            comboBox20.TextChanged += FieldUpdated;
            comboBox21.TextChanged += FieldUpdated;
            comboBox22.TextChanged += FieldUpdated;
            comboBox23.TextChanged += FieldUpdated;
            comboBox24.TextChanged += FieldUpdated;
            comboBox3.TextChanged += FieldUpdated;
            comboBox4.TextChanged += FieldUpdated;
            comboBox5.TextChanged += FieldUpdated;
            comboBox6.TextChanged += FieldUpdated;
            comboBox7.TextChanged += FieldUpdated;
            comboBox8.TextChanged += FieldUpdated;
            comboBox9.TextChanged += FieldUpdated;

            this.FormClosed += new FormClosedEventHandler(SetSensorsScheduleFormClosed);
        }

        #region textBoxes
        string ISetSensorsSchedule.LightSensorOptimalValue { get => textBox3.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.AirTempretureSensorOptimalValue { get => textBox6.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.WetSensorOptimalValue { get => textBox10.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.AcidSensorOptimalValue { get => textBox14.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.NutrientSensorOptimalValue { get => textBox18.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.WaterTemperatureSensorOptimalValue { get => textBox22.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.LightSensorMaxDeviation { get => textBox4.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.AirTempretureSensorMaxDeviation { get => textBox5.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.WetSensorMaxDeviation { get => textBox9.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.AcidSensorMaxDeviation { get => textBox13.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.NutrientSensorMaxDeviation { get => textBox17.Text; set => throw new NotImplementedException(); }
        string ISetSensorsSchedule.WaterTemperatureSensorMaxDeviation { get => textBox21.Text; set => throw new NotImplementedException(); }

        #endregion textBoxes

        #region sensorsTime

        Time ISetSensorsSchedule.LightSensorStartTime { get => new Time(comboBox1.Text, comboBox2.Text); set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.AirTempretureSensorStartTime { get => new Time(comboBox4.Text, comboBox3.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.WetSensorStartHour { get => new Time(comboBox6.Text, comboBox5.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.AcidSensorStartHour { get => new Time(comboBox8.Text, comboBox7.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.NutrientSensorStartHour { get => new Time(comboBox10.Text, comboBox9.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.WaterTemperatureSensorStartHour { get => new Time(comboBox12.Text, comboBox11.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.LightSensorEndTime { get => new Time(comboBox24.Text, comboBox23.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.AirTempretureSensorEndTime { get => new Time(comboBox22.Text, comboBox21.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.WetSensorEndTime { get => new Time(comboBox20.Text, comboBox19.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.AcidSensorEndTime { get => new Time(comboBox18.Text, comboBox17.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.NutrientSensorEndTime { get => new Time(comboBox6.Text, comboBox15.Text);set => throw new NotImplementedException(); }
        Time ISetSensorsSchedule.WaterTemperatureSensorEndTime { get => new Time(comboBox14.Text, comboBox13.Text);set => throw new NotImplementedException(); }

        #endregion sensorsTime


        private void SetSensorsChedule_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FieldUpdated(object sender, EventArgs e)
        {
            FieldUpdate?.Invoke();
            // Add and verify new info in service
        }

        void SetSensorsScheduleFormClosed(object sender, FormClosedEventArgs e)
        {
            SaveData?.Invoke();
            // Save all form fields
        }

        public void SetCurrentDay(int day)
        {
            _currentDay = day;
            this.Text = $"Настройка работы датчиков для {day} дня ";
        }

        public int GetCurrentDay()
        {
            return _currentDay;
        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void ShowError(string message)
        {
            label35.Text = message;
        }
    }
}
