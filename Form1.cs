using AutoModel.Common;
using AutoModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //获取服务器信息文件
            ServerInfo serverInfo = Util.GetServerInfo<ServerInfo>();
            if (serverInfo != null)
            {
                this.txtServer.Text = serverInfo.server;
                this.txtUserName.Text = serverInfo.username;
                this.txtPwd.Text = serverInfo.pwd;
                this.txtDbName.Text = serverInfo.database;
                this.txtTables.Text = serverInfo.tables;
                this.txtNameSpace.Text = serverInfo.name_space;
            }
        }

        private void Btncreate_Click(object sender, EventArgs e)
        {
            StartCreate();
        }
        private void StartCreate()
        {
            string namespacestr = txtNameSpace.Text.Trim();
            if (namespacestr.Length <= 0)
            {
                namespacestr = "Model";
            }
            string connString = "Server=" + this.txtServer.Text;
            connString += ";UID=" + this.txtUserName.Text;
            connString += ";PWD=" + this.txtPwd.Text;
            connString += ";DataBase=" + this.txtDbName.Text;
            Dbinfo.ConnString = connString;
            List<Table> tables;
            try
            {
                tables = Dbinfo.GetTables(this.txtTables.Text.Trim());
                CreateDirectory(namespacestr);
                foreach (var item in tables)
                {
                    WriteFile(namespacestr, item);
                }
            }
            catch (Exception ex)
            {
                return;
            }
            Btncreate.Text = "生成完成";
        }

        private static void CreateDirectory(string namespacestr)
        {
            if (!Directory.Exists(Application.StartupPath + "\\" + namespacestr))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\" + namespacestr);
            }
        }

        private static void WriteFile(string namespacestr, Table item)
        {
            using (StreamWriter sw = new StreamWriter(Application.StartupPath + "\\" + namespacestr + "\\" + item.TableName + ".cs", false))
            {
                StringBuilder sbText = FormatString(namespacestr, item);
                sw.Write(sbText.ToString());
            }
        }

        private static StringBuilder FormatString(string namespacestr, Table item)
        {
            StringBuilder sbText = new StringBuilder();
            sbText.AppendLine("namespace " + namespacestr);
            sbText.AppendLine("{");
            sbText.AppendLine("    public class " + item.TableName);
            sbText.AppendLine("    {");
            foreach (var col in item.Columns)
            {
                string fieldName = Util.FieldNameConvert(col.ColumnName);
                sbText.AppendLine("        private " + Util.GetTypeFromDbType(col.Type) + " " + fieldName + ";");
                sbText.AppendLine("        public " + Util.GetTypeFromDbType(col.Type) + " " + col.ColumnName);
                sbText.AppendLine("        {");
                sbText.AppendLine("            get { return " + fieldName + "; }");
                sbText.AppendLine("            set { " + fieldName + "=value; }");
                sbText.AppendLine("        }");
            }
            sbText.AppendLine("    }");
            sbText.AppendLine("}");
            return sbText;
        }
        
    }
}
