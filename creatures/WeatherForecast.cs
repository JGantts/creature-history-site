using System;

namespace creatures
{
    public class Creature
    {
        public string Moniker { get; set; }
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string Parent1Moniker { get; set; }

        public string Parent2Moniker { get; set; }

        public string[] ChildrenMonikers { get; set; }
    }

    public class CreatureWithKin
    {
        public string Moniker { get; set; }
        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string Parent1Moniker { get; set; }
        public string Parent1Name { get; set; }

        public string Parent2Moniker { get; set; }
        public string Parent2Name { get; set; }

        public string[] ChildrenMonikers { get; set; }
        public string[] ChildrenNames { get; set; }
    }
}
