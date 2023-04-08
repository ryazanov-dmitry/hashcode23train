using System.Text;

namespace hashcode23train
{
    public static class ResultWriter
    {
        public static void WriteResult(List<PathAction> actions, string inputName)
        {
            var output = new StringBuilder();
            output.AppendLine($"{actions.Count}");
            foreach(var a in actions)
            {
                string desc = "";
                switch (a.ActionType)
                {
                    case Action.AccDown:
                    case Action.AccUp:
                    case Action.AccRight:
                    case Action.AccLeft:
                    case Action.Float:
                    case Action.LoadCarrots:
                        desc = $"{a.ActionType} {a.Amount}";
                        break;
                    case Action.LoadGift:
                    case Action.DeliverGift:
                        desc = $"{a.ActionType} {a.ChildName}";
                        break;
                }

                output.AppendLine(desc);
            }

            // File.WriteAllText(GetFilePath(GetDirectory("Output"), Path.ChangeExtension(fileName, "out.txt")), output.ToString());
            File.WriteAllText($"out_{inputName.Split("/").Last()}", output.ToString());
        }
    }
}