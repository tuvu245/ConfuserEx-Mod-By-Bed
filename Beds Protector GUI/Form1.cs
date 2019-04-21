using Confuser.Core;
using Confuser.Core.Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Rule = Confuser.Core.Project.Rule;

namespace Beds_Protector_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void thirteenButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void thirteenButton2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void thirteenTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                thirteenTextBox1.Text = files[0];
            }
        }

        private void thirteenTextBox2_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length != 0)
            {
                thirteenTextBox2.Text = files[0];
            }
        }

        private void thirteenButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Since i havent added XML parsing, you will have to create a program file with confuserex with the protections you would like. Then in this program, set the project file and program file and the rest will be done. Setting protections from within this GUI will be added soon!");
        }
        string filelocation;
        string projectlocation;
        private void thirteenButton6_Click(object sender, EventArgs e)
        {
            filelocation = thirteenTextBox1.Text;
            projectlocation = thirteenTextBox2.Text;
            ConfuserProject project = new ConfuserProject(); //create a project
            project.BaseDirectory = filelocation;filelocation.TrimEnd('\\') ; //directory in which modules are found
            project.OutputDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Confused"); //output directory

            //add a module to the project
            ProjectModule module = new ProjectModule(); //create a instance of ProjectModule
            module.Path = "UnpackMe.exe"; //sets the module name

            Rule rule = new Rule("true", ProtectionPreset.None, false); //creates a Global Rule, with no preset and "true" patern, without inherit
            SettingItem<Protection> protection = new SettingItem<Protection>("ref proxy", SettingItemAction.Add); //adds protection (use short id)
            rule.Add(protection); //add protection to rule



            project.Rules.Add(rule); //add our Global rule to the project

            project.Add(module); //adds module to project

            XmlDocument doc = project.Save(); //convert our project to xml document
            doc.Save("test.crproj"); //save the xml document as a file
         
            //MessageBox.Show(Directory.GetCurrentDirectory() + "\\Unnamed.csproj");
            Process.Start("cmd.exe","/k "+ "Confuser.CLI.exe -n " + "Unnamed.crproj");
        }

        private void thirteenButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog k = new OpenFileDialog();
            DialogResult result = k.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = k.FileName;
                thirteenTextBox1.Text = file;
                try
                {
                    string text = File.ReadAllText(file);
                   
                }
                catch (IOException)
                {
                }
            }
        }

        private void thirteenButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog k = new OpenFileDialog();
            DialogResult result = k.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = k.FileName;
                thirteenTextBox2.Text = file;
                try
                {
                    string text = File.ReadAllText(file);

                }
                catch (IOException)
                {
                }
            }
        }

        private void antiTamper_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
