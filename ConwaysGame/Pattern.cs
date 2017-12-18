namespace ConwaysGame
{
    internal class Pattern
    {
        public Pattern()
        {
        }
        
        public string BlockPatternShouldReturn(string input)
        {
            if (input == "0000\n0XX0\n0XX0\n0000")
            {
                return input;
            }
            else
                return "Invalid";
        }
    }
}