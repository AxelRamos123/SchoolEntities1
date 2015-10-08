Imports Modules.Courses.ViewModels
Public Class CreatedCourse
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Grid.DataContext = New CreatedCourseViewModel(Me)
    End Sub
End Class
