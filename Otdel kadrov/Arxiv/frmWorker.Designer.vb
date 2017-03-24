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
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.txtSimPolog = New System.Windows.Forms.TextBox()
        Me.txtStagO = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtOsv = New System.Windows.Forms.TextBox()
        Me.txtDolgn = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtAdress = New System.Windows.Forms.TextBox()
        Me.txtFIO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDataUv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOtdel = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtReason = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(12, 208)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 20)
        Me.txtId.TabIndex = 47
        Me.txtId.Visible = False
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(461, 64)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(100, 20)
        Me.txtData.TabIndex = 42
        '
        'txtSimPolog
        '
        Me.txtSimPolog.Location = New System.Drawing.Point(461, 38)
        Me.txtSimPolog.Name = "txtSimPolog"
        Me.txtSimPolog.Size = New System.Drawing.Size(100, 20)
        Me.txtSimPolog.TabIndex = 41
        '
        'txtStagO
        '
        Me.txtStagO.Location = New System.Drawing.Point(461, 12)
        Me.txtStagO.Name = "txtStagO"
        Me.txtStagO.Size = New System.Drawing.Size(100, 20)
        Me.txtStagO.TabIndex = 40
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(352, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Дата прийому"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(352, 41)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Сім. положення"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(352, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Стаж загальний"
        '
        'txtOsv
        '
        Me.txtOsv.Location = New System.Drawing.Point(245, 116)
        Me.txtOsv.Name = "txtOsv"
        Me.txtOsv.Size = New System.Drawing.Size(100, 20)
        Me.txtOsv.TabIndex = 34
        '
        'txtDolgn
        '
        Me.txtDolgn.Location = New System.Drawing.Point(245, 90)
        Me.txtDolgn.Name = "txtDolgn"
        Me.txtDolgn.Size = New System.Drawing.Size(100, 20)
        Me.txtDolgn.TabIndex = 33
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(245, 64)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 32
        '
        'txtAdress
        '
        Me.txtAdress.Location = New System.Drawing.Point(245, 38)
        Me.txtAdress.Name = "txtAdress"
        Me.txtAdress.Size = New System.Drawing.Size(100, 20)
        Me.txtAdress.TabIndex = 31
        '
        'txtFIO
        '
        Me.txtFIO.Location = New System.Drawing.Point(245, 12)
        Me.txtFIO.Name = "txtFIO"
        Me.txtFIO.Size = New System.Drawing.Size(100, 20)
        Me.txtFIO.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Освіта"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(175, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Посада"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(175, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Телефон"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Адреса"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ПІБ"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 190)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(352, 93)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Дата звільнення"
        '
        'txtDataUv
        '
        Me.txtDataUv.Location = New System.Drawing.Point(461, 90)
        Me.txtDataUv.Name = "txtDataUv"
        Me.txtDataUv.Size = New System.Drawing.Size(100, 20)
        Me.txtDataUv.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(352, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Відділ"
        '
        'txtOtdel
        '
        Me.txtOtdel.Location = New System.Drawing.Point(461, 116)
        Me.txtOtdel.Name = "txtOtdel"
        Me.txtOtdel.Size = New System.Drawing.Size(100, 20)
        Me.txtOtdel.TabIndex = 44
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "Причина"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(245, 141)
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(316, 20)
        Me.txtReason.TabIndex = 49
        '
        'frmWorker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 211)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtOtdel)
        Me.Controls.Add(Me.txtDataUv)
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
        Me.Text = "frmWorker"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtId As TextBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents txtSimPolog As TextBox
    Friend WithEvents txtStagO As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Private WithEvents txtOsv As TextBox
    Friend WithEvents txtDolgn As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtAdress As TextBox
    Friend WithEvents txtFIO As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDataUv As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOtdel As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtReason As TextBox
End Class
