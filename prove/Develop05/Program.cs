using System;

class Program
{
    static void Main(string[] args)
    {
        var GoalMenu = true;
        var quit = false;
        var events = new Events();
        while (!quit) 
        {
            var input = Menu.GetInput();

            switch (input){

                case "1":
                    input = Menu.GetInput(GoalMenu);

                    switch(input){

                        case "1":
                            events.AddGoal(MenuGoals.SimpleGoal);
                        break;

                        case "2":
                            events.AddGoal(MenuGoals.EternalGoal);
                        break;

                        case "3":
                            events.AddGoal(MenuGoals.ChecklistGoal);
                        break;
                    }
                    break;

                case "2":
                    events.DisplayList();
                    break;

                case "3":
                    Console.Write($"Save as: ");
                    var file = Console.ReadLine();
                    events.Save(file);
                    break;

                case "4":
                    Console.Write($"What's the name of the file?: ");
                    file = Console.ReadLine();
                    events.Load(file);
                    break;

                case "5":
                    if(events.GetListNumber() > 1)
                    {
                        events.GetRecordEvent();
                    }
                    else{
                        Console.WriteLine("Please, remember to create a goal first.");
                    }
                    break;

                case "6":
                    quit = true;
                    break;
                default:
                    break;
            }
        }
    }
}