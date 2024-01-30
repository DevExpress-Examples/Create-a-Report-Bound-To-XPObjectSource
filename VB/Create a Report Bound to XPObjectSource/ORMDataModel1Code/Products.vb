Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace Create_a_Report_Bound_to_XPObjectSource.nwind

    Public Partial Class Products

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub
    End Class
End Namespace
