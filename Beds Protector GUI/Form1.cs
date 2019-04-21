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
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Rule = Confuser.Core.Project.Rule;

namespace Beds_Protector_GUI
{
    public partial class Form1 : Form
    {
        ConfuserProject proj;
        CancellationTokenSource cancelSrc;
        public Form1()
        {
            InitializeComponent();
            string version = "Could no connect to server";
            try
            {
                version = new WebClient().DownloadString("https://pastebin.com/raw/rQUCwMmL");
            }
            catch
            {
            }
            thirteenForm1.Text += version;
            proj = new ConfuserProject();
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
           
        }

        private void thirteenButton5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Simply click browse and choose your file or drag/drop it into the test box , then choose protections and hit protect. Output will be in the \\ Confused folder of the input file");
        }
        string filelocation;
        string projectlocation;
        private void thirteenButton6_Click(object sender, EventArgs e)
        {
            filelocation = thirteenTextBox1.Text;

            ConfuserProject project = new ConfuserProject(); //create a project
            project.BaseDirectory = Path.GetDirectoryName(filelocation);
            project.OutputDirectory = Path.Combine(Path.GetDirectoryName(filelocation) + @"\Confused"); //output directory

            //add a module to the project
            ProjectModule module = new ProjectModule(); //create a instance of ProjectModule
            module.Path = Path.GetFileName(filelocation); //sets the module name]
            project.Add(module); //adds module to project

            Rule rule = new Rule("true", ProtectionPreset.None, false); //creates a Global Rule, with no preset and "true" patern, without inherit

            if (antiTamper.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("anti tamper", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (antiDebug.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("anti debug", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (antiDump.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("anti dump", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (calli.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("Calli Protection", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (constants.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("constants", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (controlFlow.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("ctrl flow", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (invalidMetadat.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("invalid metadata", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (renamer.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("rename", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (refProxy.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("ref proxy", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (mildRefProxy.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("Clean ref proxy", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (moduleFlood.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("module flood", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (fakeNative.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("Fake Native", SettingItemAction.Add);
                rule.Add(protection);
            }
            if (renameAssembly.Checked)
            {
                SettingItem<Protection> protection = new SettingItem<Protection>("Rename Module", SettingItemAction.Add);
                rule.Add(protection);
            }

            project.Rules.Add(rule); //add our Global rule to the project 

            XmlDocument doc = project.Save(); //convert our project to xml document
            doc.Save("temp.crproj"); //save the xml document as a file


            Process.Start("Confuser.CLI.exe", "-n temp.crproj").WaitForExit();
            File.Delete("temp.crproj");
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
          
        }

        private void antiTamper_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                antiDebug.Checked = true;
                antiDump.Checked = true;
                antiTamper.Checked = true;
                renameAssembly.Checked = true;
                renamer.Checked = true;
                constants.Checked = true;
                controlFlow.Checked = true;
                moduleFlood.Checked = true;
                refProxy.Checked = true;
                mildRefProxy.Checked = true;
                calli.Checked = true;
            }
            else
            {
                antiDebug.Checked = false;
                antiDump.Checked = false;
                antiTamper.Checked = false;
                renameAssembly.Checked = false;
                renamer.Checked = false;
                constants.Checked = false;
                controlFlow.Checked = false;
                moduleFlood.Checked = false;
                refProxy.Checked = false;
                mildRefProxy.Checked = false;
                calli.Checked = false;
            }

        }

        private void pictureBox1_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void thirteenForm1_Click(object sender, EventArgs e)
        {

        }

        private void thirteenButton4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Simply click browse and choose your file , then choose protections and hit protect. Output will be in the \\ Confused folder of the input file");
        }
    }
}
