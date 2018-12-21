namespace WindowsFormsApp1
{
    partial class Form1
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.knowledgeCheckDBDataSet = new WindowsFormsApp1.KnowledgeCheckDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subjectTableAdapter = new WindowsFormsApp1.KnowledgeCheckDBDataSetTableAdapters.SubjectTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKQuestionToSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new WindowsFormsApp1.KnowledgeCheckDBDataSetTableAdapters.QuestionTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fKAnswerToQuestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answerTableAdapter = new WindowsFormsApp1.KnowledgeCheckDBDataSetTableAdapters.AnswerTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fKAnswerToQuestionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKQuestionToSubjectBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.fKQuestionToSubjectBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKQuestionToSubjectBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKQuestionToSubjectBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fKAnswerToQuestionBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKQuestionToSubjectBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeCheckDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAnswerToQuestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAnswerToQuestionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAnswerToQuestionBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.knowledgeCheckDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // knowledgeCheckDBDataSet
            // 
            this.knowledgeCheckDBDataSet.DataSetName = "KnowledgeCheckDBDataSet";
            this.knowledgeCheckDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(68, 71);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(366, 185);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // subjectBindingSource
            // 
            this.subjectBindingSource.DataMember = "Subject";
            this.subjectBindingSource.DataSource = this.bindingSource1;
            // 
            // subjectTableAdapter
            // 
            this.subjectTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fKQuestionToSubjectBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(535, 71);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(685, 185);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Subject";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            // 
            // fKQuestionToSubjectBindingSource
            // 
            this.fKQuestionToSubjectBindingSource.DataMember = "FK_Question_ToSubject";
            this.fKQuestionToSubjectBindingSource.DataSource = this.subjectBindingSource;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.contentDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.validDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.fKAnswerToQuestionBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(79, 366);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(676, 71);
            this.dataGridView3.TabIndex = 2;
            this.dataGridView3.Visible = false;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Content";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // validDataGridViewTextBoxColumn
            // 
            this.validDataGridViewTextBoxColumn.DataPropertyName = "Valid";
            this.validDataGridViewTextBoxColumn.HeaderText = "Valid";
            this.validDataGridViewTextBoxColumn.Name = "validDataGridViewTextBoxColumn";
            // 
            // fKAnswerToQuestionBindingSource
            // 
            this.fKAnswerToQuestionBindingSource.DataMember = "FK_Answer_ToQuestion";
            this.fKAnswerToQuestionBindingSource.DataSource = this.fKQuestionToSubjectBindingSource;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKAnswerToQuestionBindingSource1, "Content", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.fKAnswerToQuestionBindingSource1, "Valid", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKAnswerToQuestionBindingSource1, "Valid", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.fKAnswerToQuestionBindingSource1, "Valid", true));
            this.comboBox1.DataSource = this.fKAnswerToQuestionBindingSource1;
            this.comboBox1.DisplayMember = "Content";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(535, 312);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(260, 24);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "Valid";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // fKAnswerToQuestionBindingSource1
            // 
            this.fKAnswerToQuestionBindingSource1.DataMember = "FK_Answer_ToQuestion";
            this.fKAnswerToQuestionBindingSource1.DataSource = this.fKQuestionToSubjectBindingSource;
            // 
            // subjectBindingSource1
            // 
            this.subjectBindingSource1.DataMember = "Subject";
            this.subjectBindingSource1.DataSource = this.bindingSource1;
            // 
            // fKQuestionToSubjectBindingSource4
            // 
            this.fKQuestionToSubjectBindingSource4.DataMember = "FK_Question_ToSubject";
            this.fKQuestionToSubjectBindingSource4.DataSource = this.subjectBindingSource;
            // 
            // fKQuestionToSubjectBindingSource1
            // 
            this.fKQuestionToSubjectBindingSource1.DataMember = "FK_Question_ToSubject";
            this.fKQuestionToSubjectBindingSource1.DataSource = this.subjectBindingSource;
            // 
            // fKQuestionToSubjectBindingSource2
            // 
            this.fKQuestionToSubjectBindingSource2.DataMember = "FK_Question_ToSubject";
            this.fKQuestionToSubjectBindingSource2.DataSource = this.subjectBindingSource;
            // 
            // fKQuestionToSubjectBindingSource3
            // 
            this.fKQuestionToSubjectBindingSource3.DataMember = "FK_Question_ToSubject";
            this.fKQuestionToSubjectBindingSource3.DataSource = this.subjectBindingSource1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(884, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "_________________";
            // 
            // fKAnswerToQuestionBindingSource2
            // 
            this.fKAnswerToQuestionBindingSource2.DataMember = "FK_Answer_ToQuestion";
            this.fKAnswerToQuestionBindingSource2.DataSource = this.fKQuestionToSubjectBindingSource;
            // 
            // fKQuestionToSubjectBindingSource5
            // 
            this.fKQuestionToSubjectBindingSource5.DataMember = "FK_Question_ToSubject";
            this.fKQuestionToSubjectBindingSource5.DataSource = this.subjectBindingSource1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Choose the knowledge area";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(546, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose the question";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Select the answer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fKQuestionToSubjectBindingSource, "Description", true));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.fKQuestionToSubjectBindingSource, "Id", true));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "KnowledgeCheckSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knowledgeCheckDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAnswerToQuestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAnswerToQuestionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKAnswerToQuestionBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKQuestionToSubjectBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private KnowledgeCheckDBDataSet knowledgeCheckDBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource subjectBindingSource;
        private KnowledgeCheckDBDataSetTableAdapters.SubjectTableAdapter subjectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fKQuestionToSubjectBindingSource;
        private KnowledgeCheckDBDataSetTableAdapters.QuestionTableAdapter questionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource fKAnswerToQuestionBindingSource;
        private KnowledgeCheckDBDataSetTableAdapters.AnswerTableAdapter answerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource subjectBindingSource1;
        private System.Windows.Forms.BindingSource fKQuestionToSubjectBindingSource1;
        private System.Windows.Forms.BindingSource fKQuestionToSubjectBindingSource2;
        private System.Windows.Forms.BindingSource fKQuestionToSubjectBindingSource3;
        private System.Windows.Forms.BindingSource fKQuestionToSubjectBindingSource4;
        private System.Windows.Forms.BindingSource fKAnswerToQuestionBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource fKQuestionToSubjectBindingSource5;
        private System.Windows.Forms.BindingSource fKAnswerToQuestionBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

