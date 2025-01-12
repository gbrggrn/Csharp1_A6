using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_A6_WF
{
    /// <summary>
    /// Class handles the collection of tasks.
    /// </summary>
    internal class TaskManager
    {
        private List<Task> tasks;

        /// <summary>
        /// Constructor inits a new collection of tasks.
        /// </summary>
        internal TaskManager()
        {
            tasks = new();
        }

        /// <summary>
        /// Get-property for tasks.
        /// </summary>
        internal List<Task> Tasks => tasks;

        /// <summary>
        /// Checks if task is being changed, if yes: replaces.
        /// Otherwise saves new task to end of collection.
        /// </summary>
        /// <param name="currentTaskIn">The current task being manipulated/handled</param>
        internal void AddTask(Task currentTaskIn)
        {
            if (tasks.Contains(currentTaskIn))
            {
                int indexToSaveChange = tasks.IndexOf(currentTaskIn);
                tasks[indexToSaveChange] = currentTaskIn;
            }
            else
            {
                tasks.Add(currentTaskIn);

            }
        }

        /// <summary>
        /// Deletes a chosen task.
        /// </summary>
        /// <param name="taskToDeleteIndexIn">Index of the task to be deleted</param>
        internal void DeleteTask(int taskToDeleteIndexIn)
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                if (tasks[i] == tasks[taskToDeleteIndexIn])
                {
                    tasks.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Aggregates all task data into one single serialized string.
        /// </summary>
        /// <returns>The string containing all task data</returns>
        internal string SerializeTasks()
        {
            string serializedTasks = string.Empty;

            foreach (Task task in tasks)
            {
                serializedTasks += task.SerializeTask();
            }

            return serializedTasks;
        }

        /// <summary>
        /// Splits the input data and loads it into tasks, then adds those tasks to the list.
        /// </summary>
        /// <param name="serializedTasksIn">A string of text from the .txt-file being opened</param>
        internal void DeSerializeTasks(string serializedTasksIn)
        {
            //First split into task-specific data, leaves empty element at the end of array
            string[] firstSplit = serializedTasksIn.Split('\n');

            //Copy all except last element, since that is empty
            string[] firstSplitLastRemoved = firstSplit.Take(firstSplit.Length - 1).ToArray();

            tasks = new();

            for (int i = 0; i < firstSplitLastRemoved.Length; i++)
            {
                string taskString = firstSplitLastRemoved[i].Trim();

                string[] secondSplit = taskString.Split("|");

                Task task = new Task();

                //Parse DateTime and add to task
                if (DateTime.TryParseExact(secondSplit[0].Trim(), 
                    "yyyy-MM-dd HH:mm:ss",
                    System.Globalization.CultureInfo.InvariantCulture, 
                    System.Globalization.DateTimeStyles.None, 
                    out DateTime parsedTaskDate))
                {
                    task.TaskDateTime = parsedTaskDate;
                }
                else
                {
                    task.TaskDateTime = DateTime.Now;
                }

                //Add to do description to task
                task.TaskToDo = secondSplit[1].Trim();

                //Add priority to task
                task.TaskPriority = (Enums.PriorityType)Enum.Parse(typeof(Enums.PriorityType), secondSplit[2].Trim());

                //Add task to list
                tasks.Add(task);
            }
        }

        /// <summary>
        /// Getter specified by index.
        /// </summary>
        /// <param name="taskToGetIn">Index of the task to get</param>
        /// <returns>The task corresponding to the index given</returns>
        internal Task GetTask(int taskToGetIn) => tasks[taskToGetIn];
    }
}
