<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits MetroFramework.Forms.MetroForm

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtFolderDir = New MetroFramework.Controls.MetroTextBox()
        Me.btnBrowse = New MetroFramework.Controls.MetroButton()
        Me.btnLoad = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.btnConvert = New MetroFramework.Controls.MetroButton()
        Me.ImageList = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.grdImageList = New MetroFramework.Controls.MetroGrid()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.lbPreviewCount = New MetroFramework.Controls.MetroLabel()
        Me.btnNext = New MetroFramework.Controls.MetroButton()
        Me.btnPrevious = New MetroFramework.Controls.MetroButton()
        Me.pbPreview = New System.Windows.Forms.PictureBox()
        Me.progressBar = New MetroFramework.Controls.MetroProgressBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.cbbSizeMode = New MetroFramework.Controls.MetroComboBox()
        Me.MetroStyleManager1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.MetroToolTip1 = New MetroFramework.Components.MetroToolTip()
        Me.MetroPanel1.SuspendLayout()
        Me.ImageList.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        CType(Me.grdImageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.txtFolderDir)
        Me.MetroPanel1.Controls.Add(Me.btnBrowse)
        Me.MetroPanel1.Controls.Add(Me.btnLoad)
        Me.MetroPanel1.Controls.Add(Me.btnSave)
        Me.MetroPanel1.Controls.Add(Me.btnConvert)
        Me.MetroPanel1.Controls.Add(Me.ImageList)
        Me.MetroPanel1.Controls.Add(Me.progressBar)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(20, 60)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(722, 504)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtFolderDir
        '
        '
        '
        '
        Me.txtFolderDir.CustomButton.Image = Nothing
        Me.txtFolderDir.CustomButton.Location = New System.Drawing.Point(286, 1)
        Me.txtFolderDir.CustomButton.Name = ""
        Me.txtFolderDir.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFolderDir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFolderDir.CustomButton.TabIndex = 1
        Me.txtFolderDir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFolderDir.CustomButton.UseSelectable = True
        Me.txtFolderDir.CustomButton.Visible = False
        Me.txtFolderDir.Lines = New String(-1) {}
        Me.txtFolderDir.Location = New System.Drawing.Point(23, 438)
        Me.txtFolderDir.MaxLength = 32767
        Me.txtFolderDir.Name = "txtFolderDir"
        Me.txtFolderDir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFolderDir.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFolderDir.SelectedText = ""
        Me.txtFolderDir.SelectionLength = 0
        Me.txtFolderDir.SelectionStart = 0
        Me.txtFolderDir.ShortcutsEnabled = True
        Me.txtFolderDir.Size = New System.Drawing.Size(308, 23)
        Me.txtFolderDir.TabIndex = 5
        Me.txtFolderDir.UseSelectable = True
        Me.txtFolderDir.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFolderDir.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(337, 438)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(87, 23)
        Me.btnBrowse.TabIndex = 4
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseSelectable = True
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(462, 438)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(87, 23)
        Me.btnLoad.TabIndex = 4
        Me.btnLoad.Text = "Load List"
        Me.MetroToolTip1.SetToolTip(Me.btnLoad, "Load all images inside folder into a list.")
        Me.btnLoad.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(632, 438)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(67, 23)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.MetroToolTip1.SetToolTip(Me.btnSave, "Drop image into temple and save.")
        Me.btnSave.UseSelectable = True
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(555, 438)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(71, 23)
        Me.btnConvert.TabIndex = 4
        Me.btnConvert.Text = "Preload"
        Me.MetroToolTip1.SetToolTip(Me.btnConvert, "Preload will increase your preview speed but will cost more ram.")
        Me.btnConvert.UseSelectable = True
        '
        'ImageList
        '
        Me.ImageList.Controls.Add(Me.MetroTabPage1)
        Me.ImageList.Controls.Add(Me.MetroTabPage2)
        Me.ImageList.Location = New System.Drawing.Point(3, 3)
        Me.ImageList.Name = "ImageList"
        Me.ImageList.SelectedIndex = 0
        Me.ImageList.Size = New System.Drawing.Size(716, 429)
        Me.ImageList.TabIndex = 3
        Me.ImageList.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.Controls.Add(Me.grdImageList)
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.Size = New System.Drawing.Size(708, 387)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "ImageList"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'grdImageList
        '
        Me.grdImageList.AllowUserToResizeRows = False
        Me.grdImageList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdImageList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdImageList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grdImageList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdImageList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdImageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdImageList.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdImageList.EnableHeadersVisualStyles = False
        Me.grdImageList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.grdImageList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.grdImageList.Location = New System.Drawing.Point(3, 3)
        Me.grdImageList.Name = "grdImageList"
        Me.grdImageList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdImageList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grdImageList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdImageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdImageList.Size = New System.Drawing.Size(702, 372)
        Me.grdImageList.TabIndex = 2
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.Controls.Add(Me.lbPreviewCount)
        Me.MetroTabPage2.Controls.Add(Me.btnNext)
        Me.MetroTabPage2.Controls.Add(Me.btnPrevious)
        Me.MetroTabPage2.Controls.Add(Me.pbPreview)
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(708, 387)
        Me.MetroTabPage2.TabIndex = 1
        Me.MetroTabPage2.Text = "Preview"
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'lbPreviewCount
        '
        Me.lbPreviewCount.AutoSize = True
        Me.lbPreviewCount.Location = New System.Drawing.Point(339, 356)
        Me.lbPreviewCount.Name = "lbPreviewCount"
        Me.lbPreviewCount.Size = New System.Drawing.Size(28, 19)
        Me.lbPreviewCount.TabIndex = 4
        Me.lbPreviewCount.Text = "0/0"
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.Transparent
        Me.btnNext.BackgroundImage = Global.CardMaker.My.Resources.Resources.arrow_right
        Me.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNext.Location = New System.Drawing.Point(521, 152)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(70, 70)
        Me.btnNext.TabIndex = 3
        Me.btnNext.UseSelectable = True
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.Transparent
        Me.btnPrevious.BackgroundImage = Global.CardMaker.My.Resources.Resources.arrow_left
        Me.btnPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrevious.Location = New System.Drawing.Point(130, 152)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(70, 70)
        Me.btnPrevious.TabIndex = 3
        Me.btnPrevious.UseSelectable = True
        '
        'pbPreview
        '
        Me.pbPreview.Location = New System.Drawing.Point(233, 3)
        Me.pbPreview.Name = "pbPreview"
        Me.pbPreview.Size = New System.Drawing.Size(248, 350)
        Me.pbPreview.TabIndex = 2
        Me.pbPreview.TabStop = False
        '
        'progressBar
        '
        Me.progressBar.Location = New System.Drawing.Point(3, 478)
        Me.progressBar.Name = "progressBar"
        Me.progressBar.Size = New System.Drawing.Size(716, 23)
        Me.progressBar.TabIndex = 2
        '
        'cbbSizeMode
        '
        Me.cbbSizeMode.FormattingEnabled = True
        Me.cbbSizeMode.ItemHeight = 23
        Me.cbbSizeMode.Items.AddRange(New Object() {"Fate (Standard Size)", "Yugioh Size"})
        Me.cbbSizeMode.Location = New System.Drawing.Point(157, 25)
        Me.cbbSizeMode.Name = "cbbSizeMode"
        Me.cbbSizeMode.Size = New System.Drawing.Size(164, 29)
        Me.cbbSizeMode.TabIndex = 1
        Me.cbbSizeMode.UseSelectable = True
        '
        'MetroStyleManager1
        '
        Me.MetroStyleManager1.Owner = Me
        Me.MetroStyleManager1.Style = MetroFramework.MetroColorStyle.Purple
        '
        'MetroToolTip1
        '
        Me.MetroToolTip1.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroToolTip1.StyleManager = Nothing
        Me.MetroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(777, 584)
        Me.Controls.Add(Me.cbbSizeMode)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Style = MetroFramework.MetroColorStyle.Purple
        Me.Text = "Card Maker"
        Me.MetroPanel1.ResumeLayout(False)
        Me.ImageList.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        CType(Me.grdImageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.pbPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MetroStyleManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents btnConvert As MetroFramework.Controls.MetroButton
    Friend WithEvents ImageList As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents grdImageList As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents pbPreview As PictureBox
    Friend WithEvents progressBar As MetroFramework.Controls.MetroProgressBar
    Friend WithEvents btnLoad As MetroFramework.Controls.MetroButton
    Friend WithEvents txtFolderDir As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBrowse As MetroFramework.Controls.MetroButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents cbbSizeMode As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroStyleManager1 As MetroFramework.Components.MetroStyleManager
    Friend WithEvents btnNext As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPrevious As MetroFramework.Controls.MetroButton
    Friend WithEvents lbPreviewCount As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroToolTip1 As MetroFramework.Components.MetroToolTip
End Class
