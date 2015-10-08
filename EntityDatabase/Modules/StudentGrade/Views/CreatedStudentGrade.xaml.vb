Imports Modules.StudentGrades.ViewModels

Public Class CreatedStudentGrade
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Grid.DataContext = New CreatedStudentGradeViewModel(Me)
    End Sub
End Class
