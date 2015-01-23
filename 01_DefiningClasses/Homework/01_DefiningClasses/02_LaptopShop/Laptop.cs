using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Laptop
{
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private int hdd;
    private string screen;
    private string battery;
    private float batteryLife;
    private decimal price;

    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, int hdd, string screen, string battery, float batteryLife, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.BatteryLife = batteryLife;
        this.Price = price;
    }

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }

    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = value;
        }
    }

    public string Processor
    {
        get
        {
            return this.processor;
        }
        set
        {
            this.processor = value;
        }
    }

    public int Ram
    {
        get
        {
            return this.ram;
        }
        set
        {
            this.ram = value;
        }
    }

    public string GraphicsCard
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            this.graphicsCard = value;
        }
    }

    public int Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            this.hdd = value;
        }
    }

    public string Screen
    {
        get
        {
            return this.screen;
        }
        set
        {
            this.screen = value;
        }
    }

    public string Battery
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }

    public float BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            this.batteryLife = value;
        }
    }

    public decimal Price
    {
        get
        {
            return this.price;
        }
        set
        {
            this.price = value;
        }
    }
}

