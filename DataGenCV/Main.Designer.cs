namespace DataGenCV
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbCameras = new System.Windows.Forms.GroupBox();
            this.cbResolutions = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConnectCamera = new System.Windows.Forms.Button();
            this.btnUpdateCameras = new System.Windows.Forms.Button();
            this.cbCameras = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLoadData = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.btnTakePoint = new System.Windows.Forms.Button();
            this.gbSettings = new System.Windows.Forms.GroupBox();
            this.tbBMax = new System.Windows.Forms.TrackBar();
            this.tbBMin = new System.Windows.Forms.TrackBar();
            this.tbGMax = new System.Windows.Forms.TrackBar();
            this.tbGMin = new System.Windows.Forms.TrackBar();
            this.tbRMax = new System.Windows.Forms.TrackBar();
            this.tbRMin = new System.Windows.Forms.TrackBar();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPoints = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFeature2 = new System.Windows.Forms.Button();
            this.btnFeature1 = new System.Windows.Forms.Button();
            this.tbArea2 = new System.Windows.Forms.NumericUpDown();
            this.tbArea1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lRMin = new System.Windows.Forms.Label();
            this.lRMax = new System.Windows.Forms.Label();
            this.lGMin = new System.Windows.Forms.Label();
            this.lGMax = new System.Windows.Forms.Label();
            this.lBMin = new System.Windows.Forms.Label();
            this.lBMax = new System.Windows.Forms.Label();
            this.settingsValuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.u1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.u2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carPendulumPostureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbCameras.SuspendLayout();
            this.gbSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRMin)).BeginInit();
            this.gbPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsValuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPendulumPostureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCameras
            // 
            this.gbCameras.Controls.Add(this.cbResolutions);
            this.gbCameras.Controls.Add(this.label9);
            this.gbCameras.Controls.Add(this.btnConnectCamera);
            this.gbCameras.Controls.Add(this.btnUpdateCameras);
            this.gbCameras.Controls.Add(this.cbCameras);
            this.gbCameras.Controls.Add(this.label1);
            this.gbCameras.Location = new System.Drawing.Point(12, 12);
            this.gbCameras.Name = "gbCameras";
            this.gbCameras.Size = new System.Drawing.Size(497, 187);
            this.gbCameras.TabIndex = 0;
            this.gbCameras.TabStop = false;
            this.gbCameras.Text = "Paso 1: Selección de cámara";
            // 
            // cbResolutions
            // 
            this.cbResolutions.FormattingEnabled = true;
            this.cbResolutions.Location = new System.Drawing.Point(187, 74);
            this.cbResolutions.Name = "cbResolutions";
            this.cbResolutions.Size = new System.Drawing.Size(304, 28);
            this.cbResolutions.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Seleccionar Resolución:";
            // 
            // btnConnectCamera
            // 
            this.btnConnectCamera.BackgroundImage = global::DataGenCV.Properties.Resources.connect_icon;
            this.btnConnectCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnectCamera.Location = new System.Drawing.Point(431, 117);
            this.btnConnectCamera.Name = "btnConnectCamera";
            this.btnConnectCamera.Size = new System.Drawing.Size(60, 60);
            this.btnConnectCamera.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnConnectCamera, "Conectar Cámara");
            this.btnConnectCamera.UseVisualStyleBackColor = true;
            this.btnConnectCamera.Click += new System.EventHandler(this.btnConnectCamera_Click);
            // 
            // btnUpdateCameras
            // 
            this.btnUpdateCameras.BackgroundImage = global::DataGenCV.Properties.Resources.Button_Refresh_icon;
            this.btnUpdateCameras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateCameras.Location = new System.Drawing.Point(10, 117);
            this.btnUpdateCameras.Name = "btnUpdateCameras";
            this.btnUpdateCameras.Size = new System.Drawing.Size(60, 60);
            this.btnUpdateCameras.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnUpdateCameras, "Recargar lista de cámaras");
            this.btnUpdateCameras.UseVisualStyleBackColor = true;
            this.btnUpdateCameras.Click += new System.EventHandler(this.btnUpdateCameras_Click);
            // 
            // cbCameras
            // 
            this.cbCameras.FormattingEnabled = true;
            this.cbCameras.Location = new System.Drawing.Point(173, 31);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(318, 28);
            this.cbCameras.TabIndex = 1;
            this.cbCameras.SelectedIndexChanged += new System.EventHandler(this.cbCameras_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cámaras detectadas:";
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackgroundImage = global::DataGenCV.Properties.Resources.open_file_icon;
            this.btnLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLoadData.Location = new System.Drawing.Point(606, 765);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Size = new System.Drawing.Size(60, 60);
            this.btnLoadData.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnLoadData, "Cargar configuración del filtro");
            this.btnLoadData.UseVisualStyleBackColor = true;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackgroundImage = global::DataGenCV.Properties.Resources.Save_icon;
            this.btnSaveData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveData.Location = new System.Drawing.Point(971, 765);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(60, 60);
            this.btnSaveData.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnSaveData, "Guardar datos");
            this.btnSaveData.UseVisualStyleBackColor = true;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.BackgroundImage = global::DataGenCV.Properties.Resources.Save;
            this.btnSaveSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveSettings.Location = new System.Drawing.Point(540, 765);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(60, 60);
            this.btnSaveSettings.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnSaveSettings, "Guardar configuración del filtro");
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // btnTakePoint
            // 
            this.btnTakePoint.BackgroundImage = global::DataGenCV.Properties.Resources.Actions_media_record_icon;
            this.btnTakePoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTakePoint.Location = new System.Drawing.Point(7, 3);
            this.btnTakePoint.Name = "btnTakePoint";
            this.btnTakePoint.Size = new System.Drawing.Size(60, 60);
            this.btnTakePoint.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnTakePoint, "Conectar Cámara");
            this.btnTakePoint.UseVisualStyleBackColor = true;
            this.btnTakePoint.Click += new System.EventHandler(this.btnTakePoint_Click);
            // 
            // gbSettings
            // 
            this.gbSettings.Controls.Add(this.lBMax);
            this.gbSettings.Controls.Add(this.lBMin);
            this.gbSettings.Controls.Add(this.lGMax);
            this.gbSettings.Controls.Add(this.lGMin);
            this.gbSettings.Controls.Add(this.lRMax);
            this.gbSettings.Controls.Add(this.lRMin);
            this.gbSettings.Controls.Add(this.tbBMax);
            this.gbSettings.Controls.Add(this.tbBMin);
            this.gbSettings.Controls.Add(this.tbGMax);
            this.gbSettings.Controls.Add(this.tbGMin);
            this.gbSettings.Controls.Add(this.tbRMax);
            this.gbSettings.Controls.Add(this.tbRMin);
            this.gbSettings.Controls.Add(this.cbFilter);
            this.gbSettings.Controls.Add(this.label4);
            this.gbSettings.Controls.Add(this.label3);
            this.gbSettings.Controls.Add(this.label2);
            this.gbSettings.Location = new System.Drawing.Point(12, 205);
            this.gbSettings.Name = "gbSettings";
            this.gbSettings.Size = new System.Drawing.Size(497, 471);
            this.gbSettings.TabIndex = 1;
            this.gbSettings.TabStop = false;
            this.gbSettings.Text = "Paso 2: Configurar Filtro";
            // 
            // tbBMax
            // 
            this.tbBMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "BMax", true));
            this.tbBMax.Location = new System.Drawing.Point(132, 377);
            this.tbBMax.Maximum = 255;
            this.tbBMax.Name = "tbBMax";
            this.tbBMax.Size = new System.Drawing.Size(357, 69);
            this.tbBMax.TabIndex = 18;
            this.tbBMax.Value = 255;
            this.tbBMax.ValueChanged += new System.EventHandler(this.tbBMax_ValueChanged);
            // 
            // tbBMin
            // 
            this.tbBMin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "BMin", true));
            this.tbBMin.Location = new System.Drawing.Point(132, 308);
            this.tbBMin.Maximum = 255;
            this.tbBMin.Name = "tbBMin";
            this.tbBMin.Size = new System.Drawing.Size(357, 69);
            this.tbBMin.TabIndex = 17;
            this.tbBMin.ValueChanged += new System.EventHandler(this.tbBMin_ValueChanged);
            // 
            // tbGMax
            // 
            this.tbGMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "GMax", true));
            this.tbGMax.Location = new System.Drawing.Point(132, 239);
            this.tbGMax.Maximum = 255;
            this.tbGMax.Name = "tbGMax";
            this.tbGMax.Size = new System.Drawing.Size(357, 69);
            this.tbGMax.TabIndex = 16;
            this.tbGMax.Value = 255;
            this.tbGMax.ValueChanged += new System.EventHandler(this.tbGMax_ValueChanged);
            // 
            // tbGMin
            // 
            this.tbGMin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "GMin", true));
            this.tbGMin.Location = new System.Drawing.Point(132, 170);
            this.tbGMin.Maximum = 255;
            this.tbGMin.Name = "tbGMin";
            this.tbGMin.Size = new System.Drawing.Size(357, 69);
            this.tbGMin.TabIndex = 15;
            this.tbGMin.ValueChanged += new System.EventHandler(this.tbGMin_ValueChanged);
            // 
            // tbRMax
            // 
            this.tbRMax.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "RMax", true));
            this.tbRMax.Location = new System.Drawing.Point(133, 125);
            this.tbRMax.Maximum = 255;
            this.tbRMax.Name = "tbRMax";
            this.tbRMax.Size = new System.Drawing.Size(357, 69);
            this.tbRMax.TabIndex = 14;
            this.tbRMax.Value = 255;
            this.tbRMax.ValueChanged += new System.EventHandler(this.tbRMax_ValueChanged);
            // 
            // tbRMin
            // 
            this.tbRMin.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "RMin", true));
            this.tbRMin.Location = new System.Drawing.Point(132, 32);
            this.tbRMin.Maximum = 255;
            this.tbRMin.Name = "tbRMin";
            this.tbRMin.Size = new System.Drawing.Size(357, 69);
            this.tbRMin.TabIndex = 13;
            this.tbRMin.Scroll += new System.EventHandler(this.tbRMin_Scroll);
            this.tbRMin.ValueChanged += new System.EventHandler(this.tbRMin_ValueChanged);
            this.tbRMin.Validated += new System.EventHandler(this.tbRMin_Validated);
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Location = new System.Drawing.Point(6, 441);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(123, 24);
            this.cbFilter.TabIndex = 12;
            this.cbFilter.Text = "Mostrar filtro";
            this.cbFilter.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Niveles de Azul:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Niveles de Verde:";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Niveles de Rojo:";
            // 
            // gbPoints
            // 
            this.gbPoints.Controls.Add(this.dataGridView1);
            this.gbPoints.Controls.Add(this.panel1);
            this.gbPoints.Location = new System.Drawing.Point(537, 12);
            this.gbPoints.Name = "gbPoints";
            this.gbPoints.Size = new System.Drawing.Size(497, 747);
            this.gbPoints.TabIndex = 2;
            this.gbPoints.TabStop = false;
            this.gbPoints.Text = "Paso 4: Capturar puntos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.u1DataGridViewTextBoxColumn,
            this.v1DataGridViewTextBoxColumn,
            this.u2DataGridViewTextBoxColumn,
            this.v2DataGridViewTextBoxColumn,
            this.xDataGridViewTextBoxColumn,
            this.angleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carPendulumPostureBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(491, 653);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.btnTakePoint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 69);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(491, 3);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFeature2);
            this.groupBox1.Controls.Add(this.btnFeature1);
            this.groupBox1.Controls.Add(this.tbArea2);
            this.groupBox1.Controls.Add(this.tbArea1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(6, 682);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(497, 119);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paso 3: Seleccionar Características";
            // 
            // btnFeature2
            // 
            this.btnFeature2.Location = new System.Drawing.Point(187, 69);
            this.btnFeature2.Name = "btnFeature2";
            this.btnFeature2.Size = new System.Drawing.Size(219, 30);
            this.btnFeature2.TabIndex = 22;
            this.btnFeature2.Text = "Caracteristica 2";
            this.btnFeature2.UseVisualStyleBackColor = true;
            this.btnFeature2.Click += new System.EventHandler(this.btnFeature2_Click);
            // 
            // btnFeature1
            // 
            this.btnFeature1.Location = new System.Drawing.Point(187, 29);
            this.btnFeature1.Name = "btnFeature1";
            this.btnFeature1.Size = new System.Drawing.Size(219, 30);
            this.btnFeature1.TabIndex = 21;
            this.btnFeature1.Text = "Caracteristica 1";
            this.btnFeature1.UseVisualStyleBackColor = true;
            this.btnFeature1.Click += new System.EventHandler(this.btnFeature1_Click);
            // 
            // tbArea2
            // 
            this.tbArea2.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "Area2", true));
            this.tbArea2.Location = new System.Drawing.Point(72, 71);
            this.tbArea2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tbArea2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbArea2.Name = "tbArea2";
            this.tbArea2.Size = new System.Drawing.Size(95, 26);
            this.tbArea2.TabIndex = 20;
            this.tbArea2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tbArea1
            // 
            this.tbArea1.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsValuesBindingSource, "Area1", true));
            this.tbArea1.Location = new System.Drawing.Point(72, 31);
            this.tbArea1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.tbArea1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.tbArea1.Name = "tbArea1";
            this.tbArea1.Size = new System.Drawing.Size(95, 26);
            this.tbArea1.TabIndex = 19;
            this.tbArea1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Area 2:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Area 1:";
            // 
            // lRMin
            // 
            this.lRMin.AutoSize = true;
            this.lRMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsValuesBindingSource, "RMin", true));
            this.lRMin.Location = new System.Drawing.Point(90, 56);
            this.lRMin.Name = "lRMin";
            this.lRMin.Size = new System.Drawing.Size(18, 20);
            this.lRMin.TabIndex = 19;
            this.lRMin.Text = "0";
            // 
            // lRMax
            // 
            this.lRMax.AutoSize = true;
            this.lRMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsValuesBindingSource, "RMax", true));
            this.lRMax.Location = new System.Drawing.Point(90, 125);
            this.lRMax.Name = "lRMax";
            this.lRMax.Size = new System.Drawing.Size(36, 20);
            this.lRMax.TabIndex = 20;
            this.lRMax.Text = "255";
            // 
            // lGMin
            // 
            this.lGMin.AutoSize = true;
            this.lGMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsValuesBindingSource, "GMin", true));
            this.lGMin.Location = new System.Drawing.Point(90, 194);
            this.lGMin.Name = "lGMin";
            this.lGMin.Size = new System.Drawing.Size(18, 20);
            this.lGMin.TabIndex = 21;
            this.lGMin.Text = "0";
            // 
            // lGMax
            // 
            this.lGMax.AutoSize = true;
            this.lGMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsValuesBindingSource, "GMax", true));
            this.lGMax.Location = new System.Drawing.Point(90, 263);
            this.lGMax.Name = "lGMax";
            this.lGMax.Size = new System.Drawing.Size(36, 20);
            this.lGMax.TabIndex = 22;
            this.lGMax.Text = "255";
            // 
            // lBMin
            // 
            this.lBMin.AutoSize = true;
            this.lBMin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsValuesBindingSource, "BMin", true));
            this.lBMin.Location = new System.Drawing.Point(90, 332);
            this.lBMin.Name = "lBMin";
            this.lBMin.Size = new System.Drawing.Size(18, 20);
            this.lBMin.TabIndex = 23;
            this.lBMin.Text = "0";
            // 
            // lBMax
            // 
            this.lBMax.AutoSize = true;
            this.lBMax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsValuesBindingSource, "BMax", true));
            this.lBMax.Location = new System.Drawing.Point(90, 401);
            this.lBMax.Name = "lBMax";
            this.lBMax.Size = new System.Drawing.Size(36, 20);
            this.lBMax.TabIndex = 24;
            this.lBMax.Text = "255";
            // 
            // settingsValuesBindingSource
            // 
            this.settingsValuesBindingSource.DataSource = typeof(DataGenCV.Models.SettingsValues);
            // 
            // u1DataGridViewTextBoxColumn
            // 
            this.u1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.u1DataGridViewTextBoxColumn.DataPropertyName = "U1";
            this.u1DataGridViewTextBoxColumn.HeaderText = "U1";
            this.u1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.u1DataGridViewTextBoxColumn.Name = "u1DataGridViewTextBoxColumn";
            this.u1DataGridViewTextBoxColumn.ReadOnly = true;
            this.u1DataGridViewTextBoxColumn.Width = 66;
            // 
            // v1DataGridViewTextBoxColumn
            // 
            this.v1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            this.v1DataGridViewTextBoxColumn.HeaderText = "V1";
            this.v1DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            this.v1DataGridViewTextBoxColumn.ReadOnly = true;
            this.v1DataGridViewTextBoxColumn.Width = 65;
            // 
            // u2DataGridViewTextBoxColumn
            // 
            this.u2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.u2DataGridViewTextBoxColumn.DataPropertyName = "U2";
            this.u2DataGridViewTextBoxColumn.HeaderText = "U2";
            this.u2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.u2DataGridViewTextBoxColumn.Name = "u2DataGridViewTextBoxColumn";
            this.u2DataGridViewTextBoxColumn.ReadOnly = true;
            this.u2DataGridViewTextBoxColumn.Width = 66;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            this.v2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            this.v2DataGridViewTextBoxColumn.HeaderText = "V2";
            this.v2DataGridViewTextBoxColumn.MinimumWidth = 8;
            this.v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            this.v2DataGridViewTextBoxColumn.ReadOnly = true;
            this.v2DataGridViewTextBoxColumn.Width = 65;
            // 
            // xDataGridViewTextBoxColumn
            // 
            this.xDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.xDataGridViewTextBoxColumn.DataPropertyName = "X";
            this.xDataGridViewTextBoxColumn.HeaderText = "X";
            this.xDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.xDataGridViewTextBoxColumn.Name = "xDataGridViewTextBoxColumn";
            this.xDataGridViewTextBoxColumn.ReadOnly = true;
            this.xDataGridViewTextBoxColumn.Width = 56;
            // 
            // angleDataGridViewTextBoxColumn
            // 
            this.angleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.angleDataGridViewTextBoxColumn.DataPropertyName = "Angle";
            this.angleDataGridViewTextBoxColumn.HeaderText = "Angulo";
            this.angleDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.angleDataGridViewTextBoxColumn.Name = "angleDataGridViewTextBoxColumn";
            this.angleDataGridViewTextBoxColumn.ReadOnly = true;
            this.angleDataGridViewTextBoxColumn.Width = 95;
            // 
            // carPendulumPostureBindingSource
            // 
            this.carPendulumPostureBindingSource.DataSource = typeof(DataGenCV.Models.CarPendulumPosture);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 856);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnSaveSettings);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbPoints);
            this.Controls.Add(this.gbSettings);
            this.Controls.Add(this.gbCameras);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Generador de datos";
            this.gbCameras.ResumeLayout(false);
            this.gbCameras.PerformLayout();
            this.gbSettings.ResumeLayout(false);
            this.gbSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbBMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbRMin)).EndInit();
            this.gbPoints.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbArea1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsValuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPendulumPostureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCameras;
        private System.Windows.Forms.ComboBox cbCameras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateCameras;
        private System.Windows.Forms.Button btnConnectCamera;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbSettings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPoints;
        private System.Windows.Forms.Button btnTakePoint;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource carPendulumPostureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn u1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn u2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn angleDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbResolutions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.Button btnFeature2;
        private System.Windows.Forms.Button btnFeature1;
        private System.Windows.Forms.NumericUpDown tbArea2;
        private System.Windows.Forms.NumericUpDown tbArea1;
        private System.Windows.Forms.BindingSource settingsValuesBindingSource;
        private System.Windows.Forms.TrackBar tbBMax;
        private System.Windows.Forms.TrackBar tbBMin;
        private System.Windows.Forms.TrackBar tbGMax;
        private System.Windows.Forms.TrackBar tbGMin;
        private System.Windows.Forms.TrackBar tbRMax;
        private System.Windows.Forms.TrackBar tbRMin;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.Label lBMax;
        private System.Windows.Forms.Label lBMin;
        private System.Windows.Forms.Label lGMax;
        private System.Windows.Forms.Label lGMin;
        private System.Windows.Forms.Label lRMax;
        private System.Windows.Forms.Label lRMin;
    }
}

