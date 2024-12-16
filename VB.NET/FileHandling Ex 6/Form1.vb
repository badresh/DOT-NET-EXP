Imports System.IO

Public Class Form1
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Dim filePath As String = txtFilePath.Text
        Try
            If File.Exists(filePath) Then
                txtContent.Text = File.ReadAllText(filePath)
            Else
                MessageBox.Show("File does not exist.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim filePath As String = txtFilePath.Text
        Try
            If File.Exists(filePath) Then
                File.Delete(filePath)
                MessageBox.Show("File deleted successfully.")
            Else
                MessageBox.Show("File does not exist.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        Dim filePath As String = txtFilePath.Text
        Try
            If File.Exists(filePath) Then
                File.WriteAllText(filePath, txtContent.Text)
                MessageBox.Show("File modified successfully.")
            Else
                MessageBox.Show("File does not exist.")
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub SaveFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles SaveFileDialog1.FileOk

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label2.Click

    End Sub
End Class
