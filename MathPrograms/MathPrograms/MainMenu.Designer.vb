<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BangunRuangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SegitigaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LingkaranToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KubusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PersegiEmpatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeregiPajangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KerucutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnutiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BarisanAritmatikaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SisipanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAppsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutAppsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(690, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BangunRuangToolStripMenuItem, Me.AnutiasToolStripMenuItem, Me.BarisanAritmatikaToolStripMenuItem, Me.SisipanToolStripMenuItem, Me.QuitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'BangunRuangToolStripMenuItem
        '
        Me.BangunRuangToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SegitigaToolStripMenuItem, Me.LingkaranToolStripMenuItem, Me.KubusToolStripMenuItem, Me.TabungToolStripMenuItem, Me.PersegiEmpatToolStripMenuItem, Me.PeregiPajangToolStripMenuItem, Me.KerucutToolStripMenuItem})
        Me.BangunRuangToolStripMenuItem.Name = "BangunRuangToolStripMenuItem"
        Me.BangunRuangToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.BangunRuangToolStripMenuItem.Text = "Bangun Ruang"
        '
        'SegitigaToolStripMenuItem
        '
        Me.SegitigaToolStripMenuItem.Name = "SegitigaToolStripMenuItem"
        Me.SegitigaToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SegitigaToolStripMenuItem.Text = "Segitiga"
        '
        'LingkaranToolStripMenuItem
        '
        Me.LingkaranToolStripMenuItem.Name = "LingkaranToolStripMenuItem"
        Me.LingkaranToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.LingkaranToolStripMenuItem.Text = "Lingkaran"
        '
        'KubusToolStripMenuItem
        '
        Me.KubusToolStripMenuItem.Name = "KubusToolStripMenuItem"
        Me.KubusToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.KubusToolStripMenuItem.Text = "Kubus"
        '
        'TabungToolStripMenuItem
        '
        Me.TabungToolStripMenuItem.Name = "TabungToolStripMenuItem"
        Me.TabungToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.TabungToolStripMenuItem.Text = "Tabung"
        '
        'PersegiEmpatToolStripMenuItem
        '
        Me.PersegiEmpatToolStripMenuItem.Name = "PersegiEmpatToolStripMenuItem"
        Me.PersegiEmpatToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PersegiEmpatToolStripMenuItem.Text = "Persegi Empat"
        '
        'PeregiPajangToolStripMenuItem
        '
        Me.PeregiPajangToolStripMenuItem.Name = "PeregiPajangToolStripMenuItem"
        Me.PeregiPajangToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.PeregiPajangToolStripMenuItem.Text = "Peregi Pajang"
        '
        'KerucutToolStripMenuItem
        '
        Me.KerucutToolStripMenuItem.Name = "KerucutToolStripMenuItem"
        Me.KerucutToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.KerucutToolStripMenuItem.Text = "Kerucut"
        '
        'AnutiasToolStripMenuItem
        '
        Me.AnutiasToolStripMenuItem.Name = "AnutiasToolStripMenuItem"
        Me.AnutiasToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.AnutiasToolStripMenuItem.Text = "Anutias"
        '
        'BarisanAritmatikaToolStripMenuItem
        '
        Me.BarisanAritmatikaToolStripMenuItem.Name = "BarisanAritmatikaToolStripMenuItem"
        Me.BarisanAritmatikaToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.BarisanAritmatikaToolStripMenuItem.Text = "Barisan Aritmatika"
        '
        'SisipanToolStripMenuItem
        '
        Me.SisipanToolStripMenuItem.Name = "SisipanToolStripMenuItem"
        Me.SisipanToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.SisipanToolStripMenuItem.Text = "Sisipan Barisan Aritmatika"
        '
        'QuitToolStripMenuItem
        '
        Me.QuitToolStripMenuItem.Name = "QuitToolStripMenuItem"
        Me.QuitToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.QuitToolStripMenuItem.Text = "Quit"
        '
        'AboutAppsToolStripMenuItem
        '
        Me.AboutAppsToolStripMenuItem.Name = "AboutAppsToolStripMenuItem"
        Me.AboutAppsToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.AboutAppsToolStripMenuItem.Text = "About Apps"
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(690, 419)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainMenu"
        Me.Text = "MainMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BangunRuangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SegitigaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LingkaranToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KubusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PersegiEmpatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PeregiPajangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KerucutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnutiasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BarisanAritmatikaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SisipanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAppsToolStripMenuItem As ToolStripMenuItem
End Class
