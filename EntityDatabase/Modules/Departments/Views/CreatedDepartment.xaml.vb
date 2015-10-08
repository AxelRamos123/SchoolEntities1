Imports Modules.Departments.ViewModels
Public Class CreatedDepartment
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Grid.DataContext = New CreatedDepartmentViewModel(Me)
    End Sub

End Class
