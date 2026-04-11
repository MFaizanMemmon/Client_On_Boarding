namespace Client_On_Boarding.DTO
{
    public class ClientPagesAllowancesVM
    {
        public int ClientId { get; set; }
        public List<int> PageIds { get; set; } = new();
    }
}
