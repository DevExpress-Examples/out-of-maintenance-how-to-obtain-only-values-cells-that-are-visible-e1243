// Developer Express Code Central Example:
// How to obtain only values cells that are visible
// 
// This task can be accomplished by using the GridViewInfo class. This class
// provides collections of the visible rows (the GridRowInfoCollection) and visible
// columns (the GridColumnsInfo).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1243

namespace WindowsApplication1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet11 = new WindowsApplication1.DataSet1();
			this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colStringProperty1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCurrentDate1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIntProperty = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemSpinEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
			this.repositoryItemHyperLinkEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
			this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
			this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colBoolProperty1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colStringProperty1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewColumn7 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colCurrentDate1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewColumn8 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
			this.layoutViewField_colDoubleProperty1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
			this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
			this.cardView1 = new DevExpress.XtraGrid.Views.Card.CardView();
			this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
			this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
			this.colBoolProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colStringProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colCurrentDate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.colDoubleProperty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBoolProperty1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colStringProperty1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCurrentDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDoubleProperty1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataTable1BindingSource
			// 
			this.dataTable1BindingSource.DataMember = "DataTable1";
			this.dataTable1BindingSource.DataSource = this.dataSet11;
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// defaultLookAndFeel1
			// 
			this.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.dataTable1BindingSource;
			this.gridControl1.Location = new System.Drawing.Point(0, 1);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHyperLinkEdit1,
            this.repositoryItemButtonEdit1,
            this.repositoryItemMemoEdit1,
            this.repositoryItemSpinEdit1});
			this.gridControl1.Size = new System.Drawing.Size(483, 357);
			this.gridControl1.TabIndex = 0;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.layoutView1,
            this.cardView1,
            this.advBandedGridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colStringProperty1,
            this.colCurrentDate1,
            this.colIntProperty});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsSelection.MultiSelect = true;
			this.gridView1.OptionsView.ColumnAutoWidth = false;
			// 
			// colStringProperty1
			// 
			this.colStringProperty1.Caption = "StringProperty";
			this.colStringProperty1.FieldName = "StringProperty";
			this.colStringProperty1.Name = "colStringProperty1";
			this.colStringProperty1.Visible = true;
			this.colStringProperty1.VisibleIndex = 0;
			this.colStringProperty1.Width = 500;
			// 
			// colCurrentDate1
			// 
			this.colCurrentDate1.Caption = "CurrentDate";
			this.colCurrentDate1.FieldName = "CurrentDate";
			this.colCurrentDate1.Name = "colCurrentDate1";
			this.colCurrentDate1.Visible = true;
			this.colCurrentDate1.VisibleIndex = 1;
			this.colCurrentDate1.Width = 200;
			// 
			// colIntProperty
			// 
			this.colIntProperty.Caption = "IntProperty";
			this.colIntProperty.ColumnEdit = this.repositoryItemSpinEdit1;
			this.colIntProperty.FieldName = "IntProperty";
			this.colIntProperty.Name = "colIntProperty";
			this.colIntProperty.Visible = true;
			this.colIntProperty.VisibleIndex = 2;
			this.colIntProperty.Width = 439;
			// 
			// repositoryItemSpinEdit1
			// 
			this.repositoryItemSpinEdit1.AutoHeight = false;
			this.repositoryItemSpinEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.repositoryItemSpinEdit1.MaxValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1";
			// 
			// repositoryItemHyperLinkEdit1
			// 
			this.repositoryItemHyperLinkEdit1.AutoHeight = false;
			this.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1";
			// 
			// repositoryItemButtonEdit1
			// 
			this.repositoryItemButtonEdit1.AutoHeight = false;
			this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
			this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			// 
			// layoutView1
			// 
			this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn5,
            this.layoutViewColumn6,
            this.layoutViewColumn7,
            this.layoutViewColumn8});
			this.layoutView1.GridControl = this.gridControl1;
			this.layoutView1.Name = "layoutView1";
			this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;
			this.layoutView1.TemplateCard = this.layoutViewCard1;
			// 
			// layoutViewColumn5
			// 
			this.layoutViewColumn5.Caption = "BoolProperty";
			this.layoutViewColumn5.FieldName = "BoolProperty";
			this.layoutViewColumn5.LayoutViewField = this.layoutViewField_colBoolProperty1;
			this.layoutViewColumn5.Name = "layoutViewColumn5";
			// 
			// layoutViewField_colBoolProperty1
			// 
			this.layoutViewField_colBoolProperty1.EditorPreferredWidth = 112;
			this.layoutViewField_colBoolProperty1.Location = new System.Drawing.Point(0, 0);
			this.layoutViewField_colBoolProperty1.Name = "layoutViewField_colBoolProperty1";
			this.layoutViewField_colBoolProperty1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colBoolProperty1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colBoolProperty1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewColumn6
			// 
			this.layoutViewColumn6.Caption = "StringProperty";
			this.layoutViewColumn6.FieldName = "StringProperty";
			this.layoutViewColumn6.LayoutViewField = this.layoutViewField_colStringProperty1;
			this.layoutViewColumn6.Name = "layoutViewColumn6";
			// 
			// layoutViewField_colStringProperty1
			// 
			this.layoutViewField_colStringProperty1.EditorPreferredWidth = 112;
			this.layoutViewField_colStringProperty1.Location = new System.Drawing.Point(0, 27);
			this.layoutViewField_colStringProperty1.Name = "layoutViewField_colStringProperty1";
			this.layoutViewField_colStringProperty1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colStringProperty1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colStringProperty1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewColumn7
			// 
			this.layoutViewColumn7.Caption = "CurrentDate";
			this.layoutViewColumn7.FieldName = "CurrentDate";
			this.layoutViewColumn7.LayoutViewField = this.layoutViewField_colCurrentDate1;
			this.layoutViewColumn7.Name = "layoutViewColumn7";
			// 
			// layoutViewField_colCurrentDate1
			// 
			this.layoutViewField_colCurrentDate1.EditorPreferredWidth = 112;
			this.layoutViewField_colCurrentDate1.Location = new System.Drawing.Point(0, 54);
			this.layoutViewField_colCurrentDate1.Name = "layoutViewField_colCurrentDate1";
			this.layoutViewField_colCurrentDate1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colCurrentDate1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colCurrentDate1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewColumn8
			// 
			this.layoutViewColumn8.Caption = "DoubleProperty";
			this.layoutViewColumn8.DisplayFormat.FormatString = "{0:n3} €";
			this.layoutViewColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.layoutViewColumn8.FieldName = "DoubleProperty";
			this.layoutViewColumn8.LayoutViewField = this.layoutViewField_colDoubleProperty1;
			this.layoutViewColumn8.Name = "layoutViewColumn8";
			// 
			// layoutViewField_colDoubleProperty1
			// 
			this.layoutViewField_colDoubleProperty1.EditorPreferredWidth = 112;
			this.layoutViewField_colDoubleProperty1.Location = new System.Drawing.Point(0, 81);
			this.layoutViewField_colDoubleProperty1.Name = "layoutViewField_colDoubleProperty1";
			this.layoutViewField_colDoubleProperty1.Size = new System.Drawing.Size(207, 27);
			this.layoutViewField_colDoubleProperty1.TextLocation = DevExpress.Utils.Locations.Left;
			this.layoutViewField_colDoubleProperty1.TextSize = new System.Drawing.Size(79, 20);
			// 
			// layoutViewCard1
			// 
			this.layoutViewCard1.CustomizationFormText = "layoutViewCard1";
			this.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText;
			this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_colBoolProperty1,
            this.layoutViewField_colStringProperty1,
            this.layoutViewField_colCurrentDate1,
            this.layoutViewField_colDoubleProperty1});
			this.layoutViewCard1.Name = "layoutViewCard1";
			this.layoutViewCard1.Text = "layoutViewCard1";
			// 
			// cardView1
			// 
			this.cardView1.CardCaptionFormat = "Record [{0} of {1}]";
			this.cardView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4});
			this.cardView1.FocusedCardTopFieldIndex = 0;
			this.cardView1.GridControl = this.gridControl1;
			this.cardView1.Name = "cardView1";
			// 
			// layoutViewColumn1
			// 
			this.layoutViewColumn1.Caption = "BoolProperty";
			this.layoutViewColumn1.FieldName = "BoolProperty";
			this.layoutViewColumn1.Name = "layoutViewColumn1";
			this.layoutViewColumn1.Visible = true;
			this.layoutViewColumn1.VisibleIndex = 0;
			// 
			// layoutViewColumn2
			// 
			this.layoutViewColumn2.Caption = "StringProperty";
			this.layoutViewColumn2.ColumnEdit = this.repositoryItemMemoEdit1;
			this.layoutViewColumn2.FieldName = "StringProperty";
			this.layoutViewColumn2.Name = "layoutViewColumn2";
			this.layoutViewColumn2.Visible = true;
			this.layoutViewColumn2.VisibleIndex = 1;
			// 
			// layoutViewColumn3
			// 
			this.layoutViewColumn3.Caption = "CurrentDate";
			this.layoutViewColumn3.FieldName = "CurrentDate";
			this.layoutViewColumn3.Name = "layoutViewColumn3";
			this.layoutViewColumn3.Visible = true;
			this.layoutViewColumn3.VisibleIndex = 2;
			// 
			// layoutViewColumn4
			// 
			this.layoutViewColumn4.Caption = "DoubleProperty";
			this.layoutViewColumn4.FieldName = "DoubleProperty";
			this.layoutViewColumn4.Name = "layoutViewColumn4";
			this.layoutViewColumn4.Visible = true;
			this.layoutViewColumn4.VisibleIndex = 3;
			// 
			// advBandedGridView1
			// 
			this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
			this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colBoolProperty,
            this.colStringProperty,
            this.colCurrentDate,
            this.colDoubleProperty});
			this.advBandedGridView1.GridControl = this.gridControl1;
			this.advBandedGridView1.Name = "advBandedGridView1";
			this.advBandedGridView1.OptionsSelection.MultiSelect = true;
			// 
			// gridBand1
			// 
			this.gridBand1.Caption = "gridBand1";
			this.gridBand1.Columns.Add(this.colBoolProperty);
			this.gridBand1.Columns.Add(this.colStringProperty);
			this.gridBand1.Columns.Add(this.colCurrentDate);
			this.gridBand1.Columns.Add(this.colDoubleProperty);
			this.gridBand1.Name = "gridBand1";
			this.gridBand1.Width = 464;
			// 
			// colBoolProperty
			// 
			this.colBoolProperty.Caption = "BoolProperty";
			this.colBoolProperty.FieldName = "BoolProperty";
			this.colBoolProperty.Name = "colBoolProperty";
			this.colBoolProperty.Visible = true;
			this.colBoolProperty.Width = 116;
			// 
			// colStringProperty
			// 
			this.colStringProperty.Caption = "StringProperty";
			this.colStringProperty.FieldName = "StringProperty";
			this.colStringProperty.Name = "colStringProperty";
			this.colStringProperty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
			this.colStringProperty.Visible = true;
			this.colStringProperty.Width = 116;
			// 
			// colCurrentDate
			// 
			this.colCurrentDate.Caption = "CurrentDate";
			this.colCurrentDate.FieldName = "CurrentDate";
			this.colCurrentDate.Name = "colCurrentDate";
			this.colCurrentDate.Visible = true;
			this.colCurrentDate.Width = 116;
			// 
			// colDoubleProperty
			// 
			this.colDoubleProperty.Caption = "DoubleProperty";
			this.colDoubleProperty.FieldName = "DoubleProperty";
			this.colDoubleProperty.Name = "colDoubleProperty";
			this.colDoubleProperty.Visible = true;
			this.colDoubleProperty.Width = 116;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(526, 40);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(123, 23);
			this.simpleButton1.TabIndex = 1;
			this.simpleButton1.Text = "simpleButton1";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// listBoxControl1
			// 
			this.listBoxControl1.Location = new System.Drawing.Point(489, 97);
			this.listBoxControl1.Name = "listBoxControl1";
			this.listBoxControl1.Size = new System.Drawing.Size(228, 249);
			this.listBoxControl1.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(740, 358);
			this.Controls.Add(this.listBoxControl1);
			this.Controls.Add(this.simpleButton1);
			this.Controls.Add(this.gridControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemHyperLinkEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colBoolProperty1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colStringProperty1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colCurrentDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewField_colDoubleProperty1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cardView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
		private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colBoolProperty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colStringProperty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colCurrentDate;
		private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colDoubleProperty;
		private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repositoryItemHyperLinkEdit1;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
		private DevExpress.XtraGrid.Views.Card.CardView cardView1;
		private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn1;
		private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn2;
		private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn3;
		private DevExpress.XtraGrid.Columns.GridColumn layoutViewColumn4;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colBoolProperty1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colStringProperty1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn7;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colCurrentDate1;
		private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn8;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_colDoubleProperty1;
		private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
		private DevExpress.XtraGrid.Columns.GridColumn colStringProperty1;
		private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate1;
		private DevExpress.XtraGrid.Columns.GridColumn colIntProperty;
		private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEdit1;
		private DevExpress.XtraEditors.SimpleButton simpleButton1;
		private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    }
}

