using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISqlHelper
    {
        int ExecuteNonQuery(string Query);
        int ExecuteScalar(string Query);

        DataTable GetDataTable(string Query);
    }
}
