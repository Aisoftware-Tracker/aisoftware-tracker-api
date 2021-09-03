namespace Aisoftware.Tracker.Borders
{
    public class Base<T>
    {
        public Pagination Paging { get; set; }
        public T Results { get; set; }
    }

    public class Pagination
    {
        public int Total { get; set; }
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}