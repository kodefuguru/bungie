namespace Bungie
{
    using System;

    public struct TrackState : IEquatable<TrackState>
    {
        private readonly bool value;

        public static TrackState Tracked
        {
            get { return new TrackState(true); }
        }

        public static TrackState NotTracked
        {
            get { return new TrackState(false); }
        }

        private TrackState(bool value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(TrackState))
                return Equals((TrackState)obj);

            return false;
        }

        public bool Equals(TrackState other)
        {
            return this.value == other.value;
        }

        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        public override string ToString()
        {
            return value ? "Tracked" : "Not Tracked";
        }

        public static explicit operator bool(TrackState trackState)
        {
            return trackState.value;
        }
    }
}
