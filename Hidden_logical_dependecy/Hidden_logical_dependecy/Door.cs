namespace Hidden_logical_dependecy
{
    /// <summary>
    /// The door class.
    /// </summary>
    public class Door
    {
        public bool Locked { get; private set; }

        public Door()
        {
            Locked = true;
        }

        public void OpenFromInside(bool childLock)
        {
            if(childLock)
            {
                return;
            }
            Locked = false;
        }

        public void OpenFromOutside() => Locked = false;

        public void Close() => Locked = true;

    }
}
