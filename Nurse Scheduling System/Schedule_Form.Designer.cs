namespace Nurse_Scheduling_System
{
    partial class Schedule_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule_Form));
            this.repoPosition = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.pnlheader = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnminimize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnmaxmin = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlschedleft = new System.Windows.Forms.Panel();
            this.btninvetory = new System.Windows.Forms.Button();
            this.btnroom = new System.Windows.Forms.Button();
            this.btnpatient = new System.Windows.Forms.Button();
            this.btnnurse = new System.Windows.Forms.Button();
            this.btnschedule = new System.Windows.Forms.Button();
            this.btnpnlschedleftclose = new System.Windows.Forms.Button();
            this.pnlright = new System.Windows.Forms.Panel();
            this.pnlbottom = new System.Windows.Forms.Panel();
            this.pnlnotif = new System.Windows.Forms.Panel();
            this.lblnotif = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rsicon = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.btnaddsched = new System.Windows.Forms.Button();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlschedbody = new System.Windows.Forms.Panel();
            this.tabbody = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.clndrsched = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridschedules = new DevExpress.XtraGrid.GridControl();
            this.forightmed = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_schedule_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_schedule_nursefullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_schedule_title = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_schedule_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlschedtop = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.lblallsched = new System.Windows.Forms.Label();
            this.lblclear = new System.Windows.Forms.Label();
            this.lblcurrenttime = new System.Windows.Forms.Label();
            this.lblcurrentdate = new System.Windows.Forms.Label();
            this.lbldateselected = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.btnsearch = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtsearch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlview = new DevExpress.XtraEditors.PanelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pnlbodynurse = new System.Windows.Forms.Panel();
            this.pnlbodynurse1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRecovery = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFullname = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbPosition = new Bunifu.Framework.UI.BunifuDropdown();
            this.lsvMedicine = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlpatient = new System.Windows.Forms.Panel();
            this.pnlpatient1 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel14 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnPatientDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPatientSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmbRooms = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel13 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lsvPatient = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel10 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnRoomSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRoomDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lsvRoom = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lsvSupplies = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpManufactured = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel15 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInventorySave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAdd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSupplyName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel16 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel18 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lsvTransaction = new System.Windows.Forms.ListView();
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader56 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.bunifuCustomLabel19 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel20 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnMedicineCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicineQuantity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtMedicineName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel21 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel22 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel23 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel24 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel25 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lsvMedicineTransaction = new System.Windows.Forms.ListView();
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader57 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvMedicineInventory = new System.Windows.Forms.ListView();
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtpMedicineExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpMedicineManufactured = new System.Windows.Forms.DateTimePicker();
            this.lsvMedInventory = new System.Windows.Forms.ListView();
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMedicineInventorySave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtBatch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStock = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel26 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel27 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMedicineType = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel28 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMedicineInventoryName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel29 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel30 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel31 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.xtraTabPage9 = new DevExpress.XtraTab.XtraTabPage();
            this.panel11 = new System.Windows.Forms.Panel();
            this.dtpSupplyExpiry = new System.Windows.Forms.DateTimePicker();
            this.dtpSupplyManufacture = new System.Windows.Forms.DateTimePicker();
            this.lsvSupplyInventory = new System.Windows.Forms.ListView();
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader52 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader55 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSuppliesDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSuppliesSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtRemarks = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtStatus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSupplyBatch = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtSuppliesStocks = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel32 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel33 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel34 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel35 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel36 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtSuppliesName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel37 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel38 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.pnlleft = new System.Windows.Forms.Panel();
            this.tmreactive = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tmnotif = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.forposition = new System.Windows.Forms.Timer(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse7 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse8 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse9 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse10 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse11 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse12 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.repoPosition)).BeginInit();
            this.pnlheader.SuspendLayout();
            this.pnlschedleft.SuspendLayout();
            this.pnlbottom.SuspendLayout();
            this.pnlnotif.SuspendLayout();
            this.pnlschedbody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabbody)).BeginInit();
            this.tabbody.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clndrsched.CalendarTimeProperties)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridschedules)).BeginInit();
            this.forightmed.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlschedtop)).BeginInit();
            this.pnlschedtop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlview)).BeginInit();
            this.pnlview.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel12.SuspendLayout();
            this.pnlbodynurse.SuspendLayout();
            this.pnlbodynurse1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlpatient.SuspendLayout();
            this.pnlpatient1.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel13.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.xtraTabPage7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.panel9.SuspendLayout();
            this.xtraTabPage8.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.xtraTabPage9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // repoPosition
            // 
            this.repoPosition.AutoHeight = false;
            this.repoPosition.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoPosition.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("user_position", "user_position")});
            this.repoPosition.Name = "repoPosition";
            // 
            // pnlheader
            // 
            this.pnlheader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlheader.Controls.Add(this.label4);
            this.pnlheader.Controls.Add(this.btnminimize);
            this.pnlheader.Controls.Add(this.label5);
            this.pnlheader.Controls.Add(this.btnmaxmin);
            this.pnlheader.Controls.Add(this.btnclose);
            this.pnlheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlheader.Location = new System.Drawing.Point(0, 0);
            this.pnlheader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlheader.Name = "pnlheader";
            this.pnlheader.Size = new System.Drawing.Size(1000, 32);
            this.pnlheader.TabIndex = 17;
            this.pnlheader.DoubleClick += new System.EventHandler(this.pnlheader_DoubleClick);
            this.pnlheader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseDown);
            this.pnlheader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseMove);
            this.pnlheader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlheader_MouseUp);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 1061;
            this.label4.Text = "MANAGEMENT SCHEDULE";
            // 
            // btnminimize
            // 
            this.btnminimize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnminimize.BackColor = System.Drawing.Color.Transparent;
            this.btnminimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimize.BackgroundImage")));
            this.btnminimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminimize.FlatAppearance.BorderSize = 0;
            this.btnminimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnminimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnminimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnminimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnminimize.Location = new System.Drawing.Point(904, 0);
            this.btnminimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnminimize.Name = "btnminimize";
            this.btnminimize.Size = new System.Drawing.Size(32, 32);
            this.btnminimize.TabIndex = 14;
            this.btnminimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnminimize.UseVisualStyleBackColor = false;
            this.btnminimize.Click += new System.EventHandler(this.btnminimize_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(645, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 16);
            this.label5.TabIndex = 1062;
            this.label5.Text = "Copyright Nursing Scheduler 2017 - 2018";
            // 
            // btnmaxmin
            // 
            this.btnmaxmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmaxmin.BackColor = System.Drawing.Color.Transparent;
            this.btnmaxmin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmaxmin.BackgroundImage")));
            this.btnmaxmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnmaxmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmaxmin.FlatAppearance.BorderSize = 0;
            this.btnmaxmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnmaxmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnmaxmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmaxmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnmaxmin.Location = new System.Drawing.Point(936, 0);
            this.btnmaxmin.Margin = new System.Windows.Forms.Padding(0);
            this.btnmaxmin.Name = "btnmaxmin";
            this.btnmaxmin.Size = new System.Drawing.Size(32, 32);
            this.btnmaxmin.TabIndex = 13;
            this.btnmaxmin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmaxmin.UseVisualStyleBackColor = false;
            this.btnmaxmin.Click += new System.EventHandler(this.btnmaxmin_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnclose.Location = new System.Drawing.Point(968, 0);
            this.btnclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(32, 32);
            this.btnclose.TabIndex = 12;
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "power_white.PNG");
            this.imageList1.Images.SetKeyName(1, "settings.PNG");
            this.imageList1.Images.SetKeyName(2, "settings-6 (2).png");
            this.imageList1.Images.SetKeyName(3, "success.PNG");
            this.imageList1.Images.SetKeyName(4, "warning.png");
            // 
            // pnlschedleft
            // 
            this.pnlschedleft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlschedleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlschedleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlschedleft.Controls.Add(this.btninvetory);
            this.pnlschedleft.Controls.Add(this.btnroom);
            this.pnlschedleft.Controls.Add(this.btnpatient);
            this.pnlschedleft.Controls.Add(this.btnnurse);
            this.pnlschedleft.Controls.Add(this.btnschedule);
            this.pnlschedleft.Controls.Add(this.btnpnlschedleftclose);
            this.pnlschedleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlschedleft.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.pnlschedleft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.pnlschedleft.Location = new System.Drawing.Point(0, 0);
            this.pnlschedleft.Margin = new System.Windows.Forms.Padding(0);
            this.pnlschedleft.Name = "pnlschedleft";
            this.pnlschedleft.Size = new System.Drawing.Size(70, 509);
            this.pnlschedleft.TabIndex = 21;
            this.pnlschedleft.Resize += new System.EventHandler(this.Schedule_Form_Resize);
            // 
            // btninvetory
            // 
            this.btninvetory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btninvetory.BackColor = System.Drawing.Color.DarkMagenta;
            this.btninvetory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btninvetory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninvetory.FlatAppearance.BorderSize = 0;
            this.btninvetory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btninvetory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btninvetory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninvetory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninvetory.ForeColor = System.Drawing.Color.White;
            this.btninvetory.Image = ((System.Drawing.Image)(resources.GetObject("btninvetory.Image")));
            this.btninvetory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninvetory.Location = new System.Drawing.Point(0, 230);
            this.btninvetory.Margin = new System.Windows.Forms.Padding(0);
            this.btninvetory.Name = "btninvetory";
            this.btninvetory.Size = new System.Drawing.Size(70, 49);
            this.btninvetory.TabIndex = 19;
            this.btninvetory.Text = " ";
            this.btninvetory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninvetory.UseVisualStyleBackColor = false;
            this.btninvetory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnroom
            // 
            this.btnroom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnroom.BackColor = System.Drawing.Color.Crimson;
            this.btnroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnroom.FlatAppearance.BorderSize = 0;
            this.btnroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.ForeColor = System.Drawing.Color.White;
            this.btnroom.Image = ((System.Drawing.Image)(resources.GetObject("btnroom.Image")));
            this.btnroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.Location = new System.Drawing.Point(0, 183);
            this.btnroom.Margin = new System.Windows.Forms.Padding(0);
            this.btnroom.Name = "btnroom";
            this.btnroom.Size = new System.Drawing.Size(70, 49);
            this.btnroom.TabIndex = 17;
            this.btnroom.Text = " ";
            this.btnroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.UseVisualStyleBackColor = false;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // btnpatient
            // 
            this.btnpatient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnpatient.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnpatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpatient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpatient.FlatAppearance.BorderSize = 0;
            this.btnpatient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnpatient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnpatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpatient.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpatient.ForeColor = System.Drawing.Color.White;
            this.btnpatient.Image = ((System.Drawing.Image)(resources.GetObject("btnpatient.Image")));
            this.btnpatient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpatient.Location = new System.Drawing.Point(0, 134);
            this.btnpatient.Margin = new System.Windows.Forms.Padding(0);
            this.btnpatient.Name = "btnpatient";
            this.btnpatient.Size = new System.Drawing.Size(70, 49);
            this.btnpatient.TabIndex = 16;
            this.btnpatient.Text = " ";
            this.btnpatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpatient.UseVisualStyleBackColor = false;
            this.btnpatient.Click += new System.EventHandler(this.btnpatient_Click);
            // 
            // btnnurse
            // 
            this.btnnurse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnurse.BackColor = System.Drawing.Color.Ivory;
            this.btnnurse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnnurse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnurse.FlatAppearance.BorderSize = 0;
            this.btnnurse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnnurse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnnurse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnurse.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnurse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnnurse.Image = ((System.Drawing.Image)(resources.GetObject("btnnurse.Image")));
            this.btnnurse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnurse.Location = new System.Drawing.Point(0, 85);
            this.btnnurse.Margin = new System.Windows.Forms.Padding(0);
            this.btnnurse.Name = "btnnurse";
            this.btnnurse.Size = new System.Drawing.Size(70, 49);
            this.btnnurse.TabIndex = 15;
            this.btnnurse.Text = " ";
            this.btnnurse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnurse.UseVisualStyleBackColor = false;
            this.btnnurse.Click += new System.EventHandler(this.btnnurse_Click);
            // 
            // btnschedule
            // 
            this.btnschedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnschedule.BackColor = System.Drawing.Color.SeaGreen;
            this.btnschedule.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnschedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnschedule.FlatAppearance.BorderSize = 0;
            this.btnschedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnschedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnschedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnschedule.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnschedule.ForeColor = System.Drawing.Color.White;
            this.btnschedule.Image = ((System.Drawing.Image)(resources.GetObject("btnschedule.Image")));
            this.btnschedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.Location = new System.Drawing.Point(0, 36);
            this.btnschedule.Margin = new System.Windows.Forms.Padding(0);
            this.btnschedule.Name = "btnschedule";
            this.btnschedule.Size = new System.Drawing.Size(70, 49);
            this.btnschedule.TabIndex = 14;
            this.btnschedule.Text = " ";
            this.btnschedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnschedule.UseVisualStyleBackColor = false;
            this.btnschedule.Click += new System.EventHandler(this.btnschedule_Click);
            // 
            // btnpnlschedleftclose
            // 
            this.btnpnlschedleftclose.BackColor = System.Drawing.Color.Transparent;
            this.btnpnlschedleftclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnpnlschedleftclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpnlschedleftclose.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnpnlschedleftclose.FlatAppearance.BorderSize = 0;
            this.btnpnlschedleftclose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnpnlschedleftclose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnpnlschedleftclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpnlschedleftclose.Font = new System.Drawing.Font("Century Gothic", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpnlschedleftclose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.btnpnlschedleftclose.Image = ((System.Drawing.Image)(resources.GetObject("btnpnlschedleftclose.Image")));
            this.btnpnlschedleftclose.Location = new System.Drawing.Point(0, 0);
            this.btnpnlschedleftclose.Margin = new System.Windows.Forms.Padding(0);
            this.btnpnlschedleftclose.Name = "btnpnlschedleftclose";
            this.btnpnlschedleftclose.Size = new System.Drawing.Size(70, 36);
            this.btnpnlschedleftclose.TabIndex = 18;
            this.btnpnlschedleftclose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnpnlschedleftclose.UseVisualStyleBackColor = false;
            this.btnpnlschedleftclose.Click += new System.EventHandler(this.btnpnlschedleftclose_Click);
            // 
            // pnlright
            // 
            this.pnlright.BackColor = System.Drawing.SystemColors.Control;
            this.pnlright.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlright.Location = new System.Drawing.Point(1000, 32);
            this.pnlright.Name = "pnlright";
            this.pnlright.Size = new System.Drawing.Size(0, 509);
            this.pnlright.TabIndex = 21;
            // 
            // pnlbottom
            // 
            this.pnlbottom.Controls.Add(this.pnlnotif);
            this.pnlbottom.Controls.Add(this.btnaddsched);
            this.pnlbottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlbottom.Location = new System.Drawing.Point(0, 541);
            this.pnlbottom.Name = "pnlbottom";
            this.pnlbottom.Size = new System.Drawing.Size(1000, 59);
            this.pnlbottom.TabIndex = 22;
            // 
            // pnlnotif
            // 
            this.pnlnotif.BackColor = System.Drawing.Color.Transparent;
            this.pnlnotif.Controls.Add(this.lblnotif);
            this.pnlnotif.Controls.Add(this.shapeContainer1);
            this.pnlnotif.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlnotif.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlnotif.Location = new System.Drawing.Point(0, 0);
            this.pnlnotif.Name = "pnlnotif";
            this.pnlnotif.Size = new System.Drawing.Size(550, 59);
            this.pnlnotif.TabIndex = 1063;
            this.pnlnotif.Visible = false;
            // 
            // lblnotif
            // 
            this.lblnotif.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblnotif.AutoSize = true;
            this.lblnotif.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnotif.ForeColor = System.Drawing.Color.White;
            this.lblnotif.Location = new System.Drawing.Point(70, 21);
            this.lblnotif.Name = "lblnotif";
            this.lblnotif.Size = new System.Drawing.Size(0, 18);
            this.lblnotif.TabIndex = 10;
            this.lblnotif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rsicon});
            this.shapeContainer1.Size = new System.Drawing.Size(550, 59);
            this.shapeContainer1.TabIndex = 11;
            this.shapeContainer1.TabStop = false;
            // 
            // rsicon
            // 
            this.rsicon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rsicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rsicon.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rsicon.BorderColor = System.Drawing.Color.White;
            this.rsicon.BorderWidth = 3;
            this.rsicon.CornerRadius = 23;
            this.rsicon.Location = new System.Drawing.Point(7, 5);
            this.rsicon.Name = "rsicon";
            this.rsicon.SelectionColor = System.Drawing.Color.Transparent;
            this.rsicon.Size = new System.Drawing.Size(50, 46);
            // 
            // btnaddsched
            // 
            this.btnaddsched.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnaddsched.BackColor = System.Drawing.Color.SeaGreen;
            this.btnaddsched.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnaddsched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddsched.FlatAppearance.BorderSize = 0;
            this.btnaddsched.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnaddsched.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnaddsched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddsched.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddsched.ForeColor = System.Drawing.Color.White;
            this.btnaddsched.Image = ((System.Drawing.Image)(resources.GetObject("btnaddsched.Image")));
            this.btnaddsched.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddsched.Location = new System.Drawing.Point(805, 4);
            this.btnaddsched.Margin = new System.Windows.Forms.Padding(0);
            this.btnaddsched.Name = "btnaddsched";
            this.btnaddsched.Size = new System.Drawing.Size(176, 49);
            this.btnaddsched.TabIndex = 29;
            this.btnaddsched.Text = "              Add Schedule";
            this.btnaddsched.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnaddsched.UseVisualStyleBackColor = false;
            this.btnaddsched.Click += new System.EventHandler(this.btnaddsched_Click);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.StripAmpersands = true;
            this.toolTip1.ToolTipTitle = "hello";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // pnlschedbody
            // 
            this.pnlschedbody.Controls.Add(this.tabbody);
            this.pnlschedbody.Controls.Add(this.pnlschedleft);
            this.pnlschedbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlschedbody.Location = new System.Drawing.Point(0, 32);
            this.pnlschedbody.Name = "pnlschedbody";
            this.pnlschedbody.Size = new System.Drawing.Size(1000, 509);
            this.pnlschedbody.TabIndex = 23;
            // 
            // tabbody
            // 
            this.tabbody.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabbody.Appearance.Options.UseBackColor = true;
            this.tabbody.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tabbody.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tabbody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabbody.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.tabbody.Location = new System.Drawing.Point(70, 0);
            this.tabbody.Name = "tabbody";
            this.tabbody.PaintStyleName = "Flat";
            this.tabbody.SelectedTabPage = this.xtraTabPage1;
            this.tabbody.ShowHeaderFocus = DevExpress.Utils.DefaultBoolean.False;
            this.tabbody.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tabbody.ShowToolTips = DevExpress.Utils.DefaultBoolean.False;
            this.tabbody.Size = new System.Drawing.Size(930, 509);
            this.tabbody.TabIndex = 22;
            this.tabbody.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5});
            this.tabbody.Click += new System.EventHandler(this.tabbody_Click);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabPage1.Appearance.PageClient.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabPage1.Appearance.PageClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBorderColor = true;
            this.xtraTabPage1.Controls.Add(this.clndrsched);
            this.xtraTabPage1.Controls.Add(this.gridschedules);
            this.xtraTabPage1.Controls.Add(this.pnlschedtop);
            this.xtraTabPage1.FireScrollEventOnMouseWheel = true;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(930, 509);
            this.xtraTabPage1.Text = "tabschedule";
            // 
            // clndrsched
            // 
            this.clndrsched.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.clndrsched.Appearance.ForeColor = System.Drawing.Color.White;
            this.clndrsched.Appearance.Options.UseBackColor = true;
            this.clndrsched.Appearance.Options.UseForeColor = true;
            this.clndrsched.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clndrsched.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.clndrsched.CalendarAppearance.CalendarHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.CalendarHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.CalendarHeader.Options.UseBackColor = true;
            this.clndrsched.CalendarAppearance.CalendarHeader.Options.UseBorderColor = true;
            this.clndrsched.CalendarAppearance.DayCellHighlighted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellHighlighted.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellHighlighted.ForeColor = System.Drawing.Color.Honeydew;
            this.clndrsched.CalendarAppearance.DayCellHighlighted.Options.UseBackColor = true;
            this.clndrsched.CalendarAppearance.DayCellHighlighted.Options.UseForeColor = true;
            this.clndrsched.CalendarAppearance.DayCellToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellToday.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.CalendarAppearance.DayCellToday.ForeColor = System.Drawing.Color.Honeydew;
            this.clndrsched.CalendarAppearance.DayCellToday.Options.UseBackColor = true;
            this.clndrsched.CalendarAppearance.DayCellToday.Options.UseForeColor = true;
            this.clndrsched.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clndrsched.CalendarTimeProperties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Flat;
            this.clndrsched.CalendarTimeProperties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.clndrsched.CaseMonthNames = DevExpress.XtraEditors.Controls.TextCaseMode.UpperCase;
            this.clndrsched.CaseWeekDayAbbreviations = DevExpress.XtraEditors.Controls.TextCaseMode.UpperCase;
            this.clndrsched.CellPadding = new System.Windows.Forms.Padding(20, 10, 20, 27);
            this.clndrsched.ContextMenuStrip = this.contextMenuStrip2;
            this.clndrsched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clndrsched.DateTime = new System.DateTime(2017, 7, 22, 0, 0, 0, 0);
            this.clndrsched.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clndrsched.DrawCellLines = true;
            this.clndrsched.EditValue = new System.DateTime(2017, 7, 22, 0, 0, 0, 0);
            this.clndrsched.HighlightTodayCell = DevExpress.Utils.DefaultBoolean.True;
            this.clndrsched.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clndrsched.Location = new System.Drawing.Point(0, 58);
            this.clndrsched.MinValue = new System.DateTime(1988, 12, 25, 0, 0, 0, 0);
            this.clndrsched.Name = "clndrsched";
            this.clndrsched.SelectionBehavior = DevExpress.XtraEditors.Controls.CalendarSelectionBehavior.OutlookStyle;
            this.clndrsched.ShowClearButton = true;
            this.clndrsched.ShowFooter = false;
            this.clndrsched.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.clndrsched.ShowWeekNumbers = true;
            this.clndrsched.ShowYearNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.clndrsched.Size = new System.Drawing.Size(625, 451);
            this.clndrsched.TabIndex = 23;
            this.clndrsched.TodayDate = new System.DateTime(2017, 7, 21, 0, 0, 0, 0);
            this.clndrsched.TodayDayCellFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.clndrsched.UpdateSelectionWhenNavigating = true;
            this.clndrsched.VistaCalendarViewStyle = ((DevExpress.XtraEditors.VistaCalendarViewStyle)(((((DevExpress.XtraEditors.VistaCalendarViewStyle.MonthView | DevExpress.XtraEditors.VistaCalendarViewStyle.YearView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.QuarterView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView) 
            | DevExpress.XtraEditors.VistaCalendarViewStyle.CenturyView)));
            this.clndrsched.WeekDayAbbreviationLength = 3;
            this.clndrsched.DateTimeChanged += new System.EventHandler(this.clndrsched_DateTimeChanged);
            this.clndrsched.Click += new System.EventHandler(this.clndrsched_Click_1);
            this.clndrsched.DoubleClick += new System.EventHandler(this.clndrsched_DoubleClick);
            this.clndrsched.MouseMove += new System.Windows.Forms.MouseEventHandler(this.clndrsched_MouseMove);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.manageScheduleToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip2.Size = new System.Drawing.Size(202, 70);
            this.contextMenuStrip2.Text = "View All";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem3.Image")));
            this.toolStripMenuItem3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem3.Text = "Add Schedule";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem4.Text = "Delete  All Selected Date";
            // 
            // manageScheduleToolStripMenuItem
            // 
            this.manageScheduleToolStripMenuItem.Name = "manageScheduleToolStripMenuItem";
            this.manageScheduleToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.manageScheduleToolStripMenuItem.Text = "Manage Schedule";
            this.manageScheduleToolStripMenuItem.Click += new System.EventHandler(this.manageScheduleToolStripMenuItem_Click);
            // 
            // gridschedules
            // 
            this.gridschedules.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridschedules.ContextMenuStrip = this.forightmed;
            this.gridschedules.Dock = System.Windows.Forms.DockStyle.Right;
            this.gridschedules.Location = new System.Drawing.Point(625, 58);
            this.gridschedules.MainView = this.gridView2;
            this.gridschedules.Name = "gridschedules";
            this.gridschedules.Size = new System.Drawing.Size(305, 451);
            this.gridschedules.TabIndex = 30;
            this.gridschedules.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridschedules.Click += new System.EventHandler(this.gridschedules_Click);
            this.gridschedules.DoubleClick += new System.EventHandler(this.gridschedules_DoubleClick);
            this.gridschedules.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gridschedules_MouseUp);
            // 
            // forightmed
            // 
            this.forightmed.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.forightmed.Name = "contextMenuStrip1";
            this.forightmed.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.forightmed.Size = new System.Drawing.Size(202, 48);
            this.forightmed.Text = "View All";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem1.Text = "Add Schedule";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(201, 22);
            this.toolStripMenuItem2.Text = "Delete  All Selected Date";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // gridView2
            // 
            this.gridView2.Appearance.GroupPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.gridView2.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.DarkSlateGray;
            this.gridView2.Appearance.GroupPanel.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.gridView2.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gridView2.Appearance.GroupPanel.Options.UseBorderColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_schedule_date,
            this.col_schedule_nursefullname,
            this.col_schedule_title,
            this.col_schedule_id});
            this.gridView2.GridControl = this.gridschedules;
            this.gridView2.GroupCount = 2;
            this.gridView2.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView2.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_schedule_date, DevExpress.Data.ColumnSortOrder.Descending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_schedule_nursefullname, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gridView2.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // col_schedule_date
            // 
            this.col_schedule_date.Caption = "Scheduled Date ";
            this.col_schedule_date.FieldName = "schedule_date";
            this.col_schedule_date.Name = "col_schedule_date";
            this.col_schedule_date.Visible = true;
            this.col_schedule_date.VisibleIndex = 3;
            // 
            // col_schedule_nursefullname
            // 
            this.col_schedule_nursefullname.Caption = "Nurse Fullname ";
            this.col_schedule_nursefullname.FieldName = "nurse_fullname";
            this.col_schedule_nursefullname.Name = "col_schedule_nursefullname";
            this.col_schedule_nursefullname.Visible = true;
            this.col_schedule_nursefullname.VisibleIndex = 0;
            // 
            // col_schedule_title
            // 
            this.col_schedule_title.Caption = "Scheduled Title";
            this.col_schedule_title.FieldName = "schedule_title";
            this.col_schedule_title.Name = "col_schedule_title";
            this.col_schedule_title.Visible = true;
            this.col_schedule_title.VisibleIndex = 0;
            this.col_schedule_title.Width = 292;
            // 
            // col_schedule_id
            // 
            this.col_schedule_id.Caption = "nurse_id";
            this.col_schedule_id.FieldName = "nurse_id";
            this.col_schedule_id.MinWidth = 10;
            this.col_schedule_id.Name = "col_schedule_id";
            this.col_schedule_id.OptionsColumn.FixedWidth = true;
            this.col_schedule_id.Visible = true;
            this.col_schedule_id.VisibleIndex = 1;
            this.col_schedule_id.Width = 10;
            // 
            // pnlschedtop
            // 
            this.pnlschedtop.Appearance.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pnlschedtop.Appearance.Options.UseBackColor = true;
            this.pnlschedtop.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlschedtop.Controls.Add(this.label3);
            this.pnlschedtop.Controls.Add(this.lblallsched);
            this.pnlschedtop.Controls.Add(this.lblclear);
            this.pnlschedtop.Controls.Add(this.lblcurrenttime);
            this.pnlschedtop.Controls.Add(this.lblcurrentdate);
            this.pnlschedtop.Controls.Add(this.lbldateselected);
            this.pnlschedtop.Controls.Add(this.label7);
            this.pnlschedtop.Controls.Add(this.dtdate);
            this.pnlschedtop.Controls.Add(this.btnsearch);
            this.pnlschedtop.Controls.Add(this.txtsearch);
            this.pnlschedtop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlschedtop.Location = new System.Drawing.Point(0, 0);
            this.pnlschedtop.Name = "pnlschedtop";
            this.pnlschedtop.Size = new System.Drawing.Size(930, 58);
            this.pnlschedtop.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Honeydew;
            this.label3.Location = new System.Drawing.Point(402, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 14);
            this.label3.TabIndex = 1063;
            this.label3.Text = "QUICK SELECT DATE";
            // 
            // lblallsched
            // 
            this.lblallsched.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblallsched.AutoSize = true;
            this.lblallsched.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblallsched.Font = new System.Drawing.Font("Century Gothic", 7.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblallsched.ForeColor = System.Drawing.Color.White;
            this.lblallsched.Location = new System.Drawing.Point(632, 35);
            this.lblallsched.Name = "lblallsched";
            this.lblallsched.Size = new System.Drawing.Size(72, 14);
            this.lblallsched.TabIndex = 1062;
            this.lblallsched.Text = "ALL SCHEDULE";
            this.lblallsched.Click += new System.EventHandler(this.lblallsched_Click);
            // 
            // lblclear
            // 
            this.lblclear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblclear.AutoSize = true;
            this.lblclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblclear.Font = new System.Drawing.Font("Century Gothic", 7.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblclear.ForeColor = System.Drawing.Color.White;
            this.lblclear.Location = new System.Drawing.Point(819, 35);
            this.lblclear.Name = "lblclear";
            this.lblclear.Size = new System.Drawing.Size(78, 14);
            this.lblclear.TabIndex = 1061;
            this.lblclear.Text = "CLEAR SEARCH";
            this.lblclear.Click += new System.EventHandler(this.lblclear_Click);
            // 
            // lblcurrenttime
            // 
            this.lblcurrenttime.AutoSize = true;
            this.lblcurrenttime.BackColor = System.Drawing.Color.Transparent;
            this.lblcurrenttime.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcurrenttime.ForeColor = System.Drawing.Color.Honeydew;
            this.lblcurrenttime.Location = new System.Drawing.Point(6, 30);
            this.lblcurrenttime.Name = "lblcurrenttime";
            this.lblcurrenttime.Size = new System.Drawing.Size(94, 19);
            this.lblcurrenttime.TabIndex = 1058;
            this.lblcurrenttime.Text = "Current Time";
            // 
            // lblcurrentdate
            // 
            this.lblcurrentdate.AutoSize = true;
            this.lblcurrentdate.BackColor = System.Drawing.Color.Transparent;
            this.lblcurrentdate.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.lblcurrentdate.ForeColor = System.Drawing.Color.Honeydew;
            this.lblcurrentdate.Location = new System.Drawing.Point(6, 8);
            this.lblcurrentdate.Name = "lblcurrentdate";
            this.lblcurrentdate.Size = new System.Drawing.Size(128, 22);
            this.lblcurrentdate.TabIndex = 1057;
            this.lblcurrentdate.Text = "Current Date";
            // 
            // lbldateselected
            // 
            this.lbldateselected.AutoSize = true;
            this.lbldateselected.ForeColor = System.Drawing.Color.White;
            this.lbldateselected.Location = new System.Drawing.Point(387, 34);
            this.lbldateselected.Name = "lbldateselected";
            this.lbldateselected.Size = new System.Drawing.Size(13, 13);
            this.lbldateselected.TabIndex = 27;
            this.lbldateselected.Text = "_";
            this.lbldateselected.Visible = false;
            this.lbldateselected.TextChanged += new System.EventHandler(this.lbldateselected_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1435, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 16);
            this.label7.TabIndex = 1060;
            this.label7.Text = "Quick Selected Date :";
            // 
            // dtdate
            // 
            this.dtdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dtdate.Location = new System.Drawing.Point(405, 31);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(211, 21);
            this.dtdate.TabIndex = 1059;
            this.dtdate.ValueChanged += new System.EventHandler(this.dtdate_ValueChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(134)))), ((int)(((byte)(84)))));
            this.btnsearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageActive = null;
            this.btnsearch.Location = new System.Drawing.Point(897, 0);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(27, 27);
            this.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsearch.TabIndex = 1054;
            this.btnsearch.TabStop = false;
            this.btnsearch.Zoom = 10;
            this.btnsearch.Click += new System.EventHandler(this.txtsearch_OnValueChanged);
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic);
            this.txtsearch.ForeColor = System.Drawing.SystemColors.Control;
            this.txtsearch.HintForeColor = System.Drawing.Color.Silver;
            this.txtsearch.HintText = "date, fullname, title";
            this.txtsearch.isPassword = false;
            this.txtsearch.LineFocusedColor = System.Drawing.Color.SeaGreen;
            this.txtsearch.LineIdleColor = System.Drawing.Color.SeaGreen;
            this.txtsearch.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.txtsearch.LineThickness = 2;
            this.txtsearch.Location = new System.Drawing.Point(624, 7);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(40, 33, 40, 33);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(265, 23);
            this.txtsearch.TabIndex = 1015;
            this.txtsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtsearch.OnValueChanged += new System.EventHandler(this.txtsearch_OnValueChanged);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.panel3);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(930, 509);
            this.xtraTabPage2.Text = "tabnurse";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel3.Controls.Add(this.pnlview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 509);
            this.panel3.TabIndex = 4;
            // 
            // pnlview
            // 
            this.pnlview.Controls.Add(this.panel2);
            this.pnlview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlview.Location = new System.Drawing.Point(0, 0);
            this.pnlview.Name = "pnlview";
            this.pnlview.Size = new System.Drawing.Size(930, 509);
            this.pnlview.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.panel12);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 479);
            this.panel2.TabIndex = 5;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.pnlbodynurse);
            this.panel12.Controls.Add(this.lsvMedicine);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(920, 479);
            this.panel12.TabIndex = 1124;
            // 
            // pnlbodynurse
            // 
            this.pnlbodynurse.Controls.Add(this.pnlbodynurse1);
            this.pnlbodynurse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlbodynurse.Location = new System.Drawing.Point(0, 0);
            this.pnlbodynurse.Name = "pnlbodynurse";
            this.pnlbodynurse.Size = new System.Drawing.Size(374, 479);
            this.pnlbodynurse.TabIndex = 1124;
            // 
            // pnlbodynurse1
            // 
            this.pnlbodynurse1.Controls.Add(this.panel14);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel1);
            this.pnlbodynurse1.Controls.Add(this.txtRecovery);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel2);
            this.pnlbodynurse1.Controls.Add(this.txtConfirm);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel3);
            this.pnlbodynurse1.Controls.Add(this.txtPassword);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel4);
            this.pnlbodynurse1.Controls.Add(this.txtUsername);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel5);
            this.pnlbodynurse1.Controls.Add(this.txtAddress);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel6);
            this.pnlbodynurse1.Controls.Add(this.txtFullname);
            this.pnlbodynurse1.Controls.Add(this.bunifuCustomLabel7);
            this.pnlbodynurse1.Controls.Add(this.btnSave);
            this.pnlbodynurse1.Controls.Add(this.cmbPosition);
            this.pnlbodynurse1.Location = new System.Drawing.Point(9, 21);
            this.pnlbodynurse1.Name = "pnlbodynurse1";
            this.pnlbodynurse1.Size = new System.Drawing.Size(359, 455);
            this.pnlbodynurse1.TabIndex = 1139;
            // 
            // panel14
            // 
            this.panel14.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel14.BackgroundImage")));
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Location = new System.Drawing.Point(104, 3);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(140, 140);
            this.panel14.TabIndex = 1154;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(11, 155);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 15);
            this.bunifuCustomLabel1.TabIndex = 1139;
            this.bunifuCustomLabel1.Text = "Fullname:";
            // 
            // txtRecovery
            // 
            this.txtRecovery.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRecovery.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRecovery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecovery.Location = new System.Drawing.Point(135, 359);
            this.txtRecovery.Name = "txtRecovery";
            this.txtRecovery.Size = new System.Drawing.Size(204, 14);
            this.txtRecovery.TabIndex = 1148;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(11, 183);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(54, 15);
            this.bunifuCustomLabel2.TabIndex = 1140;
            this.bunifuCustomLabel2.Text = "Address:";
            // 
            // txtConfirm
            // 
            this.txtConfirm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtConfirm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Location = new System.Drawing.Point(135, 289);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(204, 14);
            this.txtConfirm.TabIndex = 1149;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(11, 218);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(68, 15);
            this.bunifuCustomLabel3.TabIndex = 1141;
            this.bunifuCustomLabel3.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(135, 254);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(204, 14);
            this.txtPassword.TabIndex = 1150;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(11, 252);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(64, 15);
            this.bunifuCustomLabel4.TabIndex = 1142;
            this.bunifuCustomLabel4.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(135, 220);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(204, 14);
            this.txtUsername.TabIndex = 1151;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(11, 287);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(110, 15);
            this.bunifuCustomLabel5.TabIndex = 1143;
            this.bunifuCustomLabel5.Text = "Confirm Password:";
            // 
            // txtAddress
            // 
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(135, 187);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(204, 14);
            this.txtAddress.TabIndex = 1152;
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(11, 357);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(95, 15);
            this.bunifuCustomLabel6.TabIndex = 1144;
            this.bunifuCustomLabel6.Text = "Recovery Email:";
            // 
            // txtFullname
            // 
            this.txtFullname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtFullname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtFullname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFullname.Location = new System.Drawing.Point(135, 157);
            this.txtFullname.Name = "txtFullname";
            this.txtFullname.Size = new System.Drawing.Size(204, 14);
            this.txtFullname.TabIndex = 1153;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(11, 327);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(54, 15);
            this.bunifuCustomLabel7.TabIndex = 1145;
            this.bunifuCustomLabel7.Text = "Position:";
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = null;
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = false;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = false;
            this.btnSave.IconZoom = 90D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(14, 396);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.Gray;
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(325, 40);
            this.btnSave.TabIndex = 1147;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbPosition
            // 
            this.cmbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPosition.BorderRadius = 3;
            this.cmbPosition.ForeColor = System.Drawing.Color.White;
            this.cmbPosition.Items = new string[] {
        "Head Nurse",
        "Nurse"};
            this.cmbPosition.Location = new System.Drawing.Point(135, 321);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbPosition.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbPosition.selectedIndex = -1;
            this.cmbPosition.Size = new System.Drawing.Size(204, 26);
            this.cmbPosition.TabIndex = 1146;
            // 
            // lsvMedicine
            // 
            this.lsvMedicine.BackColor = System.Drawing.Color.Ivory;
            this.lsvMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.lsvMedicine.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsvMedicine.FullRowSelect = true;
            this.lsvMedicine.GridLines = true;
            this.lsvMedicine.Location = new System.Drawing.Point(374, 0);
            this.lsvMedicine.Name = "lsvMedicine";
            this.lsvMedicine.Size = new System.Drawing.Size(546, 479);
            this.lsvMedicine.TabIndex = 9;
            this.lsvMedicine.UseCompatibleStateImageBehavior = false;
            this.lsvMedicine.View = System.Windows.Forms.View.Details;
            this.lsvMedicine.DoubleClick += new System.EventHandler(this.lsvMedicine_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 0;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Nurse Name";
            this.columnHeader9.Width = 133;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Address";
            this.columnHeader10.Width = 164;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Position";
            this.columnHeader11.Width = 113;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Username";
            this.columnHeader12.Width = 127;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "UserID";
            this.columnHeader13.Width = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.panel4);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(930, 509);
            this.xtraTabPage3.Text = "tabpatient";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 509);
            this.panel4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pnlpatient);
            this.panel1.Controls.Add(this.lsvPatient);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 479);
            this.panel1.TabIndex = 6;
            // 
            // pnlpatient
            // 
            this.pnlpatient.Controls.Add(this.pnlpatient1);
            this.pnlpatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlpatient.Location = new System.Drawing.Point(0, 0);
            this.pnlpatient.Name = "pnlpatient";
            this.pnlpatient.Size = new System.Drawing.Size(375, 479);
            this.pnlpatient.TabIndex = 1124;
            // 
            // pnlpatient1
            // 
            this.pnlpatient1.Controls.Add(this.panel17);
            this.pnlpatient1.Controls.Add(this.bunifuCustomLabel14);
            this.pnlpatient1.Controls.Add(this.btnPatientDelete);
            this.pnlpatient1.Controls.Add(this.btnPatientSave);
            this.pnlpatient1.Controls.Add(this.cmbRooms);
            this.pnlpatient1.Controls.Add(this.txtPatientAddress);
            this.pnlpatient1.Controls.Add(this.bunifuCustomLabel8);
            this.pnlpatient1.Controls.Add(this.txtPatientName);
            this.pnlpatient1.Controls.Add(this.bunifuCustomLabel13);
            this.pnlpatient1.Location = new System.Drawing.Point(12, 14);
            this.pnlpatient1.Name = "pnlpatient1";
            this.pnlpatient1.Size = new System.Drawing.Size(349, 451);
            this.pnlpatient1.TabIndex = 1124;
            // 
            // panel17
            // 
            this.panel17.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel17.BackgroundImage")));
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel17.Location = new System.Drawing.Point(106, 15);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(140, 140);
            this.panel17.TabIndex = 1155;
            // 
            // bunifuCustomLabel14
            // 
            this.bunifuCustomLabel14.AutoSize = true;
            this.bunifuCustomLabel14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel14.Location = new System.Drawing.Point(23, 222);
            this.bunifuCustomLabel14.Name = "bunifuCustomLabel14";
            this.bunifuCustomLabel14.Size = new System.Drawing.Size(85, 15);
            this.bunifuCustomLabel14.TabIndex = 6;
            this.bunifuCustomLabel14.Text = "Patient Name:";
            // 
            // btnPatientDelete
            // 
            this.btnPatientDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPatientDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPatientDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatientDelete.BorderRadius = 0;
            this.btnPatientDelete.ButtonText = "Delete";
            this.btnPatientDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnPatientDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPatientDelete.Iconimage = null;
            this.btnPatientDelete.Iconimage_right = null;
            this.btnPatientDelete.Iconimage_right_Selected = null;
            this.btnPatientDelete.Iconimage_Selected = null;
            this.btnPatientDelete.IconMarginLeft = 0;
            this.btnPatientDelete.IconMarginRight = 0;
            this.btnPatientDelete.IconRightVisible = false;
            this.btnPatientDelete.IconRightZoom = 0D;
            this.btnPatientDelete.IconVisible = false;
            this.btnPatientDelete.IconZoom = 90D;
            this.btnPatientDelete.IsTab = false;
            this.btnPatientDelete.Location = new System.Drawing.Point(179, 395);
            this.btnPatientDelete.Name = "btnPatientDelete";
            this.btnPatientDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPatientDelete.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPatientDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPatientDelete.selected = false;
            this.btnPatientDelete.Size = new System.Drawing.Size(167, 43);
            this.btnPatientDelete.TabIndex = 8;
            this.btnPatientDelete.Text = "Delete";
            this.btnPatientDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatientDelete.Textcolor = System.Drawing.Color.White;
            this.btnPatientDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientDelete.Click += new System.EventHandler(this.btnPatientDelete_Click);
            // 
            // btnPatientSave
            // 
            this.btnPatientSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPatientSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPatientSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPatientSave.BorderRadius = 0;
            this.btnPatientSave.ButtonText = "Save";
            this.btnPatientSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnPatientSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPatientSave.Iconimage = null;
            this.btnPatientSave.Iconimage_right = null;
            this.btnPatientSave.Iconimage_right_Selected = null;
            this.btnPatientSave.Iconimage_Selected = null;
            this.btnPatientSave.IconMarginLeft = 0;
            this.btnPatientSave.IconMarginRight = 0;
            this.btnPatientSave.IconRightVisible = false;
            this.btnPatientSave.IconRightZoom = 0D;
            this.btnPatientSave.IconVisible = false;
            this.btnPatientSave.IconZoom = 90D;
            this.btnPatientSave.IsTab = false;
            this.btnPatientSave.Location = new System.Drawing.Point(3, 395);
            this.btnPatientSave.Name = "btnPatientSave";
            this.btnPatientSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPatientSave.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPatientSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPatientSave.selected = false;
            this.btnPatientSave.Size = new System.Drawing.Size(167, 43);
            this.btnPatientSave.TabIndex = 8;
            this.btnPatientSave.Text = "Save";
            this.btnPatientSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPatientSave.Textcolor = System.Drawing.Color.White;
            this.btnPatientSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientSave.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // cmbRooms
            // 
            this.cmbRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRooms.BorderRadius = 3;
            this.cmbRooms.ForeColor = System.Drawing.Color.White;
            this.cmbRooms.Items = new string[] {
        "Head Nurse",
        "Nurse"};
            this.cmbRooms.Location = new System.Drawing.Point(118, 306);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbRooms.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.cmbRooms.selectedIndex = -1;
            this.cmbRooms.Size = new System.Drawing.Size(219, 26);
            this.cmbRooms.TabIndex = 6;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPatientAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPatientAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientAddress.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientAddress.Location = new System.Drawing.Point(118, 266);
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(219, 20);
            this.txtPatientAddress.TabIndex = 1123;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(11, 311);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(97, 15);
            this.bunifuCustomLabel8.TabIndex = 6;
            this.bunifuCustomLabel8.Text = "Assigned Room:";
            // 
            // txtPatientName
            // 
            this.txtPatientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPatientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPatientName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPatientName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatientName.Location = new System.Drawing.Point(118, 222);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(219, 20);
            this.txtPatientName.TabIndex = 1123;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(54, 266);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(54, 15);
            this.bunifuCustomLabel13.TabIndex = 6;
            this.bunifuCustomLabel13.Text = "Address:";
            this.bunifuCustomLabel13.Click += new System.EventHandler(this.bunifuCustomLabel13_Click);
            // 
            // lsvPatient
            // 
            this.lsvPatient.BackColor = System.Drawing.Color.Ivory;
            this.lsvPatient.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lsvPatient.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsvPatient.FullRowSelect = true;
            this.lsvPatient.GridLines = true;
            this.lsvPatient.Location = new System.Drawing.Point(375, 0);
            this.lsvPatient.Name = "lsvPatient";
            this.lsvPatient.Size = new System.Drawing.Size(545, 479);
            this.lsvPatient.TabIndex = 9;
            this.lsvPatient.UseCompatibleStateImageBehavior = false;
            this.lsvPatient.View = System.Windows.Forms.View.Details;
            this.lsvPatient.SelectedIndexChanged += new System.EventHandler(this.lsvPatient_SelectedIndexChanged);
            this.lsvPatient.DoubleClick += new System.EventHandler(this.lsvPatient_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ID";
            this.columnHeader7.Width = 0;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Patient Name";
            this.columnHeader14.Width = 150;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Address";
            this.columnHeader15.Width = 159;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Room Name";
            this.columnHeader16.Width = 125;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Room Code";
            this.columnHeader17.Width = 101;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.panel5);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(930, 509);
            this.xtraTabPage4.Text = "tabroom";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Controls.Add(this.panel13);
            this.panel5.Controls.Add(this.lsvRoom);
            this.panel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel5.Location = new System.Drawing.Point(5, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(920, 479);
            this.panel5.TabIndex = 7;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.txtRoomName);
            this.panel13.Controls.Add(this.txtDescription);
            this.panel13.Controls.Add(this.bunifuCustomLabel11);
            this.panel13.Controls.Add(this.txtRoomNumber);
            this.panel13.Controls.Add(this.bunifuCustomLabel10);
            this.panel13.Controls.Add(this.bunifuCustomLabel9);
            this.panel13.Controls.Add(this.btnRoomSave);
            this.panel13.Controls.Add(this.btnRoomDelete);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(0, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(442, 479);
            this.panel13.TabIndex = 1124;
            // 
            // panel15
            // 
            this.panel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel15.BackgroundImage")));
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel15.Location = new System.Drawing.Point(150, 27);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(140, 140);
            this.panel15.TabIndex = 1156;
            // 
            // txtRoomName
            // 
            this.txtRoomName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRoomName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRoomName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(150, 239);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(230, 14);
            this.txtRoomName.TabIndex = 1123;
            // 
            // txtDescription
            // 
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(150, 314);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(230, 14);
            this.txtDescription.TabIndex = 1123;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(52, 238);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(78, 16);
            this.bunifuCustomLabel11.TabIndex = 6;
            this.bunifuCustomLabel11.Text = "Room Name:";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtRoomNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtRoomNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoomNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNumber.Location = new System.Drawing.Point(150, 275);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(230, 14);
            this.txtRoomNumber.TabIndex = 1123;
            this.txtRoomNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(41, 274);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(88, 16);
            this.bunifuCustomLabel10.TabIndex = 6;
            this.bunifuCustomLabel10.Text = "Room Number:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(61, 313);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(70, 16);
            this.bunifuCustomLabel9.TabIndex = 6;
            this.bunifuCustomLabel9.Text = "Description:";
            // 
            // btnRoomSave
            // 
            this.btnRoomSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRoomSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoomSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoomSave.BorderRadius = 0;
            this.btnRoomSave.ButtonText = "Save";
            this.btnRoomSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoomSave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoomSave.Iconimage = null;
            this.btnRoomSave.Iconimage_right = null;
            this.btnRoomSave.Iconimage_right_Selected = null;
            this.btnRoomSave.Iconimage_Selected = null;
            this.btnRoomSave.IconMarginLeft = 0;
            this.btnRoomSave.IconMarginRight = 0;
            this.btnRoomSave.IconRightVisible = false;
            this.btnRoomSave.IconRightZoom = 0D;
            this.btnRoomSave.IconVisible = false;
            this.btnRoomSave.IconZoom = 90D;
            this.btnRoomSave.IsTab = false;
            this.btnRoomSave.Location = new System.Drawing.Point(64, 358);
            this.btnRoomSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoomSave.Name = "btnRoomSave";
            this.btnRoomSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoomSave.OnHovercolor = System.Drawing.Color.Gray;
            this.btnRoomSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRoomSave.selected = false;
            this.btnRoomSave.Size = new System.Drawing.Size(138, 43);
            this.btnRoomSave.TabIndex = 8;
            this.btnRoomSave.Text = "Save";
            this.btnRoomSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRoomSave.Textcolor = System.Drawing.Color.White;
            this.btnRoomSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomSave.Click += new System.EventHandler(this.btnRoomSave_Click);
            // 
            // btnRoomDelete
            // 
            this.btnRoomDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnRoomDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoomDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRoomDelete.BorderRadius = 0;
            this.btnRoomDelete.ButtonText = "Delete";
            this.btnRoomDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoomDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnRoomDelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRoomDelete.Iconimage = null;
            this.btnRoomDelete.Iconimage_right = null;
            this.btnRoomDelete.Iconimage_right_Selected = null;
            this.btnRoomDelete.Iconimage_Selected = null;
            this.btnRoomDelete.IconMarginLeft = 0;
            this.btnRoomDelete.IconMarginRight = 0;
            this.btnRoomDelete.IconRightVisible = false;
            this.btnRoomDelete.IconRightZoom = 0D;
            this.btnRoomDelete.IconVisible = false;
            this.btnRoomDelete.IconZoom = 90D;
            this.btnRoomDelete.IsTab = false;
            this.btnRoomDelete.Location = new System.Drawing.Point(231, 358);
            this.btnRoomDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRoomDelete.Name = "btnRoomDelete";
            this.btnRoomDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRoomDelete.OnHovercolor = System.Drawing.Color.Gray;
            this.btnRoomDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRoomDelete.selected = false;
            this.btnRoomDelete.Size = new System.Drawing.Size(145, 43);
            this.btnRoomDelete.TabIndex = 8;
            this.btnRoomDelete.Text = "Delete";
            this.btnRoomDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRoomDelete.Textcolor = System.Drawing.Color.White;
            this.btnRoomDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoomDelete.Click += new System.EventHandler(this.btnRoomDelete_Click);
            // 
            // lsvRoom
            // 
            this.lsvRoom.BackColor = System.Drawing.Color.Ivory;
            this.lsvRoom.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvRoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsvRoom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvRoom.FullRowSelect = true;
            this.lsvRoom.GridLines = true;
            this.lsvRoom.Location = new System.Drawing.Point(442, 0);
            this.lsvRoom.Name = "lsvRoom";
            this.lsvRoom.Size = new System.Drawing.Size(478, 479);
            this.lsvRoom.TabIndex = 9;
            this.lsvRoom.UseCompatibleStateImageBehavior = false;
            this.lsvRoom.View = System.Windows.Forms.View.Details;
            this.lsvRoom.SelectedIndexChanged += new System.EventHandler(this.lsvRoom_SelectedIndexChanged);
            this.lsvRoom.DoubleClick += new System.EventHandler(this.lsvRoom_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Room Name";
            this.columnHeader2.Width = 166;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Room Number";
            this.columnHeader3.Width = 153;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Description";
            this.columnHeader4.Width = 151;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.xtraTabControl1);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(930, 509);
            this.xtraTabPage5.Text = "xtraTabPage5";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabControl1.Appearance.Options.UseBackColor = true;
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PaintStyleName = "PropertyView";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage6;
            this.xtraTabControl1.Size = new System.Drawing.Size(930, 509);
            this.xtraTabControl1.TabIndex = 23;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage6,
            this.xtraTabPage7,
            this.xtraTabPage8,
            this.xtraTabPage9});
            this.xtraTabControl1.Click += new System.EventHandler(this.xtraTabControl1_Click);
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Appearance.PageClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabPage6.Appearance.PageClient.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabPage6.Appearance.PageClient.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.xtraTabPage6.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage6.Appearance.PageClient.Options.UseBorderColor = true;
            this.xtraTabPage6.Controls.Add(this.panel7);
            this.xtraTabPage6.FireScrollEventOnMouseWheel = true;
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.Size = new System.Drawing.Size(930, 489);
            this.xtraTabPage6.Text = "tabschedule";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Controls.Add(this.lsvSupplies);
            this.panel7.Controls.Add(this.dtpExpiry);
            this.panel7.Controls.Add(this.dtpManufactured);
            this.panel7.Controls.Add(this.bunifuCustomLabel12);
            this.panel7.Controls.Add(this.bunifuCustomLabel15);
            this.panel7.Controls.Add(this.btnCancel);
            this.panel7.Controls.Add(this.btnInventorySave);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Controls.Add(this.txtQuantity);
            this.panel7.Controls.Add(this.txtSupplyName);
            this.panel7.Controls.Add(this.bunifuCustomLabel16);
            this.panel7.Controls.Add(this.bunifuCustomLabel18);
            this.panel7.Controls.Add(this.lsvTransaction);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(930, 489);
            this.panel7.TabIndex = 3;
            // 
            // lsvSupplies
            // 
            this.lsvSupplies.BackColor = System.Drawing.Color.Ivory;
            this.lsvSupplies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21});
            this.lsvSupplies.FullRowSelect = true;
            this.lsvSupplies.GridLines = true;
            this.lsvSupplies.Location = new System.Drawing.Point(22, 43);
            this.lsvSupplies.Name = "lsvSupplies";
            this.lsvSupplies.Size = new System.Drawing.Size(402, 248);
            this.lsvSupplies.TabIndex = 10;
            this.lsvSupplies.UseCompatibleStateImageBehavior = false;
            this.lsvSupplies.View = System.Windows.Forms.View.Details;
            this.lsvSupplies.SelectedIndexChanged += new System.EventHandler(this.lsvSupplies_SelectedIndexChanged);
            this.lsvSupplies.DoubleClick += new System.EventHandler(this.lsvSupplies_DoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Supply";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Stocks";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Batch";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Manufactured Date";
            this.columnHeader20.Width = 110;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Expiry Date";
            this.columnHeader21.Width = 101;
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Location = new System.Drawing.Point(141, 391);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(284, 21);
            this.dtpExpiry.TabIndex = 9;
            // 
            // dtpManufactured
            // 
            this.dtpManufactured.Location = new System.Drawing.Point(140, 341);
            this.dtpManufactured.Name = "dtpManufactured";
            this.dtpManufactured.Size = new System.Drawing.Size(284, 21);
            this.dtpManufactured.TabIndex = 9;
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(62, 395);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(72, 15);
            this.bunifuCustomLabel12.TabIndex = 8;
            this.bunifuCustomLabel12.Text = "Expiry Date:";
            // 
            // bunifuCustomLabel15
            // 
            this.bunifuCustomLabel15.AutoSize = true;
            this.bunifuCustomLabel15.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel15.Location = new System.Drawing.Point(19, 349);
            this.bunifuCustomLabel15.Name = "bunifuCustomLabel15";
            this.bunifuCustomLabel15.Size = new System.Drawing.Size(115, 15);
            this.bunifuCustomLabel15.TabIndex = 8;
            this.bunifuCustomLabel15.Text = "Date Manufactured:";
            // 
            // btnCancel
            // 
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = null;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = false;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = false;
            this.btnCancel.IconZoom = 90D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Location = new System.Drawing.Point(772, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.Gray;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(124, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.White;
            this.btnCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInventorySave
            // 
            this.btnInventorySave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnInventorySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInventorySave.BorderRadius = 0;
            this.btnInventorySave.ButtonText = "Save";
            this.btnInventorySave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventorySave.DisabledColor = System.Drawing.Color.Gray;
            this.btnInventorySave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInventorySave.Iconimage = null;
            this.btnInventorySave.Iconimage_right = null;
            this.btnInventorySave.Iconimage_right_Selected = null;
            this.btnInventorySave.Iconimage_Selected = null;
            this.btnInventorySave.IconMarginLeft = 0;
            this.btnInventorySave.IconMarginRight = 0;
            this.btnInventorySave.IconRightVisible = false;
            this.btnInventorySave.IconRightZoom = 0D;
            this.btnInventorySave.IconVisible = false;
            this.btnInventorySave.IconZoom = 90D;
            this.btnInventorySave.IsTab = false;
            this.btnInventorySave.Location = new System.Drawing.Point(630, 393);
            this.btnInventorySave.Name = "btnInventorySave";
            this.btnInventorySave.Normalcolor = System.Drawing.Color.Empty;
            this.btnInventorySave.OnHovercolor = System.Drawing.Color.Gray;
            this.btnInventorySave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnInventorySave.selected = false;
            this.btnInventorySave.Size = new System.Drawing.Size(136, 43);
            this.btnInventorySave.TabIndex = 7;
            this.btnInventorySave.Text = "Save";
            this.btnInventorySave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInventorySave.Textcolor = System.Drawing.Color.White;
            this.btnInventorySave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventorySave.Click += new System.EventHandler(this.btnInventorySave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.BorderRadius = 0;
            this.btnAdd.ButtonText = "Add";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledColor = System.Drawing.Color.Gray;
            this.btnAdd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAdd.Iconimage = null;
            this.btnAdd.Iconimage_right = null;
            this.btnAdd.Iconimage_right_Selected = null;
            this.btnAdd.Iconimage_Selected = null;
            this.btnAdd.IconMarginLeft = 0;
            this.btnAdd.IconMarginRight = 0;
            this.btnAdd.IconRightVisible = false;
            this.btnAdd.IconRightZoom = 0D;
            this.btnAdd.IconVisible = false;
            this.btnAdd.IconZoom = 90D;
            this.btnAdd.IsTab = false;
            this.btnAdd.Location = new System.Drawing.Point(491, 393);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAdd.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAdd.selected = false;
            this.btnAdd.Size = new System.Drawing.Size(133, 43);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Textcolor = System.Drawing.Color.White;
            this.btnAdd.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtQuantity.ForeColor = System.Drawing.Color.White;
            this.txtQuantity.HintForeColor = System.Drawing.Color.White;
            this.txtQuantity.HintText = "";
            this.txtQuantity.isPassword = false;
            this.txtQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineIdleColor = System.Drawing.Color.White;
            this.txtQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantity.LineThickness = 3;
            this.txtQuantity.Location = new System.Drawing.Point(141, 423);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(284, 21);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSupplyName
            // 
            this.txtSupplyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupplyName.ForeColor = System.Drawing.Color.White;
            this.txtSupplyName.HintForeColor = System.Drawing.Color.White;
            this.txtSupplyName.HintText = "";
            this.txtSupplyName.isPassword = false;
            this.txtSupplyName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSupplyName.LineIdleColor = System.Drawing.Color.White;
            this.txtSupplyName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSupplyName.LineThickness = 3;
            this.txtSupplyName.Location = new System.Drawing.Point(140, 304);
            this.txtSupplyName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplyName.Name = "txtSupplyName";
            this.txtSupplyName.Size = new System.Drawing.Size(284, 21);
            this.txtSupplyName.TabIndex = 5;
            this.txtSupplyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel16
            // 
            this.bunifuCustomLabel16.AutoSize = true;
            this.bunifuCustomLabel16.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel16.Location = new System.Drawing.Point(83, 429);
            this.bunifuCustomLabel16.Name = "bunifuCustomLabel16";
            this.bunifuCustomLabel16.Size = new System.Drawing.Size(51, 15);
            this.bunifuCustomLabel16.TabIndex = 6;
            this.bunifuCustomLabel16.Text = "Quantity";
            // 
            // bunifuCustomLabel18
            // 
            this.bunifuCustomLabel18.AutoSize = true;
            this.bunifuCustomLabel18.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel18.Location = new System.Drawing.Point(49, 310);
            this.bunifuCustomLabel18.Name = "bunifuCustomLabel18";
            this.bunifuCustomLabel18.Size = new System.Drawing.Size(84, 15);
            this.bunifuCustomLabel18.TabIndex = 6;
            this.bunifuCustomLabel18.Text = "Supply Name:";
            // 
            // lsvTransaction
            // 
            this.lsvTransaction.BackColor = System.Drawing.Color.Ivory;
            this.lsvTransaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24,
            this.columnHeader25,
            this.columnHeader26,
            this.columnHeader56});
            this.lsvTransaction.FullRowSelect = true;
            this.lsvTransaction.GridLines = true;
            this.lsvTransaction.Location = new System.Drawing.Point(446, 29);
            this.lsvTransaction.Name = "lsvTransaction";
            this.lsvTransaction.Size = new System.Drawing.Size(465, 335);
            this.lsvTransaction.TabIndex = 0;
            this.lsvTransaction.UseCompatibleStateImageBehavior = false;
            this.lsvTransaction.View = System.Windows.Forms.View.Details;
            this.lsvTransaction.SelectedIndexChanged += new System.EventHandler(this.lsvTransaction_SelectedIndexChanged);
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "ID";
            this.columnHeader22.Width = 0;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Supply Name";
            this.columnHeader23.Width = 148;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "Quantity";
            this.columnHeader24.Width = 61;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "Date";
            this.columnHeader25.Width = 115;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "Stocks Left";
            this.columnHeader26.Width = 0;
            // 
            // columnHeader56
            // 
            this.columnHeader56.Text = "Expiry";
            this.columnHeader56.Width = 97;
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.panel6);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.Size = new System.Drawing.Size(930, 489);
            this.xtraTabPage7.Text = "tabnurse";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.panel6.Controls.Add(this.panelControl2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(930, 489);
            this.panel6.TabIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panel9);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(930, 489);
            this.panelControl2.TabIndex = 40;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel9.Controls.Add(this.dateTimePicker1);
            this.panel9.Controls.Add(this.dateTimePicker2);
            this.panel9.Controls.Add(this.bunifuCustomLabel19);
            this.panel9.Controls.Add(this.bunifuCustomLabel20);
            this.panel9.Controls.Add(this.btnMedicineCancel);
            this.panel9.Controls.Add(this.bunifuFlatButton2);
            this.panel9.Controls.Add(this.bunifuFlatButton3);
            this.panel9.Controls.Add(this.txtType);
            this.panel9.Controls.Add(this.txtMedicineQuantity);
            this.panel9.Controls.Add(this.bunifuMaterialTextbox3);
            this.panel9.Controls.Add(this.txtMedicineName);
            this.panel9.Controls.Add(this.bunifuCustomLabel21);
            this.panel9.Controls.Add(this.bunifuCustomLabel22);
            this.panel9.Controls.Add(this.bunifuCustomLabel23);
            this.panel9.Controls.Add(this.bunifuCustomLabel24);
            this.panel9.Controls.Add(this.bunifuCustomLabel25);
            this.panel9.Controls.Add(this.lsvMedicineTransaction);
            this.panel9.Controls.Add(this.lsvMedicineInventory);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(926, 485);
            this.panel9.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(163, 399);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 21);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(163, 365);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(247, 21);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // bunifuCustomLabel19
            // 
            this.bunifuCustomLabel19.AutoSize = true;
            this.bunifuCustomLabel19.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel19.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel19.Location = new System.Drawing.Point(41, 399);
            this.bunifuCustomLabel19.Name = "bunifuCustomLabel19";
            this.bunifuCustomLabel19.Size = new System.Drawing.Size(72, 15);
            this.bunifuCustomLabel19.TabIndex = 8;
            this.bunifuCustomLabel19.Text = "Expiry Date:";
            // 
            // bunifuCustomLabel20
            // 
            this.bunifuCustomLabel20.AutoSize = true;
            this.bunifuCustomLabel20.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel20.Location = new System.Drawing.Point(41, 365);
            this.bunifuCustomLabel20.Name = "bunifuCustomLabel20";
            this.bunifuCustomLabel20.Size = new System.Drawing.Size(115, 15);
            this.bunifuCustomLabel20.TabIndex = 8;
            this.bunifuCustomLabel20.Text = "Date Manufactured:";
            // 
            // btnMedicineCancel
            // 
            this.btnMedicineCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMedicineCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedicineCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedicineCancel.BorderRadius = 0;
            this.btnMedicineCancel.ButtonText = "Cancel";
            this.btnMedicineCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicineCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedicineCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedicineCancel.Iconimage = null;
            this.btnMedicineCancel.Iconimage_right = null;
            this.btnMedicineCancel.Iconimage_right_Selected = null;
            this.btnMedicineCancel.Iconimage_Selected = null;
            this.btnMedicineCancel.IconMarginLeft = 0;
            this.btnMedicineCancel.IconMarginRight = 0;
            this.btnMedicineCancel.IconRightVisible = false;
            this.btnMedicineCancel.IconRightZoom = 0D;
            this.btnMedicineCancel.IconVisible = false;
            this.btnMedicineCancel.IconZoom = 90D;
            this.btnMedicineCancel.IsTab = false;
            this.btnMedicineCancel.Location = new System.Drawing.Point(613, 408);
            this.btnMedicineCancel.Name = "btnMedicineCancel";
            this.btnMedicineCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedicineCancel.OnHovercolor = System.Drawing.Color.Gray;
            this.btnMedicineCancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedicineCancel.selected = false;
            this.btnMedicineCancel.Size = new System.Drawing.Size(127, 43);
            this.btnMedicineCancel.TabIndex = 7;
            this.btnMedicineCancel.Text = "Cancel";
            this.btnMedicineCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicineCancel.Textcolor = System.Drawing.Color.White;
            this.btnMedicineCancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineCancel.Click += new System.EventHandler(this.btnMedicineCancel_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Save";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = false;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(755, 408);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(127, 43);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "Save";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Add";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = false;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = false;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(473, 408);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(127, 43);
            this.bunifuFlatButton3.TabIndex = 7;
            this.bunifuFlatButton3.Text = "Add";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // txtType
            // 
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtType.ForeColor = System.Drawing.Color.White;
            this.txtType.HintForeColor = System.Drawing.Color.White;
            this.txtType.HintText = "";
            this.txtType.isPassword = false;
            this.txtType.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtType.LineIdleColor = System.Drawing.Color.White;
            this.txtType.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtType.LineThickness = 3;
            this.txtType.Location = new System.Drawing.Point(163, 312);
            this.txtType.Margin = new System.Windows.Forms.Padding(4);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(247, 33);
            this.txtType.TabIndex = 5;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicineQuantity
            // 
            this.txtMedicineQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineQuantity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMedicineQuantity.ForeColor = System.Drawing.Color.White;
            this.txtMedicineQuantity.HintForeColor = System.Drawing.Color.White;
            this.txtMedicineQuantity.HintText = "";
            this.txtMedicineQuantity.isPassword = false;
            this.txtMedicineQuantity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineQuantity.LineIdleColor = System.Drawing.Color.White;
            this.txtMedicineQuantity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineQuantity.LineThickness = 3;
            this.txtMedicineQuantity.Location = new System.Drawing.Point(163, 416);
            this.txtMedicineQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineQuantity.Name = "txtMedicineQuantity";
            this.txtMedicineQuantity.Size = new System.Drawing.Size(247, 33);
            this.txtMedicineQuantity.TabIndex = 5;
            this.txtMedicineQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox3.LineThickness = 3;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(144, 19);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(285, 33);
            this.bunifuMaterialTextbox3.TabIndex = 5;
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMedicineName
            // 
            this.txtMedicineName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMedicineName.ForeColor = System.Drawing.Color.White;
            this.txtMedicineName.HintForeColor = System.Drawing.Color.White;
            this.txtMedicineName.HintText = "";
            this.txtMedicineName.isPassword = false;
            this.txtMedicineName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineName.LineIdleColor = System.Drawing.Color.White;
            this.txtMedicineName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineName.LineThickness = 3;
            this.txtMedicineName.Location = new System.Drawing.Point(163, 278);
            this.txtMedicineName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineName.Name = "txtMedicineName";
            this.txtMedicineName.Size = new System.Drawing.Size(247, 33);
            this.txtMedicineName.TabIndex = 5;
            this.txtMedicineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel21
            // 
            this.bunifuCustomLabel21.AutoSize = true;
            this.bunifuCustomLabel21.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel21.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel21.Location = new System.Drawing.Point(41, 330);
            this.bunifuCustomLabel21.Name = "bunifuCustomLabel21";
            this.bunifuCustomLabel21.Size = new System.Drawing.Size(36, 15);
            this.bunifuCustomLabel21.TabIndex = 6;
            this.bunifuCustomLabel21.Text = "Type:";
            // 
            // bunifuCustomLabel22
            // 
            this.bunifuCustomLabel22.AutoSize = true;
            this.bunifuCustomLabel22.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel22.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel22.Location = new System.Drawing.Point(41, 434);
            this.bunifuCustomLabel22.Name = "bunifuCustomLabel22";
            this.bunifuCustomLabel22.Size = new System.Drawing.Size(51, 15);
            this.bunifuCustomLabel22.TabIndex = 6;
            this.bunifuCustomLabel22.Text = "Quantity";
            // 
            // bunifuCustomLabel23
            // 
            this.bunifuCustomLabel23.AutoSize = true;
            this.bunifuCustomLabel23.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel23.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel23.Location = new System.Drawing.Point(451, 41);
            this.bunifuCustomLabel23.Name = "bunifuCustomLabel23";
            this.bunifuCustomLabel23.Size = new System.Drawing.Size(36, 15);
            this.bunifuCustomLabel23.TabIndex = 6;
            this.bunifuCustomLabel23.Text = "Date:";
            // 
            // bunifuCustomLabel24
            // 
            this.bunifuCustomLabel24.AutoSize = true;
            this.bunifuCustomLabel24.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuCustomLabel24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel24.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel24.Location = new System.Drawing.Point(22, 37);
            this.bunifuCustomLabel24.Name = "bunifuCustomLabel24";
            this.bunifuCustomLabel24.Size = new System.Drawing.Size(49, 15);
            this.bunifuCustomLabel24.TabIndex = 6;
            this.bunifuCustomLabel24.Text = "Search:";
            // 
            // bunifuCustomLabel25
            // 
            this.bunifuCustomLabel25.AutoSize = true;
            this.bunifuCustomLabel25.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel25.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel25.Location = new System.Drawing.Point(41, 296);
            this.bunifuCustomLabel25.Name = "bunifuCustomLabel25";
            this.bunifuCustomLabel25.Size = new System.Drawing.Size(98, 15);
            this.bunifuCustomLabel25.TabIndex = 6;
            this.bunifuCustomLabel25.Text = "Medicine Name:";
            // 
            // lsvMedicineTransaction
            // 
            this.lsvMedicineTransaction.BackColor = System.Drawing.Color.Ivory;
            this.lsvMedicineTransaction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader27,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader33,
            this.columnHeader57});
            this.lsvMedicineTransaction.FullRowSelect = true;
            this.lsvMedicineTransaction.GridLines = true;
            this.lsvMedicineTransaction.Location = new System.Drawing.Point(454, 68);
            this.lsvMedicineTransaction.Name = "lsvMedicineTransaction";
            this.lsvMedicineTransaction.Size = new System.Drawing.Size(454, 321);
            this.lsvMedicineTransaction.TabIndex = 0;
            this.lsvMedicineTransaction.UseCompatibleStateImageBehavior = false;
            this.lsvMedicineTransaction.View = System.Windows.Forms.View.Details;
            this.lsvMedicineTransaction.SelectedIndexChanged += new System.EventHandler(this.lsvMedicineTransaction_SelectedIndexChanged);
            this.lsvMedicineTransaction.DoubleClick += new System.EventHandler(this.lsvMedicineTransaction_DoubleClick);
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "ID";
            this.columnHeader27.Width = 0;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "Medicine Name";
            this.columnHeader28.Width = 112;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "Type";
            this.columnHeader29.Width = 74;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "Unit";
            this.columnHeader30.Width = 56;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "Quantity";
            this.columnHeader31.Width = 61;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "Date";
            this.columnHeader32.Width = 98;
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "Stocks Left";
            this.columnHeader33.Width = 0;
            // 
            // columnHeader57
            // 
            this.columnHeader57.Text = "Expiry";
            // 
            // lsvMedicineInventory
            // 
            this.lsvMedicineInventory.BackColor = System.Drawing.Color.Ivory;
            this.lsvMedicineInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader34,
            this.columnHeader35,
            this.columnHeader36,
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40});
            this.lsvMedicineInventory.FullRowSelect = true;
            this.lsvMedicineInventory.GridLines = true;
            this.lsvMedicineInventory.Location = new System.Drawing.Point(25, 68);
            this.lsvMedicineInventory.Name = "lsvMedicineInventory";
            this.lsvMedicineInventory.Size = new System.Drawing.Size(404, 194);
            this.lsvMedicineInventory.TabIndex = 0;
            this.lsvMedicineInventory.UseCompatibleStateImageBehavior = false;
            this.lsvMedicineInventory.View = System.Windows.Forms.View.Details;
            this.lsvMedicineInventory.DoubleClick += new System.EventHandler(this.lsvMedicineInventory_DoubleClick);
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "ID";
            this.columnHeader34.Width = 0;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "Medicine Name";
            this.columnHeader35.Width = 126;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "Medicine Type";
            this.columnHeader36.Width = 102;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "Stocks";
            this.columnHeader37.Width = 56;
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "Batch Delivered";
            this.columnHeader38.Width = 120;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "Manufactured Date";
            this.columnHeader39.Width = 110;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "Expiry";
            this.columnHeader40.Width = 100;
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.panel8);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.Size = new System.Drawing.Size(930, 489);
            this.xtraTabPage8.Text = "tabpatient";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(930, 489);
            this.panel8.TabIndex = 23;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel10.Controls.Add(this.dtpMedicineExpiry);
            this.panel10.Controls.Add(this.dtpMedicineManufactured);
            this.panel10.Controls.Add(this.lsvMedInventory);
            this.panel10.Controls.Add(this.btnDelete);
            this.panel10.Controls.Add(this.btnMedicineInventorySave);
            this.panel10.Controls.Add(this.txtBatch);
            this.panel10.Controls.Add(this.txtStock);
            this.panel10.Controls.Add(this.bunifuCustomLabel26);
            this.panel10.Controls.Add(this.bunifuCustomLabel27);
            this.panel10.Controls.Add(this.txtMedicineType);
            this.panel10.Controls.Add(this.bunifuCustomLabel28);
            this.panel10.Controls.Add(this.txtMedicineInventoryName);
            this.panel10.Controls.Add(this.bunifuCustomLabel29);
            this.panel10.Controls.Add(this.bunifuCustomLabel30);
            this.panel10.Controls.Add(this.bunifuCustomLabel31);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(930, 489);
            this.panel10.TabIndex = 8;
            // 
            // dtpMedicineExpiry
            // 
            this.dtpMedicineExpiry.Location = new System.Drawing.Point(17, 348);
            this.dtpMedicineExpiry.Name = "dtpMedicineExpiry";
            this.dtpMedicineExpiry.Size = new System.Drawing.Size(267, 21);
            this.dtpMedicineExpiry.TabIndex = 6;
            // 
            // dtpMedicineManufactured
            // 
            this.dtpMedicineManufactured.Location = new System.Drawing.Point(17, 281);
            this.dtpMedicineManufactured.Name = "dtpMedicineManufactured";
            this.dtpMedicineManufactured.Size = new System.Drawing.Size(267, 21);
            this.dtpMedicineManufactured.TabIndex = 6;
            // 
            // lsvMedInventory
            // 
            this.lsvMedInventory.BackColor = System.Drawing.Color.Ivory;
            this.lsvMedInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader41,
            this.columnHeader42,
            this.columnHeader43,
            this.columnHeader44,
            this.columnHeader45,
            this.columnHeader46,
            this.columnHeader47});
            this.lsvMedInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsvMedInventory.FullRowSelect = true;
            this.lsvMedInventory.GridLines = true;
            this.lsvMedInventory.Location = new System.Drawing.Point(302, 0);
            this.lsvMedInventory.Name = "lsvMedInventory";
            this.lsvMedInventory.Size = new System.Drawing.Size(628, 489);
            this.lsvMedInventory.TabIndex = 5;
            this.lsvMedInventory.UseCompatibleStateImageBehavior = false;
            this.lsvMedInventory.View = System.Windows.Forms.View.Details;
            this.lsvMedInventory.SelectedIndexChanged += new System.EventHandler(this.lsvMedInventory_SelectedIndexChanged);
            this.lsvMedInventory.DoubleClick += new System.EventHandler(this.lsvMedInventory_DoubleClick);
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "ID";
            this.columnHeader41.Width = 0;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "Medicine Name";
            this.columnHeader42.Width = 136;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "Medicine Type";
            this.columnHeader43.Width = 113;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "Stocks";
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "Batch Delivered";
            this.columnHeader45.Width = 93;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "Manufactured Date";
            this.columnHeader46.Width = 114;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "Expiry Date";
            this.columnHeader47.Width = 74;
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = false;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = false;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(160, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.Gray;
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(127, 43);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMedicineInventorySave
            // 
            this.btnMedicineInventorySave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMedicineInventorySave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedicineInventorySave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMedicineInventorySave.BorderRadius = 0;
            this.btnMedicineInventorySave.ButtonText = "Save";
            this.btnMedicineInventorySave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicineInventorySave.DisabledColor = System.Drawing.Color.Gray;
            this.btnMedicineInventorySave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMedicineInventorySave.Iconimage = null;
            this.btnMedicineInventorySave.Iconimage_right = null;
            this.btnMedicineInventorySave.Iconimage_right_Selected = null;
            this.btnMedicineInventorySave.Iconimage_Selected = null;
            this.btnMedicineInventorySave.IconMarginLeft = 0;
            this.btnMedicineInventorySave.IconMarginRight = 0;
            this.btnMedicineInventorySave.IconRightVisible = false;
            this.btnMedicineInventorySave.IconRightZoom = 0D;
            this.btnMedicineInventorySave.IconVisible = false;
            this.btnMedicineInventorySave.IconZoom = 90D;
            this.btnMedicineInventorySave.IsTab = false;
            this.btnMedicineInventorySave.Location = new System.Drawing.Point(17, 405);
            this.btnMedicineInventorySave.Name = "btnMedicineInventorySave";
            this.btnMedicineInventorySave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMedicineInventorySave.OnHovercolor = System.Drawing.Color.Gray;
            this.btnMedicineInventorySave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMedicineInventorySave.selected = false;
            this.btnMedicineInventorySave.Size = new System.Drawing.Size(127, 43);
            this.btnMedicineInventorySave.TabIndex = 4;
            this.btnMedicineInventorySave.Text = "Save";
            this.btnMedicineInventorySave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMedicineInventorySave.Textcolor = System.Drawing.Color.White;
            this.btnMedicineInventorySave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineInventorySave.Click += new System.EventHandler(this.btnMedicineInventorySave_Click);
            // 
            // txtBatch
            // 
            this.txtBatch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBatch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtBatch.ForeColor = System.Drawing.Color.White;
            this.txtBatch.HintForeColor = System.Drawing.Color.White;
            this.txtBatch.HintText = "";
            this.txtBatch.isPassword = false;
            this.txtBatch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBatch.LineIdleColor = System.Drawing.Color.White;
            this.txtBatch.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtBatch.LineThickness = 3;
            this.txtBatch.Location = new System.Drawing.Point(123, 170);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(161, 37);
            this.txtBatch.TabIndex = 1;
            this.txtBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStock.ForeColor = System.Drawing.Color.White;
            this.txtStock.HintForeColor = System.Drawing.Color.White;
            this.txtStock.HintText = "";
            this.txtStock.isPassword = false;
            this.txtStock.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStock.LineIdleColor = System.Drawing.Color.White;
            this.txtStock.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtStock.LineThickness = 3;
            this.txtStock.Location = new System.Drawing.Point(123, 128);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(161, 34);
            this.txtStock.TabIndex = 1;
            this.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel26
            // 
            this.bunifuCustomLabel26.AutoSize = true;
            this.bunifuCustomLabel26.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel26.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel26.Location = new System.Drawing.Point(14, 320);
            this.bunifuCustomLabel26.Name = "bunifuCustomLabel26";
            this.bunifuCustomLabel26.Size = new System.Drawing.Size(72, 15);
            this.bunifuCustomLabel26.TabIndex = 2;
            this.bunifuCustomLabel26.Text = "Expiry Date:";
            // 
            // bunifuCustomLabel27
            // 
            this.bunifuCustomLabel27.AutoSize = true;
            this.bunifuCustomLabel27.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel27.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel27.Location = new System.Drawing.Point(53, 193);
            this.bunifuCustomLabel27.Name = "bunifuCustomLabel27";
            this.bunifuCustomLabel27.Size = new System.Drawing.Size(59, 15);
            this.bunifuCustomLabel27.TabIndex = 2;
            this.bunifuCustomLabel27.Text = "Batch ID: ";
            // 
            // txtMedicineType
            // 
            this.txtMedicineType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineType.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMedicineType.ForeColor = System.Drawing.Color.White;
            this.txtMedicineType.HintForeColor = System.Drawing.Color.White;
            this.txtMedicineType.HintText = "";
            this.txtMedicineType.isPassword = false;
            this.txtMedicineType.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineType.LineIdleColor = System.Drawing.Color.White;
            this.txtMedicineType.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtMedicineType.LineThickness = 3;
            this.txtMedicineType.Location = new System.Drawing.Point(123, 84);
            this.txtMedicineType.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineType.Name = "txtMedicineType";
            this.txtMedicineType.Size = new System.Drawing.Size(161, 36);
            this.txtMedicineType.TabIndex = 1;
            this.txtMedicineType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel28
            // 
            this.bunifuCustomLabel28.AutoSize = true;
            this.bunifuCustomLabel28.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel28.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel28.Location = new System.Drawing.Point(66, 148);
            this.bunifuCustomLabel28.Name = "bunifuCustomLabel28";
            this.bunifuCustomLabel28.Size = new System.Drawing.Size(46, 15);
            this.bunifuCustomLabel28.TabIndex = 2;
            this.bunifuCustomLabel28.Text = "Stocks:";
            // 
            // txtMedicineInventoryName
            // 
            this.txtMedicineInventoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMedicineInventoryName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMedicineInventoryName.ForeColor = System.Drawing.Color.White;
            this.txtMedicineInventoryName.HintForeColor = System.Drawing.Color.White;
            this.txtMedicineInventoryName.HintText = "";
            this.txtMedicineInventoryName.isPassword = false;
            this.txtMedicineInventoryName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMedicineInventoryName.LineIdleColor = System.Drawing.Color.White;
            this.txtMedicineInventoryName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMedicineInventoryName.LineThickness = 3;
            this.txtMedicineInventoryName.Location = new System.Drawing.Point(123, 43);
            this.txtMedicineInventoryName.Margin = new System.Windows.Forms.Padding(4);
            this.txtMedicineInventoryName.Name = "txtMedicineInventoryName";
            this.txtMedicineInventoryName.Size = new System.Drawing.Size(161, 33);
            this.txtMedicineInventoryName.TabIndex = 1;
            this.txtMedicineInventoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel29
            // 
            this.bunifuCustomLabel29.AutoSize = true;
            this.bunifuCustomLabel29.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel29.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel29.Location = new System.Drawing.Point(14, 253);
            this.bunifuCustomLabel29.Name = "bunifuCustomLabel29";
            this.bunifuCustomLabel29.Size = new System.Drawing.Size(115, 15);
            this.bunifuCustomLabel29.TabIndex = 2;
            this.bunifuCustomLabel29.Text = "Date Manufactured:";
            // 
            // bunifuCustomLabel30
            // 
            this.bunifuCustomLabel30.AutoSize = true;
            this.bunifuCustomLabel30.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel30.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel30.Location = new System.Drawing.Point(76, 97);
            this.bunifuCustomLabel30.Name = "bunifuCustomLabel30";
            this.bunifuCustomLabel30.Size = new System.Drawing.Size(36, 15);
            this.bunifuCustomLabel30.TabIndex = 2;
            this.bunifuCustomLabel30.Text = "Type:";
            // 
            // bunifuCustomLabel31
            // 
            this.bunifuCustomLabel31.AutoSize = true;
            this.bunifuCustomLabel31.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel31.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel31.Location = new System.Drawing.Point(14, 61);
            this.bunifuCustomLabel31.Name = "bunifuCustomLabel31";
            this.bunifuCustomLabel31.Size = new System.Drawing.Size(98, 15);
            this.bunifuCustomLabel31.TabIndex = 2;
            this.bunifuCustomLabel31.Text = "Medicine Name:";
            // 
            // xtraTabPage9
            // 
            this.xtraTabPage9.Controls.Add(this.panel11);
            this.xtraTabPage9.Name = "xtraTabPage9";
            this.xtraTabPage9.Size = new System.Drawing.Size(930, 489);
            this.xtraTabPage9.Text = "tabroom";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel11.Controls.Add(this.dtpSupplyExpiry);
            this.panel11.Controls.Add(this.dtpSupplyManufacture);
            this.panel11.Controls.Add(this.lsvSupplyInventory);
            this.panel11.Controls.Add(this.btnSuppliesDelete);
            this.panel11.Controls.Add(this.btnSuppliesSave);
            this.panel11.Controls.Add(this.txtRemarks);
            this.panel11.Controls.Add(this.txtStatus);
            this.panel11.Controls.Add(this.txtSupplyBatch);
            this.panel11.Controls.Add(this.txtSuppliesStocks);
            this.panel11.Controls.Add(this.bunifuCustomLabel32);
            this.panel11.Controls.Add(this.bunifuCustomLabel33);
            this.panel11.Controls.Add(this.bunifuCustomLabel34);
            this.panel11.Controls.Add(this.bunifuCustomLabel35);
            this.panel11.Controls.Add(this.bunifuCustomLabel36);
            this.panel11.Controls.Add(this.txtSuppliesName);
            this.panel11.Controls.Add(this.bunifuCustomLabel37);
            this.panel11.Controls.Add(this.bunifuCustomLabel38);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(930, 489);
            this.panel11.TabIndex = 9;
            this.panel11.Paint += new System.Windows.Forms.PaintEventHandler(this.panel11_Paint);
            // 
            // dtpSupplyExpiry
            // 
            this.dtpSupplyExpiry.Location = new System.Drawing.Point(30, 351);
            this.dtpSupplyExpiry.Name = "dtpSupplyExpiry";
            this.dtpSupplyExpiry.Size = new System.Drawing.Size(298, 21);
            this.dtpSupplyExpiry.TabIndex = 6;
            // 
            // dtpSupplyManufacture
            // 
            this.dtpSupplyManufacture.Location = new System.Drawing.Point(30, 279);
            this.dtpSupplyManufacture.Name = "dtpSupplyManufacture";
            this.dtpSupplyManufacture.Size = new System.Drawing.Size(298, 21);
            this.dtpSupplyManufacture.TabIndex = 6;
            // 
            // lsvSupplyInventory
            // 
            this.lsvSupplyInventory.BackColor = System.Drawing.Color.Ivory;
            this.lsvSupplyInventory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader52,
            this.columnHeader53,
            this.columnHeader54,
            this.columnHeader55});
            this.lsvSupplyInventory.Dock = System.Windows.Forms.DockStyle.Right;
            this.lsvSupplyInventory.FullRowSelect = true;
            this.lsvSupplyInventory.GridLines = true;
            this.lsvSupplyInventory.Location = new System.Drawing.Point(353, 0);
            this.lsvSupplyInventory.Name = "lsvSupplyInventory";
            this.lsvSupplyInventory.Size = new System.Drawing.Size(577, 489);
            this.lsvSupplyInventory.TabIndex = 5;
            this.lsvSupplyInventory.UseCompatibleStateImageBehavior = false;
            this.lsvSupplyInventory.View = System.Windows.Forms.View.Details;
            this.lsvSupplyInventory.SelectedIndexChanged += new System.EventHandler(this.lsvSupplyInventory_SelectedIndexChanged);
            this.lsvSupplyInventory.DoubleClick += new System.EventHandler(this.lsvSupplyInventory_DoubleClick);
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "ID";
            this.columnHeader48.Width = 0;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "Supply Name";
            this.columnHeader49.Width = 128;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "Stocks";
            this.columnHeader50.Width = 73;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "Status";
            this.columnHeader51.Width = 80;
            // 
            // columnHeader52
            // 
            this.columnHeader52.Text = "Batch Delivered";
            this.columnHeader52.Width = 95;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "Manufactured Date";
            this.columnHeader53.Width = 108;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "Expiry Date";
            this.columnHeader54.Width = 80;
            // 
            // columnHeader55
            // 
            this.columnHeader55.Text = "Remarks";
            // 
            // btnSuppliesDelete
            // 
            this.btnSuppliesDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppliesDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuppliesDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppliesDelete.BorderRadius = 0;
            this.btnSuppliesDelete.ButtonText = "Delete";
            this.btnSuppliesDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliesDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuppliesDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuppliesDelete.Iconimage = null;
            this.btnSuppliesDelete.Iconimage_right = null;
            this.btnSuppliesDelete.Iconimage_right_Selected = null;
            this.btnSuppliesDelete.Iconimage_Selected = null;
            this.btnSuppliesDelete.IconMarginLeft = 0;
            this.btnSuppliesDelete.IconMarginRight = 0;
            this.btnSuppliesDelete.IconRightVisible = false;
            this.btnSuppliesDelete.IconRightZoom = 0D;
            this.btnSuppliesDelete.IconVisible = false;
            this.btnSuppliesDelete.IconZoom = 90D;
            this.btnSuppliesDelete.IsTab = false;
            this.btnSuppliesDelete.Location = new System.Drawing.Point(189, 404);
            this.btnSuppliesDelete.Name = "btnSuppliesDelete";
            this.btnSuppliesDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuppliesDelete.OnHovercolor = System.Drawing.Color.Gray;
            this.btnSuppliesDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuppliesDelete.selected = false;
            this.btnSuppliesDelete.Size = new System.Drawing.Size(127, 43);
            this.btnSuppliesDelete.TabIndex = 4;
            this.btnSuppliesDelete.Text = "Delete";
            this.btnSuppliesDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppliesDelete.Textcolor = System.Drawing.Color.White;
            this.btnSuppliesDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliesDelete.Click += new System.EventHandler(this.btnSuppliesDelete_Click_1);
            // 
            // btnSuppliesSave
            // 
            this.btnSuppliesSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSuppliesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuppliesSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSuppliesSave.BorderRadius = 0;
            this.btnSuppliesSave.ButtonText = "Save";
            this.btnSuppliesSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliesSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSuppliesSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSuppliesSave.Iconimage = null;
            this.btnSuppliesSave.Iconimage_right = null;
            this.btnSuppliesSave.Iconimage_right_Selected = null;
            this.btnSuppliesSave.Iconimage_Selected = null;
            this.btnSuppliesSave.IconMarginLeft = 0;
            this.btnSuppliesSave.IconMarginRight = 0;
            this.btnSuppliesSave.IconRightVisible = false;
            this.btnSuppliesSave.IconRightZoom = 0D;
            this.btnSuppliesSave.IconVisible = false;
            this.btnSuppliesSave.IconZoom = 90D;
            this.btnSuppliesSave.IsTab = false;
            this.btnSuppliesSave.Location = new System.Drawing.Point(38, 404);
            this.btnSuppliesSave.Name = "btnSuppliesSave";
            this.btnSuppliesSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSuppliesSave.OnHovercolor = System.Drawing.Color.Gray;
            this.btnSuppliesSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSuppliesSave.selected = false;
            this.btnSuppliesSave.Size = new System.Drawing.Size(127, 43);
            this.btnSuppliesSave.TabIndex = 4;
            this.btnSuppliesSave.Text = "Save";
            this.btnSuppliesSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSuppliesSave.Textcolor = System.Drawing.Color.White;
            this.btnSuppliesSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliesSave.Click += new System.EventHandler(this.btnSuppliesSave_Click_1);
            // 
            // txtRemarks
            // 
            this.txtRemarks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRemarks.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRemarks.ForeColor = System.Drawing.Color.White;
            this.txtRemarks.HintForeColor = System.Drawing.Color.White;
            this.txtRemarks.HintText = "";
            this.txtRemarks.isPassword = false;
            this.txtRemarks.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRemarks.LineIdleColor = System.Drawing.Color.White;
            this.txtRemarks.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtRemarks.LineThickness = 3;
            this.txtRemarks.Location = new System.Drawing.Point(149, 186);
            this.txtRemarks.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.Size = new System.Drawing.Size(179, 37);
            this.txtRemarks.TabIndex = 1;
            this.txtRemarks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtStatus
            // 
            this.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStatus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtStatus.ForeColor = System.Drawing.Color.White;
            this.txtStatus.HintForeColor = System.Drawing.Color.White;
            this.txtStatus.HintText = "";
            this.txtStatus.isPassword = false;
            this.txtStatus.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtStatus.LineIdleColor = System.Drawing.Color.White;
            this.txtStatus.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtStatus.LineThickness = 3;
            this.txtStatus.Location = new System.Drawing.Point(149, 146);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(4);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(179, 37);
            this.txtStatus.TabIndex = 1;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtSupplyBatch
            // 
            this.txtSupplyBatch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupplyBatch.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSupplyBatch.ForeColor = System.Drawing.Color.White;
            this.txtSupplyBatch.HintForeColor = System.Drawing.Color.White;
            this.txtSupplyBatch.HintText = "";
            this.txtSupplyBatch.isPassword = false;
            this.txtSupplyBatch.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSupplyBatch.LineIdleColor = System.Drawing.Color.White;
            this.txtSupplyBatch.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSupplyBatch.LineThickness = 3;
            this.txtSupplyBatch.Location = new System.Drawing.Point(149, 106);
            this.txtSupplyBatch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSupplyBatch.Name = "txtSupplyBatch";
            this.txtSupplyBatch.Size = new System.Drawing.Size(179, 34);
            this.txtSupplyBatch.TabIndex = 1;
            this.txtSupplyBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSuppliesStocks
            // 
            this.txtSuppliesStocks.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuppliesStocks.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSuppliesStocks.ForeColor = System.Drawing.Color.White;
            this.txtSuppliesStocks.HintForeColor = System.Drawing.Color.White;
            this.txtSuppliesStocks.HintText = "";
            this.txtSuppliesStocks.isPassword = false;
            this.txtSuppliesStocks.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSuppliesStocks.LineIdleColor = System.Drawing.Color.White;
            this.txtSuppliesStocks.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.txtSuppliesStocks.LineThickness = 3;
            this.txtSuppliesStocks.Location = new System.Drawing.Point(149, 57);
            this.txtSuppliesStocks.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuppliesStocks.Name = "txtSuppliesStocks";
            this.txtSuppliesStocks.Size = new System.Drawing.Size(179, 34);
            this.txtSuppliesStocks.TabIndex = 1;
            this.txtSuppliesStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuCustomLabel32
            // 
            this.bunifuCustomLabel32.AutoSize = true;
            this.bunifuCustomLabel32.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuCustomLabel32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel32.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel32.Location = new System.Drawing.Point(27, 323);
            this.bunifuCustomLabel32.Name = "bunifuCustomLabel32";
            this.bunifuCustomLabel32.Size = new System.Drawing.Size(72, 15);
            this.bunifuCustomLabel32.TabIndex = 2;
            this.bunifuCustomLabel32.Text = "Expiry Date:";
            // 
            // bunifuCustomLabel33
            // 
            this.bunifuCustomLabel33.AutoSize = true;
            this.bunifuCustomLabel33.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel33.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel33.Location = new System.Drawing.Point(82, 208);
            this.bunifuCustomLabel33.Name = "bunifuCustomLabel33";
            this.bunifuCustomLabel33.Size = new System.Drawing.Size(60, 15);
            this.bunifuCustomLabel33.TabIndex = 2;
            this.bunifuCustomLabel33.Text = "Remarks:";
            // 
            // bunifuCustomLabel34
            // 
            this.bunifuCustomLabel34.AutoSize = true;
            this.bunifuCustomLabel34.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel34.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel34.Location = new System.Drawing.Point(98, 168);
            this.bunifuCustomLabel34.Name = "bunifuCustomLabel34";
            this.bunifuCustomLabel34.Size = new System.Drawing.Size(44, 15);
            this.bunifuCustomLabel34.TabIndex = 2;
            this.bunifuCustomLabel34.Text = "Status:";
            // 
            // bunifuCustomLabel35
            // 
            this.bunifuCustomLabel35.AutoSize = true;
            this.bunifuCustomLabel35.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel35.Location = new System.Drawing.Point(86, 125);
            this.bunifuCustomLabel35.Name = "bunifuCustomLabel35";
            this.bunifuCustomLabel35.Size = new System.Drawing.Size(56, 15);
            this.bunifuCustomLabel35.TabIndex = 2;
            this.bunifuCustomLabel35.Text = "Batch ID:";
            // 
            // bunifuCustomLabel36
            // 
            this.bunifuCustomLabel36.AutoSize = true;
            this.bunifuCustomLabel36.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel36.Location = new System.Drawing.Point(96, 77);
            this.bunifuCustomLabel36.Name = "bunifuCustomLabel36";
            this.bunifuCustomLabel36.Size = new System.Drawing.Size(46, 15);
            this.bunifuCustomLabel36.TabIndex = 2;
            this.bunifuCustomLabel36.Text = "Stocks:";
            // 
            // txtSuppliesName
            // 
            this.txtSuppliesName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuppliesName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtSuppliesName.ForeColor = System.Drawing.Color.White;
            this.txtSuppliesName.HintForeColor = System.Drawing.Color.White;
            this.txtSuppliesName.HintText = "";
            this.txtSuppliesName.isPassword = false;
            this.txtSuppliesName.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtSuppliesName.LineIdleColor = System.Drawing.Color.White;
            this.txtSuppliesName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtSuppliesName.LineThickness = 3;
            this.txtSuppliesName.Location = new System.Drawing.Point(149, 16);
            this.txtSuppliesName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSuppliesName.Name = "txtSuppliesName";
            this.txtSuppliesName.Size = new System.Drawing.Size(179, 33);
            this.txtSuppliesName.TabIndex = 1;
            this.txtSuppliesName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel37
            // 
            this.bunifuCustomLabel37.AutoSize = true;
            this.bunifuCustomLabel37.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel37.Location = new System.Drawing.Point(27, 246);
            this.bunifuCustomLabel37.Name = "bunifuCustomLabel37";
            this.bunifuCustomLabel37.Size = new System.Drawing.Size(115, 15);
            this.bunifuCustomLabel37.TabIndex = 2;
            this.bunifuCustomLabel37.Text = "Date Manufactured:";
            // 
            // bunifuCustomLabel38
            // 
            this.bunifuCustomLabel38.AutoSize = true;
            this.bunifuCustomLabel38.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel38.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuCustomLabel38.Location = new System.Drawing.Point(61, 34);
            this.bunifuCustomLabel38.Name = "bunifuCustomLabel38";
            this.bunifuCustomLabel38.Size = new System.Drawing.Size(81, 15);
            this.bunifuCustomLabel38.TabIndex = 2;
            this.bunifuCustomLabel38.Text = "Supply Name";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "navBarGroup1";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // pnlleft
            // 
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlleft.Location = new System.Drawing.Point(0, 32);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(0, 568);
            this.pnlleft.TabIndex = 25;
            // 
            // tmreactive
            // 
            this.tmreactive.Enabled = true;
            this.tmreactive.Interval = 1000;
            this.tmreactive.Tick += new System.EventHandler(this.tmreactive_Tick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.btnaddsched;
            // 
            // tmnotif
            // 
            this.tmnotif.Interval = 1000;
            this.tmnotif.Tick += new System.EventHandler(this.tmnotif_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this.btnSave;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 40;
            this.bunifuElipse3.TargetControl = this.btnPatientSave;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 40;
            this.bunifuElipse4.TargetControl = this.btnPatientDelete;
            // 
            // forposition
            // 
            this.forposition.Enabled = true;
            this.forposition.Tick += new System.EventHandler(this.forposition_Tick);
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 40;
            this.bunifuElipse5.TargetControl = this.btnRoomSave;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 40;
            this.bunifuElipse6.TargetControl = this.btnRoomDelete;
            // 
            // bunifuElipse7
            // 
            this.bunifuElipse7.ElipseRadius = 40;
            this.bunifuElipse7.TargetControl = this.btnAdd;
            // 
            // bunifuElipse8
            // 
            this.bunifuElipse8.ElipseRadius = 40;
            this.bunifuElipse8.TargetControl = this.btnInventorySave;
            // 
            // bunifuElipse9
            // 
            this.bunifuElipse9.ElipseRadius = 40;
            this.bunifuElipse9.TargetControl = this.btnCancel;
            // 
            // bunifuElipse10
            // 
            this.bunifuElipse10.ElipseRadius = 50;
            this.bunifuElipse10.TargetControl = this.bunifuCustomLabel13;
            // 
            // bunifuElipse11
            // 
            this.bunifuElipse11.ElipseRadius = 40;
            this.bunifuElipse11.TargetControl = this.btnCancel;
            // 
            // bunifuElipse12
            // 
            this.bunifuElipse12.ElipseRadius = 40;
            this.bunifuElipse12.TargetControl = this.btnCancel;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Schedule_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.pnlright);
            this.Controls.Add(this.pnlschedbody);
            this.Controls.Add(this.pnlbottom);
            this.Controls.Add(this.pnlleft);
            this.Controls.Add(this.pnlheader);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Schedule_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Schedule_Form";
            this.Load += new System.EventHandler(this.Schedule_Form_Load);
            this.Resize += new System.EventHandler(this.Schedule_Form_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.repoPosition)).EndInit();
            this.pnlheader.ResumeLayout(false);
            this.pnlheader.PerformLayout();
            this.pnlschedleft.ResumeLayout(false);
            this.pnlbottom.ResumeLayout(false);
            this.pnlnotif.ResumeLayout(false);
            this.pnlnotif.PerformLayout();
            this.pnlschedbody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabbody)).EndInit();
            this.tabbody.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clndrsched.CalendarTimeProperties)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridschedules)).EndInit();
            this.forightmed.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlschedtop)).EndInit();
            this.pnlschedtop.ResumeLayout(false);
            this.pnlschedtop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlview)).EndInit();
            this.pnlview.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.pnlbodynurse.ResumeLayout(false);
            this.pnlbodynurse1.ResumeLayout(false);
            this.pnlbodynurse1.PerformLayout();
            this.xtraTabPage3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlpatient.ResumeLayout(false);
            this.pnlpatient1.ResumeLayout(false);
            this.pnlpatient1.PerformLayout();
            this.xtraTabPage4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.xtraTabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.xtraTabPage7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.xtraTabPage8.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.xtraTabPage9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlheader;
        private System.Windows.Forms.Button btnminimize;
        private System.Windows.Forms.Button btnmaxmin;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Panel pnlright;
        private System.Windows.Forms.Panel pnlbottom;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.Panel pnlschedleft;
        public System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlschedbody;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        public DevExpress.XtraEditors.Controls.CalendarControl clndrsched;
        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Button btnschedule;
        private System.Windows.Forms.Button btnnurse;
        private System.Windows.Forms.Button btnpatient;
        private System.Windows.Forms.Button btnroom;
        private System.Windows.Forms.Button btnpnlschedleftclose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.PanelControl pnlschedtop;
        private System.Windows.Forms.Button btnaddsched;
        private DevExpress.XtraEditors.PanelControl pnlview;
        private DevExpress.XtraGrid.GridControl gridschedules;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        public System.Windows.Forms.Label lblcurrenttime;
        public System.Windows.Forms.Label lblcurrentdate;
        private System.Windows.Forms.Timer tmreactive;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_schedule_nursefullname;
        private DevExpress.XtraGrid.Columns.GridColumn col_schedule_title;
        private DevExpress.XtraGrid.Columns.GridColumn col_schedule_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_schedule_date;
        private System.Windows.Forms.DateTimePicker dtdate;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtsearch;
        private Bunifu.Framework.UI.BunifuImageButton btnsearch;
        private System.Windows.Forms.Label lbldateselected;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripMenuItem manageScheduleToolStripMenuItem;
        private System.Windows.Forms.Panel pnlnotif;
        private System.Windows.Forms.Label lblnotif;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rsicon;
        private System.Windows.Forms.Timer tmnotif;
        private System.Windows.Forms.Label lblclear;
        private System.Windows.Forms.Label lblallsched;
        private DevExpress.XtraTab.XtraTabControl tabbody;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btninvetory;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvMedicine;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.ListView lsvPatient;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private Bunifu.Framework.UI.BunifuDropdown cmbRooms;
        private Bunifu.Framework.UI.BunifuFlatButton btnPatientDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnPatientSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel13;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.ListView lsvRoom;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Bunifu.Framework.UI.BunifuFlatButton btnRoomDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnRoomSave;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel10;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView lsvSupplies;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.DateTimePicker dtpManufactured;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel12;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel15;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private Bunifu.Framework.UI.BunifuFlatButton btnInventorySave;
        private Bunifu.Framework.UI.BunifuFlatButton btnAdd;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSupplyName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel16;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel18;
        private System.Windows.Forms.ListView lsvTransaction;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private System.Windows.Forms.Panel panel8;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage9;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel19;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel20;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedicineCancel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtType;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineQuantity;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel21;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel22;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel23;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel24;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel25;
        private System.Windows.Forms.ListView lsvMedicineTransaction;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ListView lsvMedicineInventory;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DateTimePicker dtpMedicineExpiry;
        private System.Windows.Forms.DateTimePicker dtpMedicineManufactured;
        private System.Windows.Forms.ListView lsvMedInventory;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnMedicineInventorySave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBatch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStock;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel26;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel27;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineType;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel28;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel29;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel30;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel31;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.DateTimePicker dtpSupplyExpiry;
        private System.Windows.Forms.DateTimePicker dtpSupplyManufacture;
        private System.Windows.Forms.ListView lsvSupplyInventory;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader52;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.ColumnHeader columnHeader55;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuppliesDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnSuppliesSave;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRemarks;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtStatus;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSupplyBatch;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSuppliesStocks;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel32;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel33;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel34;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel35;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel36;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSuppliesName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel37;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel38;
        private System.Windows.Forms.ColumnHeader columnHeader56;
        private System.Windows.Forms.ColumnHeader columnHeader57;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel panel12;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMedicineInventoryName;
        private System.Windows.Forms.ContextMenuStrip forightmed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel pnlbodynurse;
        private System.Windows.Forms.Panel pnlbodynurse1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.TextBox txtRecovery;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.TextBox txtConfirm;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox txtPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.TextBox txtUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.TextBox txtAddress;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private System.Windows.Forms.TextBox txtFullname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuDropdown cmbPosition;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel pnlpatient;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Panel pnlpatient1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Timer forposition;
        private System.Windows.Forms.Panel panel15;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse7;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse8;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse9;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse10;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse11;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse12;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}