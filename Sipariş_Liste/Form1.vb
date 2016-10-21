Public Class Form1
    Private BoyutSisConnStr As String
    Private BoyutConn As New Odbc.OdbcConnection
    Public AppName As String = Application.ProductName '"BoyutSisConnection"

    Private Filter As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim UserName = GetSetting(AppName, "Connection Settings", "User")
            Dim Password = GetSetting(AppName, "Connection Settings", "PassWord")
            Dim Dsn = GetSetting(AppName, "Connection Settings", "Dsn")

            BoyutSisConnStr = "Dsn=" & Dsn & ";uid=" & UserName & ";databasename=" & Dsn & ";pwd=" & Password
            BoyutConn.Close()
            BoyutConn.ConnectionString = BoyutSisConnStr

            Me.SIPARISTableAdapter.Connection.ConnectionString = BoyutSisConnStr
            Me.FIRMATableAdapter.Connection.ConnectionString = BoyutSisConnStr

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Boyut Bağlantısı")
        End Try

        Try
            Me.FIRMATableAdapter.Fill(DataSet1.FIRMA, Not CheckBox1.Checked)
            'Me.SIPARISTableAdapter.Fill(Me.DataSet1.SIPARIS, Not CheckBox1.Checked)
            'Filtreleme(Nothing, e)

            'DataGridView2.DataSource = Liste

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "--")
        End Try

    End Sub

    'Excel
    Private Sub ExceleVerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExceleVerToolStripMenuItem.Click,
                                                                                           ExceleVerToolStripMenuItem1.Click

        Dim Excel As Object
        Dim WBook As Object
        Dim WSheet As Object

        Dim RwNum As Integer
        Try
            'TextBox_Firma.Focus()

            Excel = CreateObject("Excel.Application")
            WBook = Excel.Workbooks.add
            WSheet = WBook.Worksheets(1)

            'If CheckBox_Firma.Checked Then
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

            'Else
            '    RwNum = 1
            'End If

            Dim c As Integer = 1

            For Each Cl As DataGridViewColumn In DataGridView2.Columns
                If Cl.Visible Then
                    WSheet.Cells(RwNum, c) = Cl.HeaderText
                    c += 1
                End If
            Next

            RwNum += 1

            For Each Rw As DataGridViewRow In DataGridView2.Rows
                'If Rw.Cells("Secim").Value Then
                c = 1
                For Each Cell As DataGridViewCell In Rw.Cells
                    If Cell.OwningColumn.Visible Then
                        WSheet.Cells(RwNum, c) = Cell.Value '.ToString.Trim
                        c += 1
                    End If
                Next
                RwNum += 1
                'End If
            Next

            WSheet.Columns("A:O").EntireColumn.AutoFit()

            Excel.visible = True

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Excel'e Aktarma Hatası")

        End Try

    End Sub

    Private Sub MusteriComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MusteriComboBox.SelectedIndexChanged, CheckBox1.CheckedChanged
        Try
            Me.SIPARISTableAdapter.FillBy_Firma(Me.DataSet1.SIPARIS, Not CheckBox1.Checked, MusteriComboBox.Text)
            Filtreleme(Nothing, e)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "--")
        End Try
    End Sub

    Private Sub Filtreleme(sender As Object, e As EventArgs) Handles TextBox1.TextChanged,
                                                                     CheckBox2.CheckedChanged,
                                                                     DateTimePicker1.ValueChanged


        Try
            Filter = "SIP_NO LIKE '%" & TextBox1.Text & "%'"

            If CheckBox2.Checked Then
                Dim Dt As Date = DateTimePicker1.Value.Date
                Filter &= "AND SEV_TAR = '" & Dt.Year & "-" & Dt.Month & "-" & Dt.Day & "' "
            End If

            'If CheckBox_Firma.Checked Then
            '    Filter &= " AND FIRMA_KODU LIKE '" & TextBox_Firma.Text & "%'"
            'End If

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
            If DRow.Cells("Secim").Value Then

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
            End If
        Next

    End Sub

    Private Sub ListeyeEkle_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            For Each Rw As DataGridViewRow In DataGridView1.Rows
                If Rw.Cells("Secim").Value Then

                    DataGridView2.Rows.Add(
                        Rw.Cells("SIP_NO").Value,
                        Rw.Cells("STK_KODU").Value,
                        Rw.Cells("KRS_KAP").Value,
                        Rw.Cells("MUS_URUN_KODU").Value,
                        Rw.Cells("TED_1").Value,
                        Rw.Cells("TED_2").Value,
                        CDec(Rw.Cells("SIP_ADEDI").Value),
                        CDec(Rw.Cells("ToplamKg").Value),
                        0,
                        CDec(Rw.Cells("BrGr").Value))
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListedenKaldırToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListedenKaldırToolStripMenuItem.Click
        Try
            For Each RW In DataGridView2.SelectedRows
                DataGridView2.Rows.Remove(RW)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub KoliNoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KoliNoToolStripMenuItem.Click

        Dim MaxKg As Single = InputBox("Maximun Koli Ağırlığı", "Ağırlık Limitini Girin", 25)
        Dim ToplKg As Single = 0
        Dim KoliNo As Integer = 1

        If MaxKg = 0 Then Exit Sub

        Try
            For Each RW As DataGridViewRow In DataGridView2.Rows
                Dim Kg As Single = RW.Cells("Kg").Value

                If Kg > MaxKg Then
                    KoliNo += 1
                    ToplKg = Kg

                ElseIf (ToplKg + Kg) > MaxKg Then
                    KoliNo += 1
                    ToplKg = 0

                Else
                    ToplKg += Kg
                End If

                RW.Cells("KoliNo").Value = CInt(KoliNo)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TemizleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TemizleToolStripMenuItem.Click
        DataGridView2.Rows.Clear()
    End Sub
    Private Sub BölToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BölToolStripMenuItem.Click
        Try
            If DataGridView2.SelectedRows.Count > 0 Then

                Dim RW As DataGridViewRow = DataGridView2.SelectedRows(0)

                With DialogBol
                    .Adet = RW.Cells("Adet").Value
                    .BrGr = RW.Cells("BirimGr").Value
                    .Urun = RW.Cells("MustUrunKod").Value & " / " & RW.Cells("Adet").Value & " Adet"

                    If .ShowDialog() = DialogResult.OK Then
                        For Each NRow As DataRow In .Res.Rows
                            If Not IsDBNull(NRow("Adet")) Then
                                DataGridView2.Rows.Add(
                                    RW.Cells("SIPNO").Value,
                                    RW.Cells("StkKod").Value,
                                    RW.Cells("KurKapl").Value,
                                    RW.Cells("MustUrunKod").Value,
                                    RW.Cells("Ted1").Value,
                                    RW.Cells("Ted2").Value,
                                    CDec(NRow("Adet")),
                                    CDec(NRow("Kg")),
                                    CInt(RW.Cells("KoliNo").Value), 'RW.Cells("KoliNo").Value.ToString,     '
                                CDec(RW.Cells("BirimGr").Value))
                            End If
                        Next

                        DataGridView2.Rows.Remove(RW)

                    End If

                End With
            End If

            For Each R As DataGridViewRow In DataGridView2.Rows
                R.Cells("KoliNo").Value = CInt(R.Cells("KoliNo").Value)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub KoliKg()

        Dim TmpTable As TmpDataSet.KoliListeDataTable = MakeDataTable()

        Dim XX = From K In TmpTable
                 Group By K.KoliNo Into NetKg = Sum(K.Kg)
                 Select KoliNo, NetKg

        KoliDataGridView.Rows.Clear()
        For Each X In XX
            KoliDataGridView.Rows.Add(X.KoliNo, X.NetKg)
        Next
    End Sub

    Private Sub DataGridView2_RowStateChanged(sender As Object, e As DataGridViewRowStateChangedEventArgs) Handles DataGridView2.RowStateChanged
        KoliKg()
    End Sub

    Private Function MakeDataTable() As TmpDataSet.KoliListeDataTable
        Dim Tmptable As New TmpDataSet.KoliListeDataTable

        For Each RW As DataGridViewRow In DataGridView2.Rows
            Tmptable.Rows.Add(RW.Cells("KoliNo").Value, RW.Cells("Kg").Value)
        Next

        Return Tmptable

    End Function

    Private Sub DataGridView2_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEndEdit

        Select Case DataGridView2.Columns(e.ColumnIndex).Name
            Case "KoliNo"
                KoliKg()
            Case "Adet"
                Dim Rw As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
                Rw.Cells("Kg").Value = Rw.Cells("Adet").Value * Rw.Cells("BirimGr").Value / 1000
        End Select
    End Sub

    Private Sub DataGridView2_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView2.ColumnHeaderMouseClick
        If e.ColumnIndex = 8 Then
            DataGridView2.Sort(New RowComparer(SortOrder.Ascending))
        End If
    End Sub

