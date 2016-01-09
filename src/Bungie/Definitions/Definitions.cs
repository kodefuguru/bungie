namespace Bungie.Definitions
{
    public class Definitions
    {
        public HashMap<Activity> Activities { get; set; }
        public HashMap<ActivityType> ActivityTypes { get; set; }
        public HashMap<ActivityBundle> ActivityBundles { get; set; }
        public HashMap<Badge> Badges { get; set; }
        public HashMap<Unknown> Books { get; set; }
        public HashMap<Bucket> Buckets { get; set; }
        public HashMap<Class> Classes { get; set; }
        public HashMap<DamageType> DamageTypes { get; set; }
        public HashMap<Destination> Destinations { get; set; }
        public HashMap<EnemyRace> EnemyRaces { get; set; }
        public HashMap<Event> Events { get; set; }
        public HashMap<Faction> Factions { get; set; }
        public HashMap<Flag> Flags { get; set; }
        public HashMap<Gender> Genders { get; set; }
        public HashMap<Item> Items { get; set; }
        public HashMap<ItemCategory> ItemCategories { get; set; }
        public HashMap<Unknown> Locations { get; set; }
        public HashMap<MaterialRequirementSet> MaterialRequirements { get; set; }
        public HashMap<Objective> Objectives { get; set; }
        public HashMap<TalentGridNodeStep> NodeSteps { get; set; }
        public HashMap<Perk> Perks { get; set; }
        public HashMap<Place> Places { get; set; }
        public HashMap<Progression> Progressions { get; set; }
        public HashMap<Unknown> ProgressionMappings { get; set; }
        public HashMap<Race> Races { get; set; }
        public HashMap<Skull> ScriptedSkulls { get; set; }
        public HashMap<Source> Sources { get; set; }
        public HashMap<StatGroup> StatGroups { get; set; }
        public HashMap<Stat> Stats { get; set; }
        public HashMap<TalentGrid> TalentGrids { get; set; }
        public HashMap<TriumphSet> Triumphs { get; set; }
        public HashMap<Unknown> UnlockValues { get; set; }
        public HashMap<VendorDetail> VendorDetails { get; set; }
        public HashMap<VendorCategory> VendorCategories { get; set; }
        public HashMap<Unknown> VendorSummaries { get; set; }

        public Definitions()
        {
            Activities = new HashMap<Activity>();
            ActivityTypes = new HashMap<ActivityType>();
            ActivityBundles = new HashMap<ActivityBundle>();
            Badges = new HashMap<Badge>();
            Books = new HashMap<Unknown>();
            Buckets = new HashMap<Bucket>();
            Classes = new HashMap<Class>();
            DamageTypes = new HashMap<DamageType>();
            Destinations = new HashMap<Destination>();
            EnemyRaces = new HashMap<EnemyRace>();
            Events = new HashMap<Event>();
            Factions = new HashMap<Faction>();
            Flags = new HashMap<Flag>();
            Genders = new HashMap<Gender>();
            Items = new HashMap<Item>();
            ItemCategories = new HashMap<ItemCategory>();
            Locations = new HashMap<Unknown>();
            MaterialRequirements = new HashMap<MaterialRequirementSet>();
            NodeSteps = new HashMap<TalentGridNodeStep>();
            Objectives = new HashMap<Objective>();
            Perks = new HashMap<Perk>();
            Places = new HashMap<Place>();
            Progressions = new HashMap<Progression>();
            ProgressionMappings = new HashMap<Unknown>();
            Races = new HashMap<Race>();
            ScriptedSkulls = new HashMap<Skull>();
            Sources = new HashMap<Source>();
            StatGroups = new HashMap<StatGroup>();
            Stats = new HashMap<Stat>();
            TalentGrids = new HashMap<TalentGrid>();
            Triumphs = new HashMap<TriumphSet>();
            UnlockValues = new HashMap<Unknown>();
            VendorDetails = new HashMap<VendorDetail>();
            VendorCategories = new HashMap<VendorCategory>();
            VendorSummaries = new HashMap<Unknown>();
        }
    }
}
