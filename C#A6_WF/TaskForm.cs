using System.ComponentModel.DataAnnotations;
using System.Media;

namespace C_A6_WF
{
    /// <summary>
    /// Class handles GUI-manipulation and app flow logic.
    /// </summary>
    public partial class TaskForm : Form
    {
        private ToolTip toolTip;
        private TaskManager taskManager;
        private Task currentTask;
        private FileManager fileManager;
        private System.Windows.Forms.Timer timer;

        /// <summary>
        /// Constructor calls several methods to init and config parts of the GUI.
        /// </summary>
        public TaskForm()
        {
            InitializeComponent();
            toDoListBox.SelectedIndexChanged += ToggleButtonsOnSelect!;
            InitInstanceVariables();
            InitConfigTimer();
            LoadPriorityComboBox();
            ConfigDateTimePicker();
            ConfigToolTip();
            ToggleButtons(false);
        }

        /// <summary>
        /// Inits instance variables.
        /// </summary>
        private void InitInstanceVariables()
        {
            taskManager = new();
            currentTask = new();
            fileManager = new();
            toolTip = new();
        }

        /// <summary>
        /// Sets a tooltip and configures it.
        /// </summary>
        private void ConfigToolTip() => toolTip.SetToolTip(dateTimePicker, "Pick the date for the task");

        /// <summary>
        /// Configures the dateTimePicker-control.
        /// </summary>
        private void ConfigDateTimePicker() => dateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";

        /// <summary>
        /// Inits timer object, configures it and subscribes its Tick-event to a display-method.
        /// </summary>
        private void InitConfigTimer()
        {
            timer = new();

            timer.Enabled = true;
            timer.Interval = 100;

            timer.Tick += TickToLabel!;
        }

        /// <summary>
        /// Loads the priorityTypes to the comboBox, replacing underscores.
        /// </summary>
        private void LoadPriorityComboBox()
        {
            foreach (var priority in Enum.GetNames(typeof(Enums.PriorityType)))
            {
                priorityComboBox.Items.Add(priority.ToString().Replace("_", " "));
            }

            //Select "Normal" per default
            priorityComboBox.SelectedIndex = 2;
        }

        /// <summary>
        /// Reacts to Exit-click in menu.
        /// Prompts the user for OK/CANCEL on whether to close the app.
        /// If OK: closes app. If CANCEL: stays.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitAltF4ToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            DialogResult exitOrNot = MessageBox.Show("Exit?",
                "Exit?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (exitOrNot == DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Reacts to "New" click in menu.
        /// Prompts the user for YES/NO on whether to reset to a new task-collection.
        /// If YES: Resets all fields, currentask and taskmanager. If NO: stays.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult newOrNot = MessageBox.Show("Do you want to reset the taskmanager?\nUnsaved changes will be lost.",
                "New?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (newOrNot == DialogResult.Yes)
            {
                ResetAll();
            }
        }
        
        /// <summary>
        /// Reacts to "Open Data File" click in menu.
        /// Lets the user choose a file through OpenFileDialog.
        /// Calls fileManager to retrieve file, the deserializes it and updates the toDoListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Open File",
                Filter = "Text Files (*.txt)|*.txt",
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                string serializedTasks = fileManager.TryReadFile(selectedFilePath);

                if (serializedTasks == "File not found" || serializedTasks == "Something went wrong")
                {
                    MessageBox.Show($"{serializedTasks}",
                        "Something went wrong",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                taskManager.DeSerializeTasks(serializedTasks);

                UpdateToDoListBox();
            }
        }

        /// <summary>
        /// Reacts to "Save Data File" click in menu.
        /// Lets the user select a file name and location through SaveFileDialog.
        /// Calls fileManager to save the file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveDataFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Title = "Save file",
                Filter = "Text Files (*.txt)|*.txt",
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = saveFileDialog.FileName;

                string message = fileManager.TrySaveFile(taskManager.SerializeTasks(), selectedFilePath);

