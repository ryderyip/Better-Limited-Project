using System;
using System.Collections.Generic;
using System.Linq;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.Controller
{
    public class InstallationService
    {
        private readonly InstallationRequest _installationRequest;
        private readonly List<Technician> _selectedTechnicians = new();

        public InstallationService(InstallationRequest installationRequest)
        {
            _installationRequest = installationRequest;
        }

        public void Arrange(DateTime scheduledInstallationTime)
        {
            if (!_selectedTechnicians.Any())
                throw new ArgumentException("You need to select at least one technician to arrange an installation.");

            var installation = new Installation(_installationRequest.Id, scheduledInstallationTime);
            installation.Save();
            
            var installationTechnicians =
                _selectedTechnicians.Select(t => new InstallationTechnician(installation.Id, t.Id));
            foreach (var installationTechnician in installationTechnicians)
                installationTechnician.Save();
        }

        public void AddTechniciansRange(IEnumerable<Technician> technicians)
        {
            _selectedTechnicians.AddRange(technicians);
        }
    }
}