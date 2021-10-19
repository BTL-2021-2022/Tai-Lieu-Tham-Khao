using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace StoreApp.Models
{
    class StroredUserData
    {
        static XmlDocument doc;
        static XmlElement root;
        static string fileName;
        public StroredUserData()
        {
            fileName = "user_data.xml";
            doc = new XmlDocument();
            if (!File.Exists("user_data.xml"))
            {
                XmlElement app = doc.CreateElement("app_store");
                doc.AppendChild(app);
                doc.Save(fileName);
            }

            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void Store(Nguoiquanly user)
        {
            XmlElement data = doc.CreateElement("user_data");
            data.SetAttribute("manql", user.MaNql);
            XmlElement name = doc.CreateElement("name");
            name.InnerText = user.TenNql;
            XmlElement address = doc.CreateElement("address");
            address.InnerText = user.DiaChiNql;
            XmlElement tinhtrang = doc.CreateElement("status");
            tinhtrang.InnerText = user.TinhTrang;
            XmlElement sdt = doc.CreateElement("phone");
            sdt.InnerText = user.Sdtnql;


            data.AppendChild(name);
            data.AppendChild(address);
            data.AppendChild(tinhtrang);
            data.AppendChild(sdt);
            root.AppendChild(data);
            doc.Save(fileName);
        }
             
        public void DeleteData()
        {
            root.RemoveAll();
            doc.Save(fileName);
        }

        public string getStatus()
        {
            XmlNode usfind = root.SelectSingleNode("user_data");

            if (usfind != null)
            {
                return usfind.SelectSingleNode("status").InnerText;
            }
            return "";
        }
        public string getMaql()
        {
            XmlNode usfind = root.SelectSingleNode("user_data");
            if (usfind!= null)
            {
                 return usfind.Attributes[0].InnerText;

            }
            return "";
        }
        public string getTen()
        {
            XmlNode usfind = root.SelectSingleNode("user_data");

            if (usfind != null)
            {
                return usfind.SelectSingleNode("name").InnerText;
            }
            return "";
        }
    }
}
