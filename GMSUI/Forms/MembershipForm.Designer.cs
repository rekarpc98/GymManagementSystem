﻿namespace GMSUI.Forms;

partial class MembershipForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MemberNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StartingDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpirationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.PlansComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrainersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MembershipsDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrainerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsExpired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoRenew = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRenewDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.ExpiredOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.ActiveOnlyRadioButton = new System.Windows.Forms.RadioButton();
            this.AllRadioButton = new System.Windows.Forms.RadioButton();
            this.AutoRenewCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MembershipsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MemberNameTextBox
            // 
            this.MemberNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberNameTextBox.Location = new System.Drawing.Point(81, 92);
            this.MemberNameTextBox.Name = "MemberNameTextBox";
            this.MemberNameTextBox.ReadOnly = true;
            this.MemberNameTextBox.Size = new System.Drawing.Size(179, 29);
            this.MemberNameTextBox.TabIndex = 85;
            this.MemberNameTextBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(746, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 84;
            this.label4.Text = "Starting Date";
            // 
            // StartingDatePicker
            // 
            this.StartingDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StartingDatePicker.Location = new System.Drawing.Point(746, 92);
            this.StartingDatePicker.Name = "StartingDatePicker";
            this.StartingDatePicker.Size = new System.Drawing.Size(200, 29);
            this.StartingDatePicker.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(177, 290);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(159, 46);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(12, 290);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(159, 46);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(746, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 79;
            this.label3.Text = "Expiration Date";
            // 
            // ExpirationDatePicker
            // 
            this.ExpirationDatePicker.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpirationDatePicker.Location = new System.Drawing.Point(746, 157);
            this.ExpirationDatePicker.Name = "ExpirationDatePicker";
            this.ExpirationDatePicker.Size = new System.Drawing.Size(200, 29);
            this.ExpirationDatePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(280, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 77;
            this.label2.Text = "Plan";
            // 
            // PlansComboBox
            // 
            this.PlansComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PlansComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlansComboBox.FormattingEnabled = true;
            this.PlansComboBox.Location = new System.Drawing.Point(280, 92);
            this.PlansComboBox.Name = "PlansComboBox";
            this.PlansComboBox.Size = new System.Drawing.Size(207, 29);
            this.PlansComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 21);
            this.label1.TabIndex = 75;
            this.label1.Text = "Member";
            // 
            // TrainersCheckedListBox
            // 
            this.TrainersCheckedListBox.CheckOnClick = true;
            this.TrainersCheckedListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TrainersCheckedListBox.FormattingEnabled = true;
            this.TrainersCheckedListBox.Location = new System.Drawing.Point(493, 92);
            this.TrainersCheckedListBox.Name = "TrainersCheckedListBox";
            this.TrainersCheckedListBox.Size = new System.Drawing.Size(245, 172);
            this.TrainersCheckedListBox.TabIndex = 2;
            this.TrainersCheckedListBox.Leave += new System.EventHandler(this.TrainersCheckedListBox_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(493, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 72;
            this.label10.Text = "Trainers";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(81, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 32);
            this.label8.TabIndex = 55;
            this.label8.Text = "Memberships";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.MembershipsDataGridView);
            this.panel1.Location = new System.Drawing.Point(12, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 164);
            this.panel1.TabIndex = 68;
            // 
            // MembershipsDataGridView
            // 
            this.MembershipsDataGridView.AllowUserToAddRows = false;
            this.MembershipsDataGridView.AllowUserToDeleteRows = false;
            this.MembershipsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembershipsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembershipsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.MemberId,
            this.MemberName,
            this.TrainerName,
            this.PlanId,
            this.PlanName,
            this.StartingDate,
            this.ExpirationDate,
            this.IsExpired,
            this.AutoRenew,
            this.LastRenewDate,
            this.UserId});
            this.MembershipsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MembershipsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.MembershipsDataGridView.MultiSelect = false;
            this.MembershipsDataGridView.Name = "MembershipsDataGridView";
            this.MembershipsDataGridView.ReadOnly = true;
            this.MembershipsDataGridView.RowTemplate.Height = 25;
            this.MembershipsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembershipsDataGridView.Size = new System.Drawing.Size(995, 164);
            this.MembershipsDataGridView.TabIndex = 11;
            this.MembershipsDataGridView.TabStop = false;
            this.MembershipsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MembershipsDataGridView_CellClick);
            // 
            // Id
            // 
            dataGridViewCellStyle1.Format = "d";
            this.Id.DefaultCellStyle = dataGridViewCellStyle1;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // MemberId
            // 
            this.MemberId.HeaderText = "MemberId";
            this.MemberId.Name = "MemberId";
            this.MemberId.ReadOnly = true;
            this.MemberId.Visible = false;
            // 
            // MemberName
            // 
            this.MemberName.HeaderText = "Member";
            this.MemberName.Name = "MemberName";
            this.MemberName.ReadOnly = true;
            // 
            // TrainerName
            // 
            this.TrainerName.HeaderText = "Trainers";
            this.TrainerName.Name = "TrainerName";
            this.TrainerName.ReadOnly = true;
            // 
            // PlanId
            // 
            this.PlanId.HeaderText = "PlanId";
            this.PlanId.Name = "PlanId";
            this.PlanId.ReadOnly = true;
            this.PlanId.Visible = false;
            // 
            // PlanName
            // 
            this.PlanName.HeaderText = "Plan";
            this.PlanName.Name = "PlanName";
            this.PlanName.ReadOnly = true;
            // 
            // StartingDate
            // 
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.StartingDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.StartingDate.HeaderText = "Starting Date";
            this.StartingDate.Name = "StartingDate";
            this.StartingDate.ReadOnly = true;
            // 
            // ExpirationDate
            // 
            dataGridViewCellStyle3.Format = "d";
            this.ExpirationDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExpirationDate.HeaderText = "Expiration Date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            // 
            // IsExpired
            // 
            this.IsExpired.HeaderText = "Is Expired";
            this.IsExpired.Name = "IsExpired";
            this.IsExpired.ReadOnly = true;
            // 
            // AutoRenew
            // 
            this.AutoRenew.HeaderText = "Auto Renew";
            this.AutoRenew.Name = "AutoRenew";
            this.AutoRenew.ReadOnly = true;
            // 
            // LastRenewDate
            // 
            dataGridViewCellStyle4.Format = "d";
            this.LastRenewDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.LastRenewDate.HeaderText = "Last Renew Date";
            this.LastRenewDate.Name = "LastRenewDate";
            this.LastRenewDate.ReadOnly = true;
            // 
            // UserId
            // 
            this.UserId.HeaderText = "Added By";
            this.UserId.Name = "UserId";
            this.UserId.ReadOnly = true;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(579, 290);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(159, 46);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeButton.Image = global::GMSUI.Properties.Resources.home_60x60;
            this.HomeButton.Location = new System.Drawing.Point(12, 12);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(63, 58);
            this.HomeButton.TabIndex = 0;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrintButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(848, 512);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(159, 48);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.TabStop = false;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = false;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ExpiredOnlyRadioButton
            // 
            this.ExpiredOnlyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpiredOnlyRadioButton.AutoSize = true;
            this.ExpiredOnlyRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExpiredOnlyRadioButton.Location = new System.Drawing.Point(887, 301);
            this.ExpiredOnlyRadioButton.Name = "ExpiredOnlyRadioButton";
            this.ExpiredOnlyRadioButton.Size = new System.Drawing.Size(113, 25);
            this.ExpiredOnlyRadioButton.TabIndex = 10;
            this.ExpiredOnlyRadioButton.Text = "Expired only";
            this.ExpiredOnlyRadioButton.UseVisualStyleBackColor = true;
            this.ExpiredOnlyRadioButton.CheckedChanged += new System.EventHandler(this.StaffOnlyRadioButton_CheckedChanged);
            // 
            // ActiveOnlyRadioButton
            // 
            this.ActiveOnlyRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ActiveOnlyRadioButton.AutoSize = true;
            this.ActiveOnlyRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveOnlyRadioButton.Location = new System.Drawing.Point(887, 270);
            this.ActiveOnlyRadioButton.Name = "ActiveOnlyRadioButton";
            this.ActiveOnlyRadioButton.Size = new System.Drawing.Size(111, 25);
            this.ActiveOnlyRadioButton.TabIndex = 9;
            this.ActiveOnlyRadioButton.Text = "Actives only";
            this.ActiveOnlyRadioButton.UseVisualStyleBackColor = true;
            this.ActiveOnlyRadioButton.CheckedChanged += new System.EventHandler(this.ActiveOnlyRadioButton_CheckedChanged);
            // 
            // AllRadioButton
            // 
            this.AllRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AllRadioButton.AutoSize = true;
            this.AllRadioButton.Checked = true;
            this.AllRadioButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AllRadioButton.Location = new System.Drawing.Point(887, 239);
            this.AllRadioButton.Name = "AllRadioButton";
            this.AllRadioButton.Size = new System.Drawing.Size(46, 25);
            this.AllRadioButton.TabIndex = 8;
            this.AllRadioButton.TabStop = true;
            this.AllRadioButton.Text = "All";
            this.AllRadioButton.UseVisualStyleBackColor = true;
            this.AllRadioButton.CheckedChanged += new System.EventHandler(this.AllRadioButton_CheckedChanged);
            // 
            // AutoRenewCheckBox
            // 
            this.AutoRenewCheckBox.AutoSize = true;
            this.AutoRenewCheckBox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AutoRenewCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(157)))), ((int)(((byte)(88)))));
            this.AutoRenewCheckBox.Location = new System.Drawing.Point(746, 201);
            this.AutoRenewCheckBox.Name = "AutoRenewCheckBox";
            this.AutoRenewCheckBox.Size = new System.Drawing.Size(214, 32);
            this.AutoRenewCheckBox.TabIndex = 86;
            this.AutoRenewCheckBox.Text = "Auto Renew Monthly";
            this.AutoRenewCheckBox.UseVisualStyleBackColor = true;
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 572);
            this.Controls.Add(this.AutoRenewCheckBox);
            this.Controls.Add(this.ExpiredOnlyRadioButton);
            this.Controls.Add(this.ActiveOnlyRadioButton);
            this.Controls.Add(this.AllRadioButton);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.HomeButton);
            this.Controls.Add(this.MemberNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StartingDatePicker);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.TrainersCheckedListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExpirationDatePicker);
            this.Controls.Add(this.PlansComboBox);
            this.Controls.Add(this.label2);
            this.Name = "MembershipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MembershipForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MembershipsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private CheckedListBox TrainersCheckedListBox;
    private Label label10;
    private Label label8;
    private Panel panel1;
    private DataGridView MembershipsDataGridView;
    private Button AddButton;
    private Label label1;
    private Label label3;
    private DateTimePicker ExpirationDatePicker;
    private Label label2;
    private ComboBox PlansComboBox;
    private Button DeleteButton;
    private Button UpdateButton;
    private Label label4;
    private DateTimePicker StartingDatePicker;
    private TextBox MemberNameTextBox;
    private Button HomeButton;
    private Button PrintButton;
    private RadioButton ExpiredOnlyRadioButton;
    private RadioButton ActiveOnlyRadioButton;
    private RadioButton AllRadioButton;
    private DataGridViewTextBoxColumn Id;
    private DataGridViewTextBoxColumn MemberId;
    private DataGridViewTextBoxColumn MemberName;
    private DataGridViewTextBoxColumn TrainerName;
    private DataGridViewTextBoxColumn PlanId;
    private DataGridViewTextBoxColumn PlanName;
    private DataGridViewTextBoxColumn StartingDate;
    private DataGridViewTextBoxColumn ExpirationDate;
    private DataGridViewTextBoxColumn IsExpired;
    private DataGridViewTextBoxColumn AutoRenew;
    private DataGridViewTextBoxColumn LastRenewDate;
    private DataGridViewTextBoxColumn UserId;
    private CheckBox AutoRenewCheckBox;
}
