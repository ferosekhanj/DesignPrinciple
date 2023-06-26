namespace Hidden_logical_dependecy
{
    /// <summary>
    /// The door class.
    /// </summary>
    public class Door
    {
        public bool Locked { get; private set; }

        public bool ChildLock { get; set; }

        public Door()
        {
            Locked = true;
            ChildLock = false;
        }

        public void Open(bool fromInside)
        {
            if(fromInside && ChildLock)
            {
                return;
            }
            Locked = false;
        }
        public void Close() => Locked = true;

    }
}
