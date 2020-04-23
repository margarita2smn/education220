using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Threading.Tasks;

namespace WindowsFormsApp4.Controller
{
    class Ouer
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;

        public Query(string conn);
       
        Connection = new OleDbConnection(Conn);
        BufferTable = DataTable();
    }
    public DataTable UpdatePerson();
    
    connection.open();
        dataAdapter = OleDbDataAdapter("SELECT * FROM Person", ConnectionState);
}
    
}
}
