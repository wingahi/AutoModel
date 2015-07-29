using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoModel.Model
{
    public class Column
    {
        private int columnId;
        public int ColumnId
        {
            get
            {
                return columnId;
            }
            set
            {
                columnId = value;
            }
        }

        private string columnName;
        public string ColumnName
        {
            get
            {
                return columnName;
            }
            set
            {
                columnName = value;
            }
        }

        private string type;
        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private bool isPrimaryKey = false;
        public bool IsPrimaryKey
        {
            get
            {
                return isPrimaryKey;
            }
            set
            {
                isPrimaryKey = value;
            }
        }

        private bool isIdentity = false;
        public bool IsIdentity
        {
            get { return isIdentity; }
            set { isIdentity = value; }
        }
    }
}
