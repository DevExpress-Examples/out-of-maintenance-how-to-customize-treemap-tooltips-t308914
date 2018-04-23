Imports DevExpress.Xpf.TreeMap
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes

Namespace TreeMapToolTipSample
    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub
    End Class

    <ContentProperty("Position")> _
    Public Class PositionWrapper
        Public Property PositionName() As String
        Public Property Position() As ToolTipPosition
    End Class

    Public Class OpenModeWrapper
        Public Property OpenModeName() As String
        Public Property OpenMode() As ToolTipOpenMode
    End Class
End Namespace
