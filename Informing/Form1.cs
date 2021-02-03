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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FirstLoadXml();
        }
        public string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        string way;
        char signChar;
        string signString;
        bool flag = true;
        public string writePath = "log.txt";
        string[] nameOfAS = new string[] { };
        string[] typeIncident = new string[] { };
        List<string> template = new List<string>();
        List<string> templateMid = new List<string>();
        List<string> templateFinal = new List<string>();
        List<string> listName = new List<string>();
        List<string> listNameIncident = new List<string>();
        List<string> listCode = new List<string>();
        List<string> listReasonIncident = new List<string>();
        List<string> listChooseMany = new List<string>();
        List<string> listChooseNames = new List<string>();
        List<string> listCopy = new List<string>();
        List<string> listSearchAdding = new List<string>();
        List<string> listSearchDeleting = new List<string>();
        List<string> listSearchFinal = new List<string>();
        List<string> listNothing = new List<string>();
        List<string> listASForSearchFinal = new List<string>();
        //List<string> listASForNothing = new List<string>();
        XmlDocument xDoc = new XmlDocument();

        private void FirstLoadXml()
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
                        listNameIncident.Add(childnode.Attributes.GetNamedItem("name").Value);
                        listReasonIncident.Add(childnode.Attributes.GetNamedItem("reason").Value);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rBInChoosenAS.Enabled = false;
            flag = false;
            lblCodeAS.Text = "";
            rBInOneAS.Enabled = true;
            rBInAllAS.Enabled = true;
            tBOldUser.Enabled = true;
            lblWarning.Text = "";
            for (int i = 0; i < listCode.Count; i++)
            {
                if (cBChooseAS.Text == listName[i])
                {
                    lblCodeAS.Text = listCode[i];
                }
            }
            LoadXml();
            btnAdd.Enabled = true;
            btnDel.Enabled = true;
            btnSearchInAdd.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rBInOneAS.Checked == false & rBInAllAS.Checked == false & rBInChoosenAS.Checked == false)
            {
                DialogResult dialogResult = MessageBox.Show("Не выбран фильтр для поиска", "Невозможен поиск", MessageBoxButtons.OK);
            }
            xDoc.Load("template.xml");
            ValuesChar();
            listSearchAdding.Clear();
            listSearchDeleting.Clear();
            listSearchFinal.Clear();
            listNothing.Clear();
            listASForSearchFinal.Clear();
            //listASForNothing.Clear();
            List<string> listSearch = new List<string>();
            listSearch.AddRange(tBEnter.Text.ToLower().Replace(" ", string.Empty).Split(signChar));
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            if (flag)
            {
                if (rBInAllAS.Checked)
                {
                    for (int i = 0; i < listSearch.Count; i++)
                    {
                        if (listSearch[i] != "")
                        {
                            for (int a = 0; a < listCode.Count; a++)
                            {
                                foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[a] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                                {
                                    if (xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[a] & xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(listSearch[i]))
                                    {
                                        listSearchFinal.Add(listSearch[i] + " содержится в (" + listName[a] + "), тип " + cBChooseIncident.Text/*lblTypeIncident.Text*/ + "\r\n");
                                        listSearchDeleting.Add(listSearch[i]);
                                        listASForSearchFinal.Add(listName[a]);
                                    }
                                    else
                                    {
                                        listNothing.Add(listSearch[i] + " не содержится в (" + listName[a] + "), тип " + lblTypeIncident.Text + "\r\n");
                                        listSearchAdding.Add(listSearch[i]);
                                        //listASForNothing.Add(listName[a]);
                                        if (i == listSearch.Count - 1 & a == listCode.Count - 1 & listSearchFinal.Count == 0)
                                        {
                                            listSearchFinal.Add("Ничего не найдено");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (rBInChoosenAS.Checked | (rBInOneAS.Checked & listView1.CheckedItems.Count == 1))
                {
                    for (int i = 0; i < listSearch.Count; i++)
                    {
                        for (int a = 0; a < listView1.CheckedItems.Count; a++)
                        {
                            foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listChooseMany[a] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                            {
                                if (xnode.ParentNode.Attributes.GetNamedItem("code").Value == listChooseMany[a] & xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(listSearch[i]))
                                {
                                    listSearchFinal.Add(listSearch[i] + " содержится в (" + listChooseNames[a] + "), тип " + lblTypeIncident.Text + "\r\n");
                                    listSearchDeleting.Add(listSearch[i]);
                                    listASForSearchFinal.Add(listName[a]);
                                }
                                else
                                {
                                    listNothing.Add(listSearch[i] + " не содержится в (" + listChooseNames[a] + "), тип " + lblTypeIncident.Text + "\r\n");
                                    listSearchAdding.Add(listSearch[i]);
                                    //listASForNothing.Add(listName[a]);
                                    if (i == listSearch.Count - 1 & a == listChooseMany.Count - 1 & listSearchFinal.Count == 0)
                                    {
                                        listSearchFinal.Add("Ничего не найдено");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (rBInOneAS.Checked)
                {
                    for (int i = 0; i < listSearch.Count; i++)
                    {
                        for (int j = 0; j < template.Count; j++)
                        {
                            if (listSearch[i] == template[j].ToLower())
                            {
                                listSearchFinal.Add(listSearch[i] + " содержится" + "\r\n");
                                j = template.Count - 1;
                            }
                            else
                            {
                                listNothing.Add(listSearch[i] + " содержится" + "\r\n");
                                if (j == template.Count - 1)
                                {
                                    listSearchFinal.Add(listSearch[i] + " не содержится" + "\r\n");
                                }
                            }
                        }
                    }
                }
                if (rBInAllAS.Checked)
                {
                    for (int i = 0; i < listSearch.Count; i++)
                    {
                        for (int a = 0; a < listCode.Count; a++)
                        {
                            foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[a] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                            {
                                if (rBInAllAS.Checked)
                                {
                                    if (xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[a] & xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(listSearch[i]))
                                    {
                                        listSearchFinal.Add(listSearch[i] + " содержится в (" + listName[a] + "), тип " + lblTypeIncident.Text + "\r\n");
                                        listSearchDeleting.Add(listSearch[i]);
                                        listASForSearchFinal.Add(listName[a]);
                                    }
                                    else
                                    {
                                        listNothing.Add(listSearch[i] + " не содержится в (" + listName[a] + "), тип " + lblTypeIncident.Text + "\r\n");
                                        listSearchAdding.Add(listSearch[i]);
                                        //listASForNothing.Add(listName[a]);
                                        if (i == listSearch.Count - 1 & a == listCode.Count - 1 & listSearchFinal.Count == 0)
                                        {
                                            listSearchFinal.Add("Ничего не найдено");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            tBResultOfSearch.Text = "";
            treeViewResultOfSearch.Nodes.Clear();
            TreeNode treeNode = new TreeNode("Найдено");
            treeViewResultOfSearch.Nodes.Add(treeNode);
            for (int i = 0; i < listSearchFinal.Count; i++)
            {
                if (listSearchFinal[i] != "")
                {
                    tBResultOfSearch.Text += listSearchFinal[i];
                    TreeNode subtreeNode = new TreeNode(listSearchFinal[i]);
                    treeViewResultOfSearch.Nodes[0].Nodes.Add(subtreeNode);
                }
            }
            TreeNode treeNode2 = new TreeNode("Не найдено");
            treeViewResultOfSearch.Nodes.Add(treeNode2);
            for (int i = 0; i < listNothing.Count; i++)
            {
                if (listNothing[i] != "")
                {
                    TreeNode subtreeNode = new TreeNode(listNothing[i]);
                    treeViewResultOfSearch.Nodes[1].Nodes.Add(subtreeNode);
                }
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            xDoc.Load("template.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            ValuesChar();
            ValuesString();
            if (flag)
            {
                for (int j = 0; j < listCode.Count; j++)
                {
                    for (int a = 0; a < listView1.CheckedItems.Count; a++)
                    {
                        foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                        {
                            for (int z = 0; z < tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar).Length; z++)
                            {
                                if (IsValidEmail(tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z]))
                                {
                                    if (xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z]))
                                    {
                                        if (listView1.CheckedItems[a].Text == listName[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                                        {
                                            DialogResult dialogResult = MessageBox.Show("Элемент " + tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z] + " уже содержится в " + listName[j], "Внимание", MessageBoxButtons.OK);
                                        }
                                    }
                                    if (!xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z]))
                                    {
                                        if (listView1.CheckedItems[a].Text == listName[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j] /*& !xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Intersect(tBEnter.Text.ToLower().Replace(" ", string.Empty).Split(signChar)).Any()*/)
                                        {
                                            if (!xnode.InnerText.EndsWith(signString))
                                            {
                                                xnode.InnerText += signString;
                                            }
                                            xnode.InnerText += tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z] + signChar;
                                            using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                                            {
                                                sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): " + tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z] + signChar);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                xDoc.Save("template.xml");
                LoadXml();
            }
            else
            {
                foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + lblCodeAS.Text + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                {
                    for (int z = 0; z < tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar).Length; z++)
                    {
                        if (!xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z]))
                        {
                            if (!xnode.InnerText.EndsWith(signString))
                            {
                                xnode.InnerText += signString;
                            }
                            xnode.InnerText += tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z] + signChar;
                            using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                            {
                                sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + cBChooseAS.Text + " (" + lblTypeIncident.Text + "): " + tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar)[z] + signChar);
                            }
                        }
                    }
                }
                xDoc.Save("template.xml");
                LoadXml();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            xDoc.Load("template.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            ValuesChar();
            ValuesString();
            templateMid.Clear();
            templateMid.AddRange(tBAdd.Text.ToLower().Replace(" ", string.Empty).Split(signChar));
            for (int i = 0; i < treeViewStructure.Nodes.Count; i++)
            {
                foreach (TreeNode item in treeViewStructure.Nodes[i].Nodes)
                {
                    if (item.Checked)
                    {
                        templateMid.Add(item.Text.ToLower().Replace(" ", string.Empty));
                    }
                }
            }
            if (flag)
            {
                for (int a = 0; a < listView1.CheckedItems.Count; a++)
                {
                    for (int j = 0; j < listCode.Count; j++)
                    {
                        foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                        {
                            if (listView1.CheckedItems[a].Text == listName[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                            {
                                templateFinal.Clear();
                                templateFinal.AddRange(xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar));
                                xnode.InnerText = "";
                                for (int i = 0; i < templateMid.Count; i++)
                                {
                                    while (templateFinal.Contains(templateMid[i]))
                                    {
                                        templateFinal.Remove(templateMid[i]);
                                    }
                                    using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                                    {
                                        sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение удалено из рассылки " + listName[j] + " (" + lblTypeIncident.Text + "): " + templateMid[i]);
                                    }
                                }
                                for (int i = 0; i < templateFinal.Count; i++)
                                {
                                    if (i != templateFinal.Count - 1)
                                    {
                                        xnode.InnerText += templateFinal[i] + signChar;
                                    }
                                    else
                                    {
                                        xnode.InnerText += templateFinal[i];
                                    }
                                }
                                if (xnode.InnerText.Last() != signChar)
                                {
                                    xnode.InnerText += signChar;
                                }
                            }
                        }
                    }
                }
                xDoc.Save("template.xml");
                LoadXml();
            }
            else
            {
                foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + lblCodeAS.Text + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                {
                    templateFinal.Clear();
                    templateFinal.AddRange(xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar));
                    xnode.InnerText = "";
                    for (int i = 0; i < templateMid.Count; i++)
                    {
                        while (templateFinal.Contains(templateMid[i]))
                        {
                            templateFinal.Remove(templateMid[i]);
                        }
                        using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                        {
                            sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение удалено из рассылки " + cBChooseAS.Text + " (" + lblTypeIncident.Text + "): " + templateMid[i]);
                        }
                    }
                    for (int i = 0; i < templateFinal.Count; i++)
                    {
                        if (i != templateFinal.Count - 1)
                        {
                            xnode.InnerText += templateFinal[i] + signChar;
                        }
                        else
                        {
                            xnode.InnerText += templateFinal[i];
                        }
                    }
                    if (xnode.InnerText.Last() != signChar)
                    {
                        xnode.InnerText += signChar;
                    }
                }
                xDoc.Save("template.xml");
                LoadXml();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count != 0)
            {
                flag = true;
                LoadXml();
                rBInAllAS.Enabled = true;
                rBInChoosenAS.Enabled = true;
                tBOldUser.Enabled = true;
                lblWarning.Text = "";
                if (listView1.CheckedItems.Count == 1)
                {
                    rBInOneAS.Enabled = true;
                }
                else
                {
                    rBInOneAS.Enabled = false;
                }
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnSearchInAdd.Enabled = true;
            }
        }

        public void LoadTreeViewStructure()
        {
            treeViewStructure.Nodes.Clear();
            //treeViewStructure.Nodes.Nodes.Clear();
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            for (int i = 0; i < listChooseMany.Count; i++)
            {
                foreach (XmlElement childnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listChooseMany[i] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                {
                    for (int j = 0; j < listCopy.Count; j++)
                    {
                        if (childnode.ParentNode.Attributes.GetNamedItem("code").Value /*listCode[i]*/ == listCopy[j])
                        {
                            TreeNode treeNode = new TreeNode(listChooseNames[i]);
                            if (childnode.InnerText == string.Empty)
                            {
                                treeNode.Text += " (Всего записей: 0)";
                            }
                            else
                            {
                                if (childnode.InnerText.Last() == signChar)
                                {
                                    treeNode.Text += " (Всего записей: " + (childnode.InnerText.Replace(" ", string.Empty).Split(signChar).Count() - 1) + ")";
                                }
                                //if (childnode.InnerText.First() == signChar)
                                //{
                                //    childnode.InnerText.First() = string.Empty;
                                //}
                                else
                                {
                                    treeNode.Text += " (Всего записей: " + childnode.InnerText.Replace(" ", string.Empty).Split(signChar).Count() + ")";
                                }
                            }
                            treeViewStructure.Nodes.Add(treeNode);
                            template.Clear();
                            template.AddRange(childnode.InnerText.Replace(" ", string.Empty).Split(signChar));
                            for (int a = 0; a < template.Count; a++)
                            {
                                template.Sort();
                                if (template[a] != ""/* & treeViewStructure.Nodes[j].Nodes != null*/)
                                {
                                    TreeNode subtreeNode = new TreeNode(template[a]);
                                    treeViewStructure.Nodes[i].Nodes.Add(subtreeNode);
                                }
                            }
                            listCopy.Remove(listCopy[j]);
                            j = listCopy.Count - 1;
                        }
                    }
                }
            }
            //treeViewStructure.Sort();
        }

        public void LoadXml()
        {
            template.Clear();
            xDoc.Load("template.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            //tBFinal.Text = "";
            ValuesChar();
            if (flag)
            {
                listChooseMany.Clear();
                listChooseNames.Clear();
                for (int i = 0; i < listView1.CheckedItems.Count; i++)
                {
                    for (int j = 0; j < listName.Count; j++)
                    {
                        if (listView1.CheckedItems[i].Text == listName[j])
                        {
                            listChooseMany.Add(listCode[j]);
                            listChooseNames.Add(listName[j]);
                        }
                    }
                }
                listCopy.Clear();
                listCopy.AddRange(listCode);
                //for (int i = 0; i < listCode.Count; i++)
                //{
                //    foreach (XmlElement childnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[i] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                //    {
                //        for (int j = 0; j < listChooseMany.Count; j++)
                //        {
                //            if (childnode.ParentNode.Attributes.GetNamedItem("code").Value /*listCode[i]*/ == listChooseMany[j])
                //            {
                //                //textbox lagaet, nuzhno drugoe chto-to
                //                //template.Clear();
                //                //template.Add(listChooseNames[j] + ":" + "\r\n");
                //                //template.AddRange(childnode.InnerText.Replace(" ", string.Empty).Split(signChar));
                //                //template.Add("--------------------------------------------");
                //                //for (int z = 0; z < template.Count; z++)
                //                //{
                //                   // tBFinal.Text += childnode.InnerText + "\r\n";
                //                //}
                //            }
                //        }
                //    }
                //}
                LoadTreeViewStructure();
            }
            else
            {
                treeViewStructure.Nodes.Clear();
                foreach (XmlElement childnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + lblCodeAS.Text + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                {
                    template.AddRange(childnode.InnerText.Replace(" ", string.Empty).Split(signChar));
                    template.Sort();
                    for (int i = 0; i < template.Count; i++)
                    {
                        if (template[i] != ""/* & treeViewStructure.Nodes[j].Nodes != null*/)
                        {
                            //tBFinal.Text += template[i] + "\r\n";
                            TreeNode treeNode = new TreeNode(template[i]);
                            treeViewStructure.Nodes.Add(treeNode);
                        }
                    }
                }
                //treeViewStructure.Sort();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tBEnter.Text = "";
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
            groupBox1.Enabled = true;
        }

        private void rBtnMail_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Enabled = true;
            cBChooseAS.Enabled = true;
            btnChooseAllASInlV.Enabled = true;
            treeViewStructure.Nodes.Clear();
            //tBFinal.Text = "";
            if (cBChooseAS.Text != "" | listView1.CheckedItems.Count != 0)
            {
                LoadXml();
            }
        }

        private void rBtnCallNumber_CheckedChanged(object sender, EventArgs e) // объединить в 1 метод
        {
            listView1.Enabled = true;
            cBChooseAS.Enabled = true;
            btnChooseAllASInlV.Enabled = true;
            treeViewStructure.Nodes.Clear();
            //tBFinal.Text = "";
            if (cBChooseAS.Text != "" | listView1.CheckedItems.Count != 0)
            {
                LoadXml();
            }
        }

        public void ValuesChar() //объединить
        {
            if (rBtnMail.Checked)
            {
                way = "']//copy";
                signChar = ';';
            }
            if (rBtnCallNumber.Checked)
            {
                way = "']//numbers";
                signChar = ',';
            }
        }

        public void ValuesString()
        {
            if (rBtnMail.Checked)
            {
                way = "']//copy";
                signString = ";";
            }
            if (rBtnCallNumber.Checked)
            {
                way = "']//numbers";
                signString = ",";
            }
        }

        private void btnAddNewUser_Click(object sender, EventArgs e)
        {
            ValuesChar();
            ValuesString();
            xDoc.Load("template.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            for (int a = 0; a < listView2.CheckedItems.Count; a++)
            {
                for (int j = 0; j < listCode.Count; j++)
                {
                    foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                    {
                        if (listView2.CheckedItems[a].Text == listName[j] & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                        {
                            if (!xnode.InnerText.EndsWith(signString))
                            {
                                xnode.InnerText += signString;
                            }
                            xnode.InnerText += tBNewUser.Text.ToLower().Replace(" ", string.Empty).Split(signChar);
                            if (!tBNewUser.Text.EndsWith(signString))
                            {
                                xnode.InnerText += signString;
                            }
                            using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                            {
                                sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): " + tBNewUser.Text.ToLower().Replace(" ", string.Empty).Split(signChar));
                            }
                        }
                    }
                }
            }
            xDoc.Save("template.xml");
            LoadXml();
        }

        private void btnSearchInAdd_Click(object sender, EventArgs e)
        {
            listView2.Clear();
            xDoc.Load("template.xml");
            ValuesChar();
            List<string> listSearch = new List<string>();
            listSearch.AddRange(tBOldUser.Text.ToLower().Replace(" ", string.Empty).Split(signChar));
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            for (int i = 0; i < listSearch.Count; i++)
            {
                for (int a = 0; a < listCode.Count; a++)
                {
                    if (tBOldUser.Text != "")
                    {
                        foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[a] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                        {
                            if (xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[a] & xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(listSearch[i]))
                            {
                                listView2.Items.Add(listName[a]);
                            }
                        }
                    }
                }
            }
            listView2.Enabled = true;
            tBNewUser.Enabled = true;
            btnChooseAllASInlV2.Enabled = true;
            btnAddNewUser.Enabled = true;
        }

        private void btnChooseAllASInlV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Если выбрано несколько АС, выбранный элемент удалится во всех выбранных АС (можно не выбирать этот элемент везде, с дублями (если присутствуют изначально, хоть и нельзя добавить значение, если оно уже имеется) ситуация аналогичная.", "Справка", MessageBoxButtons.OK);
        }

        private void btnChooseAllASInlV2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView2.Items)
            {
                item.Checked = true;
            }
        }

        private void btnMainHelp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Введите почту получателя или нескольких получателей, разделяя знаком ';' - точка с запятой (номера телефона разделять знаком ',' - запятая)", "Справка", MessageBoxButtons.OK);
        }

        private void btnCreateNewAS_Click(object sender, EventArgs e)
        {
            CreateNewAS CNAS = new CreateNewAS();
            CNAS.ShowDialog();
            FirstLoadXml();
        }

        private void btnCreateNewTypeOfIncident_Click(object sender, EventArgs e)
        {
            CreateNewTypeOfIncident CNTI = new CreateNewTypeOfIncident();
            CNTI.ShowDialog();
        }

        private void btnAddFromSearch_Click(object sender, EventArgs e)
        {
            xDoc.Load("template.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            ValuesChar();
            ValuesString();
            templateMid.Clear();
            listASForSearchFinal.Clear();
            //for (int i = 0; i < treeViewResultOfSearch.Nodes.Count; i++)
            //{
                foreach (TreeNode item in treeViewResultOfSearch.Nodes[1].Nodes)
                {
                    if (item.Checked)
                    {
                        templateMid.Add(item.Text.Substring(0, item.Text.IndexOf(' '))/*.ToLower().Replace(" ", string.Empty)*/);
                        listASForSearchFinal.Add(item.Text);
                    }
                }
            //}
            for (int j = 0; j < listCode.Count; j++)
            {
                for (int a = 0; a < templateMid.Count; a++)
                {
                    foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                    {
                        if (listASForSearchFinal[a].Contains(listName[j]) & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                        {
                            templateFinal.Clear();
                            templateFinal.AddRange(xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar));
                            //for (int i = 0; i < templateFinal.Count; i++)
                            //{
                            //    if (templateMid[a].Contains(templateFinal[i]))
                            //    {
                            //        templateFinal.Remove(templateFinal[i]);
                            //    }
                            //}
                            //for (int z = 0; z < templateFinal.Count; z++)
                            //{
                            if (IsValidEmail(templateMid[a]/*.Substring(0, templateFinal[z].IndexOf(' '))*/))
                            {
                                if (xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(templateMid[a]/*.Substring(0, templateFinal[z].IndexOf(' '))*/))
                                {
                                    if (xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Элемент " + templateMid[a]/*.Substring(0, templateFinal[z].IndexOf(' '))*/ + " уже содержится в " + listName[j], "Внимание", MessageBoxButtons.OK);
                                    }
                                }
                                if (!xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Contains(templateMid[a]/*.Substring(0, templateFinal[z].IndexOf(' '))*/))
                                {
                                    if (xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j] /*& !xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar).Intersect(tBEnter.Text.ToLower().Replace(" ", string.Empty).Split(signChar)).Any()*/)
                                    {
                                        if (!xnode.InnerText.EndsWith(signString))
                                        {
                                            xnode.InnerText += signString;
                                        }
                                        xnode.InnerText += templateMid[a]/*.Substring(0, templateFinal[z].IndexOf(' '))*/ + signChar;
                                        using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                                        {
                                            sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение добавлено в рассылку " + listName[j] + " (" + lblTypeIncident.Text + "): " + templateMid[a] + signChar);
                                        }
                                    }
                                }
                            }
                            //}
                        }
                    }
                }
            }
            xDoc.Save("template.xml");
            LoadXml();
        }

        private void btnDelFromSearch_Click(object sender, EventArgs e)
        {
            xDoc.Load("template.xml");
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            ValuesChar();
            ValuesString();
            templateMid.Clear();
            for (int i = 0; i < treeViewResultOfSearch.Nodes.Count; i++)
            {
                foreach (TreeNode item in treeViewResultOfSearch.Nodes[0].Nodes)
                {
                    if (item.Checked)
                    {
                        templateMid.Add(item.Text/*.ToLower().Replace(" ", string.Empty)*/);
                    }
                }
            }
            //for (int a = 0; a < listASForSearchFinal.Count; a++)
            //{
            for (int j = 0; j < listCode.Count; j++)
            {
                for (int z = 0; z < templateMid.Count; z++)
                {
                    foreach (XmlElement xnode in xDoc.SelectNodes(".//Reciepients//list[@code='" + listCode[j] + "' and @reason='" + lblTypeIncident.Text + way, nsmgr))
                    {
                        if (templateMid[z].Contains(listName[j]) & xnode.ParentNode.Attributes.GetNamedItem("code").Value == listCode[j])
                        {
                            templateFinal.Clear();
                            templateFinal.AddRange(xnode.InnerText.ToLower().Replace(" ", string.Empty).Split(signChar));
                            xnode.InnerText = "";
                            for (int i = 0; i < templateFinal.Count; i++)
                            {
                                if (templateMid[z].Contains(templateFinal[i]))
                                {
                                    using (StreamWriter sw = new StreamWriter(writePath, true, Encoding.Default))
                                    {
                                        sw.WriteLine("Логин: " + userName + ", ip: " + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0].ToString() + ", дата и время: " + DateTime.UtcNow.AddHours(3) + " (по МСК), следующее значение удалено из рассылки " + listName[j] + " (" + lblTypeIncident.Text + "): " + templateFinal[i]);
                                    }
                                    templateFinal.Remove(templateFinal[i]);
                                }
                            }
                            for (int i = 0; i < templateFinal.Count; i++)
                            {
                                if (i != templateFinal.Count - 1)
                                {
                                    xnode.InnerText += templateFinal[i] + signChar;
                                }
                                else
                                {
                                    xnode.InnerText += templateFinal[i];
                                }
                            }
                            if (xnode.InnerText.Last() != signChar)
                            {
                                xnode.InnerText += signChar;
                            }
                        }
                    }
                }
            }
            //}
            xDoc.Save("template.xml");
            LoadXml();
        }
    }
}

