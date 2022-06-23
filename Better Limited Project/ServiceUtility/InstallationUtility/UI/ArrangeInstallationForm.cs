using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.Login;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Controller;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class ArrangeInstallationForm : Form
    {
        private readonly InstallationRequest _installationRequest;
        private List<Technician> _selectedTechnicians = new();

        public ArrangeInstallationForm(InstallationRequest installationRequest)
        {
            _installationRequest = installationRequest;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        private void Initialize()
        {
            var deliveryRequest = _installationRequest.SalesOrder.GetDeliveryRequest();
            dtpScheduledDate.MinDate = dtpScheduledTime.MinDate =
                deliveryRequest != null
                    ? GetEarliestInstallationTimeByDeliverySchedule(deliveryRequest.GetDeliveries()
                        .Max(d => d.ScheduledOn))
                    : GetNextDay9Am();
            dtpScheduledDate.Value = dtpScheduledTime.Value = dtpScheduledTime.MinDate;

            dtpScheduledTime.Format = DateTimePickerFormat.Time;
            dtpScheduledTime.ShowUpDown = true;
            dtpScheduledDate.ValueChanged += (_, _) =>
            {
                _selectedTechnicians.Clear();
                tbSelectedTechnicians.Clear();
            };
        }

        private DateTime GetNextDay9Am()
        {
            return DateTime.Today + TimeSpan.FromDays(1) + TimeSpan.FromHours(9);
        }

        private DateTime GetEarliestInstallationTimeByDeliverySchedule(DateTime arrangedDeliveryTime)
        {
            if (IsAfter5Pm(arrangedDeliveryTime))
            {
                var nextDayMorning = arrangedDeliveryTime.Date + TimeSpan.FromDays(1) + TimeSpan.FromHours(9);
                return nextDayMorning.DayOfWeek is DayOfWeek.Sunday
                    ? nextDayMorning + TimeSpan.FromDays(1)
                    : nextDayMorning;
            }

            return arrangedDeliveryTime + TimeSpan.FromHours(2);
        }

        private static bool IsAfter5Pm(DateTime lastParcelDeliveryTime)
        {
            return lastParcelDeliveryTime.TimeOfDay > TimeSpan.FromHours(17);
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            if (dtpScheduledDate.Value.Date.DayOfWeek is DayOfWeek.Sunday)
            {
                MessageBox.Show("Sunday is company and cannot have installation scheduled.");
                return;
            }

            var service = new InstallationService(_installationRequest);
            service.AddTechniciansRange(_selectedTechnicians);
            var scheduledInstallationTime = dtpScheduledDate.Value.Date + dtpScheduledTime.Value.TimeOfDay;
            service.Arrange(scheduledInstallationTime);
            _installationRequest.ArrangedOn = DateTime.Now;
            _installationRequest.ArrangedByStaffId = LoginSession.GetSession().CurrentStaff.Id;
            _installationRequest.Save();
            DialogResult = DialogResult.OK;
        }

        private void btnSelectTechnicians_Click(object sender, EventArgs e)
        {
            var form = _selectedTechnicians.Count != 0
                ? new TechnicianPickerForm(_selectedTechnicians)
                : new TechnicianPickerForm(GetUnoccupiedTechniciansOnScheduledDateTime());
            var result = form.ShowDialog();
            if (result is not DialogResult.OK)
                return;
            _selectedTechnicians = form.SelectedTechnicians;
            tbSelectedTechnicians.Text = string.Join(", ", _selectedTechnicians.Select(t => t.Name));
            btnArrange.Enabled = _selectedTechnicians.Any();
        }

        private IEnumerable<Technician> GetUnoccupiedTechniciansOnScheduledDateTime()
        {
            return TechnicianRepository.GetAll().Where(t =>
                !t.AppointedInstallations.Any() ||
                t.AppointedInstallations.All(ai => ai.ScheduledOn.Date != dtpScheduledDate.Value.Date));
        }
    }
}