﻿using System;
using System.ComponentModel.Composition;
using System.Data;

namespace NAudit.Data.Sqlite
{
    /// <summary>
    /// Class AuditSqliteProvider.
    /// </summary>
    /// <seealso cref="NAudit.Data.IAuditDbProvider" />
    [Export(typeof(IAuditDbProvider))]
    public class AuditSqliteProvider : IAuditDbProvider
    {
        private IDbConnection _currentDbConnection;
        private IDbCommand _currentDbCommand;

        public string ConnectionString { get; set; }
        public string DatabaseName { get; }
        public string ProviderNamespace { get; }
        public IDbConnection CurrentConnection { get; }

        public IDbCommand CreateDbCommand(string commandText, CommandType commandType, int commandTimeOut)
        {
            throw new NotImplementedException();
        }

        public IDbConnection CreateDatabaseSession()
        {
            throw new NotImplementedException();
        }

        public IDbDataAdapter CreateDbDataAdapter(IDbCommand currentDbCommand)
        {
            throw new NotImplementedException();
        }
    }
}
