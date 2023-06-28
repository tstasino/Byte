namespace ByteComputer.Forms
{
    partial class frmAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEdit));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnEdtCV = new DevExpress.XtraEditors.ButtonEdit();
            this.docsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ByteComputer.Data.DataSet1();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.dateInterview = new System.Windows.Forms.DateTimePicker();
            this.chkAccepted = new System.Windows.Forms.CheckBox();
            this.cmbDegree = new System.Windows.Forms.ComboBox();
            this.degreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEdtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtMobile = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtEmail = new DevExpress.XtraEditors.TextEdit();
            this.txtEdtLastName = new DevExpress.XtraEditors.TextEdit();
            this.candidatesTableAdapter = new ByteComputer.Data.DataSet1TableAdapters.CandidatesTableAdapter();
            this.degreesTableAdapter = new ByteComputer.Data.DataSet1TableAdapters.DegreesTableAdapter();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.docsTableAdapter = new ByteComputer.Data.DataSet1TableAdapters.docsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdtCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnEdtCV);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.dateCreated);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.dateInterview);
            this.groupControl1.Controls.Add(this.chkAccepted);
            this.groupControl1.Controls.Add(this.cmbDegree);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtEdtFirstName);
            this.groupControl1.Controls.Add(this.txtEdtMobile);
            this.groupControl1.Controls.Add(this.txtEdtEmail);
            this.groupControl1.Controls.Add(this.txtEdtLastName);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(418, 397);
            this.groupControl1.TabIndex = 0;
            // 
            // btnEdtCV
            // 
            this.btnEdtCV.CausesValidation = false;
            this.btnEdtCV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.docsBindingSource, "Doc", true));
            this.btnEdtCV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.docsBindingSource, "DocName", true));
            this.btnEdtCV.Location = new System.Drawing.Point(130, 244);
            this.btnEdtCV.Name = "btnEdtCV";
            this.btnEdtCV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdtCV.Size = new System.Drawing.Size(198, 20);
            this.btnEdtCV.TabIndex = 11;
            this.btnEdtCV.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            this.btnEdtCV.EditValueChanged += new System.EventHandler(this.btnEdtCV_EditValueChanged);
            // 
            // docsBindingSource
            // 
            this.docsBindingSource.DataMember = "docs";
            this.docsBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(228, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Ακύρωση";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(44, 314);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 36);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Αποθήκευση και Κλείσιμο";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dateCreated
            // 
            this.dateCreated.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.candidatesBindingSource, "dateCreated", true));
            this.dateCreated.Location = new System.Drawing.Point(130, 269);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(198, 21);
            this.dateCreated.TabIndex = 8;
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.dataSet1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(44, 269);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 6;
            this.labelControl9.Text = "Date Created";
            // 
            // dateInterview
            // 
            this.dateInterview.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.candidatesBindingSource, "InterviewDate", true));
            this.dateInterview.Location = new System.Drawing.Point(130, 196);
            this.dateInterview.Name = "dateInterview";
            this.dateInterview.ShowCheckBox = true;
            this.dateInterview.Size = new System.Drawing.Size(198, 21);
            this.dateInterview.TabIndex = 5;
            this.dateInterview.ValueChanged += new System.EventHandler(this.dateInterview_ValueChanged);
            // 
            // chkAccepted
            // 
            this.chkAccepted.AutoSize = true;
            this.chkAccepted.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.candidatesBindingSource, "Accepted", true));
            this.chkAccepted.Location = new System.Drawing.Point(130, 223);
            this.chkAccepted.Name = "chkAccepted";
            this.chkAccepted.Size = new System.Drawing.Size(15, 14);
            this.chkAccepted.TabIndex = 6;
            this.chkAccepted.UseVisualStyleBackColor = true;
            this.chkAccepted.CheckedChanged += new System.EventHandler(this.chkAccepted_CheckedChanged);
            // 
            // cmbDegree
            // 
            this.cmbDegree.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.candidatesBindingSource, "Degree", true));
            this.cmbDegree.DataSource = this.degreesBindingSource;
            this.cmbDegree.DisplayMember = "Description";
            this.cmbDegree.FormattingEnabled = true;
            this.cmbDegree.Location = new System.Drawing.Point(130, 169);
            this.cmbDegree.Name = "cmbDegree";
            this.cmbDegree.Size = new System.Drawing.Size(198, 21);
            this.cmbDegree.TabIndex = 4;
            this.cmbDegree.ValueMember = "Id";
            this.cmbDegree.SelectedIndexChanged += new System.EventHandler(this.cmbDegree_SelectedIndexChanged);
            // 
            // degreesBindingSource
            // 
            this.degreesBindingSource.DataMember = "Degrees";
            this.degreesBindingSource.DataSource = this.dataSet1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(44, 93);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(51, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "First Name";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(44, 250);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(13, 13);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "CV";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(44, 223);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(45, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Accepted";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(44, 196);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(72, 13);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Interview Date";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(44, 172);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "Degree";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(44, 145);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(30, 13);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Mobile";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(44, 119);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Email";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(44, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Last Name";
            // 
            // txtEdtFirstName
            // 
            this.txtEdtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.candidatesBindingSource, "FirstName", true));
            this.txtEdtFirstName.Location = new System.Drawing.Point(130, 90);
            this.txtEdtFirstName.Name = "txtEdtFirstName";
            this.txtEdtFirstName.Size = new System.Drawing.Size(198, 20);
            this.txtEdtFirstName.TabIndex = 1;
            this.txtEdtFirstName.EditValueChanged += new System.EventHandler(this.txtEdtFirstName_EditValueChanged);
            this.txtEdtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdtFirstName_Validating);
            this.txtEdtFirstName.Validated += new System.EventHandler(this.txtEdtFirstName_Validated);
            // 
            // txtEdtMobile
            // 
            this.txtEdtMobile.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.candidatesBindingSource, "Mobile", true));
            this.txtEdtMobile.Location = new System.Drawing.Point(130, 142);
            this.txtEdtMobile.Name = "txtEdtMobile";
            this.txtEdtMobile.Size = new System.Drawing.Size(198, 20);
            this.txtEdtMobile.TabIndex = 3;
            this.txtEdtMobile.EditValueChanged += new System.EventHandler(this.txtEdtMobile_EditValueChanged);
            this.txtEdtMobile.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdtMobile_Validating);
            this.txtEdtMobile.Validated += new System.EventHandler(this.txtEdtMobile_Validated);
            // 
            // txtEdtEmail
            // 
            this.txtEdtEmail.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.candidatesBindingSource, "email", true));
            this.txtEdtEmail.Location = new System.Drawing.Point(130, 116);
            this.txtEdtEmail.Name = "txtEdtEmail";
            this.txtEdtEmail.Size = new System.Drawing.Size(198, 20);
            this.txtEdtEmail.TabIndex = 2;
            this.txtEdtEmail.EditValueChanged += new System.EventHandler(this.txtEdtEmail_EditValueChanged);
            this.txtEdtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdtEmail_Validating);
            this.txtEdtEmail.Validated += new System.EventHandler(this.txtEdtEmail_Validated);
            // 
            // txtEdtLastName
            // 
            this.txtEdtLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.candidatesBindingSource, "LastName", true));
            this.txtEdtLastName.Location = new System.Drawing.Point(130, 64);
            this.txtEdtLastName.Name = "txtEdtLastName";
            this.txtEdtLastName.Size = new System.Drawing.Size(198, 20);
            this.txtEdtLastName.TabIndex = 0;
            this.txtEdtLastName.EditValueChanged += new System.EventHandler(this.txtEdtLastName_EditValueChanged);
            this.txtEdtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdtLastName_Validating);
            this.txtEdtLastName.Validated += new System.EventHandler(this.txtEdtLastName_Validated);
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // degreesTableAdapter
            // 
            this.degreesTableAdapter.ClearBeforeFill = true;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // docsTableAdapter
            // 
            this.docsTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 397);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Προσθήκη / Επεξεργασία Υποψηφίου";
            this.Load += new System.EventHandler(this.frmAddEdit_Load);
            this.Shown += new System.EventHandler(this.frmAddEdit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdtCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker dateCreated;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.DateTimePicker dateInterview;
        private System.Windows.Forms.CheckBox chkAccepted;
        private System.Windows.Forms.ComboBox cmbDegree;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEdtFirstName;
        private DevExpress.XtraEditors.TextEdit txtEdtMobile;
        private DevExpress.XtraEditors.TextEdit txtEdtEmail;
        private DevExpress.XtraEditors.TextEdit txtEdtLastName;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private Data.DataSet1TableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private System.Windows.Forms.BindingSource degreesBindingSource;
        private Data.DataSet1TableAdapters.DegreesTableAdapter degreesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource docsBindingSource;
        private Data.DataSet1TableAdapters.docsTableAdapter docsTableAdapter;
        private DevExpress.XtraEditors.ButtonEdit btnEdtCV;
    }
}