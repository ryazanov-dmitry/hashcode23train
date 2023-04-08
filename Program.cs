namespace hashcode23train;


public static class Program
{


    public static void Main(string[] args)
    {
        var globalParams = Parser.Parse(args);

        var actions = new List<PathAction>();

        actions.Add(new PathAction
        {
            ActionType = Action.LoadCarrots,
            Amount = 10
        });

        actions.Add(new PathAction
        {
            ActionType = Action.LoadGift,
            ChildName = "Olivia"
        });

        actions.Add(new PathAction
        {
            ActionType = Action.LoadGift,
            ChildName = "Liam"
        });

        actions.Add(new PathAction
        {
            ActionType = Action.AccRight,
            Amount = 4
        });
        actions.Add(new PathAction
        {
            ActionType = Action.Float,
            Amount = 1
        });
        actions.Add(new PathAction
        {
            ActionType = Action.DeliverGift,
            ChildName = "Olivia"
        });
        actions.Add(new PathAction
        {
            ActionType = Action.AccUp,
            Amount = 4
        });
        actions.Add(new PathAction
        {
            ActionType = Action.Float,
            Amount = 1
        });
        actions.Add(new PathAction
        {
            ActionType = Action.DeliverGift,
            ChildName = "Liam"
        });

        ResultWriter.WriteResult(actions, args[0]);

    }

}