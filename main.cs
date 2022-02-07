using System;

class MainClass {
  public static void Main (string[] args) {
    string answer = "0";
    while(answer != "5"){
      Console.WriteLine("\n\nWhich option would you like to select?\n1.) You enter yourname then the computer greets you!\n2.) You enter dimensions of a rectangle and thecomputer tells you the area.\n3.) The computer asks you for a distance you havedriven and the amount of gas you have consumed and the computer tells you your milesper gallon.\n4.) Enter a word or words and the computer will check if they are in acitation from 'Alice in Wonderland'\n5.) Quit");
      answer = Console.ReadLine();
      switch(answer){
        case "1": Console.Write("Hello, " + Menu.nameOption() + "! I hope you are having a good day!");
        break;
        case "2": Console.Write("The area of your rectangle is " + Menu.rectangleOption());
        break;
        case "3": Console.Write("The MPG of your trip: " + Menu.mpgOption() + " miles per gallon");
        break;
        case "4": Console.Write(Menu.aliceOption());
        break;
        case "5":
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

  public static string aliceOption(){
    string story = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";
    Console.Write("What word(s) would you like to look for? ");
    string wordGuess = Console.ReadLine();
    if(story.Contains(wordGuess)){
      return("Yup, your answer is in the string :)");
    }
    else{
      return("Sorry, looks like your answer was is not in the string. Feel free to try again though.");
    }
  }
}