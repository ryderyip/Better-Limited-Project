using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Entity
{
    public class Technician
    {
        public Technician(string id, string name, string phone)
        {
            Id = id;
            Name = name;
            Phone = phone;
        }

        public string Id { get; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public IEnumerable<Installation> AppointedInstallations =>
            InstallationRepository.FindBy(i => i.Technicians.Any(t => t.TechnicianId == Id));

        public IEnumerable<Installation> UnfinishedInstallations =>
            AppointedInstallations.Where(i => !i.IsInstalled());

        public void Save()
        {
            TechnicianRepository.InsertOrUpdate(this);
        }
    }
}