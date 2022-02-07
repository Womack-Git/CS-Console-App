using System;

class MainClass {
  public static void Main (string[] args) {
    
    while(true){
      Console.WriteLine("\n\nWhich option would you like to select?\n1.) You enter your name then the computer greets you!\n2.) You enter dimensions of a rectangle and the computer tells you the area.\n3.) The computer asks you for a distance you have driven and the amount of gas you have consumed and the computer tells you your miles per gallon.\n4.) Enter a word or words and the computer will check if they are in a citation from 'Alice in Wonderland'\n");
      string answer = Console.ReadLine();
      switch(answer){
        case "1": Console.Write("Hello, " + Menu.nameOption() + "! I hope you are having a good day!");
        break;
        case "2": Console.Write("The area of your rectangle is " + Menu.rectangleOption());
        break;
        case "3": Console.Write("The MPG of your trip: " + Menu.mpgOption() + " miles per gallon");
        break;
        default: Console.WriteLine("\nSubmission not processed.");
        break;
      }
    }

  }
}

class Menu {

  public static string nameOption(){
    Console.Write("Enter your name: ");
    string Name = Console.ReadLine();
    return Name;
  }

  public static double rectangleOption(){
    Console.Write("Enter the width of the rectangle: ");
    double Width = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the length of the rectangle: ");
    double Length = Convert.ToDouble(Console.ReadLine());
    double Area = Width*Length;
    return Area;
  }

  public static double mpgOption(){
    Console.Write("Enter the distance you traveled on your trip (only the number please): ");
    double Distance = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter the amount of gas you burned (in gallons): ");
    double Gallons = Convert.ToDouble(Console.ReadLine());
    double MilesPerGallon = Distance/Gallons;
    return MilesPerGallon;
  }

  public static double aliceOption(){
    
  }
}