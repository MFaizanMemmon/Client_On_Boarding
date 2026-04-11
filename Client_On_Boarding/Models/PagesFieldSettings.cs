namespace Client_On_Boarding.Models
{
    public class PagesFieldSettings : BaseEntity
    {
        
        public int PageId { get; set; }
        public string FieldName { get; set; } = string.Empty;
        public bool IsView { get; set; }
        public bool IsRequired { get; set; }

       
    }
}
