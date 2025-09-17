namespace MovingCostEstimate.models.MovingCosts
{
    public class MovingCostLivingRoom
    {
        public decimal LengthOfRoom { get; set; }
        public decimal WidthOfRoom { get; set; }
        public decimal HeightOfRoom { get; set; }
        public decimal FlooringCost { get; set; }
        public bool Underlay { get; set; }
        public decimal UnderlayCost { get; set; }
        public decimal PaintOrPaper { get; set; }
        public decimal Sofa { get; set; }
        public decimal Tv { get; set; }
        public decimal TvStand { get; set; }
        public decimal Storage { get; set; }
        public decimal LivingRoomLamps { get; set; }
        public decimal TablesAndChairs { get; set; }
    }
}