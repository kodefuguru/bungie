namespace Bungie.Definitions
{
    public class TalentGridNodeStep
    {
        public int StepIndex { get; set; }
        public long NodeStepHash { get; set; }
        public string NodeStepName { get; set; }
        public string NodeStepDescription { get; set; }
        public string InteractionDescription { get; set; }
        public string Icon { get; set; }
        public int DamageType { get; set; }
        public long DamageTypeHash { get; set; }
        public ActivationRequirement ActivationRequirement { get; set; }
        public bool CanActivateNextStep { get; set; }
        public int NextStepIndex { get; set; }
        public bool IsNextStepRandom { get; set; }
        public long[] PerkHashes { get; set; }
        public int StartProgressionBarAtProgress { get; set; }
        public long[] StatHashes { get; set; }
        public bool AffectsQuality { get; set; }
        public Groups StepGroups { get; set; }
        public int TrueStepIndex { get; set; }
        public int TruePropertyIndex { get; set; }
        public bool AffectsLevel { get; set; }
    }
}