namespace Program;


public static class Program
{


    public static void Main(string[] args)
    {
        var globalParams = new GlobalParams();
        globalParams.TotalTime = 1;
        globalParams.Radius = 1;
        globalParams.AccelarationRanges = 1;
        globalParams.NumberOfGifts = 1;


        globalParams.Ranges = new Dictionary<int, int>();


        globalParams.Gifts = new List<Gift>{
            new Gift {
                Name = "",
                Score = 1,
                Weight = 1,
                Coord = new Point(1,2)
            }
        };


        globalParams.GetMaxAccByWeight(13);

    }


}