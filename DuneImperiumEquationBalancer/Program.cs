// See https://aka.ms/new-console-template for more information
using DuneImperiumEquationBalancer;
using System.Reflection.Emit;

List<DuneImperiumEquationBalancer.Space> spaces = new List<DuneImperiumEquationBalancer.Space>();
List<DuneImperiumEquationBalancer.Space> spaces_2 = new List<DuneImperiumEquationBalancer.Space>();

Construct(spaces_2);

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

//Uprising spaces
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

//Intrigues
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
    .Gain(ID.BuyTech, 1)
     );
spaces.Add(new Space("Urgent Mission")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Gain(ID.PickUpWorker, 1)
     );
spaces.Add(new Space("Bribery")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 2)
    .Gain(ID.WildBump, 1)
     );
spaces.Add(new Space("Advanced Weaponry")
    .SetIsInAllBaseNotUprising()
    .IntrigueDefault()
    .Cost(ID.SolariValue, 3)
    .Gain(ID.GetDreadnought, 1)
     );

//Uprising intrigues
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


RunBalancer(0.1, 2);
//RunExpectedBalance();

// scarcity factors used to scale the effective value of resources by how often
// they appear on non-intrigue spaces. Less-common resources get a larger factor.
double[] ScarcityFactors = null;

void ComputeScarcityFactors()
{
    if (spaces.Count == 0) {
        ScarcityFactors = new double[0];
        return;
    }

    int n = spaces[0].GetGains().Length;
    double[] averages = new double[n];

    for (int i = 0; i < n; i++)
    {
        double total = 0;
        int spaces_checked = 0;
        foreach (var space in spaces_2)
        {
            // exclude intrigues from commonality calculation using the same
            // heuristic already present in the project (cost of DrawIntrigue == 0)
            if (space.GetCost(ID.DrawIntrigue) == 0)
            {
                spaces_checked++;
                total += space.GetGains()[i];
                total += space.GetCosts()[i];
            }
        }
        averages[i] = spaces_checked > 0 ? total / spaces_checked : 0;
    }
    for (int i = 0; i < n; i++) Console.WriteLine($"Average {(ID)i}: {averages[i]}");
    // convert average availability into a scarcity multiplier. Add small eps
    // so that resources that never appear don't blow up.
    //double eps = 1e-6;
    double[] scarcity = new double[n];
    /*double sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (averages[i] > 0) {
            scarcity[i] = (1.0 / (averages[i]));
        }
        else {
            scarcity[i] = 1.0;
        }

        sum += scarcity[i];
    }*/
    // normalize so the mean scarcity factor is 1.0 (keeps overall scale similar)
    /*double mean = n > 0 ? sum / n : 1.0;
    if (mean <= 0) mean = 1.0;*/
    for (int i = 0; i < n; i++) scarcity[i] = averages[i];
    for (int i = 0; i < n; i++) scarcity[i] /= averages[(int)ID.SolariValue];
    for (int i = 0; i < n; i++) scarcity[i] = 1-((1 - scarcity[i])/3);
    //Console.WriteLine($"Scarcity mean {mean}");
    for (int i = 0; i < n; i++) Console.WriteLine($"Scarcity {(ID)i}: {scarcity[i]}");

    ScarcityFactors = scarcity;
}

