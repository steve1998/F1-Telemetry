﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace F1Telemetry.WPF.Model
{
    public class CarTyreTemperatureModel
    {
        public TyreTemperature FrontLeft { get; set; } = new TyreTemperature();
        public TyreTemperature FrontRight { get; set; } = new TyreTemperature();
        public TyreTemperature RearLeft { get; set; } = new TyreTemperature();
        public TyreTemperature RearRight { get; set; } = new TyreTemperature();
    }

    public class TyreTemperature : INotifyPropertyChanged
    {
        private byte min;
        private byte max;
        private byte current;

        public byte Min
        {
            get { return min; }
        }

        public byte Max
        {
            get { return max; }
        }

        public byte Current
        {
            get
            {
                return current;
            }
            set
            {
                current = value;
                OnPropertyChanged();

                if (value > max)
                {
                    max = value;
                    OnPropertyChanged(nameof(max));
                }

                if (min == 0)
                {
                    min = value;
                }
                else
                {
                    if (value < min)
                    {
                        min = value;
                    }
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}