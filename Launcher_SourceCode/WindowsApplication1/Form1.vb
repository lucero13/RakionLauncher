Imports System.Security.Cryptography
Imports System.IO
Imports System.Text

Public Class Form1

    Private Sub Button_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Login.Click

        Dim TitleWindows As String = "Rakion Thailand"
        If UserID.Text = "" Then
            MessageBox.Show("กรุณาใส่ ID", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If Password.Text = "" Then
            MessageBox.Show("กรุณาใส่ Password", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'Dim CheckFile1 As String
        'Dim CheckFile2 As String
        'Dim CheckFile3 As String
        'CheckFile1 = "bin\config.xfs"
        'CheckFile2 = "bin\load.bin"
        'CheckFile3 = "bin\rakion.bin"
        'If Len(Dir(CheckFile1)) = 0 Then
        '    MessageBox.Show("ไฟล์เกม Rakion Thailand ได้รับความเสียหาย กรุณาติดตั้งใหม่อีกครั้ง (Code : CF1)", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If
        'If Len(Dir(CheckFile2)) = 0 Then
        '    MessageBox.Show("ไฟล์เกม Rakion Thailand ได้รับความเสียหาย กรุณาติดตั้งใหม่อีกครั้ง (Code : CF2)", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If
        'If Len(Dir(CheckFile3)) = 0 Then
        '    MessageBox.Show("ไฟล์เกม Rakion Thailand ได้รับความเสียหาย กรุณาติดตั้งใหม่อีกครั้ง (Code : CF3)", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If

        ''Copy File for Check
        ''My.Computer.FileSystem.CopyFile("bin\rakion.bin", "bin\rakion.exe", Microsoft.VisualBasic.FileIO.UIOption.AllDialogs, Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        ''Sleep(2000)
        'Dim File1 As String = "bin\config.xfs"
        'Dim File1Hash As String = GetMD5(File1)
        'Dim File2 As String = "bin\load.bin"
        'Dim File2Hash As String = GetMD5(File2)
        'Dim File3 As String = "bin\rakion.bin"
        'Dim File3Hash As String = GetMD5(File3)

        'If File1Hash <> "0E22E5580613E888C4F9037EA2519709" Then
        '    'MessageBox.Show("Config.xfs Fail", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    MessageBox.Show("ไฟล์เกม Rakion Thailand ได้รับความเสียหาย กรุณาติดตั้งใหม่อีกครั้ง (Code : FH1)", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If
        'If File2Hash <> "EA0C6E6315F886AF2D725EDD0E681E6B" Then
        '    'MessageBox.Show("load.bin Fail", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    MessageBox.Show("ไฟล์เกม Rakion Thailand ได้รับความเสียหาย กรุณาติดตั้งใหม่อีกครั้ง (Code : FH2)", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If
        'If File3Hash <> "33BFF39B2CD6D41F409A2325DA1EEBD5" Then
        '    'MessageBox.Show("rakion.bin Fail", "Title", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    MessageBox.Show("ไฟล์เกม Rakion Thailand ได้รับความเสียหาย กรุณาติดตั้งใหม่อีกครั้ง (Code : FH3)", "" + TitleWindows + "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        '    Return
        'End If

        Dim number As Integer = Len(Password.Text)
        Dim Passhex As String
        Select Case number
            Case 1
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1)))
            Case 2
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2)))
            Case 3
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3)))
            Case 4
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4)))
            Case 5
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5)))
            Case 6
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6)))
            Case 7
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7)))
            Case 8
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8)))
            Case 9
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9)))
            Case 10
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10)))
            Case 11
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10))) + Hex(Asc(Mid$(Password.Text, 11, 11)))
            Case 12
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10))) + Hex(Asc(Mid$(Password.Text, 11, 11))) + Hex(Asc(Mid$(Password.Text, 12, 12)))
            Case 13
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10))) + Hex(Asc(Mid$(Password.Text, 11, 11))) + Hex(Asc(Mid$(Password.Text, 12, 12))) + Hex(Asc(Mid$(Password.Text, 13, 13)))
            Case 14
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10))) + Hex(Asc(Mid$(Password.Text, 11, 11))) + Hex(Asc(Mid$(Password.Text, 12, 12))) + Hex(Asc(Mid$(Password.Text, 13, 13))) + Hex(Asc(Mid$(Password.Text, 14, 14)))
            Case 15
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10))) + Hex(Asc(Mid$(Password.Text, 11, 11))) + Hex(Asc(Mid$(Password.Text, 12, 12))) + Hex(Asc(Mid$(Password.Text, 13, 13))) + Hex(Asc(Mid$(Password.Text, 14, 14))) + Hex(Asc(Mid$(Password.Text, 15, 15)))
            Case 16
                Passhex = Hex(Asc(Mid$(Password.Text, 1, 1))) + Hex(Asc(Mid$(Password.Text, 2, 2))) + Hex(Asc(Mid$(Password.Text, 3, 3))) + Hex(Asc(Mid$(Password.Text, 4, 4))) + Hex(Asc(Mid$(Password.Text, 5, 5))) + Hex(Asc(Mid$(Password.Text, 6, 6))) + Hex(Asc(Mid$(Password.Text, 7, 7))) + Hex(Asc(Mid$(Password.Text, 8, 8))) + Hex(Asc(Mid$(Password.Text, 9, 9))) + Hex(Asc(Mid$(Password.Text, 10, 10))) + Hex(Asc(Mid$(Password.Text, 11, 11))) + Hex(Asc(Mid$(Password.Text, 12, 12))) + Hex(Asc(Mid$(Password.Text, 13, 13))) + Hex(Asc(Mid$(Password.Text, 14, 14))) + Hex(Asc(Mid$(Password.Text, 15, 15))) + Hex(Asc(Mid$(Password.Text, 16, 16)))
        End Select

        'Label2.Text = "bin\load.bin " + UserID.Text + " " + Passhex + " 1"
        Shell("bin\load.bin " + UserID.Text + " " + Passhex + " 1A")
        UserID.Text = ""
        Password.Text = ""
        Me.Close()

    End Sub

    Private Sub Button_Option_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Option.Click
        'If My.Computer.Registry.GetValue("@SOFTWARE\Softnyx\Rakion", "Location", Nothing) Is Nothing Then
        '    MsgBox("Value does not exist.")
        'Else
        '    MsgBox("Value exist.")
        'End If
        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Softnyx\Rakion", "Test", "POKKA")

        Dim fullPath As String = IO.Path.GetFullPath(My.Resources.ResourceManager.BaseName)
        fullPath = fullPath.Substring(0, fullPath.Length - 17)
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Softnyx\Rakion").SetValue("Location", "" + fullPath + "")
        My.Computer.Registry.LocalMachine.CreateSubKey("SOFTWARE\Softnyx\Rakion").SetValue("Version", "258", Microsoft.Win32.RegistryValueKind.DWord)

        'My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Softnyx\Test", "TestValue", "This is a test value.")

        Shell("risoption.exe")
    End Sub

    Private Declare Sub Sleep Lib "kernel32.dll" (ByVal Milliseconds As Integer)
    'คำสั่ง Sleep

    Function GetMD5(ByVal filePath As String)
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)

        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        f.Close()

        Dim hash As Byte() = md5.Hash
        Dim buff As StringBuilder = New StringBuilder
        Dim hashByte As Byte

        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next

        Dim md5string As String
        md5string = buff.ToString()

        Return md5string

    End Function
End Class
