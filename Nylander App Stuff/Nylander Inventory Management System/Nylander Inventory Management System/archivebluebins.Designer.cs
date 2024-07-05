namespace Nylander_Inventory_Management_System
{
    partial class archivebluebins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(archivebluebins));
            this.button1 = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.datecollectedbox = new System.Windows.Forms.DateTimePicker();
            this.bluebininvdata = new System.Windows.Forms.DataGridView();
            this.submitbutton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.DateTimePicker();
            this.empidbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.quantitybox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.siteregionbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sitestatebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sitetownbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.collectorbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.speciesbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genusbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.catalogidbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.searchbutton = new System.Windows.Forms.Button();
            this.bluebinsearchbox = new System.Windows.Forms.TextBox();
            this.bluebinsearchdata = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluebininvdata)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluebinsearchdata)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(706, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home Page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // refresh
            // 
            this.refresh.Image = ((System.Drawing.Image)(resources.GetObject("refresh.Image")));
            this.refresh.Location = new System.Drawing.Point(678, 6);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(22, 23);
            this.refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.refresh.TabIndex = 0;
            this.refresh.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 504);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.datecollectedbox);
            this.tabPage1.Controls.Add(this.bluebininvdata);
            this.tabPage1.Controls.Add(this.submitbutton);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.datebox);
            this.tabPage1.Controls.Add(this.empidbox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.quantitybox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.siteregionbox);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.sitestatebox);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.sitetownbox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.collectorbox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.speciesbox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.genusbox);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.catalogidbox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Specimen";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(227, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Date  Collected:";
            // 
            // datecollectedbox
            // 
            this.datecollectedbox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datecollectedbox.Location = new System.Drawing.Point(346, 151);
            this.datecollectedbox.Name = "datecollectedbox";
            this.datecollectedbox.Size = new System.Drawing.Size(112, 22);
            this.datecollectedbox.TabIndex = 24;
            // 
            // bluebininvdata
            // 
            this.bluebininvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bluebininvdata.Location = new System.Drawing.Point(9, 234);
            this.bluebininvdata.Name = "bluebininvdata";
            this.bluebininvdata.RowHeadersWidth = 51;
            this.bluebininvdata.RowTemplate.Height = 24;
            this.bluebininvdata.Size = new System.Drawing.Size(753, 235);
            this.bluebininvdata.TabIndex = 23;
            // 
            // submitbutton
            // 
            this.submitbutton.Location = new System.Drawing.Point(357, 192);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(75, 23);
            this.submitbutton.TabIndex = 22;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label11.Location = new System.Drawing.Point(488, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Date :";
            // 
            // datebox
            // 
            this.datebox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datebox.Location = new System.Drawing.Point(541, 152);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(112, 22);
            this.datebox.TabIndex = 20;
            // 
            // empidbox
            // 
            this.empidbox.Location = new System.Drawing.Point(112, 151);
            this.empidbox.Name = "empidbox";
            this.empidbox.Size = new System.Drawing.Size(100, 22);
            this.empidbox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label10.Location = new System.Drawing.Point(6, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Employee ID :";
            // 
            // quantitybox
            // 
            this.quantitybox.Location = new System.Drawing.Point(461, 63);
            this.quantitybox.Name = "quantitybox";
            this.quantitybox.Size = new System.Drawing.Size(100, 22);
            this.quantitybox.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(385, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantity :";
            // 
            // siteregionbox
            // 
            this.siteregionbox.Location = new System.Drawing.Point(423, 109);
            this.siteregionbox.Name = "siteregionbox";
            this.siteregionbox.Size = new System.Drawing.Size(100, 22);
            this.siteregionbox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.Location = new System.Drawing.Point(354, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Region :";
            // 
            // sitestatebox
            // 
            this.sitestatebox.Location = new System.Drawing.Point(239, 109);
            this.sitestatebox.Name = "sitestatebox";
            this.sitestatebox.Size = new System.Drawing.Size(100, 22);
            this.sitestatebox.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label7.Location = new System.Drawing.Point(183, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "State :";
            // 
            // sitetownbox
            // 
            this.sitetownbox.Location = new System.Drawing.Point(65, 109);
            this.sitetownbox.Name = "sitetownbox";
            this.sitetownbox.Size = new System.Drawing.Size(100, 22);
            this.sitetownbox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Town :";
            // 
            // collectorbox
            // 
            this.collectorbox.Location = new System.Drawing.Point(300, 17);
            this.collectorbox.Name = "collectorbox";
            this.collectorbox.Size = new System.Drawing.Size(100, 22);
            this.collectorbox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(218, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Collector :";
            // 
            // speciesbox
            // 
            this.speciesbox.Location = new System.Drawing.Point(269, 63);
            this.speciesbox.Name = "speciesbox";
            this.speciesbox.Size = new System.Drawing.Size(100, 22);
            this.speciesbox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(194, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Species :";
            // 
            // genusbox
            // 
            this.genusbox.Location = new System.Drawing.Point(72, 62);
            this.genusbox.Name = "genusbox";
            this.genusbox.Size = new System.Drawing.Size(100, 22);
            this.genusbox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genus :";
            // 
            // catalogidbox
            // 
            this.catalogidbox.Location = new System.Drawing.Point(97, 17);
            this.catalogidbox.Name = "catalogidbox";
            this.catalogidbox.Size = new System.Drawing.Size(100, 22);
            this.catalogidbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catalog ID :";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Update Specimen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.searchbutton);
            this.tabPage3.Controls.Add(this.bluebinsearchbox);
            this.tabPage3.Controls.Add(this.bluebinsearchdata);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Search";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(270, 16);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 30);
            this.searchbutton.TabIndex = 7;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            // 
            // bluebinsearchbox
            // 
            this.bluebinsearchbox.Location = new System.Drawing.Point(6, 18);
            this.bluebinsearchbox.Name = "bluebinsearchbox";
            this.bluebinsearchbox.Size = new System.Drawing.Size(257, 22);
            this.bluebinsearchbox.TabIndex = 6;
            // 
            // bluebinsearchdata
            // 
            this.bluebinsearchdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bluebinsearchdata.Location = new System.Drawing.Point(6, 69);
            this.bluebinsearchdata.Name = "bluebinsearchdata";
            this.bluebinsearchdata.RowHeadersWidth = 51;
            this.bluebinsearchdata.RowTemplate.Height = 24;
            this.bluebinsearchdata.Size = new System.Drawing.Size(756, 400);
            this.bluebinsearchdata.TabIndex = 5;
            // 
            // archivebluebins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 526);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "archivebluebins";
            this.Text = "Nylander Inventory Management System - Blue Bins";
            ((System.ComponentModel.ISupportInitialize)(this.refresh)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluebininvdata)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bluebinsearchdata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox refresh;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker datecollectedbox;
        private System.Windows.Forms.DataGridView bluebininvdata;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker datebox;
        private System.Windows.Forms.TextBox empidbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox quantitybox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox siteregionbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sitestatebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox sitetownbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox collectorbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox speciesbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genusbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox catalogidbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView bluebinsearchdata;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox bluebinsearchbox;
    }
}