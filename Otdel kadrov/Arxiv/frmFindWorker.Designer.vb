<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindWorker
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnRecover = New System.Windows.Forms.Button()
        Me.chDataUv = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtClear = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lstWorkers, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(897, 562)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lstWorkers
        '
        Me.lstWorkers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chId, Me.chFio, Me.chAdress, Me.chPhone, Me.chPosada, Me.chObrazovanie, Me.chStazhZag, Me.chSimPool, Me.chDataP, Me.chDataUv})
        Me.lstWorkers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstWorkers.FullRowSelect = True
        Me.lstWorkers.GridLines = True
        Me.lstWorkers.Location = New System.Drawing.Point(3, 78)
        Me.lstWorkers.Name = "lstWorkers"
        Me.lstWorkers.Size = New System.Drawing.Size(891, 481)
        Me.lstWorkers.TabIndex = 3
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtSearch, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(891, 27)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtSearch
        '
        Me.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSearch.Location = New System.Drawing.Point(42, 3)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(846, 20)
        Me.txtSearch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 27)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ПІБ:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.btnRecover, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtClear, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 36)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(891, 36)
        Me.TableLayoutPanel3.TabIndex = 4
        '
        'btnRecover
        '
        Me.btnRecover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnRecover.Location = New System.Drawing.Point(3, 3)
        Me.btnRecover.Name = "btnRecover"
        Me.btnRecover.Size = New System.Drawing.Size(178, 30)
        Me.btnRecover.TabIndex = 0
        Me.btnRecover.Text = "Відновити"
        Me.btnRecover.UseVisualStyleBackColor = True
        '
        'chDataUv
        '
        Me.chDataUv.Text = "Дата звільнення"
        Me.chDataUv.Width = 90
        '
        'txtClear
        '
        Me.txtClear.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtClear.Location = New System.Drawing.Point(187, 3)
        Me.txtClear.Name = "txtClear"
        Me.txtClear.Size = New System.Drawing.Size(178, 30)
        Me.txtClear.TabIndex = 1
        Me.txtClear.Text = "Очистити старі записи"
        Me.txtClear.UseVisualStyleBackColor = True
        '
        'frmFindWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 562)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "frmFindWorker"
        Me.Text = "frmFindWorker"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
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
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btnRecover As Button
    Friend WithEvents chDataUv As ColumnHeader
    Friend WithEvents txtClear As Button
End Class
