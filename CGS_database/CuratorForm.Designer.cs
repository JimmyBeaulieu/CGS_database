namespace CGS_database
{
    partial class CuratorForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.curatorIDTextBox = new System.Windows.Forms.TextBox();
            this.curatorFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.curatorLastNameTextBox = new System.Windows.Forms.TextBox();
            this.curatorCommissionTextBox = new System.Windows.Forms.TextBox();
            this.displayBtn = new System.Windows.Forms.Button();
            this.insertBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curator ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Commission:";
            // 
            // curatorIDTextBox
            // 
            this.curatorIDTextBox.BackColor = System.Drawing.Color.Olive;
            this.curatorIDTextBox.Location = new System.Drawing.Point(338, 50);
            this.curatorIDTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorIDTextBox.Name = "curatorIDTextBox";
            this.curatorIDTextBox.Size = new System.Drawing.Size(155, 20);
            this.curatorIDTextBox.TabIndex = 4;
            // 
            // curatorFirstNameTextBox
            // 
            this.curatorFirstNameTextBox.BackColor = System.Drawing.Color.Purple;
            this.curatorFirstNameTextBox.Location = new System.Drawing.Point(338, 96);
            this.curatorFirstNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorFirstNameTextBox.Name = "curatorFirstNameTextBox";
            this.curatorFirstNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.curatorFirstNameTextBox.TabIndex = 5;
            // 
            // curatorLastNameTextBox
            // 
            this.curatorLastNameTextBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.curatorLastNameTextBox.Location = new System.Drawing.Point(338, 146);
            this.curatorLastNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorLastNameTextBox.Name = "curatorLastNameTextBox";
            this.curatorLastNameTextBox.Size = new System.Drawing.Size(155, 20);
            this.curatorLastNameTextBox.TabIndex = 6;
            // 
            // curatorCommissionTextBox
            // 
            this.curatorCommissionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.curatorCommissionTextBox.Location = new System.Drawing.Point(338, 192);
            this.curatorCommissionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.curatorCommissionTextBox.Name = "curatorCommissionTextBox";
            this.curatorCommissionTextBox.Size = new System.Drawing.Size(155, 20);
            this.curatorCommissionTextBox.TabIndex = 7;
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(39, 286);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(2);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(93, 32);
            this.displayBtn.TabIndex = 8;
            this.displayBtn.Text = "DISPLAY";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(39, 342);
            this.insertBtn.Margin = new System.Windows.Forms.Padding(2);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(93, 32);
            this.insertBtn.TabIndex = 9;
            this.insertBtn.Text = "INSERT";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(39, 399);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(93, 32);
            this.updateBtn.TabIndex = 10;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(39, 462);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(93, 32);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "DELETE";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(39, 523);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(93, 32);
            this.searchBtn.TabIndex = 12;
            this.searchBtn.Text = "SEARCH";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Lime;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(201, 286);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(512, 264);
            this.dataGridView1.TabIndex = 13;
            // 
            // CuratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(764, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.curatorCommissionTextBox);
            this.Controls.Add(this.curatorLastNameTextBox);
            this.Controls.Add(this.curatorFirstNameTextBox);
            this.Controls.Add(this.curatorIDTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CuratorForm";
            this.Text = "Curator Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox curatorIDTextBox;
        private System.Windows.Forms.TextBox curatorFirstNameTextBox;
        private System.Windows.Forms.TextBox curatorLastNameTextBox;
        private System.Windows.Forms.TextBox curatorCommissionTextBox;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

