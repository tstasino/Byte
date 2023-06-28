using ByteComputer.Data.DataSet1TableAdapters;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteComputer.Forms
{
    public partial class frmDegrees : DevExpress.XtraEditors.XtraForm
    {
        public frmDegrees()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            if (txtEdtDegree.EditValue == null || txtEdtDegree.EditValue.ToString().Trim() == "")
            {
                dxErrorProvider1.SetError(txtEdtDegree, "Το CV είναι υποχρεωτικό", ErrorType.Critical);
                return;
            }
            else dxErrorProvider1.SetError(txtEdtDegree, null);

            if (dxErrorProvider1.HasErrors) return;

            if (frmMain.editStudiesID == 0)
            {
                try
                {
                    this.degreesTableAdapter.Insert(txtEdtDegree.Text.ToString());
                    XtraMessageBox.Show("Η προσθήκη έγινε επιτυχώς!", "Πληροφορία", MessageBoxButtons.OK);
                    this.Close();

                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Η προσθήκη δεν έγινε => " + ex.Message);
                }
            }
            else
            {
                try
                {
                    DataRowView drv = (DataRowView)degreesBindingSource.Current;
                    drv.EndEdit();
                    this.degreesBindingSource.EndEdit();
                    this.degreesTableAdapter.Update(this.dataSet1);
                    
                    this.dataSet1.AcceptChanges();
                   

                    XtraMessageBox.Show("Η επεξεργασία έγινε επιτυχώς!", "Πληροφορία", MessageBoxButtons.OK);
                    this.Close();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Update Exception: " + ex.Message);
                }
            }
        }

        private void frmDegrees_Load(object sender, EventArgs e)
        {
            if (frmMain.editStudiesID != 0)
            {
                this.degreesTableAdapter.FillByID(this.dataSet1.Degrees, frmMain.editStudiesID);
            }
           

        }

        private void txtEdtDegree_Validated(object sender, EventArgs e)
        {
            var edit = sender as TextEdit;
            dxErrorProvider1.SetError(edit, null);
        }

        private void txtEdtDegree_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            if (string.IsNullOrWhiteSpace(edit.Text.ToString()))
            {
                dxErrorProvider1.SetError(edit, "O βαθμός δεν πρέπει να είναι κενός", ErrorType.Critical);
                e.Cancel = true;                
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}