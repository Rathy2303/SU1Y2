namespace SU1Y2
{
    partial class String_txt
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btntoupper = new System.Windows.Forms.Button();
            this.txttoupper = new System.Windows.Forms.TextBox();
            this.txttolower = new System.Windows.Forms.TextBox();
            this.btntolower = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbinput = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(177, 36);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(402, 34);
            this.txtInput.TabIndex = 1;
            // 
            // btntoupper
            // 
            this.btntoupper.Location = new System.Drawing.Point(53, 120);
            this.btntoupper.Name = "btntoupper";
            this.btntoupper.Size = new System.Drawing.Size(87, 39);
            this.btntoupper.TabIndex = 2;
            this.btntoupper.Text = "==>";
            this.btntoupper.UseVisualStyleBackColor = true;
            this.btntoupper.Click += new System.EventHandler(this.btntoupper_Click);
            // 
            // txttoupper
            // 
            this.txttoupper.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttoupper.Location = new System.Drawing.Point(177, 125);
            this.txttoupper.Name = "txttoupper";
            this.txttoupper.Size = new System.Drawing.Size(402, 34);
            this.txttoupper.TabIndex = 3;
            this.txttoupper.Text = "ToUpper";
            // 
            // txttolower
            // 
            this.txttolower.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttolower.Location = new System.Drawing.Point(177, 204);
            this.txttolower.Name = "txttolower";
            this.txttolower.Size = new System.Drawing.Size(402, 34);
            this.txttolower.TabIndex = 4;
            this.txttolower.Text = "ToLower";
            // 
            // btntolower
            // 
            this.btntolower.Location = new System.Drawing.Point(53, 203);
            this.btntolower.Name = "btntolower";
            this.btntolower.Size = new System.Drawing.Size(87, 39);
            this.btntolower.TabIndex = 5;
            this.btntolower.Text = "==>";
            this.btntolower.UseVisualStyleBackColor = true;
            this.btntolower.Click += new System.EventHandler(this.btntolower_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(619, 36);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(105, 39);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "<---";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbinput
            // 
            this.cmbinput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbinput.FormattingEnabled = true;
            this.cmbinput.Items.AddRange(new object[] {
            "Male"});
            this.cmbinput.Location = new System.Drawing.Point(177, 291);
            this.cmbinput.Name = "cmbinput";
            this.cmbinput.Size = new System.Drawing.Size(402, 33);
            this.cmbinput.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(619, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(105, 39);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(619, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 39);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(619, 289);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(105, 39);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // String_txt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 382);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbinput);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btntolower);
            this.Controls.Add(this.txttolower);
            this.Controls.Add(this.txttoupper);
            this.Controls.Add(this.btntoupper);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "String_txt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String_txt";
            this.Load += new System.EventHandler(this.String_txt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btntoupper;
        private System.Windows.Forms.TextBox txttoupper;
        private System.Windows.Forms.TextBox txttolower;
        private System.Windows.Forms.Button btntolower;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cmbinput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
    }
}