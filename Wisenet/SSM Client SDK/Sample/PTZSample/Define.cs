namespace PTZSample
{
    enum EventID 
    {
        Login = 11,
    }

    public enum Mode
    {
        Display = 0,
        Relay,
    }

    public enum MediaType
    {
        Live = 1,
        Playback,
    }

    public enum PtzAction
    {
        None = 0,
        Up = 1,
        Down = 2,
        Left = 3,
        Right = 4,
        UpLeft = 5,
        UpRight = 6,
        DownLeft = 7,
        DownRight = 8,
        ZoomIn = 9,
        ZoomOut = 10,
        Stop = 19,
    }
}
