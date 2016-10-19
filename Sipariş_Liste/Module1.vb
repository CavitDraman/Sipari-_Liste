Module Module1

    Private BoyutStokKodAdp As New DataSet1TableAdapters.STK_TANIMTableAdapter
    Private AltBrmAdp As New DataSet1TableAdapters.ALTERNATIF_BIRIMTableAdapter

    'Private StkKodBolumAdp As New UrunKodlamaDataSetTableAdapters.STK_KOD_ALT_BOLUMTableAdapter
    Private StkKodBolumAdp As New DataSet1TableAdapters.STK_KOD_ALTBOLUMTableAdapter

    Private Structure FerKodBolum
        Dim Grup As String
        Dim ABolum As String
        Dim Dis_3 As String
        Dim Serit_4 As String
        Dim Bitirme_5 As String
        Dim UstStop_6 As String
        Dim AltStop_7 As String

        Dim Dis_Gr As Single
        Dim Serit_Gr As Single
        Dim Bit_Gr As Single
        Dim Usstp_Gr As Single
        Dim AltStpGr As Single

    End Structure

    Private Structure TumKod
        Dim FerKod As String
        Dim Kur1 As String
        Dim Kur2 As String
    End Structure

    Private Function KodParcala(StkKod As String) As TumKod

        Dim Grp As New TumKod

        If StkKod.Length = 0 Then
            Return Nothing
        End If

        Select Case StkKod.Substring(0, 1)

            Case "F"
                Select Case StkKod.Length

                    Case 21 'Fermuar stok kodu
                        Grp.FerKod = StkKod
                        Grp.Kur1 = ""
                        Grp.Kur2 = ""

                    Case 25 'Oto Fer stok kodu
                        Grp.FerKod = StkKod
                        Grp.Kur1 = ""
                        Grp.Kur2 = ""

                    Case 29 'otomotiv ütün kodları
                        Grp.FerKod = StkKod  '.Substring(0, 25)
                        Grp.Kur1 = ""
                        Grp.Kur2 = ""

                    Case 51 'fermuar kodları tek kürsörlü
                        Grp.FerKod = StkKod.Substring(0, 21)
                        Grp.Kur1 = StkKod.Substring(21, 30)
                        Grp.Kur2 = ""

                    Case 81 'fermuar kodları çift kürsörlü
                        Grp.FerKod = StkKod.Substring(0, 21)
                        Grp.Kur1 = StkKod.Substring(21, 30)
                        Grp.Kur2 = StkKod.Substring(51, 30)

                    Case Else
                        Grp = Nothing

                End Select

            Case "P"
                Grp.FerKod = ""
                Grp.Kur1 = StkKod
                Grp.Kur2 = ""

            Case "S", "T"

                Grp.FerKod = ""
                Grp.Kur1 = StkKod
                Grp.Kur2 = ""

            Case Else

                Grp = Nothing

        End Select

        Return Grp
    End Function

    Private Function FerBolums(FKod As String) As FerKodBolum
        Dim Fblms As New FerKodBolum

        With Fblms
            .Grup = FKod.Substring(0, 1)
            .ABolum = FKod.Substring(1, 5)
            .Dis_3 = FKod.Substring(6, 3)
            .Serit_4 = FKod.Substring(9, 2)
            .Bitirme_5 = FKod.Substring(11, 2)
            .UstStop_6 = FKod.Substring(13, 4)
            .AltStop_7 = FKod.Substring(17, 4)

            .Dis_Gr = KodParcaGrBul(.ABolum, 3, .Dis_3)
            .Serit_Gr = KodParcaGrBul(.ABolum, 4, .Serit_4)
            .Bit_Gr = KodParcaGrBul(.ABolum, 5, .Bitirme_5)
            .Usstp_Gr = KodParcaGrBul(.ABolum, 6, .UstStop_6)
            .AltStpGr = KodParcaGrBul(.ABolum, 7, .AltStop_7)
        End With

        Return Fblms
    End Function

    Private Function Fermuar_GrHesap(FerKod As String, ByRef FBlm As FerKodBolum, Optional Boy As Single = 0) As Single
        Dim Gram As Single = 0
        FBlm = FerBolums(FerKod)

        Select Case FBlm.ABolum.Substring(0, 1)

            Case "R" 'Polyester 

                Select Case FBlm.Bitirme_5
                    Case "D-" : Gram = (Boy + 5) * FBlm.Serit_Gr / 100 + FBlm.Usstp_Gr + FBlm.AltStpGr
                    Case "S-" : Gram = (Boy + 5) * FBlm.Serit_Gr / 100 + FBlm.Bit_Gr + FBlm.Usstp_Gr
                    Case "2A" : Gram = (Boy + 5) * FBlm.Serit_Gr / 100 + FBlm.Bit_Gr + FBlm.Usstp_Gr
                    Case "2O" : Gram = (Boy + 5) * FBlm.Serit_Gr / 100 + FBlm.Bit_Gr
                    Case "2X" : Gram = (Boy + 5) * FBlm.Serit_Gr / 100 + FBlm.Bit_Gr
                End Select

            Case "T" 'Metal

                Select Case FBlm.Bitirme_5
                    Case "D-" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Usstp_Gr + FBlm.AltStpGr
                    Case "S-" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr + FBlm.Usstp_Gr
                    Case "2A" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr + FBlm.Usstp_Gr
                    Case "2O" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr
                    Case "2X" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr
                End Select

            Case "D" 'Kemik

                Select Case FBlm.Bitirme_5
                    Case "D-" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Usstp_Gr + FBlm.AltStpGr
                    Case "S-" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr + FBlm.Usstp_Gr
                    Case "2A" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr + FBlm.Usstp_Gr
                    Case "2O" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr
                    Case "2X" : Gram = (Boy + 5) * FBlm.Serit_Gr * 2 / 100 + FBlm.Dis_Gr * Boy / 100 + FBlm.Bit_Gr
                End Select

            Case "O" 'Otomotiv

                Gram = OtoFerGrAl(FerKod)

            Case Else

                Gram = 0

        End Select

        Return Gram

    End Function

    Private Function PDGrBul(KurKod As String) As Single
        Dim Gr As Single
        Dim AltBrTable As New DataSet1.ALTERNATIF_BIRIMDataTable
        Dim StkId As Decimal = BoyutStokKodAdp.ScalarQuery_STK_ID_BUL(KurKod)

        AltBrmAdp.Fill(AltBrTable, StkId)

        If AltBrTable.Rows.Count > 0 Then
            Dim Rw As DataSet1.ALTERNATIF_BIRIMRow = AltBrTable.FindBySTK_IDBIRIM(StkId, "KG")
            Select Case Rw.CEV_ISLEMI
                Case 1
                    Gr = Rw.CEV_KATSAYI * 1000
                Case 2
                    Gr = 1000 / Rw.CEV_KATSAYI
            End Select
        Else
            Gr = 0
        End If

        Return Gr
    End Function

    Private Function KodParcaGrBul(Ablm As String, BlNo As String, Kod As String) As Single
        Dim Gr As Single = 0

        Try
            Gr = StkKodBolumAdp.ScalarQuery_GrBul(Ablm, BlNo, Kod)
        Catch ex As Exception
            Gr = 0
        End Try

        Return Gr

    End Function

    Private Function OtoFerGrAl(FerKod As String) As Single
        Dim Gr As Decimal = BoyutStokKodAdp.ScalarQuery_OtoFer_BrGr(FerKod)
        Return Gr
    End Function

    Public Function Ağırlık(STKKOD As String, Optional Boy As Single = 0, Optional ByRef Msj As String = "") As Single

        Dim KodGrupları As TumKod = KodParcala(STKKOD)

        Dim FerBrGr As Single
        Dim kur1Gr As Single
        Dim kur2Gr As Single

        Try

            If KodGrupları.FerKod <> "" Then
                Dim FerBolumleri As New FerKodBolum
                FerBrGr = Fermuar_GrHesap(KodGrupları.FerKod, FerBolumleri, Boy)

                If FerBolumleri.Serit_Gr = 0 Then Msj &= "Şerit=0;"
                If FerBolumleri.Dis_Gr = 0 Then Msj &= "Diş=0;"
                If FerBolumleri.Bit_Gr = 0 Then Msj &= "Bitirme=0;"
                If FerBolumleri.Usstp_Gr = 0 Then Msj &= "UstStp=0;"
                If FerBolumleri.AltStpGr = 0 Then Msj &= "AltStp=0;"
            End If

            If KodGrupları.Kur1 <> "" Then kur1Gr = PDGrBul(KodGrupları.Kur1)
            If KodGrupları.Kur2 <> "" Then kur2Gr = PDGrBul(KodGrupları.Kur2)

            If kur1Gr = 0 Then Msj &= "1.kursör=0"
            If kur2Gr = 0 Then Msj &= "2.kursör=0"

            Dim ToplamGr As Single = FerBrGr + kur1Gr + kur2Gr

            Return ToplamGr

        Catch ex As Exception

            Return 0

        End Try

    End Function
End Module
