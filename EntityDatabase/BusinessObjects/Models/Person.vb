'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Person
    Public Property PersonID As Integer
    Public Property LastName As String
    Public Property FirstName As String
    Public Property HireDate As Nullable(Of Date)
    Public Property EnrollmentDate As Nullable(Of Date)

    Public Overridable Property OfficeAssignment As OfficeAssignment
    Public Overridable Property StudentGrades As ICollection(Of StudentGrade) = New HashSet(Of StudentGrade)
    Public Overridable Property Courses As ICollection(Of Course) = New HashSet(Of Course)

End Class
