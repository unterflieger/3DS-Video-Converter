<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ffmpegdownload
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ffmpegdownload))
        DownloadYesButton = New Button()
        FFmpegnotfoundLabel = New Label()
        DownloadNoButton = New Button()
        ffmpegmanualdownload = New LinkLabel()
        SuspendLayout()
        ' 
        ' DownloadYesButton
        ' 
        DownloadYesButton.Location = New Point(64, 151)
        DownloadYesButton.Name = "DownloadYesButton"
        DownloadYesButton.Size = New Size(113, 29)
        DownloadYesButton.TabIndex = 0
        DownloadYesButton.Text = "Ja"
        DownloadYesButton.UseVisualStyleBackColor = True
        ' 
        ' FFmpegnotfoundLabel
        ' 
        FFmpegnotfoundLabel.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FFmpegnotfoundLabel.Font = New Font("Segoe UI", 10F)
        FFmpegnotfoundLabel.Location = New Point(12, 9)
        FFmpegnotfoundLabel.Name = "FFmpegnotfoundLabel"
        FFmpegnotfoundLabel.Size = New Size(334, 124)
        FFmpegnotfoundLabel.TabIndex = 1
        FFmpegnotfoundLabel.Text = resources.GetString("FFmpegnotfoundLabel.Text")
        FFmpegnotfoundLabel.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' DownloadNoButton
        ' 
        DownloadNoButton.Location = New Point(183, 151)
        DownloadNoButton.Name = "DownloadNoButton"
        DownloadNoButton.Size = New Size(113, 29)
        DownloadNoButton.TabIndex = 2
        DownloadNoButton.Text = "Nein"
        DownloadNoButton.UseVisualStyleBackColor = True
        ' 
        ' ffmpegmanualdownload
        ' 
        ffmpegmanualdownload.AutoSize = True
        ffmpegmanualdownload.Location = New Point(93, 133)
        ffmpegmanualdownload.Name = "ffmpegmanualdownload"
        ffmpegmanualdownload.Size = New Size(173, 15)
        ffmpegmanualdownload.TabIndex = 3
        ffmpegmanualdownload.TabStop = True
        ffmpegmanualdownload.Text = "Manuell FFmpeg herunterladen"
        ' 
        ' ffmpegdownload
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(358, 192)
        Controls.Add(ffmpegmanualdownload)
        Controls.Add(DownloadNoButton)
        Controls.Add(FFmpegnotfoundLabel)
        Controls.Add(DownloadYesButton)
        Name = "ffmpegdownload"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DownloadYesButton As Button
    Friend WithEvents FFmpegnotfoundLabel As Label
    Friend WithEvents DownloadNoButton As Button
    Friend WithEvents ffmpegmanualdownload As LinkLabel
End Class
