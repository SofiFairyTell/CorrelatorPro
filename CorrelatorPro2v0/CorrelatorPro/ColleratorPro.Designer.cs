
namespace CorrelatorPro
{
    partial class frmCorrellatorPro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrellatorPro));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbLineReg = new System.Windows.Forms.TabControl();
            this.tbPageTask = new System.Windows.Forms.TabPage();
            this.grParam = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBoxTask = new System.Windows.Forms.RichTextBox();
            this.tbPageLine = new System.Windows.Forms.TabPage();
            this.textboxAnswer = new System.Windows.Forms.TextBox();
            this.ChartOfFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.btLineRegCount = new System.Windows.Forms.Button();
            this.tbPageSq = new System.Windows.Forms.TabPage();
            this.qdrAnswerBox = new System.Windows.Forms.TextBox();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.ChartOfFunctionSQR = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSqrRegCount = new System.Windows.Forms.Button();
            this.tbLineReg.SuspendLayout();
            this.tbPageTask.SuspendLayout();
            this.grParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.tbPageLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
            this.tbPageSq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunctionSQR)).BeginInit();
            this.SuspendLayout();
            // 
            // tbLineReg
            // 
            this.tbLineReg.Controls.Add(this.tbPageTask);
            this.tbLineReg.Controls.Add(this.tbPageLine);
            this.tbLineReg.Controls.Add(this.tbPageSq);
            this.tbLineReg.Location = new System.Drawing.Point(13, 13);
            this.tbLineReg.Name = "tbLineReg";
            this.tbLineReg.SelectedIndex = 0;
            this.tbLineReg.Size = new System.Drawing.Size(775, 452);
            this.tbLineReg.TabIndex = 0;
            // 
            // tbPageTask
            // 
            this.tbPageTask.Controls.Add(this.grParam);
            this.tbPageTask.Controls.Add(this.richTextBoxTask);
            this.tbPageTask.Location = new System.Drawing.Point(4, 23);
            this.tbPageTask.Name = "tbPageTask";
            this.tbPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageTask.Size = new System.Drawing.Size(767, 425);
            this.tbPageTask.TabIndex = 2;
            this.tbPageTask.Text = "Задание";
            this.tbPageTask.UseVisualStyleBackColor = true;
            // 
            // grParam
            // 
            this.grParam.Controls.Add(this.numericUpDown1);
            this.grParam.Controls.Add(this.lbCount);
            this.grParam.Controls.Add(this.label1);
            this.grParam.Controls.Add(this.dgwData);
            this.grParam.Location = new System.Drawing.Point(17, 141);
            this.grParam.Name = "grParam";
            this.grParam.Size = new System.Drawing.Size(744, 206);
            this.grParam.TabIndex = 3;
            this.grParam.TabStop = false;
            this.grParam.Text = "Параметры";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(138, 48);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbCount.Location = new System.Drawing.Point(6, 50);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(126, 14);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "Количество данных";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(0, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = " Введите показатели:";
            // 
            // dgwData
            // 
            this.dgwData.AllowUserToAddRows = false;
            this.dgwData.AllowUserToDeleteRows = false;
            this.dgwData.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgwData.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgwData.Location = new System.Drawing.Point(6, 99);
            this.dgwData.Name = "dgwData";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dgwData.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwData.RowTemplate.Height = 25;
            this.dgwData.Size = new System.Drawing.Size(732, 101);
            this.dgwData.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // richTextBoxTask
            // 
            this.richTextBoxTask.Enabled = false;
            this.richTextBoxTask.Location = new System.Drawing.Point(17, 17);
            this.richTextBoxTask.Name = "richTextBoxTask";
            this.richTextBoxTask.Size = new System.Drawing.Size(744, 118);
            this.richTextBoxTask.TabIndex = 0;
            this.richTextBoxTask.Text = resources.GetString("richTextBoxTask.Text");
            this.richTextBoxTask.TextChanged += new System.EventHandler(this.richTextBoxTask_TextChanged);
            // 
            // tbPageLine
            // 
            this.tbPageLine.BackColor = System.Drawing.Color.Transparent;
            this.tbPageLine.Controls.Add(this.textboxAnswer);
            this.tbPageLine.Controls.Add(this.ChartOfFunction);
            this.tbPageLine.Controls.Add(this.dgvTemp);
            this.tbPageLine.Controls.Add(this.btLineRegCount);
            this.tbPageLine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbPageLine.Location = new System.Drawing.Point(4, 23);
            this.tbPageLine.Name = "tbPageLine";
            this.tbPageLine.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageLine.Size = new System.Drawing.Size(767, 425);
            this.tbPageLine.TabIndex = 0;
            this.tbPageLine.Text = "Линейная регрессия";
            // 
            // textboxAnswer
            // 
            this.textboxAnswer.Location = new System.Drawing.Point(7, 336);
            this.textboxAnswer.Multiline = true;
            this.textboxAnswer.Name = "textboxAnswer";
            this.textboxAnswer.Size = new System.Drawing.Size(754, 83);
            this.textboxAnswer.TabIndex = 3;
            // 
            // ChartOfFunction
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartOfFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartOfFunction.Legends.Add(legend1);
            this.ChartOfFunction.Location = new System.Drawing.Point(319, 6);
            this.ChartOfFunction.Name = "ChartOfFunction";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartOfFunction.Series.Add(series1);
            this.ChartOfFunction.Size = new System.Drawing.Size(442, 324);
            this.ChartOfFunction.TabIndex = 2;
            this.ChartOfFunction.Text = "chart1";
            // 
            // dgvTemp
            // 
            this.dgvTemp.AllowUserToAddRows = false;
            this.dgvTemp.AllowUserToDeleteRows = false;
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.GridColor = System.Drawing.SystemColors.Control;
            this.dgvTemp.Location = new System.Drawing.Point(7, 46);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.RowTemplate.Height = 25;
            this.dgvTemp.Size = new System.Drawing.Size(297, 243);
            this.dgvTemp.TabIndex = 1;
            // 
            // btLineRegCount
            // 
            this.btLineRegCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btLineRegCount.Location = new System.Drawing.Point(7, 17);
            this.btLineRegCount.Name = "btLineRegCount";
            this.btLineRegCount.Size = new System.Drawing.Size(193, 23);
            this.btLineRegCount.TabIndex = 0;
            this.btLineRegCount.Text = "Рассчитать";
            this.btLineRegCount.UseVisualStyleBackColor = true;
            this.btLineRegCount.Click += new System.EventHandler(this.btLineRegCount_Click);
            // 
            // tbPageSq
            // 
            this.tbPageSq.Controls.Add(this.qdrAnswerBox);
            this.tbPageSq.Controls.Add(this.dgv2);
            this.tbPageSq.Controls.Add(this.ChartOfFunctionSQR);
            this.tbPageSq.Controls.Add(this.btnSqrRegCount);
            this.tbPageSq.ForeColor = System.Drawing.Color.Transparent;
            this.tbPageSq.Location = new System.Drawing.Point(4, 23);
            this.tbPageSq.Name = "tbPageSq";
            this.tbPageSq.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSq.Size = new System.Drawing.Size(767, 425);
            this.tbPageSq.TabIndex = 1;
            this.tbPageSq.Text = "Квадратичная регрессия";
            this.tbPageSq.UseVisualStyleBackColor = true;
            // 
            // qdrAnswerBox
            // 
            this.qdrAnswerBox.Location = new System.Drawing.Point(0, 336);
            this.qdrAnswerBox.Multiline = true;
            this.qdrAnswerBox.Name = "qdrAnswerBox";
            this.qdrAnswerBox.Size = new System.Drawing.Size(764, 83);
            this.qdrAnswerBox.TabIndex = 5;
            // 
            // dgv2
            // 
            this.dgv2.AllowUserToAddRows = false;
            this.dgv2.AllowUserToDeleteRows = false;
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Consolas", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv2.GridColor = System.Drawing.SystemColors.Control;
            this.dgv2.Location = new System.Drawing.Point(6, 51);
            this.dgv2.Name = "dgv2";
            this.dgv2.RowTemplate.Height = 25;
            this.dgv2.Size = new System.Drawing.Size(322, 243);
            this.dgv2.TabIndex = 4;
            // 
            // ChartOfFunctionSQR
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartOfFunctionSQR.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartOfFunctionSQR.Legends.Add(legend2);
            this.ChartOfFunctionSQR.Location = new System.Drawing.Point(319, 11);
            this.ChartOfFunctionSQR.Name = "ChartOfFunctionSQR";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartOfFunctionSQR.Series.Add(series2);
            this.ChartOfFunctionSQR.Size = new System.Drawing.Size(442, 310);
            this.ChartOfFunctionSQR.TabIndex = 3;
            this.ChartOfFunctionSQR.Text = "chart1";
            // 
            // btnSqrRegCount
            // 
            this.btnSqrRegCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSqrRegCount.Location = new System.Drawing.Point(6, 22);
            this.btnSqrRegCount.Name = "btnSqrRegCount";
            this.btnSqrRegCount.Size = new System.Drawing.Size(193, 23);
            this.btnSqrRegCount.TabIndex = 1;
            this.btnSqrRegCount.Text = "Рассчитать";
            this.btnSqrRegCount.UseVisualStyleBackColor = true;
            this.btnSqrRegCount.Click += new System.EventHandler(this.btnSqrRegCount_Click);
            // 
            // frmCorrellatorPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.tbLineReg);
            this.Font = new System.Drawing.Font("Consolas", 9F);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.KeyPreview = true;
            this.Name = "frmCorrellatorPro";
            this.Text = "Корреляция и регрессия";
            this.Load += new System.EventHandler(this.frmCorrellatorPro_Load);
            this.tbLineReg.ResumeLayout(false);
            this.tbPageTask.ResumeLayout(false);
            this.grParam.ResumeLayout(false);
            this.grParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).EndInit();
            this.tbPageLine.ResumeLayout(false);
            this.tbPageLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
            this.tbPageSq.ResumeLayout(false);
            this.tbPageSq.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfFunctionSQR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbLineReg;
        private System.Windows.Forms.TabPage tbPageLine;
        private System.Windows.Forms.TabPage tbPageSq;
        private System.Windows.Forms.TabPage tbPageTask;
        private System.Windows.Forms.RichTextBox richTextBoxTask;
        private System.Windows.Forms.GroupBox grParam;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btLineRegCount;
        private System.Windows.Forms.DataGridView dgvTemp;
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartOfFunction;
        public System.Windows.Forms.TextBox textboxAnswer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btnSqrRegCount;
        private System.Windows.Forms.DataGridView dgv2;
        public System.Windows.Forms.DataVisualization.Charting.Chart ChartOfFunctionSQR;
        public System.Windows.Forms.TextBox qdrAnswerBox;
    }
}

