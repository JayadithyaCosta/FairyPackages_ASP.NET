﻿namespace FairyWeddingsAPI.Services
{
    public interface IPackagesService
    {
        List<Models.Packages> GetPackages();
        Models.Packages? GetPackageById(int id);
        Models.Packages? AddPackage(Models.Packages package);
        Models.Packages? UpdatePackage(Models.Packages package);
        Models.Packages? CalculateGrossTotalForPackage(int id);
        bool? DeletePackage(int id);
    }
}
