// Developer Express Code Central Example:
// How to obtain only values cells that are visible
// 
// This task can be accomplished by using the GridViewInfo class. This class
// provides collections of the visible rows (the GridRowInfoCollection) and visible
// columns (the GridColumnsInfo).
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E1243

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;

using DevExpress.XtraGrid.Views.Grid.Customization;

using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils;
using System.Reflection;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Drawing;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }


        public void InitData() {
            for (int i = 0; i <= 3; i++) {
                dataSet11.DataTable1.Rows.Add(new object[] {  0, i.ToString()+"item",DateTime.Today, i });
            }
            
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitData();
         }



		private void simpleButton1_Click(object sender, EventArgs e) {
			listBoxControl1.Items.Clear();
			GridViewInfo vi = gridView1.GetViewInfo() as GridViewInfo;
			GridRowInfoCollection screenRowCollection = vi.RowsInfo;
			GridColumnsInfo screenColumnwCollection = vi.ColumnsInfo;
			foreach(GridRowInfo ri in screenRowCollection) {
				foreach(GridColumnInfoArgs ci in screenColumnwCollection) {
					if(ci.Column != null) {
						listBoxControl1.Items.Add((gridView1.GetRowCellValue(ri.RowHandle, ci.Column).ToString()));
					}
				}
			}
		}

 
    }
}
