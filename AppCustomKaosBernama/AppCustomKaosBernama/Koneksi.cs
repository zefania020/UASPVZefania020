using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace AppCustomKaosBernama
{
	public class Koneksi
	{
		public SqlConnection GetConn() 
       	{ 
           	SqlConnection Conn = new SqlConnection(); 
           	Conn.ConnectionString = "Data Source=LAPTOP-B2OT493M; initial catalog=CustomKaosBernama; integrated security=true"; 
           	return Conn; 
       	} 
	}
}
