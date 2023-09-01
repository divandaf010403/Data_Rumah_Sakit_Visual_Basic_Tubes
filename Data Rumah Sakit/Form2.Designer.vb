<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Data_Pasien
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
        components = New ComponentModel.Container()
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtnamapasien = New TextBox()
        txtnikpasien = New TextBox()
        txttmptpasien = New TextBox()
        txtpekerjaan = New TextBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        btnSimpan = New Button()
        viewPasien = New DataGridView()
        btnEdit = New Button()
        btnHapus = New Button()
        BindingSource1 = New BindingSource(components)
        txtfilterpasien = New TextBox()
        Label7 = New Label()
        tglLahir = New DateTimePicker()
        idPasien = New TextBox()
        btnReset = New Button()
        exportPasien = New Button()
        CType(viewPasien, ComponentModel.ISupportInitialize).BeginInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonFace
        Button1.Location = New Point(22, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 29)
        Button1.TabIndex = 0
        Button1.Text = "<< Kembali"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(19, 86)
        Label1.Name = "Label1"
        Label1.Size = New Size(109, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama Lengkap"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 135)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 20)
        Label2.TabIndex = 2
        Label2.Text = "NIK (No. KTP)"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(19, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(97, 20)
        Label3.TabIndex = 3
        Label3.Text = "Tanggal Lahir"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(95, 20)
        Label4.TabIndex = 4
        Label4.Text = "Tempat Lahir"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(19, 289)
        Label5.Name = "Label5"
        Label5.Size = New Size(98, 20)
        Label5.TabIndex = 5
        Label5.Text = "Jenis Kelamin"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(19, 334)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 20)
        Label6.TabIndex = 6
        Label6.Text = "Pekerjaan"' 
        ' txtnamapasien
        ' 
        txtnamapasien.Location = New Point(159, 83)
        txtnamapasien.Name = "txtnamapasien"
        txtnamapasien.Size = New Size(208, 27)
        txtnamapasien.TabIndex = 7
        ' 
        ' txtnikpasien
        ' 
        txtnikpasien.Location = New Point(159, 132)
        txtnikpasien.Name = "txtnikpasien"
        txtnikpasien.Size = New Size(208, 27)
        txtnikpasien.TabIndex = 8
        ' 
        ' txttmptpasien
        ' 
        txttmptpasien.Location = New Point(159, 240)
        txttmptpasien.Name = "txttmptpasien"
        txttmptpasien.Size = New Size(208, 27)
        txttmptpasien.TabIndex = 10
        ' 
        ' txtpekerjaan
        ' 
        txtpekerjaan.Location = New Point(159, 331)
        txtpekerjaan.Name = "txtpekerjaan"
        txtpekerjaan.Size = New Size(208, 27)
        txtpekerjaan.TabIndex = 11
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(159, 287)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 12
        RadioButton1.TabStop = True
        RadioButton1.Text = "Laki-laki"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(263, 287)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(104, 24)
        RadioButton2.TabIndex = 13
        RadioButton2.TabStop = True
        RadioButton2.Text = "Perempuan"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = SystemColors.ButtonFace
        btnSimpan.Location = New Point(247, 382)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(120, 29)
        btnSimpan.TabIndex = 16
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' viewPasien
        ' 
        viewPasien.BackgroundColor = SystemColors.HighlightText
        viewPasien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        viewPasien.Location = New Point(420, 83)
        viewPasien.Name = "viewPasien"
        viewPasien.RowHeadersWidth = 51
        viewPasien.RowTemplate.Height = 29
        viewPasien.Size = New Size(400, 288)
        viewPasien.TabIndex = 17
        ' 
        ' btnEdit
        ' 
        btnEdit.BackColor = SystemColors.ButtonFace
        btnEdit.Location = New Point(650, 382)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(82, 29)
        btnEdit.TabIndex = 18
        btnEdit.Text = "Edit"
        btnEdit.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = SystemColors.ButtonFace
        btnHapus.Location = New Point(738, 382)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(82, 29)
        btnHapus.TabIndex = 19
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' txtfilterpasien
        ' 
        txtfilterpasien.Location = New Point(420, 384)
        txtfilterpasien.Name = "txtfilterpasien"
        txtfilterpasien.PlaceholderText = "Cari Nama Pasien"
        txtfilterpasien.Size = New Size(224, 27)
        txtfilterpasien.TabIndex = 20
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(525, 27)
        Label7.Name = "Label7"
        Label7.Size = New Size(207, 31)
        Label7.TabIndex = 32
        Label7.Text = "Tabel Daftar Pasien"' 
        ' tglLahir
        ' 
        tglLahir.Location = New Point(159, 186)
        tglLahir.Name = "tglLahir"
        tglLahir.Size = New Size(208, 27)
        tglLahir.TabIndex = 33
        ' 
        ' idPasien
        ' 
        idPasien.Location = New Point(159, 27)
        idPasien.Name = "idPasien"
        idPasien.PlaceholderText = "Cari ID untuk edit"
        idPasien.Size = New Size(208, 27)
        idPasien.TabIndex = 37
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = SystemColors.ButtonFace
        btnReset.Location = New Point(159, 382)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(82, 29)
        btnReset.TabIndex = 38
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' exportPasien
        ' 
        exportPasien.BackColor = Color.White
        exportPasien.Location = New Point(22, 382)
        exportPasien.Name = "exportPasien"
        exportPasien.Size = New Size(116, 29)
        exportPasien.TabIndex = 39
        exportPasien.Text = "Export"
        exportPasien.UseVisualStyleBackColor = False
        ' 
        ' Form_Data_Pasien
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumTurquoise
        ClientSize = New Size(846, 450)
        ControlBox = False
        Controls.Add(exportPasien)
        Controls.Add(btnReset)
        Controls.Add(idPasien)
        Controls.Add(tglLahir)
        Controls.Add(Label7)
        Controls.Add(txtfilterpasien)
        Controls.Add(btnHapus)
        Controls.Add(btnEdit)
        Controls.Add(viewPasien)
        Controls.Add(btnSimpan)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(txtpekerjaan)
        Controls.Add(txttmptpasien)
        Controls.Add(txtnikpasien)
        Controls.Add(txtnamapasien)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form_Data_Pasien"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Data Pasien"
        CType(viewPasien, ComponentModel.ISupportInitialize).EndInit()
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtnamapasien As TextBox
    Friend WithEvents txtnikpasien As TextBox
    Friend WithEvents txttmptpasien As TextBox
    Friend WithEvents txtpekerjaan As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents btnSimpan As Button
    Friend WithEvents viewPasien As DataGridView
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents txtfilterpasien As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tglLahir As DateTimePicker
    Friend WithEvents idPasien As TextBox
    Friend WithEvents btnReset As Button
    Public WithEvents exportPasien As Button
End Class
