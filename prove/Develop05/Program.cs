using System;

class Program
{
    static void Main(string[] args)
    {
        var GoalMenu = true;
        var quit = false;
        var progress = new Progress();
        while (!quit) 
        {
            var input = Menu.GetInput();

            switch (input){

                case "1":
                    input = Menu.GetInput(GoalMenu);

                    switch(input){

                        case "1":
                            progress.AddGoal(MenuGoals.SimpleGoal);
                        break;

                        case "2":
                            progress.AddGoal(MenuGoals.EternalGoal);
                        break;

                        case "3":
                            progress.AddGoal(MenuGoals.ChecklistGoal);
                        break;
                    }
                    break;

                case "2":
                    progress.DisplayList();
                    break;

                case "3":
                    Console.Write($"Save as: ");
                    var file = Console.ReadLine();
                    progress.Save(file);
                    break;

                case "4":
                    Console.Write($"What's the name of the file?: ");
                    file = Console.ReadLine();
                    progress.Load(file);
                    break;

                case "5":
                    if(progress.GetListNumber() > 1)
                    {
                        progress.GetRecordEvent();
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