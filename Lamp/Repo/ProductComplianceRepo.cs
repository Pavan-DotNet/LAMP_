using DataModel;
using Microsoft.EntityFrameworkCore;
using Snowflake.Data.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lamp.Models;

namespace Lamp.Repo
{
    public class ProductComplianceRepo
    {
        public static async Task<int> Save(ProductComplianceModel data)
        {
            try
            {
                using (IDbConnection conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString =
                        "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    //conn.Open();

                    StringBuilder sb = new StringBuilder();
                    StringBuilder builder = new StringBuilder();
                    sb.Append("INSERT INTO EDP_COMPLIANCE.PRD.PRODUCT_COMPLIANCE_CHECKLIST(");
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

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        int id = GetId();
                        return id;
                    }


                    //conn.Close();
                }
            }
            catch (Exception ex)
            {
                return 0;
            }

        }

        public static async Task<bool> UpdateEncryptedKey(UpdateKey data, string EncryptedMail)
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
                            "UPDATE EDP_COMPLIANCE.PRD.PRODUCT_COMPLIANCE_CHECKLIST SET ENCRYPTED_ID = '" + data.Encrypted + "', INSERTED_ON = '" + DateTime.Now.Date.ToString("MM/dd/yyyy") + "' WHERE ID = " + data.Id;

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();
                        SendMail.sendUsingSmtpProductCompliance(data.Id, EncryptedMail);
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
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
                            "SELECT MAX(ID) FROM EDP_COMPLIANCE.PRD.PRODUCT_COMPLIANCE_CHECKLIST;";

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
                return 0;
            }
        }

        public static async Task<ProductComplianceModel> GetById(int id)
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
                            "SELECT * FROM EDP_COMPLIANCE.PRD.PRODUCT_COMPLIANCE_CHECKLIST WHERE ID = ?";

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
                        ProductComplianceModel productForm = new ProductComplianceModel();
                        while (reader.Read())
                        {
                            int index = 0;

                            productForm.Id = reader.GetString(index++);
                            productForm.prodcut_Line = reader.GetString(index++);
                            productForm.service_Name = reader.GetString(index++);
                            productForm.business_Unit = reader.GetString(index++);
                            productForm.additional_Stakeholders = reader.GetString(index++);
                            productForm.service_Version = reader.GetString(index++);
                            productForm.release_Date = reader.GetString(index++);
                            productForm.product_councel_previously = reader.GetString(index++);
                            productForm.prior_checklist = reader.GetString(index++);
                            productForm.prior_checklist_text = reader.GetString(index++);
                            productForm.product_service = reader.GetString(index++);
                            productForm.technical_Summary = reader.GetString(index++);
                            productForm.file_Upload = reader.GetString(index++);
                            productForm.include_otherwise = reader.GetString(index++);
                            productForm.third_party_components = reader.GetString(index++);
                            productForm.party_ip = reader.GetString(index++);
                            productForm.particular_product = reader.GetString(index++);
                            productForm.date = Convert.ToDateTime(reader.GetString(index++));
                            productForm.reason = reader.GetString(index++);
                            productForm.cryptograph = reader.GetString(index++);
                            productForm.identify_issues = reader.GetString(index++);
                            productForm.identify_changes = reader.GetString(index++);
                            productForm.any_changes = reader.GetString(index++);
                            productForm.identify_issues_specific = reader.GetString(index++);
                            productForm.identify_other_issues = reader.GetString(index++);
                            productForm.proposed_license = reader.GetString(index++);
                            productForm.accessiblity_design = reader.GetString(index++);
                            productForm.vpat = reader.GetString(index++);
                            productForm.prev_completion = reader.GetString(index++);
                            productForm.which_it = reader.GetString(index++);
                            productForm.aggregating = reader.GetString(index++);
                            productForm.identifiable = reader.GetString(index++);
                            productForm.impact_assessment = reader.GetString(index++);
                            productForm.security_dev = reader.GetString(index++);
                            productForm.assesment_req = reader.GetString(index++);
                            productForm.new_Functionalities = reader.GetString(index++);
                            productForm.sirt = reader.GetString(index++);
                            productForm.jsa = reader.GetString(index++);
                            productForm.major_release = reader.GetString(index++);
                            productForm.trademark = reader.GetString(index++);
                            productForm.collateral_mat = reader.GetString(index++);
                            productForm.customers_deviation = reader.GetString(index++);
                            productForm.service_desc = reader.GetString(index++);
                            productForm.level_agreement = reader.GetString(index++);
                            productForm.public_docu = reader.GetString(index++);
                            productForm.gtm_collateral = reader.GetString(index++);
                            productForm.certain_cus = reader.GetString(index++);
                            productForm.pre_ga = reader.GetString(index++);
                            productForm.encrypted_id = reader.GetString(index++);
                            productForm.inserted_on = reader.GetString(index++);


                        }

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return productForm;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static async Task<List<string>> GetUsers()
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
                            "SELECT NAME FROM EDP_COMPLIANCE.PRD.HR_LIVE_DATA_PC_VW";

                        conn.Open();

                        IDataReader reader = cmd.ExecuteReader();

                        List<string> names = new List<string>();
                        
                        while (reader.Read())
                        {
                            int index = 0;
                            string name = reader.GetString(index++);
                            names.Add(name);
                        }

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();

                        return names;
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





