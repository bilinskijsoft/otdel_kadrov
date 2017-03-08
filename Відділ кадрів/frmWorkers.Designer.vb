<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkers
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chFio = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chAdress = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPhone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chPosada = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chObrazovanie = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStazhZag = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSimPool = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chDataP = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chOtdel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStazh = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chFio, Me.chAdress, Me.chPhone, Me.chPosada, Me.chObrazovanie, Me.chStazhZag, Me.chSimPool, Me.chDataP, Me.chOtdel, Me.chStazh})
        Me.ListView1.Location = New System.Drawing.Point(15, 37)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(873, 450)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'chFio
        '
        Me.chFio.Text = "ПІБ"
        Me.chFio.Width = 135
        '
        'chAdress
        '
        Me.chAdress.Text = "Адреса"
        Me.chAdress.Width = 98
        '
        'chPhone
        '
        Me.chPhone.Text = "тел."
        Me.chPhone.Width = 93
        '
        'chPosada
        '
        Me.chPosada.Text = "Посада"
        Me.chPosada.Width = 103
        '
        'chObrazovanie
        '
        Me.chObrazovanie.Text = "Освіта"
        '
        'chStazhZag
        '
        Me.chStazhZag.Text = "Загаьний стаж"
        Me.chStazhZag.Width = 92
        '
        'chSimPool
        '
        Me.chSimPool.Text = "Сім. положення"
        Me.chSimPool.Width = 94
        '
        'chDataP
        '
        Me.chDataP.Text = "Дата прийому"
        Me.chDataP.Width = 89
        '
        'chOtdel
        '
        Me.chOtdel.Text = "Відділ"
        '
        'chStazh
        '
        Me.chStazh.Text = "Стаж"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(54, 10)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Відділ"
        '
        'frmWorkers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 499)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "frmWorkers"
        Me.Text = "frmWorkers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents chFio As ColumnHeader
    Friend WithEvents chAdress As ColumnHeader
    Friend WithEvents chPhone As ColumnHeader
    Friend WithEvents chPosada As ColumnHeader
    Friend WithEvents chObrazovanie As ColumnHeader
    Friend WithEvents chStazhZag As ColumnHeader
    Friend WithEvents chSimPool As ColumnHeader
    Friend WithEvents chDataP As ColumnHeader
    Friend WithEvents chOtdel As ColumnHeader
    Friend WithEvents chStazh As ColumnHeader
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
End Class
