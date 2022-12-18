Imports DevExpress.Xpf.TreeMap
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Markup

Namespace TreeMapToolTipSample

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    <ContentProperty("Position")>
    Public Class PositionWrapper

        Public Property PositionName As String

        Public Property Position As ToolTipPosition
    End Class

    Public Class OpenModeWrapper

        Public Property OpenModeName As String

        Public Property OpenMode As ToolTipOpenMode
    End Class
End Namespace
