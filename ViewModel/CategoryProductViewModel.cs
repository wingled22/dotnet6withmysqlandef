namespace sampleMVC.ViewModel
{
    public class CategoryProductViewModel
    {
        public int Id { get; set; }
        public int Category { get; set; }
        public string CategoryName { get; set; }
        public string Name { get; set; } 
        public string Units { get; set; }
        public int Stocks { get; set; }
        public string? Status { get; set; } 
    }
}