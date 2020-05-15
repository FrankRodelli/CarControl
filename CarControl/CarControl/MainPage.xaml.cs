using CarControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CarControl
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CarDataSimulator cds = new CarDataSimulator();

            BindingContext = this;

            Device.StartTimer(TimeSpan.FromSeconds(.1), () =>
            {
                OnPropertyChanged(nameof(Speed));
                OnPropertyChanged(nameof(RPM));
                OnPropertyChanged(nameof(Temp));
                OnPropertyChanged(nameof(Gas));

                return true; 
            });
        }

        public int Speed
        {
            get { return CarData.Speed; }
            set
            {
                CarData.Speed = value ;
                OnPropertyChanged(nameof(Speed));
            }
        }

        public int RPM
        {
            get { return CarData.RPM; }
            set
            {
                CarData.RPM = value;
                OnPropertyChanged(nameof(RPM));
            }
        }

        public double Temp
        {
            get { return CarData.Temp; }
            set
            {
                CarData.Temp = value;
                OnPropertyChanged(nameof(Temp));
            }
        }
        public double Gas
        {
            get { return CarData.Gas; }
            set
            {
                CarData.Gas = value;
                OnPropertyChanged(nameof(Gas));
            }
        }
    }
}
