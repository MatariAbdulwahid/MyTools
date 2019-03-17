namespace PictureSizeChange
{
    partial class MyTools
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudWid = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudHeig = new System.Windows.Forms.NumericUpDown();
            this.lbxFile = new System.Windows.Forms.ListBox();
            this.btnPdf = new System.Windows.Forms.Button();
            this.btnConvPdf = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudWid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeig)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(30, 76);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(65, 59);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select Image";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Enabled = false;
            this.btnConvert.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btnConvert.Location = new System.Drawing.Point(608, 76);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(74, 59);
            this.btnConvert.TabIndex = 1;
            this.btnConvert.Text = "change Image size";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "MyTools";
            // 
            // nudWid
            // 
            this.nudWid.Location = new System.Drawing.Point(388, 82);
            this.nudWid.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudWid.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudWid.Name = "nudWid";
            this.nudWid.Size = new System.Drawing.Size(120, 20);
            this.nudWid.TabIndex = 3;
            this.nudWid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudWid.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(282, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(282, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height";
            // 
            // nudHeig
            // 
            this.nudHeig.Location = new System.Drawing.Point(388, 115);
            this.nudHeig.Maximum = new decimal(new int[] {
            2500,
            0,
            0,
            0});
            this.nudHeig.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudHeig.Name = "nudHeig";
            this.nudHeig.Size = new System.Drawing.Size(120, 20);
            this.nudHeig.TabIndex = 5;
            this.nudHeig.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudHeig.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lbxFile
            // 
            this.lbxFile.FormattingEnabled = true;
            this.lbxFile.Location = new System.Drawing.Point(30, 141);
            this.lbxFile.Name = "lbxFile";
            this.lbxFile.Size = new System.Drawing.Size(652, 173);
            this.lbxFile.TabIndex = 7;
            // 
            // btnPdf
            // 
            this.btnPdf.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPdf.Location = new System.Drawing.Point(113, 76);
            this.btnPdf.Name = "btnPdf";
            this.btnPdf.Size = new System.Drawing.Size(68, 59);
            this.btnPdf.TabIndex = 8;
            this.btnPdf.Text = "Select pdf";
            this.btnPdf.UseVisualStyleBackColor = true;
            this.btnPdf.Click += new System.EventHandler(this.btnPdf_Click);
            // 
            // btnConvPdf
            // 
            this.btnConvPdf.Enabled = false;
            this.btnConvPdf.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.btnConvPdf.Location = new System.Drawing.Point(528, 76);
            this.btnConvPdf.Name = "btnConvPdf";
            this.btnConvPdf.Size = new System.Drawing.Size(74, 59);
            this.btnConvPdf.TabIndex = 9;
            this.btnConvPdf.Text = "Convert pdf to Word";
            this.btnConvPdf.UseVisualStyleBackColor = true;
            this.btnConvPdf.Click += new System.EventHandler(this.btnConvPdf_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(688, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "CLR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(722, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConvPdf);
            this.Controls.Add(this.btnPdf);
            this.Controls.Add(this.lbxFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudHeig);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudWid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnSelect);
            this.Name = "Form1";
            this.Text = "+";
        
            ((System.ComponentModel.ISupportInitialize)(this.nudWid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeig)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudWid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudHeig;
        private System.Windows.Forms.ListBox lbxFile;
        private System.Windows.Forms.Button btnPdf;
        private System.Windows.Forms.Button btnConvPdf;
        private System.Windows.Forms.Button button1;
    }
}

