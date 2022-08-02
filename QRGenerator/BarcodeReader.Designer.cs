
namespace QRGenerator
{
    partial class BarcodeReader
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
            this.mainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.barcodePicBox = new System.Windows.Forms.PictureBox();
            this.itemListLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.barcodeTxtBox = new System.Windows.Forms.TextBox();
            this.btnBarcodeGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.extraTxtBox = new System.Windows.Forms.TextBox();
            this.btnPickFont = new System.Windows.Forms.Button();
            this.btnExtraAdd = new System.Windows.Forms.Button();
            this.btnBarcodeFont = new System.Windows.Forms.Button();
            this.propertiesLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.extraTextPropertyTxtBox = new System.Windows.Forms.TextBox();
            this.btnPropertyChangeFont = new System.Windows.Forms.Button();
            this.fontPicker = new System.Windows.Forms.FontDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barcodePicBox)).BeginInit();
            this.itemListLayout.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.propertiesLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainLayoutPanel
            // 
            this.mainLayoutPanel.ColumnCount = 3;
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.9465F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.32098F));
            this.mainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.6402F));
            this.mainLayoutPanel.Controls.Add(this.barcodePicBox, 1, 0);
            this.mainLayoutPanel.Controls.Add(this.itemListLayout, 1, 1);
            this.mainLayoutPanel.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.mainLayoutPanel.Controls.Add(this.propertiesLayoutPanel, 2, 0);
            this.mainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanel.Name = "mainLayoutPanel";
            this.mainLayoutPanel.RowCount = 2;
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.28692F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.71308F));
            this.mainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanel.Size = new System.Drawing.Size(1215, 748);
            this.mainLayoutPanel.TabIndex = 0;
            // 
            // barcodePicBox
            // 
            this.barcodePicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barcodePicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodePicBox.Location = new System.Drawing.Point(136, 3);
            this.barcodePicBox.Name = "barcodePicBox";
            this.barcodePicBox.Size = new System.Drawing.Size(897, 639);
            this.barcodePicBox.TabIndex = 0;
            this.barcodePicBox.TabStop = false;
            // 
            // itemListLayout
            // 
            this.itemListLayout.Controls.Add(this.btnSave);
            this.itemListLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListLayout.Location = new System.Drawing.Point(136, 648);
            this.itemListLayout.Name = "itemListLayout";
            this.itemListLayout.Size = new System.Drawing.Size(897, 97);
            this.itemListLayout.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(894, 94);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblBarCode);
            this.flowLayoutPanel1.Controls.Add(this.barcodeTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.btnBarcodeGenerate);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.extraTxtBox);
            this.flowLayoutPanel1.Controls.Add(this.btnPickFont);
            this.flowLayoutPanel1.Controls.Add(this.btnExtraAdd);
            this.flowLayoutPanel1.Controls.Add(this.btnBarcodeFont);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(127, 639);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBarCode.Location = new System.Drawing.Point(3, 0);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblBarCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblBarCode.Size = new System.Drawing.Size(120, 13);
            this.lblBarCode.TabIndex = 0;
            this.lblBarCode.Text = "Barcode Text";
            this.lblBarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // barcodeTxtBox
            // 
            this.barcodeTxtBox.Location = new System.Drawing.Point(3, 16);
            this.barcodeTxtBox.Name = "barcodeTxtBox";
            this.barcodeTxtBox.Size = new System.Drawing.Size(120, 20);
            this.barcodeTxtBox.TabIndex = 1;
            // 
            // btnBarcodeGenerate
            // 
            this.btnBarcodeGenerate.Location = new System.Drawing.Point(3, 42);
            this.btnBarcodeGenerate.Name = "btnBarcodeGenerate";
            this.btnBarcodeGenerate.Size = new System.Drawing.Size(120, 23);
            this.btnBarcodeGenerate.TabIndex = 2;
            this.btnBarcodeGenerate.Text = "Generate";
            this.btnBarcodeGenerate.UseVisualStyleBackColor = true;
            this.btnBarcodeGenerate.Click += new System.EventHandler(this.btnBarcodeGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 68);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Extra Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // extraTxtBox
            // 
            this.extraTxtBox.Location = new System.Drawing.Point(3, 84);
            this.extraTxtBox.Name = "extraTxtBox";
            this.extraTxtBox.Size = new System.Drawing.Size(120, 20);
            this.extraTxtBox.TabIndex = 4;
            // 
            // btnPickFont
            // 
            this.btnPickFont.Location = new System.Drawing.Point(3, 110);
            this.btnPickFont.Name = "btnPickFont";
            this.btnPickFont.Size = new System.Drawing.Size(120, 23);
            this.btnPickFont.TabIndex = 5;
            this.btnPickFont.Text = "Pick Font";
            this.btnPickFont.UseVisualStyleBackColor = true;
            this.btnPickFont.Click += new System.EventHandler(this.btnPickFont_Click);
            // 
            // btnExtraAdd
            // 
            this.btnExtraAdd.Location = new System.Drawing.Point(3, 139);
            this.btnExtraAdd.Name = "btnExtraAdd";
            this.btnExtraAdd.Size = new System.Drawing.Size(120, 23);
            this.btnExtraAdd.TabIndex = 10;
            this.btnExtraAdd.Text = "Apply Font";
            this.btnExtraAdd.UseVisualStyleBackColor = true;
            this.btnExtraAdd.Click += new System.EventHandler(this.btnExtraAdd_Click);
            // 
            // btnBarcodeFont
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.btnBarcodeFont, true);
            this.btnBarcodeFont.Location = new System.Drawing.Point(3, 168);
            this.btnBarcodeFont.Name = "btnBarcodeFont";
            this.btnBarcodeFont.Size = new System.Drawing.Size(120, 23);
            this.btnBarcodeFont.TabIndex = 11;
            this.btnBarcodeFont.Text = "Pick Barcode Font";
            this.btnBarcodeFont.UseVisualStyleBackColor = true;
            this.btnBarcodeFont.Click += new System.EventHandler(this.btnBarcodeFont_Click);
            // 
            // propertiesLayoutPanel
            // 
            this.propertiesLayoutPanel.Controls.Add(this.label2);
            this.propertiesLayoutPanel.Controls.Add(this.extraTextPropertyTxtBox);
            this.propertiesLayoutPanel.Controls.Add(this.btnPropertyChangeFont);
            this.propertiesLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.propertiesLayoutPanel.Location = new System.Drawing.Point(1039, 3);
            this.propertiesLayoutPanel.Name = "propertiesLayoutPanel";
            this.propertiesLayoutPanel.Size = new System.Drawing.Size(173, 639);
            this.propertiesLayoutPanel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(131, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Text Value";
            // 
            // extraTextPropertyTxtBox
            // 
            this.extraTextPropertyTxtBox.Location = new System.Drawing.Point(3, 27);
            this.extraTextPropertyTxtBox.Name = "extraTextPropertyTxtBox";
            this.extraTextPropertyTxtBox.Size = new System.Drawing.Size(170, 20);
            this.extraTextPropertyTxtBox.TabIndex = 1;
            this.extraTextPropertyTxtBox.TextChanged += new System.EventHandler(this.extraTextPropertyTxtBox_TextChanged);
            // 
            // btnPropertyChangeFont
            // 
            this.btnPropertyChangeFont.Location = new System.Drawing.Point(3, 53);
            this.btnPropertyChangeFont.Name = "btnPropertyChangeFont";
            this.btnPropertyChangeFont.Size = new System.Drawing.Size(170, 23);
            this.btnPropertyChangeFont.TabIndex = 2;
            this.btnPropertyChangeFont.Text = "Pick Font";
            this.btnPropertyChangeFont.UseVisualStyleBackColor = true;
            this.btnPropertyChangeFont.Click += new System.EventHandler(this.btnChangeText_Click);
            // 
            // BarcodeReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 748);
            this.Controls.Add(this.mainLayoutPanel);
            this.Name = "BarcodeReader";
            this.Text = "BarcodeReader";
            this.mainLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barcodePicBox)).EndInit();
            this.itemListLayout.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.propertiesLayoutPanel.ResumeLayout(false);
            this.propertiesLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainLayoutPanel;
        private System.Windows.Forms.PictureBox barcodePicBox;
        private System.Windows.Forms.FlowLayoutPanel itemListLayout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.TextBox barcodeTxtBox;
        private System.Windows.Forms.Button btnBarcodeGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox extraTxtBox;
        private System.Windows.Forms.Button btnPickFont;
        private System.Windows.Forms.Button btnExtraAdd;
        private System.Windows.Forms.FontDialog fontPicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel propertiesLayoutPanel;
        private System.Windows.Forms.Button btnBarcodeFont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox extraTextPropertyTxtBox;
        private System.Windows.Forms.Button btnPropertyChangeFont;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}