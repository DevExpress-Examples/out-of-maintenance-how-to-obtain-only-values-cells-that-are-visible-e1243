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
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace WindowsApplication1
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

				 Application.Run(New Form1())
		End Sub
	End Class
End Namespace