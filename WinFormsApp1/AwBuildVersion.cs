


namespace WinFormsApp1
{

    public class AwBuildVersion
    {
        public byte SystemInformationId { get; set; }
        public string DatabaseVersion { get; set; }
        public System.DateTime VersionDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public AwBuildVersion()
        {
            ModifiedDate = System.DateTime.Now;
        }
    }

}
