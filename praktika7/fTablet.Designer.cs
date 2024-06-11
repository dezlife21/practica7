namespace praktika7
{
    partial class fTablet
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbStorage = new System.Windows.Forms.TextBox();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chbHasCamera = new System.Windows.Forms.CheckBox();
            this.chbHasSIMSlot = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бренд";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbStorage);
            this.panel1.Controls.Add(this.tbRAM);
            this.panel1.Controls.Add(this.tbProcessor);
            this.panel1.Controls.Add(this.tbOS);
            this.panel1.Controls.Add(this.tbModel);
            this.panel1.Controls.Add(this.tbBrand);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 307);
            this.panel1.TabIndex = 1;
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(145, 206);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.Size = new System.Drawing.Size(139, 20);
            this.tbStorage.TabIndex = 11;
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(145, 162);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(139, 20);
            this.tbRAM.TabIndex = 10;
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(145, 123);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(139, 20);
            this.tbProcessor.TabIndex = 9;
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(145, 91);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(139, 20);
            this.tbOS.TabIndex = 8;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(145, 61);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(139, 20);
            this.tbModel.TabIndex = 7;
            this.tbModel.TextChanged += new System.EventHandler(this.tbModel_TextChanged);
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(145, 30);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(139, 20);
            this.tbBrand.TabIndex = 6;
            this.tbBrand.TextChanged += new System.EventHandler(this.tbBrand_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Память";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "ОЗУ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Процессор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "OS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // chbHasCamera
            // 
            this.chbHasCamera.AutoSize = true;
            this.chbHasCamera.Location = new System.Drawing.Point(29, 365);
            this.chbHasCamera.Name = "chbHasCamera";
            this.chbHasCamera.Size = new System.Drawing.Size(87, 17);
            this.chbHasCamera.TabIndex = 6;
            this.chbHasCamera.Text = "Має камеру";
            this.chbHasCamera.UseVisualStyleBackColor = true;
            // 
            // chbHasSIMSlot
            // 
            this.chbHasSIMSlot.AutoSize = true;
            this.chbHasSIMSlot.Location = new System.Drawing.Point(29, 407);
            this.chbHasSIMSlot.Name = "chbHasSIMSlot";
            this.chbHasSIMSlot.Size = new System.Drawing.Size(140, 17);
            this.chbHasSIMSlot.TabIndex = 7;
            this.chbHasSIMSlot.Text = "Має слот під сім карту";
            this.chbHasSIMSlot.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(344, 58);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(344, 110);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // fTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.chbHasSIMSlot);
            this.Controls.Add(this.chbHasCamera);
            this.Controls.Add(this.panel1);
            this.Name = "fTown";
            this.Text = "fTown";
            this.Load += new System.EventHandler(this.fTown_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chbHasCamera;
        private System.Windows.Forms.CheckBox chbHasSIMSlot;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbBrand;
    }
}