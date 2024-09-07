using DataModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Nest;
using Snowflake.Data.Client;
using Snowflake.Data.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Lamp.Repo
{
    public class EliasRepo
    {
        public static async Task<TcProfileForm> Save(TcProfileForm data)
        {
            try
            {
                using (var conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString = "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    await conn.OpenAsync();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"INSERT INTO TC_PROFILE_FORM (
                            SUB_FN, SUB_LN, JOB_TITLE, CP_NAME, SUB_EMAIL, J_VARID, QUOTE, Q_DATE, PO, SO, D_COMPNAME,
                            D_STREET, D_CITY, D_STATE, D_POSTAL, D_CTY, DISTI_RESL, EU_COMPNAME, EU_STREET, EU_CITY,
                            EU_STATE, EU_POSTAL, EU_CTY, EU_NAME, EU_EMAIL, EU_URL, EU_URL_TEXT, EU_BUSS_FN, EU_OFFERING,
                            OP_COMPNAME, OP_STREET, OP_CITY, OP_STATE, OP_POSTAL, OP_CTY, OP_NAME, OP_EMAIL, OP_URL,
                            NEU1_COMPNAME, NEU1_STREET, NEU1_CITY, NEU1_STATE, NEU1_POSTAL, NEU1_CTY, NEU1_NAME, NEU1_EMAIL,
                            NEU1_URL, NEU2_COMPNAME, NEU2_STREET, NEU2_CITY, NEU2_STATE, NEU2_POSTAL, NEU2_CTY, NEU2_NAME,
                            NEU2_EMAIL, NEU2_URL, NEU3_COMPNAME, NEU3_STREET, NEU3_CITY, NEU3_STATE, NEU3_POSTAL, NEU3_CTY,
                            NEU3_NAME, NEU3_EMAIL, NEU3_URL, NEU4_COMPNAME, NEU4_STREET, NEU4_CITY, NEU4_STATE, NEU4_POSTAL,
                            NEU4_CTY, NEU4_NAME, NEU4_EMAIL, NEU4_URL, EU_Q1, EU_Q2, EU_Q3, S1_COMPNAME, S1_STREET, S1_CITY,
                            S1_STATE, S1_POSTAL, S1_CTY, S1_URL, S2_COMPNAME, S2_STREET, S2_CITY, S2_STATE, S2_POSTAL, S2_CTY,
                            S2_URL, S3_COMPNAME, S3_STREET, S3_CITY, S3_STATE, S3_POSTAL, S3_CTY, S3_URL, S4_COMPNAME, S4_STREET,
                            S4_CITY, S4_STATE, S4_POSTAL, S4_CTY, S4_URL, S5_COMPNAME, S5_STREET, S5_CITY, S5_STATE, S5_POSTAL,
                            S5_CTY, S5_URL, CP_COMPNAME, AUTH_REPRE_NAME, AUTH_REPRE_JOB, ACK_DATE, CREATED_DATE, DOCUMENT, DOCUMENT1, ELIAS_COPY
                        ) VALUES (
                            @SubFn, @SubLn, @JobTitle, @CpName, @SubEmail, @JVarid, @Quote, @QDate, @Po, @So, @DCompname,
                            @DStreet, @DCity, @DState, @DPostal, @DCty, @DistiResl, @EuCompname, @EuStreet, @EuCity,
                            @EuState, @EuPostal, @EuCty, @EuName, @EuEmail, @EuUrl, @EuUrlText, @EuBussFn, @EuOffering,
                            @OpCompname, @OpStreet, @OpCity, @OpState, @OpPostal, @OpCty, @OpName, @OpEmail, @OpUrl,
                            @Neu1Compname, @Neu1Street, @Neu1City, @Neu1State, @Neu1Postal, @Neu1Cty, @Neu1Name, @Neu1Email,
                            @Neu1Url, @Neu2Compname, @Neu2Street, @Neu2City, @Neu2State, @Neu2Postal, @Neu2Cty, @Neu2Name,
                            @Neu2Email, @Neu2Url, @Neu3Compname, @Neu3Street, @Neu3City, @Neu3State, @Neu3Postal, @Neu3Cty,
                            @Neu3Name, @Neu3Email, @Neu3Url, @Neu4Compname, @Neu4Street, @Neu4City, @Neu4State, @Neu4Postal,
                            @Neu4Cty, @Neu4Name, @Neu4Email, @Neu4Url, @EuQ1, @EuQ2, @EuQ3, @S1Compname, @S1Street, @S1City,
                            @S1State, @S1Postal, @S1Cty, @S1Url, @S2Compname, @S2Street, @S2City, @S2State, @S2Postal, @S2Cty,
                            @S2Url, @S3Compname, @S3Street, @S3City, @S3State, @S3Postal, @S3Cty, @S3Url, @S4Compname, @S4Street,
                            @S4City, @S4State, @S4Postal, @S4Cty, @S4Url, @S5Compname, @S5Street, @S5City, @S5State, @S5Postal,
                            @S5Cty, @S5Url, @CpCompname, @AuthRepreName, @AuthRepreJob, @AckDate, @CreatedDate, @Document, @Document1, @EliasCopy
                        )";

                        // Add parameters
                        cmd.Parameters.Add(new SnowflakeDbParameter("@SubFn", SFDataType.TEXT) { Value = data.SubFn });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@SubLn", SFDataType.TEXT) { Value = data?.SubLn });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@JobTitle", SFDataType.TEXT) { Value = data?.JobTitle });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@CpName", SFDataType.TEXT) { Value = data?.CpName });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@SubEmail", SFDataType.TEXT) { Value = data?.SubEmail });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@JVarid", SFDataType.TEXT) { Value = data?.JVarid }); cmd.Parameters.Add(new SnowflakeDbParameter("@Quote", SFDataType.TEXT) { Value = data?.Quote });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@QDate", SFDataType.DATE) { Value = data?.QDate });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Po", SFDataType.TEXT) { Value = data?.Po });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@So", SFDataType.TEXT) { Value = data?.So });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DCompname", SFDataType.TEXT) { Value = data?.DCompname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DStreet", SFDataType.TEXT) { Value = data?.DStreet });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DCity", SFDataType.TEXT) { Value = data?.DCity });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DState", SFDataType.TEXT) { Value = data?.DState });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DPostal", SFDataType.TEXT) { Value = data?.DPostal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DCty", SFDataType.TEXT) { Value = data?.DCty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@DistiResl", SFDataType.TEXT) { Value = data?.DistiResl });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuCompname", SFDataType.TEXT) { Value = data?.EuCompname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuStreet", SFDataType.TEXT) { Value = data?.EuStreet });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuCity", SFDataType.TEXT) { Value = data?.EuCity });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuState", SFDataType.TEXT) { Value = data?.EuState });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuPostal", SFDataType.TEXT) { Value = data?.EuPostal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuCty", SFDataType.TEXT) { Value = data?.EuCty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuName", SFDataType.TEXT) { Value = data?.EuName });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuEmail", SFDataType.TEXT) { Value = data?.EuEmail });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuUrl", SFDataType.TEXT) { Value = data?.EuUrl });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuUrlText", SFDataType.TEXT) { Value = data?.EuUrlText });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuBussFn", SFDataType.TEXT) { Value = data?.EuBussFn });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuOffering", SFDataType.TEXT) { Value = data?.EuOffering });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpCompname", SFDataType.TEXT) { Value = data?.OpCompname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpStreet", SFDataType.TEXT) { Value = data?.OpStreet });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpCity", SFDataType.TEXT) { Value = data?.OpCity });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpState", SFDataType.TEXT) { Value = data?.OpState });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpPostal", SFDataType.TEXT) { Value = data?.OpPostal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpCty", SFDataType.TEXT) { Value = data?.OpCty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpName", SFDataType.TEXT) { Value = data?.OpName });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpEmail", SFDataType.TEXT) { Value = data?.OpEmail });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@OpUrl", SFDataType.TEXT) { Value = data?.OpUrl });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Compname", SFDataType.TEXT) { Value = data?.Neu1Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Street", SFDataType.TEXT) { Value = data?.Neu1Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1City", SFDataType.TEXT) { Value = data?.Neu1City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1State", SFDataType.TEXT) { Value = data?.Neu1State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Postal", SFDataType.TEXT) { Value = data?.Neu1Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Cty", SFDataType.TEXT) { Value = data?.Neu1Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Name", SFDataType.TEXT) { Value = data?.Neu1Name });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Email", SFDataType.TEXT) { Value = data?.Neu1Email });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu1Url", SFDataType.TEXT) { Value = data?.Neu1Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Compname", SFDataType.TEXT) { Value = data?.Neu2Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Street", SFDataType.TEXT) { Value = data?.Neu2Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2City", SFDataType.TEXT) { Value = data?.Neu2City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2State", SFDataType.TEXT) { Value = data?.Neu2State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Postal", SFDataType.TEXT) { Value = data?.Neu2Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Cty", SFDataType.TEXT) { Value = data?.Neu2Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Name", SFDataType.TEXT) { Value = data?.Neu2Name });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Email", SFDataType.TEXT) { Value = data?.Neu2Email });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu2Url", SFDataType.TEXT) { Value = data?.Neu2Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Compname", SFDataType.TEXT) { Value = data?.Neu3Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Street", SFDataType.TEXT) { Value = data?.Neu3Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3City", SFDataType.TEXT) { Value = data?.Neu3City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3State", SFDataType.TEXT) { Value = data?.Neu3State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Postal", SFDataType.TEXT) { Value = data?.Neu3Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Cty", SFDataType.TEXT) { Value = data?.Neu3Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Name", SFDataType.TEXT) { Value = data?.Neu3Name });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Email", SFDataType.TEXT) { Value = data?.Neu3Email });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu3Url", SFDataType.TEXT) { Value = data?.Neu3Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Compname", SFDataType.TEXT) { Value = data?.Neu4Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Street", SFDataType.TEXT) { Value = data?.Neu4Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4City", SFDataType.TEXT) { Value = data?.Neu4City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4State", SFDataType.TEXT) { Value = data?.Neu4State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Postal", SFDataType.TEXT) { Value = data?.Neu4Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Cty", SFDataType.TEXT) { Value = data?.Neu4Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Name", SFDataType.TEXT) { Value = data?.Neu4Name });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Email", SFDataType.TEXT) { Value = data?.Neu4Email });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Neu4Url", SFDataType.TEXT) { Value = data?.Neu4Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuQ1", SFDataType.TEXT) { Value = data?.EuQ1 });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuQ2", SFDataType.TEXT) { Value = data?.EuQ2 });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EuQ3", SFDataType.TEXT) { Value = data?.EuQ3 });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1Compname", SFDataType.TEXT) { Value = data?.S1Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1Street", SFDataType.TEXT) { Value = data?.S1Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1City", SFDataType.TEXT) { Value = data?.S1City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1State", SFDataType.TEXT) { Value = data?.S1State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1Postal", SFDataType.TEXT) { Value = data?.S1Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1Cty", SFDataType.TEXT) { Value = data?.S1Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S1Url", SFDataType.TEXT) { Value = data?.S1Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2Compname", SFDataType.TEXT) { Value = data?.S2Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2Street", SFDataType.TEXT) { Value = data?.S2Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2City", SFDataType.TEXT) { Value = data?.S2City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2State", SFDataType.TEXT) { Value = data?.S2State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2Postal", SFDataType.TEXT) { Value = data?.S2Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2Cty", SFDataType.TEXT) { Value = data?.S2Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S2Url", SFDataType.TEXT) { Value = data?.S2Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3Compname", SFDataType.TEXT) { Value = data?.S3Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3Street", SFDataType.TEXT) { Value = data?.S3Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3City", SFDataType.TEXT) { Value = data?.S3City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3State", SFDataType.TEXT) { Value = data?.S3State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3Postal", SFDataType.TEXT) { Value = data?.S3Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3Cty", SFDataType.TEXT) { Value = data?.S3Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S3Url", SFDataType.TEXT) { Value = data?.S3Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4Compname", SFDataType.TEXT) { Value = data?.S4Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4Street", SFDataType.TEXT) { Value = data?.S4Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4City", SFDataType.TEXT) { Value = data?.S4City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4State", SFDataType.TEXT) { Value = data?.S4State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4Postal", SFDataType.TEXT) { Value = data?.S4Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4Cty", SFDataType.TEXT) { Value = data?.S4Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S4Url", SFDataType.TEXT) { Value = data?.S4Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5Compname", SFDataType.TEXT) { Value = data?.S5Compname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5Street", SFDataType.TEXT) { Value = data?.S5Street });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5City", SFDataType.TEXT) { Value = data?.S5City });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5State", SFDataType.TEXT) { Value = data?.S5State });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5Postal", SFDataType.TEXT) { Value = data?.S5Postal });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5Cty", SFDataType.TEXT) { Value = data?.S5Cty });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@S5Url", SFDataType.TEXT) { Value = data?.S5Url });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@CpCompname", SFDataType.TEXT) { Value = data?.CpCompname });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@AuthRepreName", SFDataType.TEXT) { Value = data?.AuthRepreName });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@AuthRepreJob", SFDataType.TEXT) { Value = data?.AuthRepreJob });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@AckDate", SFDataType.DATE) { Value = data?.AckDate });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@CreatedDate", SFDataType.DATE) { Value = data?.CreatedDate });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Document", SFDataType.BINARY) { Value = data?.Document });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Document1", SFDataType.BINARY) { Value = data?.Document1 });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EliasCopy", SFDataType.TEXT) { Value = data?.EliasCopy });

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return data;
        }

        public static async Task<TcProfileForm> GetById(int id)
        {
            TcProfileForm profileForm = null;

            try
            {
                using (var conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString = "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    await conn.OpenAsync();

                    using (var cmd = conn.CreateCommand())
                    {
                        //cmd.CommandText = "SELECT * FROM EDP_COMPLIANCE.PRD.TC_PROFILE_FORM WHERE ID = @Id";
                        //cmd.Parameters.Add(new SnowflakeDbParameter("@Id", id));

                        cmd.CommandText = "SELECT * FROM EDP_COMPLIANCE.PRD.TC_PROFILE_FORM WHERE ID = @Id";

                        var parameter = new SnowflakeDbParameter
                        {
                            ParameterName = "@Id",
                            Value = id,
                            DbType = System.Data.DbType.Int32
                        };

                        cmd.Parameters.Add(parameter);

                        using (var reader = await cmd.ExecuteReaderAsync())
                        {
                            if (await reader.ReadAsync())
                            {
                                profileForm = new TcProfileForm
                                {
                                    Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                    SubFn = reader.GetString(reader.GetOrdinal("SUB_FN")),
                                    SubLn = reader.GetString(reader.GetOrdinal("SUB_LN")),
                                    JobTitle = reader.GetString(reader.GetOrdinal("JOB_TITLE")),
                                    CpName = reader.GetString(reader.GetOrdinal("CP_NAME")),
                                    SubEmail = reader.GetString(reader.GetOrdinal("SUB_EMAIL")),
                                    JVarid = reader.GetString(reader.GetOrdinal("J_VARID")),
                                    Quote = reader.GetString(reader.GetOrdinal("QUOTE")),
                                    QDate = reader.GetDateTime(reader.GetOrdinal("Q_DATE")),
                                    Po = reader.GetString(reader.GetOrdinal("PO")),
                                    So = reader.GetString(reader.GetOrdinal("SO")),
                                    DCompname = reader.GetString(reader.GetOrdinal("D_COMPNAME")),
                                    DStreet = reader.GetString(reader.GetOrdinal("D_STREET")),
                                    DCity = reader.GetString(reader.GetOrdinal("D_CITY")),
                                    DState = reader.GetString(reader.GetOrdinal("D_STATE")),
                                    DPostal = reader.GetString(reader.GetOrdinal("D_POSTAL")),
                                    DCty = reader.GetString(reader.GetOrdinal("D_CTY")),
                                    DistiResl = reader.GetString(reader.GetOrdinal("DISTI_RESL")),
                                    EuCompname = reader.GetString(reader.GetOrdinal("EU_COMPNAME")),
                                    EuStreet = reader.GetString(reader.GetOrdinal("EU_STREET")),
                                    EuCity = reader.GetString(reader.GetOrdinal("EU_CITY")),
                                    EuState = reader.GetString(reader.GetOrdinal("EU_STATE")),
                                    EuPostal = reader.GetString(reader.GetOrdinal("EU_POSTAL")),
                                    EuCty = reader.GetString(reader.GetOrdinal("EU_CTY")),
                                    EuName = reader.GetString(reader.GetOrdinal("EU_NAME")),
                                    EuEmail = reader.GetString(reader.GetOrdinal("EU_EMAIL")),
                                    EuUrl = reader.GetString(reader.GetOrdinal("EU_URL")),
                                    EuUrlText = reader.GetString(reader.GetOrdinal("EU_URL_TEXT")),
                                    EuBussFn = reader.GetString(reader.GetOrdinal("EU_BUSS_FN")),
                                    EuOffering = reader.GetString(reader.GetOrdinal("EU_OFFERING")),
                                    OpCompname = reader.GetString(reader.GetOrdinal("OP_COMPNAME")),
                                    OpStreet = reader.GetString(reader.GetOrdinal("OP_STREET")),
                                    OpCity = reader.GetString(reader.GetOrdinal("OP_CITY")),
                                    OpState = reader.GetString(reader.GetOrdinal("OP_STATE")),
                                    OpPostal = reader.GetString(reader.GetOrdinal("OP_POSTAL")),
                                    OpCty = reader.GetString(reader.GetOrdinal("OP_CTY")),
                                    OpName = reader.GetString(reader.GetOrdinal("OP_NAME")),
                                    OpEmail = reader.GetString(reader.GetOrdinal("OP_EMAIL")),
                                    OpUrl = reader.GetString(reader.GetOrdinal("OP_URL")),
                                    Neu1Compname = reader.GetString(reader.GetOrdinal("NEU1_COMPNAME")),
                                    Neu1Street = reader.GetString(reader.GetOrdinal("NEU1_STREET")),
                                    Neu1City = reader.GetString(reader.GetOrdinal("NEU1_CITY")),
                                    Neu1State = reader.GetString(reader.GetOrdinal("NEU1_STATE")),
                                    Neu1Postal = reader.GetString(reader.GetOrdinal("NEU1_POSTAL")),
                                    Neu1Cty = reader.GetString(reader.GetOrdinal("NEU1_CTY")),
                                    Neu1Name = reader.GetString(reader.GetOrdinal("NEU1_NAME")),
                                    Neu1Email = reader.GetString(reader.GetOrdinal("NEU1_EMAIL")),
                                    Neu1Url = reader.GetString(reader.GetOrdinal("NEU1_URL")),
                                    Neu2Compname = reader.GetString(reader.GetOrdinal("NEU2_COMPNAME")),
                                    Neu2Street = reader.GetString(reader.GetOrdinal("NEU2_STREET")),
                                    Neu2City = reader.GetString(reader.GetOrdinal("NEU2_CITY")),
                                    Neu2State = reader.GetString(reader.GetOrdinal("NEU2_STATE")),
                                    Neu2Postal = reader.GetString(reader.GetOrdinal("NEU2_POSTAL")),
                                    Neu2Cty = reader.GetString(reader.GetOrdinal("NEU2_CTY")),
                                    Neu2Name = reader.GetString(reader.GetOrdinal("NEU2_NAME")),
                                    Neu2Email = reader.GetString(reader.GetOrdinal("NEU2_EMAIL")),
                                    Neu2Url = reader.GetString(reader.GetOrdinal("NEU2_URL")),
                                    Neu3Compname = reader.GetString(reader.GetOrdinal("NEU3_COMPNAME")),
                                    Neu3Street = reader.GetString(reader.GetOrdinal("NEU3_STREET")),
                                    Neu3City = reader.GetString(reader.GetOrdinal("NEU3_CITY")),
                                    Neu3State = reader.GetString(reader.GetOrdinal("NEU3_STATE")),
                                    Neu3Postal = reader.GetString(reader.GetOrdinal("NEU3_POSTAL")),
                                    Neu3Cty = reader.GetString(reader.GetOrdinal("NEU3_CTY")),
                                    Neu3Name = reader.GetString(reader.GetOrdinal("NEU3_NAME")),
                                    Neu3Email = reader.GetString(reader.GetOrdinal("NEU3_EMAIL")),
                                    Neu3Url = reader.GetString(reader.GetOrdinal("NEU3_URL")),
                                    Neu4Compname = reader.GetString(reader.GetOrdinal("NEU4_COMPNAME")),
                                    Neu4Street = reader.GetString(reader.GetOrdinal("NEU4_STREET")),
                                    Neu4City = reader.GetString(reader.GetOrdinal("NEU4_CITY")),
                                    Neu4State = reader.GetString(reader.GetOrdinal("NEU4_STATE")),
                                    Neu4Postal = reader.GetString(reader.GetOrdinal("NEU4_POSTAL")),
                                    Neu4Cty = reader.GetString(reader.GetOrdinal("NEU4_CTY")),
                                    Neu4Name = reader.GetString(reader.GetOrdinal("NEU4_NAME")),
                                    Neu4Email = reader.GetString(reader.GetOrdinal("NEU4_EMAIL")),
                                    Neu4Url = reader.GetString(reader.GetOrdinal("NEU4_URL")),
                                    EuQ1 = reader.GetString(reader.GetOrdinal("EU_Q1")),
                                    EuQ2 = reader.GetString(reader.GetOrdinal("EU_Q2")),
                                    EuQ3 = reader.GetString(reader.GetOrdinal("EU_Q3")),
                                    S1Compname = reader.GetString(reader.GetOrdinal("S1_COMPNAME")),
                                    S1Street = reader.GetString(reader.GetOrdinal("S1_STREET")),
                                    S1City = reader.GetString(reader.GetOrdinal("S1_CITY")),
                                    S1State = reader.GetString(reader.GetOrdinal("S1_STATE")),
                                    S1Postal = reader.GetString(reader.GetOrdinal("S1_POSTAL")),
                                    S1Cty = reader.GetString(reader.GetOrdinal("S1_CTY")),
                                    S1Url = reader.GetString(reader.GetOrdinal("S1_URL")),
                                    S2Compname = reader.GetString(reader.GetOrdinal("S2_COMPNAME")),
                                    S2Street = reader.GetString(reader.GetOrdinal("S2_STREET")),
                                    S2City = reader.GetString(reader.GetOrdinal("S2_CITY")),
                                    S2State = reader.GetString(reader.GetOrdinal("S2_STATE")),
                                    S2Postal = reader.GetString(reader.GetOrdinal("S2_POSTAL")),
                                    S2Cty = reader.GetString(reader.GetOrdinal("S2_CTY")),
                                    S2Url = reader.GetString(reader.GetOrdinal("S2_URL")),
                                    S3Compname = reader.GetString(reader.GetOrdinal("S3_COMPNAME")),
                                    S3Street = reader.GetString(reader.GetOrdinal("S3_STREET")),
                                    S3City = reader.GetString(reader.GetOrdinal("S3_CITY")),
                                    S3State = reader.GetString(reader.GetOrdinal("S3_STATE")),
                                    S3Postal = reader.GetString(reader.GetOrdinal("S3_POSTAL")),
                                    S3Cty = reader.GetString(reader.GetOrdinal("S3_CTY")),
                                    S3Url = reader.GetString(reader.GetOrdinal("S3_URL")),
                                    S4Compname = reader.GetString(reader.GetOrdinal("S4_COMPNAME")),
                                    S4Street = reader.GetString(reader.GetOrdinal("S4_STREET")),
                                    S4City = reader.GetString(reader.GetOrdinal("S4_CITY")),
                                    S4State = reader.GetString(reader.GetOrdinal("S4_STATE")),
                                    S4Postal = reader.GetString(reader.GetOrdinal("S4_POSTAL")),
                                    S4Cty = reader.GetString(reader.GetOrdinal("S4_CTY")),
                                    S4Url = reader.GetString(reader.GetOrdinal("S4_URL")),
                                    S5Compname = reader.GetString(reader.GetOrdinal("S5_COMPNAME")),
                                    S5Street = reader.GetString(reader.GetOrdinal("S5_STREET")),
                                    S5City = reader.GetString(reader.GetOrdinal("S5_CITY")),
                                    S5State = reader.GetString(reader.GetOrdinal("S5_STATE")),
                                    S5Postal = reader.GetString(reader.GetOrdinal("S5_POSTAL")),
                                    S5Cty = reader.GetString(reader.GetOrdinal("S5_CTY")),
                                    S5Url = reader.GetString(reader.GetOrdinal("S5_URL")),
                                    CpCompname = reader.GetString(reader.GetOrdinal("CP_COMPNAME")),
                                    AuthRepreName = reader.GetString(reader.GetOrdinal("AUTH_REPRE_NAME")),
                                    AuthRepreJob = reader.GetString(reader.GetOrdinal("AUTH_REPRE_JOB")),
                                    AckDate = reader.GetDateTime(reader.GetOrdinal("ACK_DATE")),
                                    CreatedDate = reader.GetDateTime(reader.GetOrdinal("CREATED_DATE")),
                                    Document = GetBinaryColumn(reader, "DOCUMENT"),
                                    Document1 = GetBinaryColumn(reader, "DOCUMENT1"),
                                    EliasCopy = reader.GetString(reader.GetOrdinal("ELIAS_COPY"))

                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

            return profileForm;
        }

        private static byte[] GetBinaryColumn(DbDataReader reader, string columnName)
        {
            byte[] result = null;
            int ordinal = reader.GetOrdinal(columnName);
            if (!reader.IsDBNull(ordinal))
            {
                long size = reader.GetBytes(ordinal, 0, null, 0, 0);
                result = new byte[size];
                reader.GetBytes(ordinal, 0, result, 0, (int)size);
            }
            return result;
        }

        internal static async Task<string> SaveAttachmentURLAsync(int Id, string? email, string encryptedURl)
        {
            try
            {
                using (var conn = new SnowflakeDbConnection())
                {
                    conn.ConnectionString = "scheme=https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=PRD;warehouse=LEGAL_WH";
                    await conn.OpenAsync();

                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = @"UPDATE TC_PROFILE_FORM 
                                SET SUB_EMAIL = @SubEmail, ELIAS_COPY = @EliasCopy 
                                WHERE ID = @Id";
                        cmd.Parameters.Add(new SnowflakeDbParameter("@SubEmail", SFDataType.TEXT) { Value = email });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@EliasCopy", SFDataType.TEXT) { Value = encryptedURl });
                        cmd.Parameters.Add(new SnowflakeDbParameter("@Id", SFDataType.TEXT) { Value = Id });

                        int affectedRows = await cmd.ExecuteNonQueryAsync();
                        return Convert.ToString(affectedRows);
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





//using (IDbConnection conn = new SnowflakeDbConnection())
//                {
//                    conn.ConnectionString = "scheme =https;host=snowflake;port=443;user=ETL_COMPLIANCE;password=1t^y;account=accent;role=;db=EDP_COMPLIANCE;schema=DEV;warehouse=LEGAL_WH";
//                    //conn.Open();

//                    using (IDbCommand cmd = conn.CreateCommand())
//                    {
//                        conn.Open();

//                        cmd.CommandText = "insert into EDP_COMPLIANCE.DEV.TC_PROFILE_FORM(Sub_FN,Sub_LN,Job_Title,CP_Name,Sub_Email ,J_VARID,Quote,Q_Date,PO,SO,D_CompName,D_Street,D_City,D_State,D_Postal,D_Cty,EU_CompName,EU_Street,EU_City,EU_State,EU_Postal,EU_Cty,EU_Name,EU_Email,EU_URL,EU_Buss_Fn,EU_Offering,OP_CompName,OP_Street,OP_City,OP_State,OP_Postal,OP_Cty,OP_Name,OP_Email,OP_URL,NEU1_CompName,NEU1_Street,NEU1_City,NEU1_State,NEU1_Postal,NEU1_Cty,NEU1_Name,NEU1_Email,NEU1_URL,NEU2_CompName,NEU2_Street,NEU2_City,NEU2_State,NEU2_Postal,NEU2_Cty,NEU2_Name,NEU2_Email,NEU2_URL,NEU3_CompName,NEU3_Street,NEU3_City,NEU3_State,NEU3_Postal,NEU3_Cty,NEU3_Name,NEU3_Email,NEU3_URL,NEU4_CompName,NEU4_Street,NEU4_City,NEU4_State,NEU4_Postal,NEU4_Cty,NEU4_Name,NEU4_Email,NEU4_URL,EU_Q1,EU_Q2,S1_CompName,S1_Street,S1_City,S1_State,S1_Postal,S1_Cty,S1_URL,S2_CompName,S2_Street,S2_City,S2_State,S2_Postal,S2_Cty,S2_URL,S3_CompName,S3_Street,S3_City,S3_State,S3_Postal,S3_Cty,S3_URL,S4_CompName,S4_Street,S4_City,S4_State,S4_Postal,S4_Cty,S4_URL,S5_CompName,S5_Street,S5_City,S5_State,S5_Postal,S5_Cty,S5_URL,CP_CompName,Auth_Repre_Name,Auth_Repre_Job,Ack_Date) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

//                        var p1 = cmd.CreateParameter();
//p1.ParameterName = "1";
//                        p1.Value = data.SUB_FN;
//                        p1.DbType = DbType.String;
//                        cmd.Parameters.Add(p1);

//                        var p2 = cmd.CreateParameter();
//p2.ParameterName = "2";
//                        p2.Value = data.SUB_LN;
//                        p2.DbType = DbType.String;
//                        cmd.Parameters.Add(p2);

//                        var p3 = cmd.CreateParameter();
//p3.ParameterName = "3";
//                        p3.Value = data.JOB_TITLE;
//                        p3.DbType = DbType.String;
//                        cmd.Parameters.Add(p3);

//                        var p4 = cmd.CreateParameter();
//p4.ParameterName = "4";
//                        p4.Value = data.CP_NAME;
//                        p4.DbType = DbType.String;
//                        cmd.Parameters.Add(p4);

//                        var p5 = cmd.CreateParameter();
//p5.ParameterName = "5";
//                        p5.Value = data.SUB_EMAIL;
//                        p5.DbType = DbType.String;
//                        cmd.Parameters.Add(p5);

//                        var p6 = cmd.CreateParameter();
//p6.ParameterName = "6";
//                        p6.Value = data.J_VARID;
//                        p6.DbType = DbType.String;
//                        cmd.Parameters.Add(p6);

//                        var p7 = cmd.CreateParameter();
//p7.ParameterName = "7";
//                        p7.Value = data.QUOTE;
//                        p7.DbType = DbType.String;
//                        cmd.Parameters.Add(p7);

//                        var p8 = cmd.CreateParameter();
//p8.ParameterName = "8";
//                        p8.Value = data.Q_DATE;
//                        p8.DbType = DbType.DateTime;
//                        cmd.Parameters.Add(p8);
//                        var p9 = cmd.CreateParameter();
//p9.ParameterName = "9";
//                        p9.Value = data.PO;
//                        p9.DbType = DbType.String;
//                        cmd.Parameters.Add(p9);
//                        var p10 = cmd.CreateParameter();
//p10.ParameterName = "10";
//                        p10.Value = data.SO;
//                        p10.DbType = DbType.String;
//                        cmd.Parameters.Add(p10);
//                        var p11 = cmd.CreateParameter();
//p11.ParameterName = "11";
//                        p11.Value = data.D_COMPNAME;
//                        p11.DbType = DbType.String;
//                        cmd.Parameters.Add(p11);
//                        var p12 = cmd.CreateParameter();
//p12.ParameterName = "12";
//                        p12.Value = data.D_STREET;
//                        p12.DbType = DbType.String;
//                        cmd.Parameters.Add(p12);
//                        var p13 = cmd.CreateParameter();
//p13.ParameterName = "13";
//                        p13.Value = data.D_CITY;
//                        p13.DbType = DbType.String;
//                        cmd.Parameters.Add(p13);
//                        var p14 = cmd.CreateParameter();
//p14.ParameterName = "14";
//                        p14.Value = data.D_STATE;
//                        p14.DbType = DbType.String;
//                        cmd.Parameters.Add(p14);
//                        var p15 = cmd.CreateParameter();
//p15.ParameterName = "15";
//                        p15.Value = data.D_POSTAL;
//                        p15.DbType = DbType.String;
//                        cmd.Parameters.Add(p15);
//                        var p16 = cmd.CreateParameter();
//p16.ParameterName = "16";
//                        p16.Value = data.D_CTY;
//                        p16.DbType = DbType.String;
//                        cmd.Parameters.Add(p16);
//                        var p17 = cmd.CreateParameter();
//p17.ParameterName = "17";
//                        p17.Value = data.EU_COMPNAME;
//                        p17.DbType = DbType.String;
//                        cmd.Parameters.Add(p17);
//                        var p18 = cmd.CreateParameter();
//p18.ParameterName = "18";
//                        p18.Value = data.EU_STREET;
//                        p18.DbType = DbType.String;
//                        cmd.Parameters.Add(p18);
//                        var p19 = cmd.CreateParameter();
//p19.ParameterName = "19";
//                        p19.Value = data.EU_CITY;
//                        p19.DbType = DbType.String;
//                        cmd.Parameters.Add(p19);
//                        var p20 = cmd.CreateParameter();
//p20.ParameterName = "20";
//                        p20.Value = data.EU_STATE;
//                        p20.DbType = DbType.String;
//                        cmd.Parameters.Add(p20);
//                        var p21 = cmd.CreateParameter();
//p21.ParameterName = "21";
//                        p21.Value = data.EU_POSTAL;
//                        p21.DbType = DbType.String;
//                        cmd.Parameters.Add(p21);
//                        var p22 = cmd.CreateParameter();
//p22.ParameterName = "22";
//                        p22.Value = data.EU_CTY;
//                        p22.DbType = DbType.String;
//                        cmd.Parameters.Add(p22);
//                        var p23 = cmd.CreateParameter();
//p23.ParameterName = "23";
//                        p23.Value = data.EU_NAME;
//                        p23.DbType = DbType.String;
//                        cmd.Parameters.Add(p23);
//                        var p24 = cmd.CreateParameter();
//p24.ParameterName = "24";
//                        p24.Value = data.EU_EMAIL;
//                        p24.DbType = DbType.String;
//                        cmd.Parameters.Add(p24);
//                        var p25 = cmd.CreateParameter();
//p25.ParameterName = "25";
//                        p25.Value = data.EU_URL;
//                        p25.DbType = DbType.String;
//                        cmd.Parameters.Add(p25);
//                        var p26 = cmd.CreateParameter();
//p26.ParameterName = "26";
//                        p26.Value = data.EU_BUSS_FN;
//                        p26.DbType = DbType.String;
//                        cmd.Parameters.Add(p26);
//                        var p27 = cmd.CreateParameter();
//p27.ParameterName = "27";
//                        p27.Value = data.EU_OFFERING;
//                        p27.DbType = DbType.String;
//                        cmd.Parameters.Add(p27);
//                        var p28 = cmd.CreateParameter();
//p28.ParameterName = "28";
//                        p28.Value = data.OP_COMPNAME;
//                        p28.DbType = DbType.String;
//                        cmd.Parameters.Add(p28);
//                        var p29 = cmd.CreateParameter();
//p29.ParameterName = "29";
//                        p29.Value = data.OP_STREET;
//                        p29.DbType = DbType.String;
//                        cmd.Parameters.Add(p29);
//                        var p30 = cmd.CreateParameter();
//p30.ParameterName = "30";
//                        p30.Value = data.OP_CITY;
//                        p30.DbType = DbType.String;
//                        cmd.Parameters.Add(p30);
//                        var p31 = cmd.CreateParameter();
//p31.ParameterName = "31";
//                        p31.Value = data.OP_STATE;
//                        p31.DbType = DbType.String;
//                        cmd.Parameters.Add(p31);
//                        var p32 = cmd.CreateParameter();
//p32.ParameterName = "32";
//                        p32.Value = data.OP_POSTAL;
//                        p32.DbType = DbType.String;
//                        cmd.Parameters.Add(p32);
//                        var p33 = cmd.CreateParameter();
//p33.ParameterName = "33";
//                        p33.Value = data.OP_CTY;
//                        p33.DbType = DbType.String;
//                        cmd.Parameters.Add(p33);
//                        var p34 = cmd.CreateParameter();
//p34.ParameterName = "34";
//                        p34.Value = data.OP_NAME;
//                        p34.DbType = DbType.String;
//                        cmd.Parameters.Add(p34);
//                        var p35 = cmd.CreateParameter();
//p35.ParameterName = "35";
//                        p35.Value = data.OP_EMAIL;
//                        p35.DbType = DbType.String;
//                        cmd.Parameters.Add(p35);
//                        var p36 = cmd.CreateParameter();
//p36.ParameterName = "36";
//                        p36.Value = data.OP_URL;
//                        p36.DbType = DbType.String;
//                        cmd.Parameters.Add(p36);
//                        var p37 = cmd.CreateParameter();
//p37.ParameterName = "37";
//                        p37.Value = data.NEU1_COMPNAME;
//                        p37.DbType = DbType.String;
//                        cmd.Parameters.Add(p37);
//                        var p38 = cmd.CreateParameter();
//p38.ParameterName = "38";
//                        p38.Value = data.NEU1_STREET;
//                        p38.DbType = DbType.String;
//                        cmd.Parameters.Add(p38);
//                        var p39 = cmd.CreateParameter();
//p39.ParameterName = "39";
//                        p39.Value = data.NEU1_CITY;
//                        p39.DbType = DbType.String;
//                        cmd.Parameters.Add(p39);
//                        var p40 = cmd.CreateParameter();
//p40.ParameterName = "40";
//                        p40.Value = data.NEU1_STATE;
//                        p40.DbType = DbType.String;
//                        cmd.Parameters.Add(p40);
//                        var p41 = cmd.CreateParameter();
//p41.ParameterName = "41";
//                        p41.Value = data.NEU1_POSTAL;
//                        p41.DbType = DbType.String;
//                        cmd.Parameters.Add(p41);
//                        var p42 = cmd.CreateParameter();
//p42.ParameterName = "42";
//                        p42.Value = data.NEU1_CTY;
//                        p42.DbType = DbType.String;
//                        cmd.Parameters.Add(p42);
//                        var p43 = cmd.CreateParameter();
//p43.ParameterName = "43";
//                        p43.Value = data.NEU1_NAME;
//                        p43.DbType = DbType.String;
//                        cmd.Parameters.Add(p43);
//                        var p44 = cmd.CreateParameter();
//p44.ParameterName = "44";
//                        p44.Value = data.NEU1_EMAIL;
//                        p44.DbType = DbType.String;
//                        cmd.Parameters.Add(p44);
//                        var p45 = cmd.CreateParameter();
//p45.ParameterName = "45";
//                        p45.Value = data.NEU1_URL;
//                        p45.DbType = DbType.String;
//                        cmd.Parameters.Add(p45);
//                        var p46 = cmd.CreateParameter();
//p46.ParameterName = "46";
//                        p46.Value = data.NEU2_COMPNAME;
//                        p46.DbType = DbType.String;
//                        cmd.Parameters.Add(p46);
//                        var p47 = cmd.CreateParameter();
//p47.ParameterName = "47";
//                        p47.Value = data.NEU2_STREET;
//                        p47.DbType = DbType.String;
//                        cmd.Parameters.Add(p47);
//                        var p48 = cmd.CreateParameter();
//p48.ParameterName = "48";
//                        p48.Value = data.NEU2_CITY;
//                        p48.DbType = DbType.String;
//                        cmd.Parameters.Add(p48);
//                        var p49 = cmd.CreateParameter();
//p49.ParameterName = "49";
//                        p49.Value = data.NEU2_STATE;
//                        p49.DbType = DbType.String;
//                        cmd.Parameters.Add(p49);
//                        var p50 = cmd.CreateParameter();
//p50.ParameterName = "50";
//                        p50.Value = data.NEU2_POSTAL;
//                        p50.DbType = DbType.String;
//                        cmd.Parameters.Add(p50);
//                        var p51 = cmd.CreateParameter();
//p51.ParameterName = "51";
//                        p51.Value = data.NEU2_CTY;
//                        p51.DbType = DbType.String;
//                        cmd.Parameters.Add(p51);
//                        var p52 = cmd.CreateParameter();
//p52.ParameterName = "52";
//                        p52.Value = data.NEU2_NAME;
//                        p52.DbType = DbType.String;
//                        cmd.Parameters.Add(p52);
//                        var p53 = cmd.CreateParameter();
//p53.ParameterName = "53";
//                        p53.Value = data.NEU2_EMAIL;
//                        p53.DbType = DbType.String;
//                        cmd.Parameters.Add(p53);
//                        var p54 = cmd.CreateParameter();
//p54.ParameterName = "54";
//                        p54.Value = data.NEU2_URL;
//                        p54.DbType = DbType.String;
//                        cmd.Parameters.Add(p54);
//                        var p55 = cmd.CreateParameter();
//p55.ParameterName = "55";
//                        p55.Value = data.NEU3_COMPNAME;
//                        p55.DbType = DbType.String;
//                        cmd.Parameters.Add(p55);
//                        var p56 = cmd.CreateParameter();
//p56.ParameterName = "56";
//                        p56.Value = data.NEU3_STREET;
//                        p56.DbType = DbType.String;
//                        cmd.Parameters.Add(p56);
//                        var p57 = cmd.CreateParameter();
//p57.ParameterName = "57";
//                        p57.Value = data.NEU3_CITY;
//                        p57.DbType = DbType.String;
//                        cmd.Parameters.Add(p57);
//                        var p58 = cmd.CreateParameter();
//p58.ParameterName = "58";
//                        p58.Value = data.NEU3_STATE;
//                        p58.DbType = DbType.String;
//                        cmd.Parameters.Add(p58);
//                        var p59 = cmd.CreateParameter();
//p59.ParameterName = "59";
//                        p59.Value = data.NEU3_POSTAL;
//                        p59.DbType = DbType.String;
//                        cmd.Parameters.Add(p59);
//                        var p60 = cmd.CreateParameter();
//p60.ParameterName = "60";
//                        p60.Value = data.NEU3_CTY;
//                        p60.DbType = DbType.String;
//                        cmd.Parameters.Add(p60);
//                        var p61 = cmd.CreateParameter();
//p61.ParameterName = "61";
//                        p61.Value = data.NEU3_NAME;
//                        p61.DbType = DbType.String;
//                        cmd.Parameters.Add(p61);
//                        var p62 = cmd.CreateParameter();
//p62.ParameterName = "62";
//                        p62.Value = data.NEU3_EMAIL;
//                        p62.DbType = DbType.String;
//                        cmd.Parameters.Add(p62);
//                        var p63 = cmd.CreateParameter();
//p63.ParameterName = "63";
//                        p63.Value = data.NEU3_URL;
//                        p63.DbType = DbType.String;
//                        cmd.Parameters.Add(p63);
//                        var p64 = cmd.CreateParameter();
//p64.ParameterName = "64";
//                        p64.Value = data.NEU4_COMPNAME;
//                        p64.DbType = DbType.String;
//                        cmd.Parameters.Add(p64);
//                        var p65 = cmd.CreateParameter();
//p65.ParameterName = "65";
//                        p65.Value = data.NEU4_STREET;
//                        p65.DbType = DbType.String;
//                        cmd.Parameters.Add(p65);
//                        var p66 = cmd.CreateParameter();
//p66.ParameterName = "66";
//                        p66.Value = data.NEU4_CITY;
//                        p66.DbType = DbType.String;
//                        cmd.Parameters.Add(p66);
//                        var p67 = cmd.CreateParameter();
//p67.ParameterName = "67";
//                        p67.Value = data.NEU4_STATE;
//                        p67.DbType = DbType.String;
//                        cmd.Parameters.Add(p67);
//                        var p68 = cmd.CreateParameter();
//p68.ParameterName = "68";
//                        p68.Value = data.NEU4_POSTAL;
//                        p68.DbType = DbType.String;
//                        cmd.Parameters.Add(p68);
//                        var p69 = cmd.CreateParameter();
//p69.ParameterName = "69";
//                        p69.Value = data.NEU4_CTY;
//                        p69.DbType = DbType.String;
//                        cmd.Parameters.Add(p69);
//                        var p70 = cmd.CreateParameter();
//p70.ParameterName = "70";
//                        p70.Value = data.NEU4_NAME;
//                        p70.DbType = DbType.String;
//                        cmd.Parameters.Add(p70);
//                        var p71 = cmd.CreateParameter();
//p71.ParameterName = "71";
//                        p71.Value = data.NEU4_EMAIL;
//                        p71.DbType = DbType.String;
//                        cmd.Parameters.Add(p71);
//                        var p72 = cmd.CreateParameter();
//p72.ParameterName = "72";
//                        p72.Value = data.NEU4_URL;
//                        p72.DbType = DbType.String;
//                        cmd.Parameters.Add(p72);
//                        var p73 = cmd.CreateParameter();
//p73.ParameterName = "73";
//                        p73.Value = data.EU_Q1;
//                        p73.DbType = DbType.String;
//                        cmd.Parameters.Add(p73);
//                        var p74 = cmd.CreateParameter();
//p74.ParameterName = "74";
//                        p74.Value = data.EU_Q2;
//                        p74.DbType = DbType.String;
//                        cmd.Parameters.Add(p74);
//                        var p75 = cmd.CreateParameter();
//p75.ParameterName = "75";
//                        p75.Value = data.S1_COMPNAME;
//                        p75.DbType = DbType.String;
//                        cmd.Parameters.Add(p75);
//                        var p76 = cmd.CreateParameter();
//p76.ParameterName = "76";
//                        p76.Value = data.S1_STREET;
//                        p76.DbType = DbType.String;
//                        cmd.Parameters.Add(p76);
//                        var p77 = cmd.CreateParameter();
//p77.ParameterName = "77";
//                        p77.Value = data.S1_CITY;
//                        p77.DbType = DbType.String;
//                        cmd.Parameters.Add(p77);
//                        var p78 = cmd.CreateParameter();
//p78.ParameterName = "78";
//                        p78.Value = data.S1_STATE;
//                        p78.DbType = DbType.String;
//                        cmd.Parameters.Add(p78);
//                        var p79 = cmd.CreateParameter();
//p79.ParameterName = "79";
//                        p79.Value = data.S1_POSTAL;
//                        p79.DbType = DbType.String;
//                        cmd.Parameters.Add(p79);
//                        var p80 = cmd.CreateParameter();
//p80.ParameterName = "80";
//                        p80.Value = data.S1_CTY;
//                        p80.DbType = DbType.String;
//                        cmd.Parameters.Add(p80);
//                        var p81 = cmd.CreateParameter();
//p81.ParameterName = "81";
//                        p81.Value = data.S1_URL;
//                        p81.DbType = DbType.String;
//                        cmd.Parameters.Add(p81);
//                        var p82 = cmd.CreateParameter();
//p82.ParameterName = "82";
//                        p82.Value = data.S2_COMPNAME;
//                        p82.DbType = DbType.String;
//                        cmd.Parameters.Add(p82);
//                        var p83 = cmd.CreateParameter();
//p83.ParameterName = "83";
//                        p83.Value = data.S2_STREET;
//                        p83.DbType = DbType.String;
//                        cmd.Parameters.Add(p83);
//                        var p84 = cmd.CreateParameter();
//p84.ParameterName = "84";
//                        p84.Value = data.S2_CITY;
//                        p84.DbType = DbType.String;
//                        cmd.Parameters.Add(p84);
//                        var p85 = cmd.CreateParameter();
//p85.ParameterName = "85";
//                        p85.Value = data.S2_STATE;
//                        p85.DbType = DbType.String;
//                        cmd.Parameters.Add(p85);
//                        var p86 = cmd.CreateParameter();
//p86.ParameterName = "86";
//                        p86.Value = data.S2_POSTAL;
//                        p86.DbType = DbType.String;
//                        cmd.Parameters.Add(p86);
//                        var p87 = cmd.CreateParameter();
//p87.ParameterName = "87";
//                        p87.Value = data.S2_CTY;
//                        p87.DbType = DbType.String;
//                        cmd.Parameters.Add(p87);
//                        var p88 = cmd.CreateParameter();
//p88.ParameterName = "88";
//                        p88.Value = data.S2_URL;
//                        p88.DbType = DbType.String;
//                        cmd.Parameters.Add(p88);
//                        var p89 = cmd.CreateParameter();
//p89.ParameterName = "89";
//                        p89.Value = data.S3_COMPNAME;
//                        p89.DbType = DbType.String;
//                        cmd.Parameters.Add(p89);
//                        var p90 = cmd.CreateParameter();
//p90.ParameterName = "90";
//                        p90.Value = data.S3_STREET;
//                        p90.DbType = DbType.String;
//                        cmd.Parameters.Add(p90);
//                        var p91 = cmd.CreateParameter();
//p91.ParameterName = "91";
//                        p91.Value = data.S3_CITY;
//                        p91.DbType = DbType.String;
//                        cmd.Parameters.Add(p91);
//                        var p92 = cmd.CreateParameter();
//p92.ParameterName = "92";
//                        p92.Value = data.S3_STATE;
//                        p92.DbType = DbType.String;
//                        cmd.Parameters.Add(p92);
//                        var p93 = cmd.CreateParameter();
//p93.ParameterName = "93";
//                        p93.Value = data.S3_POSTAL;
//                        p93.DbType = DbType.String;
//                        cmd.Parameters.Add(p93);
//                        var p94 = cmd.CreateParameter();
//p94.ParameterName = "94";
//                        p94.Value = data.S3_CTY;
//                        p94.DbType = DbType.String;
//                        cmd.Parameters.Add(p94);
//                        var p95 = cmd.CreateParameter();
//p95.ParameterName = "95";
//                        p95.Value = data.S3_URL;
//                        p95.DbType = DbType.String;
//                        cmd.Parameters.Add(p95);
//                        var p96 = cmd.CreateParameter();
//p96.ParameterName = "96";
//                        p96.Value = data.S4_COMPNAME;
//                        p96.DbType = DbType.String;
//                        cmd.Parameters.Add(p96);
//                        var p97 = cmd.CreateParameter();
//p97.ParameterName = "97";
//                        p97.Value = data.S4_STREET;
//                        p97.DbType = DbType.String;
//                        cmd.Parameters.Add(p97);
//                        var p98 = cmd.CreateParameter();
//p98.ParameterName = "98";
//                        p98.Value = data.S4_CITY;
//                        p98.DbType = DbType.String;
//                        cmd.Parameters.Add(p98);
//                        var p99 = cmd.CreateParameter();
//p99.ParameterName = "99";
//                        p99.Value = data.S4_STATE;
//                        p99.DbType = DbType.String;
//                        cmd.Parameters.Add(p99);
//                        var p100 = cmd.CreateParameter();
//p100.ParameterName = "100";
//                        p100.Value = data.S4_POSTAL;
//                        p100.DbType = DbType.String;
//                        cmd.Parameters.Add(p100);
//                        var p101 = cmd.CreateParameter();
//p101.ParameterName = "101";
//                        p101.Value = data.S4_CTY;
//                        p101.DbType = DbType.String;
//                        cmd.Parameters.Add(p101);
//                        var p102 = cmd.CreateParameter();
//p102.ParameterName = "102";
//                        p102.Value = data.S4_URL;
//                        p102.DbType = DbType.String;
//                        cmd.Parameters.Add(p102);
//                        var p103 = cmd.CreateParameter();
//p103.ParameterName = "103";
//                        p103.Value = data.S5_COMPNAME;
//                        p103.DbType = DbType.String;
//                        cmd.Parameters.Add(p103);
//                        var p104 = cmd.CreateParameter();
//p104.ParameterName = "104";
//                        p104.Value = data.S5_STREET;
//                        p104.DbType = DbType.String;
//                        cmd.Parameters.Add(p104);
//                        var p105 = cmd.CreateParameter();
//p105.ParameterName = "105";
//                        p105.Value = data.S5_CITY;
//                        p105.DbType = DbType.String;
//                        cmd.Parameters.Add(p105);
//                        var p106 = cmd.CreateParameter();
//p106.ParameterName = "106";
//                        p106.Value = data.S5_STATE;
//                        p106.DbType = DbType.String;
//                        cmd.Parameters.Add(p106);
//                        var p107 = cmd.CreateParameter();
//p107.ParameterName = "107";
//                        p107.Value = data.S5_POSTAL;
//                        p107.DbType = DbType.String;
//                        cmd.Parameters.Add(p107);
//                        var p108 = cmd.CreateParameter();
//p108.ParameterName = "108";
//                        p108.Value = data.S5_CTY;
//                        p108.DbType = DbType.String;
//                        cmd.Parameters.Add(p108);
//                        var p109 = cmd.CreateParameter();
//p109.ParameterName = "109";
//                        p109.Value = data.S5_URL;
//                        p109.DbType = DbType.String;
//                        cmd.Parameters.Add(p109);
//                        var p110 = cmd.CreateParameter();
//p110.ParameterName = "110";
//                        p110.Value = data.CP_COMPNAME;
//                        p110.DbType = DbType.String;
//                        cmd.Parameters.Add(p110);
//                        var p111 = cmd.CreateParameter();
//p111.ParameterName = "111";
//                        p111.Value = data.AUTH_REPRE_NAME;
//                        p111.DbType = DbType.String;
//                        cmd.Parameters.Add(p111);
//                        var p112 = cmd.CreateParameter();
//p112.ParameterName = "112";
//                        p112.Value = data.AUTH_REPRE_JOB;
//                        p112.DbType = DbType.String;
//                        cmd.Parameters.Add(p112);
//                        var p113 = cmd.CreateParameter();
//p113.ParameterName = "113";
//                        p113.Value = data.ACK_DATE;
//                        p113.DbType = DbType.DateTime;
//                        cmd.Parameters.Add(p113);


//                        var count = cmd.ExecuteNonQuery();

//conn.Close();
//                    }

//                    //conn.Close();
//                }