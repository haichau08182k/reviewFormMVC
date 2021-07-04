namespace HotelWithEntity.UserControls
{
    partial class uEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgvListEmployee = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvListEmployee
            // 
            this.dtgvListEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListEmployee.Location = new System.Drawing.Point(145, 121);
            this.dtgvListEmployee.Name = "dtgvListEmployee";
            this.dtgvListEmployee.Size = new System.Drawing.Size(850, 361);
            this.dtgvListEmployee.TabIndex = 0;
            // 
            // uEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.Controls.Add(this.dtgvListEmployee);
            this.Name = "uEmployee";
            this.Size = new System.Drawing.Size(1290, 574);
            this.Load += new System.EventHandler(this.uEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvListEmployee;
    }
}
