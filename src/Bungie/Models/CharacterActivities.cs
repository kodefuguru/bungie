namespace Bungie.Models
{
    using System;

    public class CharacterActivities
    {
        public DateTime DataActivityStarted { get; set; }
        public CharacterActivity[] Available { get; set; }
    }
}