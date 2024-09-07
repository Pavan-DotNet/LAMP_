using System.Data;
using System.Text;
using Lamp.Models;
using Snowflake.Data.Client;

namespace Lamp.Repo
{
    public class TapPolicyRepo
    {
        public static bool Save(TapPolicy data)
        {
            try
            {
                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    conn.Open();

                    if (data.Policy_RequestType == "Option 3")
                    {
                        //Check if policy already exists 
                        using (IDbCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandText =
                                "UPDATE EDP_COMPLIANCE.PRD.TAP_POLICY SET Is_Active = ? WHERE POLICY_NAME = ? ";

                            var q1 = cmd.CreateParameter();
                            q1.ParameterName = "1";
                            q1.Value = "0";
                            q1.DbType = DbType.String;
                            cmd.Parameters.Add(q1);

                            var q2 = cmd.CreateParameter();
                            q2.ParameterName = "2";
                            q2.Value = data.Policy_name;
                            q2.DbType = DbType.String;
                            cmd.Parameters.Add(q2);

                            cmd.ExecuteNonQuery();
                            return true;
                        }

                    }

                    //Check if policy already exists 
                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            "SELECT Count(*) FROM EDP_COMPLIANCE.PRD.TAP_POLICY WHERE POLICY_NAME = ?";

                        var p1 = cmd.CreateParameter();
                        p1.ParameterName = "1";
                        p1.Value = data.Policy_RequestType == "Option 2" ? data.UpdatePolicy_SelectPolicy : data.Policy_name;
                        p1.DbType = DbType.String;
                        cmd.Parameters.Add(p1);


                        conn.Open();
                        int numrows = (int)(long)cmd.ExecuteScalar();
                        if (numrows > 0)
                        {
                            cmd.CommandText =
                                "UPDATE EDP_COMPLIANCE.PRD.TAP_POLICY SET Is_Active = ? WHERE POLICY_NAME = ? ";

                            var q1 = cmd.CreateParameter();
                            q1.ParameterName = "1";
                            q1.Value = "0";
                            q1.DbType = DbType.String;
                            cmd.Parameters.Add(q1);

                            var q2 = cmd.CreateParameter();
                            q2.ParameterName = "2";
                            q2.Value = data.Policy_name;
                            q2.DbType = DbType.String;
                            cmd.Parameters.Add(q2);
                        }
                        cmd.ExecuteNonQuery();
                    }
                    if (!string.IsNullOrEmpty(data.UpdatePolicy_SelectPolicy) && string.IsNullOrEmpty(data.Policy_name))
                    {
                        data.Policy_name = data.UpdatePolicy_SelectPolicy;
                    }

                    StringBuilder sb = new StringBuilder();
                    StringBuilder builder = new StringBuilder();
                    sb.Append("INSERT INTO EDP_COMPLIANCE.PRD.TAP_POLICY(");
                    builder.Append(" VALUES (");

                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        int i = 1;
                        foreach (var propertyInfo in data.GetType().GetProperties())
                        {
                            var propertyName = propertyInfo.Name;
                            var propertyValue = propertyInfo.GetValue(data);
                            if (propertyValue != null && propertyName != "Id")
                            {
                                sb.Append(propertyName.ToUpper() + ",");
                                builder.Append("?,");
                                string FieldNameParameter = i.ToString();
                                var dbParameter = cmd.CreateParameter();
                                dbParameter.ParameterName = FieldNameParameter;
                                dbParameter.Value = propertyValue.ToString();
                                dbParameter.DbType = DbType.String;
                                cmd.Parameters.Add(dbParameter);
                                i++;
                            }
                        }
                        sb.Remove(sb.Length - 1, 1);
                        sb.Append(") ");
                        builder.Remove(builder.Length - 1, 1);
                        builder.Append(") ");

                        cmd.CommandText = sb.ToString() + "" + builder.ToString();


                        cmd.ExecuteNonQuery();
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        data.Id = GetId();

                        return true;
                    }


