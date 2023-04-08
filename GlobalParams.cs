namespace Program
{
    internal class GlobalParams
    {
        public GlobalParams()
        {
        }

        public int TotalTime { get; internal set; }
        public int Radius { get; internal set; }
        public int AccelarationRangesNumber { get; internal set; }
        public int NumberOfGifts { get; internal set; }
        public Dictionary<int, int> Ranges { get; internal set; }
        public List<Gift> Gifts { get; internal set; }

        internal int GetMaxAccByWeight(int weight)
        {
            foreach (var item in Ranges.Keys.OrderBy(x=>x))
            {
                if(weight <= item)
                    return Ranges[item];

            }

            return 0;
        }
    }
}