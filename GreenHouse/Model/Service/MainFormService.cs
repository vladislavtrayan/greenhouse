using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Entity;
using static EnvironmentModulation.Environment;

namespace Model.Service
{
    public class MainFormService : IMainFormService
    {
        private readonly ITimer _timer;
        private readonly IDeviceFactory _deviceFactory;
        private int _numberOfTicks = 0;
        private int _item_counter = 0;

        public event Action RedrawPictureBox;
        public event Action RefreshPictureBox;
        public event Action MouseDraggUIElement;
        public event Action MouseIsNotDraggingUIElement;

        public List<UIElement> UIElements { get; set; } = new List<UIElement>();
        public List<Device> Devices { get; set; } = new List<Device>();
        public Plant GrowingPlant { get ; set ; }
        private bool _isCycleStarted = false;
        public bool IsCycleStarted { get { return _isCycleStarted; } set { if (GrowingPlant.Name == string.Empty) { throw new ArgumentException(); } _isCycleStarted = value; } }
        public int CurrentDay { get; set; } = 0;
        public Time CurrentTime { get; set; } = new Time(0,0);
        public List<PassiveSensor> PassiveSensors { get; set; } = new List<PassiveSensor>();
        public List<ActiveSensor> ActiveSensors { get; set; } = new List<ActiveSensor>();

        public MainFormService(ITimer timer, IRepository<UIElement> repository,IDeviceFactory deviceFactory)
        {
            _deviceFactory = deviceFactory;
            _timer = timer;
            _timer.Interval = 5;
            _timer.Tick += TimerTick;
            _timer.Start();

            UIElement uIElement = new UIElement("Обогреватель",DeviceType.Device,Area.AirTemperature,@"C:\Users\vladi\OneDrive\Изображения\heater.png", 10, 10);
            uIElement.CurrentState = "active";
            UIElement uIElement1 = new UIElement("какая то дичь", DeviceType.PasssiveSensor,Area.WaterTemperature, @"C:\Users\vladi\OneDrive\Изображения\tempBitmap.png", 100, 200);
            repository.Add(uIElement);
            repository.Add(uIElement1);

            //UIElements = new List<UIElement>();

        }

        private void TimerTick(object sender, EventArgs e)
        {
            RedrawAllElements();
            _numberOfTicks++;
            if(IsCycleStarted)
                RecalculateTime();
        }

        public void RemoveElement(int elementId)
        {
        }

        public void RedrawAllElements()
        {
            RedrawPictureBox?.Invoke();
        }

        public void AddNewElement(UIElement uIElement)
        {
            uIElement.Id = _item_counter;
            UIElements.Add(uIElement);
            IDevice device = _deviceFactory.CreateDevice(uIElement.DeviceType,_item_counter);
            switch (uIElement.DeviceType)
            {
                case DeviceType.Device:
                    Devices.Add(device as Device);
                    break;
                case DeviceType.ActiveSensor:
                    ActiveSensors.Add(device as ActiveSensor);
                    break;
                case DeviceType.PasssiveSensor:
                    PassiveSensors.Add(device as PassiveSensor);
                    break;
                default:
                    throw new NotImplementedException();
            }
            _item_counter++;
        }

        public void MoveElement(int xPos, int yPos)
        {
            foreach (var element in UIElements)
                if (Math.Abs(element.Position.x - xPos) < 20 && Math.Abs(element.Position.y - yPos) < 20)
                {
                    MouseDraggUIElement.Invoke();
                    element.Position.x = xPos;
                    element.Position.y = yPos;
                }
                else { MouseIsNotDraggingUIElement.Invoke(); }
        }

        private void RecalculateTime()
        {
            if(_numberOfTicks % 60 == 0)
            {
                CurrentTime.Minutes = 20;

                if (CurrentTime.Hours == 0 && CurrentTime.Minutes == 0)
                    CurrentDay++;
            }
        }

        public void AddDevice(IDevice device)
        {

        }
    }
}
