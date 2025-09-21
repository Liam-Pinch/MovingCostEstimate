Home Move Cost Calculator (Notes)

This is a personal project I started because I need to move house in the coming months and I wanted a calculator to make sure all costs are covered.
It expanded into a full-stack application idea so others can use the tool to avoid surprises and understand the total cost of furnishing a property.

The application allows users to input their own figures while browsing and will provide a total.

------------------------------------------------------------
Tech Notes
- Backend: C# with .NET (mostly complete, more items can be added later).
- Frontend: React (SPA, still in design phase).
------------------------------------------------------------

What It Covers
- Buying a house -> Breakdown of monthly repayments, interest being paid, and total interest paid.
- Renting a property -> Deposit + first month’s rent.
- Furnishing a house -> Costs for common essentials (white goods, entertainment, furniture, etc.).

------------------------------------------------------------
Backend Testing
Clone the repository and run:
dotnet run

Recommended testing with Postman:
- Endpoint: http://localhost:5008/api/movingcost/total <- modify the port number as required.
- Method: POST
- Body: JSON (example below)
------------------------------------------------------------

JSON Structure

{
  "van": {
    "VanHire": 0,
    "VanHireDays": 0,
    "VanFuel": 0,
    "ProfessionalMovers": 0
  },
  "kitchen": {
    "LengthOfRoom": 0,
    "WidthOfRoom": 0,
    "HeightOfRoom": 0,
    "PaintCost": 0,
    "PaintCoverage": 0,
    "NumberOfCoats": 0,
    "FlooringCost": 0,
    "Underlay": true, // Boolean
    "UnderlayCost": 0,
    "Fridge": 0,
    "Freezer": 0,
    "WashingMachine": 0,
    "Dishwasher": 0,
    "TumbleDryer": 0,
    "Cooker": 0,
    "Kettle": 0,
    "Microwave": 0,
    "Toaster": 0,
    "Dishes": 0,
    "Cutlery": 0
  },
  "livingroom": {
    "LengthOfRoom": 0,
    "WidthOfRoom": 0,
    "HeightOfRoom": 0,
    "FlooringCost": 0,
    "Underlay": false, // Boolean
    "UnderlayCost": 0,
    "PaintCost": 0,
    "PaintCoverage": 0,
    "NumberOfCoats": 0,
    "Sofa": 0,
    "Tv": 0,
    "TvStand": 0,
    "Storage": 0,
    "LivingRoomLamps": 0,
    "TablesAndChairs": 0
  },
  "bedroom": [
    {
      "LengthOfRoom": 0,
      "WidthOfRoom": 0,
      "HeightOfRoom": 0,
      "FlooringCost": 0,
      "Underlay": true, // Boolean
      "UnderlayCost": 0,
      "PaintCost": 0,
      "PaintCoverage": 0,
      "NumberOfCoats": 0,
      "Bed": 0,
      "Mattress": 0,
      "Bedding": 0,
      "Wardrobe": 0,
      "ChestOfDraws": 0,
      "BedroomLamps": 0,
      "Curtains": 0
    }
  ],
  "bathroom": {
    "LengthOfRoom": 0,
    "WidthOfRoom": 0,
    "HeightOfRoom": 0,
    "PaintCost": 0,
    "PaintCoverage": 0,
    "NumberOfCoats": 0,
    "FlooringCost": 0,
    "Underlay": false, // Boolean
    "UnderlayCost": 0,
    "Towels": 0,
    "FloorMats": 0,
    "ShowerCurtain": 0
  },
  "essentials": {
    "Groceries": 0,
    "CleaningSupplies": 0,
    "InternetInstall": 0,
    "Gas": 0,
    "Electric": 0,
    "Water": 0,
    "CouncilTax": 0
  },
  "decorating": {
    "BoxesAndEquipment": 0,
    "PaintEquipment": 0,
    "WallpaperingEquipment": 0,
    "FlooringEquipment": 0,
    "LightFittings": 0
  }
}

------------------------------------------------------------
Notes
- Include your own figures for each item.
- You can add multiple bedrooms by appending objects to the bedroom array.
- Underlay is a Boolean (true/false).
- FlooringCost is price per m².
- Paint cost = (room area ÷ coverage per litre) × number of coats.
------------------------------------------------------------

TODO
- Finish frontend design.
- Implement React forms (room-by-room).
- Build JSON aggregator to send data to backend.
- Add more items for non-essentials (luxuries, extras).


