Public Class Form1
    Private BoyutSisConnStr As String
    Private BoyutConn As New Odbc.OdbcConnection
    Public AppName As String = Application.ProductName '"BoyutSisConnection"

    Private Filter As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, CheckBox1.CheckedChanged
        Try
            Dim UserName = GetSetting(AppName, "Connection Settings", "User")
            Dim Password = GetSetting(AppName, "Connection Settings", "PassWord")
            Dim Dsn = GetSetting(AppName, "Connection Settings", "Dsn")

            BoyutSisConnStr = "Dsn=" & Dsn & ";uid=" & UserName & ";databasename=" & Dsn & ";pwd=" & Password
            BoyutConn.Close()
            BoyutConn.ConnectionString = BoyutSisConnStr

            Me.SIPARISTableAdapter.Connection.ConnectionString = BoyutSisConnStr
            'Me.FIRMATableAdapter.Connection = BoyutConn

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Boyut Bağlantısı")
        End Try

        Try
            Me.SIPARISTableAdapter.Fill(Me.DataSet1.SIPARIS, Not CheckBox1.Checked)
            Filtreleme(Nothing, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "--")
        End Try

    End Sub

    'Excel
    Private Sub ExceleVerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExceleVerToolStripMenuItem.Click

        Dim Excel As Object
        Dim WBook As Object
        Dim WSheet As Object

        Dim RwNum As Integer
        Try
            TextBox_Firma.Focus()

            Excel = CreateObject("Excel.Application")
            WBook = Excel.Workbooks.add
            WSheet = WBook.Worksheets(1)

            If CheckBox_Firma.Checked Then
                Dim FirmaKod As String = DataGridView1.Rows(0).Cells("FIRMA_KODU").Value
                Dim FirmaTbl As New DataSet1.FIRMADataTable

                FIRMATableAdapter.FillBy_FIRMA_KODU(FirmaTbl, FirmaKod)

                WSheet.Cells(1, 2) = FirmaKod

                If FirmaTbl.Rows.Count > 0 Then
                    Dim FRow As DataSet1.FIRMARow = FirmaTbl.Rows(0)
                    WSheet.Cells(2, 2) = IIf(FRow.IsADRES_1Null, "-", FRow("ADRES_1"))
                    WSheet.Cells(3, 2) = IIf(FRow.IsADRES_2Null, "-", FRow("ADRES_2"))
                    WSheet.Cells(4, 2) = IIf(FRow.IsADRES_3Null, "-", FRow("ADRES_3"))
                    WSheet.Cells(5, 2) = IIf(FRow.IsADRES_4Null, "-", FRow("ADRES_4"))
                    WSheet.Cells(6, 2) = IIf(FRow.IsPOSTA_KODUNull, "-", FRow("POSTA_KODU")) & "  " &
                                         IIf(FRow.IsSEHIRNull, "-", FRow("SEHIR")) & " / " &
                                         IIf(FRow.IsULKE_KODUNull, "-", FRow("ULKE_KODU"))
                    RwNum = 8
                Else
                    RwNum = 3
                End If
            Else
                RwNum = 1
            End If

            Dim c As Integer = 1

            For Each Cl As DataGridViewColumn In DataGridView1.Columns
                WSheet.Cells(RwNum, c) = Cl.HeaderText
                c += 1
            Next

            RwNum += 1

            For Each Rw As DataGridViewRow In DataGridView1.Rows
                If Rw.Cells("Secim").Value Then
                    c = 1
                    For Each Cell As DataGridViewCell In Rw.Cells
                        WSheet.Cells(RwNum, c) = Cell.Value '.ToString.Trim
                        c += 1
                    Next
                    RwNum += 1
                End If
            Next

            WSheet.Columns("A:O").EntireColumn.AutoFit()

            Excel.visible = True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Excel'e Aktarma Hatası")

        End Try

    End Sub

    Private Sub Filtreleme(sender As Object, e As EventArgs) Handles TextBox1.TextChanged,
                                                                     CheckBox2.CheckedChanged,
                                                                     DateTimePicker1.ValueChanged,
                                                                     TextBox_Firma.TextChanged,
                                                                     CheckBox_Firma.CheckedChanged


        Try
            Filter = "SIP_NO LIKE '%" & TextBox1.Text & "%'"

            If CheckBox2.Checked Then
                Dim Dt As Date = DateTimePicker1.Value.Date
                Filter &= "AND SEV_TAR = '" & Dt.Year & "-" & Dt.Month & "-" & Dt.Day & "' "
            End If

            If CheckBox_Firma.Checked Then
                Filter &= " AND FIRMA_KODU LIKE '" & TextBox_Firma.Text & "%'"
            End If

            SIPARISBindingSource.Filter = Filter

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        For Each R As DataGridViewRow In DataGridView1.Rows
            R.Cells("Secim").Value = CheckBox3.Checked
        Next
    End Sub

    Private Sub BoyutSisKullanıcıToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoyutSisKullanıcıToolStripMenuItem.Click
        If LoginForm1.ShowDialog = Windows.Forms.DialogResult.OK Then
            BoyutSisConnStr = LoginForm1.BoyutConnString
            BoyutConn.Close()
            BoyutConn.ConnectionString = BoyutSisConnStr
        End If

    End Sub

    Private Sub KapatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KapatToolStripMenuItem.Click
        End
    End Sub

    Private Sub Button_GrHesap_Click(sender As Object, e As EventArgs) Handles Button_GrHesap.Click

        For Each DRow As DataGridViewRow In DataGridView1.Rows

            Dim StkKod As String = DRow.Cells("STK_KODU").Value
            Dim Msg As String = ""

            Try
                Dim Boy As Single = IIf(IsNumeric(DRow.Cells("TED_1").Value), DRow.Cells("TED_1").Value, 0)

                Dim BrGr As Single = Ağırlık(StkKod, Boy, Msg)

                DRow.Cells("BrGr").Value = BrGr
                DRow.Cells("ToplamKg").Value = BrGr * DRow.Cells("SIP_ADEDI").Value / 1000

            Catch ex As Exception

                DRow.Cells("BrGr").Value = Msg

            End Try
        Next

    End Sub
End Class
