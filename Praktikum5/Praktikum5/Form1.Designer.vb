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
        Listbox1 = New ListBox()
        Bfor = New Button()
        Bwhile = New Button()
        Buntil = New Button()
        Bkeluar = New Button()
        SuspendLayout()
        ' 
        ' Listbox1
        ' 
        Listbox1.FormattingEnabled = True
        Listbox1.ItemHeight = 15
        Listbox1.Location = New Point(75, 28)
        Listbox1.Name = "Listbox1"
        Listbox1.Size = New Size(202, 304)
        Listbox1.TabIndex = 0
        ' 
        ' Bfor
        ' 
        Bfor.Location = New Point(318, 28)
        Bfor.Name = "Bfor"
        Bfor.Size = New Size(75, 23)
        Bfor.TabIndex = 1
        Bfor.Text = "For Next"
        Bfor.UseVisualStyleBackColor = True
        ' 
        ' Bwhile
        ' 
        Bwhile.Location = New Point(318, 70)
        Bwhile.Name = "Bwhile"
        Bwhile.Size = New Size(75, 23)
        Bwhile.TabIndex = 2
        Bwhile.Text = "Do While"
        Bwhile.UseVisualStyleBackColor = True
        ' 
        ' Buntil
        ' 
        Buntil.Location = New Point(318, 110)
        Buntil.Name = "Buntil"
        Buntil.Size = New Size(75, 23)
        Buntil.TabIndex = 3
        Buntil.Text = "Do Until"
        Buntil.UseVisualStyleBackColor = True
        ' 
        ' Bkeluar
        ' 
        Bkeluar.Location = New Point(318, 164)
        Bkeluar.Name = "Bkeluar"
        Bkeluar.Size = New Size(75, 23)
        Bkeluar.TabIndex = 4
        Bkeluar.Text = "Keluar"
        Bkeluar.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Bkeluar)
        Controls.Add(Buntil)
        Controls.Add(Bwhile)
        Controls.Add(Bfor)
        Controls.Add(Listbox1)
        Name = "Form1"
        Text = "Frmpengulangan2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Listbox1 As ListBox
    Friend WithEvents Bfor As Button
    Friend WithEvents Bwhile As Button
    Friend WithEvents Buntil As Button
    Friend WithEvents Bkeluar As Button

End Class
