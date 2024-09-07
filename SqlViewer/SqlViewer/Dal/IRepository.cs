﻿using SqlViewer.Models;
using System.Data;
using System.Data.SqlClient;

namespace SqlViewer.Dal
{
    internal interface IRepository
    {
        SqlConnection GetSqlConnection();
        DataSet CreateDataset(DBEntity dbEntity);
        IEnumerable<Column> GetColumns(DBEntity entity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType entityType);
        IEnumerable<Parameter> GetParameters(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void Login(string server, string username, string password);
    }
}