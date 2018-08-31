'*********************************************************************'
'* Copyright 2005-2016 - Accusoft Corporation, Tampa Florida.        *'
'* This sample code is provided to Accusoft licensees "as is"        *'
'* with no restrictions on use or modification. No warranty for      *'
'* use of this sample code is provided by Accusoft.                  *'
'*********************************************************************'
Imports System.Windows.Forms

NotInheritable Class Program
	Private Sub New()
	End Sub
	''' <summary>
	''' The main entry point for the application.
    ''' </summary>
	<STAThread> _
	Friend Shared Sub Main()
		Application.EnableVisualStyles()
		Application.SetCompatibleTextRenderingDefault(False)
		Application.Run(New MainForm())
	End Sub
End Class
