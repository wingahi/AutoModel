using AutoModel.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace AutoModel.Common
{
    public sealed class Util
    {
        /// <summary>
        /// 数据库类型-C#类型转换
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string GetTypeFromDbType(string type)
        {
            string result = string.Empty;
            type = type.Substring(0, type.IndexOf("(")).ToLower();
            switch (type)
            {
                case "smallint":
                    result = "short";
                    break;

                case "int":
                    result = "int";
                    break;

                case "nchar":
                case "char":
                case "nvarchar":
                case "varchar":
                case "ntext":
                case "text":
                    result = "string";
                    break;
                case "timestamp":
                case "smalldatetime":
                case "datetime":
                case "date":
                    result = "Datetime";
                    break;

                case "bigint":
                    result = "long";
                    break;

                case "real":
                    result = "Single";
                    break;

                case "float":
                    result = "double";
                    break;

                case "smallmoney":
                case "money":
                case "numeric":
                case "decimal":
                    result = "decimal";
                    break;
                case "varbinary":
                case "image":
                case "binary":
                    result = "byte[]";
                    break;

                case "tinyint":
                    return "byte";
                case "bit ":
                    result = "bool";
                    break;

                case "uniqueidentifier":
                    result = "Guid";
                    break;
                case "variant":
                    result = "object";
                    break;
                default:
                    result = "object";
                    break;
            }
            return result;
        }
        public static string FieldNameConvert(string fieldName)
        {
            string result = string.Empty;
            char captal = fieldName[0];
            string offfield=fieldName.Substring(1);
            if (captal >= 'A' && captal <= 'Z')
            {
                result = captal.ToString().ToLower() + offfield;
            }
            else
            {
                result = "_"+captal;
            }
            return result;
        }

        public static T GetServerInfo<T>()
            where T:new()
        {
            if (File.Exists("data.txt"))
            {
                using (StreamReader sr = new StreamReader("data.txt"))
                {
                    string strdata = sr.ReadToEnd();
                    if (strdata != null)
                    {
                        string[] dataArray = strdata.Split(new string[] { "\r\n" },StringSplitOptions.RemoveEmptyEntries);
                        if(dataArray!=null && dataArray.Length>0)
                        {
                            T model = new T();
                            foreach (var item in dataArray)
                            {
                                string[] itemArray = item.Split('=');
                                if (itemArray != null && itemArray.Length == 2)
                                {
                                    PropertyInfo propertyInfo = model.GetType().GetProperty(itemArray[0]);
                                    propertyInfo.SetValue(model, itemArray[1], null);
                                }
                            }
                            return model;
                        }
                    }
                }
            }
            return default(T);
        } 
    }
}
