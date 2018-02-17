namespace MLBGameViewer
{
    partial class GameView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.atLbl = new System.Windows.Forms.Label();
            this.homeTeamLbl = new System.Windows.Forms.Label();
            this.awayTeamLbl = new System.Windows.Forms.Label();
            this.dataAwayLineup = new System.Windows.Forms.DataGridView();
            this.colNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataHomeLineup = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataLineScore = new System.Windows.Forms.DataGridView();
            this.colTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAwayLineup)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHomeLineup)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLineScore)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitle.Controls.Add(this.atLbl);
            this.panelTitle.Controls.Add(this.homeTeamLbl);
            this.panelTitle.Controls.Add(this.awayTeamLbl);
            this.panelTitle.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitle.Location = new System.Drawing.Point(308, 12);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(640, 72);
            this.panelTitle.TabIndex = 0;
            // 
            // atLbl
            // 
            this.atLbl.AutoSize = true;
            this.atLbl.Location = new System.Drawing.Point(306, 28);
            this.atLbl.Name = "atLbl";
            this.atLbl.Size = new System.Drawing.Size(29, 23);
            this.atLbl.TabIndex = 2;
            this.atLbl.Text = "@";
            // 
            // homeTeamLbl
            // 
            this.homeTeamLbl.AutoSize = true;
            this.homeTeamLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamLbl.Location = new System.Drawing.Point(546, 18);
            this.homeTeamLbl.Name = "homeTeamLbl";
            this.homeTeamLbl.Size = new System.Drawing.Size(0, 36);
            this.homeTeamLbl.TabIndex = 1;
            // 
            // awayTeamLbl
            // 
            this.awayTeamLbl.AutoSize = true;
            this.awayTeamLbl.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awayTeamLbl.Location = new System.Drawing.Point(3, 18);
            this.awayTeamLbl.Name = "awayTeamLbl";
            this.awayTeamLbl.Size = new System.Drawing.Size(0, 36);
            this.awayTeamLbl.TabIndex = 0;
            // 
            // dataAwayLineup
            // 
            this.dataAwayLineup.AllowUserToAddRows = false;
            this.dataAwayLineup.AllowUserToDeleteRows = false;
            this.dataAwayLineup.AllowUserToResizeColumns = false;
            this.dataAwayLineup.AllowUserToResizeRows = false;
            this.dataAwayLineup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataAwayLineup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAwayLineup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAwayLineup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumber,
            this.colName,
            this.colPos});
            this.dataAwayLineup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataAwayLineup.Location = new System.Drawing.Point(12, 87);
            this.dataAwayLineup.Name = "dataAwayLineup";
            this.dataAwayLineup.ReadOnly = true;
            this.dataAwayLineup.RowHeadersVisible = false;
            this.dataAwayLineup.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataAwayLineup.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAwayLineup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataAwayLineup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAwayLineup.ShowEditingIcon = false;
            this.dataAwayLineup.Size = new System.Drawing.Size(248, 513);
            this.dataAwayLineup.TabIndex = 0;
            this.dataAwayLineup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAwayLineup_CellClick);
            // 
            // colNumber
            // 
            this.colNumber.FillWeight = 25F;
            this.colNumber.HeaderText = "#";
            this.colNumber.Name = "colNumber";
            this.colNumber.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colPos
            // 
            this.colPos.FillWeight = 80F;
            this.colPos.HeaderText = "Pos";
            this.colPos.Name = "colPos";
            this.colPos.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 54);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(62, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Away";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1004, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 54);
            this.panel2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(62, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Home";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataHomeLineup
            // 
            this.dataHomeLineup.AllowUserToAddRows = false;
            this.dataHomeLineup.AllowUserToDeleteRows = false;
            this.dataHomeLineup.AllowUserToResizeColumns = false;
            this.dataHomeLineup.AllowUserToResizeRows = false;
            this.dataHomeLineup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataHomeLineup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataHomeLineup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHomeLineup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataHomeLineup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataHomeLineup.Location = new System.Drawing.Point(1004, 87);
            this.dataHomeLineup.Name = "dataHomeLineup";
            this.dataHomeLineup.ReadOnly = true;
            this.dataHomeLineup.RowHeadersVisible = false;
            this.dataHomeLineup.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataHomeLineup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataHomeLineup.ShowEditingIcon = false;
            this.dataHomeLineup.Size = new System.Drawing.Size(248, 513);
            this.dataHomeLineup.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 25F;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.FillWeight = 80F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Pos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 606);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 63);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Stats";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(168, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(73, 39);
            this.button3.TabIndex = 0;
            this.button3.Text = "Pitching";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(89, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 39);
            this.button2.TabIndex = 0;
            this.button2.Text = "Fielding";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(10, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hitting";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Location = new System.Drawing.Point(1004, 606);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 63);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Player Stats";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(168, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 39);
            this.button4.TabIndex = 0;
            this.button4.Text = "Pitching";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(89, 18);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(73, 39);
            this.button5.TabIndex = 0;
            this.button5.Text = "Fielding";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(10, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 39);
            this.button6.TabIndex = 0;
            this.button6.Text = "Hitting";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataLineScore
            // 
            this.dataLineScore.AllowUserToAddRows = false;
            this.dataLineScore.AllowUserToDeleteRows = false;
            this.dataLineScore.AllowUserToResizeColumns = false;
            this.dataLineScore.AllowUserToResizeRows = false;
            this.dataLineScore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataLineScore.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataLineScore.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLineScore.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataLineScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataLineScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTeam,
            this.col1,
            this.col2,
            this.col3,
            this.col4,
            this.col5,
            this.col6,
            this.col7,
            this.col8,
            this.col9,
            this.colR,
            this.colH,
            this.colE});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLineScore.DefaultCellStyle = dataGridViewCellStyle22;
            this.dataLineScore.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataLineScore.Location = new System.Drawing.Point(308, 103);
            this.dataLineScore.MultiSelect = false;
            this.dataLineScore.Name = "dataLineScore";
            this.dataLineScore.ReadOnly = true;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLineScore.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dataLineScore.RowHeadersVisible = false;
            this.dataLineScore.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataLineScore.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dataLineScore.RowTemplate.Height = 30;
            this.dataLineScore.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataLineScore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataLineScore.ShowEditingIcon = false;
            this.dataLineScore.Size = new System.Drawing.Size(639, 87);
            this.dataLineScore.TabIndex = 0;
            // 
            // colTeam
            // 
            this.colTeam.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTeam.FillWeight = 200F;
            this.colTeam.Frozen = true;
            this.colTeam.HeaderText = "Team";
            this.colTeam.Name = "colTeam";
            this.colTeam.ReadOnly = true;
            this.colTeam.Width = 104;
            // 
            // col1
            // 
            this.col1.FillWeight = 85F;
            this.col1.HeaderText = "1";
            this.col1.Name = "col1";
            this.col1.ReadOnly = true;
            // 
            // col2
            // 
            this.col2.FillWeight = 85F;
            this.col2.HeaderText = "2";
            this.col2.Name = "col2";
            this.col2.ReadOnly = true;
            // 
            // col3
            // 
            this.col3.FillWeight = 85F;
            this.col3.HeaderText = "3";
            this.col3.Name = "col3";
            this.col3.ReadOnly = true;
            // 
            // col4
            // 
            this.col4.FillWeight = 85F;
            this.col4.HeaderText = "4";
            this.col4.Name = "col4";
            this.col4.ReadOnly = true;
            // 
            // col5
            // 
            this.col5.FillWeight = 85F;
            this.col5.HeaderText = "5";
            this.col5.Name = "col5";
            this.col5.ReadOnly = true;
            // 
            // col6
            // 
            this.col6.FillWeight = 85F;
            this.col6.HeaderText = "6";
            this.col6.Name = "col6";
            this.col6.ReadOnly = true;
            // 
            // col7
            // 
            this.col7.FillWeight = 85F;
            this.col7.HeaderText = "7";
            this.col7.Name = "col7";
            this.col7.ReadOnly = true;
            // 
            // col8
            // 
            this.col8.FillWeight = 85F;
            this.col8.HeaderText = "8";
            this.col8.Name = "col8";
            this.col8.ReadOnly = true;
            // 
            // col9
            // 
            this.col9.FillWeight = 85F;
            this.col9.HeaderText = "9";
            this.col9.Name = "col9";
            this.col9.ReadOnly = true;
            // 
            // colR
            // 
            this.colR.FillWeight = 85F;
            this.colR.HeaderText = "R";
            this.colR.Name = "colR";
            this.colR.ReadOnly = true;
            // 
            // colH
            // 
            this.colH.FillWeight = 85F;
            this.colH.HeaderText = "H";
            this.colH.Name = "colH";
            this.colH.ReadOnly = true;
            // 
            // colE
            // 
            this.colE.FillWeight = 85F;
            this.colE.HeaderText = "E";
            this.colE.Name = "colE";
            this.colE.ReadOnly = true;
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.dataLineScore);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataHomeLineup);
            this.Controls.Add(this.dataAwayLineup);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "GameView";
            this.Text = "GameView";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameView_FormClosing);
            this.Load += new System.EventHandler(this.GameView_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAwayLineup)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataHomeLineup)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLineScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label homeTeamLbl;
        private System.Windows.Forms.Label awayTeamLbl;
        private System.Windows.Forms.Label atLbl;
        private System.Windows.Forms.DataGridView dataAwayLineup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPos;
        private System.Windows.Forms.DataGridView dataHomeLineup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataLineScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn col9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colR;
        private System.Windows.Forms.DataGridViewTextBoxColumn colH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colE;
    }
}