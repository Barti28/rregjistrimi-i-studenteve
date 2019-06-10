using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using IronPdf;
using System.Text;

namespace ProjektiFinal
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {

            }
        }
        protected void lbn_exportToPdf_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("C:/Users/Barti/Downloads/Studenti.htm", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8)) {
                    w.WriteLine("<!DOCTYPE html>");
                    w.WriteLine("<html>");
                    w.WriteLine("<body>");
                    w.WriteLine("<div style='padding:10px; border-style: groove; margin:-10px;'>");
                    w.WriteLine("<img src =\"C:/Users/Barti/Desktop/prova1/ProjektiFinal-1/ProjektiFinal/images/ut.jpg\"  style='float: left; width:142px; height:186px; padding-top:30px' />");
                    w.WriteLine("<img src=\"C:/Users/Barti/Desktop/prova1/ProjektiFinal-1/ProjektiFinal/images/fakulteti-i-ekonomise.jpg\" style ='float: right; width:150px; height:122px;margin-top:20px; padding-top:37px; '/>");
                    w.WriteLine("<h1 style='text-align:center; margin-right:100px;padding-top:50px;'>Universiteti i Tiranës </ h1 > ");
                    w.WriteLine("<h2 style='text-align:center; margin-bottom:80px; margin-right:100px; margin-top:28px;'>Fakulteti i Ekonomisë</h2>");
                    w.WriteLine("<h3 > Vërtetim i të dhënave tuaja nga regjistrimi:</h3>");
                    w.WriteLine("<p>Ky dokument lëshohet për qëllim verifikimi dhe regjistrimi nga FEUT. Të dhënat që sapo futët janë si këto më poshtë. Ju urojmë një vit akademik të suksesshëm. Ruajeni këtë dokument në pdf dhe dërgojeni në emailin tuaj.</p>");
                    w.WriteLine("<p>Stafi i Fakultetit të Ekonomisë !</p>");
                    w.WriteLine("</br><p style='font-size:28px; color:red; margin:auto; text-decoration: underline; text-align:center;'>Të dhënat e studentit: </p>");
                    w.WriteLine("<h4 style='background-color:Tomato; text-align:center;;'>Emri:" + txt_emri.Text + "</h4>");
                    w.WriteLine("<h4 style='background-color:Orange; text-align:center; '>Mbiemri: " + txt_mbiemri.Text + "</h4>");
                    w.WriteLine("<h4 style='background-color:MediumSeaGreen; text-align:center;' >Gjinia: " + rdb_gjinia.SelectedItem + "</h4>");
                    w.WriteLine("<h4 style='background-color:Gray; text-align:center;'>Koha e plotesimit: " + cal_koha.SelectedDate.ToString("dddd, dd MMMM yyyy") + "</h4>");
                    w.WriteLine("<h4 style='background-color:LightGray; text-align:center;'>Dega: " + ddl_dega.SelectedItem + "</h4>");

                    w.WriteLine("</br><p style='font-size:20px; color:green; margin:auto; text-decoration: underline; margin-bottom:30px;' > Të dhënat e gjeneruara në formë tabelare: </p> ");
                    w.WriteLine("<table style='border-collapse:collapse; table-layout:auto;' border = '3' opacity:'0.95' background-color:'grey';>");
                    w.WriteLine("<tbody>");
                    w.WriteLine("<tr>");
                    w.WriteLine("<td style='background-color:# 70000; color:blue; text-align:center; font-size:26px;'>Emri</td>");
                    w.WriteLine("<td style='background-color:# 70000; color:blue; text-align:center; font-size:26px;'>Mbiemri</td>");
                    w.WriteLine("<td style='background-color:# 70000; color:blue; text-align:center; font-size:26px;'>Gjinia</td>");
                    w.WriteLine("<td style='background-color:# 70000; color:blue; text-align:center; font-size:26px;'>Koha e plotësimit</td>");
                    w.WriteLine("<td style='background-color:# 70000; color:blue; text-align:center; font-size:26px;'>Dega</td>");
                    w.WriteLine("</tr>");
                    w.WriteLine("<tr>");
                    w.WriteLine("<td style='color:brown; text-align:center; font-size:19px;'>" + txt_emri.Text +"</td>");
                    w.WriteLine("<td style='color:brown; text-align:center; font-size:19px;'>" + txt_mbiemri.Text + "</td>");
                    w.WriteLine("<td style='color:brown; text-align:center; font-size:19px;'>" + rdb_gjinia.SelectedItem + "</td>");
                    w.WriteLine("<td style='color:brown; text-align:center; font-size:19px;'>" + cal_koha.SelectedDate.ToString("dddd, dd MMMM yyyy") + "</td>");
                    w.WriteLine("<td style='color:brown; text-align:center; font-size:19px;'>" + ddl_dega.SelectedItem + "</td>");
                    w.WriteLine("</tr>");
                    w.WriteLine("</tbody>");
                    w.WriteLine("</table>");
                    w.WriteLine("</br><a href='http://www.feut.edu.al/'>Faqja Kryesore e Fakultetit</a>");
                    w.WriteLine("<table style='width:100%;'>");
                    w.WriteLine("<tr><td><h3>Sekretarja</h3></td><td><h3> Dekani </h3></td><td><h3> Zv.Dekani </h3></td></tr>");
                    w.WriteLine("<tr><td style='font-size:21px;'>Lindita Zyka</td><td style='font-size:21px;'>Dhori Kule</td><td style='font-size:21px;'>Alban Korbi</td></tr>");
                    w.WriteLine("</table>");
                    w.WriteLine("</br></br></br></br>");
                    w.WriteLine("<hr><ul style='list-style-type: none; '><li>Adresa: Rruga Arben Broci, Tiranë</li><li>Kontakti: LinditaZyka@feut.edu.al</li></ul>");
                    w.WriteLine("</div>");
                    w.WriteLine("</body>");
                    w.WriteLine("</html>");

                }
                var Redender = new IronPdf.HtmlToPdf();
                var PDF = Redender.RenderHTMLFileAsPdf("C:/Users/Barti/Downloads/Studenti.htm");
                var OutputPath = "C:/Users/Barti/source/repos/studenti.pdf";
                PDF.SaveAs(OutputPath);
                System.Diagnostics.Process.Start("C:/Users/Barti/source/repos/studenti.pdf");
            }
        }

        // Required to avoid the runtime error.
        public override void VerifyRenderingInServerForm(Control control)
        {
        }
        protected void Ngarko_Click(object sender, EventArgs e)
        {
            // Specify the path on the server to
            // save the uploaded file to.
            string savePath = @"c:\Desktop";

            // Before attempting to save the file, verify
            // that the FileUpload control contains a file.
            if (FileUpload1.HasFile)
            {
                // Get the name of the file to upload.
                string fileName = Server.HtmlEncode(FileUpload1.FileName);

                // Get the extension of the uploaded file.
                string extension = System.IO.Path.GetExtension(fileName);
            }
        }



        private void InitializeGrid()
        {
            try
            {
                ViewState["applicationDetail"] = null;

                DataTable dt = new DataTable();
                dt.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("Emri", typeof(string)),
                    new DataColumn("Mbiemri",typeof(string)),
                    new DataColumn("Koha e plotesimit", typeof(string)),
                    new DataColumn("Gjinia", typeof(string)),
                    new DataColumn("Dega", typeof(string)),
                    new DataColumn("Emaili", typeof(string))
                });

                DataRow drRow = dt.NewRow();
                drRow["Emri"] = txt_emri.Text;
                drRow["Mbiemri"] = txt_mbiemri.Text;
                drRow["Koha e plotesimit"] = cal_koha.SelectedDate.ToString("dddd, dd MMMM yyyy");
                drRow["Gjinia"] = rdb_gjinia.SelectedItem.Text;
                drRow["Dega"] = ddl_dega.SelectedItem.Text;
                drRow["Emaili"] = txt_email.Text;
                dt.Rows.Add(drRow);

                ViewState["applicationDetail"] = dt;
                gv_tabela.DataSource = ViewState["applicationDetail"];
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        protected void lbt_shto_Click(object sender, EventArgs e)
        {
            InitializeGrid();
            gv_tabela.DataBind();
        }

        protected void lbn_sendemail_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("projektpune11@gmail.com", "lusi1234");
                MailMessage message = new MailMessage();
                message.To.Add(txt_email.Text);
                message.IsBodyHtml = true;
                message.From = new MailAddress("projektpune11@gmail.com");
                message.Subject = "Te dhenat e studentit";
                message.Body = "<!DOCTYPE html> " +
                "<html xmlns=\"http://www.w3.org/1999/xhtml\">" +
                "<head>" +
                    "<title>Te dhenat e studentit</title>" +
                "</head>" +
                "<body style=\"font-family:'Century Gothic'\">" +
                    "<h4 style=\"font-size:14px;\">" + "Emri: " + txt_emri.Text + "</h4>" +
                    "</br><h4>Mbiemri: " + txt_mbiemri.Text + "</h4>" +
                    "</br><h4>Gjinia: " + rdb_gjinia.SelectedItem + "</h4>" +
                    "</br><h4>Koha e plotesimit: " + cal_koha.SelectedDate.ToString("dddd, dd MMMM yyyy") + "</h4>" +
                    "</br><h4>Dega: " + ddl_dega.SelectedItem +
                    "</h4>" +
                "</body>" +
                "</html>";
              
                Attachment data = new Attachment("C:/Users/Barjam/source/repos/studenti.pdf");
                message.Attachments.Add(data);
                smtpClient.Send(message);
                Response.Write("Mesazhi u dergua me sukses");
            }
            catch (Exception ex)
            {
                Response.Write("Nuk u dergua dot emaili" + ex.Message);
            }
        }

      
    }
}
