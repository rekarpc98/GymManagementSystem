﻿using GMSDataAccess.DataAccess;
using GMSDataAccess.Model;
using GMSUI.Helper;
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
public partial class UserForm : Form {

    private readonly HomeForm _home;
    private SqlConnector _sqlConnector = new SqlConnector();
    private BindingList<UserModel> _Users;
    private DataGridViewRow _selectedRow;

    public UserForm(HomeForm home) {
        InitializeComponent();
        
        _home = home;

        ComboBoxItem<int> item1 = new ComboBoxItem<int>();
        item1.Label = "Admin";
        item1.Value = 1;

        ComboBoxItem<int> item2 = new ComboBoxItem<int>();
        item2.Label = "Manager";
        item2.Value = 2;

        List<ComboBoxItem<int>> items = new List<ComboBoxItem<int>>();
        items.Add(item1);
        items.Add(item2);

        RoleLevelComboBox.DataSource = items;
        RoleLevelComboBox.DisplayMember = "Label";

    }

    protected async override void OnLoad(EventArgs e) {


        await LoadUsers();

    }

    internal async Task LoadUsers() {

        var u = await _sqlConnector.GetUsers();

        _Users = new BindingList<UserModel>(u);

        UsersDataGridView.DataSource = _Users;
    }
    private void AddUserButton_Click(object sender, EventArgs e) {
        AddUserForm frm = new AddUserForm(this);
        frm.ShowDialog();
    }

    private bool ValidateForm() {
        bool output = true;

        if (string.IsNullOrEmpty(NameTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(AddressTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(SalaryTextBox.Text)) {
            output = false;

        } else if (string.IsNullOrEmpty(PhoneNumber1TextBox.Text)) {
            output = false;

        }

        return output;
    }

    private async void UpdateInfoButton_Click(object sender, EventArgs e) {
        
        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (!ValidateForm()) {
            MessageBox.Show("Please enter all required information!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        UserModel model = new UserModel();

        model.Id = int.Parse(_selectedRow.Cells[0].Value.ToString());
        model.Name = NameTextBox.Text;
        model.RoleLevel = int.Parse(RoleLevelComboBox.SelectedItem.ToString());
        model.Address = AddressTextBox.Text;
        model.Salary = decimal.Parse(SalaryTextBox.Text);
        model.PhoneNumber1 = PhoneNumber1TextBox.Text;
        model.PhoneNumber2 = PhoneNumber2TextBox.Text;

        try {
            await _sqlConnector.UpdateUser(model);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();

    }

    private async void UpdatePasswordButton_Click(object sender, EventArgs e) {
        
        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (string.IsNullOrEmpty(PasswordTextBox.Text)) {
            MessageBox.Show("Please a password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        int id = int.Parse(_selectedRow.Cells[0].Value.ToString());
        try {
            await _sqlConnector.UpdateUserPassword(id, PasswordTextBox.Text.Trim());
            PasswordTextBox.Text = "";

        } catch (Exception ex) {

            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }

    private async void DeleteButton_Click(object sender, EventArgs e) {
        
        if (_selectedRow == null) {
            MessageBox.Show("Please Select a row!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        int id = int.Parse(_selectedRow.Cells[0].Value.ToString());

        try {
            await _sqlConnector.DeleteUser(id);

        } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        await ResetForm();
    }

    private async Task ResetForm() {

        NameTextBox.Text = "";
        AddressTextBox.Text = "";
        SalaryTextBox.Text = "";
        PhoneNumber1TextBox.Text = "";
        PhoneNumber2TextBox.Text = "";
        PasswordTextBox.Text = "";

        await LoadUsers();
    }

    private void SalaryTextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void PhoneNumber1TextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void PhoneNumber2TextBox_KeyPress(object sender, KeyPressEventArgs e) {
        e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }

    private void UsersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
        
        if (e.RowIndex < 0) {
            return;
        }

        _selectedRow = UsersDataGridView.Rows[e.RowIndex];

        NameTextBox.Text = _selectedRow.Cells[1].Value.ToString();
        RoleLevelComboBox.SelectedIndex = int.Parse(_selectedRow.Cells[2].Value.ToString()) - 1;
        AddressTextBox.Text = _selectedRow.Cells[3].Value.ToString();
        SalaryTextBox.Text = _selectedRow.Cells[4].Value.ToString();
        PhoneNumber1TextBox.Text = _selectedRow.Cells[5].Value.ToString();
        PhoneNumber2TextBox.Text = _selectedRow.Cells[6].Value.ToString();
    }
}