void RunExpectedBalance(){
    // compute scarcity factors once before evaluating balances
    ComputeScarcityFactors();
    //double[] weights_base = { 2.5, 1, 1.6, 1.8, 1, 1.5, 0.0, 0.5, 1.0, 0.5, 1.5, 2, 1.5, 1, 1.5, 1, 2, 8, 11, 1, 2, 2, 3, 2, 1.5, 1.5, 4.5, -0.5, -0.5, 2, 1, 2, 2.5, 2, 3.25, 6.5, 1, 1.5, 4.5 };
    double[] weights_base = { 2.5, 1, 1.8, 2.0, 1.25, 1.5, 0.1, 0.5, 1.0, 0.5, 1.5, 2, 1.5, 1, 1.5, 1, 2, 8, 11, 1, 2, 2, 3, 2, 1.5, 1.5, 4.5, -0.5, -0.5, 2, 1, 2, 2.5, 2, 4, 8, 1, 1.5, 4.5 };

    SortedDictionary<string, double> space_balances = new SortedDictionary<string, double>();
    double[] balances = new double[spaces.Count];
    for (int i = 0; i < spaces.Count; i++)
    {
        //Console.WriteLine($"Calculating balance for space {spaces[i].Name()}");
        balances[i] = SpaceBalance(spaces[i], weights_base);
        //Console.WriteLine(Math.Round(balances[i],2));
        space_balances.Add(spaces[i].Name(), balances[i]);
    }
    Dictionary<string, double> space_balances_sorted = space_balances.OrderBy(x => x.Value).ToDictionary();

    Console.WriteLine("\nSpaces/intrigues ranked for balance:");
    foreach (var space in space_balances_sorted)
    {
        Console.WriteLine($"{space.Key}: {Math.Round(space.Value, 2)}");
    }

    Console.WriteLine($"Total balance: {Math.Round(TotalBalance(weights_base), 2)}");

    for (int i = 0; i < weights_base.Length; i++)
    {
        Console.WriteLine($"{Math.Round(weights_base[i], 3)}\t - {(ID)i}");
    }
    //double[] weights_base = new double[4];
}



