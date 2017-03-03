using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//my references
using System.Xml;
using System.IO;
//using System.Text;
using System.Diagnostics;
using net.jsBeautifier;

namespace JSact
{
    class ParseDOM
    {
        public void GetJScript(string strUpdateSet)
        {


            PrepareUpdateSet(strUpdateSet);

            #region Commented code
            //XmlDocument xdUpdateSet = new XmlDocument();

            ////string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            ////if (xdUpdateSet.Supports(  .StartsWith(_byteOrderMarkUtf8))
            ////{
            ////    xdUpdateSet = xdUpdateSet.RemoveChild(0, _byteOrderMarkUtf8.Length);
            ////}

            //xdUpdateSet.Load(strUpdateSet+".bac");

            //XmlNode xnRoot = xdUpdateSet.DocumentElement;

            //XmlNodeList xnlScripts = xnRoot.SelectNodes("script");

            //string strJS = string.Empty;
            //foreach (XmlNode xnJS in xnlScripts)
            //{
            //    strJS = xnJS.InnerXml;
            //    Debug.WriteLine(strJS.ToString());
            //}
            //return strJS;
            #endregion
        }

        private void PrepareUpdateSet(string strUSPath)
        {
            FileStream fs;
           
            string line = string.Empty;
            bool hasScriptStart=false;
           // bool hasScriptEnd = false;
            StreamReader sr = new StreamReader(strUSPath);
            int scriptstartpos=0;
            //int scriptendpos=0;
           // int nextbyte;
            int charcount = 0;
            string strBuff = string.Empty;


            while ((line = sr.ReadLine()) != null)
            {
                charcount = charcount + line.Count();

                if (line.Contains("<script>") && !hasScriptStart){
                    hasScriptStart = true;
                    charcount = charcount - line.Count();
                    scriptstartpos = charcount + line.IndexOf("<script>");
                    int endpoint = charcount + line.IndexOf("</script>");
                    endpoint = endpoint-scriptstartpos;
                    strBuff = line.Substring(line.IndexOf("<script>"),endpoint+9); 
                }

                #region commented code
                //if (line.Contains("</script>") && !hasScriptEnd)
                //{
                //    hasScriptEnd = true;
                //    scriptendpos = scriptstartpos + line.IndexOf("</script>");

                //}
                #endregion
            }


            sr.Close();

            string strFolder = string.Empty;
            strFolder = strUSPath.Substring(0,strUSPath.LastIndexOf("\\"));
            strFolder = strFolder + "\\Results";
            DirectoryInfo di = Directory.CreateDirectory(strFolder);
            char[] buffarray = new char[10000]; // strBuff.ToCharArray();
            fs=File.Open(di.FullName+"\\Results.js", FileMode.Append);

            strBuff = RemoveCData(strBuff);

            if (strBuff.Length >0)
            {
                buffarray = strBuff.ToCharArray();

                foreach (char ch in buffarray)
                {
                    Debug.Write(ch);
                    fs.WriteByte(Convert.ToByte(ch));
                }

                byte[] newline = Encoding.ASCII.GetBytes(Environment.NewLine);
                fs.Write(newline, 0, newline.Length);
                fs.Write(newline, 0, newline.Length);
                fs.Flush();

                #region commented code
                //while ((nextbyte = fs.ReadByte()) > 0)
                //{
                //    strBuff.ToCharArray()
                //    Debug.Write(Convert.ToChar(nextbyte));
                //    fsnew.WriteByte(Convert.ToByte(nextbyte));
                //}
                //fsnew.Flush();

                //fsnew.Seek(scriptendpos + 1, SeekOrigin.End);
                //nextbyte = 0;
                //while ((nextbyte = fsnew.ReadByte()) > 0)
                //{
                //    Debug.Write(Convert.ToChar(nextbyte));
                //    fsnew.WriteByte(Convert.ToByte(nextbyte));
                //}
                //fsnew.Flush();
                #endregion
            }
          

            fs.Close();

            JsBeautifier jsb = new JsBeautifier();
            //jsb.
            
           
        }

        private string RemoveCData(string strXMLWithCData)
        {
            string strCleaned = String.Empty;

            strCleaned = strXMLWithCData.Replace("<script><![CDATA[", string.Empty);
            strCleaned = strCleaned.Replace("]]></script>", string.Empty);
            
            return strCleaned;
        }
    }
}
