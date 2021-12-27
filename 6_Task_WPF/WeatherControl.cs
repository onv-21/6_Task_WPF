using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _6_Task_WPF
{
    class WeatherControl : DependencyObject
    {
        public static readonly DependencyProperty TemperatureProperty;
        public int temperature;
        public string windDirection;
        public int windSpeed;
        public int downFall;
        public int Temperature
        {
            get => (int)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty, value);
        }
        public string WindDirection
        {
            get => windDirection;
            set => windDirection = value;
        }
        public int WindSpeed
        {
            get
            {
                return windSpeed;
            }
            set
            {
                if (value >= 0)
                {
                    temperature = value;
                }
                else
                {
                    temperature = 0;
                }
            }
        }
        public enum DownFall
        {
            Солнечно = 0,
            Облачно = 1,
            Дождь = 2,
            Снег = 3
        }
      
        static WeatherControl()
        {
            TemperatureProperty = DependencyProperty.Register(
                nameof(Temperature),
                typeof(int),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.AffectsMeasure |
                    FrameworkPropertyMetadataOptions.AffectsRender,
                    null,
                    new CoerceValueCallback(CoerceTemperature)
                ),
                new ValidateValueCallback(ValidateTemperature));
        }

        private static bool ValidateTemperature(object value)
        {
            int v = (int)value;
            if (v >= -50 && v <= 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static object CoerceTemperature(DependencyObject d, object baseValue)
        {
            int v = (int)baseValue;
            if (v >= -50)
            {
                return v;
            }
            else
            {
                return 0;
            }
        }
    }
}

