namespace ActAud
{
    partial class AuditForm
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
            this.tPgAuditSystemEvents = new System.Windows.Forms.TabPage();
            this.btnRefreshLogLIst = new System.Windows.Forms.Button();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbCurrentLog = new System.Windows.Forms.GroupBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbComputer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMessageType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.rbByComputer = new System.Windows.Forms.RadioButton();
            this.rbByDate = new System.Windows.Forms.RadioButton();
            this.rbByMessageType = new System.Windows.Forms.RadioButton();
            this.rbByID = new System.Windows.Forms.RadioButton();
            this.btnEraseCurrentLog = new System.Windows.Forms.Button();
            this.btnViewCurrentLogWithFilter = new System.Windows.Forms.Button();
            this.btnViewCurrentLog = new System.Windows.Forms.Button();
            this.dataGridViewCurrentLog = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStartEventMonitoring = new System.Windows.Forms.Button();
            this.rtbMonitoredEvents = new System.Windows.Forms.RichTextBox();
            this.gbSystemEventsList = new System.Windows.Forms.GroupBox();
            this.tvSystemEventsList = new System.Windows.Forms.TreeView();
            this.tcAuditFileSystem = new System.Windows.Forms.TabControl();
            this.tPgAuditFileSystem = new System.Windows.Forms.TabPage();
            this.gbInformation = new System.Windows.Forms.GroupBox();
            this.rtbInformation = new System.Windows.Forms.RichTextBox();
            this.btnStopMonitoring = new System.Windows.Forms.Button();
            this.clbActions = new System.Windows.Forms.CheckedListBox();
            this.btnStartMonitoring = new System.Windows.Forms.Button();
            this.lbDirectoryName = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChooseDirectory = new System.Windows.Forms.Button();
            this.tbPgAuditDevices = new System.Windows.Forms.TabPage();
            this.tmrAuditDevices = new System.Windows.Forms.Timer(this.components);
            this.lsbAuditDevices = new System.Windows.Forms.ListBox();
            this.pnElements = new System.Windows.Forms.Panel();
            this.tPgAuditSystemEvents.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbCurrentLog.SuspendLayout();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentLog)).BeginInit();
            this.tabPage6.SuspendLayout();
            this.gbSystemEventsList.SuspendLayout();
            this.tcAuditFileSystem.SuspendLayout();
            this.tPgAuditFileSystem.SuspendLayout();
            this.gbInformation.SuspendLayout();
            this.tbPgAuditDevices.SuspendLayout();
            this.pnElements.SuspendLayout();
            this.SuspendLayout();
            // 
            // tPgAuditSystemEvents
            // 
            this.tPgAuditSystemEvents.Controls.Add(this.btnRefreshLogLIst);
            this.tPgAuditSystemEvents.Controls.Add(this.tabControl3);
            this.tPgAuditSystemEvents.Controls.Add(this.gbSystemEventsList);
            this.tPgAuditSystemEvents.Location = new System.Drawing.Point(4, 22);
            this.tPgAuditSystemEvents.Name = "tPgAuditSystemEvents";
            this.tPgAuditSystemEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tPgAuditSystemEvents.Size = new System.Drawing.Size(1422, 543);
            this.tPgAuditSystemEvents.TabIndex = 1;
            this.tPgAuditSystemEvents.Text = "Мониторинг системных событий";
            this.tPgAuditSystemEvents.UseVisualStyleBackColor = true;
            // 
            // btnRefreshLogLIst
            // 
            this.btnRefreshLogLIst.Location = new System.Drawing.Point(64, 263);
            this.btnRefreshLogLIst.Name = "btnRefreshLogLIst";
            this.btnRefreshLogLIst.Size = new System.Drawing.Size(193, 43);
            this.btnRefreshLogLIst.TabIndex = 3;
            this.btnRefreshLogLIst.Text = "Обновить список журналов";
            this.btnRefreshLogLIst.UseVisualStyleBackColor = true;
            this.btnRefreshLogLIst.Click += new System.EventHandler(this.btnRefreshLogLIst_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage5);
            this.tabControl3.Controls.Add(this.tabPage6);
            this.tabControl3.Location = new System.Drawing.Point(348, 8);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(1018, 386);
            this.tabControl3.TabIndex = 2;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbCurrentLog);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1010, 360);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Просмотр журналов событий";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbCurrentLog
            // 
            this.gbCurrentLog.Controls.Add(this.dateTimePickerTo);
            this.gbCurrentLog.Controls.Add(this.label8);
            this.gbCurrentLog.Controls.Add(this.dateTimePickerFrom);
            this.gbCurrentLog.Controls.Add(this.label7);
            this.gbCurrentLog.Controls.Add(this.label6);
            this.gbCurrentLog.Controls.Add(this.tbComputer);
            this.gbCurrentLog.Controls.Add(this.label5);
            this.gbCurrentLog.Controls.Add(this.tbMessageType);
            this.gbCurrentLog.Controls.Add(this.label4);
            this.gbCurrentLog.Controls.Add(this.tbID);
            this.gbCurrentLog.Controls.Add(this.label3);
            this.gbCurrentLog.Controls.Add(this.gbFilter);
            this.gbCurrentLog.Controls.Add(this.btnEraseCurrentLog);
            this.gbCurrentLog.Controls.Add(this.btnViewCurrentLogWithFilter);
            this.gbCurrentLog.Controls.Add(this.btnViewCurrentLog);
            this.gbCurrentLog.Controls.Add(this.dataGridViewCurrentLog);
            this.gbCurrentLog.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbCurrentLog.Location = new System.Drawing.Point(3, 3);
            this.gbCurrentLog.Name = "gbCurrentLog";
            this.gbCurrentLog.Size = new System.Drawing.Size(1006, 354);
            this.gbCurrentLog.TabIndex = 1;
            this.gbCurrentLog.TabStop = false;
            this.gbCurrentLog.Text = "Выбранный журнал";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(190, 320);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerTo.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 319);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "до";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(190, 294);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(171, 20);
            this.dateTimePickerFrom.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "от";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Дата";
            // 
            // tbComputer
            // 
            this.tbComputer.Location = new System.Drawing.Point(253, 253);
            this.tbComputer.Name = "tbComputer";
            this.tbComputer.Size = new System.Drawing.Size(108, 20);
            this.tbComputer.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Компьютер";
            // 
            // tbMessageType
            // 
            this.tbMessageType.Location = new System.Drawing.Point(253, 227);
            this.tbMessageType.Name = "tbMessageType";
            this.tbMessageType.Size = new System.Drawing.Size(108, 20);
            this.tbMessageType.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Тип сообщения";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(253, 202);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(108, 20);
            this.tbID.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Идентификатор";
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.rbByComputer);
            this.gbFilter.Controls.Add(this.rbByDate);
            this.gbFilter.Controls.Add(this.rbByMessageType);
            this.gbFilter.Controls.Add(this.rbByID);
            this.gbFilter.Location = new System.Drawing.Point(383, 202);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(146, 123);
            this.gbFilter.TabIndex = 4;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Фильтрация";
            // 
            // rbByComputer
            // 
            this.rbByComputer.AutoSize = true;
            this.rbByComputer.Location = new System.Drawing.Point(11, 93);
            this.rbByComputer.Name = "rbByComputer";
            this.rbByComputer.Size = new System.Drawing.Size(104, 17);
            this.rbByComputer.TabIndex = 3;
            this.rbByComputer.TabStop = true;
            this.rbByComputer.Text = "По компьютеру";
            this.rbByComputer.UseVisualStyleBackColor = true;
            // 
            // rbByDate
            // 
            this.rbByDate.AutoSize = true;
            this.rbByDate.Location = new System.Drawing.Point(11, 70);
            this.rbByDate.Name = "rbByDate";
            this.rbByDate.Size = new System.Drawing.Size(65, 17);
            this.rbByDate.TabIndex = 2;
            this.rbByDate.TabStop = true;
            this.rbByDate.Text = "По дате";
            this.rbByDate.UseVisualStyleBackColor = true;
            // 
            // rbByMessageType
            // 
            this.rbByMessageType.AutoSize = true;
            this.rbByMessageType.Location = new System.Drawing.Point(11, 47);
            this.rbByMessageType.Name = "rbByMessageType";
            this.rbByMessageType.Size = new System.Drawing.Size(124, 17);
            this.rbByMessageType.TabIndex = 1;
            this.rbByMessageType.TabStop = true;
            this.rbByMessageType.Text = "По типу сообщения";
            this.rbByMessageType.UseVisualStyleBackColor = true;
            // 
            // rbByID
            // 
            this.rbByID.AutoSize = true;
            this.rbByID.Location = new System.Drawing.Point(11, 24);
            this.rbByID.Name = "rbByID";
            this.rbByID.Size = new System.Drawing.Size(125, 17);
            this.rbByID.TabIndex = 0;
            this.rbByID.TabStop = true;
            this.rbByID.Text = "По идентификатору";
            this.rbByID.UseVisualStyleBackColor = true;
            // 
            // btnEraseCurrentLog
            // 
            this.btnEraseCurrentLog.Location = new System.Drawing.Point(13, 296);
            this.btnEraseCurrentLog.Name = "btnEraseCurrentLog";
            this.btnEraseCurrentLog.Size = new System.Drawing.Size(140, 36);
            this.btnEraseCurrentLog.TabIndex = 3;
            this.btnEraseCurrentLog.Text = "Очистить выбранный журнал";
            this.btnEraseCurrentLog.UseVisualStyleBackColor = true;
            // 
            // btnViewCurrentLogWithFilter
            // 
            this.btnViewCurrentLogWithFilter.Location = new System.Drawing.Point(13, 247);
            this.btnViewCurrentLogWithFilter.Name = "btnViewCurrentLogWithFilter";
            this.btnViewCurrentLogWithFilter.Size = new System.Drawing.Size(140, 43);
            this.btnViewCurrentLogWithFilter.TabIndex = 2;
            this.btnViewCurrentLogWithFilter.Text = "Просмотр выбранного журнала с фильтрацией";
            this.btnViewCurrentLogWithFilter.UseVisualStyleBackColor = true;
            this.btnViewCurrentLogWithFilter.Click += new System.EventHandler(this.btnViewCurrentLogWithFilter_Click);
            // 
            // btnViewCurrentLog
            // 
            this.btnViewCurrentLog.Location = new System.Drawing.Point(13, 202);
            this.btnViewCurrentLog.Name = "btnViewCurrentLog";
            this.btnViewCurrentLog.Size = new System.Drawing.Size(140, 37);
            this.btnViewCurrentLog.TabIndex = 1;
            this.btnViewCurrentLog.Text = "Просмотр выбранного журнала";
            this.btnViewCurrentLog.UseVisualStyleBackColor = true;
            this.btnViewCurrentLog.Click += new System.EventHandler(this.btnViewCurrentLog_Click);
            // 
            // dataGridViewCurrentLog
            // 
            this.dataGridViewCurrentLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCurrentLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrentLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewCurrentLog.Location = new System.Drawing.Point(3, 19);
            this.dataGridViewCurrentLog.Name = "dataGridViewCurrentLog";
            this.dataGridViewCurrentLog.RowHeadersWidth = 71;
            this.dataGridViewCurrentLog.Size = new System.Drawing.Size(997, 170);
            this.dataGridViewCurrentLog.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Идентификатор";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип сообщения";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Компьютер";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Сообщение";
            this.Column5.Name = "Column5";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lbStatus);
            this.tabPage6.Controls.Add(this.label2);
            this.tabPage6.Controls.Add(this.btnStartEventMonitoring);
            this.tabPage6.Controls.Add(this.rtbMonitoredEvents);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(1010, 360);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Мониторинг событий";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(842, 30);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(66, 13);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "не запущен";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Статус:";
            // 
            // btnStartEventMonitoring
            // 
            this.btnStartEventMonitoring.Location = new System.Drawing.Point(553, 14);
            this.btnStartEventMonitoring.Name = "btnStartEventMonitoring";
            this.btnStartEventMonitoring.Size = new System.Drawing.Size(193, 44);
            this.btnStartEventMonitoring.TabIndex = 6;
            this.btnStartEventMonitoring.Text = "Начать мониторинг событий";
            this.btnStartEventMonitoring.UseVisualStyleBackColor = true;
            this.btnStartEventMonitoring.Click += new System.EventHandler(this.btnStartEventMonitoring_Click);
            // 
            // rtbMonitoredEvents
            // 
            this.rtbMonitoredEvents.Location = new System.Drawing.Point(14, 14);
            this.rtbMonitoredEvents.Name = "rtbMonitoredEvents";
            this.rtbMonitoredEvents.Size = new System.Drawing.Size(511, 343);
            this.rtbMonitoredEvents.TabIndex = 0;
            this.rtbMonitoredEvents.Text = "";
            // 
            // gbSystemEventsList
            // 
            this.gbSystemEventsList.Controls.Add(this.tvSystemEventsList);
            this.gbSystemEventsList.Location = new System.Drawing.Point(8, 6);
            this.gbSystemEventsList.Name = "gbSystemEventsList";
            this.gbSystemEventsList.Size = new System.Drawing.Size(320, 249);
            this.gbSystemEventsList.TabIndex = 0;
            this.gbSystemEventsList.TabStop = false;
            this.gbSystemEventsList.Text = "Список системных журналов";
            // 
            // tvSystemEventsList
            // 
            this.tvSystemEventsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSystemEventsList.Location = new System.Drawing.Point(3, 16);
            this.tvSystemEventsList.Name = "tvSystemEventsList";
            this.tvSystemEventsList.Size = new System.Drawing.Size(314, 230);
            this.tvSystemEventsList.TabIndex = 0;
            // 
            // tcAuditFileSystem
            // 
            this.tcAuditFileSystem.Controls.Add(this.tPgAuditSystemEvents);
            this.tcAuditFileSystem.Controls.Add(this.tPgAuditFileSystem);
            this.tcAuditFileSystem.Controls.Add(this.tbPgAuditDevices);
            this.tcAuditFileSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAuditFileSystem.Location = new System.Drawing.Point(0, 0);
            this.tcAuditFileSystem.Name = "tcAuditFileSystem";
            this.tcAuditFileSystem.SelectedIndex = 0;
            this.tcAuditFileSystem.Size = new System.Drawing.Size(1430, 569);
            this.tcAuditFileSystem.TabIndex = 1;
            // 
            // tPgAuditFileSystem
            // 
            this.tPgAuditFileSystem.Controls.Add(this.pnElements);
            this.tPgAuditFileSystem.Controls.Add(this.gbInformation);
            this.tPgAuditFileSystem.Controls.Add(this.lbDirectoryName);
            this.tPgAuditFileSystem.Controls.Add(this.btnChooseDirectory);
            this.tPgAuditFileSystem.Location = new System.Drawing.Point(4, 22);
            this.tPgAuditFileSystem.Name = "tPgAuditFileSystem";
            this.tPgAuditFileSystem.Size = new System.Drawing.Size(1422, 543);
            this.tPgAuditFileSystem.TabIndex = 2;
            this.tPgAuditFileSystem.Text = "Мониторинг событий файловой системы";
            this.tPgAuditFileSystem.UseVisualStyleBackColor = true;
            // 
            // gbInformation
            // 
            this.gbInformation.Controls.Add(this.rtbInformation);
            this.gbInformation.Location = new System.Drawing.Point(268, 13);
            this.gbInformation.Name = "gbInformation";
            this.gbInformation.Size = new System.Drawing.Size(1146, 522);
            this.gbInformation.TabIndex = 21;
            this.gbInformation.TabStop = false;
            this.gbInformation.Text = "Информация об изменениях файловой системы";
            // 
            // rtbInformation
            // 
            this.rtbInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInformation.Location = new System.Drawing.Point(3, 16);
            this.rtbInformation.Name = "rtbInformation";
            this.rtbInformation.Size = new System.Drawing.Size(1140, 503);
            this.rtbInformation.TabIndex = 0;
            this.rtbInformation.Text = "";
            // 
            // btnStopMonitoring
            // 
            this.btnStopMonitoring.Enabled = false;
            this.btnStopMonitoring.Location = new System.Drawing.Point(3, 225);
            this.btnStopMonitoring.Name = "btnStopMonitoring";
            this.btnStopMonitoring.Size = new System.Drawing.Size(220, 35);
            this.btnStopMonitoring.TabIndex = 20;
            this.btnStopMonitoring.Text = "Остановить";
            this.btnStopMonitoring.UseVisualStyleBackColor = true;
            this.btnStopMonitoring.Click += new System.EventHandler(this.btnStopMonitoring_Click);
            // 
            // clbActions
            // 
            this.clbActions.FormattingEnabled = true;
            this.clbActions.Items.AddRange(new object[] {
            "Изменение файловой системы",
            "Создание файлов и папок",
            "Удаление файлов и папок",
            "Переименование файлов и папок",
            "Любые изменения файловой системы"});
            this.clbActions.Location = new System.Drawing.Point(3, 3);
            this.clbActions.Name = "clbActions";
            this.clbActions.Size = new System.Drawing.Size(220, 79);
            this.clbActions.TabIndex = 13;
            // 
            // btnStartMonitoring
            // 
            this.btnStartMonitoring.Location = new System.Drawing.Point(3, 164);
            this.btnStartMonitoring.Name = "btnStartMonitoring";
            this.btnStartMonitoring.Size = new System.Drawing.Size(220, 39);
            this.btnStartMonitoring.TabIndex = 19;
            this.btnStartMonitoring.Text = "Начать мониторинг событий файловой системы";
            this.btnStartMonitoring.UseVisualStyleBackColor = true;
            this.btnStartMonitoring.Click += new System.EventHandler(this.btnStartMonitoring_Click);
            // 
            // lbDirectoryName
            // 
            this.lbDirectoryName.Location = new System.Drawing.Point(10, 71);
            this.lbDirectoryName.Name = "lbDirectoryName";
            this.lbDirectoryName.Size = new System.Drawing.Size(218, 44);
            this.lbDirectoryName.TabIndex = 12;
            this.lbDirectoryName.Text = "<Выберите каталог>";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(2, 102);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(221, 41);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистить поле вывода информации";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChooseDirectory
            // 
            this.btnChooseDirectory.Location = new System.Drawing.Point(8, 18);
            this.btnChooseDirectory.Name = "btnChooseDirectory";
            this.btnChooseDirectory.Size = new System.Drawing.Size(220, 40);
            this.btnChooseDirectory.TabIndex = 2;
            this.btnChooseDirectory.Text = "Выбор каталога";
            this.btnChooseDirectory.UseVisualStyleBackColor = true;
            this.btnChooseDirectory.Click += new System.EventHandler(this.btnChooseDirectory_Click);
            // 
            // tbPgAuditDevices
            // 
            this.tbPgAuditDevices.Controls.Add(this.lsbAuditDevices);
            this.tbPgAuditDevices.Location = new System.Drawing.Point(4, 22);
            this.tbPgAuditDevices.Name = "tbPgAuditDevices";
            this.tbPgAuditDevices.Size = new System.Drawing.Size(1422, 543);
            this.tbPgAuditDevices.TabIndex = 3;
            this.tbPgAuditDevices.Text = "Мониториг аппаратных изменений";
            this.tbPgAuditDevices.UseVisualStyleBackColor = true;
            // 
            // tmrAuditDevices
            // 
            this.tmrAuditDevices.Enabled = true;
            this.tmrAuditDevices.Interval = 1000;
            this.tmrAuditDevices.Tick += new System.EventHandler(this.tmrAuditDevices_Tick);
            // 
            // lsbAuditDevices
            // 
            this.lsbAuditDevices.Dock = System.Windows.Forms.DockStyle.Left;
            this.lsbAuditDevices.Location = new System.Drawing.Point(0, 0);
            this.lsbAuditDevices.Name = "lsbAuditDevices";
            this.lsbAuditDevices.Size = new System.Drawing.Size(1166, 543);
            this.lsbAuditDevices.TabIndex = 2;
            // 
            // pnElements
            // 
            this.pnElements.Controls.Add(this.clbActions);
            this.pnElements.Controls.Add(this.btnStopMonitoring);
            this.pnElements.Controls.Add(this.btnClear);
            this.pnElements.Controls.Add(this.btnStartMonitoring);
            this.pnElements.Enabled = false;
            this.pnElements.Location = new System.Drawing.Point(8, 92);
            this.pnElements.Name = "pnElements";
            this.pnElements.Size = new System.Drawing.Size(227, 263);
            this.pnElements.TabIndex = 22;
            // 
            // AuditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 569);
            this.Controls.Add(this.tcAuditFileSystem);
            this.Name = "AuditForm";
            this.Text = "AuditForm";
            this.Load += new System.EventHandler(this.AuditForm_Load);
            this.tPgAuditSystemEvents.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.gbCurrentLog.ResumeLayout(false);
            this.gbCurrentLog.PerformLayout();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrentLog)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.gbSystemEventsList.ResumeLayout(false);
            this.tcAuditFileSystem.ResumeLayout(false);
            this.tPgAuditFileSystem.ResumeLayout(false);
            this.gbInformation.ResumeLayout(false);
            this.tbPgAuditDevices.ResumeLayout(false);
            this.pnElements.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tPgAuditSystemEvents;
        private System.Windows.Forms.Button btnRefreshLogLIst;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox gbCurrentLog;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbComputer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMessageType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.RadioButton rbByComputer;
        private System.Windows.Forms.RadioButton rbByDate;
        private System.Windows.Forms.RadioButton rbByMessageType;
        private System.Windows.Forms.RadioButton rbByID;
        private System.Windows.Forms.Button btnEraseCurrentLog;
        private System.Windows.Forms.Button btnViewCurrentLogWithFilter;
        private System.Windows.Forms.Button btnViewCurrentLog;
        private System.Windows.Forms.DataGridView dataGridViewCurrentLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStartEventMonitoring;
        private System.Windows.Forms.RichTextBox rtbMonitoredEvents;
        private System.Windows.Forms.GroupBox gbSystemEventsList;
        private System.Windows.Forms.TreeView tvSystemEventsList;
        private System.Windows.Forms.TabControl tcAuditFileSystem;
        private System.Windows.Forms.TabPage tPgAuditFileSystem;
        private System.Windows.Forms.GroupBox gbInformation;
        private System.Windows.Forms.RichTextBox rtbInformation;
        private System.Windows.Forms.Button btnStopMonitoring;
        private System.Windows.Forms.CheckedListBox clbActions;
        private System.Windows.Forms.Button btnStartMonitoring;
        private System.Windows.Forms.Label lbDirectoryName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChooseDirectory;
        private System.Windows.Forms.TabPage tbPgAuditDevices;
        private System.Windows.Forms.Timer tmrAuditDevices;
        private System.Windows.Forms.ListBox lsbAuditDevices;
        private System.Windows.Forms.Panel pnElements;
    }
}