<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Firma = New System.Windows.Forms.CheckBox()
        Me.TextBox_Firma = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DosyaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BoyutSisKullanıcıToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExceleVerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KapatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_GrHesap = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Secim = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.FIRMA_KODU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIP_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUS_SIP_NO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STK_KODU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KRS_KAP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MUS_URUN_KODU = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TED_1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TED_2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIP_ADEDI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEV_TAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrGr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToplamKg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Grup = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIPARISBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Sipariş_Liste.DataSet1()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListedenKaldırToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TemizleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.KoliNoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExceleVerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FIRMABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIRMATableAdapter = New Sipariş_Liste.DataSet1TableAdapters.FIRMATableAdapter()
        Me.SIPARISTableAdapter = New Sipariş_Liste.DataSet1TableAdapters.SIPARISTableAdapter()
        Me.MustSıpNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MustUrunKod = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KurKapl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ted1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ted2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Adet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KoliNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirimGr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BölToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SIPARISBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.FIRMABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(544, 60)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(92, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Açık Siparişler"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 58)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(133, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SIP_NO:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(327, 58)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 7
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(227, 60)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox2.TabIndex = 6
        Me.CheckBox2.Text = "SEVK TARİHİ"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(708, 60)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox3.TabIndex = 8
        Me.CheckBox3.Text = "Hepsini Seç"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox_Firma
        '
        Me.CheckBox_Firma.AutoSize = True
        Me.CheckBox_Firma.Location = New System.Drawing.Point(19, 36)
        Me.CheckBox_Firma.Name = "CheckBox_Firma"
        Me.CheckBox_Firma.Size = New System.Drawing.Size(60, 17)
        Me.CheckBox_Firma.TabIndex = 9
        Me.CheckBox_Firma.Text = "Müşteri"
        Me.CheckBox_Firma.UseVisualStyleBackColor = True
        '
        'TextBox_Firma
        '
        Me.TextBox_Firma.Location = New System.Drawing.Point(85, 33)
        Me.TextBox_Firma.Name = "TextBox_Firma"
        Me.TextBox_Firma.Size = New System.Drawing.Size(256, 20)
        Me.TextBox_Firma.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DosyaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(999, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DosyaToolStripMenuItem
        '
        Me.DosyaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoyutSisKullanıcıToolStripMenuItem, Me.ExceleVerToolStripMenuItem, Me.ToolStripMenuItem1, Me.KapatToolStripMenuItem})
        Me.DosyaToolStripMenuItem.Name = "DosyaToolStripMenuItem"
        Me.DosyaToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.DosyaToolStripMenuItem.Text = "Dosya"
        '
        'BoyutSisKullanıcıToolStripMenuItem
        '
        Me.BoyutSisKullanıcıToolStripMenuItem.Name = "BoyutSisKullanıcıToolStripMenuItem"
        Me.BoyutSisKullanıcıToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.BoyutSisKullanıcıToolStripMenuItem.Text = "BoyutSis kullanıcı"
        '
        'ExceleVerToolStripMenuItem
        '
        Me.ExceleVerToolStripMenuItem.Name = "ExceleVerToolStripMenuItem"
        Me.ExceleVerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.ExceleVerToolStripMenuItem.Text = "Excel'e ver"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(163, 6)
        '
        'KapatToolStripMenuItem
        '
        Me.KapatToolStripMenuItem.Name = "KapatToolStripMenuItem"
        Me.KapatToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.KapatToolStripMenuItem.Text = "Kapat"
        '
        'Button_GrHesap
        '
        Me.Button_GrHesap.Location = New System.Drawing.Point(821, 36)
        Me.Button_GrHesap.Name = "Button_GrHesap"
        Me.Button_GrHesap.Size = New System.Drawing.Size(75, 44)
        Me.Button_GrHesap.TabIndex = 12
        Me.Button_GrHesap.Text = "Birim Ağırlık Hesapla"
        Me.Button_GrHesap.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 86)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Size = New System.Drawing.Size(999, 324)
        Me.SplitContainer1.SplitterDistance = 135
        Me.SplitContainer1.TabIndex = 13
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Secim, Me.FIRMA_KODU, Me.SIP_NO, Me.MUS_SIP_NO, Me.STK_KODU, Me.KRS_KAP, Me.MUS_URUN_KODU, Me.TED_1, Me.TED_2, Me.SIP_ADEDI, Me.SEV_TAR, Me.BrGr, Me.ToplamKg, Me.Grup})
        Me.DataGridView1.DataSource = Me.SIPARISBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(999, 135)
        Me.DataGridView1.TabIndex = 2
        '
        'Secim
        '
        Me.Secim.HeaderText = "Secim"
        Me.Secim.Name = "Secim"
        Me.Secim.Width = 40
        '
        'FIRMA_KODU
        '
        Me.FIRMA_KODU.DataPropertyName = "FIRMA_KODU"
        Me.FIRMA_KODU.HeaderText = "FIRMA_KODU"
        Me.FIRMA_KODU.Name = "FIRMA_KODU"
        Me.FIRMA_KODU.Width = 150
        '
        'SIP_NO
        '
        Me.SIP_NO.DataPropertyName = "SIP_NO"
        Me.SIP_NO.HeaderText = "SIP_NO"
        Me.SIP_NO.Name = "SIP_NO"
        Me.SIP_NO.ReadOnly = True
        '
        'MUS_SIP_NO
        '
        Me.MUS_SIP_NO.DataPropertyName = "MUS_SIP_NO"
        Me.MUS_SIP_NO.HeaderText = "MUS_SIP_NO"
        Me.MUS_SIP_NO.Name = "MUS_SIP_NO"
        Me.MUS_SIP_NO.ReadOnly = True
        '
        'STK_KODU
        '
        Me.STK_KODU.DataPropertyName = "STK_KODU"
        Me.STK_KODU.HeaderText = "STK_KODU"
        Me.STK_KODU.Name = "STK_KODU"
        Me.STK_KODU.ReadOnly = True
        '
        'KRS_KAP
        '
        Me.KRS_KAP.DataPropertyName = "Kürsör Kaplama"
        Me.KRS_KAP.HeaderText = "Kürsör Kaplama"
        Me.KRS_KAP.Name = "KRS_KAP"
        Me.KRS_KAP.ReadOnly = True
        '
        'MUS_URUN_KODU
        '
        Me.MUS_URUN_KODU.DataPropertyName = "MUS_URUN_KODU"
        Me.MUS_URUN_KODU.HeaderText = "MUS_URUN_KODU"
        Me.MUS_URUN_KODU.Name = "MUS_URUN_KODU"
        Me.MUS_URUN_KODU.ReadOnly = True
        '
        'TED_1
        '
        Me.TED_1.DataPropertyName = "TED_1"
        Me.TED_1.HeaderText = "TED_1"
        Me.TED_1.Name = "TED_1"
        Me.TED_1.ReadOnly = True
        '
        'TED_2
        '
        Me.TED_2.DataPropertyName = "TED_2"
        Me.TED_2.HeaderText = "TED_2"
        Me.TED_2.Name = "TED_2"
        Me.TED_2.ReadOnly = True
        '
        'SIP_ADEDI
        '
        Me.SIP_ADEDI.DataPropertyName = "SIP_ADEDI"
        Me.SIP_ADEDI.HeaderText = "SIP_ADEDI"
        Me.SIP_ADEDI.Name = "SIP_ADEDI"
        Me.SIP_ADEDI.ReadOnly = True
        '
        'SEV_TAR
        '
        Me.SEV_TAR.DataPropertyName = "SEV_TAR"
        Me.SEV_TAR.HeaderText = "SEV_TAR"
        Me.SEV_TAR.Name = "SEV_TAR"
        Me.SEV_TAR.ReadOnly = True
        '
        'BrGr
        '
        Me.BrGr.HeaderText = "Birim Ağırlık (gr)"
        Me.BrGr.Name = "BrGr"
        '
        'ToplamKg
        '
        Me.ToplamKg.HeaderText = "Toplam Ağırlık (Kg)"
        Me.ToplamKg.Name = "ToplamKg"
        '
        'Grup
        '
        Me.Grup.DataPropertyName = "Grup"
        Me.Grup.HeaderText = "Grup"
        Me.Grup.Name = "Grup"
        Me.Grup.ReadOnly = True
        '
        'SIPARISBindingSource
        '
        Me.SIPARISBindingSource.DataMember = "SIPARIS"
        Me.SIPARISBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.EnforceConstraints = False
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MustSıpNo, Me.MustUrunKod, Me.KurKapl, Me.ted1, Me.ted2, Me.Adet, Me.Kg, Me.KoliNo, Me.BirimGr})
        Me.DataGridView2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(999, 185)
        Me.DataGridView2.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListedenKaldırToolStripMenuItem, Me.TemizleToolStripMenuItem, Me.ToolStripMenuItem2, Me.BölToolStripMenuItem, Me.KoliNoToolStripMenuItem, Me.ToolStripMenuItem3, Me.ExceleVerToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(171, 148)
        '
        'ListedenKaldırToolStripMenuItem
        '
        Me.ListedenKaldırToolStripMenuItem.Name = "ListedenKaldırToolStripMenuItem"
        Me.ListedenKaldırToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ListedenKaldırToolStripMenuItem.Text = "Listeden kaldır"
        '
        'TemizleToolStripMenuItem
        '
        Me.TemizleToolStripMenuItem.Name = "TemizleToolStripMenuItem"
        Me.TemizleToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.TemizleToolStripMenuItem.Text = "Temizle"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(167, 6)
        '
        'KoliNoToolStripMenuItem
        '
        Me.KoliNoToolStripMenuItem.Name = "KoliNoToolStripMenuItem"
        Me.KoliNoToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.KoliNoToolStripMenuItem.Text = "Koli Numaralandır"
        '
        'ExceleVerToolStripMenuItem1
        '
        Me.ExceleVerToolStripMenuItem1.Name = "ExceleVerToolStripMenuItem1"
        Me.ExceleVerToolStripMenuItem1.Size = New System.Drawing.Size(170, 22)
        Me.ExceleVerToolStripMenuItem1.Text = "Excel'e ver"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(902, 36)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 45)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Seçilenleri Listeye Ekle"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FIRMABindingSource
        '
        Me.FIRMABindingSource.DataMember = "FIRMA"
        Me.FIRMABindingSource.DataSource = Me.DataSet1
        '
        'FIRMATableAdapter
        '
        Me.FIRMATableAdapter.ClearBeforeFill = True
        '
        'SIPARISTableAdapter
        '
        Me.SIPARISTableAdapter.ClearBeforeFill = True
        '
        'MustSıpNo
        '
        Me.MustSıpNo.HeaderText = "Müşteri Sip.No"
        Me.MustSıpNo.Name = "MustSıpNo"
        '
        'MustUrunKod
        '
        Me.MustUrunKod.HeaderText = "Müşteri Ürün Kodu"
        Me.MustUrunKod.Name = "MustUrunKod"
        '
        'KurKapl
        '
        Me.KurKapl.HeaderText = "Kürsör Kaplama"
        Me.KurKapl.Name = "KurKapl"
        '
        'ted1
        '
        Me.ted1.HeaderText = "Ted_1"
        Me.ted1.Name = "ted1"
        '
        'ted2
        '
        Me.ted2.HeaderText = "Ted_2"
        Me.ted2.Name = "ted2"
        '
        'Adet
        '
        Me.Adet.HeaderText = "Adet"
        Me.Adet.Name = "Adet"
        '
        'Kg
        '
        Me.Kg.HeaderText = "Kg"
        Me.Kg.Name = "Kg"
        '
        'KoliNo
        '
        Me.KoliNo.HeaderText = "Koli No"
        Me.KoliNo.Name = "KoliNo"
        '
        'BirimGr
        '
        Me.BirimGr.HeaderText = "BirimGr"
        Me.BirimGr.Name = "BirimGr"
        Me.BirimGr.Visible = False
        '
        'BölToolStripMenuItem
        '
        Me.BölToolStripMenuItem.Name = "BölToolStripMenuItem"
        Me.BölToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BölToolStripMenuItem.Text = "Böl"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(167, 6)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Button_GrHesap)
        Me.Controls.Add(Me.TextBox_Firma)
        Me.Controls.Add(Me.CheckBox_Firma)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Sipariş Listesi"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SIPARISBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.FIRMABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FIRMABindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet1 As Sipariş_Liste.DataSet1
    Friend WithEvents FIRMATableAdapter As Sipariş_Liste.DataSet1TableAdapters.FIRMATableAdapter
    Friend WithEvents SIPARISBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SIPARISTableAdapter As Sipariş_Liste.DataSet1TableAdapters.SIPARISTableAdapter
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Firma As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_Firma As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DosyaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoyutSisKullanıcıToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExceleVerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KapatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button_GrHesap As Button
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ListedenKaldırToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Secim As DataGridViewCheckBoxColumn
    Friend WithEvents FIRMA_KODU As DataGridViewTextBoxColumn
    Friend WithEvents SIP_NO As DataGridViewTextBoxColumn
    Friend WithEvents MUS_SIP_NO As DataGridViewTextBoxColumn
    Friend WithEvents STK_KODU As DataGridViewTextBoxColumn
    Friend WithEvents KRS_KAP As DataGridViewTextBoxColumn
    Friend WithEvents MUS_URUN_KODU As DataGridViewTextBoxColumn
    Friend WithEvents TED_1 As DataGridViewTextBoxColumn
    Friend WithEvents TED_2 As DataGridViewTextBoxColumn
    Friend WithEvents SIP_ADEDI As DataGridViewTextBoxColumn
    Friend WithEvents SEV_TAR As DataGridViewTextBoxColumn
    Friend WithEvents BrGr As DataGridViewTextBoxColumn
    Friend WithEvents ToplamKg As DataGridViewTextBoxColumn
    Friend WithEvents Grup As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents KoliNoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TemizleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExceleVerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MustSıpNo As DataGridViewTextBoxColumn
    Friend WithEvents MustUrunKod As DataGridViewTextBoxColumn
    Friend WithEvents KurKapl As DataGridViewTextBoxColumn
    Friend WithEvents ted1 As DataGridViewTextBoxColumn
    Friend WithEvents ted2 As DataGridViewTextBoxColumn
    Friend WithEvents Adet As DataGridViewTextBoxColumn
    Friend WithEvents Kg As DataGridViewTextBoxColumn
    Friend WithEvents KoliNo As DataGridViewTextBoxColumn
    Friend WithEvents BirimGr As DataGridViewTextBoxColumn
    Friend WithEvents BölToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
End Class
