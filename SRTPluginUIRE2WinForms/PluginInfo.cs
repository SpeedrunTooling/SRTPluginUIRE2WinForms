using SRTPluginBase;
using System;

namespace SRTPluginUIRE2WinForms
{
    internal class PluginInfo : IPluginInfo
    {
        public string Name => "WinForms UI (Resident Evil 2 (2019))";

        public string Description => "A WinForms-based User Interface for displaying Resident Evil 2 (2019) game memory values.";

        public string Author => "Squirrelies";

        public Uri MoreInfoURL => new Uri("https://github.com/Squirrelies/SRTPluginUIRE2WinForms");

        public int VersionMajor => assemblyFileVersion.ProductMajorPart;

        public int VersionMinor => assemblyFileVersion.ProductMinorPart;

        public int VersionBuild => assemblyFileVersion.ProductBuildPart;

        public int VersionRevision => assemblyFileVersion.ProductPrivatePart;

        private System.Diagnostics.FileVersionInfo assemblyFileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}
