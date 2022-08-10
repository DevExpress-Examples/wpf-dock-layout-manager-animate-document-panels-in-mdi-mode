' Developer Express Code Central Example:
' How to enable MDI mode for a DocumentGroup
' 
' In this example, MDI mode is enabled for a DocumentGroup via the MDIStyle
' property. In this mode, the DocumentGroup's panels are represented as floating
' windows.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2190
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Input
Imports DevExpress.Xpf.Docking.VisualElements
Imports DevExpress.Xpf.Docking

Namespace DocumentGroup_MDI_Ex

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Dim d As MDIDocument = New MDIDocument()
            Dim dp As DocumentPanel = New DocumentPanel()
            Dim lp As LayoutPanel = New LayoutPanel()
        End Sub

        Private Sub PART_CloseButton_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        End Sub

        Private Sub PART_Button_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        End Sub

        Private Sub Button_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        End Sub

        Private Sub border_MouseDown(ByVal sender As Object, ByVal e As MouseButtonEventArgs)
        End Sub
    End Class
End Namespace
