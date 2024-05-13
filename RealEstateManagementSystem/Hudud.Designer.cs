namespace FurnitureProductionManagementSystem
{
    partial class Product
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
            label1 = new Label();
            tntbl = new TextBox();
            sbtn = new Button();
            resetbtn = new Button();
            ubtn = new Button();
            dbtn = new Button();
            tDGV = new DataGridView();
            restorebtn = new Button();
            label4 = new Label();
            label5 = new Label();
            stbl = new TextBox();
            ((System.ComponentModel.ISupportInitialize)tDGV).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 91);
            label1.Name = "label1";
            label1.Size = new Size(116, 25);
            label1.TabIndex = 0;
            label1.Text = "Hudud Nomi";
            // 
            // tntbl
            // 
            tntbl.Location = new Point(290, 87);
            tntbl.Name = "tntbl";
            tntbl.Size = new Size(407, 31);
            tntbl.TabIndex = 1;
            // 
            // sbtn
            // 
            sbtn.BackColor = Color.White;
            sbtn.FlatAppearance.MouseOverBackColor = Color.Lime;
            sbtn.FlatStyle = FlatStyle.Flat;
            sbtn.Location = new Point(108, 213);
            sbtn.Name = "sbtn";
            sbtn.Size = new Size(147, 42);
            sbtn.TabIndex = 6;
            sbtn.Text = "Saqlash";
            sbtn.UseVisualStyleBackColor = false;
            sbtn.Click += sbtn_Click;
            // 
            // resetbtn
            // 
            resetbtn.BackColor = Color.White;
            resetbtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            resetbtn.FlatStyle = FlatStyle.Flat;
            resetbtn.Location = new Point(679, 213);
            resetbtn.Name = "resetbtn";
            resetbtn.Size = new Size(147, 42);
            resetbtn.TabIndex = 7;
            resetbtn.Text = "Qayta O'rnatish";
            resetbtn.UseVisualStyleBackColor = false;
            resetbtn.Click += resetbtn_Click;
            // 
            // ubtn
            // 
            ubtn.BackColor = Color.White;
            ubtn.FlatAppearance.MouseOverBackColor = Color.Yellow;
            ubtn.FlatStyle = FlatStyle.Flat;
            ubtn.Location = new Point(290, 213);
            ubtn.Name = "ubtn";
            ubtn.Size = new Size(147, 42);
            ubtn.TabIndex = 7;
            ubtn.Text = "Yangilash";
            ubtn.UseVisualStyleBackColor = false;
            ubtn.Click += ubtn_Click;
            // 
            // dbtn
            // 
            dbtn.BackColor = Color.White;
            dbtn.FlatAppearance.MouseOverBackColor = Color.Red;
            dbtn.FlatStyle = FlatStyle.Flat;
            dbtn.Location = new Point(484, 213);
            dbtn.Name = "dbtn";
            dbtn.Size = new Size(147, 42);
            dbtn.TabIndex = 8;
            dbtn.Text = "O'chirish";
            dbtn.UseVisualStyleBackColor = false;
            dbtn.Click += dbtn_Click;
            // 
            // tDGV
            // 
            tDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tDGV.Dock = DockStyle.Bottom;
            tDGV.Location = new Point(0, 385);
            tDGV.Name = "tDGV";
            tDGV.RowHeadersWidth = 51;
            tDGV.Size = new Size(881, 309);
            tDGV.TabIndex = 9;
            tDGV.CellContentClick += pDGV_CellContentClick;
            // 
            // restorebtn
            // 
            restorebtn.BackColor = Color.White;
            restorebtn.FlatAppearance.MouseOverBackColor = Color.Cyan;
            restorebtn.FlatStyle = FlatStyle.Flat;
            restorebtn.Location = new Point(679, 340);
            restorebtn.Name = "restorebtn";
            restorebtn.Size = new Size(147, 39);
            restorebtn.TabIndex = 10;
            restorebtn.Text = "Qayta Tiklash";
            restorebtn.UseVisualStyleBackColor = false;
            restorebtn.Click += restorebtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 347);
            label4.Name = "label4";
            label4.Size = new Size(171, 28);
            label4.TabIndex = 11;
            label4.Text = "Hududlar Ro'yxati";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 348);
            label5.Name = "label5";
            label5.Size = new Size(73, 25);
            label5.TabIndex = 12;
            label5.Text = "Qidirish";
            // 
            // stbl
            // 
            stbl.Location = new Point(329, 344);
            stbl.Name = "stbl";
            stbl.Size = new Size(302, 31);
            stbl.TabIndex = 13;
            stbl.TextChanged += stbl_TextChanged;
            // 
            // Product
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
            Name = "Product";
            Text = "Product";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)tDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tntbl;
        private Button sbtn;
        private Button resetbtn;
        private Button ubtn;
        private Button dbtn;
        private DataGridView tDGV;
        private Button restorebtn;
        private Label label4;
        private Label label5;
        private TextBox stbl;
    }
}