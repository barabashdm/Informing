using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Informing
{
    public partial class CreateNewAS : Form
    {
        Form1 f1 = new Form1();
        public CreateNewAS()
        {
            InitializeComponent();
            LoadXml();
        }
        string[] nameOfAS = new string[] { };
        string[] typeIncident = new string[] { };
        List<string> listName = new List<string>();
        List<string> listNameIncident = new List<string>();
        List<string> listCode = new List<string>();
        List<string> listReasonIncident = new List<string>();
        List<string> listChooseMany = new List<string>();
        List<string> listChooseNames = new List<string>();
        List<string> listCopy = new List<string>();
        XmlDocument xDoc = new XmlDocument();

        private void LoadXml()
        {
            Array.Clear(nameOfAS, 0, nameOfAS.Length);
            cBChooseAS.Items.Clear();
            listView1.Items.Clear();
            listName.Clear();
            listCode.Clear();
            Array.Clear(typeIncident, 0, typeIncident.Length);
            cBChooseIncident.Items.Clear();
            listNameIncident.Clear();
            listReasonIncident.Clear();
            xDoc.Load("template.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "asListNew")
                {
                    foreach (XmlElement childnode in xnode.ChildNodes)
                    {
                        nameOfAS = new string[] { childnode.Attributes.GetNamedItem("name").Value };
                        cBChooseAS.Items.AddRange(nameOfAS);
                        for (int i = 0; i < nameOfAS.Length; i++)
                        {
                            listView1.Items.Add(nameOfAS[i]);
                        }
                        listName.Add(childnode.Attributes.GetNamedItem("name").Value);
                        listCode.Add(childnode.Attributes.GetNamedItem("code").Value);
                    }
                }
                if (xnode.Name == "themeList")
                {
                    foreach (XmlElement childnode in xnode.ChildNodes)
                    {
                        typeIncident = new string[] { childnode.Attributes.GetNamedItem("name").Value };
                        cBChooseIncident.Items.AddRange(typeIncident);
                        cBTypeIncMain.Items.AddRange(typeIncident);
                        cBTypeIncExt.Items.AddRange(typeIncident);
                        listNameIncident.Add(childnode.Attributes.GetNamedItem("name").Value);
                        listReasonIncident.Add(childnode.Attributes.GetNamedItem("reason").Value);
                    }
                }
            }
        }

        public void CreateAS()
        {
            //asListNew

            xDoc.Load("template.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            for (int j = 0; j < listCode.Count; j++)
            {
                foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + "']//copy", nsmgr))
                {
                    if (tBNameAS.Text == listName[j] || tBASID.Text == listCode[j])
                    {
                        DialogResult dialogResult = MessageBox.Show("Рассылка уже создана", "Внимание", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            XmlElement userElem = xDoc.CreateElement("asListNew");
            XmlElement userElem2 = xDoc.CreateElement("AS");

            XmlAttribute nameAttr = xDoc.CreateAttribute("name");
            XmlAttribute reasonAttr = xDoc.CreateAttribute("code");

            XmlText nameText = xDoc.CreateTextNode(tBNameAS.Text);
            XmlText reasonText = xDoc.CreateTextNode(tBASID.Text);

            nameAttr.AppendChild(nameText);
            reasonAttr.AppendChild(reasonText);

            XmlElement companyElem = xDoc.CreateElement("tksNum");
            XmlElement ageElem = xDoc.CreateElement("ci");
            XmlElement wgsmElem = xDoc.CreateElement("wgsm");

            XmlText companyText = xDoc.CreateTextNode(tBNumberOfTKS.Text);
            XmlText ageText = xDoc.CreateTextNode(tBci.Text);
            XmlText wgsmText = xDoc.CreateTextNode(tBwgsm.Text);

            companyElem.AppendChild(companyText);
            ageElem.AppendChild(ageText);
            wgsmElem.AppendChild(wgsmText);

            userElem2.Attributes.Append(nameAttr);
            userElem2.Attributes.Append(reasonAttr);

            userElem2.AppendChild(companyElem);

            if (tBNumberOfTKS11.Enabled & tBNumberOfTKS11.Text != "")
            {
                XmlElement companyElem11 = xDoc.CreateElement("tksNum");
                XmlText companyText11 = xDoc.CreateTextNode(tBNumberOfTKS11.Text);
                companyElem11.AppendChild(companyText11);
                userElem2.AppendChild(companyElem11);
            }
            if (tBNumberOfTKS12.Enabled & tBNumberOfTKS12.Text != "")
            {
                XmlElement companyElem12 = xDoc.CreateElement("tksNum");
                XmlText companyText12 = xDoc.CreateTextNode(tBNumberOfTKS12.Text);
                companyElem12.AppendChild(companyText12);
                userElem2.AppendChild(companyElem12);
            }
            if (tBNumberOfTKS13.Enabled & tBNumberOfTKS13.Text != "")
            {
                XmlElement companyElem13 = xDoc.CreateElement("tksNum");
                XmlText companyText13 = xDoc.CreateTextNode(tBNumberOfTKS13.Text);
                companyElem13.AppendChild(companyText13);
                userElem2.AppendChild(companyElem13);
            }

            if (tBci21.Enabled & tBci21.Text != "")
            {
                XmlElement ageElem21 = xDoc.CreateElement("ci");
                XmlText ageText21 = xDoc.CreateTextNode(tBci21.Text);
                ageElem21.AppendChild(ageText21);
                userElem2.AppendChild(ageElem21);
            }
            if (tBci22.Enabled & tBci22.Text != "")
            {
                XmlElement ageElem22 = xDoc.CreateElement("ci");
                XmlText ageText22 = xDoc.CreateTextNode(tBci22.Text);
                ageElem22.AppendChild(ageText22);
                userElem2.AppendChild(ageElem22);
            }

            userElem2.AppendChild(ageElem);
            userElem2.AppendChild(wgsmElem);

            userElem.AppendChild(userElem2);

            xRoot.AppendChild(userElem);
            xDoc.Save("template.xml");

            //Reciepients

            XmlElement userElem3 = xDoc.CreateElement("Reciepients");
            XmlElement userElem4 = xDoc.CreateElement("list");

            XmlAttribute nameAttr1 = xDoc.CreateAttribute("code");
            XmlAttribute reasonAttr1 = xDoc.CreateAttribute("reason");

            XmlText nameText1 = xDoc.CreateTextNode(tBASID.Text);
            XmlText reasonText1 = xDoc.CreateTextNode(lblTypeIncident.Text);

            nameAttr1.AppendChild(nameText1);
            reasonAttr1.AppendChild(reasonText1);

            XmlElement companyElem1 = xDoc.CreateElement("copy");
            XmlElement ageElem1 = xDoc.CreateElement("numbers");

            XmlText companyText1 = xDoc.CreateTextNode(string.Empty);
            XmlText ageText1 = xDoc.CreateTextNode(string.Empty);

            if (listView1.Enabled == true)
            {
                if (listView1.CheckedItems.Count > 1 | listView1.CheckedItems.Count == 0)
                {
                    //DialogResult dialogResult = MessageBox.Show("Выбрано больше одного значения или ни одного. Вы копируете рассылку АС?", "Невозможно", MessageBoxButtons.YesNo);
                    if (MessageBox.Show("Выбрано больше одного значения или ни одного. Вы копируете рассылку АС? Если да, то нажмите 'Да' и выберите снова в списке АС значение (только одно). Если нет, то нажмите 'Нет', сохранится пустая рассылка", "Невозможно", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        companyElem1.AppendChild(companyText1);
                        ageElem1.AppendChild(ageText1);

                        userElem4.Attributes.Append(nameAttr1);
                        userElem4.Attributes.Append(reasonAttr1);

                        userElem4.AppendChild(companyElem1);
                        userElem4.AppendChild(ageElem1);

                        userElem3.AppendChild(userElem4);

                        xRoot.AppendChild(userElem3);
                        xDoc.Save("template.xml");
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    for (int j = 0; j < listCode.Count; j++)
                    {
                        for (int a = 0; a < listView1.CheckedItems.Count; a++)
                        {
                            foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + "']//copy", nsmgr))
                            {
                                if (listView1.CheckedItems[a].Text == listName[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                                {
                                    companyText1 = xDoc.CreateTextNode(xnode.InnerText);
                                    using (StreamWriter sw = new StreamWriter(f1.writePath, true, Encoding.Default))
                                    {
                                        sw.WriteLine("Логин: " + f1.userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): ");
                                    }
                                }
                            }
                            foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + "']//numbers", nsmgr))
                            {
                                if (listView1.CheckedItems[a].Text == listName[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                                {
                                    ageText1 = xDoc.CreateTextNode(xnode.InnerText);
                                    using (StreamWriter sw = new StreamWriter(f1.writePath, true, Encoding.Default))
                                    {
                                        sw.WriteLine("Логин: " + f1.userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): ");
                                    }
                                }
                            }
                        }
                    }
                    companyElem1.AppendChild(companyText1);
                    ageElem1.AppendChild(ageText1);

                    userElem4.Attributes.Append(nameAttr1);
                    userElem4.Attributes.Append(reasonAttr1);

                    userElem4.AppendChild(companyElem1);
                    userElem4.AppendChild(ageElem1);

                    userElem3.AppendChild(userElem4);

                    xRoot.AppendChild(userElem3);
                    xDoc.Save("template.xml");
                }
            }
            else
            {
                companyElem1.AppendChild(companyText1);
                ageElem1.AppendChild(ageText1);

                userElem4.Attributes.Append(nameAttr1);
                userElem4.Attributes.Append(reasonAttr1);

                userElem4.AppendChild(companyElem1);
                userElem4.AppendChild(ageElem1);

                userElem3.AppendChild(userElem4);

                xRoot.AppendChild(userElem3);
                xDoc.Save("template.xml");
            }
            LoadXml();
        }

        private void cBChooseIncident_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTypeIncident.Text = "";
            for (int i = 0; i < listReasonIncident.Count; i++)
            {
                if (cBChooseIncident.Text == listNameIncident[i])
                {
                    lblTypeIncident.Text = listReasonIncident[i];
                }
            }
        }

        private void btnCreateNewAS_Click(object sender, EventArgs e)
        {
            CreateAS();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listView1.Enabled = true;
        }

        private void btnCreateNewTemplateForASByTypeOfIncident_Click(object sender, EventArgs e)
        {
            xDoc.Load("template.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            for (int j = 0; j < listCode.Count; j++)
            {
                foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncMain.Text + "']//copy", nsmgr))
                {
                    if (lblCodeAS.Text == listCode[j])
                    {
                        DialogResult dialogResult = MessageBox.Show("Рассылка уже создана", "Внимание", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            //Reciepients

            XmlElement userElem3 = xDoc.CreateElement("Reciepients");
            XmlElement userElem4 = xDoc.CreateElement("list");

            XmlAttribute nameAttr1 = xDoc.CreateAttribute("code");
            XmlAttribute reasonAttr1 = xDoc.CreateAttribute("reason");

            XmlText nameText1 = xDoc.CreateTextNode(lblCodeAS.Text);
            XmlText reasonText1 = xDoc.CreateTextNode(lblTypeIncMain.Text);

            nameAttr1.AppendChild(nameText1);
            reasonAttr1.AppendChild(reasonText1);

            XmlElement companyElem1 = xDoc.CreateElement("copy");
            XmlElement ageElem1 = xDoc.CreateElement("numbers");

            XmlText companyText1 = xDoc.CreateTextNode(string.Empty);
            XmlText ageText1 = xDoc.CreateTextNode(string.Empty);

            if (cBxNeedCopy.Checked == true & cBTypeIncExt.Text != "")
            {
                for (int j = 0; j < listCode.Count; j++)
                {
                    foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncExt.Text + "']//copy", nsmgr))
                    {
                        if (lblCodeAS.Text == listCode[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                        {
                            companyText1 = xDoc.CreateTextNode(xnode.InnerText);
                            using (StreamWriter sw = new StreamWriter(f1.writePath, true, Encoding.Default))
                            {
                                sw.WriteLine("Логин: " + f1.userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): ");
                            }
                        }
                    }
                    foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncExt.Text + "']//numbers", nsmgr))
                    {
                        if (lblCodeAS.Text == listCode[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                        {
                            ageText1 = xDoc.CreateTextNode(xnode.InnerText);
                            using (StreamWriter sw = new StreamWriter(f1.writePath, true, Encoding.Default))
                            {
                                sw.WriteLine("Логин: " + f1.userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): ");
                            }
                        }
                    }
                }
                companyElem1.AppendChild(companyText1);
                ageElem1.AppendChild(ageText1);

                userElem4.Attributes.Append(nameAttr1);
                userElem4.Attributes.Append(reasonAttr1);

                userElem4.AppendChild(companyElem1);
                userElem4.AppendChild(ageElem1);

                userElem3.AppendChild(userElem4);

                xRoot.AppendChild(userElem3);
                xDoc.Save("template.xml");
            }
            else
            {
                companyElem1.AppendChild(companyText1);
                ageElem1.AppendChild(ageText1);

                userElem4.Attributes.Append(nameAttr1);
                userElem4.Attributes.Append(reasonAttr1);

                userElem4.AppendChild(companyElem1);
                userElem4.AppendChild(ageElem1);

                userElem3.AppendChild(userElem4);

                xRoot.AppendChild(userElem3);
                xDoc.Save("template.xml");
            }
            LoadXml();
        }

        private void btnShowTB11_Click(object sender, EventArgs e)
        {
            tBNumberOfTKS11.Enabled = true;
        }

        private void btnShowTB12_Click(object sender, EventArgs e)
        {
            tBNumberOfTKS12.Enabled = true;
        }

        private void btnShowTB13_Click(object sender, EventArgs e)
        {
            tBNumberOfTKS13.Enabled = true;
        }

        private void btnShowTB21_Click(object sender, EventArgs e)
        {
            tBci21.Enabled = true;
        }

        private void btnShowTB22_Click(object sender, EventArgs e)
        {
            tBci22.Enabled = true;
        }

        private void cBTypeIncMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTypeIncMain.Text = "";
            for (int i = 0; i < listReasonIncident.Count; i++)
            {
                if (cBTypeIncMain.Text == listNameIncident[i])
                {
                    lblTypeIncMain.Text = listReasonIncident[i];
                }
            }
        }

        private void cBTypeIncExt_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTypeIncExt.Text = "";
            for (int i = 0; i < listReasonIncident.Count; i++)
            {
                if (cBTypeIncExt.Text == listNameIncident[i])
                {
                    lblTypeIncExt.Text = listReasonIncident[i];
                }
            }
        }

        private void cBChooseAS_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCodeAS.Text = "";
            for (int i = 0; i < listCode.Count; i++)
            {
                if (cBChooseAS.Text == listName[i])
                {
                    lblCodeAS.Text = listCode[i];
                }
            }
        }
    }
}
