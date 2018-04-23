' Developer Express Code Central Example:
' How to obtain only values cells that are visible
' 
' This task can be accomplished by using the GridViewInfo class. This class
' provides collections of the visible rows (the GridRowInfoCollection) and visible
' columns (the GridColumnsInfo).
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E1243

Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dataSet11 = New DataSet1()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colStringProperty1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCurrentDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colIntProperty = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
			Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
			Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.layoutViewColumn5 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colBoolProperty1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn6 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colStringProperty1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn7 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colCurrentDate1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewColumn8 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_colDoubleProperty1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
			Me.layoutViewColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutViewColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutViewColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.layoutViewColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.advBandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.colBoolProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colStringProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colCurrentDate = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.colDoubleProperty = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colBoolProperty1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colStringProperty1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colCurrentDate1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_colDoubleProperty1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dataTable1BindingSource
			' 
			Me.dataTable1BindingSource.DataMember = "DataTable1"
			Me.dataTable1BindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Lilian"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1BindingSource
			Me.gridControl1.Location = New System.Drawing.Point(0, 1)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemHyperLinkEdit1, Me.repositoryItemButtonEdit1, Me.repositoryItemMemoEdit1, Me.repositoryItemSpinEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(483, 357)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.layoutView1, Me.cardView1, Me.advBandedGridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colStringProperty1, Me.colCurrentDate1, Me.colIntProperty})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.Hidden
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsSelection.MultiSelect = True
			Me.gridView1.OptionsView.ColumnAutoWidth = False
			' 
			' colStringProperty1
			' 
			Me.colStringProperty1.Caption = "StringProperty"
			Me.colStringProperty1.FieldName = "StringProperty"
			Me.colStringProperty1.Name = "colStringProperty1"
			Me.colStringProperty1.Visible = True
			Me.colStringProperty1.VisibleIndex = 0
			Me.colStringProperty1.Width = 500
			' 
			' colCurrentDate1
			' 
			Me.colCurrentDate1.Caption = "CurrentDate"
			Me.colCurrentDate1.FieldName = "CurrentDate"
			Me.colCurrentDate1.Name = "colCurrentDate1"
			Me.colCurrentDate1.Visible = True
			Me.colCurrentDate1.VisibleIndex = 1
			Me.colCurrentDate1.Width = 200
			' 
			' colIntProperty
			' 
			Me.colIntProperty.Caption = "IntProperty"
			Me.colIntProperty.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.colIntProperty.FieldName = "IntProperty"
			Me.colIntProperty.Name = "colIntProperty"
			Me.colIntProperty.Visible = True
			Me.colIntProperty.VisibleIndex = 2
			Me.colIntProperty.Width = 439
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 5, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' repositoryItemHyperLinkEdit1
			' 
			Me.repositoryItemHyperLinkEdit1.AutoHeight = False
			Me.repositoryItemHyperLinkEdit1.Name = "repositoryItemHyperLinkEdit1"
			' 
			' repositoryItemButtonEdit1
			' 
			Me.repositoryItemButtonEdit1.AutoHeight = False
			Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
			' 
			' repositoryItemMemoEdit1
			' 
			Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
			' 
			' layoutView1
			' 
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.layoutViewColumn5, Me.layoutViewColumn6, Me.layoutViewColumn7, Me.layoutViewColumn8})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
			' 
			' layoutViewColumn5
			' 
			Me.layoutViewColumn5.Caption = "BoolProperty"
			Me.layoutViewColumn5.FieldName = "BoolProperty"
			Me.layoutViewColumn5.LayoutViewField = Me.layoutViewField_colBoolProperty1
			Me.layoutViewColumn5.Name = "layoutViewColumn5"
			' 
			' layoutViewField_colBoolProperty1
			' 
			Me.layoutViewField_colBoolProperty1.EditorPreferredWidth = 112
			Me.layoutViewField_colBoolProperty1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_colBoolProperty1.Name = "layoutViewField_colBoolProperty1"
			Me.layoutViewField_colBoolProperty1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colBoolProperty1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colBoolProperty1.TextSize = New System.Drawing.Size(79, 20)
			' 
			' layoutViewColumn6
			' 
			Me.layoutViewColumn6.Caption = "StringProperty"
			Me.layoutViewColumn6.FieldName = "StringProperty"
			Me.layoutViewColumn6.LayoutViewField = Me.layoutViewField_colStringProperty1
			Me.layoutViewColumn6.Name = "layoutViewColumn6"
			' 
			' layoutViewField_colStringProperty1
			' 
			Me.layoutViewField_colStringProperty1.EditorPreferredWidth = 112
			Me.layoutViewField_colStringProperty1.Location = New System.Drawing.Point(0, 27)
			Me.layoutViewField_colStringProperty1.Name = "layoutViewField_colStringProperty1"
			Me.layoutViewField_colStringProperty1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colStringProperty1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colStringProperty1.TextSize = New System.Drawing.Size(79, 20)
			' 
			' layoutViewColumn7
			' 
			Me.layoutViewColumn7.Caption = "CurrentDate"
			Me.layoutViewColumn7.FieldName = "CurrentDate"
			Me.layoutViewColumn7.LayoutViewField = Me.layoutViewField_colCurrentDate1
			Me.layoutViewColumn7.Name = "layoutViewColumn7"
			' 
			' layoutViewField_colCurrentDate1
			' 
			Me.layoutViewField_colCurrentDate1.EditorPreferredWidth = 112
			Me.layoutViewField_colCurrentDate1.Location = New System.Drawing.Point(0, 54)
			Me.layoutViewField_colCurrentDate1.Name = "layoutViewField_colCurrentDate1"
			Me.layoutViewField_colCurrentDate1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colCurrentDate1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colCurrentDate1.TextSize = New System.Drawing.Size(79, 20)
			' 
			' layoutViewColumn8
			' 
			Me.layoutViewColumn8.Caption = "DoubleProperty"
			Me.layoutViewColumn8.DisplayFormat.FormatString = "{0:n3} €"
			Me.layoutViewColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.layoutViewColumn8.FieldName = "DoubleProperty"
			Me.layoutViewColumn8.LayoutViewField = Me.layoutViewField_colDoubleProperty1
			Me.layoutViewColumn8.Name = "layoutViewColumn8"
			' 
			' layoutViewField_colDoubleProperty1
			' 
			Me.layoutViewField_colDoubleProperty1.EditorPreferredWidth = 112
			Me.layoutViewField_colDoubleProperty1.Location = New System.Drawing.Point(0, 81)
			Me.layoutViewField_colDoubleProperty1.Name = "layoutViewField_colDoubleProperty1"
			Me.layoutViewField_colDoubleProperty1.Size = New System.Drawing.Size(207, 27)
			Me.layoutViewField_colDoubleProperty1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_colDoubleProperty1.TextSize = New System.Drawing.Size(79, 20)
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "layoutViewCard1"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_colBoolProperty1, Me.layoutViewField_colStringProperty1, Me.layoutViewField_colCurrentDate1, Me.layoutViewField_colDoubleProperty1})
			Me.layoutViewCard1.Name = "layoutViewCard1"
			Me.layoutViewCard1.Text = "layoutViewCard1"
			' 
			' cardView1
			' 
			Me.cardView1.CardCaptionFormat = "Record [{0} of {1}]"
			Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.layoutViewColumn1, Me.layoutViewColumn2, Me.layoutViewColumn3, Me.layoutViewColumn4})
			Me.cardView1.FocusedCardTopFieldIndex = 0
			Me.cardView1.GridControl = Me.gridControl1
			Me.cardView1.Name = "cardView1"
			' 
			' layoutViewColumn1
			' 
			Me.layoutViewColumn1.Caption = "BoolProperty"
			Me.layoutViewColumn1.FieldName = "BoolProperty"
			Me.layoutViewColumn1.Name = "layoutViewColumn1"
			Me.layoutViewColumn1.Visible = True
			Me.layoutViewColumn1.VisibleIndex = 0
			' 
			' layoutViewColumn2
			' 
			Me.layoutViewColumn2.Caption = "StringProperty"
			Me.layoutViewColumn2.ColumnEdit = Me.repositoryItemMemoEdit1
			Me.layoutViewColumn2.FieldName = "StringProperty"
			Me.layoutViewColumn2.Name = "layoutViewColumn2"
			Me.layoutViewColumn2.Visible = True
			Me.layoutViewColumn2.VisibleIndex = 1
			' 
			' layoutViewColumn3
			' 
			Me.layoutViewColumn3.Caption = "CurrentDate"
			Me.layoutViewColumn3.FieldName = "CurrentDate"
			Me.layoutViewColumn3.Name = "layoutViewColumn3"
			Me.layoutViewColumn3.Visible = True
			Me.layoutViewColumn3.VisibleIndex = 2
			' 
			' layoutViewColumn4
			' 
			Me.layoutViewColumn4.Caption = "DoubleProperty"
			Me.layoutViewColumn4.FieldName = "DoubleProperty"
			Me.layoutViewColumn4.Name = "layoutViewColumn4"
			Me.layoutViewColumn4.Visible = True
			Me.layoutViewColumn4.VisibleIndex = 3
			' 
			' advBandedGridView1
			' 
			Me.advBandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.advBandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() { Me.colBoolProperty, Me.colStringProperty, Me.colCurrentDate, Me.colDoubleProperty})
			Me.advBandedGridView1.GridControl = Me.gridControl1
			Me.advBandedGridView1.Name = "advBandedGridView1"
			Me.advBandedGridView1.OptionsSelection.MultiSelect = True
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Columns.Add(Me.colBoolProperty)
			Me.gridBand1.Columns.Add(Me.colStringProperty)
			Me.gridBand1.Columns.Add(Me.colCurrentDate)
			Me.gridBand1.Columns.Add(Me.colDoubleProperty)
			Me.gridBand1.Name = "gridBand1"
			Me.gridBand1.Width = 464
			' 
			' colBoolProperty
			' 
			Me.colBoolProperty.Caption = "BoolProperty"
			Me.colBoolProperty.FieldName = "BoolProperty"
			Me.colBoolProperty.Name = "colBoolProperty"
			Me.colBoolProperty.Visible = True
			Me.colBoolProperty.Width = 116
			' 
			' colStringProperty
			' 
			Me.colStringProperty.Caption = "StringProperty"
			Me.colStringProperty.FieldName = "StringProperty"
			Me.colStringProperty.Name = "colStringProperty"
			Me.colStringProperty.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True
			Me.colStringProperty.Visible = True
			Me.colStringProperty.Width = 116
			' 
			' colCurrentDate
			' 
			Me.colCurrentDate.Caption = "CurrentDate"
			Me.colCurrentDate.FieldName = "CurrentDate"
			Me.colCurrentDate.Name = "colCurrentDate"
			Me.colCurrentDate.Visible = True
			Me.colCurrentDate.Width = 116
			' 
			' colDoubleProperty
			' 
			Me.colDoubleProperty.Caption = "DoubleProperty"
			Me.colDoubleProperty.FieldName = "DoubleProperty"
			Me.colDoubleProperty.Name = "colDoubleProperty"
			Me.colDoubleProperty.Visible = True
			Me.colDoubleProperty.Width = 116
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Location = New System.Drawing.Point(526, 40)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(123, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "simpleButton1"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' listBoxControl1
			' 
			Me.listBoxControl1.Location = New System.Drawing.Point(489, 97)
			Me.listBoxControl1.Name = "listBoxControl1"
			Me.listBoxControl1.Size = New System.Drawing.Size(228, 249)
			Me.listBoxControl1.TabIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(740, 358)
			Me.Controls.Add(Me.listBoxControl1)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colBoolProperty1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colStringProperty1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colCurrentDate1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_colDoubleProperty1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.cardView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.advBandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dataSet11 As DataSet1
		Private dataTable1BindingSource As System.Windows.Forms.BindingSource
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private advBandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private colBoolProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colStringProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colCurrentDate As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private colDoubleProperty As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
		Private repositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
		Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
		Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
		Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView
		Private layoutViewColumn1 As DevExpress.XtraGrid.Columns.GridColumn
		Private layoutViewColumn2 As DevExpress.XtraGrid.Columns.GridColumn
		Private layoutViewColumn3 As DevExpress.XtraGrid.Columns.GridColumn
		Private layoutViewColumn4 As DevExpress.XtraGrid.Columns.GridColumn
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private layoutViewColumn5 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colBoolProperty1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewColumn6 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colStringProperty1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewColumn7 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colCurrentDate1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewColumn8 As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_colDoubleProperty1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard
		Private colStringProperty1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colCurrentDate1 As DevExpress.XtraGrid.Columns.GridColumn
		Private colIntProperty As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
	End Class
End Namespace

