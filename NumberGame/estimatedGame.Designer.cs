namespace NumberGame
{
    partial class estimatedGame
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
            this.components = new System.ComponentModel.Container();
            this.estimatedPnl = new System.Windows.Forms.Panel();
            this.estimatedBtn = new FontAwesome.Sharp.IconButton();
            this.numberToKnow = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label17 = new System.Windows.Forms.Label();
            this.estimatedNumberTxtBx = new System.Windows.Forms.TextBox();
            this.infoLbl = new System.Windows.Forms.Label();
            this.digit3Lbl = new System.Windows.Forms.Label();
            this.digit10Lbl = new System.Windows.Forms.Label();
            this.digit1Lbl = new System.Windows.Forms.Label();
            this.digit9Lbl = new System.Windows.Forms.Label();
            this.digit2Lbl = new System.Windows.Forms.Label();
            this.digit8Lbl = new System.Windows.Forms.Label();
            this.digit7Lbl = new System.Windows.Forms.Label();
            this.digit4Lbl = new System.Windows.Forms.Label();
            this.digit6Lbl = new System.Windows.Forms.Label();
            this.digit5Lbl = new System.Windows.Forms.Label();
            this.scoreListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userStatusPnl = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.retriesLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timeLbl = new System.Windows.Forms.Label();
            this.recurringCheckBox = new System.Windows.Forms.CheckBox();
            this.retriesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.digitNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTxtBx = new System.Windows.Forms.TextBox();
            this.scoreListBtn = new FontAwesome.Sharp.IconButton();
            this.startBtn = new FontAwesome.Sharp.IconButton();
            this.remainingTimer = new System.Windows.Forms.Timer(this.components);
            this.estimatedPnl.SuspendLayout();
            this.userStatusPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitNumberNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // estimatedPnl
            // 
            this.estimatedPnl.BackColor = System.Drawing.Color.SandyBrown;
            this.estimatedPnl.Controls.Add(this.estimatedBtn);
            this.estimatedPnl.Controls.Add(this.numberToKnow);
            this.estimatedPnl.Controls.Add(this.label17);
            this.estimatedPnl.Controls.Add(this.estimatedNumberTxtBx);
            this.estimatedPnl.Controls.Add(this.infoLbl);
            this.estimatedPnl.Controls.Add(this.digit3Lbl);
            this.estimatedPnl.Controls.Add(this.digit10Lbl);
            this.estimatedPnl.Controls.Add(this.digit1Lbl);
            this.estimatedPnl.Controls.Add(this.digit9Lbl);
            this.estimatedPnl.Controls.Add(this.digit2Lbl);
            this.estimatedPnl.Controls.Add(this.digit8Lbl);
            this.estimatedPnl.Controls.Add(this.digit7Lbl);
            this.estimatedPnl.Controls.Add(this.digit4Lbl);
            this.estimatedPnl.Controls.Add(this.digit6Lbl);
            this.estimatedPnl.Controls.Add(this.digit5Lbl);
            this.estimatedPnl.Location = new System.Drawing.Point(54, 261);
            this.estimatedPnl.Name = "estimatedPnl";
            this.estimatedPnl.Size = new System.Drawing.Size(595, 182);
            this.estimatedPnl.TabIndex = 54;
            this.estimatedPnl.Visible = false;
            // 
            // estimatedBtn
            // 
            this.estimatedBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.estimatedBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.estimatedBtn.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.estimatedBtn.IconColor = System.Drawing.Color.Black;
            this.estimatedBtn.IconSize = 20;
            this.estimatedBtn.Location = new System.Drawing.Point(12, 26);
            this.estimatedBtn.Name = "estimatedBtn";
            this.estimatedBtn.Rotation = 0D;
            this.estimatedBtn.Size = new System.Drawing.Size(110, 54);
            this.estimatedBtn.TabIndex = 58;
            this.estimatedBtn.Text = "Tahmin Et";
            this.estimatedBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.estimatedBtn.UseVisualStyleBackColor = true;
            this.estimatedBtn.Click += new System.EventHandler(this.estimatedBtn_Click);
            // 
            // numberToKnow
            // 
            this.numberToKnow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.numberToKnow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numberToKnow.GridLines = true;
            this.numberToKnow.HideSelection = false;
            this.numberToKnow.Location = new System.Drawing.Point(355, 33);
            this.numberToKnow.Name = "numberToKnow";
            this.numberToKnow.Size = new System.Drawing.Size(237, 88);
            this.numberToKnow.TabIndex = 29;
            this.numberToKnow.UseCompatibleStateImageBehavior = false;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 31;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 35;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Width = 34;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Width = 36;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Width = 31;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Width = 30;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Width = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(382, 9);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 14);
            this.label17.TabIndex = 30;
            this.label17.Text = "Sayının içinde var olan rakamlar";
            // 
            // estimatedNumberTxtBx
            // 
            this.estimatedNumberTxtBx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.estimatedNumberTxtBx.Location = new System.Drawing.Point(161, 33);
            this.estimatedNumberTxtBx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.estimatedNumberTxtBx.MaxLength = 10;
            this.estimatedNumberTxtBx.Name = "estimatedNumberTxtBx";
            this.estimatedNumberTxtBx.Size = new System.Drawing.Size(189, 27);
            this.estimatedNumberTxtBx.TabIndex = 16;
            this.estimatedNumberTxtBx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.estimatedNumberTxtBx_KeyPress);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.Color.White;
            this.infoLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLbl.Location = new System.Drawing.Point(5, 114);
            this.infoLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(285, 14);
            this.infoLbl.TabIndex = 53;
            this.infoLbl.Text = "Sayının içinde var olan rakamların basamakları";
            this.infoLbl.Visible = false;
            // 
            // digit3Lbl
            // 
            this.digit3Lbl.AutoSize = true;
            this.digit3Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit3Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit3Lbl.Location = new System.Drawing.Point(92, 140);
            this.digit3Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit3Lbl.Name = "digit3Lbl";
            this.digit3Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit3Lbl.TabIndex = 50;
            this.digit3Lbl.Text = "?";
            this.digit3Lbl.Visible = false;
            // 
            // digit10Lbl
            // 
            this.digit10Lbl.AutoSize = true;
            this.digit10Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit10Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit10Lbl.Location = new System.Drawing.Point(393, 140);
            this.digit10Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit10Lbl.Name = "digit10Lbl";
            this.digit10Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit10Lbl.TabIndex = 43;
            this.digit10Lbl.Text = "?";
            this.digit10Lbl.Visible = false;
            // 
            // digit1Lbl
            // 
            this.digit1Lbl.AutoSize = true;
            this.digit1Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit1Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit1Lbl.ForeColor = System.Drawing.Color.Black;
            this.digit1Lbl.Location = new System.Drawing.Point(6, 140);
            this.digit1Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit1Lbl.Name = "digit1Lbl";
            this.digit1Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit1Lbl.TabIndex = 52;
            this.digit1Lbl.Text = "?";
            this.digit1Lbl.Visible = false;
            // 
            // digit9Lbl
            // 
            this.digit9Lbl.AutoSize = true;
            this.digit9Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit9Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit9Lbl.Location = new System.Drawing.Point(350, 140);
            this.digit9Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit9Lbl.Name = "digit9Lbl";
            this.digit9Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit9Lbl.TabIndex = 44;
            this.digit9Lbl.Text = "?";
            this.digit9Lbl.Visible = false;
            // 
            // digit2Lbl
            // 
            this.digit2Lbl.AutoSize = true;
            this.digit2Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit2Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit2Lbl.Location = new System.Drawing.Point(49, 140);
            this.digit2Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit2Lbl.Name = "digit2Lbl";
            this.digit2Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit2Lbl.TabIndex = 51;
            this.digit2Lbl.Text = "?";
            this.digit2Lbl.Visible = false;
            // 
            // digit8Lbl
            // 
            this.digit8Lbl.AutoSize = true;
            this.digit8Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit8Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit8Lbl.Location = new System.Drawing.Point(307, 140);
            this.digit8Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit8Lbl.Name = "digit8Lbl";
            this.digit8Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit8Lbl.TabIndex = 45;
            this.digit8Lbl.Text = "?";
            this.digit8Lbl.Visible = false;
            // 
            // digit7Lbl
            // 
            this.digit7Lbl.AutoSize = true;
            this.digit7Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit7Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit7Lbl.Location = new System.Drawing.Point(264, 140);
            this.digit7Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit7Lbl.Name = "digit7Lbl";
            this.digit7Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit7Lbl.TabIndex = 46;
            this.digit7Lbl.Text = "?";
            this.digit7Lbl.Visible = false;
            // 
            // digit4Lbl
            // 
            this.digit4Lbl.AutoSize = true;
            this.digit4Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit4Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit4Lbl.Location = new System.Drawing.Point(135, 140);
            this.digit4Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit4Lbl.Name = "digit4Lbl";
            this.digit4Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit4Lbl.TabIndex = 49;
            this.digit4Lbl.Text = "?";
            this.digit4Lbl.Visible = false;
            // 
            // digit6Lbl
            // 
            this.digit6Lbl.AutoSize = true;
            this.digit6Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit6Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit6Lbl.Location = new System.Drawing.Point(221, 140);
            this.digit6Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit6Lbl.Name = "digit6Lbl";
            this.digit6Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit6Lbl.TabIndex = 47;
            this.digit6Lbl.Text = "?";
            this.digit6Lbl.Visible = false;
            // 
            // digit5Lbl
            // 
            this.digit5Lbl.AutoSize = true;
            this.digit5Lbl.BackColor = System.Drawing.Color.Sienna;
            this.digit5Lbl.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digit5Lbl.Location = new System.Drawing.Point(178, 140);
            this.digit5Lbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.digit5Lbl.Name = "digit5Lbl";
            this.digit5Lbl.Size = new System.Drawing.Size(30, 33);
            this.digit5Lbl.TabIndex = 48;
            this.digit5Lbl.Text = "?";
            this.digit5Lbl.Visible = false;
            // 
            // scoreListView
            // 
            this.scoreListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.scoreListView.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreListView.GridLines = true;
            this.scoreListView.HideSelection = false;
            this.scoreListView.Location = new System.Drawing.Point(739, 6);
            this.scoreListView.Name = "scoreListView";
            this.scoreListView.Size = new System.Drawing.Size(271, 333);
            this.scoreListView.TabIndex = 42;
            this.scoreListView.UseCompatibleStateImageBehavior = false;
            this.scoreListView.View = System.Windows.Forms.View.Details;
            this.scoreListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kullanıcı Adı";
            this.columnHeader1.Width = 188;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Skor";
            this.columnHeader2.Width = 72;
            // 
            // userStatusPnl
            // 
            this.userStatusPnl.BackColor = System.Drawing.Color.Sienna;
            this.userStatusPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userStatusPnl.Controls.Add(this.label4);
            this.userStatusPnl.Controls.Add(this.scoreLbl);
            this.userStatusPnl.Controls.Add(this.retriesLbl);
            this.userStatusPnl.Controls.Add(this.label9);
            this.userStatusPnl.Controls.Add(this.label5);
            this.userStatusPnl.Controls.Add(this.timeLbl);
            this.userStatusPnl.Location = new System.Drawing.Point(739, 345);
            this.userStatusPnl.Name = "userStatusPnl";
            this.userStatusPnl.Size = new System.Drawing.Size(342, 98);
            this.userStatusPnl.TabIndex = 41;
            this.userStatusPnl.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Peru;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(68, 13);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalan Hak Sayısı";
            // 
            // scoreLbl
            // 
            this.scoreLbl.AutoSize = true;
            this.scoreLbl.BackColor = System.Drawing.Color.Peru;
            this.scoreLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLbl.Location = new System.Drawing.Point(23, 54);
            this.scoreLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(22, 23);
            this.scoreLbl.TabIndex = 14;
            this.scoreLbl.Text = "0";
            // 
            // retriesLbl
            // 
            this.retriesLbl.AutoSize = true;
            this.retriesLbl.BackColor = System.Drawing.Color.Peru;
            this.retriesLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.retriesLbl.Location = new System.Drawing.Point(142, 54);
            this.retriesLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.retriesLbl.Name = "retriesLbl";
            this.retriesLbl.Size = new System.Drawing.Size(22, 23);
            this.retriesLbl.TabIndex = 10;
            this.retriesLbl.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Peru;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(5, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Skor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Peru;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(269, 13);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Süre";
            // 
            // timeLbl
            // 
            this.timeLbl.AutoSize = true;
            this.timeLbl.BackColor = System.Drawing.Color.Peru;
            this.timeLbl.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.timeLbl.Location = new System.Drawing.Point(288, 54);
            this.timeLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLbl.Name = "timeLbl";
            this.timeLbl.Size = new System.Drawing.Size(34, 23);
            this.timeLbl.TabIndex = 11;
            this.timeLbl.Text = "20";
            // 
            // recurringCheckBox
            // 
            this.recurringCheckBox.AutoSize = true;
            this.recurringCheckBox.BackColor = System.Drawing.Color.Chocolate;
            this.recurringCheckBox.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.recurringCheckBox.Location = new System.Drawing.Point(250, 228);
            this.recurringCheckBox.Name = "recurringCheckBox";
            this.recurringCheckBox.Size = new System.Drawing.Size(184, 27);
            this.recurringCheckBox.TabIndex = 40;
            this.recurringCheckBox.Text = "Rakamları Farklı";
            this.recurringCheckBox.UseVisualStyleBackColor = false;
            // 
            // retriesNumericUpDown
            // 
            this.retriesNumericUpDown.BackColor = System.Drawing.Color.Chocolate;
            this.retriesNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.retriesNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.retriesNumericUpDown.Location = new System.Drawing.Point(344, 159);
            this.retriesNumericUpDown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.retriesNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.retriesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.retriesNumericUpDown.Name = "retriesNumericUpDown";
            this.retriesNumericUpDown.ReadOnly = true;
            this.retriesNumericUpDown.Size = new System.Drawing.Size(85, 27);
            this.retriesNumericUpDown.TabIndex = 39;
            this.retriesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // digitNumberNumericUpDown
            // 
            this.digitNumberNumericUpDown.BackColor = System.Drawing.Color.Chocolate;
            this.digitNumberNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digitNumberNumericUpDown.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.digitNumberNumericUpDown.Location = new System.Drawing.Point(344, 86);
            this.digitNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.digitNumberNumericUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digitNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.digitNumberNumericUpDown.Name = "digitNumberNumericUpDown";
            this.digitNumberNumericUpDown.ReadOnly = true;
            this.digitNumberNumericUpDown.Size = new System.Drawing.Size(85, 27);
            this.digitNumberNumericUpDown.TabIndex = 38;
            this.digitNumberNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Chocolate;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(60, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 37;
            this.label3.Text = "Basamak Sayısı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Chocolate;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(60, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 23);
            this.label2.TabIndex = 36;
            this.label2.Text = "Hak Sayısı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chocolate;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // userNameTxtBx
            // 
            this.userNameTxtBx.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameTxtBx.Location = new System.Drawing.Point(202, 13);
            this.userNameTxtBx.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.userNameTxtBx.MaxLength = 20;
            this.userNameTxtBx.Name = "userNameTxtBx";
            this.userNameTxtBx.Size = new System.Drawing.Size(227, 27);
            this.userNameTxtBx.TabIndex = 34;
            // 
            // scoreListBtn
            // 
            this.scoreListBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.scoreListBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreListBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.scoreListBtn.IconColor = System.Drawing.Color.Black;
            this.scoreListBtn.IconSize = 20;
            this.scoreListBtn.Location = new System.Drawing.Point(556, 32);
            this.scoreListBtn.Name = "scoreListBtn";
            this.scoreListBtn.Rotation = 0D;
            this.scoreListBtn.Size = new System.Drawing.Size(153, 54);
            this.scoreListBtn.TabIndex = 56;
            this.scoreListBtn.Text = "Skor Tablosu";
            this.scoreListBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scoreListBtn.UseVisualStyleBackColor = true;
            this.scoreListBtn.Click += new System.EventHandler(this.scoreListBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.startBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBtn.IconChar = FontAwesome.Sharp.IconChar.Rocket;
            this.startBtn.IconColor = System.Drawing.Color.Black;
            this.startBtn.IconSize = 20;
            this.startBtn.Location = new System.Drawing.Point(64, 201);
            this.startBtn.Name = "startBtn";
            this.startBtn.Rotation = 0D;
            this.startBtn.Size = new System.Drawing.Size(110, 54);
            this.startBtn.TabIndex = 57;
            this.startBtn.Text = "Başla";
            this.startBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // remainingTimer
            // 
            this.remainingTimer.Interval = 1000;
            this.remainingTimer.Tick += new System.EventHandler(this.remainingTimer_Tick);
            // 
            // estimatedGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(1070, 459);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.scoreListBtn);
            this.Controls.Add(this.userStatusPnl);
            this.Controls.Add(this.estimatedPnl);
            this.Controls.Add(this.scoreListView);
            this.Controls.Add(this.recurringCheckBox);
            this.Controls.Add(this.retriesNumericUpDown);
            this.Controls.Add(this.digitNumberNumericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameTxtBx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "estimatedGame";
            this.Text = "Sayı Bulmaca Oyunu";
            this.Load += new System.EventHandler(this.estimatedGame_Load);
            this.estimatedPnl.ResumeLayout(false);
            this.estimatedPnl.PerformLayout();
            this.userStatusPnl.ResumeLayout(false);
            this.userStatusPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.retriesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitNumberNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel estimatedPnl;
        private System.Windows.Forms.ListView numberToKnow;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox estimatedNumberTxtBx;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label digit1Lbl;
        private System.Windows.Forms.Label digit2Lbl;
        private System.Windows.Forms.Label digit3Lbl;
        private System.Windows.Forms.Label digit4Lbl;
        private System.Windows.Forms.Label digit5Lbl;
        private System.Windows.Forms.Label digit6Lbl;
        private System.Windows.Forms.Label digit7Lbl;
        private System.Windows.Forms.Label digit8Lbl;
        private System.Windows.Forms.Label digit9Lbl;
        private System.Windows.Forms.Label digit10Lbl;
        private System.Windows.Forms.ListView scoreListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel userStatusPnl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label retriesLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timeLbl;
        private System.Windows.Forms.CheckBox recurringCheckBox;
        private System.Windows.Forms.NumericUpDown retriesNumericUpDown;
        private System.Windows.Forms.NumericUpDown digitNumberNumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTxtBx;
        private FontAwesome.Sharp.IconButton scoreListBtn;
        private FontAwesome.Sharp.IconButton startBtn;
        private FontAwesome.Sharp.IconButton estimatedBtn;
        private System.Windows.Forms.Timer remainingTimer;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

