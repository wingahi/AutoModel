using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoModel.Model
{
    public class Table
    {
        private string tableName;
        public string TableName
        {
            get
            {
                return tableName;
            }
            set
            {
                tableName = value;
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

        private List<Column> columns;
        public List<Column> Columns
        {
            get
            {
                return columns;
            }
            set
            {
                columns = value;
            }
        }

        private int tableId;
        public int TableId
        {
            get
            {
                return tableId;
            }
            set
            {
                tableId = value;
            }
        }
    }
}
