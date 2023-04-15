using FairyWeddingsAPI.Data;
using FairyWeddingsAPI.Models;

namespace FairyWeddingsAPI.Services
{
    public class PackagesService : IPackagesService
    {
        public Models.Packages? AddPackage(Packages package)
        {
            PackagesMockDataService.Packages.Add(package);
            return package;
        }

        public bool? DeletePackage(int id)
        {
            Models.Packages selectedPackage = PackagesMockDataService.Packages.FirstOrDefault(x => x.packageID == id);
            if (selectedPackage != null)
            {
                PackagesMockDataService.Packages.Remove(selectedPackage);
                return true;
            }
            return false;
        }

        public Packages? GetPackageById(int id)
        {
            return PackagesMockDataService.Packages.FirstOrDefault(x => x.packageID == id);
        }

        public List<Packages> GetPackages()
        {
            return PackagesMockDataService.Packages;
        }

        public Packages? UpdatePackage(Packages package)
        {
            Models.Packages selectedPackage = PackagesMockDataService.Packages.FirstOrDefault(x => x.packageID == package.packageID);
            if (selectedPackage != null)
            {
                selectedPackage.packageGuestNo = package.packageID;
                selectedPackage.packageVenue = package.packageVenue;
                selectedPackage.packageVersion = selectedPackage.packageVersion + 1;
                selectedPackage.packageName = package.packageName;
                selectedPackage.packageAccomadation = package.packageAccomadation;
                selectedPackage.packageDescription = package.packageDescription;
                selectedPackage.packageService = selectedPackage.packageService;
                selectedPackage.packageTotal = package.packageTotal;
                selectedPackage.packageType = package.packageType;
            }
            return selectedPackage;
        }
    }
}
