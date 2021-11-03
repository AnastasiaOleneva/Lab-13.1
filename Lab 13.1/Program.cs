using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MultiBuilding multiBuilding = new MultiBuilding("г.Москва, бульвар Яна Райниса д. 19", 13.2, 4, 15, 17);
            multiBuilding.PrintBuildingInformation();
            Console.ReadKey();
        }
    }


    class Building
    {
        public string BuildingAdress { get; set; }
        public double BuildingLength { get; set; }
        public double BuildingWidth { get; set; }
        public double BuildingHeight { get; set; }

        public Building()
        {
        }
        public Building(string buildingAdress, double buildingLength, double buildingWidth, double buildingHeight)
        {
            BuildingAdress = buildingAdress;
            BuildingLength = buildingLength;
            BuildingWidth = buildingWidth;
            BuildingHeight = buildingHeight;

        }

        public void PrintBuildingInformation()
        {
            Console.WriteLine("Здание по адресу : {0} \nИмеет длину : {1} м ,ширину : {2} м, высоту : {3} м ", BuildingAdress, BuildingLength, BuildingWidth, BuildingHeight);


        }
    }


    class MultiBuilding : Building
    {
        public int BuildingFloor { get; set; }
        public MultiBuilding(string buildingAdress, double buildingLength, double buildingWidth, double buildingHeight, int buildingFloor)
        {
            BuildingAdress = buildingAdress;
            BuildingLength = buildingLength;
            BuildingWidth = buildingWidth;
            BuildingHeight = buildingHeight;
            BuildingFloor = buildingFloor;



        }
        new public void PrintBuildingInformation()
        {
            Console.WriteLine("Здание по адресу : {0} \nИмеет длину : {1} м ,ширину : {2} м, высоту : {3} м, количество этажей :{4} ", BuildingAdress, BuildingLength, BuildingWidth, BuildingHeight, BuildingFloor);


        }
    }
}