                    //conn.Close();
                }
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        private static int GetId()
        {

            try
            {
                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    //conn.Open();

                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            "SELECT MAX(ID) FROM EDP_COMPLIANCE.PRD.TAP_POLICY;";

                        conn.Open();
                        int modified = Convert.ToInt32(cmd.ExecuteScalar());
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return modified;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static List<TapPolicy> Get()
        {

            try
            {
                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    //conn.Open();

                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            "SELECT ID,POLICY_REQUESTTYPE,BIENNIAL_REVIEW,REQUESTER_NAME,REQUESTER_EMAIL,NEWPOLICY_TRIGGERINGEVENT,NEWPOLICY_TRIGGERINGEVENT_OTHER,UPDATEPOLICY_TRIGGERINGEVENT,UPDATEPOLICY_TRIGGERINGEVENT_OTHER,EXISTINGPOLICY_ENDWORKFLOW,NEWPOLICY_DOCUMENT,EXISTINGPOLICY_REQUESTED,UPDATEPOLICY_SELECTPOLICY,UPDATEDPOLICY_DOCUMENT,FUNCTION,POLICY_NAME,POLICY_OWNER,POLICY_SPONSOR,POLICY_EFFECTIVEDATE,RETIREPOLICY_REASONS,CCOAPPROVAL,ICGCONFIRMATION,REASONSFORREJECTING,BIENNIALREVIEW_LAST,OTHER_REJECTION,IS_ACTIVE FROM EDP_COMPLIANCE.PRD.TAP_POLICY WHERE IS_ACTIVE = '1';";

                        conn.Open();
                        IDataReader reader = cmd.ExecuteReader();

                        List<TapPolicy> policies = new List<TapPolicy>();

                        while (reader.Read())
                        {
                            TapPolicy policy = new TapPolicy();
                            int index = 0;

                            policy.Id = reader.GetInt32(index++);
                            policy.Policy_RequestType = reader.GetString(index++);
                            policy.Biennial_Review = reader.GetString(index++);
                            policy.Requester_Name = reader.GetString(index++);
                            policy.Requester_Email = reader.GetString(index++);
                            policy.NewPolicy_TriggeringEvent = reader.GetString(index++);
                            policy.NewPolicy_TriggeringEvent_Other = reader.GetString(index++);
                            policy.UpdatePolicy_TriggeringEvent = reader.GetString(index++);
                            policy.UpdatePolicy_TriggeringEvent_Other = reader.GetString(index++);
                            policy.ExistingPolicy_EndWorkflow = reader.GetString(index++);
                            policy.NewPolicy_Document = reader.GetString(index++);
                            policy.ExistingPolicy_Requested = reader.GetString(index++);
                            policy.UpdatePolicy_SelectPolicy = reader.GetString(index++);
                            policy.UpdatedPolicy_Document = reader.GetString(index++);
                            policy.Function = reader.GetString(index++);
                            policy.Policy_name = reader.GetString(index++);
                            policy.Policy_owner = reader.GetString(index++);
                            policy.Policy_sponsor = reader.GetString(index++);
                            policy.Policy_effectivedate = reader.GetString(index++);
                            policy.RetirePolicy_Reasons = reader.GetString(index++);
                            policy.CCOApproval = reader.GetString(index++);
                            policy.ICGConfirmation = reader.GetString(index++);
                            policy.ReasonsForRejecting = reader.GetString(index++);
                            policy.BiennialReview_Last = reader.GetString(index++);
                            policy.Other_rejection = "https://lampd-ext.juniper.net/api/tap/v1/download/" + policy.Policy_name;
                            policy.Is_Active = reader.GetString(index++);
                            policies.Add(policy);
                        }

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return policies;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static async Task<TapPolicy> GetById(int id)
        {
            try
            {
                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    //conn.Open();

                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            "SELECT * FROM EDP_COMPLIANCE.PRD.TAP_POLICY WHERE ID = ? AND IS_ACTIVE = '1'";

                        var p1 = cmd.CreateParameter();
                        p1.ParameterName = "1";
                        p1.Value = id;
                        p1.DbType = DbType.Int32;
                        cmd.Parameters.Add(p1);

                        conn.Open();
                        //SnowflakeDbDataReader reader = (SnowflakeDbDataReader)cmd.ExecuteReader();
                        IDataReader reader = cmd.ExecuteReader();

                        //while (reader.Read())
                        //{
                        //    Console.WriteLine(reader.GetString(0));
                        //}
                        TapPolicy policy = new TapPolicy();
                        while (reader.Read())
                        {
                            int index = 0;

                            policy.Id = reader.GetInt32(index++);
                            policy.Policy_RequestType = reader.GetString(index++);
                            policy.Biennial_Review = reader.GetString(index++);
                            policy.Requester_Name = reader.GetString(index++);
                            policy.Requester_Email = reader.GetString(index++);
                            policy.NewPolicy_TriggeringEvent = reader.GetString(index++);
                            policy.NewPolicy_TriggeringEvent_Other = reader.GetString(index++);
                            policy.UpdatePolicy_TriggeringEvent = reader.GetString(index++);
                            policy.UpdatePolicy_TriggeringEvent_Other = reader.GetString(index++);
                            policy.ExistingPolicy_EndWorkflow = reader.GetString(index++);
                            policy.NewPolicy_Document = reader.GetString(index++);
                            policy.ExistingPolicy_Requested = reader.GetString(index++);
                            policy.UpdatePolicy_SelectPolicy = reader.GetString(index++);
                            policy.UpdatedPolicy_Document = reader.GetString(index++);
                            policy.Function = reader.GetString(index++);
                            policy.Policy_name = reader.GetString(index++);
                            policy.Policy_owner = reader.GetString(index++);
                            policy.Policy_sponsor = reader.GetString(index++);
                            policy.Policy_effectivedate = reader.GetString(index++);
                            policy.RetirePolicy_Reasons = reader.GetString(index++);
                            policy.Policy_FinalVersion = reader.GetString(index++);
                            policy.CCOApproval = reader.GetString(index++);
                            policy.ICGConfirmation = reader.GetString(index++);
                            policy.ReasonsForRejecting = reader.GetString(index++);
                            policy.BiennialReview_Last = reader.GetString(index++);
                            policy.Other_rejection = reader.GetString(index++);
                            policy.Is_Active = reader.GetString(index++);
                        }

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return policy;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<TapPolicy> GetByName(string name)
        {
            try
            {
                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    //conn.Open();

                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            "SELECT Policy_FinalVersion FROM EDP_COMPLIANCE.PRD.TAP_POLICY WHERE POLICY_NAME = ? AND IS_ACTIVE = '1'";

                        var p1 = cmd.CreateParameter();
                        p1.ParameterName = "1";
                        p1.Value = name;
                        p1.DbType = DbType.String;
                        cmd.Parameters.Add(p1);

                        conn.Open();
                        //SnowflakeDbDataReader reader = (SnowflakeDbDataReader)cmd.ExecuteReader();
                        IDataReader reader = cmd.ExecuteReader();

                        //while (reader.Read())
                        //{
                        //    Console.WriteLine(reader.GetString(0));
                        //}
                        TapPolicy policy = new TapPolicy();
                        while (reader.Read())
                        {
                            int index = 0;
                            policy.Policy_FinalVersion = reader.GetString(index++);
                        }

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return policy;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
