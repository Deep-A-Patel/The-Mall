using System;

namespace TheMall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of a dollar store
            DollarStore Dollarama = new DollarStore();

            // Instance of a dollar item
            DollarItem MultiColorPen = new DollarItem()
            {
                Name = "Muli Colored Pen with 12 colors"
            };

            Dollarama.AddToInventory("mcp", MultiColorPen);



            FoodStore Cinnabon = new FoodStore();

            FoodItem Classicroll = new FoodItem()
            {
                Name = "The Classic Roll",
                Price = 3.50,
                Calories = 880
            };
            FoodItem CaramelPecanBun = new FoodItem()
            {
                Name = "Caramel Pecan Bon",
                Price = 6,
                Calories = 1080
            };

            Cinnabon.AddToInventory("tcr", Classicroll);
            Cinnabon.AddToInventory("cpb", CaramelPecanBun);

            // Prints (the Name of) a dollar item
            System.Console.WriteLine(Dollarama.GetFromInventory("mcp").Name);
            // Prints (the Name of) a food item
            System.Console.WriteLine(Cinnabon.GetFromInventory("tcr").Name);
            System.Console.WriteLine(Cinnabon.GetFromInventory("cpb").Name);

        }
    }
}