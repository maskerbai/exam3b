Imports System.Threading
Imports System.Globalization

Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Overrides Sub InitializeCulture()

        Dim lang As String = Request("language1")

        If lang IsNot Nothing Or lang <> "" Then

            Thread.CurrentThread.CurrentUICulture = New CultureInfo(lang)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang)
        End If

    End Sub

    Protected Sub bt_submit_Click(sender As Object, e As EventArgs) Handles bt_submit.Click

    End Sub
End Class
