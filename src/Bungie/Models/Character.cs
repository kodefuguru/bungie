namespace Bungie.Models
{
    public class Character
    {
        public CharacterBase CharacterBase { get; set; }
        public CharacterActivities Activities { get; set; }
        public HashMap<NodeStates> DirectorNodeStates { get; set; }
        public long[] VisibleBookHashes { get; set; }
        public long DefaultBookHash { get; set; }
        public CharacterInventory Inventory { get; set; }
        public CharacterProgression Progressions { get; set; }
        public Dye[] CustomDyes { get; set; }
        public int CharacterLevel { get; set; }
    }

}