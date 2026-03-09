// See https://aka.ms/new-console-template for more information
using DuneImperiumEquationBalancer;
using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

//Console.WriteLine("Hello, World!");

List<DuneImperiumEquationBalancer.Space> spaces = new List<DuneImperiumEquationBalancer.Space>();

/*
Space 'costs'

Worker Spent
Solari
Spice
Water
Faction 2-req
Faction Space
Once/game
Green Space
Blue Space
Yellow Space

Space 'Benefits'


1  Solari
2  Spice
3  Water
4  Faction bump
5  Draw Intrigue
6  Gain Troops
7  Combat Allowed
8  Draw Card
9  Draw Contract
10 Gain Spy
11 Steal intrigues
12 Trash
13 Permanent 2 influence
14 Permanent Worker
15 Spice Accumulation
16 Shipping
17 foldspace
18 mentat
19 temporary influence
20 discount/negotiator
21 buy tech
22 get dreadnought
23 solari flag
24 spice flag
25 microscope*/
/*26 double DiscardDrawIntrigue = 1.0;
  27  double Contract = 2.0;
  28  double PickUpWorker = 1.0;
  29  double Spy = 1.5;
  30  double TwoSpiceOrDeploy = 1.0;
  31  double FourSpiceOrDeployTwo = 1.0;
  32  double GetMakerHook = 1.0;
  33  double DestroyShieldWall = 1.0;
  34  double WildBump = 1.0;*/
/*double Goingtospace = 2.6;
    double SolariValue = 1;
    double SpiceValue = 1.7;
    double WaterValue = 1.2;
    double DrawCard = 1.8;
    double DrawIntrigue = 1.6;
    double Shipping = 1.8;
    double StealIntrigue = 0.6;
    double FactionBump = 2;
    double GainTroops = 1.8;
    double Combat = 1;
    double Trash = 2;
    double HighCouncil = 8;
    double Swordmaster = 11;
    double SpiceAccumulation = 1.1;
    double Mentat = 3.3;
    double Faction2req = 0.6;
    
    double Oncegame = 0.1;
    double Foldspace = 2.2;
    double tempinfluence = 1.1;
    double solariflag = -1;
    double spiceflag = 0.2;
    double microscope = 1.6;
    double FactionSpace = 1.6;
    double GreenSpace = 0.3;
    double BlueSpace = 0.8;
    double Yellowspace = 0.4;

    //Uprising-specific benefits
    double DiscardDrawIntrigue = 1.9;
    double Contract = 2.0;
    double PickUpWorker = 3.0;
    double Spy = 2.3;
    double TwoSpiceOrDeploy = 3.1;
    double FourSpiceOrDeployTwo = 5.5;
    double GetMakerHook = 0.0;
    double DestroyShieldWall = 1.8;
    double WildBump = 3.7;*/
//string[] CostNames = new string[] { "Goingtospace", "SolariValue", "SpiceValue", "WaterValue", "Faction2req", "FactionSpace", "Oncegame", "GreenSpace", "BlueSpace", "YellowSpace", "DrawIntrigue" };
//string[] GainNames = new string[] { "SolariValue", "SpiceValue", "WaterValue", "FactionBump", "DrawIntrigue", "GainTroops", "Combat", "DrawCard", "null", "null", "StealIntrigue", "Trash", "HighCouncil", "Swordmaster", "SpiceAccumulation", "Shipping", "Foldspace", "Mentat", "tempinfluence", "TechDiscountNegotiator", "BuyTech", "GetDreadnought", "solariflag", "spiceflag", "microscope", "DiscardDrawIntrigue", "Contract", "PickUpWorker", "Spy", "TwoSpiceOrDeploy", "FourSpiceOrDeployTwo", "GetMakerHook", "DestroyShieldWall", "WildBump" };
//string[] DescriptiveCostNames = new string[] { "Sending worker to a space", "Solari", "Spice", "Water", "Has Faction 2 influence requirement", "Is a faction space", "Can only go once/game", "Is a green space", "Is a blue space", "Is a yellow space", "Draw an Intrigue" };
//[] DescriptiveGainNames = new string[] { "Solari", "Spice", "Water", "Faction-specific Bump", "Draw an Intrigue", "Gain Troop", "Space allows combat", "Draw a Card", "null", "null", "Steal intrigues above 4", "Trash a card", "High Council", "Swordmaster", "Spice Accumulation", "Shipping", "Foldspace", "Mentat", "Temporary influence", "Buy Tech w/ Discount or Negotiator", "Buy Tech", "Get Dreadnought", "Has solari flag", "Has spice flag", "Microscope", "Discard and Draw an Intrigue", "Contract", "Pick Up Worker", "Spy", "Two Spice Or Deploy Worm", "Four Spice Or Deploy Two Worm", "Get Maker Hook", "Destroy Shield Wall", "Wild Faction Bump" };

