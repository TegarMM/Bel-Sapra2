Imports System.Data.OleDb
Module Koneksi

    Public con As OleDbConnection
    Public dr As OleDbDataReader
    Public ds As DataSet
    Public da As OleDbDataAdapter
    Public cmd As OleDbCommand
    Public str As String


    Public Sub ConOpen()
        Try
            con = New OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=data.accdb")
            con.Open()
            System.Console.WriteLine("Berhasil Konek")
        Catch ex As Exception
            System.Console.WriteLine("Gagal Konek : " & ex.Message)
        End Try
    End Sub

    Public Sub ConClose()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Function GetTable(ByVal table As String)

        da = New OleDbDataAdapter("SELECT * FROM " & table, con)
        ds = New DataSet
        da.Fill(ds)

        Return ds.Tables(0)
    End Function

    Public Function GetTableCustom(ByVal sql As String)

        da = New OleDbDataAdapter(sql, con)
        ds = New DataSet
        da.Fill(ds)

        Return ds.Tables(0)
    End Function

End Module
