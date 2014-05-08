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

    'Protected Sub Calendar1_DataBinding(sender As Object, e As EventArgs) Handles Calendar1.DataBinding

    'Dim graduationdate As String = Calendar1.SelectedDate.ToShortDateString()

    'labeldate.Text = graduationdate

    'End Sub

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As EventArgs) Handles Calendar1.SelectionChanged

        Dim graduationdate As String = Calendar1.SelectedDate.ToShortDateString()

        labeldate.Text = graduationdate

    End Sub


    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Session("name") = tb_name.Text
        Session("salary") = tb_salary.Text
        Session("male") = rb1.Checked
        Session("female") = rb2.Checked
        Session("date") = labeldate.Text

    End Sub



    
    Protected Sub bt_submit_Click(sender As Object, e As EventArgs) Handles bt_submit.Click
        Response.Redirect("~/default2.aspx")
    End Sub
End Class
