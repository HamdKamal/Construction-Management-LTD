<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About_pro
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About_pro))
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.picSPLASH = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.bttnInfo = New System.Windows.Forms.Button()
        Me.bttnOK = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.picLOGO = New System.Windows.Forms.PictureBox()
        Me.picHeader = New System.Windows.Forms.PictureBox()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSPLASH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLOGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox2
        '
        Me.pictureBox2.BackColor = System.Drawing.Color.White
        Me.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(5, 88)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(139, 200)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pictureBox2.TabIndex = 37
        Me.pictureBox2.TabStop = False
        '
        'pictureBox1
        '
        Me.pictureBox1.BackColor = System.Drawing.Color.White
        Me.pictureBox1.Location = New System.Drawing.Point(145, 88)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(340, 24)
        Me.pictureBox1.TabIndex = 36
        Me.pictureBox1.TabStop = False
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.White
        Me.label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(150, 115)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(315, 173)
        Me.label3.TabIndex = 35
        Me.label3.Text = resources.GetString("label3.Text")
        '
        'picSPLASH
        '
        Me.picSPLASH.BackColor = System.Drawing.Color.White
        Me.picSPLASH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picSPLASH.Location = New System.Drawing.Point(8, 88)
        Me.picSPLASH.Name = "picSPLASH"
        Me.picSPLASH.Size = New System.Drawing.Size(477, 200)
        Me.picSPLASH.TabIndex = 34
        Me.picSPLASH.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.Transparent
        Me.lblHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblHeader.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.Black
        Me.lblHeader.Location = New System.Drawing.Point(40, 52)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(142, 19)
        Me.lblHeader.TabIndex = 30
        Me.lblHeader.Text = "Product Information"
        '
        'bttnInfo
        '
        Me.bttnInfo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnInfo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bttnInfo.Location = New System.Drawing.Point(377, 366)
        Me.bttnInfo.Name = "bttnInfo"
        Me.bttnInfo.Size = New System.Drawing.Size(96, 23)
        Me.bttnInfo.TabIndex = 28
        Me.bttnInfo.Text = "&System Info..."
        '
        'bttnOK
        '
        Me.bttnOK.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bttnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.bttnOK.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bttnOK.Location = New System.Drawing.Point(377, 334)
        Me.bttnOK.Name = "bttnOK"
        Me.bttnOK.Size = New System.Drawing.Size(96, 25)
        Me.bttnOK.TabIndex = 33
        Me.bttnOK.Text = "&OK"
        '
        'label1
        '
        Me.label1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.Brown
        Me.label1.Location = New System.Drawing.Point(12, 334)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(359, 55)
        Me.label1.TabIndex = 32
        Me.label1.Text = "Warning: This software is copyright 2018  by SmartVision IT. Any form of selling " & _
    "or reproduction of this software without permission from the author is strictly " & _
    "prohibited."
        '
        'picLOGO
        '
        Me.picLOGO.Image = CType(resources.GetObject("picLOGO.Image"), System.Drawing.Image)
        Me.picLOGO.Location = New System.Drawing.Point(16, 48)
        Me.picLOGO.Name = "picLOGO"
        Me.picLOGO.Size = New System.Drawing.Size(24, 24)
        Me.picLOGO.TabIndex = 31
        Me.picLOGO.TabStop = False
        '
        'picHeader
        '
        Me.picHeader.BackColor = System.Drawing.Color.Transparent
        Me.picHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.picHeader.Location = New System.Drawing.Point(0, 0)
        Me.picHeader.Name = "picHeader"
        Me.picHeader.Size = New System.Drawing.Size(485, 30)
        Me.picHeader.TabIndex = 29
        Me.picHeader.TabStop = False
        '
        'About_pro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 402)
        Me.Controls.Add(Me.pictureBox2)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.picSPLASH)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.bttnInfo)
        Me.Controls.Add(Me.bttnOK)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.picLOGO)
        Me.Controls.Add(Me.picHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "About_pro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About_Project ..."
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSPLASH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLOGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHeader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents pictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents picSPLASH As System.Windows.Forms.PictureBox
    Private WithEvents lblHeader As System.Windows.Forms.Label
    Private WithEvents bttnInfo As System.Windows.Forms.Button
    Private WithEvents bttnOK As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents picLOGO As System.Windows.Forms.PictureBox
    Private WithEvents picHeader As System.Windows.Forms.PictureBox
End Class
