
using System;
using System.Collections.Generic;
using UrbanPropertyAssetManager;

class Program
{

    static void Main()
    {
        List<PropertyAsset> assets = new List<PropertyAsset>();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("       URBAN PROPERTY ASSET MANAGER");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Residential Lot");
            Console.WriteLine("2. Add Circular Storage Depot");
            Console.WriteLine("3. Add Triangular Park");
            Console.WriteLine("4. View List of Property Assets");
            Console.WriteLine("5. Exit");
            Console.WriteLine("========================================");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n--- Add Residential Lot ---");

                    Console.Write("Property Code: ");
                    string lotCode = Console.ReadLine();

                    double lotTax = ReadDouble("Tax Rate: ");
                    double frontage = ReadDouble("Frontage: ");
                    double depth = ReadDouble("Depth: ");

                    assets.Add(new ResidentialLot(
                        lotCode, lotTax, frontage, depth));

                    Console.WriteLine("Residential Lot added successfully!");
                    break;

                case "2":
                    Console.WriteLine("\n--- Add Circular Storage Depot ---");

                    Console.Write("Property Code: ");
                    string depotCode = Console.ReadLine();

                    double depotTax = ReadDouble("Tax Rate: ");
                    double radius = ReadDouble("Radius: ");

                    assets.Add(new CircularStorageDepot(
                        depotCode, depotTax, radius));

                    Console.WriteLine("Circular Storage Depot added successfully!");
                    break;

                case "3":
                    Console.WriteLine("\n--- Add Triangular Park ---");

                    Console.Write("Property Code: ");
                    string parkCode = Console.ReadLine();

                    double parkTax = ReadDouble("Tax Rate: ");
                    double baseSpan = ReadDouble("Base Span: ");
                    double height = ReadDouble("Height: ");
                    double side1 = ReadDouble("Side 1: ");
                    double side2 = ReadDouble("Side 2: ");
                    double side3 = ReadDouble("Side 3: ");

                    assets.Add(new TriangularPark(
                        parkCode, parkTax, baseSpan, height,
                        side1, side2, side3));

                    Console.WriteLine("Triangular Park added successfully!");
                    break;

                case "4":
                    Console.WriteLine("\n--- Property Asset List ---");

                    if (assets.Count == 0)
                    {
                        Console.WriteLine("No property assets have been added yet.");
                    }
                    else
                    {
                        double totalTax = 0;

                        Console.WriteLine(
    $"{"Property Code",-15} {"Type",-25} {"Area",12} {"Perimeter",12} {"Tax",12}");

                        Console.WriteLine(
                            "------------------------------------------------------------");

                        foreach (PropertyAsset asset in assets)
                        {
                            double area = asset.ComputeFootprintArea();
                            double perimeter = asset.ComputeEnclosurePerimeter();
                            double tax = asset.ComputeEstimatedTax();

                            string type = asset.GetType().Name;

                            Console.WriteLine(
                                $"{asset.PropertyCode,-15} " +
                                $"{type,-25} " +
                                $"{area,12:F2} " +
                                $"{perimeter,12:F2} " +
                                $"{tax,12:F2}");

                            totalTax += tax;
                        }

                        Console.WriteLine(
                            "------------------------------------------------------------");

                        Console.WriteLine($"{"TOTAL TAX:",-40}{totalTax,11:F2}");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("TANKYUUUU BABABBYEEEEE");
                    break;

                default:
                    Console.WriteLine("Please bro select only from 1-5");
                    break;
            }
        }
    }

    static double ReadDouble(string prompt)
    {
        double value;

        while (true)
        {
            Console.Write(prompt);

            if (double.TryParse(Console.ReadLine(), out value))
            {
                return value;
            }

            Console.WriteLine("Invalid number. Please try again.");
        }
    }
}
