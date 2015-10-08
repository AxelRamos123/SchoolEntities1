Imports Modules.OnlineCourses.ViewModels
Public Class CreatedOnlineCourse
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Grid.DataContext = New CreatedOnlineCourseViewModel(Me)
    End Sub
End Class