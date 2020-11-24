using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Adventure_Game
{
    public class NPC
    {
        public string Name { get; set; }

        public List<Item> Inventory = new List<Item>();


        public void TalkAndShowInventory()
        {
            WriteLine($"I have these very special items that you can trade that can potientally help u in your journey. You can call me {Name}.");
            int index = 1;
            foreach (var Item in Inventory)
            {
                WriteLine($"{index++}: {Item.Name} \n{Item.Description} - {Item.ItemWorth:c}");
            }
        }
    }
}
