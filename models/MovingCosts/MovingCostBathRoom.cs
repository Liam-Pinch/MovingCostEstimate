namespace MovingCostEstimate.models.MovingCosts
{
    public class MovingCostBathroom
    {
        public decimal LengthOfRoom { get; set; }
        public decimal WidthOfRoom { get; set; }
        public decimal HeightOfRoom { get; set; }
        public decimal PaintCost { get; set; }
        public int PaintCoverage { get; set; }
        public int NumberOfCoats { get; set; }
        public decimal FlooringCost { get; set; }
        public bool Underlay { get; set; }
        public decimal UnderlayCost { get; set; }
        public decimal Towels { get; set; }
        public decimal FloorMats { get; set; }
        public decimal ShowerCurtain { get; set; }
    }
}