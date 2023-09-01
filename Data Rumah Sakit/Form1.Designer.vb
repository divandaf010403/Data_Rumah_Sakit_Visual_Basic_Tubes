<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Menu_Utama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        btnPasien = New Button()
        GroupBox1 = New GroupBox()
        btnX = New Button()
        btnObat = New Button()
        btnDokter = New Button()
        GroupBox2 = New GroupBox()
        btnCheckUp = New Button()
        Button4 = New Button()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(12, 421)
        Label1.Name = "Label1"
        Label1.Size = New Size(492, 20)
        Label1.TabIndex = 0
        Label1.Text = "Dikembangkan Oleh: D3 Teknik Informatika - Politeknik Negeri Semarang"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(26, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 1
        ' 
        ' btnPasien
        ' 
        btnPasien.BackColor = Color.White
        btnPasien.Location = New Point(24, 81)
        btnPasien.Name = "btnPasien"
        btnPasien.Size = New Size(94, 29)
        btnPasien.TabIndex = 2
        btnPasien.Text = "Data Pasien"
        btnPasien.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.PaleGreen
        GroupBox1.Controls.Add(btnX)
        GroupBox1.Controls.Add(btnObat)
        GroupBox1.Controls.Add(btnDokter)
        GroupBox1.Controls.Add(btnPasien)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(505, 190)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Master Data"' 
        ' btnX
        ' 
        btnX.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnX.Location = New Point(469, 0)
        btnX.Name = "btnX"
        btnX.Size = New Size(36, 29)
        btnX.TabIndex = 5
        btnX.Text = "X"
        btnX.UseVisualStyleBackColor = False
        ' 
        ' btnObat
        ' 
        btnObat.BackColor = Color.White
        btnObat.Location = New Point(300, 81)
        btnObat.Name = "btnObat"
        btnObat.Size = New Size(94, 29)
        btnObat.TabIndex = 4
        btnObat.Text = "Data Obat"
        btnObat.UseVisualStyleBackColor = False
        ' 
        ' btnDokter
        ' 
        btnDokter.BackColor = Color.White
        btnDokter.Location = New Point(153, 81)
        btnDokter.Name = "btnDokter"
        btnDokter.Size = New Size(110, 29)
        btnDokter.TabIndex = 3
        btnDokter.Text = "Data Dokter"
        btnDokter.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.PaleGreen
        GroupBox2.Controls.Add(btnCheckUp)
        GroupBox2.Controls.Add(Button4)
        GroupBox2.Location = New Point(12, 219)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(505, 190)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        GroupBox2.Text = "Data Pemeriksaan/Check Up"' 
        ' btnCheckUp
        ' 
        btnCheckUp.BackColor = Color.White
        btnCheckUp.Location = New Point(24, 78)
        btnCheckUp.Name = "btnCheckUp"
        btnCheckUp.Size = New Size(117, 29)
        btnCheckUp.TabIndex = 5
        btnCheckUp.Text = "Data CheckUp"
        btnCheckUp.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(24, 92)
        Button4.Name = "Button4"
        Button4.Size = New Size(0, 0)
        Button4.TabIndex = 5
        Button4.Text = "Button4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form_Menu_Utama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(529, 450)
        ControlBox = False
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form_Menu_Utama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Rumah Sakit Mitra Sehat"
        GroupBox1.ResumeLayout(False)
        GroupBox2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPasien As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnObat As Button
    Friend WithEvents btnDokter As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnX As Button
    Friend WithEvents btnCheckUp As Button
End Class
