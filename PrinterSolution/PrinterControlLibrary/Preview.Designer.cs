namespace PrinterControlLibrary
{
    partial class Preview
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDept = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5024 = new System.Windows.Forms.Panel();
            this.labelSpec5024 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelArea5024 = new System.Windows.Forms.Label();
            this.labelDate5024 = new System.Windows.Forms.Label();
            this.labelName5024 = new System.Windows.Forms.Label();
            this.labelTitle5024 = new System.Windows.Forms.Label();
            this.panel92 = new System.Windows.Forms.Panel();
            this.textSpec = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textNo = new System.Windows.Forms.Label();
            this.textArea = new System.Windows.Forms.Label();
            this.textDate = new System.Windows.Forms.Label();
            this.textBrand = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.Label();
            this.panel74 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.cbxLabel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel5024.SuspendLayout();
            this.panel92.SuspendLayout();
            this.panel74.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(342, 305);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(476, 305);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(75, 23);
            this.btnCancle.TabIndex = 1;
            this.btnCancle.Text = "取消";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::PrinterControlLibrary.Properties.Resources.无标题d;
            this.panel3.Location = new System.Drawing.Point(56, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 33);
            this.panel3.TabIndex = 6;
            // 
            // labelNo
            // 
            this.labelNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNo.AutoSize = true;
            this.labelNo.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNo.Location = new System.Drawing.Point(104, 99);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(187, 14);
            this.labelNo.TabIndex = 5;
            this.labelNo.Text = "00000000000000000000";
            this.labelNo.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelArea.Location = new System.Drawing.Point(378, 113);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(63, 14);
            this.labelArea.TabIndex = 4;
            this.labelArea.Text = "存放位置";
            this.labelArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelArea.Click += new System.EventHandler(this.labelArea_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDate.Location = new System.Drawing.Point(10, 113);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(77, 14);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "2017-12-12";
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDept.Location = new System.Drawing.Point(378, 32);
            this.labelDept.Margin = new System.Windows.Forms.Padding(0);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(63, 14);
            this.labelDept.TabIndex = 2;
            this.labelDept.Text = "所属部门";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName.Location = new System.Drawing.Point(10, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(63, 14);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "资产名称";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.panel92);
            this.panel2.Controls.Add(this.panel74);
            this.panel2.Controls.Add(this.panel5024);
            this.panel2.Location = new System.Drawing.Point(43, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 215);
            this.panel2.TabIndex = 3;
            // 
            // panel5024
            // 
            this.panel5024.BackColor = System.Drawing.Color.White;
            this.panel5024.Controls.Add(this.labelSpec5024);
            this.panel5024.Controls.Add(this.panel4);
            this.panel5024.Controls.Add(this.labelArea5024);
            this.panel5024.Controls.Add(this.labelDate5024);
            this.panel5024.Controls.Add(this.labelName5024);
            this.panel5024.Controls.Add(this.labelTitle5024);
            this.panel5024.Location = new System.Drawing.Point(80, 20);
            this.panel5024.Name = "panel5024";
            this.panel5024.Size = new System.Drawing.Size(350, 170);
            this.panel5024.TabIndex = 8;
            // 
            // labelSpec5024
            // 
            this.labelSpec5024.AutoSize = true;
            this.labelSpec5024.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSpec5024.Location = new System.Drawing.Point(201, 82);
            this.labelSpec5024.Margin = new System.Windows.Forms.Padding(0);
            this.labelSpec5024.Name = "labelSpec5024";
            this.labelSpec5024.Size = new System.Drawing.Size(35, 14);
            this.labelSpec5024.TabIndex = 7;
            this.labelSpec5024.Text = "规格";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::PrinterControlLibrary.Properties.Resources.无标题d;
            this.panel4.Location = new System.Drawing.Point(13, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(318, 33);
            this.panel4.TabIndex = 6;
            // 
            // labelArea5024
            // 
            this.labelArea5024.AutoSize = true;
            this.labelArea5024.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelArea5024.Location = new System.Drawing.Point(10, 82);
            this.labelArea5024.Name = "labelArea5024";
            this.labelArea5024.Size = new System.Drawing.Size(35, 14);
            this.labelArea5024.TabIndex = 3;
            this.labelArea5024.Text = "区域";
            // 
            // labelDate5024
            // 
            this.labelDate5024.AutoSize = true;
            this.labelDate5024.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelDate5024.Location = new System.Drawing.Point(201, 45);
            this.labelDate5024.Margin = new System.Windows.Forms.Padding(0);
            this.labelDate5024.Name = "labelDate5024";
            this.labelDate5024.Size = new System.Drawing.Size(77, 14);
            this.labelDate5024.TabIndex = 2;
            this.labelDate5024.Text = "2017-12-12";
            // 
            // labelName5024
            // 
            this.labelName5024.AutoSize = true;
            this.labelName5024.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelName5024.Location = new System.Drawing.Point(10, 45);
            this.labelName5024.Name = "labelName5024";
            this.labelName5024.Size = new System.Drawing.Size(63, 14);
            this.labelName5024.TabIndex = 1;
            this.labelName5024.Text = "资产名称";
            // 
            // labelTitle5024
            // 
            this.labelTitle5024.AutoSize = true;
            this.labelTitle5024.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle5024.Location = new System.Drawing.Point(97, 10);
            this.labelTitle5024.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle5024.Name = "labelTitle5024";
            this.labelTitle5024.Size = new System.Drawing.Size(93, 20);
            this.labelTitle5024.TabIndex = 0;
            this.labelTitle5024.Text = "公司名称";
            this.labelTitle5024.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel92
            // 
            this.panel92.BackColor = System.Drawing.Color.White;
            this.panel92.Controls.Add(this.textSpec);
            this.panel92.Controls.Add(this.panel5);
            this.panel92.Controls.Add(this.textNo);
            this.panel92.Controls.Add(this.textArea);
            this.panel92.Controls.Add(this.textDate);
            this.panel92.Controls.Add(this.textBrand);
            this.panel92.Controls.Add(this.textName);
            this.panel92.Controls.Add(this.textTitle);
            this.panel92.Location = new System.Drawing.Point(26, 34);
            this.panel92.Name = "panel92";
            this.panel92.Size = new System.Drawing.Size(444, 144);
            this.panel92.TabIndex = 7;
            // 
            // textSpec
            // 
            this.textSpec.AutoSize = true;
            this.textSpec.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textSpec.Location = new System.Drawing.Point(306, 82);
            this.textSpec.Margin = new System.Windows.Forms.Padding(0);
            this.textSpec.Name = "textSpec";
            this.textSpec.Size = new System.Drawing.Size(35, 14);
            this.textSpec.TabIndex = 7;
            this.textSpec.Text = "规格";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = global::PrinterControlLibrary.Properties.Resources.无标题d;
            this.panel5.Location = new System.Drawing.Point(13, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(412, 33);
            this.panel5.TabIndex = 6;
            // 
            // textNo
            // 
            this.textNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textNo.AutoSize = true;
            this.textNo.Font = new System.Drawing.Font("宋体", 8F);
            this.textNo.Location = new System.Drawing.Point(10, 57);
            this.textNo.Name = "textNo";
            this.textNo.Size = new System.Drawing.Size(147, 14);
            this.textNo.TabIndex = 5;
            this.textNo.Text = "00000000000000000000";
            // 
            // textArea
            // 
            this.textArea.AutoSize = true;
            this.textArea.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textArea.Location = new System.Drawing.Point(306, 57);
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(35, 14);
            this.textArea.TabIndex = 4;
            this.textArea.Text = "区域";
            this.textArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textDate
            // 
            this.textDate.AutoSize = true;
            this.textDate.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textDate.Location = new System.Drawing.Point(10, 80);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(77, 14);
            this.textDate.TabIndex = 3;
            this.textDate.Text = "2017-12-12";
            // 
            // textBrand
            // 
            this.textBrand.AutoSize = true;
            this.textBrand.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBrand.Location = new System.Drawing.Point(306, 32);
            this.textBrand.Margin = new System.Windows.Forms.Padding(0);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(35, 14);
            this.textBrand.TabIndex = 2;
            this.textBrand.Text = "品牌";
            // 
            // textName
            // 
            this.textName.AutoSize = true;
            this.textName.Font = new System.Drawing.Font("宋体", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textName.Location = new System.Drawing.Point(10, 33);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(63, 14);
            this.textName.TabIndex = 1;
            this.textName.Text = "资产名称";
            // 
            // textTitle
            // 
            this.textTitle.AutoSize = true;
            this.textTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textTitle.Location = new System.Drawing.Point(124, 10);
            this.textTitle.Margin = new System.Windows.Forms.Padding(0);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(93, 20);
            this.textTitle.TabIndex = 0;
            this.textTitle.Text = "公司名称";
            this.textTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel74
            // 
            this.panel74.BackColor = System.Drawing.Color.White;
            this.panel74.Controls.Add(this.panel3);
            this.panel74.Controls.Add(this.labelNo);
            this.panel74.Controls.Add(this.labelArea);
            this.panel74.Controls.Add(this.labelDate);
            this.panel74.Controls.Add(this.labelDept);
            this.panel74.Controls.Add(this.labelName);
            this.panel74.Controls.Add(this.labelTitle);
            this.panel74.Location = new System.Drawing.Point(26, 34);
            this.panel74.Name = "panel74";
            this.panel74.Size = new System.Drawing.Size(444, 144);
            this.panel74.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(124, 10);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(93, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "公司名称";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxLabel
            // 
            this.cbxLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLabel.FormattingEnabled = true;
            this.cbxLabel.Items.AddRange(new object[] {
            "SATO-抗金属标签（24mm*92mm）",
            "SATO-非抗金属标签（24mm*74mm）",
            "PT-900标签（100mm*36mm）",
            "PT-900标签（50mm*24mm）"});
            this.cbxLabel.Location = new System.Drawing.Point(190, 22);
            this.cbxLabel.Name = "cbxLabel";
            this.cbxLabel.Size = new System.Drawing.Size(245, 23);
            this.cbxLabel.TabIndex = 4;
            this.cbxLabel.SelectedIndexChanged += new System.EventHandler(this.cbxLabel_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "选择标签类型";
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLabel);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panel2);
            this.Name = "Preview";
            this.Text = "打印样式预览";
            this.panel2.ResumeLayout(false);
            this.panel5024.ResumeLayout(false);
            this.panel5024.PerformLayout();
            this.panel92.ResumeLayout(false);
            this.panel92.PerformLayout();
            this.panel74.ResumeLayout(false);
            this.panel74.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel74;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox cbxLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel92;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label textNo;
        private System.Windows.Forms.Label textArea;
        private System.Windows.Forms.Label textDate;
        private System.Windows.Forms.Label textBrand;
        private System.Windows.Forms.Label textName;
        private System.Windows.Forms.Label textTitle;
        private System.Windows.Forms.Label textSpec;
        private System.Windows.Forms.Panel panel5024;
        private System.Windows.Forms.Label labelSpec5024;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelArea5024;
        private System.Windows.Forms.Label labelDate5024;
        private System.Windows.Forms.Label labelName5024;
        private System.Windows.Forms.Label labelTitle5024;
    }
}