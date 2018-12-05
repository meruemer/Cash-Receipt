
Module mod_connection
    Public Sub connection()
        With conn
            .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\POP.accdb;Persist Security Info= False;"
        End With
    End Sub
End Module
