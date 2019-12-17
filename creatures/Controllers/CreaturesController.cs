using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace creatures.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CreaturesController : ControllerBase
    {


        private static readonly HistEvent[] Events =
        {
            new HistEvent
            {
                Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                HistEventType = HistEventType.Born,
                LifeStage = LifeStage.Child,
                photo = "",
                Moniker1 = "norn.chichi06.ex47.gen",
                Moniker2 = "norn.chichi06.ex47.gen",
                TimeUTC = 0,
                TickAge = 0,
                UserText = "",
                WorldName = "Norn Paradise",
                WorldTick = 12,
                WorldId = "norn-parad-xvjbp-xyhye-ign3a-drjyp"
            },
            new HistEvent
            {
                Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                HistEventType = HistEventType.ChildBorn,
                LifeStage = LifeStage.Adult,
                photo = "",
                Moniker1 = "norn.chichi06.ex47.gen",
                Moniker2 = "norn.chichi06.ex47.gen",
                TimeUTC = 1,
                TickAge = 0,
                UserText = "",
                WorldName = "Norn Paradise",
                WorldTick = 12,
                WorldId = "norn-parad-xvjbp-xyhye-ign3a-drjyp"
            },
            new HistEvent
            {
                Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                HistEventType = HistEventType.Died,
                LifeStage = LifeStage.Old,
                photo = "",
                Moniker1 = "norn.chichi06.ex47.gen",
                Moniker2 = "norn.chichi06.ex47.gen",
                TimeUTC = 2,
                TickAge = 0,
                UserText = "",
                WorldName = "Norn Paradise",
                WorldTick = 12,
                WorldId = "norn-parad-xvjbp-xyhye-ign3a-drjyp"
            },
        };

        private static readonly Creature[] Creatures =
        {
            new Creature
            {
                Moniker = "003-magic-xvjbp-xyhye-ign3a-drjyp",
                Name = "Jace",
                BirthEventType = BirthEventType.Conceived,
                Birthdate = DateTime.Now,
                Parent1Moniker = "001-wizard-xvjbp-xyhye-ign3a-drjyp",
                Parent2Moniker = "002-norn-xvjbp-xyhye-ign3a-drjyp",
                ChildrenMonikers = new string[] { },
            },
            new Creature
            {
                Moniker = "003-flower-xvjbp-xyhye-ign3a-drjyp",
                Name = "Laynacae",
                BirthEventType = BirthEventType.Conceived,
                Birthdate = DateTime.Now,
                Parent1Moniker = "002-lion-xvjbp-xyhye-ign3a-drjyp",
                Parent2Moniker = "001-cat-xvjbp-xyhye-ign3a-drjyp",
                ChildrenMonikers = new string[] { },
            },

            new Creature
            {
                Moniker = "001-wizard-xvjbp-xyhye-ign3a-drjyp",
                Name = "Amber",
                BirthEventType = BirthEventType.Engineered,
                Birthdate = DateTime.Now,
                Parent1Moniker = "",
                Parent2Moniker = "norn.chichi06.ex47.gen",
                ChildrenMonikers = new string[] {
                    "003-magic-xvjbp-xyhye-ign3a-drjyp",
                },
            },
            new Creature
            {
                Moniker = "001-cat-xvjbp-xyhye-ign3a-drjyp",
                Name = "Allen",
                BirthEventType = BirthEventType.Engineered,
                Birthdate = DateTime.Now,
                Parent1Moniker = "",
                Parent2Moniker = "norn.astro.ex47.gen",
                ChildrenMonikers = new string[] {
                    "003-flower-xvjbp-xyhye-ign3a-drjyp",
                },
            },



            new Creature
            {
                Moniker = "002-sprite-xvjbp-xyhye-ign3a-drjyp",
                Name = "Kevin",
                BirthEventType = BirthEventType.Conceived,
                Birthdate = DateTime.Now,
                Parent1Moniker = "001-butterfly-xvjbp-xyhye-ign3a-drjyp",
                Parent2Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                ChildrenMonikers = new string[] { },
            },
            new Creature
            {
                Moniker = "002-norn-xvjbp-xyhye-ign3a-drjyp",
                Name = "Benjamin",
                BirthEventType = BirthEventType.Conceived,
                Birthdate = DateTime.Now,
                Parent1Moniker = "001-butterfly-xvjbp-xyhye-ign3a-drjyp",
                Parent2Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                ChildrenMonikers = new string[] {
                    "003-magic-xvjbp-xyhye-ign3a-drjyp",
                },
            },
            new Creature
            {
                Moniker = "002-wizard-xvjbp-xyhye-ign3a-drjyp",
                Name = "Jacob",
                BirthEventType = BirthEventType.Conceived,
                Birthdate = DateTime.Now,
                Parent1Moniker = "001-butterfly-xvjbp-xyhye-ign3a-drjyp",
                Parent2Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                ChildrenMonikers = new string[] { },
            },
            new Creature
            {
                Moniker = "002-lion-xvjbp-xyhye-ign3a-drjyp",
                Name = "Samantha",
                BirthEventType = BirthEventType.Conceived,
                Birthdate = DateTime.Now,
                Parent1Moniker = "001-butterfly-xvjbp-xyhye-ign3a-drjyp",
                Parent2Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                ChildrenMonikers = new string[] {
                     "003-flower-xvjbp-xyhye-ign3a-drjyp",
                },
            },

            new Creature
            {
                Moniker = "001-flower-xvjbp-xyhye-ign3a-drjyp",
                Name = "Thomas",
                BirthEventType = BirthEventType.Engineered,
                Birthdate = DateTime.Now,
                Parent1Moniker = "",
                Parent2Moniker = "norn.chichi06.ex47.gen",
                ChildrenMonikers = new string[] {
                    "002-sprite-xvjbp-xyhye-ign3a-drjyp",
                    "002-norn-xvjbp-xyhye-ign3a-drjyp",
                    "002-wizard-xvjbp-xyhye-ign3a-drjyp",
                    "002-lion-xvjbp-xyhye-ign3a-drjyp",
                },
            },
            new Creature
            {
                Moniker = "001-butterfly-xvjbp-xyhye-ign3a-drjyp",
                Name = "Kathy",
                BirthEventType = BirthEventType.Engineered,
                Birthdate = DateTime.Now,
                Parent1Moniker = "",
                Parent2Moniker = "norn.astro.ex47.gen",
                ChildrenMonikers = new string[] {
                    "002-sprite-xvjbp-xyhye-ign3a-drjyp",
                    "002-norn-xvjbp-xyhye-ign3a-drjyp",
                    "002-wizard-xvjbp-xyhye-ign3a-drjyp",
                    "002-lion-xvjbp-xyhye-ign3a-drjyp",
                },
            },

        };

        private readonly ILogger<CreaturesController> _logger;

        public CreaturesController(ILogger<CreaturesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CreatureWithKin> Get()
        {
            return CreaturesWithKin().ToList();
        }

        [HttpGet("{id}/events")]
        public IEnumerable<HistEvent> EventsFor(string id)
        {
            return Events
                .Where(histEvent => histEvent.Moniker == id)
                .OrderBy(histEvent => histEvent.TimeUTC);
        }

        private IEnumerable<CreatureWithKin> CreaturesWithKin()
        {
            return Creatures
                .GroupJoin(
                    Creatures,
                    creature => creature.Parent1Moniker,
                    creature => creature.Moniker,
                    (creature1, creature2) =>
                    new
                    {
                        Creature = creature1,
                        Parent1 = creature2.FirstOrDefault()
                    })
                .GroupJoin(
                    Creatures,
                    creature => creature.Creature.Parent2Moniker,
                    creature => creature.Moniker,
                    (creature1, creature2) =>
                    new
                    {
                        Creature = creature1.Creature,
                        Parent1 = creature1.Parent1,
                        Parent2 = creature2.FirstOrDefault()
                    })
                .Select(obj =>
                    new CreatureWithKin
                    {
                        Moniker = obj.Creature.Moniker,
                        Name = obj.Creature.Name,
                        CrossoverPointMutations = obj.Creature.CrossoverPointMutations,
                        PointMutations = obj.Creature.PointMutations,
                        Gender = obj.Creature.Gender,
                        Genus = obj.Creature.Genus,
                        Birthdate = obj.Creature.Birthdate,
                        BirthEventType = obj.Creature.BirthEventType,

                        Parent1Moniker = obj.Creature.Parent1Moniker,
                        Parent1Name = obj.Parent1?.Name ?? "No Parent",
                        Parent2Moniker = obj.Creature.Parent2Moniker,
                        Parent2Name = obj.Parent2?.Name ?? "No Parent",
                        ChildrenMonikers = obj.Creature.ChildrenMonikers,
                        ChildrenNames = obj.Creature.ChildrenMonikers
                            .Join(
                                Creatures,
                                childMoniker => childMoniker,
                                creature => creature.Moniker,
                                (childMoniker, creature) => creature.Name
                            ).ToArray(),
                    }
                )
                .OrderBy(creature => creature.Birthdate);
        }

        [HttpGet("{id}")]
        public CreatureWithKin Get(string id)
        {
            return
                CreaturesWithKin().FirstOrDefault(creature => creature.Moniker == id) ??
                Creatures.Where(creature => creature.Moniker == id)
                    .Select(obj =>
                     new CreatureWithKin
                     {
                         Moniker = obj.Moniker,
                         Name = obj.Name,
                         Birthdate = obj.Birthdate,
                         BirthEventType = obj.BirthEventType,
                         Parent1Moniker = obj.Parent1Moniker,
                         Parent1Name = "",
                         Parent2Moniker = obj.Parent2Moniker,
                         Parent2Name = "",
                         ChildrenMonikers = obj.ChildrenMonikers,
                         ChildrenNames = new string[]{ "" }
                     }
                    )
                    .First();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }
    }
}
