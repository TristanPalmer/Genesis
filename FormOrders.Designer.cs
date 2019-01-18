namespace Genesis
{
    partial class FormOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrders));
            this.gridOrders = new DevExpress.XtraGrid.GridControl();
            this.xpViewOrders = new DevExpress.Xpo.XPView(this.components);
            this.unitOfWorkOrders = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReferenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::Genesis.WaitForm1), true, true);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpViewOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOrders
            // 
            this.gridOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOrders.DataSource = this.xpViewOrders;
            this.gridOrders.Location = new System.Drawing.Point(12, 12);
            this.gridOrders.MainView = this.gridView1;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridOrders.Size = new System.Drawing.Size(777, 479);
            this.gridOrders.TabIndex = 0;
            this.gridOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpViewOrders
            // 
            this.xpViewOrders.ObjectType = typeof(Genesis.Orders.Order);
            this.xpViewOrders.Properties.AddRange(new DevExpress.Xpo.ViewProperty[] {
            new DevExpress.Xpo.ViewProperty("Id", DevExpress.Xpo.SortDirection.None, "[Id]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerId", DevExpress.Xpo.SortDirection.None, "[CustomerId]", false, true),
            new DevExpress.Xpo.ViewProperty("ReferenceNumber", DevExpress.Xpo.SortDirection.None, "[ReferenceNumber]", false, true),
            new DevExpress.Xpo.ViewProperty("OrderValue", DevExpress.Xpo.SortDirection.None, "[OrderValue]", false, true),
            new DevExpress.Xpo.ViewProperty("OrderDate", DevExpress.Xpo.SortDirection.None, "[OrderDate]", false, true),
            new DevExpress.Xpo.ViewProperty("CustomerName", DevExpress.Xpo.SortDirection.None, "Concat([CustomerId.LastName], \', \', [CustomerId.FirstName])", false, true)});
            this.xpViewOrders.Session = this.unitOfWorkOrders;
            this.xpViewOrders.Sorting.AddRange(new DevExpress.Xpo.SortProperty[] {
            new DevExpress.Xpo.SortProperty("[OrderDate]", DevExpress.Xpo.DB.SortingDirection.Ascending)});
            // 
            // unitOfWorkOrders
            // 
            this.unitOfWorkOrders.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.unitOfWorkOrders.TrackPropertiesModifications = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReferenceNumber,
            this.colOrderValue,
            this.colOrderDate,
            this.colCustomerName,
            this.colViewCustomer});
            this.gridView1.GridControl = this.gridOrders;
            this.gridView1.Name = "gridView1";
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.FieldName = "ReferenceNumber";
            this.colReferenceNumber.Name = "colReferenceNumber";
            this.colReferenceNumber.Visible = true;
            this.colReferenceNumber.VisibleIndex = 0;
            // 
            // colOrderValue
            // 
            this.colOrderValue.DisplayFormat.FormatString = "c2";
            this.colOrderValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOrderValue.FieldName = "OrderValue";
            this.colOrderValue.Name = "colOrderValue";
            this.colOrderValue.Visible = true;
            this.colOrderValue.VisibleIndex = 1;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DisplayFormat.FormatString = "dd-MMM-yyyy ";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            // 
            // colCustomerName
            // 
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 3;
            // 
            // colViewCustomer
            // 
            this.colViewCustomer.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colViewCustomer.FieldName = "ViewCustomer";
            this.colViewCustomer.Name = "colViewCustomer";
            this.colViewCustomer.Visible = true;
            this.colViewCustomer.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick_1);
            // 
            // splashScreenManager1
            // 
            this.splashScreenManager1.ClosingDelay = 500;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 503);
            this.Controls.Add(this.gridOrders);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpViewOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitOfWorkOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridOrders;
        private DevExpress.Xpo.XPView xpViewOrders;
        private DevExpress.Xpo.UnitOfWork unitOfWorkOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderValue;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colViewCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1;
    }
}

