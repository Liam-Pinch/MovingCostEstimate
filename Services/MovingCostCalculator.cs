using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using MovingCostEstimate.models;

namespace MovingCostEstimate.Services
{
    public class MovingCost
    {
        public decimal CalculateVan(MovingCostVan Van)
        {
            decimal total = (Van.VanFuel * Van.VanHireDays) + (Van.ProfessionalMovers * Van.VanHireDays) + Van.VanFuel;
            return total;
        }

        public decimal CalculateKitchen(MovingCostKitchen Kitchen)
        {
            decimal total = Kitchen.Cooker + Kitchen.Dishwasher + Kitchen.Freezer + Kitchen.Fridge +
            Kitchen.Kettle + Kitchen.Microwave + Kitchen.Toaster + Kitchen.TumbleDryer + Kitchen.WashingMachine;

            return total;
        }

        public decimal CalculateLivingRoom(MovingCostLivingRoom LivingRoom)
        {
            decimal total = LivingRoom.LivingRoomLamps + LivingRoom.Sofa + LivingRoom.Storage + LivingRoom.TablesAndChairs
            + LivingRoom.Tv + LivingRoom.TvStand;

            return total;
        }

        public decimal CalculateBedroom(MovingCostBedroom Bedroom)
        {
            decimal total = Bedroom.Bed + Bedroom.Bedding + Bedroom.BedroomLamps + Bedroom.ChestOfDraws + Bedroom.Mattress +
            Bedroom.Wardrobe;

            return total;
        }

        public decimal CalculateEssentials(MovingCostEssentials Essentials)
        {
            decimal total = Essentials.CleaningSupplies + Essentials.CouncilTax + Essentials.Electric +
            Essentials.Gas + Essentials.Groceries + Essentials.InternetInstall + Essentials.Water;

            return total;
        }

        public decimal CalculateDecorating(MovingCostDecorating Decorating)
        {
            decimal total = Decorating.BoxesAndEquiptment + Decorating.Curtains + Decorating.FlooringAndEquipment +
            Decorating.LightFittings + Decorating.PaintAndEquipment + Decorating.WallpaperingAndEquipment;

            return total;
        }

        public MovingCostResponse TotalCost(MovingCostVan van, MovingCostKitchen kitchen,
        MovingCostLivingRoom livingRoom, MovingCostBedroom bedroom,
        MovingCostEssentials essentials, MovingCostDecorating decorating)
        {
            var response = new MovingCostResponse
            {
                Van = CalculateVan(van),
                Kitchen = CalculateKitchen(kitchen),
                Livingroom = CalculateLivingRoom(livingRoom),
                Bedroom = CalculateBedroom(bedroom),
                Essentials = CalculateEssentials(essentials),
                Decorating = CalculateDecorating(decorating)
            };
            response.Total = response.Van + response.Kitchen + response.Livingroom +
            response.Bedroom + response.Essentials + response.Decorating;
            
            return response;
        }
    }
}