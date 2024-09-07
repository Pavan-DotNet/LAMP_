using System.Data;
using Newtonsoft.Json;
using Snowflake.Data.Client;

namespace Lamp.Repo
{
    public class SmartContractsRepo
    {
        public static string Get()
        {
            DataTable dt = new DataTable();
            try
            {
                using (SnowflakeDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    conn.Open();
                    string CommandText = "SELECT * FROM EDP_COMPLIANCE.SMART_CONTRACTS.MPLA_DATA";
                    SnowflakeDbDataAdapter da = new SnowflakeDbDataAdapter(CommandText, conn);

                    da.Fill(dt);
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    Dictionary<string, object> row;
                    foreach (DataRow dr in dt.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }

                    if (conn.State == System.Data.ConnectionState.Open)
                        conn.Close();

                    return JsonConvert.SerializeObject(rows);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //using (SqlConnection con = new SqlConnection("Data Source=SureshDasari;Initial Catalog=master;Integrated Security=true"))
            //{
            //    using (SqlCommand cmd = new SqlCommand("select title=City,lat=latitude,lng=longitude,description from LocationDetails", con))
            //    {
            //        con.Open();
            //        SqlDataAdapter da = new SqlDataAdapter(cmd);
            //        da.Fill(dt);
            //        System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
            //        List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
            //        Dictionary<string, object> row;
            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            row = new Dictionary<string, object>();
            //            foreach (DataColumn col in dt.Columns)
            //            {
            //                row.Add(col.ColumnName, dr[col]);
            //            }
            //            rows.Add(row);
            //        }
            //        return serializer.Serialize(rows);
            //    }
            //}
        }
    }
}
