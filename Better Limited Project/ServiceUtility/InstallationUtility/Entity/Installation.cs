using System;
using System.Collections.Generic;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Entity
{
    public class Installation
    {
        public Installation(string installationRequestId, DateTime scheduledOn)
        {
            Id = InstallationRepository.GetNewId();
            InstallationRequestId = installationRequestId;
            ScheduledOn = scheduledOn;
        }

        public Installation(string id, string installationRequestId, DateTime scheduledOn, DateTime? installedOn)
        {
            Id = id;
            InstallationRequestId = installationRequestId;
            ScheduledOn = scheduledOn;
            InstalledOn = installedOn;
        }

        public string Id { get; }
        public string InstallationRequestId { get; }
        public InstallationRequest InstallationRequest => InstallationRequestRepository.FindById(InstallationRequestId);
        public DateTime ScheduledOn { get; }
        public DateTime? InstalledOn { get; set; }

        public IEnumerable<InstallationTechnician> Technicians =>
            InstallationTechnicianRepository.GetByInstallationId(Id);

        public void Save()
        {
            InstallationRepository.InsertOrUpdate(this);
        }

        public bool IsInstalled()
        {
            return InstalledOn != null;
        }
    }
}