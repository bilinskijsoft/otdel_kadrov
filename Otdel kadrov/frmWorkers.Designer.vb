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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbOtdel = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstWorkers
        '
        Me.lstWorkers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chFio, Me.chAdress, Me.chPhone, Me.chPosada, Me.chObrazovanie, Me.chStazhZag, Me.chSimPool, Me.chDataP, Me.chOtdel, Me.chStazh})
        Me.lstWorkers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstWorkers.FullRowSelect = True
        Me.lstWorkers.GridLines = True
        Me.lstWorkers.Location = New System.Drawing.Point(3, 36)
        Me.lstWorkers.Name = "lstWorkers"
        Me.lstWorkers.Size = New System.Drawing.Size(894, 460)
        Me.lstWorkers.TabIndex = 0
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cbOtdel)
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(885, 27)
        Me.Panel1.TabIndex = 3
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.btnClear.Location = New System.Drawing.Point(169, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(23, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "X"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Відділ"
        '
        'cbOtdel
        '
        Me.cbOtdel.FormattingEnabled = True
        Me.cbOtdel.Location = New System.Drawing.Point(48, 3)
        Me.cbOtdel.Name = "cbOtdel"
        Me.cbOtdel.Size = New System.Drawing.Size(121, 21)
        Me.cbOtdel.TabIndex = 3
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lstWorkers, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.813627!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.18637!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(900, 499)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'frmWorkers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 499)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmWorkers"
        Me.Text = "Працюючі працівники"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstWorkers As ListView
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cbOtdel As ComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents chId As ColumnHeader
    Friend WithEvents btnClear As Button
End Class
