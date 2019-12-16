using System;

namespace creatures
{
    public enum LifeStage: int
    {
        Unborn = 0,
        Baby = 1,
        Child = 2,
        Adolescent = 3,
        Youth = 4,
        Adult = 5,
        Old = 6,
        Ancient = 7,
    }

    public enum Gender: int
    {
        Unborn = -1,
        Male = 1,
        Female = 2
    }

    public enum Genus: int
    {
        Norn = 1,
        Grendel = 2,
        Ettin = 3,
        Geat = 4
    }

    public enum HistEventType: int
    {
        Conceived = 0,
        Spliced = 1,
        Engineered = 2,
        Cloned = 14,
        
        Born = 3,
        Aged = 4,
        Exported = 5 ,
        Imported = 6,
        Died = 7,
        BecamePregnant = 8,
        Impregnated = 9,
        ChildBorn = 10,
        CloneSource = 15,
        WarpedOut = 16,
        WarpedIn = 17,
        
        LaidByMother = 11,
        LaidAnEgg = 12,
        Photographed = 13,
}

    public class HistEvent
    {
        public string Moniker { get; set; }
        public HistEventType HistEventType { get; set; }
        public LifeStage LifeStage { get; set; }
        public string photo { get; set; }
        public string Moniker1 { get; set; }
        public string Moniker2 { get; set; }
        public int TimeUTC { get; set; }
        public int TickAge { get; set; }
        public string UserText { get; set; }
        public string WorldName { get; set; }
        public int WorldTick { get; set; }
        public string WorldId { get; set; }
    }

    public class Creature
    {
        public string Moniker { get; set; }
        public string Name { get; set; }
        public int CrossoverPointMutations { get; set; }
        public int PointMutations { get; set; }
        public Gender Gender { get; set; }
        public Genus Genus { get; set; }

        public DateTime Birthdate { get; set; }

        public string Parent1Moniker { get; set; }

        public string Parent2Moniker { get; set; }

        public string[] ChildrenMonikers { get; set; }
    }

    public class CreatureWithKin
    {
        public string Moniker { get; set; }
        public string Name { get; set; }
        public int CrossoverPointMutations { get; set; }
        public int PointMutations { get; set; }
        public Gender Gender { get; set; }
        public Genus Genus { get; set; }

        public DateTime Birthdate { get; set; }

        public string Parent1Moniker { get; set; }
        public string Parent1Name { get; set; }

        public string Parent2Moniker { get; set; }
        public string Parent2Name { get; set; }

        public string[] ChildrenMonikers { get; set; }
        public string[] ChildrenNames { get; set; }
    }
}
