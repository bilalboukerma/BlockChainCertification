using BlockChainCertification.Models;
using BlockChainCertification.Repos;
using BlockChainCertification.Server.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockChainCertification
{
    public partial class Awarde : Form
    {
        AwardeCrtificateController awarde = new AwardeCrtificateController();
        CritifiateRepository awarde2 = new CritifiateRepository();
        int Id;

        Certification certification;
        AwardeCrtificate awardeCrtificate;
        public Awarde(int Id)
        {
            this.Id =  Id;
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            awardeCrtificate = new AwardeCrtificate();
            awardeCrtificate.CertificationId = Id;// awarde2.GetCertification(Id);
            awardeCrtificate.CrtificateNumber = CrtificateNumber.Text;
            awardeCrtificate.Recipient = Recipient.Text;
            awardeCrtificate.provider = provider.Text;
            awardeCrtificate.Moyen =Convert.ToDecimal(Moyen.Text);
            awardeCrtificate.TransactionDate = TransactionDate.Value;
            awardeCrtificate.Notes = Notes.Text;
            awarde.CreateAwardeCrtificate(awardeCrtificate);
            MessageBox.Show("added successfully");
            getData();
        }
        void getData()
        {
            CertificationsGridView.DataSource =  awarde2.GetAwardeCrtificates(Id);
            CertificationsGridView.Columns[6].Visible = false;


        }

        private void Addnew_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = !PanelAdd.Visible;

        }

        private void Awarde_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
