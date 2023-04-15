namespace FairyWeddingsAPI.Models
{
    public class Packages
    {
        public int packageID { get; set; }
        public int? packageVersion { get; set; }
        public string? packageName { get; set; }
        public int packageGuestNo { get; set; }
        public string? packageDescription { get; set; }
        public string? packageType { get; set; }
        public string? packageVenue { get; set; }
        public string? packageService { get; set; }
        public double ? packageTotal { get; set; }
        public bool? packageAccomadation { get; set; }
        public bool? packageEntertainment { get; set; }
        public bool? packageCatering { get; set; }




    }
}
