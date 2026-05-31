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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.DF1COM = New AdvancedHMIDrivers.SerialDF1forPLC5Com(Me.components)
        Me.Status = New AdvancedHMIControls.BasicLabel()
        Me.WaterPump1 = New AdvancedHMIControls.WaterPump()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight2 = New AdvancedHMIControls.PilotLight()
        Me.PilotLight3 = New AdvancedHMIControls.PilotLight()
        Me.Reset = New AdvancedHMIControls.BasicButton()
        Me.Silence = New AdvancedHMIControls.BasicButton()
        Me.Pressure = New AdvancedHMIControls.BasicLabel()
        Me.HAND = New AdvancedHMIControls.BasicButton()
        Me.OFF = New AdvancedHMIControls.BasicButton()
        Me.AUT = New AdvancedHMIControls.BasicButton()
        Me.HOA = New AdvancedHMIControls.MessageDisplayByValue()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DF1COM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(195, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(213, 12)
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
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.BackColor = System.Drawing.Color.Black
        Me.Status.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Status.ComComponent = Me.DF1COM
        Me.Status.DisplayAsTime = False
        Me.Status.ForeColor = System.Drawing.Color.White
        Me.Status.Highlight = False
        Me.Status.HighlightColor = System.Drawing.Color.Red
        Me.Status.HighlightForeColor = System.Drawing.Color.White
        Me.Status.HighlightKeyCharacter = "!"
        Me.Status.KeypadAlphaNumeric = False
        Me.Status.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Status.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Status.KeypadMaxValue = 0R
        Me.Status.KeypadMinValue = 0R
        Me.Status.KeypadScaleFactor = 1.0R
        Me.Status.KeypadShowCurrentValue = False
        Me.Status.KeypadText = Nothing
        Me.Status.KeypadWidth = 300
        Me.Status.Location = New System.Drawing.Point(46, 25)
        Me.Status.Name = "Status"
        Me.Status.NumericFormat = Nothing
        Me.Status.PLCAddressKeypad = ""
        Me.Status.PollRate = 0
        Me.Status.Size = New System.Drawing.Size(54, 17)
        Me.Status.TabIndex = 47
        Me.Status.Text = "Status"
        Me.Status.Value = "Status"
        Me.Status.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Status.ValueLeftPadLength = 0
        Me.Status.ValuePrefix = Nothing
        Me.Status.ValueScaleFactor = 1.0R
        Me.Status.ValueSuffix = Nothing
        '
        'WaterPump1
        '
        Me.WaterPump1.ComComponent = Me.DF1COM
        Me.WaterPump1.Location = New System.Drawing.Point(225, 70)
        Me.WaterPump1.Name = "WaterPump1"
        Me.WaterPump1.PLCAddressText = "O:0.0/0"
        Me.WaterPump1.PLCAddressValue = ""
        Me.WaterPump1.PLCAddressVisible = "O:0.0/0"
        Me.WaterPump1.Size = New System.Drawing.Size(216, 84)
        Me.WaterPump1.TabIndex = 48
        Me.WaterPump1.Text = "WaterPump1"
        Me.WaterPump1.Value = False
        '
        'PilotLight1
        '
        Me.PilotLight1.BackColor = System.Drawing.Color.Black
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.DF1COM
        Me.PilotLight1.ForeColor = System.Drawing.Color.IndianRed
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.Location = New System.Drawing.Point(177, 202)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight1.PLCAddressClick = ""
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "O:0/3"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(42, 44)
        Me.PilotLight1.TabIndex = 49
        Me.PilotLight1.Text = "Vibration"
        Me.PilotLight1.Value = False
        '
        'PilotLight2
        '
        Me.PilotLight2.Blink = False
        Me.PilotLight2.ComComponent = Me.DF1COM
        Me.PilotLight2.ForeColor = System.Drawing.Color.IndianRed
        Me.PilotLight2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight2.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight2.Location = New System.Drawing.Point(273, 203)
        Me.PilotLight2.Name = "PilotLight2"
        Me.PilotLight2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight2.PLCAddressClick = ""
        Me.PilotLight2.PLCAddressText = ""
        Me.PilotLight2.PLCAddressValue = "O:0/1"
        Me.PilotLight2.PLCAddressVisible = ""
        Me.PilotLight2.Size = New System.Drawing.Size(42, 44)
        Me.PilotLight2.TabIndex = 50
        Me.PilotLight2.Text = "Flow"
        Me.PilotLight2.Value = False
        '
        'PilotLight3
        '
        Me.PilotLight3.Blink = False
        Me.PilotLight3.ComComponent = Me.DF1COM
        Me.PilotLight3.ForeColor = System.Drawing.Color.IndianRed
        Me.PilotLight3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Small
        Me.PilotLight3.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight3.Location = New System.Drawing.Point(225, 203)
        Me.PilotLight3.Name = "PilotLight3"
        Me.PilotLight3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.PilotLight3.PLCAddressClick = ""
        Me.PilotLight3.PLCAddressText = ""
        Me.PilotLight3.PLCAddressValue = "O:0/2"
        Me.PilotLight3.PLCAddressVisible = ""
        Me.PilotLight3.Size = New System.Drawing.Size(42, 44)
        Me.PilotLight3.TabIndex = 51
        Me.PilotLight3.Text = "Pressure"
        Me.PilotLight3.Value = False
        '
        'Reset
        '
        Me.Reset.BackColor = System.Drawing.Color.IndianRed
        Me.Reset.ComComponent = Me.DF1COM
        Me.Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Reset.Highlight = False
        Me.Reset.HighlightColor = System.Drawing.Color.Green
        Me.Reset.Location = New System.Drawing.Point(377, 191)
        Me.Reset.MaximumHoldTime = 3000
        Me.Reset.MinimumHoldTime = 500
        Me.Reset.Name = "Reset"
        Me.Reset.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Reset.PLCAddressClick = "I:0/1"
        Me.Reset.SelectTextAlternate = False
        Me.Reset.Size = New System.Drawing.Size(75, 23)
        Me.Reset.TabIndex = 52
        Me.Reset.Text = "Reset"
        Me.Reset.TextAlternate = Nothing
        Me.Reset.UseVisualStyleBackColor = False
        Me.Reset.ValueToWrite = 1
        '
        'Silence
        '
        Me.Silence.BackColor = System.Drawing.Color.RosyBrown
        Me.Silence.ComComponent = Me.DF1COM
        Me.Silence.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Silence.Highlight = False
        Me.Silence.HighlightColor = System.Drawing.Color.Green
        Me.Silence.Location = New System.Drawing.Point(377, 224)
        Me.Silence.MaximumHoldTime = 3000
        Me.Silence.MinimumHoldTime = 500
        Me.Silence.Name = "Silence"
        Me.Silence.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.Silence.PLCAddressClick = "I:0/2"
        Me.Silence.SelectTextAlternate = False
        Me.Silence.Size = New System.Drawing.Size(75, 23)
        Me.Silence.TabIndex = 53
        Me.Silence.Text = "Silence"
        Me.Silence.TextAlternate = Nothing
        Me.Silence.UseVisualStyleBackColor = False
        Me.Silence.ValueToWrite = 1
        '
        'Pressure
        '
        Me.Pressure.AutoSize = True
        Me.Pressure.BackColor = System.Drawing.Color.Black
        Me.Pressure.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.Pressure.ComComponent = Me.DF1COM
        Me.Pressure.DisplayAsTime = False
        Me.Pressure.ForeColor = System.Drawing.Color.White
        Me.Pressure.Highlight = False
        Me.Pressure.HighlightColor = System.Drawing.Color.Red
        Me.Pressure.HighlightForeColor = System.Drawing.Color.White
        Me.Pressure.HighlightKeyCharacter = "!"
        Me.Pressure.KeypadAlphaNumeric = False
        Me.Pressure.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.Pressure.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.Pressure.KeypadMaxValue = 0R
        Me.Pressure.KeypadMinValue = 0R
        Me.Pressure.KeypadScaleFactor = 1.0R
        Me.Pressure.KeypadShowCurrentValue = False
        Me.Pressure.KeypadText = Nothing
        Me.Pressure.KeypadWidth = 300
        Me.Pressure.Location = New System.Drawing.Point(347, 43)
        Me.Pressure.Name = "Pressure"
        Me.Pressure.NumericFormat = Nothing
        Me.Pressure.PLCAddressKeypad = ""
        Me.Pressure.PLCAddressValue = "F8:0"
        Me.Pressure.PollRate = 0
        Me.Pressure.Size = New System.Drawing.Size(73, 17)
        Me.Pressure.TabIndex = 54
        Me.Pressure.Text = "Pressure"
        Me.Pressure.Value = "Pressure"
        Me.Pressure.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.Pressure.ValueLeftPadLength = 0
        Me.Pressure.ValuePrefix = Nothing
        Me.Pressure.ValueScaleFactor = 1.0R
        Me.Pressure.ValueSuffix = Nothing
        '
        'HAND
        '
        Me.HAND.BackColor = System.Drawing.Color.DarkGray
        Me.HAND.ComComponent = Me.DF1COM
        Me.HAND.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.HAND.Highlight = False
        Me.HAND.HighlightColor = System.Drawing.Color.Green
        Me.HAND.Location = New System.Drawing.Point(584, 80)
        Me.HAND.MaximumHoldTime = 3000
        Me.HAND.MinimumHoldTime = 500
        Me.HAND.Name = "HAND"
        Me.HAND.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.HAND.PLCAddressClick = "N7:1"
        Me.HAND.SelectTextAlternate = False
        Me.HAND.Size = New System.Drawing.Size(75, 23)
        Me.HAND.TabIndex = 55
        Me.HAND.Text = "HAND"
        Me.HAND.TextAlternate = Nothing
        Me.HAND.UseVisualStyleBackColor = False
        Me.HAND.ValueToWrite = 1
        '
        'OFF
        '
        Me.OFF.BackColor = System.Drawing.Color.DarkGray
        Me.OFF.ComComponent = Me.DF1COM
        Me.OFF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.OFF.Highlight = False
        Me.OFF.HighlightColor = System.Drawing.Color.Green
        Me.OFF.Location = New System.Drawing.Point(584, 109)
        Me.OFF.MaximumHoldTime = 3000
        Me.OFF.MinimumHoldTime = 500
        Me.OFF.Name = "OFF"
        Me.OFF.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.OFF.PLCAddressClick = "N7:1"
        Me.OFF.SelectTextAlternate = False
        Me.OFF.Size = New System.Drawing.Size(75, 23)
        Me.OFF.TabIndex = 56
        Me.OFF.Text = "OFF"
        Me.OFF.TextAlternate = Nothing
        Me.OFF.UseVisualStyleBackColor = False
        Me.OFF.ValueToWrite = 1
        '
        'AUT
        '
        Me.AUT.BackColor = System.Drawing.Color.DarkGray
        Me.AUT.ComComponent = Me.DF1COM
        Me.AUT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AUT.Highlight = False
        Me.AUT.HighlightColor = System.Drawing.Color.Green
        Me.AUT.Location = New System.Drawing.Point(584, 138)
        Me.AUT.MaximumHoldTime = 3000
        Me.AUT.MinimumHoldTime = 500
        Me.AUT.Name = "AUT"
        Me.AUT.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.AUT.PLCAddressClick = "N7:1"
        Me.AUT.SelectTextAlternate = False
        Me.AUT.Size = New System.Drawing.Size(75, 23)
        Me.AUT.TabIndex = 57
        Me.AUT.Text = "AUT"
        Me.AUT.TextAlternate = Nothing
        Me.AUT.UseVisualStyleBackColor = False
        Me.AUT.ValueToWrite = 1
        '
        'HOA
        '
        Me.HOA.AutoSize = True
        Me.HOA.ComComponent = Me.DF1COM
        Me.HOA.ForeColor = System.Drawing.Color.Transparent
        Me.HOA.HighlightColor = System.Drawing.Color.Red
        Me.HOA.HighlightColor2 = System.Drawing.Color.Red
        Me.HOA.HighlightKeyCharacter = "!"
        Me.HOA.HighlightKeyCharacter2 = "."
        Me.HOA.IniFileName = Nothing
        Me.HOA.Location = New System.Drawing.Point(482, 109)
        Me.HOA.Messages.Add(CType(resources.GetObject("HOA.Messages"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.HOA.Messages.Add(CType(resources.GetObject("HOA.Messages1"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.HOA.Messages.Add(CType(resources.GetObject("HOA.Messages2"), MfgControl.AdvancedHMI.Controls.MessageByValue))
        Me.HOA.Name = "HOA"
        Me.HOA.PLCAddressValue = "N7:1"
        Me.HOA.PLCAddressVisible = ""
        Me.HOA.ShowMessageNumber = False
        Me.HOA.Size = New System.Drawing.Size(41, 17)
        Me.HOA.SpeakMessage = False
        Me.HOA.TabIndex = 58
        Me.HOA.Text = "HOA"
        Me.HOA.TextPrefix = Nothing
        Me.HOA.Value = 0
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(672, 303)
        Me.Controls.Add(Me.HOA)
        Me.Controls.Add(Me.AUT)
        Me.Controls.Add(Me.OFF)
        Me.Controls.Add(Me.HAND)
        Me.Controls.Add(Me.Pressure)
        Me.Controls.Add(Me.Silence)
        Me.Controls.Add(Me.Reset)
        Me.Controls.Add(Me.PilotLight3)
        Me.Controls.Add(Me.PilotLight2)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.WaterPump1)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.PictureBox1)
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents DF1COM As AdvancedHMIDrivers.SerialDF1forPLC5Com
    Friend WithEvents Status As AdvancedHMIControls.BasicLabel
    Friend WithEvents WaterPump1 As AdvancedHMIControls.WaterPump
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight2 As AdvancedHMIControls.PilotLight
    Friend WithEvents PilotLight3 As AdvancedHMIControls.PilotLight
    Friend WithEvents Reset As AdvancedHMIControls.BasicButton
    Friend WithEvents Silence As AdvancedHMIControls.BasicButton
    Friend WithEvents Pressure As AdvancedHMIControls.BasicLabel
    Friend WithEvents HAND As AdvancedHMIControls.BasicButton
    Friend WithEvents OFF As AdvancedHMIControls.BasicButton
    Friend WithEvents AUT As AdvancedHMIControls.BasicButton
    Friend WithEvents HOA As AdvancedHMIControls.MessageDisplayByValue
End Class
