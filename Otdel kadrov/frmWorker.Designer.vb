<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWorker
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFIO = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtDolgn = New System.Windows.Forms.TextBox()
        Me.txtOsv = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStagO = New System.Windows.Forms.TextBox()
        Me.txtSimPolog = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtOtdel = New System.Windows.Forms.TextBox()
        Me.txtStag = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.openFile = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ПІБ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Адреса"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(176, 68)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Телефон"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(176, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Посада"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Освіта"
        '
        'txtFIO
        '
        Me.txtFIO.Location = New System.Drawing.Point(246, 13)
        Me.txtFIO.Name = "txtFIO"
        Me.txtFIO.Size = New System.Drawing.Size(100, 20)
        Me.txtFIO.TabIndex = 6
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(246, 39)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(100, 20)
        Me.txtAdress.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(246, 65)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 8
        '
        'txtDolgn
        '
        Me.txtDolgn.Location = New System.Drawing.Point(246, 91)
        Me.txtDolgn.Name = "txtDolgn"
        Me.txtDolgn.Size = New System.Drawing.Size(100, 20)
        Me.txtDolgn.TabIndex = 9
        '
        'txtOsv
        '
        Me.txtOsv.Location = New System.Drawing.Point(246, 117)
        Me.txtOsv.Name = "txtOsv"
        Me.txtOsv.Size = New System.Drawing.Size(100, 20)
        Me.txtOsv.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(353, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Стаж загальний"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(353, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Сім. положення"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Дата прийому"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(353, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Відділ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Стаж в піпр."
        '
        'txtStagO
        '
        Me.txtStagO.Location = New System.Drawing.Point(443, 13)
        Me.txtStagO.Name = "txtStagO"
        Me.txtStagO.Size = New System.Drawing.Size(100, 20)
        Me.txtStagO.TabIndex = 16
        '
        'txtSimPolog
        '
        Me.txtSimPolog.Location = New System.Drawing.Point(443, 39)
        Me.txtSimPolog.Name = "txtSimPolog"
        Me.txtSimPolog.Size = New System.Drawing.Size(100, 20)
        Me.txtSimPolog.TabIndex = 17
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(443, 65)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 18
        '
        'txtOtdel
        '
        Me.txtOtdel.Location = New System.Drawing.Point(443, 91)
        Me.txtOtdel.Name = "txtOtdel"
        Me.txtOtdel.Size = New System.Drawing.Size(100, 20)
        Me.txtOtdel.TabIndex = 19
        '
        'txtStag
        '
        Me.txtStag.Location = New System.Drawing.Point(443, 117)
        Me.txtStag.Name = "txtStag"
        Me.txtStag.Size = New System.Drawing.Size(100, 20)
        Me.txtStag.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAction)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 38)
        Me.Panel1.TabIndex = 21
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(467, 3)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(94, 32)
        Me.btnAction.TabIndex = 1
        Me.btnAction.Text = "Зберегти"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'openFile
        '
        Me.openFile.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 143)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Завантажити фото"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(179, 172)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 23
        Me.txtId.Visible = False
        '
        'frmWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 249)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtStag)
        Me.Controls.Add(Me.txtOtdel)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtSimPolog)
        Me.Controls.Add(Me.txtStagO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtOsv)
        Me.Controls.Add(Me.txtDolgn)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtAdress)
        Me.Controls.Add(Me.txtFIO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmWorker"
        Me.Text = "Працівник"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtFIO As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtDolgn As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtStagO As TextBox
    Friend WithEvents txtSimPolog As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtOtdel As TextBox
    Friend WithEvents txtStag As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAction As Button
    Private WithEvents txtOsv As TextBox
    Friend WithEvents openFile As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents txtId As TextBox
End Class
