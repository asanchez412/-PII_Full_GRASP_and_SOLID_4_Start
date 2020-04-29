//-------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class Program
    {
        private static List<Product> productCatalog = new List<Product>();

        private static List<Equipment> equipmentCatalog = new List<Equipment>();

        public static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            recipe.AddStep("Café", 2, 100, "Cafetera", 10, 1000);
            recipe.AddStep("Leche", 6, 20, "Microondas", 50, 200);

            Product finalProduct = new Product("Café con leche", 20);
            recipe.FinalProduct = finalProduct;

            IPrinter consolePrinter = new ConsolePrinter();
            IPrinter filePrinter = new FilePrinter();

            filePrinter.PrintRecipe(recipe);
            consolePrinter.PrintRecipe(recipe);
        }
    }
}
