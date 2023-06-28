using ByteComputer.Data;
using ByteComputer.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Svg.CommonSvgImages;

namespace ByteComputer
{
    public partial class frmMain : Form
    {
        public static int editUserID = 0;
        public static int editStudiesID = 0;
        public frmMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.xtraTabControl1.SelectedTabPage = xtraTabPage1;
        }



        private void frmMain_Load(object sender, EventArgs e)
        {           
            initializeData();
        }
        private void initializeData()
        {
            // TODO: This line of code loads data into the 'dataSet1.docs' table. You can move, or remove it, as needed.
            this.docsTableAdapter.Fill(this.dataSet1.docs);
            this.degreesTableAdapter.Fill(this.dataSet1.Degrees);
            this.candidatesTableAdapter.Fill(this.dataSet1.Candidates);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.xtraTabControl1.SelectedTabPage.Name.Equals("xtraTabPage1"))
            {
                editUserID = 0;
                frmAddEdit frm = new frmAddEdit();
                frm.ShowDialog();
                initializeData();
            }
            else
            {
                editStudiesID = 0;
                frmDegrees frm = new frmDegrees();
                frm.ShowDialog();
                initializeData();
            }
            
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.xtraTabControl1.SelectedTabPage.Name.Equals("xtraTabPage1"))
            {
                editUserID = (int)gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Id");
                frmAddEdit frm = new frmAddEdit();
                frm.ShowDialog();
                
            }
            else
            {
                editStudiesID = (int)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Id");
                frmDegrees frm = new frmDegrees();
                frm.ShowDialog();
                
            }
            initializeData();
        }
        private string degreeDescr;
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.xtraTabControl1.SelectedTabPage.Name.Equals("xtraTabPage1"))
            {
                string message = "Θέλετε να διαγράψετε τον υποψήφιο";
                if (XtraMessageBox.Show(message + " ;", "Επιβεβαίωση Διαγραφής", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                try
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    candidatesTableAdapter.Update(dataSet1);
                    XtraMessageBox.Show("O υποψήφιος διαγράφηκε");
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Κάτι πήγε στραβά στη διαγραφή: " + ex.Message);
                }

            }
            else
            {
                string message = "Θελετε να διαγραψετε τις σπουδές";
                if (XtraMessageBox.Show(message + " ;", "Επιβεβαίωση Διαγραφής", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                try
                {
                    editStudiesID = (int)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Id");
                    degreeDescr = (string)gridView2.GetRowCellValue(gridView2.FocusedRowHandle, "Description");
                    this.degreesTableAdapter.Delete(editStudiesID,degreeDescr);
                    //gridView2.DeleteRow(gridView2.FocusedRowHandle);
                    candidatesTableAdapter.Update(this.dataSet1);
                    XtraMessageBox.Show("Oι σπουδές διαγράφηκαν");
                }
                catch (SqlException ex)
                {
                    
                    XtraMessageBox.Show("Οι συγκεκριμένες σπουδές χρησιμοποιούνται για υποψήφιους και δεν γίνεται να διαγραφούν ");
                }
            }

            initializeData();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
