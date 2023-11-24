Imports System.Data.SqlClient

Public Class _Default
    Inherits Page
    Dim connect As New SqlConnection("Data Source=LAPTOP-4OGNKJ6A\SQLEXPRESS;Initial Catalog=TestCRUD_DB;Integrated Security=True")
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If (Page.IsPostBack = False) Then
            Try
                SetEmployeeTypes()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Session("EmployeeID") = 0
        Response.Redirect("About.aspx")
    End Sub
    Private Sub SetEmployeeTypes()
        Dim command As New SqlCommand("select * from EmployeeType", connect)
        Dim sd As New SqlDataAdapter(command)
        Dim dt As New DataTable
        sd.Fill(dt)

        connect.Open()
        Dim commandInsert As New SqlCommand("insert into EmployeeType values ('AAA', 'Type 1'); insert into EmployeeType values ('BBB', 'Type 2');", connect)
        commandInsert.ExecuteNonQuery()
        connect.Close()
    End Sub

    Protected Sub GridView1_RowEditing(sender As Object, e As GridViewEditEventArgs)
        Dim primarykey As Integer = Convert.ToInt32(GridView1.DataKeys(e.NewEditIndex).Value)
        Session("EmployeeID") = primarykey
        Response.Redirect("About.aspx")
        'btnAddNew.clie
    End Sub
End Class