void RunBalancer(double balance_factor, int tweak)
{
    //double[] weights_base = { 2.6, 1, 1.57, 1.52, 0.7, 1.6, 0.1, 0.3, 0.52, 0.7, 1.6, 2, 1.57, 0.73, 1.6, 0.6, 2.14, 8, 11, 0.95, 2, 2.2, 3.3, 1.29, 1.61, 1.6, 4.3, -0.73, 0.05, 1.6, 3, 2.1, 2, 2.17, 3.14, 6.18, 0, 1.6, 4.59 };
    double[] weights_base = { 2.6, 1, 1.57, 1.52, 1.3, 1.6, 0.1, 0.3, 1.1, 0.7, 1.6, 2, 1.57, 0.73, 1.6, 0.6, 2.14, 8, 11, 0.95, 2.3, 2.2, 3.3, 1.3, 1.6, 1.51, 4.41, -0.73, 0.05, 1.6, 4.85, 2.1, 0.75, 2.17, 3.14, 6.18, 0, 1.6, 4.59 };

    double[] minimums = { -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, 1, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0, -5.0 };
    double[] maximums = { 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0, 25.0 };

    if(minimums.Length != weights_base.Length)
    {
        Console.WriteLine($"Error: minimums array length does not match weights array length. {minimums.Length - weights_base.Length}");
        return;
    }
    if (maximums.Length != weights_base.Length)
    {
        Console.WriteLine($"Error: minimums array length does not match weights array length. {minimums.Length - weights_base.Length}");
        return;
    }
    //double[] weights_base = { 2.6, 1, 1.57, 1.52, 1.3, 1.6, 0.1, 0.3, -0.08, 0.7, 1.6, 2, 1.57, 0.73, 1.6, 0.6, 2.14, 8, 11, 0.95, 2.3, 2.2, 3.3, 1.29, 1.61, 1.5, 4.4, -0.73, 0.05, 1.6, 7.2, 2.1, -1.6, 2.17, 3.14, 6.18, 0, 1.6, 4.59};
    //double[] commonality_weights = { 0, 0.3977, 0.2727, 0.1591, 0, 0, 0, 0, 0, 0, 0, 0, 0.6023, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // currently unused, figure out scarcity

    /*Console.Write("{");
    for (int i = 0; i < commonality_weights.Length; i++)
    {
        commonality_weights[i] = CalculateAverageOfSpacesThatProvide((ID)i);
        Console.Write($"{Math.Round(CalculateAverageOfSpacesThatProvide((ID)i),3)}");
        if ((i + 1 < commonality_weights.Length))
        {
            Console.Write(", ");
        }
    }
    Console.Write("};\n");*/


    //double balance_factor = 0.01;

    // compute scarcity factors so the optimizer values scarce resources more
    ComputeScarcityFactors();

    double[] weights = new double[weights_base.Length];
    

    double[] best_weights = new double[weights.Length];
    double best_balance = TotalBalance(weights_base);

    int[] mindices = new int[weights.Length];
    for (int i = 0; i < weights.Length; i++)
    {
        mindices[i] = i;
    }
    Random.Shared.Shuffle(mindices);

    foreach(int m in mindices)
    {
        for(int n = -1*tweak; n < 2*tweak; n += 2*tweak)
        {
            Console.Write($"{m}:{n} ");
            Array.Copy(weights_base, weights, weights_base.Length);
            weights[m] += n;
            if (weights[m] < minimums[m])
            {
                Console.WriteLine($"Tried to write {(ID)m} below minimum");
                weights[m] = minimums[m];
            }
            if (weights[m] > maximums[m])
            {
                weights[m] = maximums[m];
            }
            /*if (weights[m] < 0 && (ID)m==ID.BlueSpace)
            {
                weights[m] = 0;
            }*/

            int index_to_change = -2;

            while (index_to_change != -1)
            {
                double base_balance = TotalBalance(weights);
                //Console.WriteLine($"Base balance: {base_balance}");
                double biggest_difference = 0;
                bool gain = false;
                index_to_change = -1;

                int[] indices = new int[weights.Length];
                for(int i = 0; i < weights.Length; i++)
                {
                    indices[i] = i;
                }
                Random.Shared.Shuffle(indices);

                //for (int i = 0; i < weights.Length; i++)
                foreach(int i in indices)
                {
                    if (weights[i] < maximums[i])
                    {
                        double[] _weights = new double[weights.Length];
                        Array.Copy(weights, _weights, weights.Length);
                        _weights[i] += balance_factor;

                        double tb = TotalBalance(_weights);
                        if (tb < base_balance)
                        {
                            if (base_balance - tb > biggest_difference && i != (int)ID.SolariValue)
                            {
                                biggest_difference = base_balance - tb;
                                gain = true;
                                index_to_change = i;
                            }
                            //Console.WriteLine($"Increasing weight {(ID)i} improved balance by {Math.Round(base_balance - TotalBalance(_weights), 2)}");
                        }
                    }
                    
                }
                
                foreach (int i in indices)
                {
                    if (weights[i] > minimums[i])
                    {
                        double[] _weights = new double[weights.Length];
                        Array.Copy(weights, _weights, weights.Length);
                        _weights[i] -= balance_factor;
                        /*if (_weights[i] < 0)
                        {
                            _weights[i] = 0;
                        }*/
                        double tb = TotalBalance(_weights);
                        if (tb < base_balance)
                        {
                            if (base_balance - tb > biggest_difference && i != 1)
                            {
                                biggest_difference = base_balance - tb;
                                gain = false;
                                index_to_change = i;
                            }
                            //Console.WriteLine($"Decreasing weight {(ID)i} improved balance by {Math.Round(base_balance - TotalBalance(_weights), 2)}");
                        }
                    }
                    else
                    {
                        //Console.WriteLine($"Tried to write {(ID)i} below minimum");
                    }
                }


                //Console.WriteLine($"{index_to_change}");
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
                else
                {
                    if(base_balance < best_balance)
                    {
                        best_balance = base_balance;
                        Array.Copy(weights, best_weights, weights.Length);
                        Console.WriteLine($"New best balance: {Math.Round(best_balance,2)}");
                    }
                    else
                    {
                        Console.WriteLine($"No improvement found, exiting early. Current balance: {Math.Round(base_balance,2)}, best balance: {Math.Round(best_balance,2)}");
                    }
                    //Console.WriteLine("No improvement found, exiting early");
                    break;

                }
            }
        }
    }


    
    
    SortedDictionary<string, double> space_balances = new SortedDictionary<string, double>();
    double[] balances = new double[spaces.Count];
    for (int i = 0; i < spaces.Count; i++)
    {
        //Console.WriteLine($"Calculating balance for space {spaces[i].Name()}");
        balances[i] = SpaceBalance(spaces[i], best_weights);
        //Console.WriteLine(Math.Round(balances[i],2));
        space_balances.Add(spaces[i].Name(), balances[i]);
    }
    Dictionary<string, double> space_balances_sorted = space_balances.OrderBy(x => x.Value).ToDictionary();

    Console.WriteLine("\nSpaces/intrigues ranked for balance:");
    foreach (var space in space_balances_sorted) {
        Console.WriteLine($"{space.Key}: {Math.Round(space.Value,2)}");
    }

    //outputs weights in a format that can be copy-pasted into the code
    Console.WriteLine("\nFinal weights in array format:");
    Console.Write("{");
    for (int i = 0; i < best_weights.Length; i++)
    {
        Console.Write($"{Math.Round(best_weights[i],3)}");
        if ((i +1 < best_weights.Length))
        {
            Console.Write(", ");
        }
    }
    Console.Write("};\n");
    Console.WriteLine("\nFinal weights:");
    for (int i = 0; i < best_weights.Length; i++)
    {
        Console.WriteLine($"{Math.Round(best_weights[i],3)}\t - {(ID)i}");
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
        double scarcity = 1.0;
        if (ScarcityFactors != null && i < ScarcityFactors.Length)
        {
            scarcity = ScarcityFactors[i];
        }
        if((ID)i == ID.SolariValue || (ID)i == ID.SpiceValue || (ID)i == ID.WaterValue)
        {
            balance += space.GetGains()[i] * weights[i] * scarcity;// (scarcity<1?scarcity:1);
            balance -= space.GetCosts()[i] * weights[i] * scarcity;// (scarcity < 1 ? scarcity : 1);
        }
        else
        {
            balance += space.GetGains()[i] * weights[i];
            balance -= space.GetCosts()[i] * weights[i];
        }
    
    }

    return balance;
}