//base game board spaces
//                                                                                                                                              X              X              X              X              X              X              X
//spaces.Add(new DuneImperiumEquationBalancer.Space() { Costs = new double[] { 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0 }, Gains = new double[] { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, Name = "Arrakeen" });
spaces.Add(new Space("Arrakeen")
    .SetIsInAll()
    .Default(ID.BlueSpace)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.GainTroops, 1)
    .Gain(ID.Combat, 1)
    .Gain(ID.SolariFlag, 1)
    );
spaces.Add(new Space("Carthag")
    .SetIsInAllBaseNotUprising()
    .Default(ID.BlueSpace)
    .Gain(ID.DrawIntrigue, 1)
    .Gain(ID.GainTroops, 1)
    .Gain(ID.Combat, 1)
    .Gain(ID.SolariFlag, 1)
    );
spaces.Add(new Space("Research Station 1")
    .SetIsBase()
    .SetIsIx()
    .Default(ID.BlueSpace)
    .Cost(ID.WaterValue, 2)
    .Gain(ID.DrawCard, 3)
    .Gain(ID.Combat, 1)
    );
spaces.Add(new Space("Research Station 2")
    .SetIsIxImmo()
    .Default(ID.BlueSpace)
    .Cost(ID.WaterValue, 2)
    .Gain(ID.DrawCard, 2)
    .Gain(ID.Microscope, 1)
    .Gain(ID.Combat, 1)
    );
spaces.Add(new Space("Sietch Tabr")
    .SetIsInAllBaseNotUprising()
    .Default(ID.BlueSpace)
    .Cost(ID.Faction2req, 1)
    .Gain(ID.WaterValue, 1)
    .Gain(ID.GainTroops, 1)
    .Gain(ID.Combat, 1)
    );
spaces.Add(new Space("Sell Melange 1")
    .SetIsBase()
    .Default(ID.YellowSpace)
    .Cost(ID.SpiceValue, 2)
    .Gain(ID.SolariValue, 6)
    );
spaces.Add(new Space("Sell Melange 2")
    .SetIsBase()
    .Default(ID.YellowSpace)
    .Cost(ID.SpiceValue, 3)
    .Gain(ID.SolariValue, 8)
    );
spaces.Add(new Space("Sell Melange 3")
    .SetIsBase()
    .Default(ID.YellowSpace)
    .Cost(ID.SpiceValue, 4)
    .Gain(ID.SolariValue, 10)
    );
spaces.Add(new Space("Sell Melange 4")
    .SetIsBase()
    .Default(ID.YellowSpace)
    .Cost(ID.SpiceValue, 5)
    .Gain(ID.SolariValue, 12)
    );
spaces.Add(new Space("Secure Contract")
    .SetIsBase()
    .Default(ID.YellowSpace)
    .Gain(ID.SolariValue, 3)
    );
spaces.Add(new Space("Interstellar Shipping")
    .SetIsIx()
    .SetIsIxImmo()
    .Default(ID.YellowSpace)
    .Cost(ID.Faction2req, 1)
    .Gain(ID.Shipping, 2)
    );
spaces.Add(new Space("Smuggling")
    .SetIsIx()
    .SetIsIxImmo()
    .Default(ID.YellowSpace)
    .Gain(ID.Shipping, 1)
    .Gain(ID.SolariValue, 1)
    );
spaces.Add(new Space("Imperial Basin")
    .SetIsInAll()
    .Default(ID.YellowSpace)
    .Gain(ID.SpiceValue, 1)
    .Gain(ID.Combat, 1)
    .Gain(ID.SpiceFlag, 1)
    .Gain(ID.SpiceAccumulation, 1)
    );
