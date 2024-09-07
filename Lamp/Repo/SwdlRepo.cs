using Lamp.Models;
using Snowflake.Data.Client;
using System.Data;
using Newtonsoft.Json;


namespace Lamp.Repo
{
    public class SwdlRepo
    {
        public static async Task<SwdlForm> Save(SwdlForm data)
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
                            "INSERT INTO EDP_COMPLIANCE.PRD.SWDL_FORM(CERT_COMP_NAME,CERT_ADDRESS,CERT_PHONE_NO,CERT_CONTACT_NAME,CERT_EMAIL_NOTICE ,CERT_CONTACT_PERSON_EMAIL,END_USER_NAME,END_USER_ADDRESS,END_USER_WEBSITE,END_USER_PHONE,END_USER_CONTACT_NAME,END_USER_CONTACT_EMAIL,SIGNATURE,DATED,INSTALLATION_SITES,CREATED_DATE) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";

                        var p1 = cmd.CreateParameter();
                        p1.ParameterName = "1";
                        p1.Value = data.Cert_Comp_Name;
                        p1.DbType = DbType.String;
                        cmd.Parameters.Add(p1);

                        var p2 = cmd.CreateParameter();
                        p2.ParameterName = "2";
                        p2.Value = data.Cert_Address;
                        p2.DbType = DbType.String;
                        cmd.Parameters.Add(p2);

                        var p3 = cmd.CreateParameter();
                        p3.ParameterName = "3";
                        p3.Value = data.Cert_Phone_No;
                        p3.DbType = DbType.String;
                        cmd.Parameters.Add(p3);

                        var p4 = cmd.CreateParameter();
                        p4.ParameterName = "4";
                        p4.Value = data.Cert_Contact_Name;
                        p4.DbType = DbType.String;
                        cmd.Parameters.Add(p4);

                        var p5 = cmd.CreateParameter();
                        p5.ParameterName = "5";
                        p5.Value = data.Cert_Email_Notice;
                        p5.DbType = DbType.String;
                        cmd.Parameters.Add(p5);

                        var p6 = cmd.CreateParameter();
                        p6.ParameterName = "6";
                        p6.Value = data.Cert_Contact_Person_Email;
                        p6.DbType = DbType.String;
                        cmd.Parameters.Add(p6);

                        var p7 = cmd.CreateParameter();
                        p7.ParameterName = "7";
                        p7.Value = data.End_User_Name;
                        p7.DbType = DbType.String;
                        cmd.Parameters.Add(p7);

                        var p8 = cmd.CreateParameter();
                        p8.ParameterName = "8";
                        p8.Value = data.End_User_Address;
                        p8.DbType = DbType.String;
                        cmd.Parameters.Add(p8);

                        var p9 = cmd.CreateParameter();
                        p9.ParameterName = "9";
                        p9.Value = data.End_User_Website;
                        p9.DbType = DbType.String;
                        cmd.Parameters.Add(p9);

                        var p10 = cmd.CreateParameter();
                        p10.ParameterName = "10";
                        p10.Value = data.End_User_Phone;
                        p10.DbType = DbType.String;
                        cmd.Parameters.Add(p10);

                        var p11 = cmd.CreateParameter();
                        p11.ParameterName = "11";
                        p11.Value = data.End_User_Contact_Name;
                        p11.DbType = DbType.String;
                        cmd.Parameters.Add(p11);

                        var p12 = cmd.CreateParameter();
                        p12.ParameterName = "12";
                        p12.Value = data.End_User_Contact_Email;
                        p12.DbType = DbType.String;
                        cmd.Parameters.Add(p12);

                        var p13 = cmd.CreateParameter();
                        p13.ParameterName = "13";
                        p13.Value = data.Signature;
                        p13.DbType = DbType.String;
                        cmd.Parameters.Add(p13);

                        var p14 = cmd.CreateParameter();
                        p14.ParameterName = "14";
                        p14.Value = data.Dated;
                        p14.DbType = DbType.DateTime;
                        cmd.Parameters.Add(p14);

                        var p15 = cmd.CreateParameter();
                        p15.ParameterName = "15";
                        p15.Value = JsonConvert.SerializeObject(data.Installation_Sites).ToString();
                        p15.DbType = DbType.String;
                        cmd.Parameters.Add(p15);

                        var p16 = cmd.CreateParameter();
                        p16.ParameterName = "16";
                        p16.Value = DateTime.Now;
                        p16.DbType = DbType.DateTime;
                        cmd.Parameters.Add(p16);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        data.Id = GetId();

                        return data;
                    }

                    //conn.Close();
                }
            }
            catch (Exception ex)
            {
                SwdlForm swdl = new SwdlForm();
                swdl.ErrorDesc = ex.Message;
                return swdl;
            }
        }

        public static int GetId()
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
                            "SELECT MAX(ID) FROM EDP_COMPLIANCE.PRD.SWDL_FORM;";

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

        public static async Task<SwdlForm> GetById(int id)
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
                            "SELECT * FROM EDP_COMPLIANCE.PRD.SWDL_FORM WHERE ID = ?";

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
                        SwdlForm swdlForm = new SwdlForm();
                        while (reader.Read())
                        {
                            int index = 0;

                            swdlForm.Id = reader.GetInt32(index++);
                            swdlForm.Cert_Comp_Name = reader.GetString(index++);
                            swdlForm.Cert_Address = reader.GetString(index++);
                            swdlForm.Cert_Phone_No = reader.GetString(index++);
                            swdlForm.Cert_Contact_Name = reader.GetString(index++);
                            swdlForm.Cert_Email_Notice = reader.GetString(index++);
                            swdlForm.Cert_Contact_Person_Email = reader.GetString(index++);
                            swdlForm.End_User_Name = reader.GetString(index++);
                            swdlForm.End_User_Address = reader.GetString(index++);
                            swdlForm.End_User_Website = reader.GetString(index++);
                            swdlForm.End_User_Phone = reader.GetString(index++);
                            swdlForm.End_User_Contact_Name = reader.GetString(index++);
                            swdlForm.End_User_Contact_Email = reader.GetString(index++);
                            swdlForm.Signature = reader.GetString(index++);
                            swdlForm.Dated = reader.GetDateTime(index++);
                            swdlForm.Installation_Sites =
                                JsonConvert.DeserializeObject<List<InstallationSites>>(reader.GetString(index++));
                            swdlForm.Created_Date = reader.GetDateTime(index++);
                        }

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return swdlForm;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static async Task<string> SendMail(SendMailModel data, string encryptedURl)
        {
            try
            {

                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";

                    using (IDbCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText =
                            "UPDATE EDP_COMPLIANCE.PRD.SWDL_FORM SET VIEW_LINK = ? WHERE ID = ?;";

                        var p1 = cmd.CreateParameter();
                        p1.ParameterName = "1";
                        p1.Value = encryptedURl;
                        p1.DbType = DbType.String;
                        cmd.Parameters.Add(p1);

                        var p2 = cmd.CreateParameter();
                        p2.ParameterName = "2";
                        p2.Value = data.Id;
                        p2.DbType = DbType.String;
                        cmd.Parameters.Add(p2);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        Lamp.SendMail.sendUsingSmtp(encryptedURl, data.End_User_Email + "," + data.Channel_User_Email, data.Id, "SWDL");
                        return "Mail Sent";
                    }

                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
