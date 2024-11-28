namespace RGU.DistributedSystems.Labs.WPF.Models;

public class DataMatrixModel
{
    public class DataMatrix 
    {
        public List<string> Columns { get; set; }
        public List<object[]> Rows { get; set; }
    }
}