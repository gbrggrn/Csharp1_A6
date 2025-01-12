using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace C_A6_WF
{
    /// <summary>
    /// Controls for the AboutForm.
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Constructor calls InitializeComponent and the load-method.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();

            AboutFormLoad();
        }

        /// <summary>
        /// Saves metadata to strings and displays these.
        /// </summary>
        private void AboutFormLoad()
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();

            string title = thisAssembly.GetCustomAttribute<AssemblyTitleAttribute>()?.Title;
            string version = thisAssembly.GetName().Version.ToString();
            string author = thisAssembly.GetCustomAttribute<AssemblyCompanyAttribute>()?.Company;
            string description = thisAssembly.GetCustomAttribute<AssemblyDescriptionAttribute>()?.Description;

            appNameLabel.Text = title;
            versionLabel.Text = version;
            authorLabel.Text = author;
            descriptionLabel.Text = description;
        }

        /// <summary>
        /// Reacts to close-button-click. Closes the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
