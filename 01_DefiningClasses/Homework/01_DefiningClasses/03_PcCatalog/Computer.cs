using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computer
{
    private string name;
    private List<Component> components;

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            Validators.AssertNotEmpty(value, "name");
            this.name = value;
        }
    }

    public List<Component> Components
    {
        get
        {
            return this.components;
        }
        set
        {
            this.components = value;
        }
    }

    public decimal CalculatePrice()
    {
        decimal totalPrice = 0;
        foreach (Component component in this.Components)
        {
            totalPrice = totalPrice + component.Price;
        }
        return totalPrice;
    }

    public override string ToString()
    {
        StringBuilder result = new StringBuilder();

        string header = String.Format("=== Computer ===");
        result.AppendLine(header);
        string separationLine = String.Format("==============================================");
        result.AppendLine(separationLine);
        string computerName = String.Format("=== Name : {0}", this.Name);
        result.AppendLine(computerName);
        result.AppendLine(separationLine);

        List<Component> componentsOrderedByPrice = this.Components.OrderBy(c => c.Price).ToList();

        foreach (var component in componentsOrderedByPrice)
        {
            string componentName = String.Format("=== Component name : {0}", component.Name);
            result.AppendLine(componentName);

            if (component.Details != null)
            {
                string componentDetails = String.Format("=== Details : {0}", component.Details);
                result.AppendLine(componentDetails);
            }

            string componentPrice = String.Format("=== Price : ${0}", component.Price);
            result.AppendLine(componentPrice);
            result.AppendLine(separationLine);
        }

        string computerPrice = String.Format("=== Total Price : ${0}", CalculatePrice());
        result.AppendLine(computerPrice);
        result.AppendLine(separationLine);

        return result.ToString().Trim();
    }
}

