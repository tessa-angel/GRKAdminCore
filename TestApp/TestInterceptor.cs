using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace TestApp
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure.Interception;
    using System.Data.Common;

    class TestInterceptor : IDbCommandInterceptor
    {
        public void NonQueryExecuted(System.Data.Common.DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            List<string> par = new List<string>();
            DbParameterCollection p = command.Parameters;
            DbParameter[] pars = new DbParameter[7];
            p.CopyTo(pars, 0);

            string commandText = command.CommandText;
            List<DbParameter> prs = pars.ToList();
            foreach (var x in prs)
            {
                string name = x.ParameterName.ToString();
                string value;
                if (x.DbType==System.Data.DbType.Int32)
                    value = x.Value.ToString();
                else
                    value=$"'{x.Value.ToString()}'";
                commandText = commandText.Replace(name, value);
            }

            LogInfo("NonQueryExecuted", commandText);
        }

        public void NonQueryExecuting(System.Data.Common.DbCommand command, DbCommandInterceptionContext<int> interceptionContext)
        {
            //LogInfo("NonQueryExecuting", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ReaderExecuted(System.Data.Common.DbCommand command, DbCommandInterceptionContext<System.Data.Common.DbDataReader> interceptionContext)
        {
           // LogInfo("ReaderExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ReaderExecuting(System.Data.Common.DbCommand command, DbCommandInterceptionContext<System.Data.Common.DbDataReader> interceptionContext)
        {
            //LogInfo("ReaderExecuting", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ScalarExecuted(System.Data.Common.DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
           // LogInfo("ScalarExecuted", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        public void ScalarExecuting(System.Data.Common.DbCommand command, DbCommandInterceptionContext<object> interceptionContext)
        {
            //LogInfo("ScalarExecuting", String.Format(" IsAsync: {0}, Command Text: {1}", interceptionContext.IsAsync, command.CommandText));
        }

        private void LogInfo(string command, string commandText)
        {
            Console.WriteLine(commandText);
        }
    }
}
