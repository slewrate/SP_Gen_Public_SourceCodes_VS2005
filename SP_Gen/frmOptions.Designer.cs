﻿namespace SP_Gen
{
    partial class frmOptions
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tcOptions = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.chkGenerateWrapperClass = new System.Windows.Forms.CheckBox();
            this.tpSQL = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbDelete = new System.Windows.Forms.CheckBox();
            this.cbSelectAll = new System.Windows.Forms.CheckBox();
            this.cbUpdate = new System.Windows.Forms.CheckBox();
            this.cbInsert = new System.Windows.Forms.CheckBox();
            this.cbSelectRow = new System.Windows.Forms.CheckBox();
            this.chkAutosaveSqlScript = new System.Windows.Forms.CheckBox();
            this.chkNullParamDefaultValues = new System.Windows.Forms.CheckBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.lblPrefix = new System.Windows.Forms.Label();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.lblAuthorName = new System.Windows.Forms.Label();
            this.tpWrapperClass = new System.Windows.Forms.TabPage();
            this.chkAutosaveWrapperClass = new System.Windows.Forms.CheckBox();
            this.chkStaticMethods = new System.Windows.Forms.CheckBox();
            this.txtNamespace = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.variables = new SP_Gen.Variables();
            this.appvariablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.app_variablesTableAdapter = new SP_Gen.VariablesTableAdapters.app_variablesTableAdapter();
            this.tcOptions.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            this.tpSQL.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpWrapperClass.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appvariablesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(367, 247);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(286, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tcOptions
            // 
            this.tcOptions.Controls.Add(this.tpGeneral);
            this.tcOptions.Controls.Add(this.tpSQL);
            this.tcOptions.Controls.Add(this.tpWrapperClass);
            this.tcOptions.Controls.Add(this.tabPage1);
            this.tcOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcOptions.Location = new System.Drawing.Point(0, 0);
            this.tcOptions.Name = "tcOptions";
            this.tcOptions.SelectedIndex = 0;
            this.tcOptions.Size = new System.Drawing.Size(447, 245);
            this.tcOptions.TabIndex = 6;
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.chkGenerateWrapperClass);
            this.tpGeneral.Location = new System.Drawing.Point(4, 22);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(439, 219);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "General";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // chkGenerateWrapperClass
            // 
            this.chkGenerateWrapperClass.AutoSize = true;
            this.chkGenerateWrapperClass.Location = new System.Drawing.Point(18, 16);
            this.chkGenerateWrapperClass.Name = "chkGenerateWrapperClass";
            this.chkGenerateWrapperClass.Size = new System.Drawing.Size(142, 17);
            this.chkGenerateWrapperClass.TabIndex = 7;
            this.chkGenerateWrapperClass.Text = "Generate Wrapper Class";
            this.chkGenerateWrapperClass.UseVisualStyleBackColor = true;
            // 
            // tpSQL
            // 
            this.tpSQL.Controls.Add(this.groupBox1);
            this.tpSQL.Controls.Add(this.chkAutosaveSqlScript);
            this.tpSQL.Controls.Add(this.chkNullParamDefaultValues);
            this.tpSQL.Controls.Add(this.txtPrefix);
            this.tpSQL.Controls.Add(this.lblPrefix);
            this.tpSQL.Controls.Add(this.txtAuthorName);
            this.tpSQL.Controls.Add(this.lblAuthorName);
            this.tpSQL.Location = new System.Drawing.Point(4, 22);
            this.tpSQL.Name = "tpSQL";
            this.tpSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tpSQL.Size = new System.Drawing.Size(439, 219);
            this.tpSQL.TabIndex = 1;
            this.tpSQL.Text = "SQL Script Generation";
            this.tpSQL.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbDelete);
            this.groupBox1.Controls.Add(this.cbSelectAll);
            this.groupBox1.Controls.Add(this.cbUpdate);
            this.groupBox1.Controls.Add(this.cbInsert);
            this.groupBox1.Controls.Add(this.cbSelectRow);
            this.groupBox1.Location = new System.Drawing.Point(123, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 88);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Procedures:";
            // 
            // cbDelete
            // 
            this.cbDelete.AutoSize = true;
            this.cbDelete.Location = new System.Drawing.Point(117, 43);
            this.cbDelete.Name = "cbDelete";
            this.cbDelete.Size = new System.Drawing.Size(57, 17);
            this.cbDelete.TabIndex = 27;
            this.cbDelete.Text = "Delete";
            this.cbDelete.UseVisualStyleBackColor = true;
            // 
            // cbSelectAll
            // 
            this.cbSelectAll.AutoSize = true;
            this.cbSelectAll.Location = new System.Drawing.Point(11, 18);
            this.cbSelectAll.Name = "cbSelectAll";
            this.cbSelectAll.Size = new System.Drawing.Size(70, 17);
            this.cbSelectAll.TabIndex = 23;
            this.cbSelectAll.Text = "Select All";
            this.cbSelectAll.UseVisualStyleBackColor = true;
            // 
            // cbUpdate
            // 
            this.cbUpdate.AutoSize = true;
            this.cbUpdate.Location = new System.Drawing.Point(117, 18);
            this.cbUpdate.Name = "cbUpdate";
            this.cbUpdate.Size = new System.Drawing.Size(61, 17);
            this.cbUpdate.TabIndex = 26;
            this.cbUpdate.Text = "Update";
            this.cbUpdate.UseVisualStyleBackColor = true;
            // 
            // cbInsert
            // 
            this.cbInsert.AutoSize = true;
            this.cbInsert.Location = new System.Drawing.Point(11, 66);
            this.cbInsert.Name = "cbInsert";
            this.cbInsert.Size = new System.Drawing.Size(52, 17);
            this.cbInsert.TabIndex = 25;
            this.cbInsert.Text = "Insert";
            this.cbInsert.UseVisualStyleBackColor = true;
            // 
            // cbSelectRow
            // 
            this.cbSelectRow.AutoSize = true;
            this.cbSelectRow.Location = new System.Drawing.Point(11, 43);
            this.cbSelectRow.Name = "cbSelectRow";
            this.cbSelectRow.Size = new System.Drawing.Size(81, 17);
            this.cbSelectRow.TabIndex = 24;
            this.cbSelectRow.Text = "Select Row";
            this.cbSelectRow.UseVisualStyleBackColor = true;
            // 
            // chkAutosaveSqlScript
            // 
            this.chkAutosaveSqlScript.AutoSize = true;
            this.chkAutosaveSqlScript.Location = new System.Drawing.Point(123, 161);
            this.chkAutosaveSqlScript.Name = "chkAutosaveSqlScript";
            this.chkAutosaveSqlScript.Size = new System.Drawing.Size(125, 17);
            this.chkAutosaveSqlScript.TabIndex = 17;
            this.chkAutosaveSqlScript.Text = "Autosave SQL Script";
            this.chkAutosaveSqlScript.UseVisualStyleBackColor = true;
            // 
            // chkNullParamDefaultValues
            // 
            this.chkNullParamDefaultValues.AutoSize = true;
            this.chkNullParamDefaultValues.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkNullParamDefaultValues.Location = new System.Drawing.Point(123, 184);
            this.chkNullParamDefaultValues.Name = "chkNullParamDefaultValues";
            this.chkNullParamDefaultValues.Size = new System.Drawing.Size(296, 30);
            this.chkNullParamDefaultValues.TabIndex = 16;
            this.chkNullParamDefaultValues.Text = "Pass \"NULL\" as default parameter values for fields which\r\nallow nulls";
            this.chkNullParamDefaultValues.UseVisualStyleBackColor = true;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(123, 39);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(185, 20);
            this.txtPrefix.TabIndex = 15;
            this.txtPrefix.Text = "sp_";
            // 
            // lblPrefix
            // 
            this.lblPrefix.AutoSize = true;
            this.lblPrefix.Location = new System.Drawing.Point(81, 42);
            this.lblPrefix.Name = "lblPrefix";
            this.lblPrefix.Size = new System.Drawing.Size(36, 13);
            this.lblPrefix.TabIndex = 14;
            this.lblPrefix.Text = "Perfix:";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(123, 10);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(185, 20);
            this.txtAuthorName.TabIndex = 13;
            // 
            // lblAuthorName
            // 
            this.lblAuthorName.AutoSize = true;
            this.lblAuthorName.Location = new System.Drawing.Point(45, 13);
            this.lblAuthorName.Name = "lblAuthorName";
            this.lblAuthorName.Size = new System.Drawing.Size(72, 13);
            this.lblAuthorName.TabIndex = 12;
            this.lblAuthorName.Text = "Author Name:";
            // 
            // tpWrapperClass
            // 
            this.tpWrapperClass.Controls.Add(this.chkAutosaveWrapperClass);
            this.tpWrapperClass.Controls.Add(this.chkStaticMethods);
            this.tpWrapperClass.Controls.Add(this.txtNamespace);
            this.tpWrapperClass.Controls.Add(this.lblNamespace);
            this.tpWrapperClass.Location = new System.Drawing.Point(4, 22);
            this.tpWrapperClass.Name = "tpWrapperClass";
            this.tpWrapperClass.Padding = new System.Windows.Forms.Padding(3);
            this.tpWrapperClass.Size = new System.Drawing.Size(439, 219);
            this.tpWrapperClass.TabIndex = 2;
            this.tpWrapperClass.Text = "Wrapper Class";
            this.tpWrapperClass.UseVisualStyleBackColor = true;
            // 
            // chkAutosaveWrapperClass
            // 
            this.chkAutosaveWrapperClass.AutoSize = true;
            this.chkAutosaveWrapperClass.Location = new System.Drawing.Point(95, 69);
            this.chkAutosaveWrapperClass.Name = "chkAutosaveWrapperClass";
            this.chkAutosaveWrapperClass.Size = new System.Drawing.Size(143, 17);
            this.chkAutosaveWrapperClass.TabIndex = 3;
            this.chkAutosaveWrapperClass.Text = "Autosave Wrapper Class";
            this.chkAutosaveWrapperClass.UseVisualStyleBackColor = true;
            // 
            // chkStaticMethods
            // 
            this.chkStaticMethods.AutoSize = true;
            this.chkStaticMethods.Location = new System.Drawing.Point(95, 45);
            this.chkStaticMethods.Name = "chkStaticMethods";
            this.chkStaticMethods.Size = new System.Drawing.Size(144, 17);
            this.chkStaticMethods.TabIndex = 2;
            this.chkStaticMethods.Text = "Generate Static Methods";
            this.chkStaticMethods.UseVisualStyleBackColor = true;
            // 
            // txtNamespace
            // 
            this.txtNamespace.Location = new System.Drawing.Point(95, 18);
            this.txtNamespace.Name = "txtNamespace";
            this.txtNamespace.Size = new System.Drawing.Size(149, 20);
            this.txtNamespace.TabIndex = 1;
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(21, 18);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(67, 13);
            this.lblNamespace.TabIndex = 0;
            this.lblNamespace.Text = "Namespace:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(439, 219);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(18, 40);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 134);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Business Object";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(178, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datatype:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Elements:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(178, 85);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Label";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "TextBox";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(178, 147);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // variables
            // 
            this.variables.DataSetName = "Variables";
            this.variables.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appvariablesBindingSource
            // 
            this.appvariablesBindingSource.DataMember = "app_variables";
            this.appvariablesBindingSource.DataSource = this.variables;
            // 
            // app_variablesTableAdapter
            // 
            this.app_variablesTableAdapter.ClearBeforeFill = true;
            // 
            // frmOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(447, 275);
            this.ControlBox = false;
            this.Controls.Add(this.tcOptions);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOptions";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.tcOptions.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            this.tpGeneral.PerformLayout();
            this.tpSQL.ResumeLayout(false);
            this.tpSQL.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpWrapperClass.ResumeLayout(false);
            this.tpWrapperClass.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.variables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appvariablesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tcOptions;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.CheckBox chkGenerateWrapperClass;
        private System.Windows.Forms.TabPage tpSQL;
        private System.Windows.Forms.CheckBox chkNullParamDefaultValues;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label lblPrefix;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label lblAuthorName;
        private System.Windows.Forms.TabPage tpWrapperClass;
        private System.Windows.Forms.TextBox txtNamespace;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.CheckBox chkStaticMethods;
        private System.Windows.Forms.CheckBox chkAutosaveSqlScript;
        private System.Windows.Forms.CheckBox chkAutosaveWrapperClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbDelete;
        private System.Windows.Forms.CheckBox cbSelectAll;
        private System.Windows.Forms.CheckBox cbUpdate;
        private System.Windows.Forms.CheckBox cbInsert;
        private System.Windows.Forms.CheckBox cbSelectRow;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private Variables variables;
        private System.Windows.Forms.BindingSource appvariablesBindingSource;
        private VariablesTableAdapters.app_variablesTableAdapter app_variablesTableAdapter;
    }
}