public static class Menu{
    private const string _menuTitle = "\nMenu Options:\n";

    private const string _menuChoice = "\nSelect a choice from the menu: ";

    private const string _goalMenuTitle = "\nThe types of goals are:\n";

    private const string _goalMenuChoice = "\nWhich type of goal would you like to create:?";

    

    private static readonly Dictionary<int, string> _menuOptions = new Dictionary<int, string>(){
        {   1, "Create New Goal" },
        {   2, "List Goals"},
        {   3, "Save Goals"},
        {   4, "Load Goals"},
        {   5, "Record Event"},
        {   6, "Quit"}
    };

    private static readonly Dictionary<int, string> _goalMenuOptions = new Dictionary<int, string>(){
        {   1, "Simple Goal" },
        {   2, "Eternal Goal"},
        {   3, "Checklist Goal"}
    };

    

     public static string GetInput(bool GoalMenu = false){
        string title;
        string choice;
        Dictionary<int, string> options;

        if(GoalMenu){
            title = _goalMenuTitle;
            choice = _goalMenuChoice;
            options = _goalMenuOptions;
        }
        else
        {
            title = _menuTitle;
            choice = _menuChoice;
            options = _menuOptions;
        }

        Console.WriteLine($"{title}");
        for (int i = 1; i <= options.Count(); i++){
            Console.WriteLine($"{i}. {options[i]}");
        }
        Console.WriteLine($"{choice}");
        return Console.ReadLine();
    }

}