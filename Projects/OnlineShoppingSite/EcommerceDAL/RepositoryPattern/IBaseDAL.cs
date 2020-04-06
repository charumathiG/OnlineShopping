// <copyright file="IBaseDAL.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EcommerceDAL.RepositoryPattern
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Text;

    /// <summary>
    /// Implementation of Interface.
    /// </summary>
    public interface IBaseDAL
    {
        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandType">commandType.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="lastId">lastId.</param>
        /// <returns>value.</returns>
        int Insert(string commandtext, CommandType commandType, SqlParameter[] parameters, out int lastId);

        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandType">commandType.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="status">status.</param>
        /// <returns>value.</returns>
        bool Update(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status);

        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandType">commandType.</param>
        /// <param name="parameters">parameters.</param>
        /// <param name="status">status.</param>
        /// <returns>value.</returns>
        bool Delete(string commandtext, CommandType commandType, SqlParameter[] parameters, out bool status);

        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="commandtext">commandtext.</param>
        /// <param name="commandtype">commandtype.</param>
        /// <param name="parameters">parameters.</param>
        /// <returns>value.</returns>
        DataSet GetData(string commandtext, CommandType commandtype, SqlParameter[] parameters = null);

        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="value">value.</param>
        /// <param name="dbType">dbType.</param>
        /// <returns> values.</returns>
        SqlParameter CreateParameter(string name, int size, object value, DbType dbType);

        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="value">value.</param>
        /// <param name="dbType">dbType.</param>
        /// <returns> values.</returns>
        SqlParameter CreateParameter(string name, object value, DbType dbType);

        /// <summary>
        /// Implementattion of Method.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="size">size.</param>
        /// <param name="value">value.</param>
        /// <param name="dbType">dbType.</param>
        /// <param name="direction">direction.</param>
        /// <returns>values.</returns>
        SqlParameter CreateParameter(string name, int size, object value, DbType dbType, ParameterDirection direction);
     }
}
