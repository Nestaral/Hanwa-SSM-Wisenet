namespace PTZSample
{
    public class ObjectInfo
    {
        public string Guid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string NameExt { get; set; }
        public string IpAddress { get; set; }

        public string NameAddress
        {
            get
            {
                return this.Name + " (" + IpAddress + ")";
            }
        }
    }
}
