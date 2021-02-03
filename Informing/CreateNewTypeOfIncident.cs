using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Informing
{
    public partial class CreateNewTypeOfIncident : Form
    {
        public CreateNewTypeOfIncident()
        {
            InitializeComponent();
            LoadXml();
        }
        List<string> listNameIncident = new List<string>();
        List<string> listReasonIncident = new List<string>();
        XmlDocument xDoc = new XmlDocument();

        private void LoadXml()
        {
            listNameIncident.Clear();
            listReasonIncident.Clear();
            xDoc.Load("template.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            foreach (XmlElement xnode in xRoot)
            {
                if (xnode.Name == "themeList")
                {
                    foreach (XmlElement childnode in xnode.ChildNodes)
                    {
                        listNameIncident.Add(childnode.Attributes.GetNamedItem("name").Value);
                        listReasonIncident.Add(childnode.Attributes.GetNamedItem("reason").Value);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            xDoc.Load("template.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xDoc.NameTable);
            for (int j = 0; j < listReasonIncident.Count; j++)
            {
                foreach (XmlElement xnode in xDoc.SelectNodes(".//themeList//theme[@name='" + listNameIncident[j] + "' and @reason='" + listReasonIncident[j] + "']", nsmgr))
                {
                    if (tBNameOfTypeOfIncident.Text == listNameIncident[j] || tBCode.Text == listReasonIncident[j])
                    {
                        DialogResult dialogResult = MessageBox.Show("Тип инцидента уже создан", "Внимание", MessageBoxButtons.OK);
                        return;
                    }
                }
            }

            XmlElement userElem3 = xDoc.CreateElement("themeList");
            XmlElement userElem4 = xDoc.CreateElement("theme");

            XmlAttribute nameAttr1 = xDoc.CreateAttribute("name");
            XmlAttribute reasonAttr1 = xDoc.CreateAttribute("reason");
            XmlAttribute messageAttr1 = xDoc.CreateAttribute("message");
            XmlAttribute needIncAttr1 = xDoc.CreateAttribute("needInc");

            XmlText nameText1 = xDoc.CreateTextNode(tBNameOfTypeOfIncident.Text);
            XmlText reasonText1 = xDoc.CreateTextNode(tBCode.Text);
            XmlText messageText1 = xDoc.CreateTextNode(tBMessage.Text);
            XmlText needIncText1 = xDoc.CreateTextNode(tBneedInc.Text);

            nameAttr1.AppendChild(nameText1);
            reasonAttr1.AppendChild(reasonText1);
            messageAttr1.AppendChild(messageText1);
            needIncAttr1.AppendChild(needIncText1);

            userElem4.Attributes.Append(nameAttr1);
            userElem4.Attributes.Append(reasonAttr1);
            userElem4.Attributes.Append(messageAttr1);
            userElem4.Attributes.Append(needIncAttr1);

            userElem3.AppendChild(userElem4);

            xRoot.AppendChild(userElem3);
            xDoc.Save("template.xml");
        }
    }
}
