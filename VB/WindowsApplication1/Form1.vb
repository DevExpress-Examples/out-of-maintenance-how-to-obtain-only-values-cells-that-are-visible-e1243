Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid

Imports DevExpress.XtraGrid.Views.Grid.Customization

Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils
Imports System.Reflection
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Scrolling
Imports DevExpress.XtraGrid.Drawing

Namespace WindowsApplication1
	Public Partial Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub


		Public Sub InitData()
			For i As Integer = 0 To 3
				dataSet11.DataTable1.Rows.Add(New Object() { 0, i.ToString() & "item",DateTime.Today, i })
			Next i

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			InitData()
		End Sub



		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			listBoxControl1.Items.Clear()
			Dim vi As GridViewInfo = TryCast(gridView1.GetViewInfo(), GridViewInfo)
			Dim screenRowCollection As GridRowInfoCollection = vi.RowsInfo
			Dim screenColumnwCollection As GridColumnsInfo = vi.ColumnsInfo
			For Each ri As GridRowInfo In screenRowCollection
				For Each ci As GridColumnInfoArgs In screenColumnwCollection
					If Not ci.Column Is Nothing Then
						listBoxControl1.Items.Add((gridView1.GetRowCellValue(ri.RowHandle, ci.Column).ToString()))
					End If
				Next ci
			Next ri
		End Sub


	End Class
End Namespace
