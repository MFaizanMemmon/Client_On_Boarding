namespace Client_On_Boarding.DTO
{
    public class DashboardVM
    {
        public int? TotalClientLead { get; set; }
        public int? GrossMonthlyPercent { get; set; }

        public int? ActiveOnBoarding { get; set; }
        public int? Followup { get; set; }
        public int? TotalReceivable { get; set; }

        public int? BusinessType { get; set; }
        public string? Top1BusinessTypeName { get; set; }
        public int? CountTop1BusinessTypeName { get; set; }


    }
}
