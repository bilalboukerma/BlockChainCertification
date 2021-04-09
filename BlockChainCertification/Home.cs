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
    public partial class Home : Form
    {
        AwardeCrtificateController awarde =new AwardeCrtificateController();
        Certification certification;
        Awarde formAwarde;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void CertificationsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            formAwarde = new Awarde(Convert.ToInt32(CertificationsGridView.CurrentRow.Cells[1].Value.ToString()));
            formAwarde.ShowDialog();
        }

        private void Addnew_Click(object sender, EventArgs e)
        {
            PanelAdd.Visible = !PanelAdd.Visible;
        }

        private void save_Click(object sender, EventArgs e)
        {
            certification = new Certification();
            certification.CertificateTitle = CertificateTitle.Text;
            certification.Notes = Notes.Text;
            certification.CreateDate = CreateDate.Value;
            awarde.CreateCertification(certification);
            MessageBox.Show("added successfully");
            getData();
        }
        void getData()
        {
            CertificationsGridView.DataSource = awarde.Gets();
           

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
