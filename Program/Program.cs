using System;
using System.Collections.Generic;

namespace Program
{
    internal class Program
    {
        public static void Main()
        {
            HashSet<TSquare> squareSet = new HashSet<TSquare>();
            
            TSquare square1 = new TSquare(5);
            squareSet.Add(square1);

            TSquare square2 = new TSquare(5);
            
            bool foundSquare = squareSet.Contains(square2);
            Console.WriteLine($"Знайдено квадрат TSquare: {foundSquare}");

        
            HashSet<TSquareF> squareFSet = new HashSet<TSquareF>();
            
            TSquareF squareF1 = new TSquareF(5);
            squareFSet.Add(squareF1);

            TSquareF squareF2 = new TSquareF(5);
            
            bool foundSquareF = squareFSet.Contains(squareF2);
            Console.WriteLine($"Знайдено квадрат TSquareF: {foundSquareF}");

            HashSet<TCube> cubeSet = new HashSet<TCube>();
            
            for (int i = 1; i <= 5; i++)
            {
                string color = $"Color{i}";
                
                TCube cube = new TCube(5, color);
                cubeSet.Add(cube);
            }
            
            Console.WriteLine($"Кiлькiсть елементiв у TCube: {cubeSet.Count}");
            
            HashSet<TCubeF> cubeFSet = new HashSet<TCubeF>();
            
            for (int i = 1; i <= 5; i++)
            {
                string color = $"Color{i}";
                
                TCubeF cubeF = new TCubeF(5, color);
                cubeFSet.Add(cubeF);
            }
            
            Console.WriteLine($"Кiлькiсть елементiв у TCubeF: {cubeFSet.Count}");
        }
    }
}