spaces.Add(new Space("Hagga Basin")
    .SetIsInAllBaseNotUprising()
    .Default(ID.YellowSpace)
    .Cost(ID.WaterValue, 1)
    .Gain(ID.SpiceValue, 2)
    .Gain(ID.Combat, 1)
    .Gain(ID.SpiceAccumulation, 1)
    );
spaces.Add(new Space("The Great Flat")
    .SetIsInAllBaseNotUprising()
    .Default(ID.YellowSpace)
    .Cost(ID.WaterValue, 2)
    .Gain(ID.SpiceValue, 3)
    .Gain(ID.Combat, 1)
    .Gain(ID.SpiceAccumulation, 1)
    );
spaces.Add(new Space("Conspire")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.SpiceValue, 4)
    .Gain(ID.SolariValue, 5)
    .Gain(ID.GainTroops, 2)
    .Gain(ID.DrawIntrigue, 1)
    .Gain(ID.FactionBump, 1)
    );
spaces.Add(new Space("Wealth")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Gain(ID.SolariValue, 2)
    .Gain(ID.FactionBump, 1)
    );
spaces.Add(new Space("Heighliner")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.SpiceValue, 6)
    .Gain(ID.WaterValue, 2)
    .Gain(ID.GainTroops, 5)
    .Gain(ID.Combat, 1)
    .Gain(ID.FactionBump, 1)
    );
spaces.Add(new Space("Foldspace")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Gain(ID.Foldspace, 1)
    .Gain(ID.FactionBump, 1)
    );
spaces.Add(new Space("Selective Breeding")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.SpiceValue, 2)
    .Gain(ID.Trash, 1)
    .Gain(ID.DrawCard, 2)
    .Gain(ID.FactionBump, 1)
    );
spaces.Add(new Space("Secrets")
    .SetIsInAll()
    .Default(ID.FactionSpace)
    .Gain(ID.DrawIntrigue, 1)
    .Gain(ID.FactionBump, 1)
    .Gain(ID.StealIntrigue, 1)
    );
spaces.Add(new Space("Hardy Warriors")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.WaterValue, 1)
    .Gain(ID.GainTroops, 2)
    .Gain(ID.Combat, 1)
    .Gain(ID.FactionBump, 1)
    );
spaces.Add(new Space("Stillsuits")
    .SetIsInAllBaseNotUprising()
    .Default(ID.FactionSpace)
    .Gain(ID.WaterValue, 1)
    .Gain(ID.Combat, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("High Council")
    .SetIsInAllBaseNotUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 5)
    .Cost(ID.Oncegame, 1)
    .Gain(ID.HighCouncil, 1)
     );
spaces.Add(new Space("Mentat")
    .SetIsInAllBaseNotUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 2)
    .Gain(ID.Mentat, 1)
    .Gain(ID.DrawCard, 1)
     );
spaces.Add(new Space("Swordmaster")
    .SetIsInAllBaseNotUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 8)
    .Cost(ID.Oncegame, 1)
    .Gain(ID.Swordmaster, 1)
     );
spaces.Add(new Space("Hall of Oratory")
    .SetIsBase()
    .Default(ID.GreenSpace)
    .Gain(ID.GainTroops, 1)
    .Gain(ID.TempInfluence, 1)
     );
spaces.Add(new Space("Rally Troops")
    .SetIsBase()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 4)
    .Gain(ID.GainTroops, 4)
     );
spaces.Add(new Space("Tech Negotiation")
    .SetIsIx()
    .SetIsIxImmo()
    .Default(ID.GreenSpace)
    .Gain(ID.TechDiscountNegotiator, 1)
    .Gain(ID.TempInfluence, 1)
     );
spaces.Add(new Space("Dreadnought")
    .SetIsIx()
    .SetIsIxImmo()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 3)
    .Gain(ID.GetDreadnought, 1)
    .Gain(ID.BuyTech, 1)
     );
spaces.Add(new Space("Spice Refinery 1")
    .SetIsUprising()
    .Default(ID.BlueSpace)
    .Gain(ID.SolariValue, 2)
    .Gain(ID.Combat, 1)
    .Gain(ID.SolariFlag, 1)
     );
