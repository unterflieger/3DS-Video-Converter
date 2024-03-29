﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.'
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
        SourceTextBox = New TextBox()
        FileSearchButton = New Button()
        TitleText = New Label()
        SourceLabel = New Label()
        ResultTextBox = New TextBox()
        ResultSearchButton = New Button()
        ResultLabel = New Label()
        ConvertButton = New Button()
        LeftVideoSelect = New RadioButton()
        RightVideoSelect = New RadioButton()
        BothVideoSelect = New RadioButton()
        LabelTrackSelect = New Label()
        GithubLink = New LinkLabel()
        Label2 = New Label()
        Label1 = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        SuspendLayout()
        ' 
        ' SourceTextBox
        ' 
        SourceTextBox.Location = New Point(12, 72)
        SourceTextBox.Name = "SourceTextBox"
        SourceTextBox.PlaceholderText = "Dateispeicherort (Beispiel: C:\Videos\video.avi)"
        SourceTextBox.Size = New Size(298, 23)
        SourceTextBox.TabIndex = 0
        ' 
        ' FileSearchButton
        ' 
        FileSearchButton.Location = New Point(316, 71)
        FileSearchButton.Name = "FileSearchButton"
        FileSearchButton.Size = New Size(75, 23)
        FileSearchButton.TabIndex = 1
        FileSearchButton.Text = "Suchen..."
        FileSearchButton.UseVisualStyleBackColor = True
        ' 
        ' TitleText
        ' 
        TitleText.AutoSize = True
        TitleText.Font = New Font("Segoe UI", 15F)
        TitleText.Location = New Point(12, 9)
        TitleText.Name = "TitleText"
        TitleText.Size = New Size(195, 28)
        TitleText.TabIndex = 2
        TitleText.Text = "3DS Video Converter"
        ' 
        ' SourceLabel
        ' 
        SourceLabel.AutoSize = True
        SourceLabel.Location = New Point(12, 54)
        SourceLabel.Name = "SourceLabel"
        SourceLabel.Size = New Size(81, 15)
        SourceLabel.TabIndex = 3
        SourceLabel.Text = "Originalvideo:"
        ' 
        ' ResultTextBox
        ' 
        ResultTextBox.Location = New Point(12, 129)
        ResultTextBox.Name = "ResultTextBox"
        ResultTextBox.PlaceholderText = "Dateispeicherort (Beispiel: C:\Videos\video-fertig.avi)"
        ResultTextBox.Size = New Size(298, 23)
        ResultTextBox.TabIndex = 4
        ' 
        ' ResultSearchButton
        ' 
        ResultSearchButton.Location = New Point(316, 129)
        ResultSearchButton.Name = "ResultSearchButton"
        ResultSearchButton.Size = New Size(75, 23)
        ResultSearchButton.TabIndex = 5
        ResultSearchButton.Text = "Suchen..."
        ResultSearchButton.UseVisualStyleBackColor = True
        ' 
        ' ResultLabel
        ' 
        ResultLabel.AutoSize = True
        ResultLabel.Location = New Point(12, 111)
        ResultLabel.Name = "ResultLabel"
        ResultLabel.Size = New Size(105, 15)
        ResultLabel.TabIndex = 6
        ResultLabel.Text = "Fertige(s) Video(s):"
        ' 
        ' ConvertButton
        ' 
        ConvertButton.Location = New Point(12, 234)
        ConvertButton.Name = "ConvertButton"
        ConvertButton.Size = New Size(379, 35)
        ConvertButton.TabIndex = 7
        ConvertButton.Text = "Konvertieren!"
        ConvertButton.UseVisualStyleBackColor = True
        ' 
        ' LeftVideoSelect
        ' 
        LeftVideoSelect.AutoSize = True
        LeftVideoSelect.Location = New Point(12, 200)
        LeftVideoSelect.Name = "LeftVideoSelect"
        LeftVideoSelect.Size = New Size(52, 19)
        LeftVideoSelect.TabIndex = 8
        LeftVideoSelect.TabStop = True
        LeftVideoSelect.Text = "Links"
        LeftVideoSelect.UseVisualStyleBackColor = True
        ' 
        ' RightVideoSelect
        ' 
        RightVideoSelect.AutoSize = True
        RightVideoSelect.Location = New Point(70, 200)
        RightVideoSelect.Name = "RightVideoSelect"
        RightVideoSelect.Size = New Size(60, 19)
        RightVideoSelect.TabIndex = 9
        RightVideoSelect.TabStop = True
        RightVideoSelect.Text = "Rechts"
        RightVideoSelect.UseVisualStyleBackColor = True
        ' 
        ' BothVideoSelect
        ' 
        BothVideoSelect.AutoSize = True
        BothVideoSelect.Location = New Point(136, 200)
        BothVideoSelect.Name = "BothVideoSelect"
        BothVideoSelect.Size = New Size(54, 19)
        BothVideoSelect.TabIndex = 10
        BothVideoSelect.TabStop = True
        BothVideoSelect.Text = "Beide"
        BothVideoSelect.UseVisualStyleBackColor = True
        ' 
        ' LabelTrackSelect
        ' 
        LabelTrackSelect.AutoSize = True
        LabelTrackSelect.Location = New Point(12, 166)
        LabelTrackSelect.Name = "LabelTrackSelect"
        LabelTrackSelect.Size = New Size(247, 15)
        LabelTrackSelect.TabIndex = 11
        LabelTrackSelect.Text = "Von welcher Kamera soll das Video stammen?"
        ' 
        ' GithubLink
        ' 
        GithubLink.AutoSize = True
        GithubLink.Location = New Point(346, 6)
        GithubLink.Name = "GithubLink"
        GithubLink.Size = New Size(45, 15)
        GithubLink.TabIndex = 12
        GithubLink.TabStop = True
        GithubLink.Text = "GitHub"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(245, 6)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 15)
        Label2.TabIndex = 13
        Label2.Text = "2023 unterflieger"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 182)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 15)
        Label1.TabIndex = 14
        Label1.Text = "(Bei ""Beide"" entstehen 2 Videos)"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.DefaultExt = "avi"
        OpenFileDialog1.Filter = "Videodateien (*.avi)|*.avi|Alle Dateien (*.*)|*.*"
        ' 
        ' SaveFileDialog1
        ' 
        SaveFileDialog1.DefaultExt = "avi"
        SaveFileDialog1.FileName = "FertigesVideo.avi"
        SaveFileDialog1.Filter = "Videodatei (*.avi)|*.avi|Alle Dateien (*.*)|*.*"
        SaveFileDialog1.Tag = ".avi"
        SaveFileDialog1.Title = "Zielverzeichnis und Namen wählen"
        ' 
        ' MainScreen
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnableAllowFocusChange
        ClientSize = New Size(403, 281)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(GithubLink)
        Controls.Add(LabelTrackSelect)
        Controls.Add(BothVideoSelect)
        Controls.Add(RightVideoSelect)
        Controls.Add(LeftVideoSelect)
        Controls.Add(ConvertButton)
        Controls.Add(ResultLabel)
        Controls.Add(ResultSearchButton)
        Controls.Add(ResultTextBox)
        Controls.Add(SourceLabel)
        Controls.Add(TitleText)
        Controls.Add(FileSearchButton)
        Controls.Add(SourceTextBox)
        Name = "MainScreen"
        Text = "3DS Video Converter"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SourceTextBox As TextBox
    Friend WithEvents FileSearchButton As Button
    Friend WithEvents TitleText As Label
    Friend WithEvents SourceLabel As Label
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents ResultSearchButton As Button
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ConvertButton As Button
    Friend WithEvents LeftVideoSelect As RadioButton
    Friend WithEvents RightVideoSelect As RadioButton
    Friend WithEvents BothVideoSelect As RadioButton
    Friend WithEvents LabelTrackSelect As Label
    Friend WithEvents GithubLink As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog

End Class
