namespace RealEstateManagementSystem
{
    partial class MulkTuri
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
            stbl = new TextBox();
            label5 = new Label();
            label4 = new Label();
            restorebtn = new Button();
            tDGV = new DataGridView();
            dbtn = new Button();
            ubtn = new Button();
            resetbtn = new Button();
            sbtn = new Button();
            tntbl = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)tDGV).BeginInit();
            SuspendLayout();
            // 
            // stbl
            // 
            stbl.Location = new Point(337, 360);
            stbl.Name = "stbl";
            stbl.Size = new Size(302, 31);
            stbl.TabIndex = 35;
            stbl.TextChanged += stbl_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(260, 364);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 34;
            label5.Text = "Qidirish";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(20, 363);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 33;
            label4.Text = "Mulk Turlari Ro'yxati";
            // 
            // restorebtn
            // 
            restorebtn.BackColor = Color.White;
            restorebtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restorebtn.FlatStyle = FlatStyle.Flat;
            restorebtn.Location = new Point(687, 356);
            restorebtn.Name = "restorebtn";
            restorebtn.Size = new Size(147, 39);
            restorebtn.TabIndex = 32;
            restorebtn.Text = "Qayta Tiklash";
            restorebtn.UseVisualStyleBackColor = false;
            restorebtn.Click += restorebtn_Click;
            // 
            // tDGV
            // 
            tDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tDGV.Dock = DockStyle.Bottom;
            tDGV.Location = new Point(0, 401);
            tDGV.Name = "tDGV";
            tDGV.RowHeadersWidth = 51;
            tDGV.Size = new Size(881, 293);
            tDGV.TabIndex = 31;
            tDGV.CellContentClick += tDGV_CellContentClick_1;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Location = new Point(492, 215);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(147, 42);
            dbtn.TabIndex = 30;
            dbtn.Text = "O'chirish";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // ubtn
            // 
            ubtn.BackColor = Color.White;
            ubtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ubtn.FlatStyle = FlatStyle.Flat;
            ubtn.Location = new Point(298, 215);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(147, 42);
            ubtn.TabIndex = 28;
            ubtn.Text = "Yangilash";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.White;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Location = new Point(687, 215);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(147, 42);
            resetbtn.TabIndex = 29;
            resetbtn.Text = "Qayta O'rnatish";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // sbtn
            // 
            sbtn.BackColor = Color.White;
            sbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            sbtn.FlatStyle = FlatStyle.Flat;
            sbtn.Location = new Point(116, 215);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(147, 42);
            sbtn.TabIndex = 27;
            sbtn.Text = "Saqlash";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // tntbl
            // 
            tntbl.Location = new Point(298, 96);
            tntbl.Name = "tntbl";
            tntbl.Size = new Size(407, 31);
            tntbl.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(207, 99);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 25;
            label1.Text = "Mulk Turi";
            // 
            // MulkTuri
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 694);
            Controls.Add(stbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(restorebtn);
            Controls.Add(tDGV);
            Controls.Add(dbtn);
            Controls.Add(ubtn);
            Controls.Add(resetbtn);
            Controls.Add(sbtn);
            Controls.Add(tntbl);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MulkTuri";
            Text = "MulkTuri";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)tDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox stbl;
        private Label label5;
        private Label label4;
        private Button restorebtn;
        private DataGridView tDGV;
        private Button dbtn;
        private Button ubtn;
        private Button resetbtn;
        private Button sbtn;
        private TextBox tntbl;
        private Label label1;
    }
}