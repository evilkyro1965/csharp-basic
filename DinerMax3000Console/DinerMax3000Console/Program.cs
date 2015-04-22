﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon","Fresh Norwegian Salmon with Sandefjord butter.",25.50);
            summerMenu.AddMenuItem("Taco", "All Norwegians eat taco on Fridays.", 10);
            summerMenu.HospitalDirections = "Right around the corner";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Virgin Cuba LIbre", "A Classic", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Makes you hammered.", 15);

            Order hungryGuestOrder = new Order();

            for (int x = 0; x < summerMenu.items.Count; x++)
            {
                MenuItem currentItem = summerMenu.items[x];
                hungryGuestOrder.items.Add(currentItem);
            }

            foreach (MenuItem currentItem in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(currentItem);
            }
        }
    }
} 
