<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.showBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.bgBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CheckBox1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(848, 496)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.PictureBox1, 2)
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(842, 440)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 449)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(70, 20)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Stretch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.showBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.clearBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.bgBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.closeBtn)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(130, 449)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(715, 44)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'showBtn
        '
        Me.showBtn.AutoSize = True
        Me.showBtn.Location = New System.Drawing.Point(608, 3)
        Me.showBtn.Name = "showBtn"
        Me.showBtn.Size = New System.Drawing.Size(104, 26)
        Me.showBtn.TabIndex = 0
        Me.showBtn.Text = "Show a picture"
        Me.showBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.AutoSize = True
        Me.clearBtn.Location = New System.Drawing.Point(489, 3)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(113, 26)
        Me.clearBtn.TabIndex = 1
        Me.clearBtn.Text = "Clear the picture"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'bgBtn
        '
        Me.bgBtn.AutoSize = True
        Me.bgBtn.Location = New System.Drawing.Point(301, 3)
        Me.bgBtn.Name = "bgBtn"
        Me.bgBtn.Size = New System.Drawing.Size(182, 26)
        Me.bgBtn.TabIndex = 2
        Me.bgBtn.Text = "Set The Background Colour"
        Me.bgBtn.UseVisualStyleBackColor = True
        '
        'closeBtn
        '
        Me.closeBtn.AutoSize = True
        Me.closeBtn.Location = New System.Drawing.Point(220, 3)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(75, 26)
        Me.closeBtn.TabIndex = 3
        Me.closeBtn.Text = "Close"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" &
    "s (*.*)|*.*"
        Me.OpenFileDialog1.Title = "Select a picture file"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 496)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Form1"
        Me.Text = "Picture Viewer"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents showBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents bgBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
End Class
