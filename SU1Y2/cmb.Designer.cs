namespace SU1Y2
{
    partial class cmb
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
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtnewitem = new SU1Y2.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Items :";
            // 
            // cbGender
            // 
            this.cbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGender.DropDownHeight = 100;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.IntegralHeight = false;
            this.cbGender.Location = new System.Drawing.Point(178, 156);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(309, 37);
            this.cbGender.Sorted = true;
            this.cbGender.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(512, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 34);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtnewitem
            // 
            this.txtnewitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.txtnewitem.ForeColor = System.Drawing.Color.Gray;
            this.txtnewitem.Location = new System.Drawing.Point(178, 72);
            this.txtnewitem.Name = "txtnewitem";
            this.txtnewitem.PlaceHolderText = "Enter Item";
            this.txtnewitem.Size = new System.Drawing.Size(309, 34);
            this.txtnewitem.TabIndex = 4;
            this.txtnewitem.Text = "Enter Item";
            // 
            // cmb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 261);
            this.Controls.Add(this.txtnewitem);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "cmb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2";
            this.Load += new System.EventHandler(this.cmb_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnAdd;
        private PlaceHolderTextBox txtnewitem;
    }
}