<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Panel1 = New Panel()
        MinimizeButton = New Button()
        RegisterButton = New Button()
        CloseButton = New Button()
        Label1 = New Label()
        Panel2 = New Panel()
        SettingsBtn = New Button()
        ResultsBtn = New Button()
        PrivacyBtn = New Button()
        ProtectionBtn = New Button()
        HomeBtn = New Button()
        CtlHome1 = New ctlHome()
        CtlProtection1 = New ctlProtection()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(35), CByte(51))
        Panel1.Controls.Add(MinimizeButton)
        Panel1.Controls.Add(RegisterButton)
        Panel1.Controls.Add(CloseButton)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(935, 50)
        Panel1.TabIndex = 0
        ' 
        ' MinimizeButton
        ' 
        MinimizeButton.BackColor = Color.FromArgb(CByte(46), CByte(53), CByte(77))
        MinimizeButton.FlatAppearance.BorderSize = 0
        MinimizeButton.FlatStyle = FlatStyle.Flat
        MinimizeButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MinimizeButton.ForeColor = Color.White
        MinimizeButton.Location = New Point(831, 0)
        MinimizeButton.Name = "MinimizeButton"
        MinimizeButton.Size = New Size(52, 50)
        MinimizeButton.TabIndex = 1
        MinimizeButton.Text = "_"
        MinimizeButton.UseVisualStyleBackColor = False
        ' 
        ' RegisterButton
        ' 
        RegisterButton.BackColor = Color.FromArgb(CByte(30), CByte(35), CByte(51))
        RegisterButton.FlatAppearance.BorderSize = 0
        RegisterButton.FlatStyle = FlatStyle.Flat
        RegisterButton.Font = New Font("Segoe UI", 18F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        RegisterButton.ForeColor = Color.MediumPurple
        RegisterButton.Location = New Point(663, 0)
        RegisterButton.Name = "RegisterButton"
        RegisterButton.Size = New Size(162, 50)
        RegisterButton.TabIndex = 1
        RegisterButton.Text = "Unregistered"
        RegisterButton.UseVisualStyleBackColor = False
        ' 
        ' CloseButton
        ' 
        CloseButton.BackColor = Color.FromArgb(CByte(46), CByte(53), CByte(77))
        CloseButton.FlatAppearance.BorderSize = 0
        CloseButton.FlatStyle = FlatStyle.Flat
        CloseButton.Font = New Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CloseButton.ForeColor = Color.White
        CloseButton.Location = New Point(883, 0)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(52, 50)
        CloseButton.TabIndex = 1
        CloseButton.Text = "X"
        CloseButton.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 32)
        Label1.TabIndex = 0
        Label1.Text = "Antivirus Demo"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(30), CByte(35), CByte(51))
        Panel2.Controls.Add(SettingsBtn)
        Panel2.Controls.Add(ResultsBtn)
        Panel2.Controls.Add(PrivacyBtn)
        Panel2.Controls.Add(ProtectionBtn)
        Panel2.Controls.Add(HomeBtn)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 554)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(935, 52)
        Panel2.TabIndex = 1
        ' 
        ' SettingsBtn
        ' 
        SettingsBtn.BackColor = Color.FromArgb(CByte(46), CByte(53), CByte(77))
        SettingsBtn.FlatAppearance.BorderSize = 0
        SettingsBtn.FlatStyle = FlatStyle.Flat
        SettingsBtn.Font = New Font("Segoe UI", 14.25F)
        SettingsBtn.ForeColor = Color.WhiteSmoke
        SettingsBtn.Location = New Point(644, 0)
        SettingsBtn.Name = "SettingsBtn"
        SettingsBtn.Size = New Size(114, 52)
        SettingsBtn.TabIndex = 1
        SettingsBtn.Tag = "settings"
        SettingsBtn.Text = "Settings"
        SettingsBtn.UseVisualStyleBackColor = False
        ' 
        ' ResultsBtn
        ' 
        ResultsBtn.BackColor = Color.FromArgb(CByte(46), CByte(53), CByte(77))
        ResultsBtn.FlatAppearance.BorderSize = 0
        ResultsBtn.FlatStyle = FlatStyle.Flat
        ResultsBtn.Font = New Font("Segoe UI", 14.25F)
        ResultsBtn.ForeColor = Color.WhiteSmoke
        ResultsBtn.Location = New Point(524, 0)
        ResultsBtn.Name = "ResultsBtn"
        ResultsBtn.Size = New Size(114, 52)
        ResultsBtn.TabIndex = 1
        ResultsBtn.Tag = "results"
        ResultsBtn.Text = "Results"
        ResultsBtn.UseVisualStyleBackColor = False
        ' 
        ' PrivacyBtn
        ' 
        PrivacyBtn.BackColor = Color.FromArgb(CByte(46), CByte(53), CByte(77))
        PrivacyBtn.FlatAppearance.BorderSize = 0
        PrivacyBtn.FlatStyle = FlatStyle.Flat
        PrivacyBtn.Font = New Font("Segoe UI", 14.25F)
        PrivacyBtn.ForeColor = Color.WhiteSmoke
        PrivacyBtn.Location = New Point(404, 0)
        PrivacyBtn.Name = "PrivacyBtn"
        PrivacyBtn.Size = New Size(114, 52)
        PrivacyBtn.TabIndex = 1
        PrivacyBtn.Tag = "privacy"
        PrivacyBtn.Text = "Privacy"
        PrivacyBtn.UseVisualStyleBackColor = False
        ' 
        ' ProtectionBtn
        ' 
        ProtectionBtn.BackColor = Color.FromArgb(CByte(46), CByte(53), CByte(77))
        ProtectionBtn.FlatAppearance.BorderSize = 0
        ProtectionBtn.FlatStyle = FlatStyle.Flat
        ProtectionBtn.Font = New Font("Segoe UI", 14.25F)
        ProtectionBtn.ForeColor = Color.WhiteSmoke
        ProtectionBtn.Location = New Point(284, 0)
        ProtectionBtn.Name = "ProtectionBtn"
        ProtectionBtn.Size = New Size(114, 52)
        ProtectionBtn.TabIndex = 1
        ProtectionBtn.Tag = "protection"
        ProtectionBtn.Text = "Protection"
        ProtectionBtn.UseVisualStyleBackColor = False
        ' 
        ' HomeBtn
        ' 
        HomeBtn.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(25))
        HomeBtn.FlatAppearance.BorderSize = 0
        HomeBtn.FlatStyle = FlatStyle.Flat
        HomeBtn.Font = New Font("Segoe UI", 14.25F)
        HomeBtn.ForeColor = Color.WhiteSmoke
        HomeBtn.ImageAlign = ContentAlignment.MiddleLeft
        HomeBtn.Location = New Point(164, 0)
        HomeBtn.Name = "HomeBtn"
        HomeBtn.Size = New Size(114, 52)
        HomeBtn.TabIndex = 1
        HomeBtn.Tag = "home"
        HomeBtn.Text = "Home"
        HomeBtn.UseVisualStyleBackColor = False
        ' 
        ' CtlHome1
        ' 
        CtlHome1.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(25))
        CtlHome1.Location = New Point(0, 56)
        CtlHome1.Name = "CtlHome1"
        CtlHome1.Size = New Size(935, 492)
        CtlHome1.TabIndex = 2
        ' 
        ' CtlProtection1
        ' 
        CtlProtection1.BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(25))
        CtlProtection1.Location = New Point(0, 56)
        CtlProtection1.Name = "CtlProtection1"
        CtlProtection1.Size = New Size(935, 492)
        CtlProtection1.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(15), CByte(17), CByte(25))
        ClientSize = New Size(935, 606)
        Controls.Add(CtlHome1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(CtlProtection1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Antivirus Demo"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CloseButton As Button
    Friend WithEvents MinimizeButton As Button
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents ResultsBtn As Button
    Friend WithEvents PrivacyBtn As Button
    Friend WithEvents ProtectionBtn As Button
    Friend WithEvents HomeBtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RegisterButton As Button
    Friend WithEvents CtlHome1 As ctlHome
    Friend WithEvents CtlProtection1 As ctlProtection

End Class
