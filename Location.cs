﻿
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Adventure_Game
{
    public class Location
    {
     
        public string Name
        {
            get; set;
        }

        public string Description
        {
            get; set;
        }

        public List<Item> Items
        {
            get; set;
        }

        public ConsoleColor LocationColor
        {
            get; set;
        }
         
        public List<Item> RequiredItems = new List<Item>();
        private string v;
        private List<Item> lists1;
        private List<Item> lists2;
        private ConsoleColor magenta;
        private NPC armorGod;

        public NPC Guardian { get; set; }

        //constructor :)
        public Location() { }
        public Location(string name, string description, List<Item> items, List<Item> requiredItems, ConsoleColor color, NPC guardian)
        {
            Name = name;
            Description = description;
            Items = items;
            RequiredItems = requiredItems;
            LocationColor = color;
            Guardian = guardian;
        }
        public Location(string name, string description, List<Item> items, ConsoleColor color)
        {
            Name = name;
            Description = description;
            Items = items;
            LocationColor = color;
        }

        public Location(string v, List<Item> lists1, List<Item> lists2, ConsoleColor magenta, NPC armorGod)
        {
            this.v = v;
            this.lists1 = lists1;
            this.lists2 = lists2;
            this.magenta = magenta;
            this.armorGod = armorGod;
        }

        //this prints the location and description to the console!
        public void PrintLocationInfo()
        {
            WriteLine($"You are at {Name}.  {Description}");
        }
    }
}
