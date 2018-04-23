Imports System
Imports System.Windows
Imports System.Reflection

Namespace LoadPDFDocument

    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()

            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)
            Dim uri As New Uri(baseUri, "..\..\Demo.pdf")
            Viewer.DocumentSource = uri
        End Sub
    End Class
End Namespace
