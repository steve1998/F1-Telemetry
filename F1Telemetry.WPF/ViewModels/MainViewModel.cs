﻿using F12020Telemetry.Data;
using System.ComponentModel;

namespace F1Telemetry.WPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public SessionViewModel SessionInfo { get; set; } = new SessionViewModel();

        // 5000 for one minute of data.
        public double[] speed = new double[25_000];
        public double[] time = new double[25_000];
        public double[] gear = new double[25_000];

        public double[] throttle = new double[25_000];
        public double[] brake = new double[25_000];

        public CurrentTelemetryDataViewModel CurrentTelemetry { get; set; } = new CurrentTelemetryDataViewModel();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}