using System;
using System.Collections.Generic;
using UrbanPropertyAssetManager;

namespace UrbanPropertAssetManager
{

    class Program
    {
        static void Main()
        {
            List<PropertyAsset> assets = new List<PropertyAsset>()
        {
            new ResidentialLot("Lot 1", 10.0, 20.0, 30.0),

            new CircularStorageDepot("Depot 1", 15.0, 5.0),

            new TriangularPark("Park 1", 8.0, 10.0, 6.0, 6.0, 8.0, 10.0)
        };

            double totalTax = 0;

            Console.WriteLine("\t==============================================");
            Console.WriteLine("\t=             TAKE-HOME LAB 04               =");
            Console.WriteLine("\t=  Asset Valuation & Hierarchy Modeling      =");
            Console.WriteLine("\t==============================================\n\n");
            Console.WriteLine("\tpd***URBAN PROPERTY ASSET MANAGER***bq\n");
            Console.WriteLine($"{"Property Code",-15} {"Area",12} {"Perimeter",12} {"Tax",12}");
            Console.WriteLine("------------------------------------------------------------");

            foreach (PropertyAsset asset in assets)
            {
                double area = asset.ComputeFootprintArea();
                double perimeter = asset.ComputeEnclosurePerimeter();
                double tax = asset.ComputeEstimatedTax();

                Console.WriteLine(
                    $"{asset.PropertyCode,-15} " +
                    $"{area,12:F2} " +
                    $"{perimeter,12:F2} " +
                    $"{tax,12:F2}");

                totalTax += tax;
            }

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"{"TOTAL TAX:",-40}{totalTax,11:F2}");
            Console.WriteLine("==============================================");
        }
    }

}