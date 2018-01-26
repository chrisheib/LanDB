namespace LanDB
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridViewLans = new System.Windows.Forms.DataGridView();
            this.lb_status = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lanDataSet = new LanDB.lanDataSet();
            this.lansBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lansTableAdapter = new LanDB.lanDataSetTableAdapters.lansTableAdapter();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.cmd_ofen_add = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_ofen_person = new System.Windows.Forms.ComboBox();
            this.cb_ofen_lan = new System.Windows.Forms.ComboBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.cb_teilnahme_delete_person = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_teiln_delete_datum = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmd_teiln_delete = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmd_teiln_add = new System.Windows.Forms.Button();
            this.cb_teiln_add_lan = new System.Windows.Forms.ComboBox();
            this.cb_teiln_add_person = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmdDeleteDienst = new System.Windows.Forms.Button();
            this.cmdAddDienst = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDienstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_dienste_id = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmd_keys_del = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cb_keys_del_key = new System.Windows.Forms.ComboBox();
            this.cb_keys_del_spiel = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_keys_del_person = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmd_keys_add = new System.Windows.Forms.Button();
            this.txt_keys_key = new System.Windows.Forms.TextBox();
            this.cb_keys_person = new System.Windows.Forms.ComboBox();
            this.cb_keys_spiel = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_spiele_add_kosten = new System.Windows.Forms.TextBox();
            this.txt_spiele_name = new System.Windows.Forms.TextBox();
            this.cb_spiele_id = new System.Windows.Forms.ComboBox();
            this.cmdDeleteSpiel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_spiele_dienst = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdAddSpiel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb_personen_id = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_personen_email = new System.Windows.Forms.TextBox();
            this.txt_personen_telefon = new System.Windows.Forms.TextBox();
            this.txt_personen_adresse = new System.Windows.Forms.TextBox();
            this.txt_personen_name = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmd_personen_delete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cmd_personen_add = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.datetime_lan_add = new System.Windows.Forms.DateTimePicker();
            this.cmd_lan_entfernen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_lans_id = new System.Windows.Forms.ComboBox();
            this.cmd_lan_add = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel_status = new System.Windows.Forms.Panel();
            this.panel_grid = new System.Windows.Forms.Panel();
            this.panel_tabs = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lansBindingSource)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel_status.SuspendLayout();
            this.panel_grid.SuspendLayout();
            this.panel_tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewLans
            // 
            this.gridViewLans.AllowUserToAddRows = false;
            this.gridViewLans.AllowUserToDeleteRows = false;
            this.gridViewLans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewLans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewLans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridViewLans.Location = new System.Drawing.Point(3, 3);
            this.gridViewLans.Name = "gridViewLans";
            this.gridViewLans.ReadOnly = true;
            this.gridViewLans.RowHeadersVisible = false;
            this.gridViewLans.Size = new System.Drawing.Size(301, 272);
            this.gridViewLans.TabIndex = 1;
            this.gridViewLans.TabStop = false;
            this.gridViewLans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewLans_CellContentClick);
            // 
            // lb_status
            // 
            this.lb_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_status.FormattingEnabled = true;
            this.lb_status.HorizontalScrollbar = true;
            this.lb_status.Location = new System.Drawing.Point(3, 3);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(453, 85);
            this.lb_status.TabIndex = 7;
            this.lb_status.TabStop = false;
            // 
            // lanDataSet
            // 
            this.lanDataSet.DataSetName = "lanDataSet";
            this.lanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lansBindingSource
            // 
            this.lansBindingSource.DataMember = "lans";
            this.lansBindingSource.DataSource = this.lanDataSet;
            // 
            // lansTableAdapter
            // 
            this.lansTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.cmd_ofen_add);
            this.tabPage9.Controls.Add(this.label19);
            this.tabPage9.Controls.Add(this.label18);
            this.tabPage9.Controls.Add(this.cb_ofen_person);
            this.tabPage9.Controls.Add(this.cb_ofen_lan);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(445, 149);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Ofen";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // cmd_ofen_add
            // 
            this.cmd_ofen_add.Location = new System.Drawing.Point(9, 74);
            this.cmd_ofen_add.Name = "cmd_ofen_add";
            this.cmd_ofen_add.Size = new System.Drawing.Size(180, 23);
            this.cmd_ofen_add.TabIndex = 11;
            this.cmd_ofen_add.Text = "Ofen gereinigt";
            this.cmd_ofen_add.UseVisualStyleBackColor = true;
            this.cmd_ofen_add.Click += new System.EventHandler(this.cmdAddOfen_click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 10;
            this.label19.Text = "Person";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Lan";
            // 
            // cb_ofen_person
            // 
            this.cb_ofen_person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ofen_person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ofen_person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ofen_person.FormattingEnabled = true;
            this.cb_ofen_person.Location = new System.Drawing.Point(67, 33);
            this.cb_ofen_person.Name = "cb_ofen_person";
            this.cb_ofen_person.Size = new System.Drawing.Size(121, 21);
            this.cb_ofen_person.TabIndex = 6;
            // 
            // cb_ofen_lan
            // 
            this.cb_ofen_lan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_ofen_lan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_ofen_lan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ofen_lan.FormattingEnabled = true;
            this.cb_ofen_lan.Location = new System.Drawing.Point(67, 6);
            this.cb_ofen_lan.Name = "cb_ofen_lan";
            this.cb_ofen_lan.Size = new System.Drawing.Size(121, 21);
            this.cb_ofen_lan.TabIndex = 5;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.cb_teilnahme_delete_person);
            this.tabPage6.Controls.Add(this.label24);
            this.tabPage6.Controls.Add(this.cb_teiln_delete_datum);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.cmd_teiln_delete);
            this.tabPage6.Controls.Add(this.label22);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.cmd_teiln_add);
            this.tabPage6.Controls.Add(this.cb_teiln_add_lan);
            this.tabPage6.Controls.Add(this.cb_teiln_add_person);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(445, 149);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Teilnahme";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // cb_teilnahme_delete_person
            // 
            this.cb_teilnahme_delete_person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_teilnahme_delete_person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_teilnahme_delete_person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_teilnahme_delete_person.FormattingEnabled = true;
            this.cb_teilnahme_delete_person.Location = new System.Drawing.Point(286, 33);
            this.cb_teilnahme_delete_person.Name = "cb_teilnahme_delete_person";
            this.cb_teilnahme_delete_person.Size = new System.Drawing.Size(135, 21);
            this.cb_teilnahme_delete_person.TabIndex = 16;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(229, 36);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 13);
            this.label24.TabIndex = 15;
            this.label24.Text = "Person";
            // 
            // cb_teiln_delete_datum
            // 
            this.cb_teiln_delete_datum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_teiln_delete_datum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_teiln_delete_datum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_teiln_delete_datum.FormattingEnabled = true;
            this.cb_teiln_delete_datum.Location = new System.Drawing.Point(286, 6);
            this.cb_teiln_delete_datum.Name = "cb_teiln_delete_datum";
            this.cb_teiln_delete_datum.Size = new System.Drawing.Size(135, 21);
            this.cb_teiln_delete_datum.TabIndex = 14;
            this.cb_teiln_delete_datum.SelectedValueChanged += new System.EventHandler(this.cb_teiln_delete_datum_SelectedValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(229, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(51, 13);
            this.label23.TabIndex = 13;
            this.label23.Text = "Löschen:";
            // 
            // cmd_teiln_delete
            // 
            this.cmd_teiln_delete.Location = new System.Drawing.Point(232, 86);
            this.cmd_teiln_delete.Name = "cmd_teiln_delete";
            this.cmd_teiln_delete.Size = new System.Drawing.Size(189, 23);
            this.cmd_teiln_delete.TabIndex = 11;
            this.cmd_teiln_delete.Text = "Teilnahme löschen";
            this.cmd_teiln_delete.UseVisualStyleBackColor = true;
            this.cmd_teiln_delete.Click += new System.EventHandler(this.cmd_teiln_delete_click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Lan";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 9);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(40, 13);
            this.label21.TabIndex = 9;
            this.label21.Text = "Person";
            // 
            // cmd_teiln_add
            // 
            this.cmd_teiln_add.Location = new System.Drawing.Point(6, 86);
            this.cmd_teiln_add.Name = "cmd_teiln_add";
            this.cmd_teiln_add.Size = new System.Drawing.Size(206, 23);
            this.cmd_teiln_add.TabIndex = 8;
            this.cmd_teiln_add.Text = "Teilnahme eintragen";
            this.cmd_teiln_add.UseVisualStyleBackColor = true;
            this.cmd_teiln_add.Click += new System.EventHandler(this.cmd_teiln_add_Click);
            // 
            // cb_teiln_add_lan
            // 
            this.cb_teiln_add_lan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_teiln_add_lan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_teiln_add_lan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_teiln_add_lan.FormattingEnabled = true;
            this.cb_teiln_add_lan.Location = new System.Drawing.Point(91, 33);
            this.cb_teiln_add_lan.Name = "cb_teiln_add_lan";
            this.cb_teiln_add_lan.Size = new System.Drawing.Size(121, 21);
            this.cb_teiln_add_lan.TabIndex = 6;
            // 
            // cb_teiln_add_person
            // 
            this.cb_teiln_add_person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_teiln_add_person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_teiln_add_person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_teiln_add_person.FormattingEnabled = true;
            this.cb_teiln_add_person.Location = new System.Drawing.Point(91, 6);
            this.cb_teiln_add_person.Name = "cb_teiln_add_person";
            this.cb_teiln_add_person.Size = new System.Drawing.Size(121, 21);
            this.cb_teiln_add_person.TabIndex = 5;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmdDeleteDienst);
            this.tabPage5.Controls.Add(this.cmdAddDienst);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.txtDienstName);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.cb_dienste_id);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(445, 149);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dienste";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmdDeleteDienst
            // 
            this.cmdDeleteDienst.Location = new System.Drawing.Point(224, 86);
            this.cmdDeleteDienst.Name = "cmdDeleteDienst";
            this.cmdDeleteDienst.Size = new System.Drawing.Size(189, 23);
            this.cmdDeleteDienst.TabIndex = 4;
            this.cmdDeleteDienst.Text = "Dienst Löschen";
            this.cmdDeleteDienst.UseVisualStyleBackColor = true;
            this.cmdDeleteDienst.Click += new System.EventHandler(this.cmdDeleteDienst_Click);
            // 
            // cmdAddDienst
            // 
            this.cmdAddDienst.Location = new System.Drawing.Point(9, 86);
            this.cmdAddDienst.Name = "cmdAddDienst";
            this.cmdAddDienst.Size = new System.Drawing.Size(206, 23);
            this.cmdAddDienst.TabIndex = 2;
            this.cmdAddDienst.Text = "Dienst Hinzufügen";
            this.cmdAddDienst.UseVisualStyleBackColor = true;
            this.cmdAddDienst.Click += new System.EventHandler(this.cmdAddDienst_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hinzufügen:";
            // 
            // txtDienstName
            // 
            this.txtDienstName.Location = new System.Drawing.Point(97, 6);
            this.txtDienstName.Name = "txtDienstName";
            this.txtDienstName.Size = new System.Drawing.Size(118, 20);
            this.txtDienstName.TabIndex = 1;
            this.txtDienstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDienstName_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Löschen:";
            // 
            // cb_dienste_id
            // 
            this.cb_dienste_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_dienste_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_dienste_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dienste_id.FormattingEnabled = true;
            this.cb_dienste_id.Location = new System.Drawing.Point(292, 6);
            this.cb_dienste_id.Name = "cb_dienste_id";
            this.cb_dienste_id.Size = new System.Drawing.Size(121, 21);
            this.cb_dienste_id.TabIndex = 3;
            this.cb_dienste_id.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cb_dienste_id_KeyDown);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmd_keys_del);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.cb_keys_del_key);
            this.tabPage4.Controls.Add(this.cb_keys_del_spiel);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.cb_keys_del_person);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.cmd_keys_add);
            this.tabPage4.Controls.Add(this.txt_keys_key);
            this.tabPage4.Controls.Add(this.cb_keys_person);
            this.tabPage4.Controls.Add(this.cb_keys_spiel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(445, 149);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Keys";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmd_keys_del
            // 
            this.cmd_keys_del.Location = new System.Drawing.Point(222, 86);
            this.cmd_keys_del.Name = "cmd_keys_del";
            this.cmd_keys_del.Size = new System.Drawing.Size(209, 23);
            this.cmd_keys_del.TabIndex = 17;
            this.cmd_keys_del.Text = "Key entfernen";
            this.cmd_keys_del.UseVisualStyleBackColor = true;
            this.cmd_keys_del.Click += new System.EventHandler(this.cmd_keys_del_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(219, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Key";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(219, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Spiel";
            // 
            // cb_keys_del_key
            // 
            this.cb_keys_del_key.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_keys_del_key.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_keys_del_key.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_keys_del_key.FormattingEnabled = true;
            this.cb_keys_del_key.Location = new System.Drawing.Point(265, 60);
            this.cb_keys_del_key.Name = "cb_keys_del_key";
            this.cb_keys_del_key.Size = new System.Drawing.Size(166, 21);
            this.cb_keys_del_key.TabIndex = 14;
            // 
            // cb_keys_del_spiel
            // 
            this.cb_keys_del_spiel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_keys_del_spiel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_keys_del_spiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_keys_del_spiel.FormattingEnabled = true;
            this.cb_keys_del_spiel.Location = new System.Drawing.Point(265, 33);
            this.cb_keys_del_spiel.Name = "cb_keys_del_spiel";
            this.cb_keys_del_spiel.Size = new System.Drawing.Size(166, 21);
            this.cb_keys_del_spiel.TabIndex = 13;
            this.cb_keys_del_spiel.SelectedValueChanged += new System.EventHandler(this.cb_keys_del_spiel_SelectedValueChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(219, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Person";
            // 
            // cb_keys_del_person
            // 
            this.cb_keys_del_person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_keys_del_person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_keys_del_person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_keys_del_person.FormattingEnabled = true;
            this.cb_keys_del_person.Location = new System.Drawing.Point(265, 6);
            this.cb_keys_del_person.Name = "cb_keys_del_person";
            this.cb_keys_del_person.Size = new System.Drawing.Size(166, 21);
            this.cb_keys_del_person.TabIndex = 11;
            this.cb_keys_del_person.SelectedValueChanged += new System.EventHandler(this.cb_keys_del_person_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Gamekey";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Person";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Spiel";
            // 
            // cmd_keys_add
            // 
            this.cmd_keys_add.Location = new System.Drawing.Point(13, 86);
            this.cmd_keys_add.Name = "cmd_keys_add";
            this.cmd_keys_add.Size = new System.Drawing.Size(180, 23);
            this.cmd_keys_add.TabIndex = 7;
            this.cmd_keys_add.Text = "Key hinzufügen";
            this.cmd_keys_add.UseVisualStyleBackColor = true;
            this.cmd_keys_add.Click += new System.EventHandler(this.cmd_keys_add_Click);
            // 
            // txt_keys_key
            // 
            this.txt_keys_key.Location = new System.Drawing.Point(72, 60);
            this.txt_keys_key.Name = "txt_keys_key";
            this.txt_keys_key.Size = new System.Drawing.Size(121, 20);
            this.txt_keys_key.TabIndex = 6;
            // 
            // cb_keys_person
            // 
            this.cb_keys_person.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_keys_person.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_keys_person.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_keys_person.FormattingEnabled = true;
            this.cb_keys_person.Location = new System.Drawing.Point(72, 33);
            this.cb_keys_person.Name = "cb_keys_person";
            this.cb_keys_person.Size = new System.Drawing.Size(121, 21);
            this.cb_keys_person.TabIndex = 5;
            // 
            // cb_keys_spiel
            // 
            this.cb_keys_spiel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_keys_spiel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_keys_spiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_keys_spiel.FormattingEnabled = true;
            this.cb_keys_spiel.Location = new System.Drawing.Point(72, 6);
            this.cb_keys_spiel.Name = "cb_keys_spiel";
            this.cb_keys_spiel.Size = new System.Drawing.Size(121, 21);
            this.cb_keys_spiel.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.txt_spiele_add_kosten);
            this.tabPage3.Controls.Add(this.txt_spiele_name);
            this.tabPage3.Controls.Add(this.cb_spiele_id);
            this.tabPage3.Controls.Add(this.cmdDeleteSpiel);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.cb_spiele_dienst);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.cmdAddSpiel);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(445, 149);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Spiele";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 63);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 9;
            this.label20.Text = "Kosten";
            // 
            // txt_spiele_add_kosten
            // 
            this.txt_spiele_add_kosten.Location = new System.Drawing.Point(68, 60);
            this.txt_spiele_add_kosten.Name = "txt_spiele_add_kosten";
            this.txt_spiele_add_kosten.Size = new System.Drawing.Size(121, 20);
            this.txt_spiele_add_kosten.TabIndex = 8;
            // 
            // txt_spiele_name
            // 
            this.txt_spiele_name.Location = new System.Drawing.Point(68, 6);
            this.txt_spiele_name.Name = "txt_spiele_name";
            this.txt_spiele_name.Size = new System.Drawing.Size(121, 20);
            this.txt_spiele_name.TabIndex = 1;
            // 
            // cb_spiele_id
            // 
            this.cb_spiele_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_spiele_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_spiele_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_spiele_id.FormattingEnabled = true;
            this.cb_spiele_id.Location = new System.Drawing.Point(242, 6);
            this.cb_spiele_id.Name = "cb_spiele_id";
            this.cb_spiele_id.Size = new System.Drawing.Size(121, 21);
            this.cb_spiele_id.TabIndex = 4;
            // 
            // cmdDeleteSpiel
            // 
            this.cmdDeleteSpiel.Location = new System.Drawing.Point(204, 86);
            this.cmdDeleteSpiel.Name = "cmdDeleteSpiel";
            this.cmdDeleteSpiel.Size = new System.Drawing.Size(159, 23);
            this.cmdDeleteSpiel.TabIndex = 5;
            this.cmdDeleteSpiel.Text = "Spiel Löschen";
            this.cmdDeleteSpiel.UseVisualStyleBackColor = true;
            this.cmdDeleteSpiel.Click += new System.EventHandler(this.cmdDeleteSpiel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dienst";
            // 
            // cb_spiele_dienst
            // 
            this.cb_spiele_dienst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_spiele_dienst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_spiele_dienst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_spiele_dienst.FormattingEnabled = true;
            this.cb_spiele_dienst.Location = new System.Drawing.Point(68, 32);
            this.cb_spiele_dienst.Name = "cb_spiele_dienst";
            this.cb_spiele_dienst.Size = new System.Drawing.Size(121, 21);
            this.cb_spiele_dienst.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spielname";
            // 
            // cmdAddSpiel
            // 
            this.cmdAddSpiel.Location = new System.Drawing.Point(9, 86);
            this.cmdAddSpiel.Name = "cmdAddSpiel";
            this.cmdAddSpiel.Size = new System.Drawing.Size(180, 23);
            this.cmdAddSpiel.TabIndex = 3;
            this.cmdAddSpiel.Text = "Spiel hinzufügen";
            this.cmdAddSpiel.UseVisualStyleBackColor = true;
            this.cmdAddSpiel.Click += new System.EventHandler(this.cmdAddSpiel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb_personen_id);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txt_personen_email);
            this.tabPage2.Controls.Add(this.txt_personen_telefon);
            this.tabPage2.Controls.Add(this.txt_personen_adresse);
            this.tabPage2.Controls.Add(this.txt_personen_name);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.cmd_personen_delete);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.cmd_personen_add);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(445, 149);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personen";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb_personen_id
            // 
            this.cb_personen_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_personen_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_personen_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_personen_id.FormattingEnabled = true;
            this.cb_personen_id.Location = new System.Drawing.Point(260, 8);
            this.cb_personen_id.Name = "cb_personen_id";
            this.cb_personen_id.Size = new System.Drawing.Size(135, 21);
            this.cb_personen_id.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "EMail";
            // 
            // txt_personen_email
            // 
            this.txt_personen_email.Location = new System.Drawing.Point(97, 86);
            this.txt_personen_email.Name = "txt_personen_email";
            this.txt_personen_email.Size = new System.Drawing.Size(100, 20);
            this.txt_personen_email.TabIndex = 11;
            // 
            // txt_personen_telefon
            // 
            this.txt_personen_telefon.Location = new System.Drawing.Point(97, 60);
            this.txt_personen_telefon.Name = "txt_personen_telefon";
            this.txt_personen_telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_personen_telefon.TabIndex = 8;
            this.txt_personen_telefon.TextChanged += new System.EventHandler(this.txt_personen_telefon_TextChanged);
            // 
            // txt_personen_adresse
            // 
            this.txt_personen_adresse.Location = new System.Drawing.Point(97, 34);
            this.txt_personen_adresse.Name = "txt_personen_adresse";
            this.txt_personen_adresse.Size = new System.Drawing.Size(100, 20);
            this.txt_personen_adresse.TabIndex = 7;
            // 
            // txt_personen_name
            // 
            this.txt_personen_name.Location = new System.Drawing.Point(97, 8);
            this.txt_personen_name.Name = "txt_personen_name";
            this.txt_personen_name.Size = new System.Drawing.Size(100, 20);
            this.txt_personen_name.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Adresse";
            // 
            // cmd_personen_delete
            // 
            this.cmd_personen_delete.Location = new System.Drawing.Point(260, 112);
            this.cmd_personen_delete.Name = "cmd_personen_delete";
            this.cmd_personen_delete.Size = new System.Drawing.Size(135, 23);
            this.cmd_personen_delete.TabIndex = 6;
            this.cmd_personen_delete.Text = "Person löschen";
            this.cmd_personen_delete.UseVisualStyleBackColor = true;
            this.cmd_personen_delete.Click += new System.EventHandler(this.cmd_personen_delete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Personenname";
            // 
            // cmd_personen_add
            // 
            this.cmd_personen_add.Location = new System.Drawing.Point(9, 112);
            this.cmd_personen_add.Name = "cmd_personen_add";
            this.cmd_personen_add.Size = new System.Drawing.Size(188, 23);
            this.cmd_personen_add.TabIndex = 2;
            this.cmd_personen_add.Text = "Person hinzufügen";
            this.cmd_personen_add.UseVisualStyleBackColor = true;
            this.cmd_personen_add.Click += new System.EventHandler(this.cmd_personen_add_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.datetime_lan_add);
            this.tabPage1.Controls.Add(this.cmd_lan_entfernen);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.cb_lans_id);
            this.tabPage1.Controls.Add(this.cmd_lan_add);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 149);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lans";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // datetime_lan_add
            // 
            this.datetime_lan_add.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datetime_lan_add.Location = new System.Drawing.Point(50, 6);
            this.datetime_lan_add.Name = "datetime_lan_add";
            this.datetime_lan_add.Size = new System.Drawing.Size(100, 20);
            this.datetime_lan_add.TabIndex = 8;
            this.datetime_lan_add.Value = new System.DateTime(2016, 2, 19, 0, 0, 0, 0);
            // 
            // cmd_lan_entfernen
            // 
            this.cmd_lan_entfernen.Location = new System.Drawing.Point(235, 75);
            this.cmd_lan_entfernen.Name = "cmd_lan_entfernen";
            this.cmd_lan_entfernen.Size = new System.Drawing.Size(159, 23);
            this.cmd_lan_entfernen.TabIndex = 7;
            this.cmd_lan_entfernen.Text = "Lan entfernen";
            this.cmd_lan_entfernen.UseVisualStyleBackColor = true;
            this.cmd_lan_entfernen.Click += new System.EventHandler(this.cmd_lan_entfernen_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lan";
            // 
            // cb_lans_id
            // 
            this.cb_lans_id.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_lans_id.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_lans_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_lans_id.FormattingEnabled = true;
            this.cb_lans_id.Location = new System.Drawing.Point(273, 6);
            this.cb_lans_id.Name = "cb_lans_id";
            this.cb_lans_id.Size = new System.Drawing.Size(121, 21);
            this.cb_lans_id.TabIndex = 5;
            // 
            // cmd_lan_add
            // 
            this.cmd_lan_add.Location = new System.Drawing.Point(9, 75);
            this.cmd_lan_add.Name = "cmd_lan_add";
            this.cmd_lan_add.Size = new System.Drawing.Size(141, 23);
            this.cmd_lan_add.TabIndex = 4;
            this.cmd_lan_add.Text = "Lan hinzufügen";
            this.cmd_lan_add.UseVisualStyleBackColor = true;
            this.cmd_lan_add.Click += new System.EventHandler(this.cmd_lan_add_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Datum";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(453, 175);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // panel_status
            // 
            this.panel_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_status.Controls.Add(this.lb_status);
            this.panel_status.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_status.Location = new System.Drawing.Point(0, 0);
            this.panel_status.Name = "panel_status";
            this.panel_status.Padding = new System.Windows.Forms.Padding(3);
            this.panel_status.Size = new System.Drawing.Size(461, 93);
            this.panel_status.TabIndex = 8;
            // 
            // panel_grid
            // 
            this.panel_grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_grid.Controls.Add(this.gridViewLans);
            this.panel_grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_grid.Location = new System.Drawing.Point(0, 0);
            this.panel_grid.Margin = new System.Windows.Forms.Padding(6);
            this.panel_grid.Name = "panel_grid";
            this.panel_grid.Padding = new System.Windows.Forms.Padding(3);
            this.panel_grid.Size = new System.Drawing.Size(309, 280);
            this.panel_grid.TabIndex = 9;
            // 
            // panel_tabs
            // 
            this.panel_tabs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_tabs.Controls.Add(this.tabControl1);
            this.panel_tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tabs.Location = new System.Drawing.Point(0, 0);
            this.panel_tabs.MaximumSize = new System.Drawing.Size(461, 183);
            this.panel_tabs.MinimumSize = new System.Drawing.Size(461, 183);
            this.panel_tabs.Name = "panel_tabs";
            this.panel_tabs.Padding = new System.Windows.Forms.Padding(3);
            this.panel_tabs.Size = new System.Drawing.Size(461, 183);
            this.panel_tabs.TabIndex = 10;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 461;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel_grid);
            this.splitContainer1.Size = new System.Drawing.Size(774, 280);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 11;
            this.splitContainer1.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel_tabs);
            this.splitContainer2.Panel1MinSize = 183;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel_status);
            this.splitContainer2.Size = new System.Drawing.Size(461, 280);
            this.splitContainer2.SplitterDistance = 183;
            this.splitContainer2.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(774, 280);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(790, 319);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lansBindingSource)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel_status.ResumeLayout(false);
            this.panel_grid.ResumeLayout(false);
            this.panel_tabs.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lb_status;
        private System.Windows.Forms.DataGridView gridViewLans;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private lanDataSet lanDataSet;
        private System.Windows.Forms.BindingSource lansBindingSource;
        private lanDataSetTableAdapters.lansTableAdapter lansTableAdapter;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.Button cmd_ofen_add;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cb_ofen_person;
        private System.Windows.Forms.ComboBox cb_ofen_lan;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.ComboBox cb_teilnahme_delete_person;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cb_teiln_delete_datum;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button cmd_teiln_delete;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button cmd_teiln_add;
        private System.Windows.Forms.ComboBox cb_teiln_add_lan;
        private System.Windows.Forms.ComboBox cb_teiln_add_person;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button cmdDeleteDienst;
        private System.Windows.Forms.Button cmdAddDienst;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDienstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_dienste_id;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button cmd_keys_del;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cb_keys_del_key;
        private System.Windows.Forms.ComboBox cb_keys_del_spiel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_keys_del_person;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cmd_keys_add;
        private System.Windows.Forms.TextBox txt_keys_key;
        private System.Windows.Forms.ComboBox cb_keys_person;
        private System.Windows.Forms.ComboBox cb_keys_spiel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_spiele_add_kosten;
        private System.Windows.Forms.TextBox txt_spiele_name;
        private System.Windows.Forms.ComboBox cb_spiele_id;
        private System.Windows.Forms.Button cmdDeleteSpiel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_spiele_dienst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdAddSpiel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cb_personen_id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_personen_email;
        private System.Windows.Forms.TextBox txt_personen_telefon;
        private System.Windows.Forms.TextBox txt_personen_adresse;
        private System.Windows.Forms.TextBox txt_personen_name;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cmd_personen_delete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cmd_personen_add;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker datetime_lan_add;
        private System.Windows.Forms.Button cmd_lan_entfernen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_lans_id;
        private System.Windows.Forms.Button cmd_lan_add;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel_status;
        private System.Windows.Forms.Panel panel_grid;
        private System.Windows.Forms.Panel panel_tabs;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
    }
}

