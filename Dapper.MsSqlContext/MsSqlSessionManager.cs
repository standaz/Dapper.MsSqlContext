using Dapper.DataContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Dapper.MsSqlContext
{
	public class MsSqlSessionManager : DatabaseSessionManager<SqlConnection>, IMsSqlSessionManager
	{
		public MsSqlSessionManager(string connectionString)
			: base(connectionString)
		{ 
		}
	}
}
