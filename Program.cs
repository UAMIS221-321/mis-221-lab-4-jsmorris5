
// GetPartial();
// GetFull();

// bool inLoop = true;

// while (Inloop)
// int ran = newRandom().Next(3,9)
// {
// string UserOption = Menu();
//     if (UserOption == "1")

// {

// for (int i = ran; i > 0; -ii)
// {
//     for(int j = i; j > 0; j--)
// {
//     System.Console.Write("rnd.Next2");
// }
    
//     }
//     System.Console.Write("\t");
// }
// }


// else if (UserOption= "2")
// static void GetFull(){
//     for(int i = 1; i<5; i++){
//       System.Console.Write("\n" + i + "\t");
//     for(int j=0; j<10; j++)
//     }

// }

// else if (UserOption = "3")

string choice;
DisplayMenu();
choice = System.Console.ReadLine();

while (choice != "4")
{
    switch (choice)
    {
        case "1":
            GetFull();
            break;
        case "2":
            GetPartial();
            break;
        case "3":
            ExitMenu();
            break;
        default:
        {
            System.Console.WriteLine("Invalid entry. Please reenter choice:");
            Console.Clear();
            DisplayMenu();
            break;
        }
    }

System.Console.WriteLine("Press any key to continue...");
System.Console.ReadKey();
        Console.Clear();
        DisplayMenu();
        choice = System.Console.ReadLine();

}


static void DisplayMenu()
{
    System.Console.WriteLine("1. Display full triangle");
    System.Console.WriteLine("2. Display partial triangle");
    System.Console.WriteLine("3. Exit menu");
    System.Console.WriteLine();

    System.Console.WriteLine("Enter Choice:");
}
//end main????

static void GetFull()
{
int ran = new Random().Next(3,10);
    for(int i = 0; i<ran; i++)
    {
        for(int j=0; i>j; j++)
        {
            System.Console.Write("*");
        }
            System.Console.WriteLine();
        
        // System.Console.Write("\n" + i + "\t");
        // for(int j=0; j<10; j++);
    }
}


//var rNum = random.Next();
static void GetPartial()
{
    int ran = new Random().Next(3,10);
    Random rand = new Random();
    for (int i = 0; i<ran; i++)
    {
        for(int j=0; i>j; j++)
        {
            if (rand.Next(2) == 1)
            { 
                System.Console.Write("*");   
            }
            else
            {   
                System.Console.Write(" "); 
            }
        }
        System.Console.WriteLine();
    }
}

static  void ExitMenu(){
    System.Console.WriteLine("Goodbye");
Environment.Exit(0);
}


