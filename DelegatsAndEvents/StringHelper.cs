namespace DelegatsAndEvents
{
    public delegate int CountDelegate(string message);
    internal class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }
        public int GetCountSymbol(string inputString)
        {
            return inputString.Count(c => c=='a');
        }
    }
}
