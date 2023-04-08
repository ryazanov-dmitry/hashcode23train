namespace Program
{
    internal class Parser
    {


        public static GlobalParams Parse(string[] args)
        {
            var filename = args[0];

            var lines = File.ReadAllLines(filename);

            var header = lines[0].Split(' ');

            var globalParams = new GlobalParams
            {
                TotalTime = int.Parse(header[0]),
                Radius = int.Parse(header[1]),
                AccelarationRangesNumber = int.Parse(header[2]),
                NumberOfGifts = int.Parse(header[3])
            };

            globalParams.Ranges =
            lines.Skip(1).Take(globalParams.AccelarationRangesNumber).Select(x => x.Split(' ')).ToDictionary(x => int.Parse(x[0]), x => int.Parse(x[1]));

            globalParams.Gifts =
                    lines.Skip(1 + globalParams.AccelarationRangesNumber).Select(x => x.Split(' ')).Select(x => new Gift
                    {
                        Name = x[0],
                        Score = int.Parse(x[1]),
                        Weight = int.Parse(x[2]),
                        Coord = new Point(int.Parse(x[3]), int.Parse(x[4]))
                    }).ToList();

            return globalParams;
        }
    }
}