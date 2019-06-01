using System.Net;

namespace Beds_Protector_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
        private System.ComponentModel.IContainer components = null;
    
          
/// <summary>
/// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.thirteenForm1 = new Teen.ThirteenForm();
            this.thirteenTabControl1 = new Teen.ThirteenTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.thirteenButton4 = new Teen.ThirteenButton();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.thirteenTextBox1 = new Teen.ThirteenTextBox();
            this.thirteenButton6 = new Teen.ThirteenButton();
            this.thirteenButton3 = new Teen.ThirteenButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.local2field = new System.Windows.Forms.CheckBox();
            this.mutations = new System.Windows.Forms.CheckBox();
            this.renameAssembly = new System.Windows.Forms.CheckBox();
            this.fakeNative = new System.Windows.Forms.CheckBox();
            this.moduleFlood = new System.Windows.Forms.CheckBox();
            this.mildRefProxy = new System.Windows.Forms.CheckBox();
            this.refProxy = new System.Windows.Forms.CheckBox();
            this.renamer = new System.Windows.Forms.CheckBox();
            this.invalidMetadat = new System.Windows.Forms.CheckBox();
            this.controlFlow = new System.Windows.Forms.CheckBox();
            this.constants = new System.Windows.Forms.CheckBox();
            this.calli = new System.Windows.Forms.CheckBox();
            this.antiDebug = new System.Windows.Forms.CheckBox();
            this.antiTamper = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.thirteenButton2 = new Teen.ThirteenButton();
            this.thirteenButton1 = new Teen.ThirteenButton();
            this.hideMethods = new System.Windows.Forms.CheckBox();
            this.thirteenForm1.SuspendLayout();
            this.thirteenTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // thirteenForm1
            // 
            this.thirteenForm1.AccentColor = System.Drawing.Color.Crimson;
            this.thirteenForm1.AllowDrop = true;
            this.thirteenForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenForm1.ColorScheme = Teen.ThirteenForm.ColorSchemes.Dark;
            this.thirteenForm1.Controls.Add(this.thirteenTabControl1);
            this.thirteenForm1.Controls.Add(this.thirteenButton2);
            this.thirteenForm1.Controls.Add(this.thirteenButton1);
            this.thirteenForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirteenForm1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenForm1.ForeColor = System.Drawing.Color.White;
            this.thirteenForm1.Location = new System.Drawing.Point(0, 0);
            this.thirteenForm1.Name = "thirteenForm1";
            this.thirteenForm1.Size = new System.Drawing.Size(831, 464);
            this.thirteenForm1.TabIndex = 0;
            this.thirteenForm1.Text = "Beds Protector | GUI";
            this.thirteenForm1.Click += new System.EventHandler(this.thirteenForm1_Click);
            this.thirteenForm1.DragDrop += new System.Windows.Forms.DragEventHandler(this.thirteenTextBox1_DragDrop);
            // 
            // thirteenTabControl1
            // 
            this.thirteenTabControl1.AccentColor = System.Drawing.Color.Crimson;
            this.thirteenTabControl1.ColorScheme = Teen.ThirteenTabControl.ColorSchemes.Dark;
            this.thirteenTabControl1.Controls.Add(this.tabPage1);
            this.thirteenTabControl1.Controls.Add(this.tabPage2);
            this.thirteenTabControl1.ForeColor = System.Drawing.Color.White;
            this.thirteenTabControl1.Location = new System.Drawing.Point(0, 33);
            this.thirteenTabControl1.Name = "thirteenTabControl1";
            this.thirteenTabControl1.SelectedIndex = 0;
            this.thirteenTabControl1.Size = new System.Drawing.Size(832, 433);
            this.thirteenTabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(824, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Protection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "           ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(167, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox2.Controls.Add(this.thirteenButton4);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.thirteenTextBox1);
            this.groupBox2.Controls.Add(this.thirteenButton6);
            this.groupBox2.Controls.Add(this.thirteenButton3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(42, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 121);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input/Output";
            this.groupBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.thirteenTextBox1_DragDrop);
            // 
            // thirteenButton4
            // 
            this.thirteenButton4.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton4.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton4.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton4.ForeColor = System.Drawing.Color.White;
            this.thirteenButton4.Location = new System.Drawing.Point(324, 41);
            this.thirteenButton4.Name = "thirteenButton4";
            this.thirteenButton4.Size = new System.Drawing.Size(25, 24);
            this.thirteenButton4.TabIndex = 14;
            this.thirteenButton4.Text = "?";
            this.thirteenButton4.UseVisualStyleBackColor = false;
            this.thirteenButton4.Click += new System.EventHandler(this.thirteenButton4_Click_1);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(235, 84);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(94, 21);
            this.checkBox4.TabIndex = 13;
            this.checkBox4.Text = "Dank Preset";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // thirteenTextBox1
            // 
            this.thirteenTextBox1.AllowDrop = true;
            this.thirteenTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.thirteenTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirteenTextBox1.ColorScheme = Teen.ThirteenTextBox.ColorSchemes.Dark;
            this.thirteenTextBox1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenTextBox1.ForeColor = System.Drawing.Color.White;
            this.thirteenTextBox1.Location = new System.Drawing.Point(52, 41);
            this.thirteenTextBox1.Name = "thirteenTextBox1";
            this.thirteenTextBox1.Size = new System.Drawing.Size(177, 25);
            this.thirteenTextBox1.TabIndex = 3;
            this.thirteenTextBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.thirteenTextBox1_DragDrop);
            this.thirteenTextBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.thirteenTextBox1_DragEnter);
            // 
            // thirteenButton6
            // 
            this.thirteenButton6.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton6.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton6.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton6.ForeColor = System.Drawing.Color.White;
            this.thirteenButton6.Location = new System.Drawing.Point(52, 78);
            this.thirteenButton6.Name = "thirteenButton6";
            this.thirteenButton6.Size = new System.Drawing.Size(177, 30);
            this.thirteenButton6.TabIndex = 10;
            this.thirteenButton6.Text = "Protect";
            this.thirteenButton6.UseVisualStyleBackColor = false;
            this.thirteenButton6.Click += new System.EventHandler(this.thirteenButton6_Click);
            // 
            // thirteenButton3
            // 
            this.thirteenButton3.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton3.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton3.ForeColor = System.Drawing.Color.White;
            this.thirteenButton3.Location = new System.Drawing.Point(235, 41);
            this.thirteenButton3.Name = "thirteenButton3";
            this.thirteenButton3.Size = new System.Drawing.Size(90, 24);
            this.thirteenButton3.TabIndex = 8;
            this.thirteenButton3.Text = "Browse";
            this.thirteenButton3.UseVisualStyleBackColor = false;
            this.thirteenButton3.Click += new System.EventHandler(this.thirteenButton3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "File to be Obfuscated: (Drag/Drop Supported)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.groupBox1.Controls.Add(this.hideMethods);
            this.groupBox1.Controls.Add(this.local2field);
            this.groupBox1.Controls.Add(this.mutations);
            this.groupBox1.Controls.Add(this.renameAssembly);
            this.groupBox1.Controls.Add(this.fakeNative);
            this.groupBox1.Controls.Add(this.moduleFlood);
            this.groupBox1.Controls.Add(this.mildRefProxy);
            this.groupBox1.Controls.Add(this.refProxy);
            this.groupBox1.Controls.Add(this.renamer);
            this.groupBox1.Controls.Add(this.invalidMetadat);
            this.groupBox1.Controls.Add(this.controlFlow);
            this.groupBox1.Controls.Add(this.constants);
            this.groupBox1.Controls.Add(this.calli);
            this.groupBox1.Controls.Add(this.antiDebug);
            this.groupBox1.Controls.Add(this.antiTamper);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(428, 211);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protections";
            // 
            // local2field
            // 
            this.local2field.AutoSize = true;
            this.local2field.Location = new System.Drawing.Point(127, 141);
            this.local2field.Name = "local2field";
            this.local2field.Size = new System.Drawing.Size(111, 21);
            this.local2field.TabIndex = 14;
            this.local2field.Text = "Locals to Fields";
            this.local2field.UseVisualStyleBackColor = true;
            this.local2field.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // mutations
            // 
            this.mutations.AutoSize = true;
            this.mutations.Location = new System.Drawing.Point(16, 141);
            this.mutations.Name = "mutations";
            this.mutations.Size = new System.Drawing.Size(82, 21);
            this.mutations.TabIndex = 13;
            this.mutations.Text = "Mutations";
            this.mutations.UseVisualStyleBackColor = true;
            // 
            // renameAssembly
            // 
            this.renameAssembly.AutoSize = true;
            this.renameAssembly.Location = new System.Drawing.Point(247, 90);
            this.renameAssembly.Name = "renameAssembly";
            this.renameAssembly.Size = new System.Drawing.Size(129, 21);
            this.renameAssembly.TabIndex = 12;
            this.renameAssembly.Text = "Rename Assembly";
            this.renameAssembly.UseVisualStyleBackColor = true;
            // 
            // fakeNative
            // 
            this.fakeNative.AutoSize = true;
            this.fakeNative.Location = new System.Drawing.Point(247, 63);
            this.fakeNative.Name = "fakeNative";
            this.fakeNative.Size = new System.Drawing.Size(93, 21);
            this.fakeNative.TabIndex = 11;
            this.fakeNative.Text = "Fake Native";
            this.fakeNative.UseVisualStyleBackColor = true;
            // 
            // moduleFlood
            // 
            this.moduleFlood.AutoSize = true;
            this.moduleFlood.Location = new System.Drawing.Point(247, 36);
            this.moduleFlood.Name = "moduleFlood";
            this.moduleFlood.Size = new System.Drawing.Size(103, 21);
            this.moduleFlood.TabIndex = 10;
            this.moduleFlood.Text = "Module Flood";
            this.moduleFlood.UseVisualStyleBackColor = true;
            // 
            // mildRefProxy
            // 
            this.mildRefProxy.AutoSize = true;
            this.mildRefProxy.Location = new System.Drawing.Point(247, 114);
            this.mildRefProxy.Name = "mildRefProxy";
            this.mildRefProxy.Size = new System.Drawing.Size(107, 21);
            this.mildRefProxy.TabIndex = 9;
            this.mildRefProxy.Text = "Mild Ref Proxy";
            this.mildRefProxy.UseVisualStyleBackColor = true;
            // 
            // refProxy
            // 
            this.refProxy.AutoSize = true;
            this.refProxy.Location = new System.Drawing.Point(127, 114);
            this.refProxy.Name = "refProxy";
            this.refProxy.Size = new System.Drawing.Size(117, 21);
            this.refProxy.TabIndex = 8;
            this.refProxy.Text = "Reference Proxy";
            this.refProxy.UseVisualStyleBackColor = true;
            // 
            // renamer
            // 
            this.renamer.AutoSize = true;
            this.renamer.Location = new System.Drawing.Point(127, 87);
            this.renamer.Name = "renamer";
            this.renamer.Size = new System.Drawing.Size(77, 21);
            this.renamer.TabIndex = 7;
            this.renamer.Text = "Renamer";
            this.renamer.UseVisualStyleBackColor = true;
            // 
            // invalidMetadat
            // 
            this.invalidMetadat.AutoSize = true;
            this.invalidMetadat.Location = new System.Drawing.Point(127, 63);
            this.invalidMetadat.Name = "invalidMetadat";
            this.invalidMetadat.Size = new System.Drawing.Size(121, 21);
            this.invalidMetadat.TabIndex = 6;
            this.invalidMetadat.Text = "Invalid Metadata";
            this.invalidMetadat.UseVisualStyleBackColor = true;
            // 
            // controlFlow
            // 
            this.controlFlow.AutoSize = true;
            this.controlFlow.Location = new System.Drawing.Point(127, 36);
            this.controlFlow.Name = "controlFlow";
            this.controlFlow.Size = new System.Drawing.Size(96, 21);
            this.controlFlow.TabIndex = 5;
            this.controlFlow.Text = "Control Flow";
            this.controlFlow.UseVisualStyleBackColor = true;
            // 
            // constants
            // 
            this.constants.AutoSize = true;
            this.constants.Location = new System.Drawing.Point(16, 114);
            this.constants.Name = "constants";
            this.constants.Size = new System.Drawing.Size(81, 21);
            this.constants.TabIndex = 4;
            this.constants.Text = "Constants";
            this.constants.UseVisualStyleBackColor = true;
            // 
            // calli
            // 
            this.calli.AutoSize = true;
            this.calli.Location = new System.Drawing.Point(16, 87);
            this.calli.Name = "calli";
            this.calli.Size = new System.Drawing.Size(91, 21);
            this.calli.TabIndex = 3;
            this.calli.Text = "Calli to Call";
            this.calli.UseVisualStyleBackColor = true;
            // 
            // antiDebug
            // 
            this.antiDebug.AutoSize = true;
            this.antiDebug.Location = new System.Drawing.Point(16, 60);
            this.antiDebug.Name = "antiDebug";
            this.antiDebug.Size = new System.Drawing.Size(90, 21);
            this.antiDebug.TabIndex = 1;
            this.antiDebug.Text = "Anti Debug";
            this.antiDebug.UseVisualStyleBackColor = true;
            // 
            // antiTamper
            // 
            this.antiTamper.AutoSize = true;
            this.antiTamper.Location = new System.Drawing.Point(16, 36);
            this.antiTamper.Name = "antiTamper";
            this.antiTamper.Size = new System.Drawing.Size(95, 21);
            this.antiTamper.TabIndex = 0;
            this.antiTamper.Text = "Anti Tamper";
            this.antiTamper.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Note: This GUI is in beta, please be considerate of any issues\r\n and report them " +
    "to me. Will be updating reguarly.";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(824, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(8, 6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(797, 391);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // thirteenButton2
            // 
            this.thirteenButton2.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton2.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton2.ForeColor = System.Drawing.Color.White;
            this.thirteenButton2.Location = new System.Drawing.Point(781, 0);
            this.thirteenButton2.Name = "thirteenButton2";
            this.thirteenButton2.Size = new System.Drawing.Size(27, 19);
            this.thirteenButton2.TabIndex = 2;
            this.thirteenButton2.Text = "_";
            this.thirteenButton2.UseVisualStyleBackColor = false;
            this.thirteenButton2.Click += new System.EventHandler(this.thirteenButton2_Click);
            // 
            // thirteenButton1
            // 
            this.thirteenButton1.AccentColor = System.Drawing.Color.DodgerBlue;
            this.thirteenButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.thirteenButton1.ColorScheme = Teen.ThirteenButton.ColorSchemes.Dark;
            this.thirteenButton1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.thirteenButton1.ForeColor = System.Drawing.Color.White;
            this.thirteenButton1.Location = new System.Drawing.Point(804, 0);
            this.thirteenButton1.Name = "thirteenButton1";
            this.thirteenButton1.Size = new System.Drawing.Size(27, 19);
            this.thirteenButton1.TabIndex = 1;
            this.thirteenButton1.Text = "X";
            this.thirteenButton1.UseVisualStyleBackColor = false;
            this.thirteenButton1.Click += new System.EventHandler(this.thirteenButton1_Click);
            // 
            // hideMethods
            // 
            this.hideMethods.AutoSize = true;
            this.hideMethods.Location = new System.Drawing.Point(247, 141);
            this.hideMethods.Name = "hideMethods";
            this.hideMethods.Size = new System.Drawing.Size(105, 21);
            this.hideMethods.TabIndex = 15;
            this.hideMethods.Text = "Hide Methods";
            this.hideMethods.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 464);
            this.Controls.Add(this.thirteenForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.thirteenForm1.ResumeLayout(false);
            this.thirteenTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Teen.ThirteenForm thirteenForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Teen.ThirteenButton thirteenButton1;
        private Teen.ThirteenButton thirteenButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Teen.ThirteenTextBox thirteenTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Teen.ThirteenButton thirteenButton3;
        private System.Windows.Forms.Label label3;
        private Teen.ThirteenButton thirteenButton6;
        private System.Windows.Forms.CheckBox renameAssembly;
        private System.Windows.Forms.CheckBox fakeNative;
        private System.Windows.Forms.CheckBox moduleFlood;
        private System.Windows.Forms.CheckBox mildRefProxy;
        private System.Windows.Forms.CheckBox refProxy;
        private System.Windows.Forms.CheckBox renamer;
        private System.Windows.Forms.CheckBox invalidMetadat;
        private System.Windows.Forms.CheckBox controlFlow;
        private System.Windows.Forms.CheckBox constants;
        private System.Windows.Forms.CheckBox calli;
        private System.Windows.Forms.CheckBox antiDebug;
        private System.Windows.Forms.CheckBox antiTamper;
        private System.Windows.Forms.CheckBox checkBox4;
        private Teen.ThirteenButton thirteenButton4;
        private Teen.ThirteenTabControl thirteenTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox mutations;
        private System.Windows.Forms.CheckBox local2field;
        private System.Windows.Forms.CheckBox hideMethods;
    }
}

