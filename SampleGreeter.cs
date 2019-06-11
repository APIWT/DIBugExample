namespace DIBugExample
{
    public class SampleGreeter : IGreeter
    {
        public string GetGreeting(string name)
        {
            return $"Hello, {name}!";
        }
    }
}
