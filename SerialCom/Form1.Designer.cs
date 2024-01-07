namespace SerialCom
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveReceiveDataToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.ResetPortConfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ContributorSylvesterLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBoxSerialPortSetting = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOpenCloseCom = new System.Windows.Forms.Button();
            this.groupBoxSendSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonSendDataHex = new System.Windows.Forms.RadioButton();
            this.radioButtonSendDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveSetting = new System.Windows.Forms.GroupBox();
            this.radioButtonReceiveDataHEX = new System.Windows.Forms.RadioButton();
            this.radioButtonReceiveDataASCII = new System.Windows.Forms.RadioButton();
            this.groupBoxReceiveData = new System.Windows.Forms.GroupBox();
            this.buttonClearRecData = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBoxSendData = new System.Windows.Forms.GroupBox();
            this.buttonSendData = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.Button_Refresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBoxSerialPortSetting.SuspendLayout();
            this.groupBoxSendSetting.SuspendLayout();
            this.groupBoxReceiveSetting.SuspendLayout();
            this.groupBoxReceiveData.SuspendLayout();
            this.groupBoxSendData.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuTools,
            this.MenuSetting,
            this.MenuIHelp});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveReceiveDataToFileToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            resources.ApplyResources(this.MenuFile, "MenuFile");
            // 
            // SaveReceiveDataToFileToolStripMenuItem
            // 
            this.SaveReceiveDataToFileToolStripMenuItem.Name = "SaveReceiveDataToFileToolStripMenuItem";
            resources.ApplyResources(this.SaveReceiveDataToFileToolStripMenuItem, "SaveReceiveDataToFileToolStripMenuItem");
            this.SaveReceiveDataToFileToolStripMenuItem.Click += new System.EventHandler(this.SaveReceiveDataToFileToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            resources.ApplyResources(this.ExitToolStripMenuItem, "ExitToolStripMenuItem");
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MenuTools
            // 
            this.MenuTools.Name = "MenuTools";
            resources.ApplyResources(this.MenuTools, "MenuTools");
            // 
            // MenuSetting
            // 
            this.MenuSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResetPortConfToolStripMenuItem});
            this.MenuSetting.Name = "MenuSetting";
            resources.ApplyResources(this.MenuSetting, "MenuSetting");
            // 
            // ResetPortConfToolStripMenuItem
            // 
            this.ResetPortConfToolStripMenuItem.Name = "ResetPortConfToolStripMenuItem";
            resources.ApplyResources(this.ResetPortConfToolStripMenuItem, "ResetPortConfToolStripMenuItem");
            this.ResetPortConfToolStripMenuItem.Click += new System.EventHandler(this.ResetPortConfToolStripMenuItem_Click);
            // 
            // MenuIHelp
            // 
            this.MenuIHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutToolStripMenuItem});
            this.MenuIHelp.Name = "MenuIHelp";
            resources.ApplyResources(this.MenuIHelp, "MenuIHelp");
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorToolStripMenuItem,
            this.ContributorSylvesterLiToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            resources.ApplyResources(this.AboutToolStripMenuItem, "AboutToolStripMenuItem");
            // 
            // AuthorToolStripMenuItem
            // 
            this.AuthorToolStripMenuItem.Name = "AuthorToolStripMenuItem";
            resources.ApplyResources(this.AuthorToolStripMenuItem, "AuthorToolStripMenuItem");
            // 
            // ContributorSylvesterLiToolStripMenuItem
            // 
            this.ContributorSylvesterLiToolStripMenuItem.Name = "ContributorSylvesterLiToolStripMenuItem";
            resources.ApplyResources(this.ContributorSylvesterLiToolStripMenuItem, "ContributorSylvesterLiToolStripMenuItem");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // groupBoxSerialPortSetting
            // 
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxStopBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxCheckBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxDataBit);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerialPortSetting.Controls.Add(this.comboBoxCom);
            this.groupBoxSerialPortSetting.Controls.Add(this.label5);
            this.groupBoxSerialPortSetting.Controls.Add(this.label4);
            this.groupBoxSerialPortSetting.Controls.Add(this.label3);
            this.groupBoxSerialPortSetting.Controls.Add(this.label2);
            this.groupBoxSerialPortSetting.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBoxSerialPortSetting, "groupBoxSerialPortSetting");
            this.groupBoxSerialPortSetting.Name = "groupBoxSerialPortSetting";
            this.groupBoxSerialPortSetting.TabStop = false;
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBit.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxStopBit, "comboBoxStopBit");
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCheckBit.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxCheckBit, "comboBoxCheckBit");
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBit.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxDataBit, "comboBoxDataBit");
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBit_SelectedIndexChanged);
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaudRate.FormattingEnabled = true;
            resources.ApplyResources(this.comboBoxBaudRate, "comboBoxBaudRate");
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // comboBoxCom
            // 
            resources.ApplyResources(this.comboBoxCom, "comboBoxCom");
            this.comboBoxCom.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCom.FormattingEnabled = true;
            this.comboBoxCom.Name = "comboBoxCom";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // buttonOpenCloseCom
            // 
            resources.ApplyResources(this.buttonOpenCloseCom, "buttonOpenCloseCom");
            this.buttonOpenCloseCom.Name = "buttonOpenCloseCom";
            this.buttonOpenCloseCom.UseVisualStyleBackColor = true;
            this.buttonOpenCloseCom.Click += new System.EventHandler(this.buttonOpenCloseCom_Click);
            // 
            // groupBoxSendSetting
            // 
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataHex);
            this.groupBoxSendSetting.Controls.Add(this.radioButtonSendDataASCII);
            resources.ApplyResources(this.groupBoxSendSetting, "groupBoxSendSetting");
            this.groupBoxSendSetting.Name = "groupBoxSendSetting";
            this.groupBoxSendSetting.TabStop = false;
            // 
            // radioButtonSendDataHex
            // 
            resources.ApplyResources(this.radioButtonSendDataHex, "radioButtonSendDataHex");
            this.radioButtonSendDataHex.Name = "radioButtonSendDataHex";
            this.radioButtonSendDataHex.TabStop = true;
            this.radioButtonSendDataHex.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendDataASCII
            // 
            resources.ApplyResources(this.radioButtonSendDataASCII, "radioButtonSendDataASCII");
            this.radioButtonSendDataASCII.Name = "radioButtonSendDataASCII";
            this.radioButtonSendDataASCII.TabStop = true;
            this.radioButtonSendDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveSetting
            // 
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataHEX);
            this.groupBoxReceiveSetting.Controls.Add(this.radioButtonReceiveDataASCII);
            resources.ApplyResources(this.groupBoxReceiveSetting, "groupBoxReceiveSetting");
            this.groupBoxReceiveSetting.Name = "groupBoxReceiveSetting";
            this.groupBoxReceiveSetting.TabStop = false;
            this.groupBoxReceiveSetting.Enter += new System.EventHandler(this.groupBoxReceiveSetting_Enter);
            // 
            // radioButtonReceiveDataHEX
            // 
            resources.ApplyResources(this.radioButtonReceiveDataHEX, "radioButtonReceiveDataHEX");
            this.radioButtonReceiveDataHEX.Name = "radioButtonReceiveDataHEX";
            this.radioButtonReceiveDataHEX.TabStop = true;
            this.radioButtonReceiveDataHEX.UseVisualStyleBackColor = true;
            // 
            // radioButtonReceiveDataASCII
            // 
            resources.ApplyResources(this.radioButtonReceiveDataASCII, "radioButtonReceiveDataASCII");
            this.radioButtonReceiveDataASCII.Name = "radioButtonReceiveDataASCII";
            this.radioButtonReceiveDataASCII.TabStop = true;
            this.radioButtonReceiveDataASCII.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceiveData
            // 
            resources.ApplyResources(this.groupBoxReceiveData, "groupBoxReceiveData");
            this.groupBoxReceiveData.Controls.Add(this.buttonClearRecData);
            this.groupBoxReceiveData.Controls.Add(this.textBoxReceive);
            this.groupBoxReceiveData.Name = "groupBoxReceiveData";
            this.groupBoxReceiveData.TabStop = false;
            // 
            // buttonClearRecData
            // 
            resources.ApplyResources(this.buttonClearRecData, "buttonClearRecData");
            this.buttonClearRecData.Name = "buttonClearRecData";
            this.buttonClearRecData.UseVisualStyleBackColor = true;
            this.buttonClearRecData.Click += new System.EventHandler(this.buttonClearRecData_Click);
            // 
            // textBoxReceive
            // 
            resources.ApplyResources(this.textBoxReceive, "textBoxReceive");
            this.textBoxReceive.Name = "textBoxReceive";
            // 
            // groupBoxSendData
            // 
            resources.ApplyResources(this.groupBoxSendData, "groupBoxSendData");
            this.groupBoxSendData.Controls.Add(this.buttonSendData);
            this.groupBoxSendData.Controls.Add(this.textBoxSend);
            this.groupBoxSendData.Name = "groupBoxSendData";
            this.groupBoxSendData.TabStop = false;
            // 
            // buttonSendData
            // 
            resources.ApplyResources(this.buttonSendData, "buttonSendData");
            this.buttonSendData.Name = "buttonSendData";
            this.buttonSendData.UseVisualStyleBackColor = true;
            this.buttonSendData.Click += new System.EventHandler(this.buttonSendData_Click);
            // 
            // textBoxSend
            // 
            resources.ApplyResources(this.textBoxSend, "textBoxSend");
            this.textBoxSend.Name = "textBoxSend";
            // 
            // Button_Refresh
            // 
            resources.ApplyResources(this.Button_Refresh, "Button_Refresh");
            this.Button_Refresh.Name = "Button_Refresh";
            this.Button_Refresh.UseVisualStyleBackColor = true;
            this.Button_Refresh.Click += new System.EventHandler(this.Button_Refresh_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Button_Refresh);
            this.Controls.Add(this.groupBoxSendData);
            this.Controls.Add(this.groupBoxReceiveData);
            this.Controls.Add(this.groupBoxReceiveSetting);
            this.Controls.Add(this.groupBoxSendSetting);
            this.Controls.Add(this.buttonOpenCloseCom);
            this.Controls.Add(this.groupBoxSerialPortSetting);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxSerialPortSetting.ResumeLayout(false);
            this.groupBoxSerialPortSetting.PerformLayout();
            this.groupBoxSendSetting.ResumeLayout(false);
            this.groupBoxSendSetting.PerformLayout();
            this.groupBoxReceiveSetting.ResumeLayout(false);
            this.groupBoxReceiveSetting.PerformLayout();
            this.groupBoxReceiveData.ResumeLayout(false);
            this.groupBoxReceiveData.PerformLayout();
            this.groupBoxSendData.ResumeLayout(false);
            this.groupBoxSendData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuTools;
        private System.Windows.Forms.ToolStripMenuItem MenuSetting;
        private System.Windows.Forms.ToolStripMenuItem MenuIHelp;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBoxSerialPortSetting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBoxCom;
        private System.Windows.Forms.Button buttonOpenCloseCom;
        private System.Windows.Forms.GroupBox groupBoxSendSetting;
        private System.Windows.Forms.RadioButton radioButtonSendDataASCII;
        private System.Windows.Forms.RadioButton radioButtonSendDataHex;
        private System.Windows.Forms.GroupBox groupBoxReceiveSetting;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataASCII;
        private System.Windows.Forms.RadioButton radioButtonReceiveDataHEX;
        private System.Windows.Forms.GroupBox groupBoxReceiveData;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBoxSendData;
        private System.Windows.Forms.Button buttonClearRecData;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSendData;
        private System.Windows.Forms.Button Button_Refresh;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AuthorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ContributorSylvesterLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetPortConfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveReceiveDataToFileToolStripMenuItem;
    }
}

