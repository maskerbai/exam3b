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



    Sub PageLoad(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Dim name As String
        'Dim salary As Double
        'Dim male As String
        'Dim female As String
        'Dim graduationdate As String

        ' Get the value of TextBox1 from the page that posted to this page.
        'name = CType((PreviousPage.FindControl("tb_name")), TextBox).Text
        'salary = CType((PreviousPage.FindControl("tb_salary")), TextBox).Text
        'male = CType((PreviousPage.FindControl("rb1")), RadioButton).Checked
        'female = CType((PreviousPage.FindControl("rb2")), RadioButton).Checked
        'graduationdate = CType((PreviousPage.FindControl("labeldate")), Label).Text

        ' Check for an empty string.
        'If Not Page.PreviousPage Is Nothing Then

        Dim salary As Decimal = CType(Session.Item("salary"), String)

        'Dim gradate As String = Session("date").ToString()
        'Dim salary As String = Session("salary").ToString()




        If Session("male") = True Then
            Label7.Text = "Mr."

        End If

        If Session("female") = True Then
            Label15.Text = "Mrs."

        End If


        Label8.Text = Session("name")

        Label10.Text = Session("date")

        Label12.Text = String.Format("{0:c}", salary)

        'End If


    End Sub


   

   
End Class
