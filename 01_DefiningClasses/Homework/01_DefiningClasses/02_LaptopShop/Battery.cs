using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Battery
{
    private string batterySpecs;
    private decimal batteryLife;

    public Battery(string laptopBattery, decimal batteryLife)
    {
        this.BatterySpecs = laptopBattery;
        this.BatteryLife = batteryLife;
    }

    public string BatterySpecs
    {
        get
        {
            return this.batterySpecs;
        }
        set
        {
            Validators.AssertNotEmpty(value, "battery specifications");
            this.batterySpecs = value;
        }
    }

    public decimal BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            Validators.AssertIsPositive(value, "battery life");
            this.batteryLife = value;
        }
    }
}

