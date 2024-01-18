<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(234, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 25)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(234, 80)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 25)
        Label2.TabIndex = 0
        Label2.Text = "Surname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(251, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 25)
        Label3.TabIndex = 0
        Label3.Text = "Age"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(234, 163)
        Label4.Name = "Label4"
        Label4.Size = New Size(99, 25)
        Label4.TabIndex = 0
        Label4.Text = "Profession"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(234, 208)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 25)
        Label5.TabIndex = 0
        Label5.Text = "Gender"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(432, 38)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(165, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(432, 74)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(165, 31)
        TextBox2.TabIndex = 1
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(432, 119)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(165, 31)
        TextBox3.TabIndex = 1
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Police", "Nurse", "Doctor", "Soldier", "Unemployed"})
        ComboBox1.Location = New Point(432, 169)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(200, 33)
        ComboBox1.TabIndex = 2
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(432, 208)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(79, 29)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(432, 243)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(97, 29)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(432, 278)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(85, 29)
        RadioButton3.TabIndex = 3
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(194, 363)
        Button1.Name = "Button1"
        Button1.Size = New Size(232, 34)
        Button1.TabIndex = 4
        Button1.Text = "Welcome Button"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(509, 363)
        Button2.Name = "Button2"
        Button2.Size = New Size(123, 34)
        Button2.TabIndex = 4
        Button2.Text = "Close"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Mistral", 17F)
        Label6.ForeColor = SystemColors.MenuHighlight
        Label6.Location = New Point(305, -3)
        Label6.Name = "Label6"
        Label6.Size = New Size(358, 41)
        Label6.TabIndex = 5
        Label6.Text = "WELCOME TO MINDWORX LMS"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(11F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Red
        ClientSize = New Size(880, 450)
        Controls.Add(Label6)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9F, FontStyle.Bold Or FontStyle.Italic)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label

End Class
