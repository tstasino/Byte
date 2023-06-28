namespace ByteComputer.Forms
{
    partial class frmDegrees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDegrees));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtEdtDegree = new DevExpress.XtraEditors.TextEdit();
            this.degreesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ByteComputer.Data.DataSet1();
            this.degreesTableAdapter = new ByteComputer.Data.DataSet1TableAdapters.DegreesTableAdapter();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtDegree.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnCancel);
            this.groupControl1.Controls.Add(this.btnSave);
            this.groupControl1.Controls.Add(this.txtEdtDegree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(367, 185);
            this.groupControl1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(80, 61);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(35, 13);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Βαθμός";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.ImageOptions.Image")));
            this.btnCancel.Location = new System.Drawing.Point(223, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Ακύρωση";
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(39, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(178, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Αποθήκευση και Κλείσιμο";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEdtDegree
            // 
            this.txtEdtDegree.CausesValidation = false;
            this.txtEdtDegree.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.degreesBindingSource, "Description", true));
            this.txtEdtDegree.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.degreesBindingSource, "Description", true));
            this.txtEdtDegree.Location = new System.Drawing.Point(141, 58);
            this.txtEdtDegree.Name = "txtEdtDegree";
            this.txtEdtDegree.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtEdtDegree.Size = new System.Drawing.Size(182, 20);
            this.txtEdtDegree.TabIndex = 0;
            this.txtEdtDegree.Validating += new System.ComponentModel.CancelEventHandler(this.txtEdtDegree_Validating);
            this.txtEdtDegree.Validated += new System.EventHandler(this.txtEdtDegree_Validated);
            // 
            // degreesBindingSource
            // 
            this.degreesBindingSource.DataMember = "Degrees";
            this.degreesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // degreesTableAdapter
            // 
            this.degreesTableAdapter.ClearBeforeFill = true;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // frmDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 185);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDegrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Σπουδές";
            this.Load += new System.EventHandler(this.frmDegrees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEdtDegree.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtEdtDegree;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource degreesBindingSource;
        private Data.DataSet1TableAdapters.DegreesTableAdapter degreesTableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}