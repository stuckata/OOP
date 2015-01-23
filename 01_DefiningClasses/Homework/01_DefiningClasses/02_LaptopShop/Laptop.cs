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

    public Laptop(string model, string processor, int ram, string graphicsCard, string hdd, string screen, decimal price)
    {
        this.Model = model;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
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

    public override string ToString()
    {
        StringBuilder laptopSpecs = new StringBuilder();

        string header = String.Format("=== LAPTOP ===");
        laptopSpecs.AppendLine(header);

        string laptopModel = String.Format("=== model : {0}", this.Model);
        laptopSpecs.AppendLine(laptopModel);

        if (this.Manufacturer != null)
        {
            string laptopManufacturer = String.Format("=== manufacturer : {0}", this.Manufacturer);
            laptopSpecs.AppendLine(laptopManufacturer);
        }

        if (this.Processor != null)
        {
            string laptopProcessor = String.Format("=== processor : {0}", this.Processor);
            laptopSpecs.AppendLine(laptopProcessor);
        }

        if (this.Ram != 0)
        {
            string laptopRam = String.Format("=== ram : {0} GB", this.Ram);
            laptopSpecs.AppendLine(laptopRam);
        }

        if (this.GraphicsCard != null)
        {
            string laptopGraphicsCard = String.Format("=== graphics card : {0}", this.GraphicsCard);
            laptopSpecs.AppendLine(laptopGraphicsCard);
        }

        if (this.Hdd != null)
        {
            string laptopHdd = String.Format("=== hdd : {0}", this.Hdd);
            laptopSpecs.AppendLine(laptopHdd);
        }

        if (this.Screen != null)
        {
            string laptopScreen = String.Format("=== screen : {0}", this.Screen);
            laptopSpecs.AppendLine(laptopScreen);
        }

        if (this.BatteryInfo != null)
        {
            string laptopBatterySpecs = String.Format("=== battery : {0}", this.BatteryInfo.BatterySpecs);
            laptopSpecs.AppendLine(laptopBatterySpecs);
            string laptopBatteryLife = String.Format("=== battery life : {0}", this.BatteryInfo.BatteryLife);
            laptopSpecs.AppendLine(laptopBatteryLife);
        }

        string laptopPrice = String.Format("=== price : {0}", this.Price);
        laptopSpecs.AppendLine(laptopPrice);

        return laptopSpecs.ToString().Trim();
    }
}

