<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Obat
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
        btnKembali = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtnamaobat = New TextBox()
        txtindikasi = New TextBox()
        txtkuantitas = New TextBox()
        txtharga = New TextBox()
        btnSimpanDokter = New Button()
        viewObat = New DataGridView()
        txtfilterobat = New TextBox()
        btnEdit = New Button()
        btnHapus = New Button()
        Label5 = New Label()
        idObat = New TextBox()
        btnReset = New Button()
        exportObat = New Button()
        CType(viewObat, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = SystemColors.ButtonFace
        btnKembali.Location = New Point(22, 25)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 29)
        btnKembali.TabIndex = 1
        btnKembali.Text = "<< Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 3
        Label1.Text = "Nama Obat"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 4
        Label2.Text = "Indikasi"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 5
        Label3.Text = "Kuantitas"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(50, 20)
        Label4.TabIndex = 6
        Label4.Text = "Harga"' 
        ' txtnamaobat
        ' 
        txtnamaobat.Location = New Point(163, 85)
        txtnamaobat.Name = "txtnamaobat"
        txtnamaobat.Size = New Size(208, 27)
        txtnamaobat.TabIndex = 9
        ' 
        ' txtindikasi
        ' 
        txtindikasi.Location = New Point(163, 135)
        txtindikasi.Name = "txtindikasi"
        txtindikasi.Size = New Size(208, 27)
        txtindikasi.TabIndex = 10
        ' 
        ' txtkuantitas
        ' 
        txtkuantitas.Location = New Point(163, 192)
        txtkuantitas.Name = "txtkuantitas"
        txtkuantitas.Size = New Size(208, 27)
        txtkuantitas.TabIndex = 11
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(163, 246)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(208, 27)
        txtharga.TabIndex = 12
        ' 
        ' btnSimpanDokter
        ' 
        btnSimpanDokter.BackColor = Color.White
        btnSimpanDokter.Location = New Point(251, 301)
        btnSimpanDokter.Name = "btnSimpanDokter"
        btnSimpanDokter.Size = New Size(120, 29)
        btnSimpanDokter.TabIndex = 25
        btnSimpanDokter.Text = "Simpan"
        btnSimpanDokter.UseVisualStyleBackColor = False
        ' 
        ' viewObat
        ' 
        viewObat.BackgroundColor = SystemColors.HighlightText
        viewObat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        viewObat.Location = New Point(402, 85)
        viewObat.Name = "viewObat"
        viewObat.RowHeadersWidth = 51
        viewObat.RowTemplate.Height = 29
        viewObat.Size = New Size(372, 282)
        viewObat.TabIndex = 26
        ' 
        ' txtfilterobat
        ' 
        txtfilterobat.Location = New Point(402, 391)
        txtfilterobat.Name = "txtfilterobat"
        txtfilterobat.PlaceholderText = "Filter Obat"
        txtfilterobat.Size = New Size(190, 27)
        txtfilterobat.TabIndex = 27
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ButtonFace
        btnEdit.Location = New Point(604, 389)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(82, 29)
        btnEdit.TabIndex = 28
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.ButtonFace
        btnHapus.Location = New Point(692, 389)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(82, 29)
        btnHapus.TabIndex = 29
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(493, 27)
        Label5.Name = "Label5"
        Label5.Size = New Size(193, 31)
        Label5.TabIndex = 30
        Label5.Text = "Tabel Daftar Obat"' 
        ' idObat
        ' 
        idObat.Location = New Point(163, 27)
        idObat.Name = "idObat"
        idObat.PlaceholderText = "Cari ID untuk edit"
        idObat.Size = New Size(208, 27)
        idObat.TabIndex = 37
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ButtonFace
        btnReset.Location = New Point(163, 301)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(82, 29)
        btnReset.TabIndex = 38
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' exportObat
        ' 
        exportObat.BackColor = Color.White
        exportObat.Location = New Point(22, 301)
        exportObat.Name = "exportObat"
        exportObat.Size = New Size(112, 29)
        exportObat.TabIndex = 39
        exportObat.Text = "Export"
        exportObat.UseVisualStyleBackColor = False
        ' 
        ' Form_Data_Obat
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumTurquoise
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(exportObat)
        Controls.Add(btnReset)
        Controls.Add(idObat)
        Controls.Add(Label5)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(txtfilterobat)
        Controls.Add(viewObat)
        Controls.Add(btnSimpanDokter)
        Controls.Add(txtharga)
        Controls.Add(txtkuantitas)
        Controls.Add(txtindikasi)
        Controls.Add(txtnamaobat)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnKembali)
        Name = "Form_Data_Obat"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Obat"
        CType(viewObat, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnamaobat As TextBox
    Friend WithEvents txtindikasi As TextBox
    Friend WithEvents txtkuantitas As TextBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents btnSimpanDokter As Button
    Friend WithEvents viewObat As DataGridView
    Friend WithEvents txtfilterobat As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents idObat As TextBox
    Friend WithEvents btnReset As Button
    Public WithEvents exportObat As Button
End Class