spaces.Add(new Space("Spice Refinery 2")
    .SetIsUprising()
    .Default(ID.BlueSpace)
    .Cost(ID.SpiceValue, 1)
    .Gain(ID.SolariValue, 4)
    .Gain(ID.Combat, 1)
    .Gain(ID.SolariFlag, 1)
    );
spaces.Add(new Space("Uprising Research Station")
    .SetIsUprising()
    .Default(ID.BlueSpace)
    .Cost(ID.WaterValue, 2)
    .Gain(ID.DrawCard, 2)
    .Gain(ID.GainTroops, 2)
    .Gain(ID.Combat, 1)
     );
spaces.Add(new Space("Uprising Sietch Tabr 1")
    .SetIsUprising()
    .Default(ID.BlueSpace)
    .Cost(ID.Faction2req, 1)
    .Gain(ID.WaterValue, 1)
    .Gain(ID.GainTroops, 1)
    .Gain(ID.GetMakerHook, 1)
    .Gain(ID.Combat, 1)
    );
spaces.Add(new Space("Uprising Sietch Tabr 2")
    .SetIsUprising()
    .Default(ID.BlueSpace)
    .Cost(ID.Faction2req, 1)
    .Gain(ID.WaterValue, 1)
    .Gain(ID.DestroyShieldWall, 1)
    .Gain(ID.Combat, 1)
     );
spaces.Add(new Space("Uprising Hagga Basin")
    .SetIsUprising()
    .Default(ID.YellowSpace)
    .Cost(ID.WaterValue, 1)
    .Gain(ID.TwoSpiceOrDeploy, 1)
    .Gain(ID.SpiceAccumulation, 1)
    .Gain(ID.Combat, 1)
    );
spaces.Add(new Space("Deep Desert")
    .SetIsUprising()
    .Default(ID.YellowSpace)
    .Cost(ID.WaterValue, 3)
    .Gain(ID.FourSpiceOrDeployTwo, 1)
    .Gain(ID.SpiceAccumulation, 1)
    .Gain(ID.Combat, 1)
     );
spaces.Add(new Space("Uprising Shipping")
    .SetIsUprising()
    .Default(ID.YellowSpace)
    .Cost(ID.SpiceValue, 3)
    .Cost(ID.Faction2req, 1)
    .Gain(ID.SolariValue, 5)
    .Gain(ID.WildBump, 1)
     );
spaces.Add(new Space("Accept Contract")
    .SetIsUprising()
    .Default(ID.YellowSpace)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.Contract, 1)    
    );
spaces.Add(new Space("Sardaukar")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.SpiceValue, 4)
    .Gain(ID.GainTroops, 4)
    .Gain(ID.DrawIntrigue, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Dutiful Service")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Gain(ID.Contract, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Uprising Heighliner")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.SpiceValue, 5)
    .Gain(ID.GainTroops, 5)
    .Gain(ID.Combat, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Deliver Supplies")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.WaterValue, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Espionage")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.SpiceValue, 1)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.Spy, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Desert Tactics")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Cost(ID.WaterValue, 1)
    .Gain(ID.GainTroops, 1)
    .Gain(ID.Combat, 1)
    .Gain(ID.Trash, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Fremkit")
    .SetIsUprising()
    .Default(ID.FactionSpace)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.Combat, 1)
    .Gain(ID.FactionBump, 1)
     );

spaces.Add(new Space("Uprising High Council 1")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 5)
    .Cost(ID.Oncegame, 1)
    .Gain(ID.HighCouncil, 1)
     );
spaces.Add(new Space("Uprising High Council 2")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 5)
    .Gain(ID.SpiceValue, 2)
    .Gain(ID.DrawIntrigue, 1)
    .Gain(ID.GainTroops, 3)
     );
spaces.Add(new Space("Imperial Privilege")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 3)
    .Cost(ID.Faction2req, 1)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.DiscardDrawIntrigue, 1)
    .Gain(ID.PickUpWorker, 1)
     );
spaces.Add(new Space("Uprising Swordmaster")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 8)
    .Cost(ID.Oncegame, 1)
    .Gain(ID.Swordmaster, 1)
     );
spaces.Add(new Space("Assembly Hall")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Gain(ID.TempInfluence, 1)
    .Gain(ID.DrawIntrigue, 1)
     );
spaces.Add(new Space("Gather Support 1")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Gain(ID.GainTroops, 2)
     );
