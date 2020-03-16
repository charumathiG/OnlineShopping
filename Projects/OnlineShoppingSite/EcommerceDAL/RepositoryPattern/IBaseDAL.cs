using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace EcommerceDAL.RepositoryPattern
{
     public interface IBaseDAL
    {

        int Insert(string commandtext, CommandType commandType, SqlParameter[] parameters, out int lastId);
        bool Update(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status);
        bool Delete(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status);
        DataSet GetData(string commandtext, CommandType commandtype, SqlParameter[] parameters = null);
        SqlParameter CreateParameter(string v1, int v2, object customerName, DbType @string);
        SqlParameter CreateParameter(String name, Object value, DbType dbType);
        SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction);

    }
}
