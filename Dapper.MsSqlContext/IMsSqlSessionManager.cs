using Dapper.DataContext;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Dapper.MsSqlContext
{
	public interface IMsSqlSessionManager : ISessionManager<SqlConnection>
	{
	}
}