double CalculateAverageOfSpacesThatProvide(ID i)
{
    double total = 0;
    int spaces_checked = 0;
    foreach (var space in spaces) { 
        if(space.GetCost(ID.DrawIntrigue) == 0) // not an intrigue
        {
            spaces_checked++;
            total += space.GetGains()[(int)i];
        }
    }
    return total/spaces_checked;
}

void Construct(List<DuneImperiumEquationBalancer.Space> spaces)
{
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
        .Cost(ID.SpiceValue, 4)
        .Gain(ID.SolariValue, 10)
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

    //Uprising spaces
    /*spaces.Add(new Space("Spice Refinery 1")
        .SetIsUprising()
        .Default(ID.BlueSpace)
        .Gain(ID.SolariValue, 2)
        .Gain(ID.Combat, 1)
        .Gain(ID.SolariFlag, 1)
         );*/
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
    /*spaces.Add(new Space("Uprising Sietch Tabr 2")
        .SetIsUprising()
        .Default(ID.BlueSpace)
        .Cost(ID.Faction2req, 1)
        .Gain(ID.WaterValue, 1)
        .Gain(ID.DestroyShieldWall, 1)
        .Gain(ID.Combat, 1)
         );*/
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
    /*spaces.Add(new Space("Gather Support 1")
        .SetIsUprising()
        .Default(ID.GreenSpace)
        .Gain(ID.GainTroops, 2)
         );*/
    spaces.Add(new Space("Gather Support 2")
        .SetIsUprising()
        .Default(ID.GreenSpace)
        .Cost(ID.SolariValue, 2)
        .Gain(ID.WaterValue, 1)
        .Gain(ID.GainTroops, 2)
         );

    //Intrigues
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
    spaces.Add(new Space("Recruitment Mission")
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
        .Gain(ID.BuyTech, 1)
         );
    spaces.Add(new Space("Urgent Mission")
        .SetIsInAllBaseNotUprising()
        .IntrigueDefault()
        .Gain(ID.PickUpWorker, 1)
         );
    spaces.Add(new Space("Bribery")
        .SetIsInAllBaseNotUprising()
        .IntrigueDefault()
        .Cost(ID.SolariValue, 2)
        .Gain(ID.WildBump, 1)
         );
    spaces.Add(new Space("Advanced Weaponry")
        .SetIsInAllBaseNotUprising()
        .IntrigueDefault()
        .Cost(ID.SolariValue, 3)
        .Gain(ID.GetDreadnought, 1)
         );

    //Uprising intrigues
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
}
