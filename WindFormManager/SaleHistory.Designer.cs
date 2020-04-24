namespace WindFormManager
{
    partial class SaleHistory
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
            this.labelCount = new System.Windows.Forms.Label();
            this.labelDateOrdered = new System.Windows.Forms.Label();
            this.labelDateDelivery = new System.Windows.Forms.Label();
            this.labelProductID = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxProductID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.dateTimePickerDateOrdered = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateDelivery = new System.Windows.Forms.DateTimePicker();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 0;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCount.Location = new System.Drawing.Point(31, 15);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(105, 29);
            this.labelCount.TabIndex = 0;
            this.labelCount.Text = "COUNT";
            // 
            // labelDateOrdered
            // 
            this.labelDateOrdered.AutoSize = true;
            this.labelDateOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOrdered.Location = new System.Drawing.Point(31, 44);
            this.labelDateOrdered.Name = "labelDateOrdered";
            this.labelDateOrdered.Size = new System.Drawing.Size(207, 29);
            this.labelDateOrdered.TabIndex = 0;
            this.labelDateOrdered.Text = "DATEORDERED";
            // 
            // labelDateDelivery
            // 
            this.labelDateDelivery.AutoSize = true;
            this.labelDateDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateDelivery.Location = new System.Drawing.Point(31, 76);
            this.labelDateDelivery.Name = "labelDateDelivery";
            this.labelDateDelivery.Size = new System.Drawing.Size(205, 29);
            this.labelDateDelivery.TabIndex = 0;
            this.labelDateDelivery.Text = "DATEDELIVERY";
            // 
            // labelProductID
            // 
            this.labelProductID.AutoSize = true;
            this.labelProductID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProductID.Location = new System.Drawing.Point(31, 105);
            this.labelProductID.Name = "labelProductID";
            this.labelProductID.Size = new System.Drawing.Size(164, 29);
            this.labelProductID.TabIndex = 0;
            this.labelProductID.Text = "PRODUCTID";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(257, 18);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(207, 20);
            this.textBoxCount.TabIndex = 1;
            // 
            // textBoxProductID
            // 
            this.textBoxProductID.Location = new System.Drawing.Point(257, 111);
            this.textBoxProductID.Name = "textBoxProductID";
            this.textBoxProductID.Size = new System.Drawing.Size(207, 20);
            this.textBoxProductID.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 148);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpdate.Location = new System.Drawing.Point(483, 18);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(105, 35);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "UPDATE";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(483, 61);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 35);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSelect.Location = new System.Drawing.Point(610, 18);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(101, 35);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "SELECT";
            this.buttonSelect.UseVisualStyleBackColor = true;
            // 
            // buttonInsert
            // 
            this.buttonInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonInsert.Location = new System.Drawing.Point(610, 61);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(101, 35);
            this.buttonInsert.TabIndex = 3;
            this.buttonInsert.Text = "INSERT";
            this.buttonInsert.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateOrdered
            // 
            this.dateTimePickerDateOrdered.Location = new System.Drawing.Point(257, 50);
            this.dateTimePickerDateOrdered.Name = "dateTimePickerDateOrdered";
            this.dateTimePickerDateOrdered.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerDateOrdered.TabIndex = 4;
            // 
            // dateTimePickerDateDelivery
            // 
            this.dateTimePickerDateDelivery.Location = new System.Drawing.Point(257, 82);
            this.dateTimePickerDateDelivery.Name = "dateTimePickerDateDelivery";
            this.dateTimePickerDateDelivery.Size = new System.Drawing.Size(207, 20);
            this.dateTimePickerDateDelivery.TabIndex = 5;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(729, 306);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(101, 35);
            this.buttonCancel.TabIndex = 32;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.button6_Click);
            // 
            // SaleHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 348);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.dateTimePickerDateDelivery);
            this.Controls.Add(this.dateTimePickerDateOrdered);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxProductID);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelProductID);
            this.Controls.Add(this.labelDateDelivery);
            this.Controls.Add(this.labelDateOrdered);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.label1);
            this.Name = "SaleHistory";
            this.Text = "SaleHistory";
            this.Load += new System.EventHandler(this.SaleHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Label labelDateOrdered;
        private System.Windows.Forms.Label labelDateDelivery;
        private System.Windows.Forms.Label labelProductID;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.TextBox textBoxProductID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOrdered;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDelivery;
        private System.Windows.Forms.Button buttonCancel;
    }
}