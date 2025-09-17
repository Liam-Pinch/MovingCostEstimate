namespace MovingCostEstimate.models.MovingCosts
{
    public class MovingCostBedroom
    {
        public decimal LengthOfRoom { get; set; }
        public decimal WidthOfRoom { get; set; }
        public decimal HeightOfRoom { get; set; }
        public decimal FlooringCost { get; set; }
        public bool Underlay { get; set; }
        public decimal UnderlayCost { get; set; }
        public decimal PaintCost { get; set; }
        public int PaintCoverage { get; set; }
        public int NumberOfCoats { get; set; }
        public decimal Bed { get; set; }
        public decimal Mattress { get; set; }
        public decimal Bedding { get; set; }
        public decimal Wardrobe { get; set; }
        public decimal ChestOfDraws { get; set; }
        public decimal BedroomLamps { get; set; }
        public decimal Curtains { get; set; }
    }
}