Public Class Form1
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Menambahkan pilihan ke ComboBox Fakultas
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("MIPA")
        ComboBox1.Items.Add("HUKUM")
        ComboBox1.Items.Add("FISIP")
        ComboBox1.Items.Add("TEKNIK")
        ComboBox1.Items.Add("FEB")
        ComboBox1.Items.Add("KEDOKTERAN")

        ' Menambahkan pilihan ke ComboBox Jurusan
        ComboBox2.Items.Clear()
        ComboBox2.Items.Add("ILMU KOMPUTER")
        ComboBox2.Items.Add("MANAJEMEN INFORMATIKA")

        ' Mengatur default pilihan kosong
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnprocess.Click
        ' Pastikan semua kontrol ada di form
        If TextBox1 Is Nothing Or TextBox2 Is Nothing Or ComboBox1 Is Nothing Or ComboBox2 Is Nothing Or RadioButton1 Is Nothing Or RadioButton2 Is Nothing Then
            MessageBox.Show("Ada elemen yang belum ditambahkan di desain!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Ambil nilai dari input
        Dim nip As String = TextBox1.Text
        Dim nama As String = TextBox2.Text
        Dim fakultas As String = ComboBox1.Text
        Dim jurusan As String = ComboBox2.Text
        Dim jenisKelamin As String = ""

        ' Cek radio button yang dipilih
        If RadioButton1.Checked Then
            jenisKelamin = "Laki - Laki"
        ElseIf RadioButton2.Checked Then
            jenisKelamin = "Perempuan"
        Else
            MessageBox.Show("Silakan pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Validasi input tidak boleh kosong
        If nip = "" Or nama = "" Or fakultas = "" Or jurusan = "" Then
            MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Tampilkan pesan hasil input
        Dim hasil As String = "NIP : " & nama & vbCrLf &
                              "Hai : " & nip & vbCrLf &
                              "Nama : " & nama & vbCrLf &
                              "Fakultas : " & fakultas & vbCrLf &
                              "Jurusan : " & jurusan & vbCrLf
                              "Jenis Kelamin : " & jenisKelamin

        MessageBox.Show(hasil, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
End Class
