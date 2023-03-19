
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCorrellatorPro));
            this.tbLineReg = new System.Windows.Forms.TabControl();
            this.tbPageTask = new System.Windows.Forms.TabPage();
            this.grParam = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwData = new System.Windows.Forms.DataGridView();
            this.richTextBoxTask = new System.Windows.Forms.RichTextBox();
            this.tbPageLine = new System.Windows.Forms.TabPage();
            this.dgvTemp = new System.Windows.Forms.DataGridView();
            this.btLineRegCount = new System.Windows.Forms.Button();
            this.tbPageSq = new System.Windows.Forms.TabPage();
            this.tbLineReg.SuspendLayout();
            this.tbPageTask.SuspendLayout();
            this.grParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwData)).BeginInit();
            this.tbPageLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).BeginInit();
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
            this.tbLineReg.Size = new System.Drawing.Size(775, 395);
            this.tbLineReg.TabIndex = 0;
            // 
            // tbPageTask
            // 
            this.tbPageTask.Controls.Add(this.grParam);
            this.tbPageTask.Controls.Add(this.richTextBoxTask);
            this.tbPageTask.Location = new System.Drawing.Point(4, 23);
            this.tbPageTask.Name = "tbPageTask";
            this.tbPageTask.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageTask.Size = new System.Drawing.Size(767, 368);
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
            this.dgwData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwData.GridColor = System.Drawing.SystemColors.Control;
            this.dgwData.Location = new System.Drawing.Point(6, 99);
            this.dgwData.Name = "dgwData";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwData.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwData.RowTemplate.Height = 25;
            this.dgwData.Size = new System.Drawing.Size(732, 101);
            this.dgwData.TabIndex = 0;
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
            this.tbPageLine.Controls.Add(this.dgvTemp);
            this.tbPageLine.Controls.Add(this.btLineRegCount);
            this.tbPageLine.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.tbPageLine.Location = new System.Drawing.Point(4, 23);
            this.tbPageLine.Name = "tbPageLine";
            this.tbPageLine.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageLine.Size = new System.Drawing.Size(767, 368);
            this.tbPageLine.TabIndex = 0;
            this.tbPageLine.Text = "Линейная регрессия";
            // 
            // dgvTemp
            // 
            this.dgvTemp.AllowUserToAddRows = false;
            this.dgvTemp.AllowUserToDeleteRows = false;
            this.dgvTemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemp.Location = new System.Drawing.Point(7, 46);
            this.dgvTemp.Name = "dgvTemp";
            this.dgvTemp.RowTemplate.Height = 25;
            this.dgvTemp.Size = new System.Drawing.Size(356, 316);
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
            this.tbPageSq.ForeColor = System.Drawing.Color.Transparent;
            this.tbPageSq.Location = new System.Drawing.Point(4, 23);
            this.tbPageSq.Name = "tbPageSq";
            this.tbPageSq.Padding = new System.Windows.Forms.Padding(3);
            this.tbPageSq.Size = new System.Drawing.Size(767, 368);
            this.tbPageSq.TabIndex = 1;
            this.tbPageSq.Text = "Квадратичная регрессия";
            this.tbPageSq.UseVisualStyleBackColor = true;
            // 
            // frmCorrellatorPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 420);
            this.Controls.Add(this.tbLineReg);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemp)).EndInit();
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
        private System.Windows.Forms.DataGridView dgwData;
        private System.Windows.Forms.Button btLineRegCount;
        private System.Windows.Forms.DataGridView dgvTemp;
    }
}

