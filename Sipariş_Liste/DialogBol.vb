Imports System.Windows.Forms

Public Class DialogBol
    Public Property BrGr As Single
    Public Property Adet As Integer
    Public WriteOnly Property Urun As String
        Set(value As String)
            Me.Text = value
        End Set
    End Property

    Public Res As DataTable

    Private TopAd As Integer
    Private TopKg As Single
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click

        Res = New DataTable

        With Res.Columns
            .Add("Adet")
            .Add("Kg")
        End With

        If TopAd <> Adet Then
            MsgBox("Adet Hatalı.!", MsgBoxStyle.Information)
            Exit Sub
        End If

        For Each R As DataGridViewRow In DataGridView1.Rows
            Res.Rows.Add(R.Cells(0).Value, R.Cells(1).Value)
        Next

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub DialogBol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Rows.Add(Adet, Adet * BrGr / 1000)
        TopKg = Adet * BrGr / 100
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit,
                                                                                                    DataGridView1.RowLeave

        TopAd = 0
        TopKg = 0

        For Each R As DataGridViewRow In DataGridView1.Rows
            R.Cells("Kilo").Value = R.Cells("Ad").Value * BrGr / 1000
            TopAd += R.Cells("Ad").Value
            TopKg += R.Cells("Kilo").Value
        Next

        AdetTextBox.Text = TopAd
        KiloTextBox.Text = TopKg

    End Sub
End Class
