using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace C_A6_WF
{
    /// <summary>
    /// Data structure class for a Task.
    /// </summary>
    internal class Task
    {
        private DateTime taskDateTime;
        private string taskToDo;
        private Enums.PriorityType taskPriority;

        /// <summary>
        /// Constructor initializes instance variables.
        /// </summary>
        internal Task()
        {
            taskDateTime = DateTime.Now;
            taskToDo = string.Empty;
            taskPriority = Enums.PriorityType.Normal;
        }

        /// <summary>
        /// Properties for taskDateTime.
        /// </summary>
        internal DateTime TaskDateTime
        {
            get => taskDateTime;
            set => taskDateTime = value;
        }

        /// <summary>
        /// Properties for taskToDo.
        /// Setter contains validation-check.
        /// </summary>
        internal string TaskToDo
        {
            get => taskToDo;
            set
            {
                if (!ValidateInput.ValidateToDo(value))
                {
                    throw new ArgumentException("Task description not valid");
                }

                taskToDo = value;
            }
        }

        /// <summary>
        /// Properties for taskPriority.
        /// </summary>
        internal Enums.PriorityType TaskPriority
        {
            get => taskPriority;
            set => taskPriority = value;
        }

        /// <summary>
        /// Serializes the task data, returning it as a string.
        /// </summary>
        /// <returns>A string of the class data</returns>
        internal string SerializeTask() => $"{taskDateTime.ToString()}|{taskToDo}|{taskPriority.ToString()}\n";
    }
}