#Region "Sort Metodu"
    Private Class RowComparer
        Implements System.Collections.IComparer

        Private sortOrderModifier As Integer = 1

        Public Sub New(ByVal sortOrder As SortOrder)
            If sortOrder = SortOrder.Descending Then
                sortOrderModifier = -1
            ElseIf sortOrder = SortOrder.Ascending Then
                sortOrderModifier = 1
            End If
        End Sub

        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements System.Collections.IComparer.Compare

            Dim Row1 As DataGridViewRow = CType(x, DataGridViewRow)
            Dim Row2 As DataGridViewRow = CType(y, DataGridViewRow)

            Dim x1 As Integer = CInt(Row1.Cells(8).Value)
            Dim y1 As Integer = CInt(Row2.Cells(8).Value)

            Dim CompareResult As Integer
            If x1 > y1 Then
                CompareResult = 1
            ElseIf x1 < y1 Then
                CompareResult = -1
            ElseIf x1 = y1 Then
                CompareResult = 0
            End If

            'String.Compare(
            '    DataGridViewRow1.Cells(1).Value.ToString(),
            '    DataGridViewRow2.Cells(1).Value.ToString())

            ' If the Last Names are equal, sort based on the First Name.
            'If CompareResult = 0 Then
            '    CompareResult = String.Compare(
            '        Row1.Cells(0).Value.ToString(),
            '        Row2.Cells(0).Value.ToString())
            'End If

            Return CompareResult * sortOrderModifier

        End Function
    End Class
#End Region
End Class


