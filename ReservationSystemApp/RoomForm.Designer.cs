namespace ReservationSystemApp
{
    partial class RoomForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.priceTxtBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textAddName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkActive = new System.Windows.Forms.CheckBox();
            this.upNameTxtBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.updatePriceTxtBox = new System.Windows.Forms.TextBox();
            this.updatePriceLbl = new System.Windows.Forms.Label();
            this.updateNameTxtBox = new System.Windows.Forms.TextBox();
            this.updateNameLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.priceTxtBox);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.textAddName);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Location = new System.Drawing.Point(39, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(137, 89);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // priceTxtBox
            // 
            this.priceTxtBox.Location = new System.Drawing.Point(48, 53);
            this.priceTxtBox.Name = "priceTxtBox";
            this.priceTxtBox.Size = new System.Drawing.Size(164, 20);
            this.priceTxtBox.TabIndex = 3;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(7, 59);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Price";
            // 
            // textAddName
            // 
            this.textAddName.Location = new System.Drawing.Point(48, 27);
            this.textAddName.Name = "textAddName";
            this.textAddName.Size = new System.Drawing.Size(164, 20);
            this.textAddName.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(7, 30);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkActive);
            this.groupBox2.Controls.Add(this.upNameTxtBox);
            this.groupBox2.Controls.Add(this.IdTextBox);
            this.groupBox2.Controls.Add(this.IdLabel);
            this.groupBox2.Controls.Add(this.updateButton);
            this.groupBox2.Controls.Add(this.updatePriceTxtBox);
            this.groupBox2.Controls.Add(this.updatePriceLbl);
            this.groupBox2.Controls.Add(this.updateNameTxtBox);
            this.groupBox2.Controls.Add(this.updateNameLbl);
            this.groupBox2.Location = new System.Drawing.Point(467, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 160);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // checkActive
            // 
            this.checkActive.AutoSize = true;
            this.checkActive.Location = new System.Drawing.Point(58, 97);
            this.checkActive.Name = "checkActive";
            this.checkActive.Size = new System.Drawing.Size(67, 17);
            this.checkActive.TabIndex = 8;
            this.checkActive.Text = "Is Active";
            this.checkActive.UseVisualStyleBackColor = true;
            // 
            // upNameTxtBox
            // 
            this.upNameTxtBox.Location = new System.Drawing.Point(58, 45);
            this.upNameTxtBox.Name = "upNameTxtBox";
            this.upNameTxtBox.Size = new System.Drawing.Size(164, 20);
            this.upNameTxtBox.TabIndex = 7;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(58, 19);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(164, 20);
            this.IdTextBox.TabIndex = 6;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(17, 22);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 13);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "Id";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(147, 125);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // updatePriceTxtBox
            // 
            this.updatePriceTxtBox.Location = new System.Drawing.Point(58, 71);
            this.updatePriceTxtBox.Name = "updatePriceTxtBox";
            this.updatePriceTxtBox.Size = new System.Drawing.Size(164, 20);
            this.updatePriceTxtBox.TabIndex = 3;
            // 
            // updatePriceLbl
            // 
            this.updatePriceLbl.AutoSize = true;
            this.updatePriceLbl.Location = new System.Drawing.Point(17, 77);
            this.updatePriceLbl.Name = "updatePriceLbl";
            this.updatePriceLbl.Size = new System.Drawing.Size(31, 13);
            this.updatePriceLbl.TabIndex = 2;
            this.updatePriceLbl.Text = "Price";
            // 
            // updateNameTxtBox
            // 
            this.updateNameTxtBox.Location = new System.Drawing.Point(58, 45);
            this.updateNameTxtBox.Name = "updateNameTxtBox";
            this.updateNameTxtBox.Size = new System.Drawing.Size(164, 20);
            this.updateNameTxtBox.TabIndex = 1;
            // 
            // updateNameLbl
            // 
            this.updateNameLbl.AutoSize = true;
            this.updateNameLbl.Location = new System.Drawing.Point(17, 48);
            this.updateNameLbl.Name = "updateNameLbl";
            this.updateNameLbl.Size = new System.Drawing.Size(35, 13);
            this.updateNameLbl.TabIndex = 0;
            this.updateNameLbl.Text = "Name";
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox priceTxtBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox textAddName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox updatePriceTxtBox;
        private System.Windows.Forms.Label updatePriceLbl;
        private System.Windows.Forms.TextBox updateNameTxtBox;
        private System.Windows.Forms.Label updateNameLbl;
        private System.Windows.Forms.CheckBox checkActive;
        private System.Windows.Forms.TextBox upNameTxtBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
    }
}