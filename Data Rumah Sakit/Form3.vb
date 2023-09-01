Imports System.Data.Common
Imports ClosedXML.Excel
Imports System.IO
Imports DocumentFormat.OpenXml.Drawing.Diagrams
Imports MySql.Data.MySqlClient

Public Class Form_Data_Dokter
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim myDb As String

    Private Sub Form_Data_Dokter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
    End Sub

    Sub Koneksi()
        myDb = "server=localhost;userid=root;password='';database=hospital;Convert Zero Datetime=True"
        conn = New MySqlConnection(myDb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub KondisiAwal()
        txtnamadok.Text = ""
        txtnikdok.Text = ""
        tglLahirDok.Format = DateTimePickerFormat.Custom
        txttmptdokter.Text = ""
        txtspesialisasi.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        txtfilterdok.Text = ""
        idDokter.Text = ""

        Call Koneksi()
        da = New MySqlDataAdapter("Select * From doctors", conn)
        ds = New DataSet
        da.Fill(ds, "doctors")
        viewDokter.DataSource = ds.Tables("doctors")
    End Sub

    Private Sub btnSimpanDokter_Click(sender As Object, e As EventArgs) Handles btnSimpanDokter.Click
        Dim s As String = ""
        If RadioButton1.Checked = True Then
            s = "M"
        ElseIf RadioButton2.Checked = True Then
            s = "F"
        End If

        If txtnamadok.Text = "" Or txtnikdok.Text = "" Or tglLahirDok.Text = "" Or txttmptdokter.Text = "" Or (RadioButton1.Checked = False And RadioButton2.Checked = False) Or txtspesialisasi.Text = "" Then
            MsgBox("Pastikan semua data terisi")
        ElseIf (idDokter.Text = "") Then
            Call Koneksi()
            Dim inputData As String = "INSERT INTO doctors (fullname, nik, birth_date, birth_place, sex, type_id) VALUES (@fullname, @nik, @birth_date, @birth_place, @sex, @type_id);"

            ' Create a new SqlCommand object
            cmd = New MySqlCommand(inputData, conn)
            ' Set parameter values for the INSERT statement
            cmd.Parameters.AddWithValue("@fullname", txtnamadok.Text) ' Replace with the actual full name
            cmd.Parameters.AddWithValue("@nik", txtnikdok.Text) ' Replace with the actual full nik
            cmd.Parameters.AddWithValue("@birth_date", tglLahirDok.Value) ' Replace with the actual birth date
            cmd.Parameters.AddWithValue("@birth_place", txttmptdokter.Text) ' Replace with the actual birth place
            cmd.Parameters.AddWithValue("@sex", s) ' Replace with the actual sex
            cmd.Parameters.AddWithValue("@type_id", txtspesialisasi.Text) ' Replace with the actual occupation

            ' Execute the INSERT statement
            cmd.ExecuteNonQuery()
            Call KondisiAwal()
        Else
            Call Koneksi()
            Dim inputData As String = "UPDATE doctors SET fullname = @fullname, nik = @nik, birth_date = @birth_date, birth_place = @birth_place, sex = @sex, type_id = @type_id WHERE id = @doctor_id;"

            ' Create a new SqlCommand object
            cmd = New MySqlCommand(inputData, conn)
            ' Set parameter values for the INSERT statement
            cmd.Parameters.AddWithValue("@fullname", txtnamadok.Text) ' Replace with the actual full name
            cmd.Parameters.AddWithValue("@nik", txtnikdok.Text) ' Replace with the actual full nik
            cmd.Parameters.AddWithValue("@birth_date", tglLahirDok.Value) ' Replace with the actual birth date
            cmd.Parameters.AddWithValue("@birth_place", txttmptdokter.Text) ' Replace with the actual birth place
            cmd.Parameters.AddWithValue("@sex", s) ' Replace with the actual sex
            cmd.Parameters.AddWithValue("@type_id", txtspesialisasi.Text) ' Replace with the actual occupation
            cmd.Parameters.AddWithValue("@doctor_id", idDokter.Text) ' ID Dokter

            ' Execute the INSERT statement
            cmd.ExecuteNonQuery()
            Call KondisiAwal()
        End If
    End Sub

    Private Sub txtfilterdok_TextChanged(sender As Object, e As EventArgs) Handles txtfilterdok.TextChanged
        If (txtfilterdok.Text = "") Then
            txtfilterdok.PlaceholderText = "Cari Nama Dokter"
        Else
            Call Koneksi()
            Dim showData As String = "Select * from doctors where fullname like @name"
            cmd = New MySqlCommand(showData, conn)
            cmd.Parameters.AddWithValue("@name", "%" & txtfilterdok.Text & "%")
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "doctors")
            viewDokter.DataSource = ds.Tables("doctors")
        End If
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim mainMenu = New Form_Menu_Utama()
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call KondisiAwal()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (idDokter.Text = "") Then
            MsgBox("ID Masih Kosong")
        Else
            Call Koneksi()
            Dim showData As String = "Select * from doctors where id like @id"
            cmd = New MySqlCommand(showData, conn)
            cmd.Parameters.AddWithValue("@id", idDokter.Text)
            dr = cmd.ExecuteReader()

            If (dr.HasRows = True) Then
                dr.Read()
                txtnamadok.Text = dr.GetString(dr.GetOrdinal("fullname"))
                txtnikdok.Text = dr.GetString(dr.GetOrdinal("nik"))
                tglLahirDok.Value = dr.GetDateTime(dr.GetOrdinal("birth_date"))
                txttmptdokter.Text = dr.GetString(dr.GetOrdinal("birth_place"))
                If (dr.GetString(dr.GetOrdinal("sex")).Equals("M")) Then
                    RadioButton1.Checked = True
                    RadioButton2.Checked = False
                Else
                    RadioButton1.Checked = False
                    RadioButton2.Checked = True
                End If
                txtspesialisasi.Text = dr.GetString(dr.GetOrdinal("type_id"))
            End If
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If (idDokter.Text = "") Then
            MsgBox("ID Masih Kosong")
        Else
            Call Koneksi()
            cmd = New MySqlCommand("DELETE FROM doctors WHERE id = @doctor_id", conn)
            Try
                cmd.Parameters.AddWithValue("@doctor_id", idDokter.Text) ' ID Dokter
                cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil menghapus data", "Berhasil")
                Call KondisiAwal()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data. Dokter pernah melakukan pemeriksaan (checkup).", "Perhatian")
            End Try
        End If
    End Sub

    Private Sub exportDokter_Click(sender As Object, e As EventArgs) Handles exportDokter.Click
        ' Membuat komponen datatable
        ' Dimulai dari baris di bawah, komponen pada dataGridView1 dipindahkan ke
        ' komponen baru yaitu DataTable pada variabel dt
        Dim dt As New DataTable()

        ' Menambahkan kolom datagridview1 ke datatable
        For Each col As DataGridViewColumn In viewDokter.Columns
            dt.Columns.Add(col.Name)
        Next

        ' Menambahkan baris/record data dari datagridview1 ke datatable
        For Each row As DataGridViewRow In viewDokter.Rows
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
                saveFileDialog.FileName = "Rekap Data Dokter.xlsx"

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