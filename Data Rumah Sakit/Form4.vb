Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class Form_Data_Obat
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim ds As DataSet
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim myDb As String

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Dim mainMenu = New Form_Menu_Utama()
        mainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Form_Data_Obat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub Koneksi()
        myDb = "server=localhost;userid=root;password='';database=hospital;Convert Zero Datetime=True"
        conn = New MySqlConnection(myDb)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Sub KondisiAwal()
        idObat.Text = ""
        txtnamaobat.Text = ""
        txtindikasi.Text = ""
        txtkuantitas.Text = ""
        txtharga.Text = ""

        Call Koneksi()
        da = New MySqlDataAdapter("Select * From drugs", conn)
        ds = New DataSet
        da.Fill(ds, "drugs")
        viewObat.DataSource = ds.Tables("drugs")
    End Sub

    Private Sub btnSimpanDokter_Click(sender As Object, e As EventArgs) Handles btnSimpanDokter.Click
        If txtnamaobat.Text = "" Or txtindikasi.Text = "" Or txtkuantitas.Text = "" Or txtharga.Text = "" Then
            MsgBox("Pastikan semua data terisi")
        ElseIf (idObat.Text = "") Then
            Call Koneksi()
            Dim inputData As String = "INSERT INTO drugs (name, diagnose, quantity, price) VALUES (@name, @diagnose, @quantity, @price);"

            ' Create a new SqlCommand object
            cmd = New MySqlCommand(inputData, conn)
            ' Set parameter values for the INSERT statement
            cmd.Parameters.AddWithValue("@name", txtnamaobat.Text) ' Replace with the actual full name
            cmd.Parameters.AddWithValue("@diagnose", txtindikasi.Text) ' Replace with the actual full nik
            cmd.Parameters.AddWithValue("@quantity", txtkuantitas.Text) ' Replace with the actual birth place
            cmd.Parameters.AddWithValue("@price", txtharga.Text) ' Replace with the actual occupation

            ' Execute the INSERT statement
            cmd.ExecuteNonQuery()
            Call KondisiAwal()
        Else
            Call Koneksi()
            Dim inputData As String = "UPDATE drugs SET name = @name, diagnose = @diagnose, quantity = @quantity, price = @price WHERE id = @id"

            ' Create a new SqlCommand object
            cmd = New MySqlCommand(inputData, conn)
            ' Set parameter values for the INSERT statement
            cmd.Parameters.AddWithValue("@name", txtnamaobat.Text) ' Replace with the actual full name
            cmd.Parameters.AddWithValue("@diagnose", txtindikasi.Text) ' Replace with the actual full nik
            cmd.Parameters.AddWithValue("@quantity", txtkuantitas.Text) ' Replace with the actual birth place
            cmd.Parameters.AddWithValue("@price", txtharga.Text) ' Replace with the actual occupation
            cmd.Parameters.AddWithValue("@id", idObat.Text) ' Replace with the ID of the drug you want to update

            ' Execute the INSERT statement
            cmd.ExecuteNonQuery()
            Call KondisiAwal()
        End If
    End Sub

    Private Sub txtfilterobat_TextChanged(sender As Object, e As EventArgs) Handles txtfilterobat.TextChanged
        If (txtfilterobat.Text = "") Then
            Call KondisiAwal()
            txtfilterobat.PlaceholderText = "Cari Nama Pasien"
        Else
            Call Koneksi()
            Dim showData As String = "Select * from drugs where name like @name"
            cmd = New MySqlCommand(showData, conn)
            cmd.Parameters.AddWithValue("@name", "%" & txtfilterobat.Text & "%")
            da = New MySqlDataAdapter(cmd)
            ds = New DataSet
            da.Fill(ds, "drugs")
            viewObat.DataSource = ds.Tables("drugs")
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If (idObat.Text = "") Then
            MsgBox("ID Masih Kosong")
        Else
            Call Koneksi()
            Dim showData As String = "Select * from drugs where id like @id"
            cmd = New MySqlCommand(showData, conn)
            cmd.Parameters.AddWithValue("@id", idObat.Text)
            dr = cmd.ExecuteReader()

            If (dr.HasRows = True) Then
                dr.Read()
                txtnamaobat.Text = dr.GetString(dr.GetOrdinal("name"))
                txtindikasi.Text = dr.GetString(dr.GetOrdinal("diagnose"))
                txtkuantitas.Text = dr.GetString(dr.GetOrdinal("quantity"))
                txtharga.Text = dr.GetString(dr.GetOrdinal("price"))
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call KondisiAwal()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If (idObat.Text = "") Then
            MsgBox("ID Masih Kosong")
        Else
            Call Koneksi()
            cmd = New MySqlCommand("DELETE FROM drugs WHERE id = @id", conn)
            Try
                cmd.Parameters.AddWithValue("@id", idObat.Text) ' ID Dokter
                cmd.ExecuteNonQuery()
                MessageBox.Show("Berhasil menghapus data", "Berhasil")
                Call KondisiAwal()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus data.", "Perhatian")
            End Try
        End If
    End Sub

    Private Sub exportObat_Click(sender As Object, e As EventArgs) Handles exportObat.Click
        ' Membuat komponen datatable
        ' Dimulai dari baris di bawah, komponen pada dataGridView1 dipindahkan ke
        ' komponen baru yaitu DataTable pada variabel dt
        Dim dt As New DataTable()

        ' Menambahkan kolom datagridview1 ke datatable
        For Each col As DataGridViewColumn In viewObat.Columns
            dt.Columns.Add(col.Name)
        Next

        ' Menambahkan baris/record data dari datagridview1 ke datatable
        For Each row As DataGridViewRow In viewObat.Rows
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
                saveFileDialog.FileName = "Rekap Data Obat.xlsx"

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