
namespace Chess
{
    class Move
    {
        public Move(int[] start, int[] end)
        {
            this.Start = start;
            this.End = end;
        }

        public int[] Start { get; private set; }
        public int[] End { get; private set; }
    }
}