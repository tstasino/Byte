using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraEditors.TextEditController.IME;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ByteComputer.Forms
{
    public partial class frmAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public frmAddEdit()
        {
            InitializeComponent();
        }

        private void frmAddEdit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.docs' table. You can move, or remove it, as needed.
            //this.docsTableAdapter.Fill(this.dataSet1.docs);
            // TODO: This line of code loads data into the 'dataSet1.Degrees' table. You can move, or remove it, as needed.
            this.degreesTableAdapter.Fill(this.dataSet1.Degrees);
          

            if (frmMain.editUserID == 0) //add new candidate
            {
                cmbDegree.SelectedItem = null;
                dateCreated.Enabled = false;
            }
            else
            {
                isFormChanged = false;
                this.candidatesTableAdapter.FillByID(this.dataSet1.Candidates,frmMain.editUserID);
                this.docsTableAdapter.FillByCandidate(this.dataSet1.docs, frmMain.editUserID);
            }

        }
        public string cvfilePath;
        public string cvfileName;
        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                (sender as ButtonEdit).Text = Path.GetFileName(ofd.FileName);
                (sender as ButtonEdit).Tag = ofd.FileName;
               // if (frmMain.editUserID !=0) 
               //         (sender as ButtonEdit).EditValue = ConvertToByteArray(ofd.FileName);
               
               
                
            }
               
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ValidateChildren();
            if (btnEdtCV.EditValue == null || btnEdtCV.EditValue.ToString().Trim() == "")
            {
                dxErrorProvider1.SetError(btnEdtCV, "Το CV είναι υποχρεωτικό", ErrorType.Critical);
                return;
            }
            else dxErrorProvider1.SetError(btnEdtCV, null);

            if (dxErrorProvider1.HasErrors) return;
           
            if (frmMain.editUserID == 0)
            {
                int? degree = null;
                if (!(cmbDegree.SelectedIndex == -1))
                    degree = int.Parse(cmbDegree.SelectedValue.ToString());

                DateTime? date = null;
                if (dateInterview.Checked)
                    date = dateInterview.Value;

                Boolean accepted = false;
                if (chkAccepted.Checked)
                    accepted = true;

                var fileByteArray = ConvertToByteArray(btnEdtCV.Tag.ToString());
                DateTime dateOfCreation = DateTime.Now;
                try
                {
                    docsTableAdapter.Insert(fileByteArray, btnEdtCV.Text);
                    int? docId = docsTableAdapter.MaxId();
                    candidatesTableAdapter.Insert(txtEdtLastName.Text.Trim(),
                                                txtEdtFirstName.Text.Trim(),
                                                txtEdtEmail.Text.Trim(),
                                                long.Parse(txtEdtMobile.Text.Trim().ToString()),
                                                degree,
                                                date,
                                                accepted,
                                                docId,
                                                dateOfCreation
                                                ); 
                    
                    XtraMessageBox.Show("Η προσθήκη έγινε επιτυχώς!", "Πληροφορία", MessageBoxButtons.OK);
                    this.Close();

                } catch (Exception ex)
                {
                    XtraMessageBox.Show("Error inserting Data => " + ex.Message);
                }
            }
            else
            {
                if (isFormChanged)
                {
                    try
                    {
                        if (isCvChanged)
                            btnEdtCV.EditValue = ConvertToByteArray(btnEdtCV.Tag.ToString());
                        docsBindingSource.EndEdit();
                        docsTableAdapter.Update(this.dataSet1);
                        DataRowView drv = (DataRowView)candidatesBindingSource.Current;
                        drv.EndEdit();
                        candidatesBindingSource.EndEdit();
                        candidatesTableAdapter.Update(this.dataSet1);
                        dataSet1.AcceptChanges();

                        XtraMessageBox.Show("Η επεξεργασία έγινε επιτυχώς!", "Πληροφορία", MessageBoxButtons.OK);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Update Exception: " + ex.Message);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Η φόρμα δεν είχε αλλαγές!", "Πληροφορία", MessageBoxButtons.OK);
                    this.Close();

                }

            }
        }
        public static byte[] ConvertToByteArray(string filePath)
        {
            byte[] fileByteArray = File.ReadAllBytes(filePath);
            return fileByteArray;
        }

        public bool isFormChanged = false;
        private void txtEdtLastName_EditValueChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }

        private void txtEdtFirstName_EditValueChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }

        private void txtEdtEmail_EditValueChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }

        private void txtEdtMobile_EditValueChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }

        private void cmbDegree_SelectedIndexChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }

        private void dateInterview_ValueChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }

        private void chkAccepted_CheckedChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
        }
        public bool isCvChanged = false;
        private void btnEdtCV_EditValueChanged(object sender, EventArgs e)
        {
            isFormChanged = true;
            isCvChanged = true;
        }

        private void frmAddEdit_Shown(object sender, EventArgs e)
        {
            isCvChanged = false; 
            isFormChanged = false;
            if (!string.IsNullOrEmpty(cvfileName))
                    btnEdtCV.Text = cvfileName;
           
        }

        private void txtEdtLastName_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            if (string.IsNullOrWhiteSpace(txtEdtLastName.Text.ToString()))
            {
                dxErrorProvider1.SetError(edit, "Το επώνυμο δεν πρέπει να είναι κενό", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void txtEdtLastName_Validated(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(txtEdtLastName, null);
        }

        private void txtEdtFirstName_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            if (string.IsNullOrWhiteSpace(txtEdtFirstName.Text.ToString()))
            {
                dxErrorProvider1.SetError(edit, "Το όνομα δεν πρέπει να είναι κενό", ErrorType.Critical);
                e.Cancel = true;
            }
        }

        private void txtEdtFirstName_Validated(object sender, EventArgs e)
        {
            dxErrorProvider1.SetError(txtEdtFirstName, null);
        }

        private void txtEdtEmail_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            Regex regEmail = new Regex(@"^(([^<>()[\]\\.,;:\s@\""]+"
                             + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
                             + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
                             + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
                             + @"[a-zA-Z]{2,}))$",
                             RegexOptions.Compiled);

            if (!regEmail.IsMatch(txtEdtEmail.Text) || string.IsNullOrEmpty(txtEdtEmail.Text))
            {
                dxErrorProvider1.SetError(edit, "Παρακαλώ εισάγετε ενα έγκυρο Email Address.");
                e.Cancel = true;
            }
        }

        private void txtEdtEmail_Validated(object sender, EventArgs e)
        {
            var edit = sender as TextEdit;
            dxErrorProvider1.SetError((Control)edit, null);
        }

        private void txtEdtMobile_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as TextEdit;

            Regex regMobile = new Regex(@"(?<!\d)\d{10}(?!\d)", RegexOptions.Compiled);
            if (!regMobile.IsMatch(txtEdtMobile.Text) || string.IsNullOrEmpty(txtEdtMobile.Text))
            {
                dxErrorProvider1.SetError(edit, "Παρακαλώ εισάγετε ενα έγκυρο κινητό.");
                e.Cancel = true;
            }
        }

        private void txtEdtMobile_Validated(object sender, EventArgs e)
        {
            var edit = sender as TextEdit;
            dxErrorProvider1.SetError((Control)edit, null);
        }

        private void btnEdtCV_Validating(object sender, CancelEventArgs e)
        {
            var edit = sender as  ButtonEdit;

            if (btnEdtCV.EditValue == null || btnEdtCV.EditValue.ToString().Trim() == "" )
            {
                dxErrorProvider1.SetError(edit, "Το CV είναι υποχρεωτικό", ErrorType.Critical);
                e.Cancel = true;
            }
            else
            {
                string s = dxErrorProvider1.GetError(edit);
            }
            
        }

        private void btnEdtCV_Validated(object sender, EventArgs e)
        {
            var edit = sender as ButtonEdit;
            dxErrorProvider1.SetError((Control)edit, null);
        }

       
    }
}