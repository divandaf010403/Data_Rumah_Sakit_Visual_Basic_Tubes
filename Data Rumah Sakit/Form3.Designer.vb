<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Dokter
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
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        btnKembali = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtnamadok = New TextBox()
        txtnikdok = New TextBox()
        txttmptdokter = New TextBox()
        txtspesialisasi = New ComboBox()
        viewDokter = New DataGridView()
        txtfilterdok = New TextBox()
        btnEdit = New Button()
        btnHapus = New Button()
        btnSimpanDokter = New Button()
        Label7 = New Label()
        tglLahirDok = New DateTimePicker()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        btnReset = New Button()
        idDokter = New TextBox()
        exportDokter = New Button()
        CType(viewDokter, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnKembali
        ' 
        btnKembali.BackColor = SystemColors.ButtonFace
        btnKembali.Location = New Point(22, 25)
        btnKembali.Name = "btnKembali"
        btnKembali.Size = New Size(112, 29)
        btnKembali.TabIndex = 0
        btnKembali.Text = "<< Kembali"
        btnKembali.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nama Lengkap"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 141)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 3
        Label2.Text = "NIK (No. KTP)"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 193)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tanggal Lahir"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(22, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 5
        Label4.Text = "Tempat Lahir"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 295)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 6
        Label5.Text = "Jenis Kelamin"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 347)
        Label6.Name = "Label6"
        Label6.Size = New Size(84, 20)
        Label6.TabIndex = 7
        Label6.Text = "Spesialisasi"' 
        ' txtnamadok
        ' 
        txtnamadok.Location = New Point(159, 86)
        txtnamadok.Name = "txtnamadok"
        txtnamadok.Size = New Size(208, 27)
        txtnamadok.TabIndex = 8
        ' 
        ' txtnikdok
        ' 
        txtnikdok.Location = New Point(159, 138)
        txtnikdok.MaxLength = 16
        txtnikdok.Name = "txtnikdok"
        txtnikdok.Size = New Size(208, 27)
        txtnikdok.TabIndex = 9
        ' 
        ' txttmptdokter
        ' 
        txttmptdokter.Location = New Point(159, 243)
        txttmptdokter.Name = "txttmptdokter"
        txttmptdokter.Size = New Size(208, 27)
        txttmptdokter.TabIndex = 11
        ' 
        ' txtspesialisasi
        ' 
        txtspesialisasi.FormattingEnabled = True
        txtspesialisasi.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9"})
        txtspesialisasi.Location = New Point(159, 344)
        txtspesialisasi.Name = "txtspesialisasi"
        txtspesialisasi.Size = New Size(208, 28)
        txtspesialisasi.TabIndex = 13
        ' 
        ' viewDokter
        ' 
        viewDokter.AllowDrop = True
        viewDokter.AllowUserToOrderColumns = True
        viewDokter.BackgroundColor = SystemColors.HighlightText
        viewDokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        viewDokter.Location = New Point(403, 86)
        viewDokter.Name = "viewDokter"
        viewDokter.RowHeadersWidth = 51
        viewDokter.RowTemplate.Height = 29
        viewDokter.Size = New Size(405, 286)
        viewDokter.TabIndex = 14
        ' 
        ' txtfilterdok
        ' 
        txtfilterdok.Location = New Point(403, 396)
        txtfilterdok.Name = "txtfilterdok"
        txtfilterdok.PlaceholderText = "Cari Data Dokter"
        txtfilterdok.Size = New Size(229, 27)
        txtfilterdok.TabIndex = 21
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ButtonFace
        btnEdit.Location = New Point(638, 394)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(82, 30)
        btnEdit.TabIndex = 22
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.ButtonFace
        btnHapus.Location = New Point(726, 394)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(82, 30)
        btnHapus.TabIndex = 23
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnSimpanDokter
        ' 
        btnSimpanDokter.BackColor = SystemColors.ButtonFace
        btnSimpanDokter.Location = New Point(247, 394)
        btnSimpanDokter.Name = "btnSimpanDokter"
        btnSimpanDokter.Size = New Size(120, 29)
        btnSimpanDokter.TabIndex = 24
        btnSimpanDokter.Text = "Simpan"
        btnSimpanDokter.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(510, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(210, 31)
        Label7.TabIndex = 31
        Label7.Text = "Tabel Daftar Dokter"' 
        ' tglLahirDok
        ' 
        tglLahirDok.Location = New Point(159, 193)
        tglLahirDok.Name = "tglLahirDok"
        tglLahirDok.Size = New Size(208, 27)
        tglLahirDok.TabIndex = 32
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(263, 293)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(104, 24)
        RadioButton2.TabIndex = 34
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(159, 293)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 33
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki-laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ButtonFace
        btnReset.Location = New Point(159, 395)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(82, 29)
        btnReset.TabIndex = 35
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' idDokter
        ' 
        idDokter.Location = New Point(159, 27)
        idDokter.Name = "idDokter"
        idDokter.PlaceholderText = "Cari ID untuk edit"
        idDokter.Size = New Size(208, 27)
        idDokter.TabIndex = 36
        ' 
        ' exportDokter
        ' 
        exportDokter.BackColor = Color.White
        exportDokter.Location = New Point(22, 394)
        exportDokter.Name = "exportDokter"
        exportDokter.Size = New Size(112, 29)
        exportDokter.TabIndex = 37
        exportDokter.Text = "Export"
        exportDokter.UseVisualStyleBackColor = False
        ' 
        ' Form_Data_Dokter
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumTurquoise
        ClientSize = New Size(834, 474)
        ControlBox = False
        Controls.Add(exportDokter)
        Controls.Add(idDokter)
        Controls.Add(btnReset)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(tglLahirDok)
        Controls.Add(Label7)
        Controls.Add(btnSimpanDokter)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(txtfilterdok)
        Controls.Add(viewDokter)
        Controls.Add(txtspesialisasi)
        Controls.Add(txttmptdokter)
        Controls.Add(txtnikdok)
        Controls.Add(txtnamadok)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnKembali)
        Name = "Form_Data_Dokter"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Data Dokter"
        CType(viewDokter, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnamadok As TextBox
    Friend WithEvents txtnikdok As TextBox
    Friend WithEvents txttmptdokter As TextBox
    Friend WithEvents txtspesialisasi As ComboBox
    Friend WithEvents viewDokter As DataGridView
    Friend WithEvents txtfilterdok As TextBox
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnSimpanDokter As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents tglLahirDok As DateTimePicker
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btnReset As Button
    Friend WithEvents idDokter As TextBox
    Public WithEvents exportDokter As Button
End Class
