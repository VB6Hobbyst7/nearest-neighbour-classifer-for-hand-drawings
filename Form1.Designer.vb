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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PicInput = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PicCmpStretch = New System.Windows.Forms.PictureBox()
        Me.PicCrop = New System.Windows.Forms.PictureBox()
        Me.PicCmpZoomStretch = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CanvasPredict = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPredict = New System.Windows.Forms.TabPage()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CmbClassificationMode = New System.Windows.Forms.ComboBox()
        Me.PicCmpZoomFit = New System.Windows.Forms.PictureBox()
        Me.PicCmpFit = New System.Windows.Forms.PictureBox()
        Me.PrgBarCompare = New System.Windows.Forms.ProgressBar()
        Me.ChkAutoScrollConsole = New System.Windows.Forms.CheckBox()
        Me.ChkShowComparisonScores = New System.Windows.Forms.CheckBox()
        Me.LblPrediction = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LstPredictConsole = New System.Windows.Forms.ListBox()
        Me.TabTrain = New System.Windows.Forms.TabPage()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PicTrainPrepped = New System.Windows.Forms.PictureBox()
        Me.BtnTrainTypeNumber = New System.Windows.Forms.Button()
        Me.BtnTrainTypeShape = New System.Windows.Forms.Button()
        Me.LblTY = New System.Windows.Forms.Label()
        Me.BtnTrainAddToTSet = New System.Windows.Forms.Button()
        Me.CanvasTrain = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LstTrainingInfo = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbTrainLabelSelector = New System.Windows.Forms.ComboBox()
        Me.TabMNIST = New System.Windows.Forms.TabPage()
        Me.ChkNeedsBWConversion = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TFTSLstConsole = New System.Windows.Forms.ListBox()
        Me.TFTSPrgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnTrainAbort = New System.Windows.Forms.Button()
        Me.BtnTrainCont = New System.Windows.Forms.Button()
        Me.LblTrainCheck = New System.Windows.Forms.Label()
        Me.PicTrainCheck = New System.Windows.Forms.PictureBox()
        Me.TxtTSOtherFileType = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CmbTSFileType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkInvertBW = New System.Windows.Forms.CheckBox()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.CmbPossLbls = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDatasetLoc = New System.Windows.Forms.TextBox()
        Me.TimerTY = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PicInput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCmpStretch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCrop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCmpZoomStretch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanvasPredict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.TabPredict.SuspendLayout()
        CType(Me.PicCmpZoomFit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCmpFit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabTrain.SuspendLayout()
        CType(Me.PicTrainPrepped, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CanvasTrain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabMNIST.SuspendLayout()
        CType(Me.PicTrainCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicInput
        '
        Me.PicInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicInput.Image = CType(resources.GetObject("PicInput.Image"), System.Drawing.Image)
        Me.PicInput.Location = New System.Drawing.Point(6, 6)
        Me.PicInput.Name = "PicInput"
        Me.PicInput.Size = New System.Drawing.Size(500, 390)
        Me.PicInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicInput.TabIndex = 0
        Me.PicInput.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(59, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "⌃⌃ Process Image ⌃⌃"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PicCmpStretch
        '
        Me.PicCmpStretch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCmpStretch.Location = New System.Drawing.Point(618, 6)
        Me.PicCmpStretch.Name = "PicCmpStretch"
        Me.PicCmpStretch.Size = New System.Drawing.Size(100, 100)
        Me.PicCmpStretch.TabIndex = 2
        Me.PicCmpStretch.TabStop = False
        '
        'PicCrop
        '
        Me.PicCrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCrop.Location = New System.Drawing.Point(512, 6)
        Me.PicCrop.Name = "PicCrop"
        Me.PicCrop.Size = New System.Drawing.Size(100, 100)
        Me.PicCrop.TabIndex = 3
        Me.PicCrop.TabStop = False
        '
        'PicCmpZoomStretch
        '
        Me.PicCmpZoomStretch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCmpZoomStretch.Location = New System.Drawing.Point(724, 6)
        Me.PicCmpZoomStretch.Name = "PicCmpZoomStretch"
        Me.PicCmpZoomStretch.Size = New System.Drawing.Size(100, 100)
        Me.PicCmpZoomStretch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCmpZoomStretch.TabIndex = 4
        Me.PicCmpZoomStretch.TabStop = False
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(225, 403)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 40)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "⌄⌄ Process Drawing ⌄⌄"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CanvasPredict
        '
        Me.CanvasPredict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CanvasPredict.Location = New System.Drawing.Point(135, 451)
        Me.CanvasPredict.Name = "CanvasPredict"
        Me.CanvasPredict.Size = New System.Drawing.Size(250, 250)
        Me.CanvasPredict.TabIndex = 7
        Me.CanvasPredict.TabStop = False
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(391, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 40)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Clear Drawing"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPredict)
        Me.TabControl.Controls.Add(Me.TabTrain)
        Me.TabControl.Controls.Add(Me.TabMNIST)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1084, 735)
        Me.TabControl.TabIndex = 9
        '
        'TabPredict
        '
        Me.TabPredict.Controls.Add(Me.Button16)
        Me.TabPredict.Controls.Add(Me.Button17)
        Me.TabPredict.Controls.Add(Me.Label13)
        Me.TabPredict.Controls.Add(Me.Label14)
        Me.TabPredict.Controls.Add(Me.CmbClassificationMode)
        Me.TabPredict.Controls.Add(Me.PicCmpZoomFit)
        Me.TabPredict.Controls.Add(Me.PicCmpFit)
        Me.TabPredict.Controls.Add(Me.PrgBarCompare)
        Me.TabPredict.Controls.Add(Me.ChkAutoScrollConsole)
        Me.TabPredict.Controls.Add(Me.ChkShowComparisonScores)
        Me.TabPredict.Controls.Add(Me.LblPrediction)
        Me.TabPredict.Controls.Add(Me.Label4)
        Me.TabPredict.Controls.Add(Me.LstPredictConsole)
        Me.TabPredict.Controls.Add(Me.PicInput)
        Me.TabPredict.Controls.Add(Me.CanvasPredict)
        Me.TabPredict.Controls.Add(Me.Button3)
        Me.TabPredict.Controls.Add(Me.Button1)
        Me.TabPredict.Controls.Add(Me.PicCmpZoomStretch)
        Me.TabPredict.Controls.Add(Me.Button2)
        Me.TabPredict.Controls.Add(Me.PicCrop)
        Me.TabPredict.Controls.Add(Me.PicCmpStretch)
        Me.TabPredict.Location = New System.Drawing.Point(4, 22)
        Me.TabPredict.Name = "TabPredict"
        Me.TabPredict.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPredict.Size = New System.Drawing.Size(1076, 709)
        Me.TabPredict.TabIndex = 0
        Me.TabPredict.Text = "Classify a shape"
        Me.TabPredict.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(1023, 6)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(45, 40)
        Me.Button16.TabIndex = 24
        Me.Button16.Text = "No"
        Me.Button16.UseVisualStyleBackColor = True
        Me.Button16.Visible = False
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(972, 6)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(45, 40)
        Me.Button17.TabIndex = 23
        Me.Button17.Text = "Yes"
        Me.Button17.UseVisualStyleBackColor = True
        Me.Button17.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(835, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 16)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Am I correct?"
        Me.Label13.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(835, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 16)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "I think this is a --."
        Me.Label14.Visible = False
        '
        'CmbClassificationMode
        '
        Me.CmbClassificationMode.FormattingEnabled = True
        Me.CmbClassificationMode.Items.AddRange(New Object() {"stretch,fit", "stretch", "fit"})
        Me.CmbClassificationMode.Location = New System.Drawing.Point(403, 466)
        Me.CmbClassificationMode.Name = "CmbClassificationMode"
        Me.CmbClassificationMode.Size = New System.Drawing.Size(102, 21)
        Me.CmbClassificationMode.TabIndex = 20
        Me.CmbClassificationMode.Text = "stretch,fit"
        '
        'PicCmpZoomFit
        '
        Me.PicCmpZoomFit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCmpZoomFit.Location = New System.Drawing.Point(724, 112)
        Me.PicCmpZoomFit.Name = "PicCmpZoomFit"
        Me.PicCmpZoomFit.Size = New System.Drawing.Size(100, 100)
        Me.PicCmpZoomFit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicCmpZoomFit.TabIndex = 19
        Me.PicCmpZoomFit.TabStop = False
        '
        'PicCmpFit
        '
        Me.PicCmpFit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicCmpFit.Location = New System.Drawing.Point(618, 112)
        Me.PicCmpFit.Name = "PicCmpFit"
        Me.PicCmpFit.Size = New System.Drawing.Size(100, 100)
        Me.PicCmpFit.TabIndex = 18
        Me.PicCmpFit.TabStop = False
        '
        'PrgBarCompare
        '
        Me.PrgBarCompare.Location = New System.Drawing.Point(826, 283)
        Me.PrgBarCompare.Maximum = 11
        Me.PrgBarCompare.Name = "PrgBarCompare"
        Me.PrgBarCompare.Size = New System.Drawing.Size(242, 21)
        Me.PrgBarCompare.TabIndex = 17
        '
        'ChkAutoScrollConsole
        '
        Me.ChkAutoScrollConsole.AutoSize = True
        Me.ChkAutoScrollConsole.Checked = True
        Me.ChkAutoScrollConsole.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkAutoScrollConsole.Location = New System.Drawing.Point(521, 682)
        Me.ChkAutoScrollConsole.Name = "ChkAutoScrollConsole"
        Me.ChkAutoScrollConsole.Size = New System.Drawing.Size(112, 17)
        Me.ChkAutoScrollConsole.TabIndex = 16
        Me.ChkAutoScrollConsole.Text = "Autoscroll console"
        Me.ChkAutoScrollConsole.UseVisualStyleBackColor = True
        '
        'ChkShowComparisonScores
        '
        Me.ChkShowComparisonScores.AutoSize = True
        Me.ChkShowComparisonScores.Location = New System.Drawing.Point(521, 662)
        Me.ChkShowComparisonScores.Name = "ChkShowComparisonScores"
        Me.ChkShowComparisonScores.Size = New System.Drawing.Size(203, 17)
        Me.ChkShowComparisonScores.TabIndex = 15
        Me.ChkShowComparisonScores.Text = "Show extra info in console (very slow)"
        Me.ChkShowComparisonScores.UseVisualStyleBackColor = True
        '
        'LblPrediction
        '
        Me.LblPrediction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrediction.Location = New System.Drawing.Point(677, 667)
        Me.LblPrediction.Name = "LblPrediction"
        Me.LblPrediction.Size = New System.Drawing.Size(390, 25)
        Me.LblPrediction.TabIndex = 11
        Me.LblPrediction.Text = "I think this is a --"
        Me.LblPrediction.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(518, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Console"
        '
        'LstPredictConsole
        '
        Me.LstPredictConsole.FormattingEnabled = True
        Me.LstPredictConsole.Location = New System.Drawing.Point(518, 310)
        Me.LstPredictConsole.Name = "LstPredictConsole"
        Me.LstPredictConsole.ScrollAlwaysVisible = True
        Me.LstPredictConsole.Size = New System.Drawing.Size(550, 342)
        Me.LstPredictConsole.TabIndex = 9
        '
        'TabTrain
        '
        Me.TabTrain.Controls.Add(Me.Button12)
        Me.TabTrain.Controls.Add(Me.Button13)
        Me.TabTrain.Controls.Add(Me.Button10)
        Me.TabTrain.Controls.Add(Me.Button11)
        Me.TabTrain.Controls.Add(Me.Button8)
        Me.TabTrain.Controls.Add(Me.Button9)
        Me.TabTrain.Controls.Add(Me.Button6)
        Me.TabTrain.Controls.Add(Me.Button7)
        Me.TabTrain.Controls.Add(Me.Button5)
        Me.TabTrain.Controls.Add(Me.Button4)
        Me.TabTrain.Controls.Add(Me.PicTrainPrepped)
        Me.TabTrain.Controls.Add(Me.BtnTrainTypeNumber)
        Me.TabTrain.Controls.Add(Me.BtnTrainTypeShape)
        Me.TabTrain.Controls.Add(Me.LblTY)
        Me.TabTrain.Controls.Add(Me.BtnTrainAddToTSet)
        Me.TabTrain.Controls.Add(Me.CanvasTrain)
        Me.TabTrain.Controls.Add(Me.Label3)
        Me.TabTrain.Controls.Add(Me.LstTrainingInfo)
        Me.TabTrain.Controls.Add(Me.Label2)
        Me.TabTrain.Controls.Add(Me.Label1)
        Me.TabTrain.Controls.Add(Me.CmbTrainLabelSelector)
        Me.TabTrain.Location = New System.Drawing.Point(4, 22)
        Me.TabTrain.Name = "TabTrain"
        Me.TabTrain.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTrain.Size = New System.Drawing.Size(1076, 709)
        Me.TabTrain.TabIndex = 1
        Me.TabTrain.Text = "Train from drawing"
        Me.TabTrain.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(554, 496)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(30, 30)
        Me.Button12.TabIndex = 23
        Me.Button12.Text = "0"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(554, 460)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(30, 30)
        Me.Button13.TabIndex = 22
        Me.Button13.Text = "0"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(518, 496)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(30, 30)
        Me.Button10.TabIndex = 21
        Me.Button10.Text = "0"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(518, 460)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(30, 30)
        Me.Button11.TabIndex = 20
        Me.Button11.Text = "0"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(482, 496)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(30, 30)
        Me.Button8.TabIndex = 19
        Me.Button8.Text = "0"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(482, 460)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(30, 30)
        Me.Button9.TabIndex = 18
        Me.Button9.Text = "0"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(446, 496)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(30, 30)
        Me.Button6.TabIndex = 17
        Me.Button6.Text = "0"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(446, 460)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(30, 30)
        Me.Button7.TabIndex = 16
        Me.Button7.Text = "0"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(410, 496)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(30, 30)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "0"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(410, 460)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(30, 30)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "0"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PicTrainPrepped
        '
        Me.PicTrainPrepped.Location = New System.Drawing.Point(333, 395)
        Me.PicTrainPrepped.Name = "PicTrainPrepped"
        Me.PicTrainPrepped.Size = New System.Drawing.Size(20, 20)
        Me.PicTrainPrepped.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicTrainPrepped.TabIndex = 13
        Me.PicTrainPrepped.TabStop = False
        '
        'BtnTrainTypeNumber
        '
        Me.BtnTrainTypeNumber.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTrainTypeNumber.Enabled = False
        Me.BtnTrainTypeNumber.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnTrainTypeNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrainTypeNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrainTypeNumber.Location = New System.Drawing.Point(247, 268)
        Me.BtnTrainTypeNumber.Name = "BtnTrainTypeNumber"
        Me.BtnTrainTypeNumber.Size = New System.Drawing.Size(83, 30)
        Me.BtnTrainTypeNumber.TabIndex = 12
        Me.BtnTrainTypeNumber.Text = "Number"
        Me.BtnTrainTypeNumber.UseVisualStyleBackColor = False
        '
        'BtnTrainTypeShape
        '
        Me.BtnTrainTypeShape.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnTrainTypeShape.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise
        Me.BtnTrainTypeShape.FlatAppearance.BorderSize = 2
        Me.BtnTrainTypeShape.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTrainTypeShape.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrainTypeShape.Location = New System.Drawing.Point(158, 268)
        Me.BtnTrainTypeShape.Name = "BtnTrainTypeShape"
        Me.BtnTrainTypeShape.Size = New System.Drawing.Size(83, 30)
        Me.BtnTrainTypeShape.TabIndex = 11
        Me.BtnTrainTypeShape.Text = "Shape"
        Me.BtnTrainTypeShape.UseVisualStyleBackColor = False
        '
        'LblTY
        '
        Me.LblTY.AutoSize = True
        Me.LblTY.Font = New System.Drawing.Font("Mistral", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTY.Location = New System.Drawing.Point(38, 389)
        Me.LblTY.Name = "LblTY"
        Me.LblTY.Size = New System.Drawing.Size(119, 34)
        Me.LblTY.TabIndex = 10
        Me.LblTY.Text = "Thank you!"
        Me.LblTY.Visible = False
        '
        'BtnTrainAddToTSet
        '
        Me.BtnTrainAddToTSet.Enabled = False
        Me.BtnTrainAddToTSet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrainAddToTSet.Location = New System.Drawing.Point(163, 385)
        Me.BtnTrainAddToTSet.Name = "BtnTrainAddToTSet"
        Me.BtnTrainAddToTSet.Size = New System.Drawing.Size(160, 40)
        Me.BtnTrainAddToTSet.TabIndex = 9
        Me.BtnTrainAddToTSet.Text = "Add to Training Set"
        Me.BtnTrainAddToTSet.UseVisualStyleBackColor = True
        '
        'CanvasTrain
        '
        Me.CanvasTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CanvasTrain.Location = New System.Drawing.Point(119, 6)
        Me.CanvasTrain.Name = "CanvasTrain"
        Me.CanvasTrain.Size = New System.Drawing.Size(250, 250)
        Me.CanvasTrain.TabIndex = 8
        Me.CanvasTrain.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(410, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Training data:"
        '
        'LstTrainingInfo
        '
        Me.LstTrainingInfo.FormattingEnabled = True
        Me.LstTrainingInfo.Location = New System.Drawing.Point(410, 29)
        Me.LstTrainingInfo.Name = "LstTrainingInfo"
        Me.LstTrainingInfo.Size = New System.Drawing.Size(358, 407)
        Me.LstTrainingInfo.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Draw a shape:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What is this?"
        '
        'CmbTrainLabelSelector
        '
        Me.CmbTrainLabelSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.CmbTrainLabelSelector.FormattingEnabled = True
        Me.CmbTrainLabelSelector.Items.AddRange(New Object() {"Circle", "Triangle", "Square", "Pentagon", "Hexagon", "Rhombus", "Semicircle", "Heart", "Banana", "A", "B", "C", "D", "E"})
        Me.CmbTrainLabelSelector.Location = New System.Drawing.Point(119, 304)
        Me.CmbTrainLabelSelector.Name = "CmbTrainLabelSelector"
        Me.CmbTrainLabelSelector.Size = New System.Drawing.Size(250, 65)
        Me.CmbTrainLabelSelector.TabIndex = 0
        '
        'TabMNIST
        '
        Me.TabMNIST.Controls.Add(Me.ChkNeedsBWConversion)
        Me.TabMNIST.Controls.Add(Me.ComboBox1)
        Me.TabMNIST.Controls.Add(Me.Label12)
        Me.TabMNIST.Controls.Add(Me.TFTSLstConsole)
        Me.TabMNIST.Controls.Add(Me.TFTSPrgBar)
        Me.TabMNIST.Controls.Add(Me.BtnTrainAbort)
        Me.TabMNIST.Controls.Add(Me.BtnTrainCont)
        Me.TabMNIST.Controls.Add(Me.LblTrainCheck)
        Me.TabMNIST.Controls.Add(Me.PicTrainCheck)
        Me.TabMNIST.Controls.Add(Me.TxtTSOtherFileType)
        Me.TabMNIST.Controls.Add(Me.Label10)
        Me.TabMNIST.Controls.Add(Me.CmbTSFileType)
        Me.TabMNIST.Controls.Add(Me.Label9)
        Me.TabMNIST.Controls.Add(Me.ChkInvertBW)
        Me.TabMNIST.Controls.Add(Me.Button15)
        Me.TabMNIST.Controls.Add(Me.CmbPossLbls)
        Me.TabMNIST.Controls.Add(Me.Label8)
        Me.TabMNIST.Controls.Add(Me.Label7)
        Me.TabMNIST.Controls.Add(Me.Button14)
        Me.TabMNIST.Controls.Add(Me.Label5)
        Me.TabMNIST.Controls.Add(Me.TxtDatasetLoc)
        Me.TabMNIST.Location = New System.Drawing.Point(4, 22)
        Me.TabMNIST.Name = "TabMNIST"
        Me.TabMNIST.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMNIST.Size = New System.Drawing.Size(1076, 709)
        Me.TabMNIST.TabIndex = 2
        Me.TabMNIST.Text = "Train from dataset"
        Me.TabMNIST.UseVisualStyleBackColor = True
        '
        'ChkNeedsBWConversion
        '
        Me.ChkNeedsBWConversion.AutoSize = True
        Me.ChkNeedsBWConversion.Location = New System.Drawing.Point(173, 116)
        Me.ChkNeedsBWConversion.Name = "ChkNeedsBWConversion"
        Me.ChkNeedsBWConversion.Size = New System.Drawing.Size(189, 17)
        Me.ChkNeedsBWConversion.TabIndex = 27
        Me.ChkNeedsBWConversion.Text = "Convert images to black and white"
        Me.ChkNeedsBWConversion.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"All (recommended for best classification)", "Stretch image to square to normalise", "Fit image to square to normalise"})
        Me.ComboBox1.Location = New System.Drawing.Point(160, 170)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(316, 21)
        Me.ComboBox1.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 172)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(146, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Compression mode:"
        '
        'TFTSLstConsole
        '
        Me.TFTSLstConsole.FormattingEnabled = True
        Me.TFTSLstConsole.Location = New System.Drawing.Point(539, 49)
        Me.TFTSLstConsole.Name = "TFTSLstConsole"
        Me.TFTSLstConsole.ScrollAlwaysVisible = True
        Me.TFTSLstConsole.Size = New System.Drawing.Size(413, 199)
        Me.TFTSLstConsole.TabIndex = 24
        '
        'TFTSPrgBar
        '
        Me.TFTSPrgBar.Location = New System.Drawing.Point(539, 15)
        Me.TFTSPrgBar.Maximum = 11
        Me.TFTSPrgBar.Name = "TFTSPrgBar"
        Me.TFTSPrgBar.Size = New System.Drawing.Size(413, 21)
        Me.TFTSPrgBar.Step = 1
        Me.TFTSPrgBar.TabIndex = 23
        '
        'BtnTrainAbort
        '
        Me.BtnTrainAbort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrainAbort.Location = New System.Drawing.Point(828, 110)
        Me.BtnTrainAbort.Name = "BtnTrainAbort"
        Me.BtnTrainAbort.Size = New System.Drawing.Size(124, 40)
        Me.BtnTrainAbort.TabIndex = 22
        Me.BtnTrainAbort.Text = "Abort"
        Me.BtnTrainAbort.UseVisualStyleBackColor = True
        Me.BtnTrainAbort.Visible = False
        '
        'BtnTrainCont
        '
        Me.BtnTrainCont.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTrainCont.Location = New System.Drawing.Point(698, 110)
        Me.BtnTrainCont.Name = "BtnTrainCont"
        Me.BtnTrainCont.Size = New System.Drawing.Size(124, 40)
        Me.BtnTrainCont.TabIndex = 21
        Me.BtnTrainCont.Text = "Continue"
        Me.BtnTrainCont.UseVisualStyleBackColor = True
        Me.BtnTrainCont.Visible = False
        '
        'LblTrainCheck
        '
        Me.LblTrainCheck.AutoSize = True
        Me.LblTrainCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTrainCheck.Location = New System.Drawing.Point(695, 65)
        Me.LblTrainCheck.Name = "LblTrainCheck"
        Me.LblTrainCheck.Size = New System.Drawing.Size(257, 32)
        Me.LblTrainCheck.TabIndex = 20
        Me.LblTrainCheck.Text = "If this image looks correct (i.e. has a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "white background) then continue."
        Me.LblTrainCheck.Visible = False
        '
        'PicTrainCheck
        '
        Me.PicTrainCheck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicTrainCheck.Location = New System.Drawing.Point(539, 36)
        Me.PicTrainCheck.Name = "PicTrainCheck"
        Me.PicTrainCheck.Size = New System.Drawing.Size(150, 150)
        Me.PicTrainCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PicTrainCheck.TabIndex = 19
        Me.PicTrainCheck.TabStop = False
        Me.PicTrainCheck.Visible = False
        '
        'TxtTSOtherFileType
        '
        Me.TxtTSOtherFileType.Enabled = False
        Me.TxtTSOtherFileType.Location = New System.Drawing.Point(82, 137)
        Me.TxtTSOtherFileType.Name = "TxtTSOtherFileType"
        Me.TxtTSOtherFileType.Size = New System.Drawing.Size(51, 20)
        Me.TxtTSOtherFileType.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 140)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "or"
        '
        'CmbTSFileType
        '
        Me.CmbTSFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTSFileType.FormattingEnabled = True
        Me.CmbTSFileType.Items.AddRange(New Object() {"jpg", "png", "gif", "bmp", "Other"})
        Me.CmbTSFileType.Location = New System.Drawing.Point(82, 112)
        Me.CmbTSFileType.Name = "CmbTSFileType"
        Me.CmbTSFileType.Size = New System.Drawing.Size(51, 21)
        Me.CmbTSFileType.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Filetype:"
        '
        'ChkInvertBW
        '
        Me.ChkInvertBW.AutoSize = True
        Me.ChkInvertBW.Enabled = False
        Me.ChkInvertBW.Location = New System.Drawing.Point(173, 137)
        Me.ChkInvertBW.Name = "ChkInvertBW"
        Me.ChkInvertBW.Size = New System.Drawing.Size(281, 17)
        Me.ChkInvertBW.TabIndex = 12
        Me.ChkInvertBW.Text = "Invert black and white colours from training set images"
        Me.ChkInvertBW.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(80, 208)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(329, 40)
        Me.Button15.TabIndex = 11
        Me.Button15.Text = "Train AI Using Dataset  (this may take a long time)"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'CmbPossLbls
        '
        Me.CmbPossLbls.FormattingEnabled = True
        Me.CmbPossLbls.Items.AddRange(New Object() {"0,1,2,3,4,5,6,7,8,9", "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z", "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z"})
        Me.CmbPossLbls.Location = New System.Drawing.Point(73, 78)
        Me.CmbPossLbls.Name = "CmbPossLbls"
        Me.CmbPossLbls.Size = New System.Drawing.Size(403, 21)
        Me.CmbPossLbls.TabIndex = 10
        Me.CmbPossLbls.Text = "0,1,2,3,4,5,6,7,8,9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Labels:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(431, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Training set images should be in subfolders which are named with the correspondin" & _
            "g label."
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(415, 15)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(61, 22)
        Me.Button14.TabIndex = 6
        Me.Button14.Text = "Browse..."
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Dataset location:"
        '
        'TxtDatasetLoc
        '
        Me.TxtDatasetLoc.Location = New System.Drawing.Point(139, 16)
        Me.TxtDatasetLoc.Name = "TxtDatasetLoc"
        Me.TxtDatasetLoc.Size = New System.Drawing.Size(270, 20)
        Me.TxtDatasetLoc.TabIndex = 0
        Me.TxtDatasetLoc.Text = "C:\Users\James\Desktop\MACHINE VISION\trainingSample"
        '
        'TimerTY
        '
        Me.TimerTY.Interval = 5000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 735)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Form1"
        Me.Text = "Nearest Neighbour Classifier"
        CType(Me.PicInput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCmpStretch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCrop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCmpZoomStretch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanvasPredict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.TabPredict.ResumeLayout(False)
        Me.TabPredict.PerformLayout()
        CType(Me.PicCmpZoomFit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCmpFit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabTrain.ResumeLayout(False)
        Me.TabTrain.PerformLayout()
        CType(Me.PicTrainPrepped, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CanvasTrain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabMNIST.ResumeLayout(False)
        Me.TabMNIST.PerformLayout()
        CType(Me.PicTrainCheck, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PicInput As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PicCmpStretch As System.Windows.Forms.PictureBox
    Friend WithEvents PicCrop As System.Windows.Forms.PictureBox
    Friend WithEvents PicCmpZoomStretch As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CanvasPredict As System.Windows.Forms.PictureBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents TabPredict As System.Windows.Forms.TabPage
    Friend WithEvents TabTrain As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LstTrainingInfo As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LstPredictConsole As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CanvasTrain As System.Windows.Forms.PictureBox
    Friend WithEvents LblTY As System.Windows.Forms.Label
    Friend WithEvents BtnTrainAddToTSet As System.Windows.Forms.Button
    Friend WithEvents BtnTrainTypeNumber As System.Windows.Forms.Button
    Friend WithEvents BtnTrainTypeShape As System.Windows.Forms.Button
    Friend WithEvents PicTrainPrepped As System.Windows.Forms.PictureBox
    Friend WithEvents TimerTY As System.Windows.Forms.Timer
    Friend WithEvents LblPrediction As System.Windows.Forms.Label
    Friend WithEvents ChkShowComparisonScores As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAutoScrollConsole As System.Windows.Forms.CheckBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CmbTrainLabelSelector As System.Windows.Forms.ComboBox
    Friend WithEvents PrgBarCompare As System.Windows.Forms.ProgressBar
    Friend WithEvents TabMNIST As System.Windows.Forms.TabPage
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDatasetLoc As System.Windows.Forms.TextBox
    Friend WithEvents CmbPossLbls As System.Windows.Forms.ComboBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents ChkInvertBW As System.Windows.Forms.CheckBox
    Friend WithEvents CmbTSFileType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTSOtherFileType As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BtnTrainAbort As System.Windows.Forms.Button
    Friend WithEvents BtnTrainCont As System.Windows.Forms.Button
    Friend WithEvents LblTrainCheck As System.Windows.Forms.Label
    Friend WithEvents PicTrainCheck As System.Windows.Forms.PictureBox
    Friend WithEvents TFTSPrgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TFTSLstConsole As System.Windows.Forms.ListBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PicCmpZoomFit As System.Windows.Forms.PictureBox
    Friend WithEvents PicCmpFit As System.Windows.Forms.PictureBox
    Friend WithEvents CmbClassificationMode As System.Windows.Forms.ComboBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChkNeedsBWConversion As System.Windows.Forms.CheckBox

End Class
