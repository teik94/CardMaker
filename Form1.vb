Imports System.Drawing.Imaging

Public Class Form1

#Region "Global Variable"
    'Private images As New List(Of Image)
    Private saveImages As New List(Of Image)
    Public imageWidth As Integer = 744
    Public imageHeight As Integer = 1039
    Public formWidth As Integer = 2480
    Public formHeight As Integer = 3508
    Public dat As DataTable
    Public max As Integer = 0
    Public previewIndex As Integer = 0
#End Region

#Region "EventHandler"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btnSave.Enabled = False
        btnConvert.Enabled = False
        cbbSizeMode.SelectedIndex = My.Settings.SizeMode
        txtFolderDir.Text = My.Settings.FolderDir
        ImageList.SelectedIndex = 0

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            txtFolderDir.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Reset()
            Dim fullpath As String
            fullpath = txtFolderDir.Text + "\"

            Dim FileDirectory As New IO.DirectoryInfo(fullpath)
            Dim FileJpg As IO.FileInfo() = FileDirectory.GetFiles("*.jpg")
            Dim FilePng As IO.FileInfo() = FileDirectory.GetFiles("*.png")
            Dim FileBmp As IO.FileInfo() = FileDirectory.GetFiles("*.bmp")
            Dim dt As New DataTable
            dt.Columns.Add("Page")
            dt.Columns.Add("Path")
            dt.Columns.Add("File Name")
            dt.Columns.Add("Extension")
            max = Math.Ceiling((FileJpg.Count + FilePng.Count + FileBmp.Count) / 9)

            Dim progressStep As Integer = 100 / (FileJpg.Count + FilePng.Count + FileBmp.Count)
            progressBar.Value = 0

            LoadImage(dt, FileJpg, FilePng, FileBmp, progressStep)
            'LoadImage(dt, FilePng, progressStep)
            'LoadImage(dt, FileBmp, progressStep)

            progressBar.Value = 100

            If dt.Rows.Count > 0 Then
                dat = dt
            End If

            grdImageList.DataSource = dt
            grdImageList.Columns.Item(1).Width = 200
            grdImageList.Columns.Item(2).Width = 200

            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage
            LoadImage()
            SetCount()
            btnConvert.Enabled = True
            btnSave.Enabled = True
            ImageList.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        If dat Is Nothing Or max = 0 Then
            Exit Sub
        End If

        Try
            previewIndex = 1
            LoadAllImage()
            pbPreview.Image = saveImages.FirstOrDefault()
            SetCount()
            ImageList.SelectedIndex = 1
            'MessageBox.Show("Convert Successes!", "Success", MessageBoxButtons.OK)
            btnSave.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Convert Error")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If saveImages.Count > 0 Then
                Dim progressStep As Integer = 100 / saveImages.Count
                progressBar.Value = 0
                Dim n As Integer = 1
                For Each img As Image In saveImages

                    If (Not System.IO.Directory.Exists(txtFolderDir.Text + "\Output\")) Then
                        System.IO.Directory.CreateDirectory(txtFolderDir.Text + "\Output\")
                    End If
                    img.Save(txtFolderDir.Text + "\Output\" + n.ToString + ".jpg", ImageFormat.Jpeg)

                    n = n + 1
                    progressBar.Value = progressBar.Value + progressStep
                Next

                progressBar.Value = 100

            Else
                SaveAll()
            End If

            If MessageBox.Show("Save OK!") = DialogResult.OK Then
                Process.Start("explorer.exe", txtFolderDir.Text + "\Output\")
                Reset()
            End If
            'ConvertImage()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbbSizeMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbSizeMode.SelectedIndexChanged
        My.Settings.SizeMode = cbbSizeMode.SelectedIndex
        If cbbSizeMode.SelectedIndex = 0 Then
            imageWidth = 744
            imageHeight = 1039
        Else
            imageWidth = 697
            imageHeight = 1016
        End If
    End Sub

    Private Sub txtFolderDir_TextChanged(sender As Object, e As EventArgs) Handles txtFolderDir.TextChanged
        My.Settings.FolderDir = txtFolderDir.Text
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If previewIndex = 0 Then
            previewIndex = 1
        End If
        If previewIndex > 1 And previewIndex <= max Then
            previewIndex = previewIndex - 1
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage
            'pbPreview.Image = Nothing
            If saveImages.Count > 0 Then
                pbPreview.Image = saveImages.Item(previewIndex - 1)
            Else
                LoadImage()
            End If

            SetCount()
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If previewIndex = 0 Then
            previewIndex = 1
        End If
        If max > 0 And previewIndex < (max) Then
            previewIndex = previewIndex + 1
            pbPreview.SizeMode = PictureBoxSizeMode.StretchImage
            'pbPreview.Image = Nothing
            'pbPreview.Image = saveImages.Item(previewIndex)
            If saveImages.Count > 0 Then
                pbPreview.Image = saveImages.Item(previewIndex - 1)
            Else
                LoadImage()
            End If
            SetCount()
        End If
    End Sub

#End Region

#Region "Function"
    Private Function GetCardRectangle(ByVal x As Integer, ByVal y As Integer) As Rectangle
        Return New Rectangle(x, y, 744, 1039)
    End Function

    Private Function GetCardRectangle(ByVal index As Integer) As Rectangle

        Dim point As Point
        Dim padding As Integer = 30
        Dim w As Integer = imageWidth + padding
        Dim h As Integer = imageHeight + padding

        Select Case index
            Case 0 To 2
                'point = New Point(w * index + ((formWidth - w * 3) / 2),(formHeight - h * 3) / 2)
                point = New Point(w * index + ((formWidth - (imageWidth * 3 + padding * 2)) / 2),
                                  (formHeight - h * 3) / 2)
            Case 3 To 5
                point = New Point(w * (index - 3) + ((formWidth - (imageWidth * 3 + padding * 2)) / 2),
                                  h * 1 + (formHeight - h * 3) / 2)
            Case 6 To 8
                point = New Point(w * (index - 6) + ((formWidth - (imageWidth * 3 + padding * 2)) / 2),
                                  h * 2 + (formHeight - h * 3) / 2)
            Case Else
                point = New Point(0, 0)
        End Select

        Return New Rectangle(point.X, point.Y, imageWidth, imageHeight)
    End Function

    Public Sub LoadImage(ByRef dt As DataTable, ByVal FileJpg As IO.FileInfo(),
                         ByVal FilePng As IO.FileInfo(),
                         ByVal FileBmp As IO.FileInfo(),
                         ByVal progressStep As Integer)
        Dim n As Integer = dt.Rows.Count
        If n = 0 Then
            n = 1
        End If
        For Each file As IO.FileInfo In FileJpg
            Dim row As DataRow = dt.NewRow
            row("Page") = Math.Ceiling(n / 9)
            row("Path") = file.DirectoryName
            row("File Name") = file.FullName.Replace(file.DirectoryName + "\", "")
            row("Extension") = file.Extension
            dt.Rows.Add(row)
            n = n + 1

            progressBar.Value = progressBar.Value + progressStep
        Next
        For Each file As IO.FileInfo In FilePng
            Dim row As DataRow = dt.NewRow
            row("Page") = Math.Ceiling(n / 9)
            row("Path") = file.DirectoryName
            row("File Name") = file.FullName.Replace(file.DirectoryName + "\", "")
            row("Extension") = file.Extension
            dt.Rows.Add(row)
            n = n + 1

            progressBar.Value = progressBar.Value + progressStep
        Next
        For Each file As IO.FileInfo In FileBmp
            Dim row As DataRow = dt.NewRow
            row("Page") = Math.Ceiling(n / 9)
            row("Path") = file.DirectoryName
            row("File Name") = file.FullName.Replace(file.DirectoryName + "\", "")
            row("Extension") = file.Extension
            dt.Rows.Add(row)
            n = n + 1

            progressBar.Value = progressBar.Value + progressStep
        Next
    End Sub

    Private Sub LoadImage()
        If pbPreview.Image IsNot Nothing Then
            pbPreview.Image.Dispose()
            pbPreview.Image = Nothing
        End If

        If previewIndex = 0 Then
            previewIndex = 1
        End If
        Dim n As Integer = 0
        Dim p As New Bitmap(formWidth, formHeight)
        p.SetResolution(300, 300)
        Dim img As Image = p
        Using graphic As Graphics = Graphics.FromImage(img)
            For Each row As DataRow In dat.Rows
                If Equals(row("Page"), previewIndex.ToString) Then
                    Dim file As String = row("Path").ToString + "\" + row("File Name").ToString
                    Using image As Image = Image.FromFile(file)
                        graphic.DrawImage(image, GetCardRectangle(n))
                        image.Dispose()
                    End Using
                    n = n + 1
                End If
            Next
            pbPreview.Image = img
            graphic.Dispose()
        End Using

    End Sub

    Private Sub LoadAllImage()
        If pbPreview.Image IsNot Nothing Then
            pbPreview.Image.Dispose()
            pbPreview.Image = Nothing
        End If

        Dim progressStep As Integer = 100 / dat.Rows.Count
        progressBar.Value = 0

        Dim count As Integer = 1
        For index = 1 To max
            Dim n As Integer = 0
            Dim p As New Bitmap(formWidth, formHeight)
            p.SetResolution(300, 300)
            Dim img As Image = p
            Using graphic As Graphics = Graphics.FromImage(img)
                graphic.FillRectangle(New SolidBrush(Color.White),
                                      New Rectangle(0, 0, formWidth, formHeight))
                For Each row As DataRow In dat.Rows
                    If Equals(row("Page"), index.ToString) Then
                        Dim file As String = row("Path").ToString + "\" + row("File Name").ToString
                        Using image As Image = Image.FromFile(file)
                            graphic.DrawImage(image, GetCardRectangle(n))
                            image.Dispose()
                        End Using
                        n = n + 1
                        progressBar.Value = progressBar.Value + progressStep
                    End If
                Next
                graphic.Dispose()
            End Using
            count = count + 1
            saveImages.Add(img)
        Next
        progressBar.Value = 100

    End Sub

    Public Sub SaveAll()
        If pbPreview.Image IsNot Nothing Then
            pbPreview.Image.Dispose()
            pbPreview.Image = Nothing
        End If

        Dim progressStep As Integer = 100 / dat.Rows.Count
        progressBar.Value = 0

        For index = 1 To max
            Dim n As Integer = 0
            Dim p As New Bitmap(formWidth, formHeight)
            p.SetResolution(300, 300)
            Dim img As Image = p
            Using graphic As Graphics = Graphics.FromImage(img)
                graphic.FillRectangle(New SolidBrush(Color.White),
                                      New Rectangle(0, 0, formWidth, formHeight))
                For Each row As DataRow In dat.Rows
                    If Equals(row("Page"), index.ToString) Then
                        Dim file As String = row("Path").ToString + "\" + row("File Name").ToString
                        Using image As Image = Image.FromFile(file)
                            graphic.DrawImage(image, GetCardRectangle(n))
                            image.Dispose()
                        End Using
                        n = n + 1
                        progressBar.Value = progressBar.Value + progressStep
                    End If
                Next
                If (Not System.IO.Directory.Exists(txtFolderDir.Text + "\Output\")) Then
                    System.IO.Directory.CreateDirectory(txtFolderDir.Text + "\Output\")
                End If
                img.Save(txtFolderDir.Text + "\Output\" + index.ToString + ".jpg", ImageFormat.Jpeg)
                graphic.Dispose()
            End Using
            'saveImages.Add(img)
        Next
        progressBar.Value = 100
    End Sub

    Private Sub Reset()
        For Each img As Image In saveImages
            img.Dispose()
        Next
        saveImages.Clear()
        grdImageList.DataSource = Nothing
        pbPreview.Image = Nothing
        btnSave.Enabled = False
        btnConvert.Enabled = False
        dat = Nothing
        previewIndex = 0
        SetCount()
    End Sub

    Private Sub SetCount()

        If dat Is Nothing Then
            lbPreviewCount.Text = "0/0"
            Exit Sub
        End If

        If dat IsNot Nothing Or dat.Rows.Count <> 0 Then
            lbPreviewCount.Text = (previewIndex).ToString + "/" + max.ToString
        Else
            lbPreviewCount.Text = "0/0"
        End If

    End Sub
#End Region

End Class
