namespace Hidden_logical_dependecy
{
    /// <summary>
    /// The door class.
    /// </summary>
    public class Door
    {
        public bool Locked { get; private set; }

        public bool ChildLock { get; private set; }

        public Door()
        {
            Locked = true;
        }

        /// <summary>
        /// Activate the child lock. And prevent the door from being opened from inside.
        /// </summary>
        public void ActivateChildLock() => ChildLock = true;

        /// <summary>
        /// Deactivate the child lock. And allow the door to be opened from inside.
        /// </summary>
        public void DeactivateChildLock() => ChildLock = false;

        /// <summary>
        /// Allows the door to be opened from inside, unless child lock is activated.
        /// </summary>
        public void OpenFromInside()
        {
            if (ChildLock)
            {
                return;
            }
            Locked = false;
        }

        /// <summary>
        /// Allow the door to be opened from outside.
        /// </summary>
        public void OpenFromOutside() => Locked = false;

        /// <summary>
        /// Close the door.
        /// </summary>
        public void Close() => Locked = true;

    }
}