                if (message == "File not found" || message == "Something went wrong")
                {
                    MessageBox.Show($"{message}",
                        "Something went wrong",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show($"{message}",
                    "Successful save",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Reacts to click of the Add-button.
        /// Tries to add a task, prompts the user with error message if something goes wrong.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                currentTask.TaskToDo = toDoTextBox.Text;
                currentTask.TaskDateTime = dateTimePicker.Value;
                currentTask.TaskPriority = (Enums.PriorityType)Enum.Parse(typeof(Enums.PriorityType), priorityComboBox.SelectedIndex.ToString());
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show("Something went wrong\nErrorMessages:\n" + ae.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            taskManager.AddTask(currentTask);
            ResetInputControls();
            currentTask = new();
            toDoListBox.SelectedIndex = -1;
            UpdateToDoListBox();
        }

        /// <summary>
        /// Reacts to click of the Change-button.
        /// Gets and sets the task as the one currently being manipulated.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (toDoListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No user selected for change",
                    "No user selected!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            currentTask = taskManager.GetTask(toDoListBox.SelectedIndex);

            LoadChangeTask(currentTask);
        }

        /// <summary>
        /// Reacts to click of Delete-button.
        /// Calls taskManager to delete the chosen task.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (toDoListBox.SelectedIndex == -1)
            {
                MessageBox.Show("No user selected for termination",
                    "No user selected!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            DialogResult deleteOrNot = MessageBox.Show("Are you sure you want to delete this task?",
                "Delete task?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (deleteOrNot == DialogResult.Yes)
            {
                int taskToDeleteIndex = toDoListBox.SelectedIndex;
                taskManager.DeleteTask(taskToDeleteIndex);
                UpdateToDoListBox();
            }
        }

        /// <summary>
        /// Updates the toDoListBox.
        /// </summary>
        private void UpdateToDoListBox()
        {
            toDoListBox.Items.Clear();

            for (int i = 0; i < taskManager.Tasks.Count; i++)
            {
                string formattedString = string.Format("{0, -30}{1, -7}{2, -17}{3, -50}",
                    taskManager.Tasks[i].TaskDateTime.ToLongDateString(),
                    taskManager.Tasks[i].TaskDateTime.ToShortTimeString(),
                    taskManager.Tasks[i].TaskPriority.ToString().Replace("_", " "),
                    taskManager.Tasks[i].TaskToDo);

                toDoListBox.Items.Add(formattedString);
            }

            ToggleButtonsOnToDoListChange(this, EventArgs.Empty);
        }

        /// <summary>
        /// Toggles buttons if item is selected in the toDoListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleButtonsOnSelect(object sender, EventArgs e)
        {
            if (toDoListBox.Items.Count > 0 && toDoListBox.SelectedIndex != -1)
            {
                ToggleButtons(true);
            }
            else
            {
                ToggleButtons(false);
            }
        }

        /// <summary>
        /// Toggles buttons to off if there are no items in the toDoListBox or if none are selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToggleButtonsOnToDoListChange(object sender, EventArgs e)
        {
            if (toDoListBox.Items.Count <= 0 && toDoListBox.SelectedIndex == -1)
            {
                ToggleButtons(false);
            }
        }

        /// <summary>
        /// Toggles change and delete buttons on or off depending on the boolean value passed to the method.
        /// </summary>
        /// <param name="onOrOff"></param>
        private void ToggleButtons(bool onOrOff)
        {
            if (onOrOff)
            {
                changeButton.Enabled = true;
                deleteButton.Enabled = true;
            }
            else
            {
                changeButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        /// <summary>
        /// Loads the specific data of a task to the input controls.
        /// </summary>
        /// <param name="taskIn">The instance of task to be loaded</param>
        private void LoadChangeTask(Task taskIn)
        {
            dateTimePicker.Value = taskIn.TaskDateTime;
            priorityComboBox.SelectedItem = (Enums.PriorityType)taskIn.TaskPriority;
            toDoTextBox.Text = taskIn.TaskToDo;

            addButton.Text = "Change";
        }

        /// <summary>
        /// Resets the input-controls.
        /// </summary>
        private void ResetInputControls()
        {
            dateTimePicker.Value = DateTime.Now;
            toDoTextBox.Clear();
            priorityComboBox.SelectedIndex = 2;
            addButton.Text = "Add";
        }

        /// <summary>
        /// Resets all input controls, initializes new instance variables.
        /// </summary>
        private void ResetAll()
        {
            ResetInputControls();
            currentTask = new();
            taskManager = new();
            UpdateToDoListBox();
        }

        /// <summary>
        /// Reacts with every tick of the timer and updates the time to "now".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TickToLabel(object sender, EventArgs e) => timerLabel.Text = DateTime.Now.ToString("HH:mm:ss");

        /// <summary>
        /// Reacts to click of About-button in menu.
        /// Displays the about-form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new();
            aboutForm.Show();
        }
    }
}
