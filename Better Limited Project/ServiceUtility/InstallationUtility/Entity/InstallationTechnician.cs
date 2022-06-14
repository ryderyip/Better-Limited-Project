using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Entity
{
    public class InstallationTechnician
    {
        public InstallationTechnician(string installationId, string technicianId)
        {
            InstallationId = installationId;
            TechnicianId = technicianId;
        }

        public string InstallationId { get; }
        public string TechnicianId { get; }
        public Installation Installation => InstallationRepository.FindById(InstallationId);
        public Technician Technician => TechnicianRepository.FindById(TechnicianId);

        public void Save()
        {
            InstallationTechnicianRepository.Insert(this);
        }
    }
}