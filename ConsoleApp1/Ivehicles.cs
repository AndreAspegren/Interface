namespace Interface
{
    interface Ivehicles
    {
        public string brand { get; set; }
        public int registration { get; set; }
        public string color { get; set; }
        void Run();
    }
}