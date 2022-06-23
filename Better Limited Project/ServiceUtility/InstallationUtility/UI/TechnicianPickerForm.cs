using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Entity;
using Better_Limited_Project.ServiceUtility.InstallationUtility.Repository;

namespace Better_Limited_Project.ServiceUtility.InstallationUtility.UI
{
    public partial class TechnicianPickerForm : Form
    {
        private readonly List<Technician> _technicians;

        public TechnicianPickerForm(IEnumerable<Technician>? preselectedTechnicians = null)
        {
            _technicians = TechnicianRepository.GetAll().ToList();
            StartPosition = FormStartPosition.CenterScreen;
            SelectedTechnicians = preselectedTechnicians != null
                ? preselectedTechnicians.ToList()
                : new List<Technician>();
            InitializeComponent();
            Load += (_, _) => Initialize();
        }

        public List<Technician> SelectedTechnicians { get; }

        private void Initialize()
        {
            dgvTechnicians.SelectionChanged += (_, _) => btnConfirm.Enabled = dgvTechnicians.SelectedRows.Count != 0;
            _technicians.ForEach(t => dgvTechnicians.Rows.Add(t.Id, t.Name, t.Phone));
            SelectedPreselectedTechnicians();
        }

        private void SelectedPreselectedTechnicians()
        {
            foreach (DataGridViewRow row in dgvTechnicians.Rows)
            {
                string id = row.Cells[idColumn.Name].Value.ToString();
                if (SelectedTechnicians.Any(t => t.Id == id))
                    row.Selected = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            SelectedTechnicians.Clear();
            foreach (DataGridViewRow row in dgvTechnicians.Rows)
            {
                if (!row.Selected)
                    continue;
                string id = row.Cells[idColumn.Name].Value.ToString();
                var technician = _technicians.Find(t => t.Id == id);
                SelectedTechnicians.Add(technician);
            }

            DialogResult = DialogResult.OK;
        }
    }
}