namespace FairyWeddingsAPI.Data
{
    public class PackagesMockDataService
    {
        public static List<Models.Packages> Packages = new List<Models.Packages>()
        {
            new Models.Packages{packageID = 1, packageName = "Basic Package", packageType = "basic", packageVersion = 1, packageVenue = "Indoor", packageAccomadation = true, packageDescription = "This is the basic package", packageService = "Time Management", packageGuestNo = 200, packageTotal = 250000.00},
            new Models.Packages{packageID = 2, packageName = "Standard Package", packageType = "standard", packageVersion = 1, packageVenue = "Outdoor", packageAccomadation = false, packageDescription = "This is the standered package", packageService = "Catering", packageGuestNo = 300, packageTotal = 650000.00},
            new Models.Packages{packageID = 3, packageName = "Premium Package", packageType = "premium", packageVersion = 1, packageVenue = "Beach front", packageAccomadation = true, packageDescription = "This is the premium package", packageService = "Entertainment Management ", packageGuestNo = 500, packageTotal = 8500000.00},
            new Models.Packages{packageID = 4, packageName = "Standard Package", packageType = "standard", packageVersion = 1, packageVenue = "Indoor", packageAccomadation = true, packageDescription = "This is the standered package", packageService = "Time Management", packageGuestNo = 400, packageTotal = 650000.00}
        };
    }
}
