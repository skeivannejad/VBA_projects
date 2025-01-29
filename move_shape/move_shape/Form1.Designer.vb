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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        PicAirplane = New PictureBox()
        PicCenterBtn = New PictureBox()
        PicUpBtn = New PictureBox()
        PanelOrder = New Panel()
        BtnZoomOut = New PictureBox()
        BtnZoomIn = New PictureBox()
        TableLayoutPanel1 = New TableLayoutPanel()
        PicLeftBtn = New PictureBox()
        PicDownBtn = New PictureBox()
        PicRightBtn = New PictureBox()
        CType(PicAirplane, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicCenterBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicUpBtn, ComponentModel.ISupportInitialize).BeginInit()
        PanelOrder.SuspendLayout()
        CType(BtnZoomOut, ComponentModel.ISupportInitialize).BeginInit()
        CType(BtnZoomIn, ComponentModel.ISupportInitialize).BeginInit()
        TableLayoutPanel1.SuspendLayout()
        CType(PicLeftBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicDownBtn, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicRightBtn, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PicAirplane
        ' 
        PicAirplane.Image = My.Resources.Resources.Untitled
        PicAirplane.Location = New Point(453, 180)
        PicAirplane.Name = "PicAirplane"
        PicAirplane.Size = New Size(173, 108)
        PicAirplane.SizeMode = PictureBoxSizeMode.Zoom
        PicAirplane.TabIndex = 1
        PicAirplane.TabStop = False
        ' 
        ' PicCenterBtn
        ' 
        PicCenterBtn.Dock = DockStyle.Fill
        PicCenterBtn.Image = My.Resources.Resources.center
        PicCenterBtn.Location = New Point(39, 39)
        PicCenterBtn.Margin = New Padding(0)
        PicCenterBtn.Name = "PicCenterBtn"
        PicCenterBtn.Size = New Size(39, 39)
        PicCenterBtn.SizeMode = PictureBoxSizeMode.StretchImage
        PicCenterBtn.TabIndex = 3
        PicCenterBtn.TabStop = False
        ' 
        ' PicUpBtn
        ' 
        PicUpBtn.Dock = DockStyle.Fill
        PicUpBtn.Image = CType(resources.GetObject("PicUpBtn.Image"), Image)
        PicUpBtn.Location = New Point(39, 0)
        PicUpBtn.Margin = New Padding(0)
        PicUpBtn.Name = "PicUpBtn"
        PicUpBtn.Size = New Size(39, 39)
        PicUpBtn.SizeMode = PictureBoxSizeMode.StretchImage
        PicUpBtn.TabIndex = 3
        PicUpBtn.TabStop = False
        ' 
        ' PanelOrder
        ' 
        PanelOrder.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(255))
        PanelOrder.Controls.Add(BtnZoomOut)
        PanelOrder.Controls.Add(BtnZoomIn)
        PanelOrder.Controls.Add(TableLayoutPanel1)
        PanelOrder.Dock = DockStyle.Left
        PanelOrder.Location = New Point(0, 0)
        PanelOrder.Name = "PanelOrder"
        PanelOrder.Size = New Size(185, 452)
        PanelOrder.TabIndex = 5
        ' 
        ' BtnZoomOut
        ' 
        BtnZoomOut.Image = My.Resources.Resources.zoom_out2
        BtnZoomOut.Location = New Point(93, 209)
        BtnZoomOut.Name = "BtnZoomOut"
        BtnZoomOut.Size = New Size(53, 50)
        BtnZoomOut.SizeMode = PictureBoxSizeMode.Zoom
        BtnZoomOut.TabIndex = 6
        BtnZoomOut.TabStop = False
        ' 
        ' BtnZoomIn
        ' 
        BtnZoomIn.Image = My.Resources.Resources.zoom_in2
        BtnZoomIn.Location = New Point(26, 209)
        BtnZoomIn.Name = "BtnZoomIn"
        BtnZoomIn.Size = New Size(53, 50)
        BtnZoomIn.SizeMode = PictureBoxSizeMode.Zoom
        BtnZoomIn.TabIndex = 6
        BtnZoomIn.TabStop = False
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 3
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Controls.Add(PicCenterBtn, 1, 1)
        TableLayoutPanel1.Controls.Add(PicUpBtn, 1, 0)
        TableLayoutPanel1.Controls.Add(PicLeftBtn, 0, 1)
        TableLayoutPanel1.Controls.Add(PicDownBtn, 1, 2)
        TableLayoutPanel1.Controls.Add(PicRightBtn, 2, 1)
        TableLayoutPanel1.Location = New Point(26, 300)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 3
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
        TableLayoutPanel1.Size = New Size(120, 120)
        TableLayoutPanel1.TabIndex = 6
        ' 
        ' PicLeftBtn
        ' 
        PicLeftBtn.Dock = DockStyle.Fill
        PicLeftBtn.Image = My.Resources.Resources.arrowKeyLeft
        PicLeftBtn.Location = New Point(0, 39)
        PicLeftBtn.Margin = New Padding(0)
        PicLeftBtn.Name = "PicLeftBtn"
        PicLeftBtn.Size = New Size(39, 39)
        PicLeftBtn.SizeMode = PictureBoxSizeMode.StretchImage
        PicLeftBtn.TabIndex = 3
        PicLeftBtn.TabStop = False
        ' 
        ' PicDownBtn
        ' 
        PicDownBtn.Dock = DockStyle.Fill
        PicDownBtn.Image = My.Resources.Resources.arrowKeyDown
        PicDownBtn.Location = New Point(39, 78)
        PicDownBtn.Margin = New Padding(0)
        PicDownBtn.Name = "PicDownBtn"
        PicDownBtn.Size = New Size(39, 42)
        PicDownBtn.SizeMode = PictureBoxSizeMode.StretchImage
        PicDownBtn.TabIndex = 3
        PicDownBtn.TabStop = False
        ' 
        ' PicRightBtn
        ' 
        PicRightBtn.Dock = DockStyle.Fill
        PicRightBtn.Image = My.Resources.Resources.arrowKeyRight
        PicRightBtn.Location = New Point(78, 39)
        PicRightBtn.Margin = New Padding(0)
        PicRightBtn.Name = "PicRightBtn"
        PicRightBtn.Size = New Size(42, 39)
        PicRightBtn.SizeMode = PictureBoxSizeMode.StretchImage
        PicRightBtn.TabIndex = 3
        PicRightBtn.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(855, 452)
        Controls.Add(PanelOrder)
        Controls.Add(PicAirplane)
        Name = "Form1"
        Text = "Form1"
        CType(PicAirplane, ComponentModel.ISupportInitialize).EndInit()
        CType(PicCenterBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PicUpBtn, ComponentModel.ISupportInitialize).EndInit()
        PanelOrder.ResumeLayout(False)
        CType(BtnZoomOut, ComponentModel.ISupportInitialize).EndInit()
        CType(BtnZoomIn, ComponentModel.ISupportInitialize).EndInit()
        TableLayoutPanel1.ResumeLayout(False)
        CType(PicLeftBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PicDownBtn, ComponentModel.ISupportInitialize).EndInit()
        CType(PicRightBtn, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents PicAirplane As PictureBox
    Friend WithEvents PicCenterBtn As PictureBox
    Friend WithEvents PicUpBtn As PictureBox
    Friend WithEvents PanelOrder As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PicLeftBtn As PictureBox
    Friend WithEvents PicDownBtn As PictureBox
    Friend WithEvents PicRightBtn As PictureBox
    Friend WithEvents BtnZoomOut As PictureBox
    Friend WithEvents BtnZoomIn As PictureBox
End Class
