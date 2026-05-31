<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.QuickStartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.DF1COM = New AdvancedHMIDrivers.SerialDF1forPLC5Com(Me.components)
        Me.BasicLabel2 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel0 = New AdvancedHMIControls.BasicLabel()
        Me.BasicLabel1 = New AdvancedHMIControls.BasicLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DF1COM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'QuickStartLabel
        '
        Me.QuickStartLabel.AutoSize = True
        Me.QuickStartLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        Me.QuickStartLabel.ForeColor = System.Drawing.Color.White
        Me.QuickStartLabel.Location = New System.Drawing.Point(12, 9)
        Me.QuickStartLabel.Name = "QuickStartLabel"
        Me.QuickStartLabel.Size = New System.Drawing.Size(350, 136)
        Me.QuickStartLabel.TabIndex = 38
        Me.QuickStartLabel.Text = resources.GetString("QuickStartLabel.Text")
        Me.QuickStartLabel.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(449, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(322, 47)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'DF1COM
        '
        Me.DF1COM.BaudRate = "9600"
        Me.DF1COM.CheckSumType = MfgControl.AdvancedHMI.Drivers.DF1Transport.ChecksumOption.Crc
        Me.DF1COM.ComPort = "COM2"
        Me.DF1COM.DisableSubscriptions = False
        Me.DF1COM.IniFileName = ""
        Me.DF1COM.IniFileSection = Nothing
        Me.DF1COM.IsPLC5 = False
        Me.DF1COM.MyNode = 0
        Me.DF1COM.Parity = System.IO.Ports.Parity.None
        Me.DF1COM.PollRateOverride = 500
        Me.DF1COM.TargetNode = 0
        '
        'BasicLabel2
        '
        Me.BasicLabel2.AutoSize = True
        Me.BasicLabel2.BackColor = System.Drawing.Color.Black
        Me.BasicLabel2.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel2.ComComponent = Me.DF1COM
        Me.BasicLabel2.DisplayAsTime = False
        Me.BasicLabel2.ForeColor = System.Drawing.Color.White
        Me.BasicLabel2.Highlight = False
        Me.BasicLabel2.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel2.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel2.HighlightKeyCharacter = "!"
        Me.BasicLabel2.KeypadAlphaNumeric = False
        Me.BasicLabel2.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel2.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel2.KeypadMaxValue = 0R
        Me.BasicLabel2.KeypadMinValue = 0R
        Me.BasicLabel2.KeypadScaleFactor = 1.0R
        Me.BasicLabel2.KeypadShowCurrentValue = False
        Me.BasicLabel2.KeypadText = Nothing
        Me.BasicLabel2.KeypadWidth = 300
        Me.BasicLabel2.Location = New System.Drawing.Point(541, 145)
        Me.BasicLabel2.Name = "BasicLabel2"
        Me.BasicLabel2.NumericFormat = Nothing
        Me.BasicLabel2.PLCAddressKeypad = ""
        Me.BasicLabel2.PollRate = 0
        Me.BasicLabel2.Size = New System.Drawing.Size(96, 17)
        Me.BasicLabel2.TabIndex = 45
        Me.BasicLabel2.Text = "BasicLabel2"
        Me.BasicLabel2.Value = "BasicLabel2"
        Me.BasicLabel2.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel2.ValueLeftPadLength = 0
        Me.BasicLabel2.ValuePrefix = Nothing
        Me.BasicLabel2.ValueScaleFactor = 1.0R
        Me.BasicLabel2.ValueSuffix = Nothing
        '
        'BasicLabel0
        '
        Me.BasicLabel0.AutoSize = True
        Me.BasicLabel0.BackColor = System.Drawing.Color.Black
        Me.BasicLabel0.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel0.ComComponent = Me.DF1COM
        Me.BasicLabel0.DisplayAsTime = False
        Me.BasicLabel0.ForeColor = System.Drawing.Color.White
        Me.BasicLabel0.Highlight = False
        Me.BasicLabel0.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel0.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel0.HighlightKeyCharacter = "!"
        Me.BasicLabel0.KeypadAlphaNumeric = False
        Me.BasicLabel0.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel0.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel0.KeypadMaxValue = 0R
        Me.BasicLabel0.KeypadMinValue = 0R
        Me.BasicLabel0.KeypadScaleFactor = 1.0R
        Me.BasicLabel0.KeypadShowCurrentValue = False
        Me.BasicLabel0.KeypadText = Nothing
        Me.BasicLabel0.KeypadWidth = 300
        Me.BasicLabel0.Location = New System.Drawing.Point(286, 182)
        Me.BasicLabel0.Name = "BasicLabel0"
        Me.BasicLabel0.NumericFormat = Nothing
        Me.BasicLabel0.PLCAddressKeypad = ""
        Me.BasicLabel0.PLCAddressValue = "F8:2"
        Me.BasicLabel0.PollRate = 0
        Me.BasicLabel0.Size = New System.Drawing.Size(96, 17)
        Me.BasicLabel0.TabIndex = 43
        Me.BasicLabel0.Text = "BasicLabel0"
        Me.BasicLabel0.Value = "BasicLabel0"
        Me.BasicLabel0.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel0.ValueLeftPadLength = 0
        Me.BasicLabel0.ValuePrefix = Nothing
        Me.BasicLabel0.ValueScaleFactor = 1.0R
        Me.BasicLabel0.ValueSuffix = Nothing
        '
        'BasicLabel1
        '
        Me.BasicLabel1.AutoSize = True
        Me.BasicLabel1.BackColor = System.Drawing.Color.Black
        Me.BasicLabel1.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.BasicLabel1.ComComponent = Me.DF1COM
        Me.BasicLabel1.DisplayAsTime = False
        Me.BasicLabel1.ForeColor = System.Drawing.Color.White
        Me.BasicLabel1.Highlight = False
        Me.BasicLabel1.HighlightColor = System.Drawing.Color.Red
        Me.BasicLabel1.HighlightForeColor = System.Drawing.Color.White
        Me.BasicLabel1.HighlightKeyCharacter = "!"
        Me.BasicLabel1.KeypadAlphaNumeric = False
        Me.BasicLabel1.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.BasicLabel1.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.BasicLabel1.KeypadMaxValue = 0R
        Me.BasicLabel1.KeypadMinValue = 0R
        Me.BasicLabel1.KeypadScaleFactor = 1.0R
        Me.BasicLabel1.KeypadShowCurrentValue = False
        Me.BasicLabel1.KeypadText = Nothing
        Me.BasicLabel1.KeypadWidth = 300
        Me.BasicLabel1.Location = New System.Drawing.Point(541, 182)
        Me.BasicLabel1.Name = "BasicLabel1"
        Me.BasicLabel1.NumericFormat = Nothing
        Me.BasicLabel1.PLCAddressKeypad = ""
        Me.BasicLabel1.PollRate = 0
        Me.BasicLabel1.Size = New System.Drawing.Size(96, 17)
        Me.BasicLabel1.TabIndex = 47
        Me.BasicLabel1.Text = "BasicLabel1"
        Me.BasicLabel1.Value = "BasicLabel1"
        Me.BasicLabel1.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.BasicLabel1.ValueLeftPadLength = 0
        Me.BasicLabel1.ValuePrefix = Nothing
        Me.BasicLabel1.ValueScaleFactor = 1.0R
        Me.BasicLabel1.ValueSuffix = Nothing
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(783, 288)
        Me.Controls.Add(Me.BasicLabel1)
        Me.Controls.Add(Me.BasicLabel2)
        Me.Controls.Add(Me.BasicLabel0)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.QuickStartLabel)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99p"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DF1COM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents QuickStartLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents BasicLabel0 As AdvancedHMIControls.BasicLabel
    Friend WithEvents DF1COM As AdvancedHMIDrivers.SerialDF1forPLC5Com
    Friend WithEvents BasicLabel2 As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicLabel1 As AdvancedHMIControls.BasicLabel
End Class
