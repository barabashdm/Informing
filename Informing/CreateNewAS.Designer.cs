
namespace Informing
{
    partial class CreateNewAS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.tBASID = new System.Windows.Forms.TextBox();
            this.tBNameAS = new System.Windows.Forms.TextBox();
            this.btnCreateNewAS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBNumberOfTKS = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTypeIncident = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cBChooseIncident = new System.Windows.Forms.ComboBox();
            this.tBci = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tBwgsm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.tBci21 = new System.Windows.Forms.TextBox();
            this.tBci22 = new System.Windows.Forms.TextBox();
            this.btnShowTB21 = new System.Windows.Forms.Button();
            this.btnShowTB22 = new System.Windows.Forms.Button();
            this.btnShowTB12 = new System.Windows.Forms.Button();
            this.btnShowTB11 = new System.Windows.Forms.Button();
            this.tBNumberOfTKS12 = new System.Windows.Forms.TextBox();
            this.tBNumberOfTKS11 = new System.Windows.Forms.TextBox();
            this.btnShowTB13 = new System.Windows.Forms.Button();
            this.tBNumberOfTKS13 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTypeIncMain = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cBTypeIncMain = new System.Windows.Forms.ComboBox();
            this.cBChooseAS = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblCodeAS = new System.Windows.Forms.Label();
            this.btnCreateNewTemplateForASByTypeOfIncident = new System.Windows.Forms.Button();
            this.lblTypeIncExt = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cBTypeIncExt = new System.Windows.Forms.ComboBox();
            this.cBxNeedCopy = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBASID
            // 
            this.tBASID.Location = new System.Drawing.Point(40, 109);
            this.tBASID.Margin = new System.Windows.Forms.Padding(2);
            this.tBASID.Name = "tBASID";
            this.tBASID.Size = new System.Drawing.Size(112, 20);
            this.tBASID.TabIndex = 0;
            // 
            // tBNameAS
            // 
            this.tBNameAS.Location = new System.Drawing.Point(40, 64);
            this.tBNameAS.Margin = new System.Windows.Forms.Padding(2);
            this.tBNameAS.Name = "tBNameAS";
            this.tBNameAS.Size = new System.Drawing.Size(112, 20);
            this.tBNameAS.TabIndex = 1;
            // 
            // btnCreateNewAS
            // 
            this.btnCreateNewAS.Location = new System.Drawing.Point(127, 526);
            this.btnCreateNewAS.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewAS.Name = "btnCreateNewAS";
            this.btnCreateNewAS.Size = new System.Drawing.Size(118, 36);
            this.btnCreateNewAS.TabIndex = 2;
            this.btnCreateNewAS.Text = "Создать новую рассылку";
            this.btnCreateNewAS.UseVisualStyleBackColor = true;
            this.btnCreateNewAS.Click += new System.EventHandler(this.btnCreateNewAS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите название АС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите code (для xml файла)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите номер ТКС";
            // 
            // tBNumberOfTKS
            // 
            this.tBNumberOfTKS.Location = new System.Drawing.Point(213, 64);
            this.tBNumberOfTKS.Margin = new System.Windows.Forms.Padding(2);
            this.tBNumberOfTKS.Name = "tBNumberOfTKS";
            this.tBNumberOfTKS.Size = new System.Drawing.Size(112, 20);
            this.tBNumberOfTKS.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Enabled = false;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(40, 246);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(290, 162);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(37, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 57);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дополнительно:\r\nВыберите одну АС, рассылку которой хотите скопировать (она может " +
    "быть пуста в данном типе инцидента):";
            // 
            // lblTypeIncident
            // 
            this.lblTypeIncident.AutoSize = true;
            this.lblTypeIncident.Location = new System.Drawing.Point(285, 24);
            this.lblTypeIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeIncident.Name = "lblTypeIncident";
            this.lblTypeIncident.Size = new System.Drawing.Size(10, 13);
            this.lblTypeIncident.TabIndex = 21;
            this.lblTypeIncident.Text = " ";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(118, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Выберите тип инцидента";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 4);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Код";
            // 
            // cBChooseIncident
            // 
            this.cBChooseIncident.FormattingEnabled = true;
            this.cBChooseIncident.Location = new System.Drawing.Point(79, 21);
            this.cBChooseIncident.Margin = new System.Windows.Forms.Padding(2);
            this.cBChooseIncident.Name = "cBChooseIncident";
            this.cBChooseIncident.Size = new System.Drawing.Size(202, 21);
            this.cBChooseIncident.TabIndex = 18;
            this.cBChooseIncident.SelectedIndexChanged += new System.EventHandler(this.cBChooseIncident_SelectedIndexChanged);
            // 
            // tBci
            // 
            this.tBci.Location = new System.Drawing.Point(64, 454);
            this.tBci.Margin = new System.Windows.Forms.Padding(2);
            this.tBci.Name = "tBci";
            this.tBci.Size = new System.Drawing.Size(112, 20);
            this.tBci.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 438);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Введите номер КЭ";
            // 
            // tBwgsm
            // 
            this.tBwgsm.Location = new System.Drawing.Point(204, 454);
            this.tBwgsm.Margin = new System.Windows.Forms.Padding(2);
            this.tBwgsm.Name = "tBwgsm";
            this.tBwgsm.Size = new System.Drawing.Size(112, 20);
            this.tBwgsm.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 438);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Введите рабочую группу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(106, 416);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дополнительно (для админов):";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(40, 218);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 27;
            this.btnShow.Text = "Отобразить";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // tBci21
            // 
            this.tBci21.Enabled = false;
            this.tBci21.Location = new System.Drawing.Point(64, 478);
            this.tBci21.Margin = new System.Windows.Forms.Padding(2);
            this.tBci21.Name = "tBci21";
            this.tBci21.Size = new System.Drawing.Size(112, 20);
            this.tBci21.TabIndex = 28;
            // 
            // tBci22
            // 
            this.tBci22.Enabled = false;
            this.tBci22.Location = new System.Drawing.Point(64, 502);
            this.tBci22.Margin = new System.Windows.Forms.Padding(2);
            this.tBci22.Name = "tBci22";
            this.tBci22.Size = new System.Drawing.Size(112, 20);
            this.tBci22.TabIndex = 29;
            // 
            // btnShowTB21
            // 
            this.btnShowTB21.Location = new System.Drawing.Point(40, 478);
            this.btnShowTB21.Name = "btnShowTB21";
            this.btnShowTB21.Size = new System.Drawing.Size(19, 19);
            this.btnShowTB21.TabIndex = 30;
            this.btnShowTB21.Text = "+";
            this.btnShowTB21.UseVisualStyleBackColor = true;
            this.btnShowTB21.Click += new System.EventHandler(this.btnShowTB21_Click);
            // 
            // btnShowTB22
            // 
            this.btnShowTB22.Location = new System.Drawing.Point(40, 502);
            this.btnShowTB22.Name = "btnShowTB22";
            this.btnShowTB22.Size = new System.Drawing.Size(19, 19);
            this.btnShowTB22.TabIndex = 31;
            this.btnShowTB22.Text = "+";
            this.btnShowTB22.UseVisualStyleBackColor = true;
            this.btnShowTB22.Click += new System.EventHandler(this.btnShowTB22_Click);
            // 
            // btnShowTB12
            // 
            this.btnShowTB12.Location = new System.Drawing.Point(189, 112);
            this.btnShowTB12.Name = "btnShowTB12";
            this.btnShowTB12.Size = new System.Drawing.Size(19, 19);
            this.btnShowTB12.TabIndex = 35;
            this.btnShowTB12.Text = "+";
            this.btnShowTB12.UseVisualStyleBackColor = true;
            this.btnShowTB12.Click += new System.EventHandler(this.btnShowTB12_Click);
            // 
            // btnShowTB11
            // 
            this.btnShowTB11.Location = new System.Drawing.Point(189, 88);
            this.btnShowTB11.Name = "btnShowTB11";
            this.btnShowTB11.Size = new System.Drawing.Size(19, 19);
            this.btnShowTB11.TabIndex = 34;
            this.btnShowTB11.Text = "+";
            this.btnShowTB11.UseVisualStyleBackColor = true;
            this.btnShowTB11.Click += new System.EventHandler(this.btnShowTB11_Click);
            // 
            // tBNumberOfTKS12
            // 
            this.tBNumberOfTKS12.Enabled = false;
            this.tBNumberOfTKS12.Location = new System.Drawing.Point(213, 112);
            this.tBNumberOfTKS12.Margin = new System.Windows.Forms.Padding(2);
            this.tBNumberOfTKS12.Name = "tBNumberOfTKS12";
            this.tBNumberOfTKS12.Size = new System.Drawing.Size(112, 20);
            this.tBNumberOfTKS12.TabIndex = 33;
            // 
            // tBNumberOfTKS11
            // 
            this.tBNumberOfTKS11.Enabled = false;
            this.tBNumberOfTKS11.Location = new System.Drawing.Point(213, 88);
            this.tBNumberOfTKS11.Margin = new System.Windows.Forms.Padding(2);
            this.tBNumberOfTKS11.Name = "tBNumberOfTKS11";
            this.tBNumberOfTKS11.Size = new System.Drawing.Size(112, 20);
            this.tBNumberOfTKS11.TabIndex = 32;
            // 
            // btnShowTB13
            // 
            this.btnShowTB13.Location = new System.Drawing.Point(189, 136);
            this.btnShowTB13.Name = "btnShowTB13";
            this.btnShowTB13.Size = new System.Drawing.Size(19, 19);
            this.btnShowTB13.TabIndex = 37;
            this.btnShowTB13.Text = "+";
            this.btnShowTB13.UseVisualStyleBackColor = true;
            this.btnShowTB13.Click += new System.EventHandler(this.btnShowTB13_Click);
            // 
            // tBNumberOfTKS13
            // 
            this.tBNumberOfTKS13.Enabled = false;
            this.tBNumberOfTKS13.Location = new System.Drawing.Point(213, 136);
            this.tBNumberOfTKS13.Margin = new System.Windows.Forms.Padding(2);
            this.tBNumberOfTKS13.Name = "tBNumberOfTKS13";
            this.tBNumberOfTKS13.Size = new System.Drawing.Size(112, 20);
            this.tBNumberOfTKS13.TabIndex = 36;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(372, 593);
            this.tabControl1.TabIndex = 38;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreateNewAS);
            this.tabPage1.Controls.Add(this.btnShow);
            this.tabPage1.Controls.Add(this.btnShowTB13);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.tBci);
            this.tabPage1.Controls.Add(this.tBNumberOfTKS13);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnShowTB12);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnShowTB11);
            this.tabPage1.Controls.Add(this.tBwgsm);
            this.tabPage1.Controls.Add(this.tBNumberOfTKS12);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tBNumberOfTKS11);
            this.tabPage1.Controls.Add(this.tBci21);
            this.tabPage1.Controls.Add(this.btnShowTB22);
            this.tabPage1.Controls.Add(this.lblTypeIncident);
            this.tabPage1.Controls.Add(this.tBci22);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.btnShowTB21);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.tBNameAS);
            this.tabPage1.Controls.Add(this.cBChooseIncident);
            this.tabPage1.Controls.Add(this.tBASID);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tBNumberOfTKS);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(364, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Создание новой АС";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btnCreateNewTemplateForASByTypeOfIncident);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(364, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Созд-е рассылки сущ-ей АС по новому типу инц-а";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTypeIncMain
            // 
            this.lblTypeIncMain.AutoSize = true;
            this.lblTypeIncMain.Location = new System.Drawing.Point(272, 39);
            this.lblTypeIncMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeIncMain.Name = "lblTypeIncMain";
            this.lblTypeIncMain.Size = new System.Drawing.Size(10, 13);
            this.lblTypeIncMain.TabIndex = 25;
            this.lblTypeIncMain.Text = " ";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(105, 21);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 14);
            this.label11.TabIndex = 23;
            this.label11.Text = "Выберите тип инцидента";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(272, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Код";
            // 
            // cBTypeIncMain
            // 
            this.cBTypeIncMain.FormattingEnabled = true;
            this.cBTypeIncMain.Location = new System.Drawing.Point(66, 36);
            this.cBTypeIncMain.Margin = new System.Windows.Forms.Padding(2);
            this.cBTypeIncMain.Name = "cBTypeIncMain";
            this.cBTypeIncMain.Size = new System.Drawing.Size(202, 21);
            this.cBTypeIncMain.TabIndex = 22;
            this.cBTypeIncMain.SelectedIndexChanged += new System.EventHandler(this.cBTypeIncMain_SelectedIndexChanged);
            // 
            // cBChooseAS
            // 
            this.cBChooseAS.FormattingEnabled = true;
            this.cBChooseAS.Location = new System.Drawing.Point(66, 95);
            this.cBChooseAS.Margin = new System.Windows.Forms.Padding(2);
            this.cBChooseAS.Name = "cBChooseAS";
            this.cBChooseAS.Size = new System.Drawing.Size(202, 21);
            this.cBChooseAS.TabIndex = 27;
            this.cBChooseAS.SelectedIndexChanged += new System.EventHandler(this.cBChooseAS_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(271, 79);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Код";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(133, 80);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 14);
            this.label14.TabIndex = 26;
            this.label14.Text = "Выберите АС";
            // 
            // lblCodeAS
            // 
            this.lblCodeAS.AutoSize = true;
            this.lblCodeAS.Location = new System.Drawing.Point(271, 98);
            this.lblCodeAS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodeAS.Name = "lblCodeAS";
            this.lblCodeAS.Size = new System.Drawing.Size(10, 13);
            this.lblCodeAS.TabIndex = 28;
            this.lblCodeAS.Text = " ";
            // 
            // btnCreateNewTemplateForASByTypeOfIncident
            // 
            this.btnCreateNewTemplateForASByTypeOfIncident.Location = new System.Drawing.Point(115, 346);
            this.btnCreateNewTemplateForASByTypeOfIncident.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateNewTemplateForASByTypeOfIncident.Name = "btnCreateNewTemplateForASByTypeOfIncident";
            this.btnCreateNewTemplateForASByTypeOfIncident.Size = new System.Drawing.Size(118, 36);
            this.btnCreateNewTemplateForASByTypeOfIncident.TabIndex = 30;
            this.btnCreateNewTemplateForASByTypeOfIncident.Text = "Создать новую рассылку";
            this.btnCreateNewTemplateForASByTypeOfIncident.UseVisualStyleBackColor = true;
            this.btnCreateNewTemplateForASByTypeOfIncident.Click += new System.EventHandler(this.btnCreateNewTemplateForASByTypeOfIncident_Click);
            // 
            // lblTypeIncExt
            // 
            this.lblTypeIncExt.AutoSize = true;
            this.lblTypeIncExt.Location = new System.Drawing.Point(296, 121);
            this.lblTypeIncExt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeIncExt.Name = "lblTypeIncExt";
            this.lblTypeIncExt.Size = new System.Drawing.Size(10, 13);
            this.lblTypeIncExt.TabIndex = 34;
            this.lblTypeIncExt.Text = " ";
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(57, 74);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(225, 42);
            this.label16.TabIndex = 32;
            this.label16.Text = "Выберите тип инцидента данной АС, если хотите скопировать значения получателей (р" +
    "ассылка должна быть создана)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(296, 101);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Код";
            // 
            // cBTypeIncExt
            // 
            this.cBTypeIncExt.FormattingEnabled = true;
            this.cBTypeIncExt.Location = new System.Drawing.Point(66, 118);
            this.cBTypeIncExt.Margin = new System.Windows.Forms.Padding(2);
            this.cBTypeIncExt.Name = "cBTypeIncExt";
            this.cBTypeIncExt.Size = new System.Drawing.Size(202, 21);
            this.cBTypeIncExt.TabIndex = 31;
            this.cBTypeIncExt.SelectedIndexChanged += new System.EventHandler(this.cBTypeIncExt_SelectedIndexChanged);
            // 
            // cBxNeedCopy
            // 
            this.cBxNeedCopy.AutoSize = true;
            this.cBxNeedCopy.Location = new System.Drawing.Point(6, 30);
            this.cBxNeedCopy.Name = "cBxNeedCopy";
            this.cBxNeedCopy.Size = new System.Drawing.Size(342, 17);
            this.cBxNeedCopy.TabIndex = 35;
            this.cBxNeedCopy.Text = "Скопировать содержимое рассылки из рассылки данной АС?";
            this.cBxNeedCopy.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBTypeIncMain);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblTypeIncMain);
            this.groupBox1.Controls.Add(this.lblCodeAS);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cBChooseAS);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 140);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите АС, для которой создаете";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.cBxNeedCopy);
            this.groupBox2.Controls.Add(this.cBTypeIncExt);
            this.groupBox2.Controls.Add(this.lblTypeIncExt);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(3, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 159);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительно: копирование";
            // 
            // CreateNewAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 593);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CreateNewAS";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать новую рассылку";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBASID;
        private System.Windows.Forms.TextBox tBNameAS;
        private System.Windows.Forms.Button btnCreateNewAS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBNumberOfTKS;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTypeIncident;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cBChooseIncident;
        private System.Windows.Forms.TextBox tBci;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBwgsm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox tBci21;
        private System.Windows.Forms.TextBox tBci22;
        private System.Windows.Forms.Button btnShowTB21;
        private System.Windows.Forms.Button btnShowTB22;
        private System.Windows.Forms.Button btnShowTB12;
        private System.Windows.Forms.Button btnShowTB11;
        private System.Windows.Forms.TextBox tBNumberOfTKS12;
        private System.Windows.Forms.TextBox tBNumberOfTKS11;
        private System.Windows.Forms.Button btnShowTB13;
        private System.Windows.Forms.TextBox tBNumberOfTKS13;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTypeIncMain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cBTypeIncMain;
        private System.Windows.Forms.ComboBox cBChooseAS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCodeAS;
        private System.Windows.Forms.Button btnCreateNewTemplateForASByTypeOfIncident;
        private System.Windows.Forms.CheckBox cBxNeedCopy;
        private System.Windows.Forms.Label lblTypeIncExt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox cBTypeIncExt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}