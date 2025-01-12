namespace C_A6_WF
{
    partial class TaskForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listGroupBox = new GroupBox();
            descriptionDisplayLabel = new Label();
            priorityDisplayLabel = new Label();
            hourLabel = new Label();
            dateLabel = new Label();
            toDoListBox = new ListBox();
            changeButton = new Button();
            deleteButton = new Button();
            addButton = new Button();
            toDoTextBox = new TextBox();
            priorityComboBox = new ComboBox();
            dateTimePicker = new DateTimePicker();
            appMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openDataFileToolStripMenuItem = new ToolStripMenuItem();
            saveDataFileToolStripMenuItem = new ToolStripMenuItem();
            exitAltF4ToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            dateTimeLabel = new Label();
            toDoLabel = new Label();
            priorityLabel = new Label();
            timerLabel = new Label();
            listGroupBox.SuspendLayout();
            appMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // listGroupBox
            // 
            listGroupBox.Controls.Add(descriptionDisplayLabel);
            listGroupBox.Controls.Add(priorityDisplayLabel);
            listGroupBox.Controls.Add(hourLabel);
            listGroupBox.Controls.Add(dateLabel);
            listGroupBox.Controls.Add(toDoListBox);
            listGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listGroupBox.ForeColor = Color.ForestGreen;
            listGroupBox.Location = new Point(12, 129);
            listGroupBox.Name = "listGroupBox";
            listGroupBox.Size = new Size(815, 280);
            listGroupBox.TabIndex = 0;
            listGroupBox.TabStop = false;
            listGroupBox.Text = "To do";
            // 
            // descriptionDisplayLabel
            // 
            descriptionDisplayLabel.AutoSize = true;
            descriptionDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descriptionDisplayLabel.ForeColor = SystemColors.ActiveCaptionText;
            descriptionDisplayLabel.Location = new Point(435, 27);
            descriptionDisplayLabel.Name = "descriptionDisplayLabel";
            descriptionDisplayLabel.Size = new Size(67, 15);
            descriptionDisplayLabel.TabIndex = 14;
            descriptionDisplayLabel.Text = "Description";
            // 
            // priorityDisplayLabel
            // 
            priorityDisplayLabel.AutoSize = true;
            priorityDisplayLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityDisplayLabel.ForeColor = SystemColors.ActiveCaptionText;
            priorityDisplayLabel.Location = new Point(278, 27);
            priorityDisplayLabel.Name = "priorityDisplayLabel";
            priorityDisplayLabel.Size = new Size(45, 15);
            priorityDisplayLabel.TabIndex = 13;
            priorityDisplayLabel.Text = "Priority";
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hourLabel.ForeColor = SystemColors.ActiveCaptionText;
            hourLabel.Location = new Point(214, 27);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new Size(34, 15);
            hourLabel.TabIndex = 12;
            hourLabel.Text = "Hour";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateLabel.ForeColor = SystemColors.ActiveCaptionText;
            dateLabel.Location = new Point(22, 27);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(31, 15);
            dateLabel.TabIndex = 11;
            dateLabel.Text = "Date";
            // 
            // toDoListBox
            // 
            toDoListBox.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            toDoListBox.FormattingEnabled = true;
            toDoListBox.ItemHeight = 15;
            toDoListBox.Location = new Point(6, 45);
            toDoListBox.Name = "toDoListBox";
            toDoListBox.Size = new Size(803, 229);
            toDoListBox.TabIndex = 0;
            // 
            // changeButton
            // 
            changeButton.FlatStyle = FlatStyle.Popup;
            changeButton.Location = new Point(49, 415);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(126, 23);
            changeButton.TabIndex = 1;
            changeButton.Text = "Change";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += ChangeButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.FlatStyle = FlatStyle.Popup;
            deleteButton.Location = new Point(226, 415);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(126, 23);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += DeleteButton_Click;
            // 
            // addButton
            // 
            addButton.BackColor = SystemColors.ButtonShadow;
            addButton.FlatStyle = FlatStyle.Popup;
            addButton.Location = new Point(226, 100);
            addButton.Name = "addButton";
            addButton.Size = new Size(126, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += AddButton_Click;
            // 
            // toDoTextBox
            // 
            toDoTextBox.Location = new Point(75, 70);
            toDoTextBox.Name = "toDoTextBox";
            toDoTextBox.Size = new Size(530, 23);
            toDoTextBox.TabIndex = 4;
            // 
            // priorityComboBox
            // 
            priorityComboBox.BackColor = SystemColors.ButtonShadow;
            priorityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            priorityComboBox.FormattingEnabled = true;
            priorityComboBox.Location = new Point(484, 41);
            priorityComboBox.Name = "priorityComboBox";
            priorityComboBox.Size = new Size(121, 23);
            priorityComboBox.TabIndex = 5;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.Location = new Point(152, 38);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 6;
            // 
            // appMenuStrip
            // 
            appMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            appMenuStrip.Location = new Point(0, 0);
            appMenuStrip.Name = "appMenuStrip";
            appMenuStrip.Size = new Size(839, 24);
            appMenuStrip.TabIndex = 7;
            appMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openDataFileToolStripMenuItem, saveDataFileToolStripMenuItem, exitAltF4ToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(167, 22);
            newToolStripMenuItem.Text = "New        Ctrl + N";
            newToolStripMenuItem.Click += NewToolStripMenuItem_Click;
            // 
            // openDataFileToolStripMenuItem
            // 
            openDataFileToolStripMenuItem.Name = "openDataFileToolStripMenuItem";
            openDataFileToolStripMenuItem.Size = new Size(167, 22);
            openDataFileToolStripMenuItem.Text = "Open data file";
            openDataFileToolStripMenuItem.Click += OpenDataFileToolStripMenuItem_Click;
            // 
            // saveDataFileToolStripMenuItem
            // 
            saveDataFileToolStripMenuItem.Name = "saveDataFileToolStripMenuItem";
            saveDataFileToolStripMenuItem.Size = new Size(167, 22);
            saveDataFileToolStripMenuItem.Text = "Save data file";
            saveDataFileToolStripMenuItem.Click += SaveDataFileToolStripMenuItem_Click;
            // 
            // exitAltF4ToolStripMenuItem
            // 
            exitAltF4ToolStripMenuItem.Name = "exitAltF4ToolStripMenuItem";
            exitAltF4ToolStripMenuItem.Size = new Size(167, 22);
            exitAltF4ToolStripMenuItem.Text = "Exit           Alt + F4";
            exitAltF4ToolStripMenuItem.Click += ExitAltF4ToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(44, 20);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(180, 22);
            aboutToolStripMenuItem1.Text = "About...";
            aboutToolStripMenuItem1.Click += AboutToolStripMenuItem1_Click;
            // 
            // dateTimeLabel
            // 
            dateTimeLabel.AutoSize = true;
            dateTimeLabel.Location = new Point(12, 41);
            dateTimeLabel.Name = "dateTimeLabel";
            dateTimeLabel.Size = new Size(81, 15);
            dateTimeLabel.TabIndex = 8;
            dateTimeLabel.Text = "Date and time";
            // 
            // toDoLabel
            // 
            toDoLabel.AutoSize = true;
            toDoLabel.Location = new Point(12, 73);
            toDoLabel.Name = "toDoLabel";
            toDoLabel.Size = new Size(36, 15);
            toDoLabel.TabIndex = 9;
            toDoLabel.Text = "To do";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new Point(433, 46);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new Size(45, 15);
            priorityLabel.TabIndex = 10;
            priorityLabel.Text = "Priority";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timerLabel.ForeColor = SystemColors.MenuHighlight;
            timerLabel.Location = new Point(643, 419);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(0, 19);
            timerLabel.TabIndex = 11;
            // 
            // TaskForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(839, 450);
            Controls.Add(timerLabel);
            Controls.Add(priorityLabel);
            Controls.Add(toDoLabel);
            Controls.Add(dateTimeLabel);
            Controls.Add(dateTimePicker);
            Controls.Add(priorityComboBox);
            Controls.Add(toDoTextBox);
            Controls.Add(addButton);
            Controls.Add(deleteButton);
            Controls.Add(changeButton);
            Controls.Add(listGroupBox);
            Controls.Add(appMenuStrip);
            Name = "TaskForm";
            Text = "ToDo Reminder by <Gustaf Berggren>";
            listGroupBox.ResumeLayout(false);
            listGroupBox.PerformLayout();
            appMenuStrip.ResumeLayout(false);
            appMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox listGroupBox;
        private ListBox toDoListBox;
        private Button changeButton;
        private Button deleteButton;
        private Button addButton;
        private TextBox toDoTextBox;
        private ComboBox priorityComboBox;
        private DateTimePicker dateTimePicker;
        private MenuStrip appMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openDataFileToolStripMenuItem;
        private ToolStripMenuItem saveDataFileToolStripMenuItem;
        private ToolStripMenuItem exitAltF4ToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label dateTimeLabel;
        private Label toDoLabel;
        private Label priorityLabel;
        private Label descriptionDisplayLabel;
        private Label priorityDisplayLabel;
        private Label hourLabel;
        private Label dateLabel;
        private Label timerLabel;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}
