class WeatherControl
{
    int temperature;
    string windDirection;
    int windSpeed;
    int downFall;
    public int Temperature
    {
        get
        {
            return temperature;
        }
        set
        {
            if (value >=-50 && value<=50)
            {
                temperature = value;
            }
            else
            {
                temperature = 0;
            }
        }
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

}
