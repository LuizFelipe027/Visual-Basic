<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.btnSobre = New System.Windows.Forms.Button()
        Me.mnuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbrirImagem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfirmeAoSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSobre = New System.Windows.Forms.ToolStripMenuItem()
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.ofdSelecionaImagem = New System.Windows.Forms.OpenFileDialog()
        Me.mnuPrincipal.SuspendLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSobre
        '
        Me.btnSobre.Location = New System.Drawing.Point(338, 37)
        Me.btnSobre.Name = "btnSobre"
        Me.btnSobre.Size = New System.Drawing.Size(75, 23)
        Me.btnSobre.TabIndex = 0
        Me.btnSobre.Text = "Sobre"
        Me.btnSobre.UseVisualStyleBackColor = True
        '
        'mnuPrincipal
        '
        Me.mnuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.mnuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuPrincipal.Name = "mnuPrincipal"
        Me.mnuPrincipal.Size = New System.Drawing.Size(425, 24)
        Me.mnuPrincipal.TabIndex = 1
        Me.mnuPrincipal.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbrirImagem, Me.mnuConfirmeAoSair, Me.ToolStripSeparator1, Me.mnuSair})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "&Arquivo"
        '
        'mnuAbrirImagem
        '
        Me.mnuAbrirImagem.Name = "mnuAbrirImagem"
        Me.mnuAbrirImagem.Size = New System.Drawing.Size(162, 22)
        Me.mnuAbrirImagem.Text = "&Abrir Imagem"
        '
        'mnuConfirmeAoSair
        '
        Me.mnuConfirmeAoSair.Name = "mnuConfirmeAoSair"
        Me.mnuConfirmeAoSair.Size = New System.Drawing.Size(162, 22)
        Me.mnuConfirmeAoSair.Text = "&Confirme ao Sair"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(159, 6)
        '
        'mnuSair
        '
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(162, 22)
        Me.mnuSair.Text = "&Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSobre})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "A&juda"
        '
        'mnuSobre
        '
        Me.mnuSobre.Name = "mnuSobre"
        Me.mnuSobre.Size = New System.Drawing.Size(104, 22)
        Me.mnuSobre.Text = "&Sobre"
        '
        'picImagem
        '
        Me.picImagem.Location = New System.Drawing.Point(13, 37)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(319, 286)
        Me.picImagem.TabIndex = 2
        Me.picImagem.TabStop = False
        '
        'ofdSelecionaImagem
        '
        Me.ofdSelecionaImagem.Filter = "Windows Bitmaps | *.BMP|JPEG Files|*.JPG"
        Me.ofdSelecionaImagem.Title = "Selecione uma Imagem"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 335)
        Me.Controls.Add(Me.picImagem)
        Me.Controls.Add(Me.btnSobre)
        Me.Controls.Add(Me.mnuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuPrincipal
        Me.Name = "frmPrincipal"
        Me.Text = "Vizualizador de Imagens"
        Me.mnuPrincipal.ResumeLayout(False)
        Me.mnuPrincipal.PerformLayout()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSobre As Button
    Friend WithEvents mnuPrincipal As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbrirImagem As ToolStripMenuItem
    Friend WithEvents mnuConfirmeAoSair As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuSair As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuSobre As ToolStripMenuItem
    Friend WithEvents picImagem As PictureBox
    Friend WithEvents ofdSelecionaImagem As OpenFileDialog
End Class
