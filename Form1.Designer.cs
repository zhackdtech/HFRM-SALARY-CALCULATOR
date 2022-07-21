namespace HFRM_SALARY_CALCULATOR
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainFormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.daraGridViewElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnExportElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnOpenElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCalculateElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnCalculate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnOpen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExport = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnImage = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mainFormElipse
            // 
            this.mainFormElipse.ElipseRadius = 20;
            this.mainFormElipse.TargetControl = this;
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.pnlTitleBar.Controls.Add(this.btnImage);
            this.pnlTitleBar.Controls.Add(this.btnExit);
            this.pnlTitleBar.Controls.Add(this.label1);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(892, 75);
            this.pnlTitleBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAMPLE";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.DoubleBuffered = true;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridView1.Location = new System.Drawing.Point(12, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.Size = new System.Drawing.Size(572, 438);
            this.dataGridView1.TabIndex = 2;
            // 
            // daraGridViewElipse
            // 
            this.daraGridViewElipse.ElipseRadius = 15;
            this.daraGridViewElipse.TargetControl = this.dataGridView1;
            // 
            // btnExportElipse
            // 
            this.btnExportElipse.ElipseRadius = 15;
            this.btnExportElipse.TargetControl = this.btnExport;
            // 
            // btnOpenElipse
            // 
            this.btnOpenElipse.ElipseRadius = 15;
            this.btnOpenElipse.TargetControl = this.btnOpen;
            // 
            // btnCalculateElipse
            // 
            this.btnCalculateElipse.ElipseRadius = 15;
            this.btnCalculateElipse.TargetControl = this.btnCalculate;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Active = false;
            this.btnCalculate.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnCalculate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculate.BorderRadius = 0;
            this.btnCalculate.ButtonText = "export";
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.DisabledColor = System.Drawing.Color.Gray;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCalculate.Iconimage = global::HFRM_SALARY_CALCULATOR.Properties.Resources.microsoft_excel_24px;
            this.btnCalculate.Iconimage_right = null;
            this.btnCalculate.Iconimage_right_Selected = null;
            this.btnCalculate.Iconimage_Selected = null;
            this.btnCalculate.IconMarginLeft = 0;
            this.btnCalculate.IconMarginRight = 0;
            this.btnCalculate.IconRightVisible = true;
            this.btnCalculate.IconRightZoom = 0D;
            this.btnCalculate.IconVisible = true;
            this.btnCalculate.IconZoom = 48D;
            this.btnCalculate.IsTab = false;
            this.btnCalculate.Location = new System.Drawing.Point(590, 417);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnCalculate.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(237)))));
            this.btnCalculate.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCalculate.selected = false;
            this.btnCalculate.Size = new System.Drawing.Size(296, 48);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "export";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculate.Textcolor = System.Drawing.Color.White;
            this.btnCalculate.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Active = false;
            this.btnOpen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpen.BorderRadius = 0;
            this.btnOpen.ButtonText = "open";
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.DisabledColor = System.Drawing.Color.Gray;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOpen.Iconimage = global::HFRM_SALARY_CALCULATOR.Properties.Resources.add_file_24px;
            this.btnOpen.Iconimage_right = null;
            this.btnOpen.Iconimage_right_Selected = null;
            this.btnOpen.Iconimage_Selected = null;
            this.btnOpen.IconMarginLeft = 0;
            this.btnOpen.IconMarginRight = 0;
            this.btnOpen.IconRightVisible = true;
            this.btnOpen.IconRightZoom = 0D;
            this.btnOpen.IconVisible = true;
            this.btnOpen.IconZoom = 48D;
            this.btnOpen.IsTab = false;
            this.btnOpen.Location = new System.Drawing.Point(590, 471);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnOpen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(237)))));
            this.btnOpen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOpen.selected = false;
            this.btnOpen.Size = new System.Drawing.Size(145, 48);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "open";
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Textcolor = System.Drawing.Color.White;
            this.btnOpen.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnExport
            // 
            this.btnExport.Active = false;
            this.btnExport.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnExport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExport.BorderRadius = 0;
            this.btnExport.ButtonText = "export";
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DisabledColor = System.Drawing.Color.Gray;
            this.btnExport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExport.Iconimage = global::HFRM_SALARY_CALCULATOR.Properties.Resources.microsoft_excel_24px;
            this.btnExport.Iconimage_right = null;
            this.btnExport.Iconimage_right_Selected = null;
            this.btnExport.Iconimage_Selected = null;
            this.btnExport.IconMarginLeft = 0;
            this.btnExport.IconMarginRight = 0;
            this.btnExport.IconRightVisible = true;
            this.btnExport.IconRightZoom = 0D;
            this.btnExport.IconVisible = true;
            this.btnExport.IconZoom = 48D;
            this.btnExport.IsTab = false;
            this.btnExport.Location = new System.Drawing.Point(741, 471);
            this.btnExport.Name = "btnExport";
            this.btnExport.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnExport.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(102)))), ((int)(((byte)(237)))));
            this.btnExport.OnHoverTextColor = System.Drawing.Color.White;
            this.btnExport.selected = false;
            this.btnExport.Size = new System.Drawing.Size(145, 48);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Textcolor = System.Drawing.Color.White;
            this.btnExport.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnExit
            // 
            this.btnExit.Image = global::HFRM_SALARY_CALCULATOR.Properties.Resources.close_window_32px;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(848, 27);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 32);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 10;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::HFRM_SALARY_CALCULATOR.Properties.Resources.close_window_32px;
            this.btnImage.ImageActive = null;
            this.btnImage.Location = new System.Drawing.Point(810, 27);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(32, 32);
            this.btnImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnImage.TabIndex = 4;
            this.btnImage.TabStop = false;
            this.btnImage.Zoom = 10;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 531);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pnlTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse mainFormElipse;
        private System.Windows.Forms.Panel pnlTitleBar;
        private Bunifu.Framework.UI.BunifuFlatButton btnExport;
        private Bunifu.Framework.UI.BunifuFlatButton btnOpen;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridView1;
        private Bunifu.Framework.UI.BunifuElipse daraGridViewElipse;
        private Bunifu.Framework.UI.BunifuElipse btnExportElipse;
        private Bunifu.Framework.UI.BunifuElipse btnOpenElipse;
        private Bunifu.Framework.UI.BunifuElipse btnCalculateElipse;
        private Bunifu.Framework.UI.BunifuFlatButton btnCalculate;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuImageButton btnImage;
    }
}

