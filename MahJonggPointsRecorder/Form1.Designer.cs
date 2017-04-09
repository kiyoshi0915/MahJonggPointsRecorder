namespace 麻雀点数記録装置
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKyoku = new System.Windows.Forms.Label();
            this.lblHonba = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReachBar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtP1_Name = new System.Windows.Forms.TextBox();
            this.txtP2_Name = new System.Windows.Forms.TextBox();
            this.txtP3_Name = new System.Windows.Forms.TextBox();
            this.txtP4_Name = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnP1_Reach = new System.Windows.Forms.Button();
            this.txtP1_Point = new System.Windows.Forms.TextBox();
            this.txtP2_Point = new System.Windows.Forms.TextBox();
            this.txtP3_Point = new System.Windows.Forms.TextBox();
            this.txtP4_Point = new System.Windows.Forms.TextBox();
            this.btnP2_Reach = new System.Windows.Forms.Button();
            this.btnP3_Reach = new System.Windows.Forms.Button();
            this.btnP4_Reach = new System.Windows.Forms.Button();
            this.lblP1_Oya = new System.Windows.Forms.Label();
            this.lblP2_Oya = new System.Windows.Forms.Label();
            this.lblP3_Oya = new System.Windows.Forms.Label();
            this.lblP4_Oya = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoP1_Agari = new System.Windows.Forms.RadioButton();
            this.rdoP4_Agari = new System.Windows.Forms.RadioButton();
            this.rdoP3_Agari = new System.Windows.Forms.RadioButton();
            this.rdoP2_Agari = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoP4_Hoju = new System.Windows.Forms.RadioButton();
            this.rdoP3_Hoju = new System.Windows.Forms.RadioButton();
            this.rdoP2_Hoju = new System.Windows.Forms.RadioButton();
            this.rdoP1_Hoju = new System.Windows.Forms.RadioButton();
            this.drpFan = new System.Windows.Forms.ComboBox();
            this.drpFu = new System.Windows.Forms.ComboBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.lblGameEnd = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblGameIdx = new System.Windows.Forms.Label();
            this.lblPrevWho = new System.Windows.Forms.Label();
            this.lblPrevFromMain = new System.Windows.Forms.Label();
            this.lblPrevFromKo = new System.Windows.Forms.Label();
            this.lblPrevWho_PointSum = new System.Windows.Forms.Label();
            this.lblPrevFromMain_Point = new System.Windows.Forms.Label();
            this.lblPrevFromKo_Point = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblPrevReachBarPoint = new System.Windows.Forms.Label();
            this.lblPrevSyukugiPoint = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnPointFix = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(172, 424);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(112, 31);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "計算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 444);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // lblKyoku
            // 
            this.lblKyoku.AutoSize = true;
            this.lblKyoku.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKyoku.Location = new System.Drawing.Point(25, 15);
            this.lblKyoku.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKyoku.Name = "lblKyoku";
            this.lblKyoku.Size = new System.Drawing.Size(96, 27);
            this.lblKyoku.TabIndex = 2;
            this.lblKyoku.Text = "東一局";
            // 
            // lblHonba
            // 
            this.lblHonba.AutoSize = true;
            this.lblHonba.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblHonba.Location = new System.Drawing.Point(182, 15);
            this.lblHonba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHonba.Name = "lblHonba";
            this.lblHonba.Size = new System.Drawing.Size(87, 27);
            this.lblHonba.TabIndex = 2;
            this.lblHonba.Text = "１本場";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(325, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "リー棒";
            // 
            // lblReachBar
            // 
            this.lblReachBar.AutoSize = true;
            this.lblReachBar.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblReachBar.Location = new System.Drawing.Point(413, 15);
            this.lblReachBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReachBar.Name = "lblReachBar";
            this.lblReachBar.Size = new System.Drawing.Size(59, 27);
            this.lblReachBar.TabIndex = 2;
            this.lblReachBar.Text = "１本";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(66, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "名前";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(49, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "持ち点";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(66, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "リーチ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(74, 239);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "誰が";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(15, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "誰から/ツモ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(66, 323);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "飜数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(205, 69);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "東";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(375, 69);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "南";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(545, 69);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 22);
            this.label10.TabIndex = 2;
            this.label10.Text = "西";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(715, 69);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 22);
            this.label11.TabIndex = 2;
            this.label11.Text = "北";
            // 
            // txtP1_Name
            // 
            this.txtP1_Name.Location = new System.Drawing.Point(175, 106);
            this.txtP1_Name.Name = "txtP1_Name";
            this.txtP1_Name.Size = new System.Drawing.Size(112, 23);
            this.txtP1_Name.TabIndex = 1;
            this.txtP1_Name.Text = "山田　太郎";
            this.txtP1_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP2_Name
            // 
            this.txtP2_Name.Location = new System.Drawing.Point(345, 106);
            this.txtP2_Name.Name = "txtP2_Name";
            this.txtP2_Name.Size = new System.Drawing.Size(112, 23);
            this.txtP2_Name.TabIndex = 2;
            this.txtP2_Name.Text = "佐藤　次郎";
            this.txtP2_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP3_Name
            // 
            this.txtP3_Name.Location = new System.Drawing.Point(515, 106);
            this.txtP3_Name.Name = "txtP3_Name";
            this.txtP3_Name.Size = new System.Drawing.Size(112, 23);
            this.txtP3_Name.TabIndex = 3;
            this.txtP3_Name.Text = "鈴木　三郎";
            this.txtP3_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP4_Name
            // 
            this.txtP4_Name.Location = new System.Drawing.Point(685, 106);
            this.txtP4_Name.Name = "txtP4_Name";
            this.txtP4_Name.Size = new System.Drawing.Size(112, 23);
            this.txtP4_Name.TabIndex = 4;
            this.txtP4_Name.Text = "伊藤　四朗";
            this.txtP4_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(66, 366);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "符数";
            // 
            // btnP1_Reach
            // 
            this.btnP1_Reach.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnP1_Reach.Location = new System.Drawing.Point(175, 191);
            this.btnP1_Reach.Name = "btnP1_Reach";
            this.btnP1_Reach.Size = new System.Drawing.Size(112, 24);
            this.btnP1_Reach.TabIndex = 9;
            this.btnP1_Reach.Text = "リーチ";
            this.btnP1_Reach.UseVisualStyleBackColor = true;
            // 
            // txtP1_Point
            // 
            this.txtP1_Point.BackColor = System.Drawing.SystemColors.Window;
            this.txtP1_Point.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtP1_Point.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtP1_Point.Location = new System.Drawing.Point(175, 142);
            this.txtP1_Point.Name = "txtP1_Point";
            this.txtP1_Point.ReadOnly = true;
            this.txtP1_Point.Size = new System.Drawing.Size(112, 31);
            this.txtP1_Point.TabIndex = 5;
            this.txtP1_Point.Text = "100000";
            this.txtP1_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP2_Point
            // 
            this.txtP2_Point.BackColor = System.Drawing.SystemColors.Window;
            this.txtP2_Point.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtP2_Point.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtP2_Point.Location = new System.Drawing.Point(345, 142);
            this.txtP2_Point.Name = "txtP2_Point";
            this.txtP2_Point.ReadOnly = true;
            this.txtP2_Point.Size = new System.Drawing.Size(112, 31);
            this.txtP2_Point.TabIndex = 6;
            this.txtP2_Point.Text = "100000";
            this.txtP2_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP3_Point
            // 
            this.txtP3_Point.BackColor = System.Drawing.SystemColors.Window;
            this.txtP3_Point.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtP3_Point.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtP3_Point.Location = new System.Drawing.Point(515, 142);
            this.txtP3_Point.Name = "txtP3_Point";
            this.txtP3_Point.ReadOnly = true;
            this.txtP3_Point.Size = new System.Drawing.Size(112, 31);
            this.txtP3_Point.TabIndex = 7;
            this.txtP3_Point.Text = "100000";
            this.txtP3_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP4_Point
            // 
            this.txtP4_Point.BackColor = System.Drawing.SystemColors.Window;
            this.txtP4_Point.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtP4_Point.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtP4_Point.Location = new System.Drawing.Point(685, 142);
            this.txtP4_Point.Name = "txtP4_Point";
            this.txtP4_Point.ReadOnly = true;
            this.txtP4_Point.Size = new System.Drawing.Size(112, 31);
            this.txtP4_Point.TabIndex = 8;
            this.txtP4_Point.Text = "100000";
            this.txtP4_Point.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnP2_Reach
            // 
            this.btnP2_Reach.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnP2_Reach.Location = new System.Drawing.Point(345, 191);
            this.btnP2_Reach.Name = "btnP2_Reach";
            this.btnP2_Reach.Size = new System.Drawing.Size(112, 24);
            this.btnP2_Reach.TabIndex = 10;
            this.btnP2_Reach.Text = "リーチ";
            this.btnP2_Reach.UseVisualStyleBackColor = true;
            // 
            // btnP3_Reach
            // 
            this.btnP3_Reach.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnP3_Reach.Location = new System.Drawing.Point(515, 191);
            this.btnP3_Reach.Name = "btnP3_Reach";
            this.btnP3_Reach.Size = new System.Drawing.Size(112, 24);
            this.btnP3_Reach.TabIndex = 11;
            this.btnP3_Reach.Text = "リーチ";
            this.btnP3_Reach.UseVisualStyleBackColor = true;
            // 
            // btnP4_Reach
            // 
            this.btnP4_Reach.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnP4_Reach.Location = new System.Drawing.Point(685, 191);
            this.btnP4_Reach.Name = "btnP4_Reach";
            this.btnP4_Reach.Size = new System.Drawing.Size(112, 24);
            this.btnP4_Reach.TabIndex = 12;
            this.btnP4_Reach.Text = "リーチ";
            this.btnP4_Reach.UseVisualStyleBackColor = true;
            // 
            // lblP1_Oya
            // 
            this.lblP1_Oya.AutoSize = true;
            this.lblP1_Oya.BackColor = System.Drawing.Color.Lime;
            this.lblP1_Oya.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblP1_Oya.ForeColor = System.Drawing.Color.Red;
            this.lblP1_Oya.Location = new System.Drawing.Point(245, 69);
            this.lblP1_Oya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP1_Oya.Name = "lblP1_Oya";
            this.lblP1_Oya.Size = new System.Drawing.Size(33, 22);
            this.lblP1_Oya.TabIndex = 2;
            this.lblP1_Oya.Text = "親";
            // 
            // lblP2_Oya
            // 
            this.lblP2_Oya.AutoSize = true;
            this.lblP2_Oya.BackColor = System.Drawing.Color.Lime;
            this.lblP2_Oya.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblP2_Oya.ForeColor = System.Drawing.Color.Red;
            this.lblP2_Oya.Location = new System.Drawing.Point(415, 69);
            this.lblP2_Oya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP2_Oya.Name = "lblP2_Oya";
            this.lblP2_Oya.Size = new System.Drawing.Size(33, 22);
            this.lblP2_Oya.TabIndex = 2;
            this.lblP2_Oya.Text = "親";
            // 
            // lblP3_Oya
            // 
            this.lblP3_Oya.AutoSize = true;
            this.lblP3_Oya.BackColor = System.Drawing.Color.Lime;
            this.lblP3_Oya.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblP3_Oya.ForeColor = System.Drawing.Color.Red;
            this.lblP3_Oya.Location = new System.Drawing.Point(585, 69);
            this.lblP3_Oya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP3_Oya.Name = "lblP3_Oya";
            this.lblP3_Oya.Size = new System.Drawing.Size(33, 22);
            this.lblP3_Oya.TabIndex = 2;
            this.lblP3_Oya.Text = "親";
            // 
            // lblP4_Oya
            // 
            this.lblP4_Oya.AutoSize = true;
            this.lblP4_Oya.BackColor = System.Drawing.Color.Lime;
            this.lblP4_Oya.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblP4_Oya.ForeColor = System.Drawing.Color.Red;
            this.lblP4_Oya.Location = new System.Drawing.Point(755, 69);
            this.lblP4_Oya.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP4_Oya.Name = "lblP4_Oya";
            this.lblP4_Oya.Size = new System.Drawing.Size(33, 22);
            this.lblP4_Oya.TabIndex = 2;
            this.lblP4_Oya.Text = "親";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoP1_Agari);
            this.panel1.Controls.Add(this.rdoP4_Agari);
            this.panel1.Controls.Add(this.rdoP3_Agari);
            this.panel1.Controls.Add(this.rdoP2_Agari);
            this.panel1.Location = new System.Drawing.Point(175, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 38);
            this.panel1.TabIndex = 7;
            // 
            // rdoP1_Agari
            // 
            this.rdoP1_Agari.AutoSize = true;
            this.rdoP1_Agari.Checked = true;
            this.rdoP1_Agari.Location = new System.Drawing.Point(7, 10);
            this.rdoP1_Agari.Name = "rdoP1_Agari";
            this.rdoP1_Agari.Size = new System.Drawing.Size(55, 20);
            this.rdoP1_Agari.TabIndex = 13;
            this.rdoP1_Agari.TabStop = true;
            this.rdoP1_Agari.Text = "東が";
            this.rdoP1_Agari.UseVisualStyleBackColor = true;
            // 
            // rdoP4_Agari
            // 
            this.rdoP4_Agari.AutoSize = true;
            this.rdoP4_Agari.Location = new System.Drawing.Point(517, 10);
            this.rdoP4_Agari.Name = "rdoP4_Agari";
            this.rdoP4_Agari.Size = new System.Drawing.Size(55, 20);
            this.rdoP4_Agari.TabIndex = 16;
            this.rdoP4_Agari.TabStop = true;
            this.rdoP4_Agari.Text = "北が";
            this.rdoP4_Agari.UseVisualStyleBackColor = true;
            // 
            // rdoP3_Agari
            // 
            this.rdoP3_Agari.AutoSize = true;
            this.rdoP3_Agari.Location = new System.Drawing.Point(347, 10);
            this.rdoP3_Agari.Name = "rdoP3_Agari";
            this.rdoP3_Agari.Size = new System.Drawing.Size(55, 20);
            this.rdoP3_Agari.TabIndex = 15;
            this.rdoP3_Agari.TabStop = true;
            this.rdoP3_Agari.Text = "西が";
            this.rdoP3_Agari.UseVisualStyleBackColor = true;
            // 
            // rdoP2_Agari
            // 
            this.rdoP2_Agari.AutoSize = true;
            this.rdoP2_Agari.Location = new System.Drawing.Point(177, 10);
            this.rdoP2_Agari.Name = "rdoP2_Agari";
            this.rdoP2_Agari.Size = new System.Drawing.Size(55, 20);
            this.rdoP2_Agari.TabIndex = 14;
            this.rdoP2_Agari.TabStop = true;
            this.rdoP2_Agari.Text = "南が";
            this.rdoP2_Agari.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoP4_Hoju);
            this.panel2.Controls.Add(this.rdoP3_Hoju);
            this.panel2.Controls.Add(this.rdoP2_Hoju);
            this.panel2.Controls.Add(this.rdoP1_Hoju);
            this.panel2.Location = new System.Drawing.Point(175, 272);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(622, 39);
            this.panel2.TabIndex = 7;
            // 
            // rdoP4_Hoju
            // 
            this.rdoP4_Hoju.AutoSize = true;
            this.rdoP4_Hoju.Location = new System.Drawing.Point(517, 10);
            this.rdoP4_Hoju.Name = "rdoP4_Hoju";
            this.rdoP4_Hoju.Size = new System.Drawing.Size(66, 20);
            this.rdoP4_Hoju.TabIndex = 20;
            this.rdoP4_Hoju.TabStop = true;
            this.rdoP4_Hoju.Text = "北から";
            this.rdoP4_Hoju.UseVisualStyleBackColor = true;
            // 
            // rdoP3_Hoju
            // 
            this.rdoP3_Hoju.AutoSize = true;
            this.rdoP3_Hoju.Location = new System.Drawing.Point(347, 10);
            this.rdoP3_Hoju.Name = "rdoP3_Hoju";
            this.rdoP3_Hoju.Size = new System.Drawing.Size(66, 20);
            this.rdoP3_Hoju.TabIndex = 19;
            this.rdoP3_Hoju.TabStop = true;
            this.rdoP3_Hoju.Text = "西から";
            this.rdoP3_Hoju.UseVisualStyleBackColor = true;
            // 
            // rdoP2_Hoju
            // 
            this.rdoP2_Hoju.AutoSize = true;
            this.rdoP2_Hoju.Location = new System.Drawing.Point(177, 10);
            this.rdoP2_Hoju.Name = "rdoP2_Hoju";
            this.rdoP2_Hoju.Size = new System.Drawing.Size(66, 20);
            this.rdoP2_Hoju.TabIndex = 18;
            this.rdoP2_Hoju.TabStop = true;
            this.rdoP2_Hoju.Text = "南から";
            this.rdoP2_Hoju.UseVisualStyleBackColor = true;
            // 
            // rdoP1_Hoju
            // 
            this.rdoP1_Hoju.AutoSize = true;
            this.rdoP1_Hoju.Checked = true;
            this.rdoP1_Hoju.Location = new System.Drawing.Point(7, 10);
            this.rdoP1_Hoju.Name = "rdoP1_Hoju";
            this.rdoP1_Hoju.Size = new System.Drawing.Size(50, 20);
            this.rdoP1_Hoju.TabIndex = 17;
            this.rdoP1_Hoju.TabStop = true;
            this.rdoP1_Hoju.Text = "ツモ";
            this.rdoP1_Hoju.UseVisualStyleBackColor = true;
            // 
            // drpFan
            // 
            this.drpFan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpFan.FormattingEnabled = true;
            this.drpFan.Items.AddRange(new object[] {
            "１飜",
            "２飜",
            "３飜",
            "４飜",
            "５飜",
            "６～７飜",
            "８～１０飜",
            "１１～１２飜",
            "１３飜以上"});
            this.drpFan.Location = new System.Drawing.Point(172, 324);
            this.drpFan.Name = "drpFan";
            this.drpFan.Size = new System.Drawing.Size(155, 24);
            this.drpFan.TabIndex = 21;
            // 
            // drpFu
            // 
            this.drpFu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpFu.FormattingEnabled = true;
            this.drpFu.Items.AddRange(new object[] {
            "２０符",
            "２５符(七対子)",
            "３０符",
            "４０符",
            "５０符",
            "６０符",
            "７０符"});
            this.drpFu.Location = new System.Drawing.Point(172, 367);
            this.drpFu.Name = "drpFu";
            this.drpFu.Size = new System.Drawing.Size(155, 24);
            this.drpFu.TabIndex = 22;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(19, 414);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // lblGameEnd
            // 
            this.lblGameEnd.AutoSize = true;
            this.lblGameEnd.BackColor = System.Drawing.Color.Lime;
            this.lblGameEnd.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblGameEnd.ForeColor = System.Drawing.Color.Red;
            this.lblGameEnd.Location = new System.Drawing.Point(548, 15);
            this.lblGameEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameEnd.Name = "lblGameEnd";
            this.lblGameEnd.Size = new System.Drawing.Size(172, 34);
            this.lblGameEnd.TabIndex = 2;
            this.lblGameEnd.Text = "ゲーム終了";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(621, 432);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 23;
            this.btnPrev.Text = "戻る";
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(702, 432);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 24;
            this.btnNext.Text = "進む";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // lblGameIdx
            // 
            this.lblGameIdx.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblGameIdx.Location = new System.Drawing.Point(521, 432);
            this.lblGameIdx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameIdx.Name = "lblGameIdx";
            this.lblGameIdx.Size = new System.Drawing.Size(93, 27);
            this.lblGameIdx.TabIndex = 2;
            this.lblGameIdx.Text = "９９９９戦目";
            this.lblGameIdx.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevWho
            // 
            this.lblPrevWho.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevWho.Location = new System.Drawing.Point(26, 19);
            this.lblPrevWho.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevWho.Name = "lblPrevWho";
            this.lblPrevWho.Size = new System.Drawing.Size(79, 27);
            this.lblPrevWho.TabIndex = 2;
            this.lblPrevWho.Text = "東が";
            this.lblPrevWho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevFromMain
            // 
            this.lblPrevFromMain.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevFromMain.Location = new System.Drawing.Point(26, 46);
            this.lblPrevFromMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevFromMain.Name = "lblPrevFromMain";
            this.lblPrevFromMain.Size = new System.Drawing.Size(79, 27);
            this.lblPrevFromMain.TabIndex = 2;
            this.lblPrevFromMain.Text = "南（親）から";
            this.lblPrevFromMain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevFromKo
            // 
            this.lblPrevFromKo.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevFromKo.Location = new System.Drawing.Point(26, 73);
            this.lblPrevFromKo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevFromKo.Name = "lblPrevFromKo";
            this.lblPrevFromKo.Size = new System.Drawing.Size(79, 27);
            this.lblPrevFromKo.TabIndex = 2;
            this.lblPrevFromKo.Text = "子から";
            this.lblPrevFromKo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevWho_PointSum
            // 
            this.lblPrevWho_PointSum.AutoEllipsis = true;
            this.lblPrevWho_PointSum.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevWho_PointSum.Location = new System.Drawing.Point(106, 19);
            this.lblPrevWho_PointSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevWho_PointSum.Name = "lblPrevWho_PointSum";
            this.lblPrevWho_PointSum.Size = new System.Drawing.Size(121, 27);
            this.lblPrevWho_PointSum.TabIndex = 2;
            this.lblPrevWho_PointSum.Text = "合計 25000点";
            this.lblPrevWho_PointSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevFromMain_Point
            // 
            this.lblPrevFromMain_Point.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevFromMain_Point.Location = new System.Drawing.Point(123, 44);
            this.lblPrevFromMain_Point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevFromMain_Point.Name = "lblPrevFromMain_Point";
            this.lblPrevFromMain_Point.Size = new System.Drawing.Size(104, 27);
            this.lblPrevFromMain_Point.TabIndex = 2;
            this.lblPrevFromMain_Point.Text = "25000点";
            this.lblPrevFromMain_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevFromKo_Point
            // 
            this.lblPrevFromKo_Point.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevFromKo_Point.Location = new System.Drawing.Point(123, 73);
            this.lblPrevFromKo_Point.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevFromKo_Point.Name = "lblPrevFromKo_Point";
            this.lblPrevFromKo_Point.Size = new System.Drawing.Size(104, 27);
            this.lblPrevFromKo_Point.TabIndex = 2;
            this.lblPrevFromKo_Point.Text = "25000点";
            this.lblPrevFromKo_Point.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPrevWho);
            this.groupBox1.Controls.Add(this.lblPrevWho_PointSum);
            this.groupBox1.Controls.Add(this.lblPrevReachBarPoint);
            this.groupBox1.Controls.Add(this.lblPrevFromMain_Point);
            this.groupBox1.Controls.Add(this.lblPrevSyukugiPoint);
            this.groupBox1.Controls.Add(this.lblPrevFromKo_Point);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblPrevFromMain);
            this.groupBox1.Controls.Add(this.lblPrevFromKo);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(357, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 101);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "前回の結果";
            // 
            // lblPrevReachBarPoint
            // 
            this.lblPrevReachBarPoint.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevReachBarPoint.Location = new System.Drawing.Point(332, 44);
            this.lblPrevReachBarPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevReachBarPoint.Name = "lblPrevReachBarPoint";
            this.lblPrevReachBarPoint.Size = new System.Drawing.Size(89, 27);
            this.lblPrevReachBarPoint.TabIndex = 2;
            this.lblPrevReachBarPoint.Text = "25000点";
            this.lblPrevReachBarPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrevSyukugiPoint
            // 
            this.lblPrevSyukugiPoint.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblPrevSyukugiPoint.Location = new System.Drawing.Point(338, 71);
            this.lblPrevSyukugiPoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrevSyukugiPoint.Name = "lblPrevSyukugiPoint";
            this.lblPrevSyukugiPoint.Size = new System.Drawing.Size(89, 27);
            this.lblPrevSyukugiPoint.TabIndex = 2;
            this.lblPrevSyukugiPoint.Text = "25000点）";
            this.lblPrevSyukugiPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(247, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 27);
            this.label14.TabIndex = 2;
            this.label14.Text = "リー棒";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(247, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 27);
            this.label13.TabIndex = 2;
            this.label13.Text = "（内、祝儀点";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPointFix
            // 
            this.btnPointFix.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnPointFix.Location = new System.Drawing.Point(363, 432);
            this.btnPointFix.Name = "btnPointFix";
            this.btnPointFix.Size = new System.Drawing.Size(99, 23);
            this.btnPointFix.TabIndex = 23;
            this.btnPointFix.Text = "点数修正";
            this.btnPointFix.UseVisualStyleBackColor = true;
            this.btnPointFix.Click += new System.EventHandler(this.btnPointFix_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 492);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPointFix);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.drpFu);
            this.Controls.Add(this.drpFan);
            this.Controls.Add(this.btnP4_Reach);
            this.Controls.Add(this.btnP3_Reach);
            this.Controls.Add(this.btnP2_Reach);
            this.Controls.Add(this.btnP1_Reach);
            this.Controls.Add(this.txtP4_Name);
            this.Controls.Add(this.txtP3_Name);
            this.Controls.Add(this.txtP2_Name);
            this.Controls.Add(this.txtP4_Point);
            this.Controls.Add(this.txtP3_Point);
            this.Controls.Add(this.txtP2_Point);
            this.Controls.Add(this.txtP1_Point);
            this.Controls.Add(this.txtP1_Name);
            this.Controls.Add(this.lblGameIdx);
            this.Controls.Add(this.lblReachBar);
            this.Controls.Add(this.lblGameEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHonba);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblP4_Oya);
            this.Controls.Add(this.lblP3_Oya);
            this.Controls.Add(this.lblP2_Oya);
            this.Controls.Add(this.lblP1_Oya);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKyoku);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "麻雀点数記録装置";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKyoku;
        private System.Windows.Forms.Label lblHonba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReachBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtP1_Name;
        private System.Windows.Forms.TextBox txtP2_Name;
        private System.Windows.Forms.TextBox txtP3_Name;
        private System.Windows.Forms.TextBox txtP4_Name;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnP1_Reach;
        private System.Windows.Forms.TextBox txtP1_Point;
        private System.Windows.Forms.TextBox txtP2_Point;
        private System.Windows.Forms.TextBox txtP3_Point;
        private System.Windows.Forms.TextBox txtP4_Point;
        private System.Windows.Forms.Button btnP2_Reach;
        private System.Windows.Forms.Button btnP3_Reach;
        private System.Windows.Forms.Button btnP4_Reach;
        private System.Windows.Forms.Label lblP1_Oya;
        private System.Windows.Forms.Label lblP2_Oya;
        private System.Windows.Forms.Label lblP3_Oya;
        private System.Windows.Forms.Label lblP4_Oya;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoP1_Agari;
        private System.Windows.Forms.RadioButton rdoP4_Agari;
        private System.Windows.Forms.RadioButton rdoP3_Agari;
        private System.Windows.Forms.RadioButton rdoP2_Agari;
        private System.Windows.Forms.RadioButton rdoP4_Hoju;
        private System.Windows.Forms.RadioButton rdoP3_Hoju;
        private System.Windows.Forms.RadioButton rdoP2_Hoju;
        private System.Windows.Forms.RadioButton rdoP1_Hoju;
        private System.Windows.Forms.ComboBox drpFan;
        private System.Windows.Forms.ComboBox drpFu;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label lblGameEnd;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblGameIdx;
        private System.Windows.Forms.Label lblPrevWho;
        private System.Windows.Forms.Label lblPrevFromMain;
        private System.Windows.Forms.Label lblPrevFromKo;
        private System.Windows.Forms.Label lblPrevWho_PointSum;
        private System.Windows.Forms.Label lblPrevFromMain_Point;
        private System.Windows.Forms.Label lblPrevFromKo_Point;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPrevReachBarPoint;
        private System.Windows.Forms.Label lblPrevSyukugiPoint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnPointFix;
    }
}

