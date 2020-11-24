/* I was able to complete this adventure game with the help of the class week 7/8 assignment with Introduction to Programming Class with Ashlyn comments and 
 * Michael finishing the code
 * Steven Blount
 * Intro to Programming 
   Darkness Awaits
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using static System.Console;

namespace Adventure_Game
    {
        class Program
        {
            static void Main(string[] args)
            {
                
                Title = "Darkness Awaits ";

                //This chunk of code instantiates all of our items in the game.  They have names and descriptions that will be passed in.
                Item AxMace = new Item("AxMace", "vigorous, sturdy ax mace that provides great strength for the Chosen ones.", 320);
                Item tinyDagger = new Item("A TiNy DaGger", "A very tiny knife I wouldn't reccomend it at all", 1050);
                Item Chestpiece = new Item("Chestpiece","used to counter Ophelia's mind-control as well as her void magic skulls. Where she will shoot a dark purple beam with thousands of skeletons which is very critcal", 500);
                Item Wolf = new Item("Cerberus", "I can bring my deadly wolf however, he might've bit me on my arm along time ago but hey no grudges", 450);
                Item Book = new Item("Book", "Its an Daily Adventures Of Steve, and its a special edition which is a bonus", 600);
                Item Crown = new Item("Crown", "Feels Great Protecting the Kingdom.  Gives you all the riches and a beautiful kingdom.", 10000000);
                Item Riches = new Item("Diamonds, Gold and Ophelia Head", " Love the joy of sweet sweet Victory! Winner Command", 10000001);

                //Creating NPCs
                NPC WeaponGod = new NPC()
                {
                    Name = "Kratos",
                    Inventory = new List<Item> { AxMace, tinyDagger }
                };

                NPC ArmorGod  = new NPC()
                {
                    Name = "Hercules",
                    Inventory = new List<Item> { Chestpiece }
                };
                NPC Goddess = new NPC()
                {
                    Name = "Ophelia",
                    Inventory = new List<Item> { Crown }
                };

                //This is the same for the locations.  They have names, descriptions, items to pick up, required items for access, and colors.
                Location Cabin = new Location("Cabin", "A greek GOD named Kratos would love to give u thou choices of weapons to use on journey ", new List<Item> { }, new List<Item> { }, ConsoleColor.Cyan, WeaponGod);
                Location Cottage = new Location("Cottage", "Another Greek God named Hercules that trades you for a chance of great armor that you will need", new List<Item> { }, new List<Item> {  }, ConsoleColor.DarkGreen, ArmorGod);
                Location House = new Location("Your Sweett Home", "This is where you sleep and watch some good ol Tv", new List<Item> { Book, Wolf }, ConsoleColor.Gray);

                //This is another way to create object without a method!
                Location BattleField = new Location()
                {
                    Name = "BattleField",
                    Description = "In the deep forest cloudy outside of the nation in a big battle field.",
                    Items = new List<Item> { },
                    RequiredItems = new List<Item> { AxMace, Chestpiece },
                    LocationColor = ConsoleColor.DarkRed,
                    Guardian = Goddess
                };
                Location Kingdom = new Location()
                {
                    Name = "Thou Kingdom",
                    Description = "Sitting on a luxury throne full of diamonds with Ophelia's head on the table watching the kingdom.",
                    Items = new List<Item> { Riches },
                    RequiredItems = new List<Item> { Crown },
                    LocationColor = ConsoleColor.Cyan
                };



                //This is the list of locations in the game.
                List<Location> Locations = new List<Location>() { House, Cabin, Cottage, BattleField, Kingdom };

                //The instantiation of an instance of the player class.  our current player.
                Player Player1 = new Player();

                //Our world has to be instantiated too, along with the important start up properties, such as the name of the world, the player, the location, etcetera.
                World world = new World("Darkness World", Player1, House, Locations, Riches, tinyDagger);
                //This takes us to the menu, and off we go!
                world.Menu();
            }
        }
    }
