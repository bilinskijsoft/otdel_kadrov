<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorkersFire
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbOtdel = New System.Windows.Forms.ComboBox()
        Me.lstWorkers = New System.Windows.Forms.ListView()
        Me.chId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Відділ"
        '
        'cbOtdel
        '
        Me.cbOtdel.FormattingEnabled = True
        Me.cbOtdel.Location = New System.Drawing.Point(51, 6)
        Me.cbOtdel.Name = "cbOtdel"
        Me.cbOtdel.Size = New System.Drawing.Size(121, 21)
        Me.cbOtdel.TabIndex = 4
        '
        'lstWorkers
        '
        Me.lstWorkers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chFio, Me.chAdress, Me.chPhone, Me.chPosada, Me.chObrazovanie, Me.chStazhZag, Me.chSimPool, Me.chDataP, Me.chOtdel, Me.chStazh})
        Me.lstWorkers.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lstWorkers.FullRowSelect = True
        Me.lstWorkers.GridLines = True
        Me.lstWorkers.Location = New System.Drawing.Point(0, 33)
        Me.lstWorkers.Name = "lstWorkers"
        Me.lstWorkers.Size = New System.Drawing.Size(896, 460)
        Me.lstWorkers.TabIndex = 6
        Me.lstWorkers.UseCompatibleStateImageBehavior = False
        Me.lstWorkers.View = System.Windows.Forms.View.Details
        '
        'chId
        '
        Me.chId.Text = ""
        Me.chId.Width = 0
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
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnClear.Location = New System.Drawing.Point(172, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(23, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "X"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(218, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Звільнити"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmWorkersFire
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 493)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lstWorkers)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbOtdel)
        Me.Name = "frmWorkersFire"
        Me.Text = "Звільнення працівника"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbOtdel As ComboBox
    Friend WithEvents lstWorkers As ListView
    Friend WithEvents chId As ColumnHeader
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
    Friend WithEvents btnClear As Button
    Friend WithEvents Button1 As Button
End Class
