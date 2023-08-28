<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.pictureBoxExcel = New System.Windows.Forms.PictureBox()
        Me.pictureBoxWord = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.pictureBoxExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxWord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(63, 67)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(88, 16)
        Me.label1.TabIndex = 7
        Me.label1.Text = "Escribe el texto:"
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(66, 86)
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.Size = New System.Drawing.Size(323, 20)
        Me.txtTexto.TabIndex = 6
        '
        'pictureBoxExcel
        '
        Me.pictureBoxExcel.Image = Global.TestInteropVB_net4._8.My.Resources.Resources.microsoft_office_excel_logo_icon_145720__1_
        Me.pictureBoxExcel.Location = New System.Drawing.Point(232, 157)
        Me.pictureBoxExcel.Name = "pictureBoxExcel"
        Me.pictureBoxExcel.Size = New System.Drawing.Size(100, 50)
        Me.pictureBoxExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxExcel.TabIndex = 9
        Me.pictureBoxExcel.TabStop = False
        '
        'pictureBoxWord
        '
        Me.pictureBoxWord.Image = Global.TestInteropVB_net4._8.My.Resources.Resources.microsoft_office_word_logo_icon_145724__1_
        Me.pictureBoxWord.Location = New System.Drawing.Point(114, 157)
        Me.pictureBoxWord.Name = "pictureBoxWord"
        Me.pictureBoxWord.Size = New System.Drawing.Size(100, 50)
        Me.pictureBoxWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxWord.TabIndex = 8
        Me.pictureBoxWord.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(453, 274)
        Me.Controls.Add(Me.pictureBoxExcel)
        Me.Controls.Add(Me.pictureBoxWord)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "Form1"
        Me.Text = "Crear documentos"
        CType(Me.pictureBoxExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxWord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents pictureBoxExcel As PictureBox
    Private WithEvents pictureBoxWord As PictureBox
    Private WithEvents label1 As Label
    Private WithEvents txtTexto As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
