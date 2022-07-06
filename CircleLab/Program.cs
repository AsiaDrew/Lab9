using CircleLab;
//get user input
//create circle object
//display circumference and area
//Welcome to the Circle Tester
//Enter radius: 3
//Circumference: 18.85
//Area: 28.27
//Continue ? (y / n) : n
//Goodbye.You created 2 Circle object(s).
double createdCircles = 0;
string answer;
Console.WriteLine("Welcome to the Circle Tester");
Console.WriteLine();
createdCircles = PromptUser(createdCircles);

 CreateMoreCircles(ref createdCircles, out answer);


static double PromptUser(double createdCircles)
{
    try
    {
        Console.Write("Enter a radius: ");
        double userInput = double.Parse(Console.ReadLine());
        if (userInput <= 0)
        {
            Console.WriteLine("Sorry try again");
        }
        else if (userInput >0)
        {
            createdCircles++;
            //access circle class w/ newcircle
            Circle newCircle = new Circle(userInput);
            Console.WriteLine(newCircle.CalculateFormattedCircumference());
            Console.WriteLine(newCircle.CalculateFormattedArea());
        }
        else
        {
            Console.WriteLine("I dont understand?");
        }
    }
    catch (SystemException s)
    {
        Console.WriteLine(s.Message);
    }

    return createdCircles;
}

static object CreateMoreCircles(ref double createdCircles, out string answer)
{
    while (true)
    {
        Console.WriteLine();
        Console.WriteLine("would you like to enter another radius? y/n");
        answer = Console.ReadLine();
        try
        {
            if (answer.ToLower().Trim() == "y")
            {
                createdCircles++;
                PromptUser(createdCircles);
            }
                //continue;
            else if (answer.ToLower().Trim() == "n")
            {
                Console.WriteLine($"\nGoodbye. You created {createdCircles} Circle object(s).");
                break;
            }
            else
            {
                throw new Exception("Not a valid option, please try again.");
                
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
    return 0;
}





////methods
//bool goAgain = true;
//while (goAgain = true)
//{
//    Console.WriteLine();
//    try
//    {
//        {
//            // Console.WriteLine("Okay!");
//            Console.WriteLine();
//            continue;
//        }
//        else if (answer.ToLower().Trim() == "n")
//{
//    break;
//}
//else
//{
//    throw new Exception("Not a valid option, please try again.");
//}
//    }
//    catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//continue;
//}

