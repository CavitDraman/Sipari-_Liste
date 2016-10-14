Public Class LoginForm1
    Public UserName As String
    Public Password As String
    Public Dsn As String

    Public Property BoyutConnString As String

    Private AppName As String = Form1.AppName '"BoyutSisConnection"

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        UserName = UsernameTextBox.Text
        Password = PasswordTextBox.Text
        Dsn = CB_DSN.SelectedItem

        BoyutConnString = "Dsn=" & Dsn & ";uid=" & UserName & ";databasename=" & Dsn & ";pwd=" & Password

        SaveSetting(AppName, "Connection Settings", "User", UserName)
        SaveSetting(AppName, "Connection Settings", "PassWord", Password)
        SaveSetting(AppName, "Connection Settings", "Dsn", Dsn)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        UserName = ""
        Password = ""
        Dsn = ""

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        UserName = GetSetting(AppName, "Connection Settings", "User")
        Password = GetSetting(AppName, "Connection Settings", "PassWord")
        Dsn = GetSetting(AppName, "Connection Settings", "Dsn")

        Try
            Dim DSNs As Microsoft.Win32.RegistryKey = My.Computer.Registry.LocalMachine.OpenSubKey("SOFTWARE\ODBC\ODBC.INI\ODBC Data Sources", False)

            CB_DSN.Items.Clear()

            For Each value As String In DSNs.GetValueNames
                CB_DSN.Items.Add(value)
            Next

            If Dsn <> "" Then CB_DSN.Text = Dsn

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        UsernameTextBox.Text = UserName
        PasswordTextBox.Text = Password

    End Sub

    Private Sub Button_Test_Click(sender As Object, e As EventArgs) Handles Button_Test.Click
        Try
            BoyutConnString = "Dsn=" & Dsn & ";uid=" & UserName & ";databasename=" & Dsn & ";pwd=" & Password
            Dim Conn As New Odbc.OdbcConnection(BoyutConnString)

            Conn.Open()
            Label2.Text = "Bağlantı Durumu OK"
            Label2.BackColor = Color.LightGreen
            Conn.Close()

        Catch ex As Exception
            'MsgBox("Bağlantı Kurulamadı", MsgBoxStyle.Critical)
            Label2.Text = "Bağlantı Durumu OK"
            Label2.BackColor = Color.OrangeRed
        End Try
    End Sub
End Class
