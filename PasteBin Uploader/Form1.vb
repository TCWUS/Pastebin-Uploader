﻿Imports System.IO
Imports System.Net
Imports System.Collections
Public Class Form1

    Dim wclient As New System.Net.WebClient

    Public Sub OpenFile()
        Dim oReader As StreamReader
        Dim dialog As New OpenFileDialog()
        dialog.CheckFileExists = True
        dialog.CheckPathExists = True
        dialog.DefaultExt = "txt"
        dialog.FileName = ""
        dialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        dialog.Multiselect = False

        If dialog.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtPath.Text = dialog.FileName
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbEXP.SelectedItem = "Choose Expire Date"
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFile()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim expire As String
        If cmbEXP.SelectedItem = "Never" Then
            expire = "N"
        ElseIf cmbEXP.SelectedItem = "10 Minutes" Then
            expire = "10M"
        ElseIf cmbEXP.SelectedItem = "1 Hour" Then
            expire = "1H"
        ElseIf cmbEXP.SelectedItem = "1 Day" Then
            expire = "1D"
        ElseIf cmbEXP.SelectedItem = "1 Week" Then
            expire = "1W"
        ElseIf cmbEXP.SelectedItem = "2 Weeks" Then
            expire = "2W"
        ElseIf cmbEXP.SelectedItem = "1 Month" Then
            expire = "1M"
        Else
            MessageBox.Show("Invalid expire date", "Pastebin Uploader", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Try
            Dim filepath As String = txtPath.Text
            Dim sr As New StreamReader(filepath)
            Dim content As String = sr.ReadToEnd()
            Dim data As New System.Collections.Specialized.NameValueCollection()
            data("api_paste_name") = txtName.Text
            data("api_paste_expire_date") = expire
            data("api_paste_code") = content
            data("api_dev_key") = "DEV KEY"
            data("api_option") = "paste"
            Dim bytes As Byte() = wclient.UploadValues("https://pastebin.com/api/api_post.php", data)
            Dim response As String
            Using ms As New MemoryStream(bytes)
                Using reader As New StreamReader(ms)
                    response = reader.ReadToEnd()
                End Using
            End Using
            If response.StartsWith("Bad API Request") Then
                MessageBox.Show("Error uploading", "Pastebin Uploader", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                txtUrl.Text = response
                Clipboard.Clear()
                Clipboard.SetText(response)
                MessageBox.Show("Successfuly Uploaded, the link has been copied to clipboard", "Pastebin Uploader", MessageBoxButtons.OK, MessageBoxIcon.Information)


            End If
        Catch ex As Exception
            MessageBox.Show("Error", "Pastebin Uploader", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class
