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
    private string hdd;
    private string screen;
    private Battery batteryInfo;
    private decimal price;

    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen, Battery batteryInfo, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.BatteryInfo = batteryInfo;
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
            Validators.AssertNotEmpty(value, "model");
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
            Validators.AssertNotEmpty(value, "manufacturer");
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
            Validators.AssertNotEmpty(value, "processor");
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
            Validators.AssertIsPositive(value, "ram");
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
            Validators.AssertNotEmpty(value, "graphics card");
            this.graphicsCard = value;
        }
    }

    public string Hdd
    {
        get
        {
            return this.hdd;
        }
        set
        {
            Validators.AssertNotEmpty(value, "hdd");
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
            Validators.AssertNotEmpty(value, "screen");
            this.screen = value;
        }
    }

    public Battery BatteryInfo
    {
        get
        {
            return this.batteryInfo;
        }
        set
        {
            this.batteryInfo = value;
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
            Validators.AssertIsPositive(value, "price");
            this.price = value;
        }
    }
}

