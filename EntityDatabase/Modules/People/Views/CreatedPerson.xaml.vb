Imports Modules.People.ViewModels
Public Class CreatedPerson

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Grid.DataContext = New CreatedPersonVIewModel(Me)
    End Sub


End Class