spaces.Add(new Space("Gather Support 2")
    .SetIsUprising()
    .Default(ID.GreenSpace)
    .Cost(ID.SolariValue, 2)
    .Gain(ID.WaterValue, 1)
    .Gain(ID.GainTroops, 2)
     );
spaces.Add(new Space("Windfall")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.SolariValue, 2)
     );
spaces.Add(new Space("Water of Life")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 1)
    .Cost(ID.WaterValue, 1)
    .Gain(ID.DrawCard, 3)
     );
spaces.Add(new Space("Water Peddlers Union")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.WaterValue, 1)
     );
spaces.Add(new Space("Calculated Hire")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 1)
    .Gain(ID.Mentat, 1)
     );
spaces.Add(new Space("Refocus")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.DrawCard, 1)
     );
spaces.Add(new Space("Breakthrough")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.Microscope, 1)
     );
spaces.Add(new Space("Cull")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 1)
    .Gain(ID.Trash, 1)
     );
spaces.Add(new Space("Expedite")
    .SetIsIx()
    .SetIsIxImmo()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 1)
    .Gain(ID.Shipping, 1)
     );
spaces.Add(new Space("Glimpse the Path")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 1)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.WaterValue, 1)
     );
spaces.Add (new Space("Recruitment Mission")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.TempInfluence, 1)
     );
spaces.Add(new Space("Charisma")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.TempInfluence, 2)
     );
spaces.Add(new Space("Favored Subject")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Know Their Ways")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Secret of the Sisterhood")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Guild Authorization")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Machine Culture")
    .SetIsIx()
    .SetIsIxImmo()
    .IntrigueDefault()
    .Cost(ID.BuyTech, 1)
     );
spaces.Add(new Space("Urgent Mission")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.PickUpWorker, 1)
     );
spaces.Add(new Space("Bribery")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 2)
    .Gain(ID.WildBump, 1)
     );


spaces.Add(new Space("Detonation 1")
    .SetIsUprising()
    .IntrigueDefault()
    .Gain(ID.DestroyShieldWall, 1)
    );
spaces.Add(new Space("Detonation 2")
    .SetIsUprising()
    .IntrigueDefault()
    .Gain(ID.DestroyShieldWall, 1)
    );
spaces.Add(new Space("Cunning 1")
    .SetIsUprising()
    .IntrigueDefault()
    .Gain(ID.DrawCard, 1)
    );
spaces.Add(new Space("Cunning 2")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 1)
    .Gain(ID.DrawCard, 1)
    .Gain(ID.Trash, 1)
     );
spaces.Add(new Space("Mercenaries")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 3)
    .Gain(ID.DrawIntrigue, 1)
    .Gain(ID.GainTroops, 2)
    );
spaces.Add(new Space("Contingency Plan")
    .SetIsUprising()
    .IntrigueDefault()
    .Gain(ID.SolariValue, 2)
     );
spaces.Add(new Space("Change Allegiances")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 3)
    .Gain(ID.WildBump, 1)
    );
spaces.Add(new Space("Market Opportunity 1")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SpiceValue, 2)
    .Gain(ID.SolariValue, 5)
     );
spaces.Add(new Space("Market Opportunity 2")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 5)
    .Gain(ID.SpiceValue, 5)
     );
spaces.Add(new Space("Buy Access")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 5)
    .Gain(ID.WildBump, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Imperium Politics 1")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 1)
    .Gain(ID.FactionBump, 1)
     );
spaces.Add(new Space("Imperium Politics 2")
    .SetIsUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 1)
    .Gain(ID.FactionBump, 1)
     );


RunBalancer();
//CalculateIntrigues();

/*void PrintSpaces()
{
    foreach (var space in spaces)
    {
        Console.Write($"Space: {space.Name},\nCosts\n");
        for(int i = 0; i < space.Costs.Length; i++)
        {
            if(space.Costs[i] != 0)
            {
                Console.Write(", " + CostNames[i] + ": " + space.Costs[i]);
            }
            
        }
        Console.Write("\nGains\n");
        for (int i = 0; i < space.Gains.Length; i++)
        {
            if (space.Gains[i] != 0)
            {
                Console.Write(", " + GainNames[i] + ": " + space.Gains[i]);
            }
            
        }
        Console.WriteLine();
    }
}*/




