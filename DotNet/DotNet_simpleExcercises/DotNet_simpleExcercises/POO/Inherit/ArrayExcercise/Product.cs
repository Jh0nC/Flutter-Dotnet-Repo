namespace DotNet_SimpleExcercises
{
    public class Products
    {
        public int stock;
        public bool state;
        public String? description;
    }

    public class Panzerroti : Products
    {
        public String type = "Panzerroti";
        public String? flavor;

        public Panzerroti(String flavor, int stock, bool state, String description)
        {
            this.flavor = flavor;
            this.stock = stock;
            this.state = state;
            this.description = description;
        }

        public override String ToString()
        {
            String stateStr;
            if (this.state == true)
            {
                stateStr = "Active";
            }
            else
            {
                stateStr = "Inactive";
            }
            return "Type: " + this.type + "\n"
                + "Flavor: " + this.flavor + "\n"
                + "Stock: " + this.stock + "\n"
                + "State: " + stateStr + "\n"
                + "Descripción: " + this.description;
        }
    }

    public class Palito : Products
    {
        public String type = "Palito";
        public String? flavor;

        public Palito(String flavor, int stock, bool state, String description)
        {
            this.flavor = flavor;
            this.stock = stock;
            this.state = state;
            this.description = description;
        }

        public override String ToString()
        {
            String stateStr;
            if (this.state == true)
            {
                stateStr = "Active";
            }
            else
            {
                stateStr = "Inactive";
            }
            return "Type: " + this.type + "\n"
                + "Flavor: " + this.flavor + "\n"
                + "Stock: " + this.stock + "\n"
                + "State: " + stateStr + "\n"
                + "Descripción: " + this.description;
        }
    }
}