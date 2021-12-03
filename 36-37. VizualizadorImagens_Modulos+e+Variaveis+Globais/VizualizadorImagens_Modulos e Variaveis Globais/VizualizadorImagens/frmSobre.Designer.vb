<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSobre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSobre))
        Me.lblNomeUsuario = New System.Windows.Forms.Label()
        Me.txtNomeUsuario = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancela = New System.Windows.Forms.Button()
        Me.chkMensagemAoSair = New System.Windows.Forms.CheckBox()
        Me.grpCorDeFundoPadrao = New System.Windows.Forms.GroupBox()
        Me.optCorDeFundoPadrao = New System.Windows.Forms.RadioButton()
        Me.optCorDeFundoBranca = New System.Windows.Forms.RadioButton()
        Me.grpCorDeFundoPadrao.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNomeUsuario
        '
        Me.lblNomeUsuario.AutoSize = True
        Me.lblNomeUsuario.Location = New System.Drawing.Point(25, 29)
        Me.lblNomeUsuario.Name = "lblNomeUsuario"
        Me.lblNomeUsuario.Size = New System.Drawing.Size(92, 13)
        Me.lblNomeUsuario.TabIndex = 0
        Me.lblNomeUsuario.Text = "Nome do Usuário:"
        '
        'txtNomeUsuario
        '
        Me.txtNomeUsuario.Location = New System.Drawing.Point(118, 29)
        Me.txtNomeUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNomeUsuario.MaxLength = 0
        Me.txtNomeUsuario.Name = "txtNomeUsuario"
        Me.txtNomeUsuario.Size = New System.Drawing.Size(170, 20)
        Me.txtNomeUsuario.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(314, 25)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancela
        '
        Me.btnCancela.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancela.Location = New System.Drawing.Point(314, 55)
        Me.btnCancela.Name = "btnCancela"
        Me.btnCancela.Size = New System.Drawing.Size(75, 23)
        Me.btnCancela.TabIndex = 3
        Me.btnCancela.Text = "Cancela"
        Me.btnCancela.UseVisualStyleBackColor = True
        '
        'chkMensagemAoSair
        '
        Me.chkMensagemAoSair.AutoSize = True
        Me.chkMensagemAoSair.Location = New System.Drawing.Point(118, 60)
        Me.chkMensagemAoSair.Name = "chkMensagemAoSair"
        Me.chkMensagemAoSair.Size = New System.Drawing.Size(149, 17)
        Me.chkMensagemAoSair.TabIndex = 4
        Me.chkMensagemAoSair.Text = "Mostrar mensagem ao sair"
        Me.chkMensagemAoSair.UseVisualStyleBackColor = True
        '
        'grpCorDeFundoPadrao
        '
        Me.grpCorDeFundoPadrao.Controls.Add(Me.optCorDeFundoBranca)
        Me.grpCorDeFundoPadrao.Controls.Add(Me.optCorDeFundoPadrao)
        Me.grpCorDeFundoPadrao.Location = New System.Drawing.Point(118, 84)
        Me.grpCorDeFundoPadrao.Name = "grpCorDeFundoPadrao"
        Me.grpCorDeFundoPadrao.Size = New System.Drawing.Size(200, 75)
        Me.grpCorDeFundoPadrao.TabIndex = 5
        Me.grpCorDeFundoPadrao.TabStop = False
        Me.grpCorDeFundoPadrao.Text = "Cor de Fundo Padrão"
        '
        'optCorDeFundoPadrao
        '
        Me.optCorDeFundoPadrao.AutoSize = True
        Me.optCorDeFundoPadrao.Checked = True
        Me.optCorDeFundoPadrao.Location = New System.Drawing.Point(16, 20)
        Me.optCorDeFundoPadrao.Name = "optCorDeFundoPadrao"
        Me.optCorDeFundoPadrao.Size = New System.Drawing.Size(107, 17)
        Me.optCorDeFundoPadrao.TabIndex = 0
        Me.optCorDeFundoPadrao.TabStop = True
        Me.optCorDeFundoPadrao.Text = "Cor Cinza Padrão"
        Me.optCorDeFundoPadrao.UseVisualStyleBackColor = True
        '
        'optCorDeFundoBranca
        '
        Me.optCorDeFundoBranca.AutoSize = True
        Me.optCorDeFundoBranca.Location = New System.Drawing.Point(16, 43)
        Me.optCorDeFundoBranca.Name = "optCorDeFundoBranca"
        Me.optCorDeFundoBranca.Size = New System.Drawing.Size(78, 17)
        Me.optCorDeFundoBranca.TabIndex = 6
        Me.optCorDeFundoBranca.Text = "Cor Branca"
        Me.optCorDeFundoBranca.UseVisualStyleBackColor = True
        '
        'frmSobre
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.CancelButton = Me.btnCancela
        Me.ClientSize = New System.Drawing.Size(436, 221)
        Me.Controls.Add(Me.grpCorDeFundoPadrao)
        Me.Controls.Add(Me.chkMensagemAoSair)
        Me.Controls.Add(Me.btnCancela)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtNomeUsuario)
        Me.Controls.Add(Me.lblNomeUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSobre"
        Me.Text = "Sobre"
        Me.grpCorDeFundoPadrao.ResumeLayout(False)
        Me.grpCorDeFundoPadrao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNomeUsuario As Label
    Friend WithEvents txtNomeUsuario As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnCancela As Button
    Friend WithEvents chkMensagemAoSair As CheckBox
    Friend WithEvents grpCorDeFundoPadrao As GroupBox
    Friend WithEvents optCorDeFundoBranca As RadioButton
    Friend WithEvents optCorDeFundoPadrao As RadioButton
End Class