void RunBalancer()
{
    double[] weights = { 2.6, 1, 1.56, 1.46, 0.6, 1.6, 0.1, 0.3, 0.58, 0.7, 1.6, 2, 1.58, 0.74, 1.59, 0.6, 2.14, 8, 11, 0.9, 2, 2.2, 3.3, 1.29, 1.61, 1.6, 4.3, -0.73, 0.1, 1.6, 2.91, 2.1, 2, 2.17, 3.12, 6.04, 0, 1.6, 4.6 };

    double balance_factor = 0.01;

    for(int j = 0; j < 200; j++)
    {
        double base_balance = TotalBalance(weights);
        Console.WriteLine($"Base balance: {base_balance}");
        double biggest_difference = 0;
        bool gain = false;
        int index_to_change = -1;

        for (int i = 0; i < weights.Length; i++)
        {
            double[] _weights = new double[weights.Length];
            Array.Copy(weights, _weights, weights.Length);
            _weights[i] += balance_factor;
            if (TotalBalance(_weights) < base_balance)
            {
                if(base_balance - TotalBalance(_weights) > biggest_difference)
                {
                    biggest_difference = base_balance - TotalBalance(_weights);
                    gain = true;
                    index_to_change = i;
                }
                Console.WriteLine($"Increasing weight {(ID)i} improved balance by {Math.Round(base_balance - TotalBalance(_weights), 2)}");
            }
        }
        for (int i = 0; i < weights.Length; i++)
        {
            double[] _weights = new double[weights.Length];
            Array.Copy(weights, _weights, weights.Length);
            _weights[i] -= balance_factor;
            if (TotalBalance(_weights) < base_balance)
            {
                if (base_balance - TotalBalance(_weights) > biggest_difference)
                {
                    biggest_difference = base_balance - TotalBalance(_weights);
                    gain = false;
                    index_to_change = i;
                }
                Console.WriteLine($"Decreasing weight {(ID)i} improved balance by {Math.Round(base_balance - TotalBalance(_weights), 2)}");
            }
        }


        Console.WriteLine($"{index_to_change}");
        if (index_to_change != -1)
        {
            if (gain)
            {
                weights[index_to_change] += balance_factor;
            }
            else
            {
                weights[index_to_change] -= balance_factor;
            }
        }
    }
    
    SortedDictionary<string, double> space_balances = new SortedDictionary<string, double>();
    double[] balances = new double[spaces.Count];
    for (int i = 0; i < spaces.Count; i++)
    {
        Console.WriteLine($"Calculating balance for space {spaces[i].Name()}");
        balances[i] = SpaceBalance(spaces[i], weights);
        Console.WriteLine(Math.Round(balances[i],2));
        space_balances.Add(spaces[i].Name(), balances[i]);
    }
    Dictionary<string, double> space_balances_sorted = space_balances.OrderBy(x => x.Value).ToDictionary();
    foreach (var space in space_balances_sorted) {
        Console.WriteLine($"{space.Key}: {Math.Round(space.Value,2)}");
    }
    Console.Write("{");
    for (int i = 0; i < weights.Length; i++)
    {
        Console.Write($"{Math.Round(weights[i],3)}");
        if ((i +1 < weights.Length))
        {
            Console.Write(", ");
        }
    }
    Console.Write("};\n");
    for (int i = 0; i < weights.Length; i++)
    {
        Console.WriteLine($"{Math.Round(weights[i],3)}\t - {(ID)i}");
    }
    /*for (int i = 0; i < GainWeights.Length; i++)
    {
        Console.WriteLine($"{Math.Round(GainWeights[i], 3)}\t - {DescriptiveGainNames[i]}");
    }*/

    /*double balances_sum = 0;
    for (int i = 0; i < balances.Length; i++)
    {
        balances_sum += Math.Abs(balances[i]);
    }*/

}

double TotalBalance(double[] weights)
{
    double balance = 0;
    foreach (var space in spaces)
    {
        balance += Math.Abs(SpaceBalance(space, weights));
    }
    return balance;
}

double SpaceBalance(Space space, double[] weights)
{
    double balance = 0;
    for (int i = 0; i < weights.Length; i++)
    {
        balance -= space.GetGains()[i] * weights[i];
        balance += space.GetCosts()[i] * weights[i];
    }

    return balance;
}

