﻿using GMSDataAccess.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMSUI.Forms;
public partial class HomeForm : Form {
    private readonly ShellForm _shell;

    public HomeForm(ShellForm shell) {

        InitializeComponent();
        _shell = shell;
    }

    override protected void OnLoad(EventArgs e) {

        if (_shell.LoggedInUser.Role == "Admin") {

            UsersButton.Visible = true;
        }
    }

    private void MembersButton_Click(object sender, EventArgs e) {
        
        MemberForm memberForm = new MemberForm(_shell);
        _shell.OpenChildForm(memberForm, "Members");
    }

    private void EmployeesButton_Click(object sender, EventArgs e) {

        EmployeeForm employeeForm = new EmployeeForm(_shell);
        _shell.OpenChildForm(employeeForm, "Employees");
    }

    private void UsersButton_Click(object sender, EventArgs e) {

        UserForm userForm = new UserForm(_shell);
        _shell.OpenChildForm(userForm, "Users");
        
    }

    private void PlansButton_Click(object sender, EventArgs e) {

        PlanForm PlanForm = new PlanForm(_shell);
        _shell.OpenChildForm(PlanForm, "Plans");
    }

    private void MembershipsButton_Click(object sender, EventArgs e) {

        MembershipForm membership = new MembershipForm(_shell);
        _shell.OpenChildForm(membership, "Memberships");
    }

    private void BackupRestoreDatabaseButton_Click(object sender, EventArgs e) {
        BackupRestoreForm backupRestore = new BackupRestoreForm(_shell);
        _shell.OpenChildForm(backupRestore, "Backup and Restore Database");
    }
}
