namespace MediaBrowser.Model.System
{
    public class WakeOnLanInfo
    {
        public string MacAddress { get; set; }
        public int Port { get; set; }

        public WakeOnLanInfo()
        {
            Port = 9;
        }
    }
}