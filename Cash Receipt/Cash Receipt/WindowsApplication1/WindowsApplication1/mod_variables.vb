Imports System.Data.OleDb
Module mod_variables
    Public conn As New OleDbConnection
    Public cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dt As New DataTable
    Public connstring As String
    Public sql As String
    Public logger As String
End Module
