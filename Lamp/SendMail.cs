using Microsoft.Exchange.WebServices.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Lamp
{
    public class SendMail
    {
        public static void sendUsingExchange(string filepath)
        {
            ExchangeService service = new ExchangeService(ExchangeVersion.Exchange2013);
            service.Credentials = new WebCredentials("pkreddy@juniper.net", "Chinnarosi123$");
            service.UseDefaultCredentials = false;
            service.AutodiscoverUrl("pkreddy@juniper.net", RedirectionUrlValidationCallback);

            EmailMessage email = new EmailMessage(service);
            email.ToRecipients.Add("c.pavankishorereddy@gmail.com");
            email.Subject = "HelloWorld";

            StringBuilder myvar = new StringBuilder();
            myvar.Append("<!doctype html>")
                 .Append("<html>")
                 .Append("  <head>")
                 .Append("    <meta name=\"viewport\" content=\"width=device-width\">")
                 .Append("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">")
                 .Append("    <title>Simple Transactional Email</title>")
                 .Append("   ")
                 .Append("  </head>")
                 .Append("  <body class=\"\" style=\"background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;\">")
                 .Append("    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"body\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;\">")
                 .Append("      <tr>")
                 .Append("        <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\"> </td>")
                 .Append("        <td class=\"container\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; width: 580px;\">")
                 .Append("          <div class=\"content\" style=\"box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;\">")
                 .Append("")
                 .Append("            <!-- START CENTERED WHITE CONTAINER -->")
                 .Append("            <span class=\"preheader\" style=\"color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;\"></span>")
                 .Append("            <table class=\"main\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #ffffff; border-radius: 3px;\">")
                 .Append("")
                 .Append("              <!-- START MAIN CONTENT AREA -->")
                 .Append("              <tr>")
                 .Append("                <td class=\"wrapper\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;\">")
                 .Append("                  <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\">")
                 .Append("                    <tr>")
                 .Append("                      <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">")
                 .Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Hi there,</p>")
                 .Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Sometimes you just want to send a simple HTML email with a simple design and clear call to action. This is it.</p>")
                 .Append("                        <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; box-sizing: border-box;\">")
                 .Append("                          <tbody>")
                 .Append("                            <tr>")
                 .Append("                              <td align=\"left\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;\">")
                 .Append("                                <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;\">")
                 .Append("                                  <tbody>")
                 .Append("                                    <tr>")
                 .Append("                                      <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #3498db; border-radius: 5px; text-align: center;\"> ")
                 .Append("									  <form action=\"https://demo.docusign.net/Member/PowerFormSigning.aspx?PowerFormId=2ff912ac-e579-4a06-931c-4907ac88ed24\" method=\"POST\">")
                 .Append("										<input type=\"hidden\" name=\"quote_id\" id=\"quote_id\" value='123456789'/>")
                 .Append("										<input type=\"hidden\" name='date_signed' value=\"Lauren\" id=\"date_signed\"/>")
                 .Append("										<input type=\"hidden\" name=\"reseller_name\" id=\"reseller_name\" value='Robinson'/>")
                 .Append("										<input type=\"hidden\" name=\"po_number\" id=\"po_number\" value='Robinson Doe'/>")
                 .Append("										<input type=\"hidden\" name=\"eu_name\" id=\"eu_name\" value='email@gmail.com'/>")
                 .Append("										<input class=\"form_submit\" type=\"submit\" value='Click here to sign the form.'/>")
                 .Append("									  </form> </td>")
                 .Append("                                    </tr>")
                 .Append("                                  </tbody>")
                 .Append("                                </table>")
                 .Append("                              </td>")
                 .Append("                            </tr>")
                 .Append("                          </tbody>")
                 .Append("                        </table>")
                 .Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">This is a really simple email template. Its sole purpose is to get the recipient to click the button with no distractions.</p>")
                 .Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Good luck! Hope it works.</p>")
                 .Append("                      </td>")
                 .Append("                    </tr>")
                 .Append("                  </table>")
                 .Append("                </td>")
                 .Append("              </tr>")
                 .Append("")
                 .Append("            <!-- END MAIN CONTENT AREA -->")
                 .Append("            </table>")
                 .Append("")
                 .Append("            <!-- START FOOTER -->")
                 .Append("            <div class=\"footer\" style=\"clear: both; Margin-top: 10px; text-align: center; width: 100%;\">")
                 .Append("              <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\">")
                 .Append("                <tr>")
                 .Append("                  <td class=\"content-block\" style=\"font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;\">")
                 .Append("                    <span class=\"apple-link\" style=\"color: #999999; font-size: 12px; text-align: center;\">Company Inc, 3 Abbey Road, San Francisco CA 94102</span>")
                 .Append("                    <br> Don't like these emails? <a href=\"http://i.imgur.com/CScmqnj.gif\" style=\"text-decoration: underline; color: #999999; font-size: 12px; text-align: center;\">Unsubscribe</a>.")
                 .Append("                  </td>")
                 .Append("                </tr>")
                 .Append("                <tr>")
                 .Append("                  <td class=\"content-block powered-by\" style=\"font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;\">")
                 .Append("                    Powered by <a href=\"http://htmlemail.io\" style=\"color: #999999; font-size: 12px; text-align: center; text-decoration: none;\">HTMLemail</a>.")
                 .Append("                  </td>")
                 .Append("                </tr>")
                 .Append("              </table>")
                 .Append("            </div>")
                 .Append("            <!-- END FOOTER -->")
                 .Append("")
                 .Append("          <!-- END CENTERED WHITE CONTAINER -->")
                 .Append("          </div>")
                 .Append("        </td>")
                 .Append("        <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\"> </td>")
                 .Append("      </tr>")
                 .Append("    </table>")
                 .Append("  </body>")
                 .Append("</html>");
            email.Body = new MessageBody(myvar.ToString());
            email.Body.BodyType = BodyType.HTML;
            email.Attachments.AddFileAttachment(filepath);
            try
            {
                email.Send();
            }
            catch (Exception ex)
            {

            }

        }

        private static bool RedirectionUrlValidationCallback(string redirectionUrl)
        {
            return redirectionUrl.ToLower().StartsWith("https://");
        }

        public static void sendUsingSmtp(String encryptedMail, string email, int RefNo, string form = null)
        {
            MailMessage msg = new MailMessage { To = { email } };
            if (form == null)
            {
                msg.CC.Add(new MailAddress("tradecompliance@juniper.net"));
                msg.CC.Add(new MailAddress("sunnyli@juniper.net"));
                msg.CC.Add(new MailAddress("cylam@juniper.net"));
                msg.From = new MailAddress("tradecompliance@Juniper.net", "Trade Compliance Team");
                msg.Subject = "Submission of ELAIS Form (Ref.No'" + RefNo + "')";
            }
            else
            {
                msg.From = new MailAddress("tradecompliance-swdl@Juniper.net", "Trade Compliance Team");
                msg.CC.Add(new MailAddress("tradecompliance-swdl@Juniper.net"));
                msg.Subject = "Submission of SWDL Form (Ref.No'" + RefNo + "')";
            }

            msg.IsBodyHtml = true;


            StringBuilder sb = new StringBuilder();

            sb.Append("<!doctype html>");
            sb.Append("<html>");
            sb.Append("  <head>");
            sb.Append("    <meta name=\"viewport\" content=\"width=device-width\">");
            sb.Append("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            sb.Append("    <title>Juniper Legal Complaince Team</title>");
            sb.Append("   ");
            sb.Append("  </head>");
            sb.Append("  <body class=\"\" style=\"background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;\">");
            sb.Append("    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"body\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;\">");
            sb.Append("      <tr>");
            sb.Append("        <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">&nbsp;</td>");
            sb.Append("        <td class=\"container\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; width: 580px;\">");
            sb.Append("          <div class=\"content\" style=\"box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;\">");
            sb.Append("            <!-- START CENTERED WHITE CONTAINER -->");
            sb.Append("            <span class=\"preheader\" style=\"color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;\"></span>");
            sb.Append("            <table class=\"main\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #ffffff; border-radius: 3px;\">");
            sb.Append("              <!-- START MAIN CONTENT AREA -->");
            sb.Append("              <tr>");
            sb.Append("                <td class=\"wrapper\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;\">");
            sb.Append("                  <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\">");
            sb.Append("                    <tr>");
            sb.Append("                      <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Dear Customer,</p>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Thanks for submiting the {formName} Form ,Please Click <a href=\"{encryptedMail}\">here</a> to review or print a copy of your form.</p>");
            sb.Append("                        <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; box-sizing: border-box;\">");
            sb.Append("                          <tbody>");
            sb.Append("                            <tr>");
            sb.Append("                              <td align=\"left\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;\">");
            sb.Append("                                <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;\">");
            sb.Append("                                  <tbody>");
            sb.Append("                                    <tr>");
            sb.Append("                                      <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #3498db; border-radius: 5px; text-align: center;\"> ");
            sb.Append("                                          ");
            sb.Append("                                      </td>");
            sb.Append("                                    </tr>");
            sb.Append("                                  </tbody>");
            sb.Append("                                </table>");
            sb.Append("                              </td>");
            sb.Append("                            </tr>");
            sb.Append("                          </tbody>");
            sb.Append("                        </table>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">If you have any questions about this process, please do not hesitate to email <a href=\"mailto:{mailTo}\">{mailTo}</a></p>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Best Regards</p>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; Margin-bottom: 15px;\">Trade Compliance Team</p>");
            sb.Append("                      </td>");
            sb.Append("                    </tr>");
            sb.Append("                  </table>");
            sb.Append("                </td>");
            sb.Append("              </tr>");
            sb.Append("            <!-- END MAIN CONTENT AREA -->");
            sb.Append("            </table>");
            sb.Append("            <!-- START FOOTER -->");
            sb.Append("            <div class=\"footer\" style=\"clear: both; Margin-top: 10px; text-align: center; width: 100%;\">");
            sb.Append("              <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\">");
            sb.Append("                <tr>");
            sb.Append("                  <td class=\"content-block\" style=\"font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;\">");
            sb.Append("                    <span class=\"apple-link\" style=\"color: #999999; font-size: 12px; text-align: center;\">Juniper Networks Inc.</span>");
            sb.Append("                  </td>");
            sb.Append("                </tr>");
            sb.Append("                <tr>");
            sb.Append("                </tr>");
            sb.Append("              </table>");
            sb.Append("            </div>");
            sb.Append("            <!-- END FOOTER -->");
            sb.Append("          <!-- END CENTERED WHITE CONTAINER -->");
            sb.Append("          </div>");
            sb.Append("        </td>");
            sb.Append("        <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">&nbsp;</td>");
            sb.Append("      </tr>");
            sb.Append("    </table>");
            sb.Append("  </body>");
            sb.Append("</html>");

            sb.Replace("{encryptedMail}", encryptedMail);

            if (form != null)
            {
                sb.Replace("{formName}", form);
                sb.Replace("{mailTo}", "tradecompliance-swdl@juniper.net");
            }
            else
            {
                sb.Replace("{formName}", "ELAIS");
                sb.Replace("{mailTo}", "tradecompliance@juniper.net");
            }

            msg.Body = sb.ToString();
            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(filepath);
            //-----
            //MemoryStream memoryStream = new MemoryStream(pdfBinary);
            //msg.Attachments.Add(new System.Net.Mail.Attachment(memoryStream, filepath, MediaTypeNames.Application.Pdf));
            SmtpClient client = new SmtpClient();
            //client.UseDefaultCredentials = true;
            //client.Credentials = new System.Net.NetworkCredential("pkreddy@juniper.net", "");
            client.Port = 25; // You can use Port 25 if 587 is blocked (mine is!)
            client.Host = "smtp.juniper.net";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            //Add this line to bypass the certificate validation
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                    System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                    System.Security.Cryptography.X509Certificates.X509Chain chain,
                    System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
            try
            {
                client.Send(msg);
                //Console.WriteLine = "Message Sent Succesfully";
            }
            catch (Exception ex)
            {
                //Console.WriteLine = ex.ToString();
            }

        }

        public static void sendUsingSmtpProductCompliance(string RefNo, string encryptedMail)
        {
            MailMessage msg = new MailMessage();

            msg.To.Add(new MailAddress("product_compliance_checklist_app@juniper.net"));
            msg.From = new MailAddress("lamp-support@juniper.net", "Legal Support Team");
            msg.Subject = "Submission of Product Compliance Form (Ref.No'" + RefNo + "')";

            msg.IsBodyHtml = true;


            StringBuilder sb = new StringBuilder();

            sb.Append("<!doctype html>");
            sb.Append("<html>");
            sb.Append("  <head>");
            sb.Append("    <meta name=\"viewport\" content=\"width=device-width\">");
            sb.Append("    <meta http-equiv=\"Content-Type\" content=\"text/html; charset=UTF-8\">");
            sb.Append("    <title>Juniper Legal Complaince Team</title>");
            sb.Append("   ");
            sb.Append("  </head>");
            sb.Append("  <body class=\"\" style=\"background-color: #f6f6f6; font-family: sans-serif; -webkit-font-smoothing: antialiased; font-size: 14px; line-height: 1.4; margin: 0; padding: 0; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;\">");
            sb.Append("    <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"body\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background-color: #f6f6f6;\">");
            sb.Append("      <tr>");
            sb.Append("        <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">&nbsp;</td>");
            sb.Append("        <td class=\"container\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; display: block; Margin: 0 auto; max-width: 580px; padding: 10px; width: 580px;\">");
            sb.Append("          <div class=\"content\" style=\"box-sizing: border-box; display: block; Margin: 0 auto; max-width: 580px; padding: 10px;\">");
            sb.Append("            <!-- START CENTERED WHITE CONTAINER -->");
            sb.Append("            <span class=\"preheader\" style=\"color: transparent; display: none; height: 0; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; mso-hide: all; visibility: hidden; width: 0;\"></span>");
            sb.Append("            <table class=\"main\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; background: #ffffff; border-radius: 3px;\">");
            sb.Append("              <!-- START MAIN CONTENT AREA -->");
            sb.Append("              <tr>");
            sb.Append("                <td class=\"wrapper\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; box-sizing: border-box; padding: 20px;\">");
            sb.Append("                  <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\">");
            sb.Append("                    <tr>");
            sb.Append("                      <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Dear Requestor,</p>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Thanks for submiting the {formName} form ,Please Click <a href=\"{encryptedMail}\">here</a> to review or print a copy of your form.</p>");
            sb.Append("                        <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" class=\"btn btn-primary\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%; box-sizing: border-box;\">");
            sb.Append("                          <tbody>");
            sb.Append("                            <tr>");
            sb.Append("                              <td align=\"left\" style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; padding-bottom: 15px;\">");
            sb.Append("                                <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: auto;\">");
            sb.Append("                                  <tbody>");
            sb.Append("                                    <tr>");
            sb.Append("                                      <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top; background-color: #3498db; border-radius: 5px; text-align: center;\"> ");
            sb.Append("                                          ");
            sb.Append("                                      </td>");
            sb.Append("                                    </tr>");
            sb.Append("                                  </tbody>");
            sb.Append("                                </table>");
            sb.Append("                              </td>");
            sb.Append("                            </tr>");
            sb.Append("                          </tbody>");
            sb.Append("                        </table>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">If you have any questions about this request, please do not hesitate to email <a href=\"mailto:{mailTo}\">{mailTo}</a></p>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; margin: 0; Margin-bottom: 15px;\">Best Regards</p>");
            sb.Append("                        <p style=\"font-family: sans-serif; font-size: 14px; font-weight: normal; Margin-bottom: 15px;\">Product Compliance Team</p>");
            sb.Append("                      </td>");
            sb.Append("                    </tr>");
            sb.Append("                  </table>");
            sb.Append("                </td>");
            sb.Append("              </tr>");
            sb.Append("            <!-- END MAIN CONTENT AREA -->");
            sb.Append("            </table>");
            sb.Append("            <!-- START FOOTER -->");
            sb.Append("            <div class=\"footer\" style=\"clear: both; Margin-top: 10px; text-align: center; width: 100%;\">");
            sb.Append("              <table border=\"0\" cellpadding=\"0\" cellspacing=\"0\" style=\"border-collapse: separate; mso-table-lspace: 0pt; mso-table-rspace: 0pt; width: 100%;\">");
            sb.Append("                <tr>");
            sb.Append("                  <td class=\"content-block\" style=\"font-family: sans-serif; vertical-align: top; padding-bottom: 10px; padding-top: 10px; font-size: 12px; color: #999999; text-align: center;\">");
            sb.Append("                    <span class=\"apple-link\" style=\"color: #999999; font-size: 12px; text-align: center;\">Juniper Networks Inc.</span>");
            sb.Append("                  </td>");
            sb.Append("                </tr>");
            sb.Append("                <tr>");
            sb.Append("                </tr>");
            sb.Append("              </table>");
            sb.Append("            </div>");
            sb.Append("            <!-- END FOOTER -->");
            sb.Append("          <!-- END CENTERED WHITE CONTAINER -->");
            sb.Append("          </div>");
            sb.Append("        </td>");
            sb.Append("        <td style=\"font-family: sans-serif; font-size: 14px; vertical-align: top;\">&nbsp;</td>");
            sb.Append("      </tr>");
            sb.Append("    </table>");
            sb.Append("  </body>");
            sb.Append("</html>");

            sb.Replace("{encryptedMail}", encryptedMail);


            sb.Replace("{formName}", "Product Compliance Checklist");
            sb.Replace("{mailTo}", "product_compliance_checklist_app@juniper.net");


            msg.Body = sb.ToString();
            //System.Net.Mail.Attachment attachment;
            //attachment = new System.Net.Mail.Attachment(filepath);
            //-----
            //MemoryStream memoryStream = new MemoryStream(pdfBinary);
            //msg.Attachments.Add(new System.Net.Mail.Attachment(memoryStream, filepath, MediaTypeNames.Application.Pdf));
            SmtpClient client = new SmtpClient();
            //client.UseDefaultCredentials = true;
            //client.Credentials = new System.Net.NetworkCredential("pkreddy@juniper.net", "");
            client.Port = 25; // You can use Port 25 if 587 is blocked (mine is!)
            client.Host = "smtp.juniper.net";
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            //Add this line to bypass the certificate validation
            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object s,
                    System.Security.Cryptography.X509Certificates.X509Certificate certificate,
                    System.Security.Cryptography.X509Certificates.X509Chain chain,
                    System.Net.Security.SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };
            try
            {
                client.Send(msg);
                //Console.WriteLine = "Message Sent Succesfully";
            }
            catch (Exception ex)
            {
                //Console.WriteLine = ex.ToString();
            }

        }
    }
}
