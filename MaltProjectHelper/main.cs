using Aspose.Email;
using Aspose.Email.Amp;
using Aspose.Email.Clients.Google;
using Aspose.Email.Mapi;
using Aspose.Email.Storage.Pst;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;

namespace MaltProjectHelper
{
    public partial class main : Form
    {

        public class OutLookMail_Object
        {
            public int ID { get; set; }
            public string Email_ID { get; set; }
            public string Email_Subject { get; set; }
            public DateTime? Email_DateTime { get; set; }
            public bool Email_hasAttachments { get; set; }
        }

        

        public string OutLook_FilePath { get; set; }

        public string Export_Attachment_Path { get; set; }

        public List<OutLookMail_Object> List_OutLookMail;

        public main()
        {
            InitializeComponent();

            dateTimePicker_From.Value = DateTime.Today.AddMonths(-1);
            dateTimePicker_To.Value = DateTime.Today;

            new Aspose.Email.License().SetLicense(AppDomain.CurrentDomain.BaseDirectory+"Aspose.Total.NET.lic");
            
        }

        public void ReadEmailsList()
        {

            string pstPath = OutLook_FilePath;
           

            PersonalStorage pst = PersonalStorage.FromFile(pstPath);
            
            //MessageInfoCollection messages = inbox.GetContents();
            //MessageBox.Show(messages.Count.ToString());

            List_OutLookMail = new List<OutLookMail_Object>();

            FolderInfo Mail_inbox = pst.GetPredefinedFolder(StandardIpmFolder.Inbox);

            int Mail_inbox_Count = Mail_inbox.GetContents().Count;

            progressBar_Main.Minimum = 0;
            progressBar_Main.Maximum = Mail_inbox_Count;
            progressBar_Main.Value = 0;

            MapiMessage Mail_message = null;
            //DateTime? sentDate = null;
            DateTime? receivedDate = null;
            bool hasAttachments =false;
            OutLookMail_Object Emessage = new OutLookMail_Object();

            int RowID = 0;

            DateTime FromDate = dateTimePicker_From.Value.Date;
            DateTime ToDate = dateTimePicker_To.Value.Date;


            foreach (MessageInfo messageInfo in Mail_inbox.GetContents())
            {
                Mail_message = pst.ExtractMessage(messageInfo);
                Emessage = new OutLookMail_Object();
                receivedDate = Mail_message.DeliveryTime;

                progressBar_Main.Value = progressBar_Main.Value + 1;
                progressBar_Main.Update();
                

                if (receivedDate.HasValue)
                {
                    if (receivedDate.Value.Date <= ToDate & receivedDate.Value.Date >= FromDate)
                    {
                        RowID = RowID + 1;
                        hasAttachments = Mail_message.Attachments.Count > 0;
                        Emessage.ID = RowID;
                        Emessage.Email_ID = messageInfo.EntryIdString;
                        Emessage.Email_Subject = Mail_message.Subject;
                        Emessage.Email_DateTime = receivedDate;
                        Emessage.Email_hasAttachments = hasAttachments;

                        List_OutLookMail.Add(Emessage);
                    }
                }
                Application.DoEvents();
            }


            dataGridView_ExportList.DataSource = List_OutLookMail.ToList();
            dataGridView_ExportList.Refresh();
            pst.Dispose();

            MessageBox.Show(List_OutLookMail.Count.ToString()+" emails was found!");

        }

        public void ExportAttachements()
        {
            string pstPath = OutLook_FilePath;
            string ExportPath = Export_Attachment_Path;

            PersonalStorage pst = PersonalStorage.FromFile(pstPath);
            FolderInfo Mail_inbox = pst.GetPredefinedFolder(StandardIpmFolder.Inbox);


            progressBar_Main.Minimum = 0;
            progressBar_Main.Maximum = List_OutLookMail.Count;
            progressBar_Main.Value = 0;

            int TotalExportCount = 0;

            List<string> EntryIDs = new List<string>();

            foreach (var messageSelection in List_OutLookMail)
            {
                EntryIDs.Add(messageSelection.Email_ID);
            }


            List<string> AllowFileFormats= new List<string>();
            AllowFileFormats.Add(".xls");
            AllowFileFormats.Add(".xlsx");
            AllowFileFormats.Add(".xlsm");
            AllowFileFormats.Add(".xlsb");
            AllowFileFormats.Add(".xltx");
            AllowFileFormats.Add(".xltm");

            string fileextension = "";

            
           // foreach (var messageSelection in List_OutLookMail)
           // {
                foreach (MessageInfo messageInfo in Mail_inbox.GetContents().Where(o => EntryIDs.Contains(o.EntryIdString)))
                {

                    progressBar_Main.Value = progressBar_Main.Value + 1;
                    progressBar_Main.Update();

                    MapiMessage message = pst.ExtractMessage(messageInfo);

                        foreach (MapiAttachment attachment in message.Attachments)
                        {


                         if (attachment.IsInline)
                             continue;


                         string filename = attachment.LongFileName;


                        byte[] data = attachment.BinaryData;

                        if (data != null && data.Length > 0)
                        {
                            fileextension = Path.GetExtension(filename);

                        if (AllowFileFormats.Contains(fileextension))
                        {


                            string baseName = Path.GetFileNameWithoutExtension(filename);
                            string timestamp = DateTime.Now.ToString("_MMddHHmmss") +
                                                           (DateTime.Now.Millisecond.ToString("000"));


                            string newName = baseName + timestamp + fileextension;
                            string filePath = Path.Combine(ExportPath, newName);


                            //if (filePath.Length > 259)
                            // {

                            attachment.Save(filePath);
                            TotalExportCount = TotalExportCount + 1;
                            // }
                            // else
                            // {
                            //Error Log
                            // }
                        }

                        }
                    Application.DoEvents();

                }
                Application.DoEvents();

                }

            //}
            pst.Dispose();
            MessageBox.Show(TotalExportCount.ToString() + " email attachments exported");
        }
        private void main_Load(object sender, EventArgs e)
        {
            OutLook_FilePath = Properties.Settings.Default["OutLookFile"].ToString();
            textBox_OutLookFilePath.Text = OutLook_FilePath;
            Export_Attachment_Path = Properties.Settings.Default["ExportAttachmentPath"].ToString();
            textBox_Export_Attachment_Path.Text = Export_Attachment_Path;
                //ReadEmailsList();
        }

        private void button_ReadOutLookFile_Click(object sender, EventArgs e)
        {
            ReadEmailsList();
        }

        private void button_Export_Click(object sender, EventArgs e)
        {
            ExportAttachements();
        }

        private void textBox_OutLookFilePath_TextChanged(object sender, EventArgs e)
        {
           // Properties.Settings.Default["OutLookFile"] = textBox_OutLookFilePath.Text;
           // Properties.Settings.Default.Save();

        }

        private void textBox_Export_Attachment_Path_TextChanged(object sender, EventArgs e)
        {
          //  Properties.Settings.Default["ExportAttachmentPath"] = textBox_Export_Attachment_Path.Text;
          //  Properties.Settings.Default.Save();
        }
    }
}
