namespace BadRulesProject;
public class Class1 {

    public void Method() {
        var myActions = new List<Action>();
        var myStrings = new List<string>() { "one", "two", "three" };
        var x = new int();
        if (1 + 3 == 4) x = 5;
        else x = 4;
        if (1 + 3 == 4) x = 6;
                else x = 2;
        for (var i = 0; i < myStrings.Count; i++)
        {
            Action print = () => { Console.WriteLine(myStrings[i]); };
            myActions.Add(print);

        }

        myActions[0]();
    }
}