Imports System.Threading
Imports System.Globalization



Partial Class _Default
    Inherits System.Web.UI.Page


    Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim name As String
        Dim salary As Double
        Dim gender As String
        Dim graduationdate As String

        ' Get the value of TextBox1 from the page that posted to this page.
        name = CType((PreviousPage.FindControl("tb_name")), TextBox).Text
        salary = CType((PreviousPage.FindControl("tb_salary")), TextBox).Text
        gender = CType((PreviousPage.FindControl("rbl_gender")), RadioButtonList).Text
        graduationdate = CType((PreviousPage.FindControl("labeldate")), Label).Text

        ' Check for an empty string.
        If Not (name = "") Then

            If gender = "Male" Then
                Label7.Text = "Mr."
            Else : Label7.Text = "Mrs."
            End If

            Label8.Text = name

            Label10.Text = graduationdate

            Label12.Text = String.Format("{0:C}", salary)


        Else



        End If

    End Sub


    Protected Overrides Sub InitializeCulture()

        Dim lang As String = Request("language1")

        If lang IsNot Nothing Or lang <> "" Then

            Thread.CurrentThread.CurrentUICulture = New CultureInfo(lang)
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang)
        End If

    End Sub

   
End Class
