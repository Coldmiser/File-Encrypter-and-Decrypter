Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography
Imports System.Runtime.InteropServices
Imports System.Text

Public Class Main
    Private Sub ButEncrypt_Click(sender As Object, e As EventArgs) Handles ButEncrypt.Click
        If Not TxtEncrypt.Text = "" Then
            Dim sSecretKey As String

            sSecretKey = Generatekey()

            Dim gch As GCHandle = GCHandle.Alloc(sSecretKey, GCHandleType.Pinned)

            EncryptFile(TxtEncrypt.Text,
                        TxtEncrypt.Text + "_encrypted",
                        sSecretKey)

            Key.Show()
            Key.txtKey.Text = sSecretKey

            '            MessageBox.Show("Completed!  " + sSecretKey, "Encryption", MessageBoxButtons.OK)


            ZeroMemory(gch.AddrOfPinnedObject(), sSecretKey.Length * 2)
            gch.Free()
        End If
    End Sub

    Public Sub ZeroMemory(ByVal addr As IntPtr, ByVal size As Integer)
    End Sub

    Function Generatekey() As String
        Dim desCrypto As DESCryptoServiceProvider = DESCryptoServiceProvider.Create()
        Return Encoding.ASCII.GetString(desCrypto.Key)
    End Function

    Sub EncryptFile(ByVal sInputFileName As String,
                    ByVal sOutputFileName As String,
                    ByVal sKey As String)
        Dim fsInput As New FileStream(sInputFileName,
                                      FileMode.Open, FileAccess.Read)
        Dim fsEncrypted As New FileStream(sOutputFileName,
                                          FileMode.Create, FileAccess.Write)

        Dim DES As New DESCryptoServiceProvider()
        DES.Key = Encoding.ASCII.GetBytes(sKey)
        DES.IV = Encoding.ASCII.GetBytes(sKey)

        Dim desencrypt As ICryptoTransform = DES.CreateEncryptor()

        Dim cryptostream As New CryptoStream(fsEncrypted,
                                           desencrypt,
                                           CryptoStreamMode.Write)

        Dim bytearrayinput(fsInput.Length - 1) As Byte
        fsInput.Read(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Write(bytearrayinput, 0, bytearrayinput.Length)
        cryptostream.Close()
    End Sub
    Sub DecryptFile(ByVal sInputFilename As String,
                ByVal sOutputFilename As String,
                ByVal sKey As String)

        Dim DES As New DESCryptoServiceProvider()
        DES.Key() = Encoding.ASCII.GetBytes(sKey)
        DES.IV = Encoding.ASCII.GetBytes(sKey)

        Dim fsread As New FileStream(sInputFilename, FileMode.Open, FileAccess.Read)

        Dim desdecrypt As ICryptoTransform = DES.CreateDecryptor()
        Dim cryptostreamDecr As New CryptoStream(fsread, desdecrypt, CryptoStreamMode.Read)
        Dim fsDecrypted As New StreamWriter(sOutputFilename)
        fsDecrypted.Write(New StreamReader(cryptostreamDecr).ReadToEnd)
        fsDecrypted.Flush()
        fsDecrypted.Close()
    End Sub

    Private Sub ButBrowseEnc_Click(sender As Object, e As EventArgs) Handles ButBrowseEnc.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TxtEncrypt.Text = OpenFileDialog.FileName.ToString
        End If
    End Sub

    Private Sub OpenFileDialog_FileOk(sender As Object, e As ComponentModel.CancelEventArgs) Handles OpenFileDialog.FileOk

    End Sub

    Private Sub ButDecrypt_Click(sender As Object, e As EventArgs) Handles ButDecrypt.Click
        If Not TxtDecrypt.Text = "" Then
            If Not TxtKey.Text = "" Then
                DecryptFile(TxtDecrypt.Text,
                            TxtDecrypt.Text + ".decrypted",
                            TxtKey.Text)
                MessageBox.Show("Completed!", "Decryption", MessageBoxButtons.OK)
                Application.Exit()
                End
            Else
                TxtKey.Text = "Please Insert your key!"
            End If
        Else
            TxtDecrypt.Text = "Please select your file!"
        End If
    End Sub

    Private Sub ButBrowseDec_Click(sender As Object, e As EventArgs) Handles ButBrowseDec.Click
        If OpenFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            TxtDecrypt.Text = OpenFileDialog.FileName.ToString
        End If
    End Sub
End Class
