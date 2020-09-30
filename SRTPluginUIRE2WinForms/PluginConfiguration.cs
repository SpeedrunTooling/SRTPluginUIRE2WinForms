namespace SRTPluginUIRE2WinForms
{
    public class PluginConfiguration
    {
        public bool Debug { get; set; }
        public bool NoInventory { get; set; }
        public bool NoTitlebar { get; set; }
        public float ScalingFactor { get; set; }
        public bool Transparent { get; set; }

        public PluginConfiguration()
        {
            Debug = false;
            NoInventory = false;
            NoTitlebar = false;
            ScalingFactor = 0.75f;
            Transparent = false;
        }
    }
}
