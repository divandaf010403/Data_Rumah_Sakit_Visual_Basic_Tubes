Imports ClosedXML.Excel
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form_Data_Pasien
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim myDb As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mainMenu = New Form_Menu_Utama()
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Data_Pasien_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub Koneksi()
        myDb = "server=localhost;userid=root;password='';database=hospital;Convert Zero Datetime=True"
        conn = New MySqlConnection(myDb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub KondisiAwal()
        idPasien.Text = ""
        txtnamapasien.Text = ""
        txtnikpasien.Text = ""
        tglLahir.Format = DateTimePickerFormat.Custom
        txttmptpasien.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtpekerjaan.Text = ""

        Call Koneksi()
        da = New MySqlDataAdapter("Select * From patients", conn)
        ds = New DataSet
        da.Fill(ds, "patiens")
        viewPasien.DataSource = ds.Tables("patiens")
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        Dim s As String = ""
        If RadioButton1.Checked = True Then
            s = "M"
        ElseIf RadioButton2.Checked = True Then
            s = "F"
        End If

        If txtnamapasien.Text = "" Or txtnikpasien.Text = "" Or tglLahir.Text = "" Or txttmptpasien.Text = "" Or (RadioButton1.Checked = False And RadioButton2.Checked = False) Or txtpekerjaan.Text = "" Then
            MsgBox("Pastikan semua data terisi")
        ElseIf (idPasien.Text = "") Then
            Call Koneksi()
            Dim inputData As String = "INSERT INTO patients (fullname, nik_pasien, birth_date, birth_place, sex, occupation, entry_date) VALUES (@fullname, @nik_pasien, @birth_date, @birth_place, @sex, @occupation, @entry_date);"

            ' Create a new SqlCommand object
            cmd = New MySqlCommand(inputData, conn)
            ' Set parameter values for the INSERT statement
            cmd.Parameters.AddWithValue("@fullname", txtnamapasien.Text) ' Replace with the actual full name
            cmd.Parameters.AddWithValue("@nik_pasien", txtnikpasien.Text) ' Replace with the actual full nik
            cmd.Parameters.AddWithValue("@birth_date", tglLahir.Value) ' Replace with the actual birth date
            cmd.Parameters.AddWithValue("@birth_place", txttmptpasien.Text) ' Replace with the actual birth place
            cmd.Parameters.AddWithValue("@sex", s) ' Replace with the actual sex
            cmd.Parameters.AddWithValue("@occupation", txtpekerjaan.Text) ' Replace with the actual occupation
            cmd.Parameters.AddWithValue("@entry_date", DateTime.Now) ' Replace with the actual entry date

            ' Execute the INSERT statement
            cmd.ExecuteNonQuery()
            Call KondisiAwal()
        Else
            Call Koneksi()
            Dim inputData As String = "UPDATE patients SET fullname = @fullname, nik_pasien = @nik_pasien, birth_date = @birth_date, birth_place = @birth_place, sex = @sex, occupation = @occupation WHERE id = @id_pasien"

            ' Create a new SqlCommand object
            cmd = New MySqlCommand(inputData, conn)
            ' Set parameter values for the INSERT statement
            cmd.Parameters.AddWithValue("@fullname", txtnamapasien.Text) ' Replace with the actual full name
            cmd.Parameters.AddWithValue("@nik_pasien", txtnikpasien.Text) ' Replace with the actual full nik
            cmd.Parameters.AddWithValue("@birth_date", tglLahir.Value) ' Replace with the actual birth date
            cmd.Parameters.AddWithValue("@birth_place", txttmptpasien.Text) ' Replace with the actual birth place
            cmd.Parameters.AddWithValue("@sex", s) ' Replace with the actual sex
            cmd.Parameters.AddWithValue("@occupation", txtpekerjaan.Text) ' Replace with the actual occupation
            cmd.Parameters.AddWithValue("@id_pasien", idPasien.Text) ' ID Dokter

            ' Execute the INSERT statement
            cmd.ExecuteNonQuery()
            Call KondisiAwal()
        End If
    End Sub

    Private Sub txtfilterpasien_TextChanged(sender As Object, e As EventArgs) Handles txtfilterpasien.TextChanged
        If (txtfilterpasien.Text = "") Then
            txtfilterpasien.PlaceholderText = "Cari Nama Pasien"
        Else
            Call Koneksi()
            Dim showData As String = "Select * from patients where fullname like @name"
            cmd = New MySqlCommand(showData, conn)
            cmd.Parameters.AddWithValue("@name", "%" & txtfilterpasien.Text & "%")
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "patiens")
            viewPasien.DataSource = ds.Tables("patiens")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (idPasien.Text = "") Then
            MsgBox("ID Masih Kosong")
        Else
            Call Koneksi()
            Dim showData As String = "Select * from patients where id like @id"
            cmd = New MySqlCommand(showData, conn)
            cmd.Parameters.AddWithValue("@id", idPasien.Text)
            dr = cmd.ExecuteReader()

            If (dr.HasRows = True) Then
                dr.Read()
                txtnamapasien.Text = dr.GetString(dr.GetOrdinal("fullname"))
                txtnikpasien.Text = dr.GetString(dr.GetOrdinal("nik_pasien"))
                tglLahir.Value = dr.GetDateTime(dr.GetOrdinal("birth_date"))
                txttmptpasien.Text = dr.GetString(dr.GetOrdinal("birth_place"))
                If (dr.GetString(dr.GetOrdinal("sex")).Equals("M")) Then
                    RadioButton1.Checked = True
                    RadioButton2.Checked = False
                Else
                    RadioButton1.Checked = False
                    RadioButton2.Checked = True
                End If
                txtpekerjaan.Text = dr.GetString(dr.GetOrdinal("occupation"))
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call KondisiAwal()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If (idPasien.Text = "") Then
            MsgBox("ID Masih Kosong")
        Else
            Call Koneksi()
            cmd = New MySqlCommand("DELETE FROM patients WHERE id = @id_pasien", conn)
            Try
                cmd.Parameters.AddWithValue("@id_pasien", idPasien.Text) ' ID Dokter
                cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil menghapus data", "Berhasil")
                Call KondisiAwal()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data.", "Perhatian")
            End Try
        End If
    End Sub

    Private Sub exportDokter_Click(sender As Object, e As EventArgs) Handles exportPasien.Click
        ' Membuat komponen datatable
        ' Dimulai dari baris di bawah, komponen pada dataGridView1 dipindahkan ke
        ' komponen baru yaitu DataTable pada variabel dt
        Dim dt As New DataTable()

        ' Menambahkan kolom datagridview1 ke datatable
        For Each col As DataGridViewColumn In viewPasien.Columns
            dt.Columns.Add(col.Name)
        Next

        ' Menambahkan baris/record data dari datagridview1 ke datatable
        For Each row As DataGridViewRow In viewPasien.Rows
            Dim dRow As DataRow = dt.NewRow()
            For Each cell As DataGridViewCell In row.Cells
                dRow(cell.ColumnIndex) = cell.Value
            Next
            dt.Rows.Add(dRow)
        Next

        ' Membuat sebuah file excel di memory
        Using wb As New XLWorkbook()
            ' Menambahkan worksheet ke file excel
            wb.Worksheets.Add(dt, "Sheet1")
            Using stream As New MemoryStream()
                wb.SaveAs(stream)

                ' Membuka save file dialog untuk menentukan tempat penyimpanan file
                Dim saveFileDialog As New SaveFileDialog()
                saveFileDialog.Filter = "Excel Files|*.xlsx"
                saveFileDialog.FileName = "Rekap Data Pasien.xlsx"

                ' Melakukan cek apakah user menekan tombol simpan
                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    ' Menyimpan file dengan nama dan lokasi yang dipilih oleh user
                    File.WriteAllBytes(saveFileDialog.FileName, stream.ToArray())
                    MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End Using
        End Using
    End Sub
End Class