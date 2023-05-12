


namespace WinFormsApp1
{

    public class Production_Document
    {
        public System.Data.Entity.Hierarchy.HierarchyId DocumentNode { get; set; }
        public short? DocumentLevel { get; private set; }
        public string Title { get; set; }
        public int Owner { get; set; }
        public bool FolderFlag { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Revision { get; set; }
        public int ChangeNumber { get; set; }
        public byte Status { get; set; }
        public string DocumentSummary { get; set; }
        public byte[] Document { get; set; }
        public System.Guid Rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        public virtual System.Collections.Generic.ICollection<Production_ProductDocument> Production_ProductDocument { get; set; }


        public virtual HumanResources_Employee HumanResources_Employee { get; set; }

        public Production_Document()
        {
            FolderFlag = false;
            ChangeNumber = 0;
            Rowguid = System.Guid.NewGuid();
            ModifiedDate = System.DateTime.Now;
            Production_ProductDocument = new System.Collections.Generic.List<Production_ProductDocument>();
        }
    }

}
