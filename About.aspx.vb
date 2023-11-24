Imports System.Data.SqlClient
Imports System.Reflection
Imports System.Web.UI.WebControls.Expressions

Public Class About
    Inherits Page
    Dim connect As New SqlConnection("Data Source=LAPTOP-4OGNKJ6A\SQLEXPRESS;Initial Catalog=TestCRUD_DB;Integrated Security=True")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

        If (Page.IsPostBack = False) Then
            Dim empId As Integer = Session("EmployeeID").ToString()

            If (empId = 0) Then
                Button3.Visible = False
            End If

            Dim command As New SqlCommand("select * from Employee where ID = " & empId, connect)
                connect.Open()

                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    txtFirstName.Text = reader("FirstName").ToString()
                    txtSecondName.Text = reader("SecondName").ToString()
                    txtPhoneNumber.Text = reader("PhoneNumber").ToString()
                    ddlEmployeeType.SelectedValue = reader("EmployeeType").ToString()
                End If
                connect.Close()
            End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim firstName As String = txtFirstName.Text
        Dim lastName As String = txtSecondName.Text
        Dim phoneNumber As String = txtPhoneNumber.Text
        Dim employeeType As String = ddlEmployeeType.SelectedValue
        Dim empId As Integer = Session("EmployeeID").ToString()

        connect.Open()
        Dim command As New SqlCommand("update Employee set FirstName = '" & firstName & "', SecondName = '" & lastName & "', PhoneNumber = '" & phoneNumber & "', EmployeeType = '" & employeeType & "' where ID = " & empId & "", connect)

        If empId = 0 Then
            command = New SqlCommand("insert into Employee values ('" & firstName & "', '" & lastName & "', '" & phoneNumber & "', '" & employeeType & "')", connect)
        End If

        command.ExecuteNonQuery()
        connect.Close()

        Response.Redirect("Default.aspx")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure to delete this employee", MsgBoxStyle.YesNo, "Delete Employee")

        If result = MsgBoxResult.Yes Then
            Dim empId As Integer = Session("EmployeeID").ToString()
            connect.Open()
            Dim command As New SqlCommand("delete from Employee where ID = " & empId & "", connect)

            command.ExecuteNonQuery()
            connect.Close()

            Response.Redirect("Default.aspx")
        End If
    End Sub
End Class