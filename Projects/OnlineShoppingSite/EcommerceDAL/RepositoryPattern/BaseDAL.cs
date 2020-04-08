// <copyright file="BaseDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;
    using Microsoft.Extensions.Configuration;

    /// <summary>
    /// Implementation of a Class.
    /// </summary>
    public class BaseDAL : IBaseDAL
        {
            private SqlConnection connection;

            private IConfiguration configuration;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseDAL"/> class.
        /// </summary>
        /// <param name="configuration">configuration.</param>
            public BaseDAL(IConfiguration configuration)
            {
            this.configuration = configuration;
            this.ConnectionString = configuration.GetConnectionString("DefaultConnection");
            }

        /// <summary>
        /// Gets or sets implementation of property.
        /// </summary>
            public string ConnectionString { get; set; }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
            public void CloseConnection()
            {
                this.CloseConnection(this.connection);
            }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="connection">connection.</param>
            public void CloseConnection(SqlConnection connection)
            {
                connection.Close();
            }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="value">value.</param>
        /// <param name="dbType">dbType.</param>
        /// <returns>values.</returns>
            public SqlParameter CreateParameter(string name, int size, object value, DbType dbType)
            {
                return this.CreateParameter(name, size, value, dbType, ParameterDirection.Input);
            }

        /// <summary>
        ///  Implementation of Method.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="value">value.</param>
        /// <param name="dbType">dbType.</param>
        /// <returns> values.</returns>
            public SqlParameter CreateParameter(string name, object value, DbType dbType)
            {
                return this.CreateParameter(name, 0, value, dbType, ParameterDirection.Input);
            }

        /// <summary>
        ///  Implementation of Method.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="value">value.</param>
        /// <param name="dbType">dbType.</param>
        /// <param name="direction">direction.</param>
        /// <returns>values.</returns>
            public SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction)
            {
                return new SqlParameter
                {
                    DbType = dbType,
                    ParameterName = name,
                    Size = size,
                    Direction = direction,
                    Value = value,
                };
            }

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandtype">commandtype.</param>
        /// <param name="parameters">parameters.</param>
        /// <returns> values.</returns>
            public DataSet GetData(string commandtext, CommandType commandtype, List<SqlParameter> parameters = null)
            {
                using (var connection = new SqlConnection(this.ConnectionString))
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

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandType">commandType.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="lastId">lastId.</param>
        /// <returns>values.</returns>
            public int Insert(string commandtext, CommandType commandType, SqlParameter[] parameters, out int lastId)
            {
                lastId = 0;
                using (var connection = new SqlConnection(this.ConnectionString))
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

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandType">commandType.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="status">status.</param>
        /// <returns>values.</returns>
            public bool Update(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status)
            {
                int result = 0;
                status = false;
                using (var connection = new SqlConnection(this.ConnectionString))
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

        /// <summary>
        /// Implementation of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandType">commandType.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="status">status.</param>
        /// <returns>values.</returns>
            public bool Delete(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status)
            {
                int result = 0;
                status = false;
                using (var connection = new SqlConnection(this.ConnectionString))
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
