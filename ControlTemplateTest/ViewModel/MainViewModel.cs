using ControlTemplateTest.Model;
using GalaSoft.MvvmLight;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ControlTemplateTest.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private List<Port> ports;

        public List<Port> Ports
        {
            get { return ports; }
            set { ports = value;
                RaisePropertyChanged(() => Ports);
            }
        }
        private ObservableCollection<ShowSpeed> showSpeeds;

        public ObservableCollection<ShowSpeed> ShowSpeeds
        {
            get { return showSpeeds; }
            set { showSpeeds = value; }
        }
        private Selector portSelector;

        public Selector PortSelector
        {
            get { return portSelector; }
            set { portSelector = value;
                RaisePropertyChanged(() => PortSelector);
            }
        }
        private Selector grabSelector;

        public Selector GrabSelector
        {
            get { return grabSelector; }
            set
            {
                grabSelector = value;
                RaisePropertyChanged(() => GrabSelector);
            }
        }
        private Selector fingerSelector;

        public Selector FingerSelector
        {
            get { return fingerSelector; }
            set
            {
                fingerSelector = value;
                RaisePropertyChanged(() => FingerSelector);
            }
        }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Ports = new List<Port>()
            {
                new Port(){ Name="传感器1：",PortNumber="15.412"},
                new Port(){ Name="传感器2：",PortNumber="14.334"},
                new Port(){ Name="传感器3：",PortNumber="16.852"},
                new Port(){ Name="传感器4：",PortNumber="13.265"},
                new Port(){ Name="传感器5：",PortNumber="12.766"},
                new Port(){ Name="传感器6：",PortNumber="15.474"},
                new Port(){ Name="传感器7：",PortNumber="14.564"},
                new Port(){ Name="传感器8：",PortNumber="13.162"},
                new Port(){ Name="传感器9：",PortNumber="16.421"},
            };
            showSpeeds = new ObservableCollection<ShowSpeed>()
            {
                new ShowSpeed(){Name="电机   1  速度：",Speed="780"},
                new ShowSpeed(){Name="电机   2  速度：",Speed="780"},
                new ShowSpeed(){Name="电机   3  速度：",Speed="780"},
                new ShowSpeed(){Name="步进电机速度：",Speed="1000"},
            };
            List<string> PortNum = new List<string>() {"COM1", "COM2" , "COM3"};
            PortSelector = new Selector() { Name = "串口号", Options = PortNum };
            List<string> grabOpts = new List<string>() { "两指精确捏取", "三指对心包络抓取", "三指平行包络抓取"};
            GrabSelector = new Selector() { Name = "抓取模式选择", Options = grabOpts };
            List<string> fingerOpts = new List<string>() { "手指张开", "手指闭合"};
            FingerSelector = new Selector() { Name = "手指张合", Options = fingerOpts };
        }
    }
}