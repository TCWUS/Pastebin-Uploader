﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MephTheme1 = New PasteBin_Uploader.MephTheme()
        Me.cmbEXP = New PasteBin_Uploader.MephComboBox()
        Me.txtName = New PasteBin_Uploader.MephTextBox()
        Me.txtUrl = New PasteBin_Uploader.MephTextBox()
        Me.btnUpload = New PasteBin_Uploader.MephButton()
        Me.btnBrowse = New PasteBin_Uploader.MephButton()
        Me.txtPath = New PasteBin_Uploader.MephTextBox()
        Me.MephTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MephTheme1
        '
        Me.MephTheme1.AccentColor = System.Drawing.Color.LimeGreen
        Me.MephTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(28, Byte), Integer))
        Me.MephTheme1.Controls.Add(Me.cmbEXP)
        Me.MephTheme1.Controls.Add(Me.txtName)
        Me.MephTheme1.Controls.Add(Me.txtUrl)
        Me.MephTheme1.Controls.Add(Me.btnUpload)
        Me.MephTheme1.Controls.Add(Me.btnBrowse)
        Me.MephTheme1.Controls.Add(Me.txtPath)
        Me.MephTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MephTheme1.Location = New System.Drawing.Point(0, 0)
        Me.MephTheme1.Name = "MephTheme1"
        Me.MephTheme1.Size = New System.Drawing.Size(339, 224)
        Me.MephTheme1.SubHeader = "By TCWLightning"
        Me.MephTheme1.TabIndex = 0
        Me.MephTheme1.Text = "Pastebin Uploader"
        '
        'cmbEXP
        '
        Me.cmbEXP.BackColor = System.Drawing.Color.Transparent
        Me.cmbEXP.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbEXP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEXP.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.cmbEXP.ForeColor = System.Drawing.Color.LimeGreen
        Me.cmbEXP.FormattingEnabled = True
        Me.cmbEXP.ItemHeight = 16
        Me.cmbEXP.ItemHighlightColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.cmbEXP.Items.AddRange(New Object() {"Select Expire Date", "Never ", "10 Minutes", "1 Hour", "1 Day", "1 Week", "2 Weeks ", "1 Month"})
        Me.cmbEXP.Location = New System.Drawing.Point(69, 127)
        Me.cmbEXP.Name = "cmbEXP"
        Me.cmbEXP.Size = New System.Drawing.Size(191, 22)
        Me.cmbEXP.StartIndex = 0
        Me.cmbEXP.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtName.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtName.Location = New System.Drawing.Point(34, 97)
        Me.txtName.MaxLength = 32767
        Me.txtName.MultiLine = False
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(274, 24)
        Me.txtName.TabIndex = 4
        Me.txtName.Text = "Name"
        Me.txtName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtName.UseSystemPasswordChar = False
        Me.txtName.WordWrap = False
        '
        'txtUrl
        '
        Me.txtUrl.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtUrl.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtUrl.Location = New System.Drawing.Point(34, 155)
        Me.txtUrl.MaxLength = 32767
        Me.txtUrl.MultiLine = False
        Me.txtUrl.Name = "txtUrl"
        Me.txtUrl.Size = New System.Drawing.Size(274, 24)
        Me.txtUrl.TabIndex = 3
        Me.txtUrl.Text = "Pastebin URL"
        Me.txtUrl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtUrl.UseSystemPasswordChar = False
        Me.txtUrl.WordWrap = False
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Transparent
        Me.btnUpload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnUpload.Location = New System.Drawing.Point(69, 185)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(191, 23)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "Upload"
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(205, Byte), Integer))
        Me.btnBrowse.Location = New System.Drawing.Point(292, 67)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(35, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "..."
        '
        'txtPath
        '
        Me.txtPath.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.txtPath.ForeColor = System.Drawing.Color.LimeGreen
        Me.txtPath.Location = New System.Drawing.Point(12, 67)
        Me.txtPath.MaxLength = 32767
        Me.txtPath.MultiLine = False
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(274, 24)
        Me.txtPath.TabIndex = 0
        Me.txtPath.Text = ".txt Path"
        Me.txtPath.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPath.UseSystemPasswordChar = False
        Me.txtPath.WordWrap = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(339, 224)
        Me.Controls.Add(Me.MephTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MephTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MephTheme1 As MephTheme
    Friend WithEvents btnBrowse As MephButton
    Friend WithEvents txtPath As MephTextBox
    Friend WithEvents txtUrl As MephTextBox
    Friend WithEvents btnUpload As MephButton
    Friend WithEvents cmbEXP As MephComboBox
    Friend WithEvents txtName As MephTextBox
End Class
