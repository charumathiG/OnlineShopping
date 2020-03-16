using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Extensions.Configuration;

namespace EcommerceDAL.RepositoryPattern
{
        public class BaseDAL : IBaseDAL
        {
            public SqlConnection connection;

            private readonly IConfiguration configuration;
            public string ConnectionString { get; }

            public BaseDAL()
            {
                //_configuration = configuration;
                ConnectionString = configuration.GetConnectionString("DefaultConnection");
            }

            public void CloseConnection()
            {
                CloseConnection(connection);
            }

            public void CloseConnection(SqlConnection connection)
            {
                connection.Close();
            }
            public SqlParameter CreateParameter(string name, int size, object value, DbType dbType)
            {
                return CreateParameter(name, size, value, dbType, ParameterDirection.Input);
            }
            public SqlParameter CreateParameter(string name, object value, DbType dbType)
            {
                return CreateParameter(name, 0, value, dbType, ParameterDirection.Input);
            }
            public SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
            {
                return new SqlParameter
                {
                    DbType = dbType,
                    ParameterName = name,
                    Size = size,
                    Direction = direction,
                    Value = value
                };
            }
            public DataSet GetData(string commandtext, CommandType commandtype, SqlParameter[] parameters = null)
            {
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(commandtext, connection))
                    {
                        command.CommandType = commandtype;
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        var dataset = new DataSet();
                        var dataAdapter = new SqlDataAdapter(command);
                        dataAdapter.Fill(dataset);
                        return dataset;
                    }
                }
            }
            public int Insert(string commandtext, CommandType commandType, SqlParameter[] parameters, out int lastId)
            {
                lastId = 0;
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(commandtext, connection))
                    {
                        command.CommandType = commandType;
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        lastId = command.ExecuteNonQuery();
                    }
                }
                return lastId;
            }

            public bool Update(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status)
            {
                int result = 0;
                status = false;
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(commandtext, connection))
                    {
                        command.CommandType = commandType;
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        result = command.ExecuteNonQuery();
                    }
                }
                if (result == 1)
                {
                    status = true;
                }
                return status;
            }

            public bool Delete(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status)
            {
                int result = 0;
                status = false;
                using (var connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (var command = new SqlCommand(commandtext, connection))
                    {
                        command.CommandType = commandType;
                        if (parameters != null)
                        {
                            foreach (var parameter in parameters)
                            {
                                command.Parameters.Add(parameter);
                            }
                        }
                        result = command.ExecuteNonQuery();
                    }
                }
                if (result == 1)
                {
                    status = true;
                }
                return status;
            }
        }
    }
