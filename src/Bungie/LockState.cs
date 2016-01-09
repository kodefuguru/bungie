namespace Bungie
{
    using System;
    using System.Linq;

    public struct LockState : IEquatable<LockState>
    {
        private readonly bool value;

        public static LockState Locked
        {
            get { return new LockState(true); }
        }

        public static LockState Unlocked
        {
            get { return new LockState(false); }
        }

        private LockState(bool value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(LockState))
                return Equals((LockState)obj);

            return false;
        }

        public bool Equals(LockState other)
        {
            return this.value == other.value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value ? "Locked" : "Unlocked";
        }
        
        public static explicit operator bool(LockState lockState)
        {
            return lockState.value;
        }
    }
}
