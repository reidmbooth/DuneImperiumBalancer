using System;
using System.Collections.Generic;
using System.Text;

namespace DuneImperiumEquationBalancer
{
    public class Space
    {

        private int[] costs { get; }
        private int[] gains { get; }
        private string name { get; }
        private bool IsBase { get; set; }
        private bool IsIx { get; set; }
        private bool IsIxImmo { get; set; }

        private bool IsUprising { get; set; }

        public Space()
        {
            IsBase = false;
            IsIx = false;
            IsIxImmo = false;
            IsUprising = false;
            costs = new int[Enum.GetNames(typeof(ID)).Length];
            gains = new int[Enum.GetNames(typeof(ID)).Length];
        }

        public Space(string _name)
        {
            IsBase = false;
            IsIx = false;
            IsIxImmo = false;
            IsUprising = false;
            name = _name;
            costs = new int[Enum.GetNames(typeof(ID)).Length];
            gains = new int[Enum.GetNames(typeof(ID)).Length];
        }

        public void SpaceDefault(ID space_type)
        {
            costs[(int)ID.GoingToSpace] = 1;
            costs[(int)space_type] = 1;
        }

        /*public void IntrigueDefault()
        {
            costs[(int)ID.DrawIntrigue] = 1;
        }*/

        public void SetCost(ID cost, int value)
        {
            costs[(int)cost] = value;
        }
        public void SetGain(ID cost, int value) {
            gains[(int)cost] = value;
        }

        public Space Cost(ID cost, int value)
        {
            costs[(int)cost] = value;
            return this;
        }

        public Space Gain(ID gain, int value)
        {
            gains[(int)gain] = value;
            return this;
        }

        public int GetCost(ID cost)
        {
            return costs[(int)cost];
        }

        public int GetGain(ID gain)
        {
            return gains[(int)gain];
        }

        public Space Default(ID space_type)
        {
            SetCost(ID.GoingToSpace, 1);
            SetCost(space_type, 1);
            return this;
        }

        public string Name()
        {
            return name;
        }
        public Space IntrigueDefault()
        {
            SetCost(ID.DrawIntrigue, 1);
            return this;
        }

        public Space SetIsBase()
        {
            IsBase = true;
            return this;
        }

        public Space SetIsIx()
        {
            IsIx = true;
            return this;
        }

        public Space SetIsIxImmo()
        {
            IsIxImmo = true;
            return this;
        }

        public Space SetIsUprising()
        {
            IsUprising = true;
            return this;
        }
        public Space SetIsInAllBaseNotUprising()
        {
            IsBase = true;
            IsIx = true;
            IsIxImmo = true;
            IsUprising = false;
            return this;

        }
        public Space SetIsInAll()
        {
            IsBase = true;
            IsIx = true;
            IsIxImmo = true;
            IsUprising = true;
            return this;
        }

        public int[] GetCosts()
        {
            return costs;
        }
        public int[] GetGains()
        {
            return gains;
        }
    }


    public enum ID
    {
        GoingToSpace = 0,
        SolariValue = 1,
        SpiceValue = 2,
        WaterValue = 3,
        Faction2req = 4,
        FactionSpace = 5,
        Oncegame = 6,
        GreenSpace = 7,
        BlueSpace = 8,
        YellowSpace = 9,
        DrawIntrigue = 10,
        FactionBump = 11,
        GainTroops = 12,
        Combat = 13,
        DrawCard = 14,
        StealIntrigue = 15,
        Trash = 16,
        HighCouncil = 17,
        Swordmaster = 18,
        SpiceAccumulation = 19,
        Shipping = 20,
        Foldspace = 21,
        Mentat = 22,
        TempInfluence = 23,
        TechDiscountNegotiator = 24,
        BuyTech = 25,
        GetDreadnought = 26,
        SolariFlag = 27,
        SpiceFlag = 28,
        Microscope = 29,
        DiscardDrawIntrigue = 30,
        Contract = 31,
        PickUpWorker = 32,
        Spy = 33,
        TwoSpiceOrDeploy = 34,
        FourSpiceOrDeployTwo = 35,
        GetMakerHook = 36,
        DestroyShieldWall = 37,
        WildBump = 38
    };

    

    /*public class ConversionItem
    {
        public double weight;
        public int id;
    }*/
}
