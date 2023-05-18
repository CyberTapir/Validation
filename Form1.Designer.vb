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
        lstDebug = New ListBox()
        txtInput = New TextBox()
        btnExtract = New Button()
        SuspendLayout()
        ' 
        ' lstDebug
        ' 
        lstDebug.FormattingEnabled = True
        lstDebug.ItemHeight = 15
        lstDebug.Location = New Point(384, 182)
        lstDebug.Name = "lstDebug"
        lstDebug.Size = New Size(120, 94)
        lstDebug.TabIndex = 0
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(187, 110)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(100, 23)
        txtInput.TabIndex = 1
        ' 
        ' btnExtract
        ' 
        btnExtract.Location = New Point(200, 299)
        btnExtract.Name = "btnExtract"
        btnExtract.Size = New Size(75, 23)
        btnExtract.TabIndex = 2
        btnExtract.Text = "Button1"
        btnExtract.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExtract)
        Controls.Add(txtInput)
        Controls.Add(lstDebug)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstDebug As ListBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnExtract As Button
End Class
