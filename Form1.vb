'KNOWN ISSUES
'   - Training tab increments the progress bar on the classification tab, which can cause a crash if the training bar is overfilled.




Imports System.IO



'Class AIDataItem
'    Public Label As String
'    Public PixelString As String
'    Sub New()
'        Me.Label = "Unclassified"
'        Me.PixelString = ""
'    End Sub
'    Sub SetLabel(ByVal x As String)
'        Me.Label = x
'    End Sub
'    Function GetLabel()
'        Return Me.Label
'    End Function
'    Sub SetPixelString(ByVal x As String)
'        Me.PixelString = x
'    End Sub
'    Function GetPixelString()
'        Return Me.PixelString
'    End Function
'End Class








Public Structure AIDataItem
    Dim Label As String
    Dim PixelStringStretch As String
    Dim PixelStringFit As String
End Structure

Structure AverageNum
    Dim sum As Single
    Dim n As Integer
End Structure

Structure ScoreRankAvg
    Dim score As AverageNum
    Dim rank As Integer
End Structure

Structure ScoreRank
    Dim score As Single
    Dim rank As Integer
End Structure

Public Structure LabelIDs
    Dim name As String
    Dim ID As Integer
End Structure



Public Class Form1






    Const TRAINING_SET_FILE_LOC As String = "trainingset.txt"

    Public Shared HasDrawnForPrediction As Boolean = False
    Public Shared HasDrawnForTraining As Boolean = False






    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CanvasPredict.Image = New Bitmap(250, 250)
        Dim g As Graphics = Graphics.FromImage(CanvasPredict.Image)
        g.FillRectangle(Brushes.White, 0, 0, CanvasPredict.Width, CanvasPredict.Height)
        CanvasTrain.Image = New Bitmap(250, 250)
        g = Graphics.FromImage(CanvasTrain.Image)
        g.FillRectangle(Brushes.White, 0, 0, CanvasTrain.Width, CanvasTrain.Height)

        Console.W("Ready to predict using image")
    End Sub





    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    'For drawing in classification tab:
    Dim mousePath As New System.Drawing.Drawing2D.GraphicsPath() 'declare a new Graphic path to follow the mouse movement
    Dim myAlpha As Integer = 255 ' declare a Alpha variable
    Dim myUserColor As New Color() 'this is a color the user selects
    Dim myPenWidth As Single = 20 'set pen width variable
    Private Sub CanvasPredict_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CanvasPredict.MouseDown
        If e.Button = MouseButtons.Left Then ' draw a filled circle if left mouse is down  
            mousePath.StartFigure()    ' The L mouse is down so we need to start a new line in mousePath
        End If
    End Sub
    Private Sub CanvasPredict_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CanvasPredict.MouseMove
        If e.Button = MouseButtons.Left Then ' draw a filled circle if left mouse is down  
            mousePath.AddLine(e.X, e.Y, e.X, e.Y)    'Add mouse coordiantes to mousePath
            If HasDrawnForPrediction = False Then
                Console.W("Ready to predict using drawing")
                HasDrawnForPrediction = True
                Button2.Enabled = True
            End If
        End If
        CanvasPredict.Invalidate() 'Repaint the PictureBox using the PicDrawing Paint event
    End Sub
    Private Sub CanvasPredict_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CanvasPredict.Paint
        myUserColor = (System.Drawing.Color.Black) 'You can remove this line and add a user selected color to
        myAlpha = 255  ' This will give the color a Alpha effect, you can set this to 255 if you want a full color
        Dim CurrentPen = New Pen(Color.FromArgb(myAlpha, myUserColor), myPenWidth) 'Set up the pen
        Dim g As Graphics = Graphics.FromImage(CanvasPredict.Image)
        'e.Graphics.DrawPath(CurrentPen, mousePath)  'draw the path! :)
        g.DrawPath(CurrentPen, mousePath)
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------

    '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    'For drawing in training tab:
    Dim mousePath2 As New System.Drawing.Drawing2D.GraphicsPath() 'declare a new Graphic path to follow the mouse movement
    Dim myAlpha2 As Integer = 255 ' declare a Alpha variable
    Dim myUserColor2 As New Color() 'this is a color the user selects
    Dim myPenWidth2 As Single = 20 'set pen width variable
    Private Sub CanvasTrain_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles CanvasTrain.MouseDown
        If e.Button = MouseButtons.Left Then ' draw a filled circle if left mouse is down  
            mousePath2.StartFigure()    ' The L mouse is down so we need to start a new line in mousePath2
        End If
    End Sub
    Private Sub CanvasTrain_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CanvasTrain.MouseMove
        If e.Button = MouseButtons.Left Then ' draw a filled circle if left mouse is down  
            mousePath2.AddLine(e.X, e.Y, e.X, e.Y)    'Add mouse coordiantes to mousePath2
            If HasDrawnForTraining = False Then
                HasDrawnForTraining = True
                BtnTrainAddToTSet.Enabled = True
            End If
        End If
        CanvasTrain.Invalidate() 'Repaint the PictureBox using the PicDrawing Paint event
    End Sub
    Private Sub CanvasTrain_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CanvasTrain.Paint
        myUserColor2 = (System.Drawing.Color.Black) 'You can remove this line and add a user selected color to
        myAlpha2 = 255  ' This will give the color a Alpha effect, you can set this to 255 if you want a full color
        Dim CurrentPen = New Pen(Color.FromArgb(myAlpha2, myUserColor2), myPenWidth2) 'Set up the pen
        Dim g As Graphics = Graphics.FromImage(CanvasTrain.Image)
        'e.Graphics.DrawPath(CurrentPen, mousePath2)  'draw the path! :)
        g.DrawPath(CurrentPen, mousePath2)
    End Sub
    '-------------------------------------------------------------------------------------------------------------------------------------------------------------



    'Custom classes to provide various different functions not present in VB forms:

    Class Console
        Public Shared Sub W(ByVal str As String)
            With Form1.LstPredictConsole
                .Items.Add("> " & str)
                If Form1.ChkAutoScrollConsole.CheckState = CheckState.Checked Then .TopIndex = .Items.Count - 1
            End With
        End Sub
    End Class

    Class ConsoleTFTS
        Public Shared Sub W(ByVal str As String)
            With Form1.TFTSLstConsole
                .Items.Add("> " & str)
                .TopIndex = .Items.Count - 1
            End With
        End Sub
    End Class

    Class CountTimer
        Public Shared StartTime As Long
        Public Shared Sub StartTimer()
            CountTimer.StartTime = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds
        End Sub
        Public Shared Function StopTimer() As Single
            Dim milliseconds As Integer = (DateTime.UtcNow - New DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds - CountTimer.StartTime ' Calculates the time taken since the timer was started.
            Dim seconds As Single = milliseconds / 1000 'Converts milliseconds integer to seconds.
            Return seconds
        End Function
    End Class






    Function BMConvertToBW(ByVal bm As Bitmap, ByVal invertBW As Boolean)
        Dim clrA, clrR, clrG, clrB As Integer
        Dim x, y As Integer
        For x = 0 To bm.Width - 1
            For y = 0 To bm.Height - 1
                clrR = Int(bm.GetPixel(x, y).R)
                clrG = Int(bm.GetPixel(x, y).G)
                clrB = Int(bm.GetPixel(x, y).B)
                clrA = (clrR + clrG + clrB) / 3
                If invertBW = True Then
                    If clrA > 150 Then : bm.SetPixel(x, y, Color.Black)
                    Else : bm.SetPixel(x, y, Color.White)
                    End If
                Else
                    If clrA > 200 Then : bm.SetPixel(x, y, Color.White)
                    Else : bm.SetPixel(x, y, Color.Black)
                    End If
                End If
            Next
        Next
        Return bm
    End Function

    Function BMCropToChar_Inefficient(ByVal bm As Bitmap)

        Dim MinX As Integer = 65535
        Dim MinY As Integer = 65535
        Dim MaxX As Integer = 0
        Dim MaxY As Integer = 0

        For y = 0 To bm.Height - 1
            For x = 0 To bm.Width - 1
                If bm.GetPixel(x, y).R = 0 Then
                    If x < MinX Then MinX = x
                End If
            Next
        Next
        For y = 0 To bm.Height - 1
            For x = 0 To bm.Width - 1
                If bm.GetPixel(x, y).R = 0 Then
                    If x > MaxX Then MaxX = x
                End If
            Next
        Next
        For x = 0 To bm.Width - 1
            For y = 0 To bm.Height - 1
                If bm.GetPixel(x, y).R = 0 Then
                    If y < MinY Then MinY = y
                End If
            Next
        Next
        For x = 0 To bm.Width - 1
            For y = 0 To bm.Height - 1
                If bm.GetPixel(x, y).R = 0 Then
                    If y > MaxY Then MaxY = y
                End If
            Next
        Next

        Dim bm_NEW As New Bitmap(1 + MaxX - MinX, 1 + MaxY - MinY) 'Needs the 1 that is added, because consider a 1 pixel wide line to be cropped to: Say maxx is 13, minx would also = 13, so 1 + 13 - 13 = 1 pixel wide image.
        For x = 0 To bm_NEW.Width - 1
            For y = 0 To bm_NEW.Height - 1
                bm_NEW.SetPixel(x, y, bm.GetPixel(x + MinX, y + MinY))
            Next
        Next

        Return bm_NEW
    End Function

    Function BMCropToChar(ByVal bm As Bitmap)

        Dim MinX As Integer = 65535
        Dim MinY As Integer = 65535
        Dim MaxX As Integer = 0
        Dim MaxY As Integer = 0

        'Compressed down to one loop of all the pixels in the image, as the order to scan the pixels doesn't matter:
        For y = 0 To bm.Height - 1
            For x = 0 To bm.Width - 1
                If bm.GetPixel(x, y).R = 0 Then
                    If x < MinX Then MinX = x
                    If x > MaxX Then MaxX = x
                    If y < MinY Then MinY = y
                    If y > MaxY Then MaxY = y
                End If
            Next
        Next

        Dim bm_NEW As New Bitmap(MaxX + 1 - MinX, MaxY + 1 - MinY)  'Needs the 1 that is added, because consider a 1 pixel wide line to be cropped to: Say maxx is 13, minx would also = 13, so 1 + 13 - 13 = 1 pixel wide image.
        For x = 0 To bm_NEW.Width - 1
            For y = 0 To bm_NEW.Height - 1
                bm_NEW.SetPixel(x, y, bm.GetPixel(x + MinX, y + MinY))
            Next
        Next

        Return bm_NEW
    End Function

    Private Function CompressBM(ByVal bm As Bitmap, ByVal MaxDimension As Integer)
        Dim bmCompressionRatio As Integer = 9 'Need to store a number to one decimal place. Stored as an integer which will be divided by 10 to get the intended number everytime it is used, as storing as a single results in funky numbers (i.e. 2.9 storing as 2.89999999, since there is no exact binary representation for 2.9 within the bits allocated to a single).
        Do : bmCompressionRatio += 1
        Loop Until bm.Width / (bmCompressionRatio / 10) <= MaxDimension And bm.Height / (bmCompressionRatio / 10) <= MaxDimension

        Return New Bitmap(bm, bm.Width / (bmCompressionRatio / 10), bm.Height / (bmCompressionRatio / 10))
    End Function

    Function BMFitToSize(ByVal bm As Bitmap, ByVal GreatestWorH As Integer) As Bitmap
        Dim oldW As Integer = bm.Width
        Dim oldH As Integer = bm.Height

        Dim newW, newH As Integer

        'Creates a bitmap with the same aspect ratio as the original, but downsized to a maximum width or height of a given number of pixels (20).
        If oldW > oldH Then
            newW = GreatestWorH
            newH = (oldH / oldW) * GreatestWorH
        Else
            newW = (oldW / oldH) * GreatestWorH
            newH = GreatestWorH
        End If

        bm = New Bitmap(bm, newW, newH) 'New bitmap created, but not square (i.e. has no white space surrounding to make it a square).

        Dim bm_NEW As New Bitmap(GreatestWorH, GreatestWorH)
        Graphics.FromImage(bm_NEW).FillRectangle(Brushes.White, 0, 0, bm_NEW.Width, bm_NEW.Height) 'This fills the new bitmap with white, so that there is no transparency in the bitmap.

        Dim Xoffset As Integer = (GreatestWorH - newW) / 2
        Dim Yoffset As Integer = (GreatestWorH - newH) / 2
        'Paints the downsized, non-square bitmap that was created onto a square bitmap. This is needed so all bitmaps end up with the same width and height.
        For y = 0 To bm.Height - 1
            For x = 0 To bm.Width - 1
                bm_NEW.SetPixel(x + Xoffset, y + Yoffset, bm.GetPixel(x, y))
            Next
        Next

        Return bm_NEW
    End Function

    Function BMStretchToSize(ByVal bm As Bitmap, ByVal w As Integer, ByVal h As Integer) As Bitmap
        Return New Bitmap(bm, w, h)
    End Function

    Function CreatePixelString(ByVal bm As Bitmap)
        Dim x As Integer = bm.Width
        Dim y As Integer = bm.Height
        Dim bmstr As String = ""
        For i = 0 To y - 1
            For j = 0 To x - 1
                If bm.GetPixel(j, i).R < 128 Then : bmstr &= "1" 'If pixel of image is black then add 1 to analysis string.
                Else : bmstr &= "0"
                End If
            Next
        Next
        Return bmstr
    End Function







    Private Sub Button1_Click() Handles Button1.Click
        ClassifyImage(True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PicInput.Image = New Bitmap(CanvasPredict.Image)
        ClassifyImage(False)
    End Sub

    Private Sub ClassifyImage(ByVal NeedsBWConversion As Boolean)

        'Byval: BM to classify, type of image (shape, number, letter, +-x/ or other symbol) Leave in needsbwconversion function to show it off and for colourblindness mode.
        'Can also decide classification mode based on type of image (e.g. stretch for shapes, fit for numbers (or whichever works better), fit+stretch for letters).

        CountTimer.StartTimer()

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Process image to BW 20x20 bitmap for analysis:

        PrgBarCompare.Value = 0
        Dim bm As New Bitmap(PicInput.Image)

        'Compress initial image input to 500 pixels longest edge - won't lose too much detail, but will reduce processing time significantly.
        If bm.Width > 500 Then bm = New Bitmap(bm, 500, 500)
        PicInput.Image = bm
        Me.Refresh()


        If NeedsBWConversion = True Then
            PicInput.Image = BMConvertToBW(bm, False)
            Console.W("Converted input image to BW")
            Me.Refresh()
        End If


        bm = BMCropToChar(bm)
        PicCrop.Image = bm

        PicCrop.Width = PicCrop.Image.Width + 2
        PicCrop.Height = PicCrop.Image.Height + 2
        PicCmpStretch.Location = New Point(PicCrop.Location.X + PicCrop.Size.Width + 6, PicCmpStretch.Location.Y)
        PicCmpFit.Location = New Point(PicCrop.Location.X + PicCrop.Size.Width + 6, PicCmpFit.Location.Y)
        Console.W("Cropped white-space from image")
        Me.Refresh()





        'Create 20x20 pixel image, stretched to size:
        Dim bmStretch As New Bitmap(BMStretchToSize(bm, 20, 20))
        PicCmpStretch.Image = bmStretch

        'Display compressed image at real size in picturebox:
        PicCmpStretch.Width = PicCmpStretch.Image.Width + 2
        PicCmpStretch.Height = PicCmpStretch.Image.Height + 2
        PicCmpZoomStretch.Location = New Point(PicCmpStretch.Location.X + PicCmpStretch.Size.Width + 6, PicCmpZoomStretch.Location.Y)
        Console.W("Compressed image by stretching to 20x20px")
        Me.Refresh()

        'Display compressed image at 5x size in picturebox:
        PicCmpZoomStretch.Image = bmStretch
        PicCmpZoomStretch.Width = (PicCmpZoomStretch.Image.Width * 5) + 2
        PicCmpZoomStretch.Height = (PicCmpZoomStretch.Image.Height * 5) + 2
        Me.Refresh()


        'Create 20x20 pixel image, fitted to size:
        Dim bmFit As New Bitmap(BMFitToSize(PicCrop.Image, 20))
        PicCmpFit.Image = bmFit

        'Display compressed image at real size in picturebox:
        PicCmpFit.Width = bmFit.Width + 2
        PicCmpFit.Height = bmFit.Height + 2
        PicCmpZoomFit.Location = New Point(PicCmpFit.Location.X + PicCmpFit.Size.Width + 6, PicCmpZoomFit.Location.Y)
        Console.W("Compressed image by fitting to 20x20px")
        Me.Refresh()

        'Display compressed image at 5x size in picturebox:
        PicCmpZoomFit.Image = bmFit
        PicCmpZoomFit.Width = (bmFit.Width * 5) + 2
        PicCmpZoomFit.Height = (bmFit.Height * 5) + 2
        'No UI refresh is required here as happens in a couple lines.

        Console.W("Image prepared for analysis successfully")
        Me.Refresh()




        '-------------------------------------------------------------------------------------------------------------------------------------------------------------



        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Create string from image:

        Dim bmstrStretch As String = CreatePixelString(bmStretch)

        Dim bmstrFit As String = CreatePixelString(bmFit)

        Console.W("Analysis string (stretch image mode) = " & bmstrStretch)
        If bmstrStretch.Length <> 400 Then Console.W("Warning: Analysis string is not equal in length to number of characters in image.")
        Console.W("Analysis string (fit image mode) = " & bmstrFit)
        If bmstrFit.Length <> 400 Then Console.W("Warning: Analysis string is not equal in length to number of characters in image.")

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------



        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Load training set from text file to array:

        Dim NumberOfTrainingItems As Integer = 0
        Dim sr As StreamReader
        Try
            NumberOfTrainingItems = File.ReadAllLines(TRAINING_SET_FILE_LOC).Length - 1
            sr = New StreamReader(TRAINING_SET_FILE_LOC)
        Catch
            Console.W("Error: Could not find training set file. Aborted operation.")
            Exit Sub
        End Try
        Dim TrainingSet(NumberOfTrainingItems - 1) As AIDataItem

        PrgBarCompare.Maximum = NumberOfTrainingItems

        Dim labelsfromTS() As String

        Dim TSWarning As Boolean = False
        Dim IsFirstReadLine As Boolean = True
        For i = 0 To TrainingSet.Length 'Loops for each line in text file (number of training set items, plus once more for the header line of the training set text file). Hence not 'For i = 0 to TrainingSet.Length - 1'.
            Try
                Dim ReadItem As String = sr.ReadLine()
                If IsFirstReadLine = True Then
                    If Strings.Left(ReadItem, 7) = "labels:" Then
                        labelsfromTS = Strings.Right(ReadItem, ReadItem.Length - 7).Split(",")
                        IsFirstReadLine = False
                    Else
                        Console.W("Error: Training set is an old version which does not support string labels. Aborted operation.")
                        Exit Sub
                    End If
                Else
                    TrainingSet(i - 1).Label = ReadItem.Split(":")(1)
                    TrainingSet(i - 1).PixelStringStretch = ReadItem.Split(":")(2)
                    If TSWarning <> True Then
                        Try
                            TrainingSet(i - 1).PixelStringFit = ReadItem.Split(":")(3)
                        Catch
                            TSWarning = True
                            Console.W("Warning: Training set only contains one analysis string.")
                        End Try
                    End If
                End If
            Catch
                Console.W("Error: Data could not be loaded from training set. Aborted operation.")
                Exit Sub
            End Try
        Next
        If TSWarning = True Then Console.W("Warning: Training set only contains one analysis string.")

        sr.Close()
        Console.W(NumberOfTrainingItems & " NN training data items loaded")

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------

        Dim NUMBER_OF_LABELS As Integer = labelsfromTS.Count

        Dim PossibleLabels(NUMBER_OF_LABELS - 1) As LabelIDs
        For i = 0 To NUMBER_OF_LABELS - 1
            PossibleLabels(i).name = labelsfromTS(i)
            PossibleLabels(i).ID = i
        Next



        Dim ClassificationModes() As String = CmbClassificationMode.Text.Split(",")


        Dim RankScores(NUMBER_OF_LABELS) As Integer


        For Each mode In ClassificationModes
            Dim ReturnedRankScores(NUMBER_OF_LABELS) As Integer
            ReturnedRankScores = CompareToChooseNN(bmstrStretch, bmstrFit, TrainingSet, PossibleLabels, mode)
            For i = 0 To ReturnedRankScores.Length - 1
                RankScores(i) += ReturnedRankScores(i)
            Next
        Next

        'Dim ChosenLabelID as integer
        Dim ChosenLabel As String
        Dim HighScore As Integer = -65535
        For i = 0 To RankScores.Count - 1
            If RankScores(i) > HighScore Then
                HighScore = RankScores(i)
                ChosenLabel = PossibleLabels(i).name
            End If
        Next

        Console.W("Classified as " & ChosenLabel & " using overall average from all classification functions (rank score = " & HighScore & ").")
        LblPrediction.Text = ("I think this is a " & ChosenLabel & ".")


    End Sub

    Function CompareToChooseNN(ByVal bmstrStretch As String, ByVal bmstrFit As String, ByVal TrainingSet() As AIDataItem, ByVal PossibleLabels() As LabelIDs, ByVal ClassificationMode As String) 'byval bm
        'Change it so that only the pixel string needed for the 
        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
        'Choose nearest neighbour from training data set array:


        'FOR AVERAGING
        Dim NUMBER_OF_LABELS As Integer = PossibleLabels.Count
        Dim AverageScores(NUMBER_OF_LABELS - 1) As ScoreRankAvg


        Dim ChosenLabel As String
        Dim HighestScore As Integer = -400

        Dim HighestScores(NUMBER_OF_LABELS - 1) As ScoreRank

        Dim CurrentComparisonLabel As LabelIDs
        Dim CurrentComparisonPixelString As String
        Dim CurrentScore As Integer = 0





        For Each item In TrainingSet
            CurrentScore = 0
            CurrentComparisonLabel.name = item.Label
            For Each Label In PossibleLabels
                If Label.name = CurrentComparisonLabel.name Then
                    CurrentComparisonLabel.ID = Label.ID
                    Exit For 'Once search is successful, exits the for loop so that the whole PossibleLabels array doesn't need to be searched once the matching label's ID is found. For efficiency/speed.
                End If
            Next

            If ClassificationMode = "stretch" Then

                CurrentComparisonPixelString = item.PixelStringStretch

                For i = 0 To 399
                    If CurrentComparisonPixelString(i) = bmstrStretch(i) Then : CurrentScore += 1
                    Else : CurrentScore -= 1
                    End If
                    'Try using AND logical operator
                Next

            ElseIf ClassificationMode = "fit" Then

                CurrentComparisonPixelString = item.PixelStringFit

                For i = 0 To 399
                    If CurrentComparisonPixelString(i) = bmstrFit(i) Then : CurrentScore += 1
                    Else : CurrentScore -= 1
                    End If
                    'Try using AND logical operator
                Next

            Else

                Console.W("Error: Unknown classification mode (stretch image, fit image, etc). Aborting operation.")
                Exit Function

            End If

            If CurrentScore > HighestScore Then
                HighestScore = CurrentScore
                ChosenLabel = CurrentComparisonLabel.name
            End If
            If CurrentScore > HighestScores(CurrentComparisonLabel.ID).score Then
                HighestScores(CurrentComparisonLabel.ID).score = CurrentScore
            End If
            If ChkShowComparisonScores.CheckState = CheckState.Checked Then
                Console.W("Compared against " & LCase(CurrentComparisonLabel.name) & " (using " & ClassificationMode & " image method), scored " & CurrentScore & " (" & (CurrentScore / 4) & "% similarity).")
            End If

            'FOR AVERAGING
            AverageScores(CurrentComparisonLabel.ID).score.sum += CurrentScore
            AverageScores(CurrentComparisonLabel.ID).score.n += 1


            'PrgBarCompare.Value += 1
        Next


        'FOR AVERAGING
        For i = 0 To NUMBER_OF_LABELS - 1
            AverageScores(i).score.sum /= AverageScores(i).score.n
            Console.W("Average score for " & ClassificationMode & " image " & PossibleLabels(i).name & " = " & (AverageScores(i).score.sum) / 4 & "%.")
        Next



        'Calculate highest score rankings by sorting highestscores array: (Needed as cannot order the array since the index of array elements = the label ID).
        Dim arraytoorder(HighestScores.Length() - 1) As Single
        For i = 0 To HighestScores.Length() - 1
            arraytoorder(i) = HighestScores(i).score
        Next
        Dim Ranks_HighScore() As Integer = GetArrayOrder(arraytoorder)
        For i = 0 To Ranks_HighScore.Length() - 1
            HighestScores(i).rank = Ranks_HighScore(i)
        Next

        For i = 0 To AverageScores.Length() - 1
            arraytoorder(i) = AverageScores(i).score.sum
        Next
        Dim Ranks_AvgScore() As Integer = GetArrayOrder(arraytoorder)
        For i = 0 To Ranks_AvgScore.Length() - 1
            AverageScores(i).rank = Ranks_AvgScore(i)
        Next

        Dim RankScores(NUMBER_OF_LABELS - 1) As Integer
        For i = 0 To NUMBER_OF_LABELS - 1
            RankScores(i) = Ranks_HighScore(i) + Ranks_AvgScore(i)
        Next


        For i = 0 To NUMBER_OF_LABELS - 1
            Console.W("Highest score for " & ClassificationMode & " image " & PossibleLabels(i).name & " = " & (HighestScores(i).score) / 4 & "% (rank score = " & HighestScores(i).rank & ").")
        Next

        Console.W("Classified as " & LCase(ChosenLabel) & " (using " & ClassificationMode & " image, highest similarity method), with " & Int(HighestScore / 4) & "% highest similarity.")






        Console.W("This took " & CountTimer.StopTimer() & " seconds.")

        Return RankScores

        '-------------------------------------------------------------------------------------------------------------------------------------------------------------
    End Function

    'This needs to be a separate function as the array to be sorted needs to be modified to sort it; by using a function a copy of the array can be modified instead.
    Function GetArrayOrder(ByVal array() As Single)
        Dim ranks(array.Count() - 1) As Integer
        Dim currentrank As Integer = array.Count()
        Dim MaxScore As Single
        Dim MaxScoreLabelID As Integer
        Do
            MaxScore = -65535
            For i = 0 To array.Count() - 1
                If array(i) > MaxScore Then
                    MaxScore = array(i)
                    MaxScoreLabelID = i
                End If
            Next
            array(MaxScoreLabelID) = -65535
            ranks(MaxScoreLabelID) = currentrank
            currentrank -= 1
        Loop Until currentrank = 0
        For Each element In ranks
            If element <= 0 Then Console.W("Warning: a possible label for the image has not been given a rank score. Final classification could be impacted.")
        Next
        Return ranks
    End Function


    'BEST: USE LOTS OF METHODS (HIGHEST SCORE, AVERAGE SCORE, AVERAGE OF TOP 10, ETC, ALL FOR BOTH STRETCHED AND TRUE SCALE IMAGES), EACH WITH A DIFFERENT WEIGHT, TO MAKE THE CLASSIFICATION DECISION.
    'e.g. highest score of 55 (with weighting, 55 * 2), average score of 25, added together = 80 (this is final score for a number, which the highest is then picked as the label).
    'Score for each method is the highest pct similarity - second highest, e.g. 50% for 9, 40% for 4 (second highest) --> final score is 10% for 9.


    'Better method:
    'Get score by using: total score for all iterations of a label, divided by number of instances of that label in the training data set.
    '(i.e. label's score (similarity) is the average of all of the same label in the training set.)
    'e.g. 5 squares, combined score is 1600, divided by 5 gives a score of 320 for square, then do this for all labels.
    'Finally, choose label with highest averaged score.
    'This will protect against incorrectly labelled data in test set, and also against one incorrect high score causing an incorrect classification.

    'Another improvement:
    'If similarity score is low (e.g. <65%, try rotating the image to try for a better similarity, in case input shape/digit is rotated.

    'Another improvement:
    'Also calculate average similarity score, if close to highest score then add 'I'm not sure what this is'. e.g. for shapes that are not in training data.
    'Average of top 10 scores?


    'DON'T STRETCH IMAGE TO 20X20PX IN PROCESSING, FIT IMAGE TO 20X20PX BY ADDING WHITE SPACE AT EDGES IF NECESSARY
    '(This will require a larger training set to function however, as shape of image will matter in classification if the image is not stretched)

    ' - For shapes: stretch to 20x20px
    ' - For numbers/letters: fit to 20x20px


    'Neuralnet

    ' - Look for string of continuous 1s = horizontal or vertical line (Create string in both x and y directions in order to find vertical and horizonal lines)
    ' - Look for 90 degree corners by observing horizonal and vertical lines ending in the same place.


    ' https://www.kaggle.com/scolianni/mnistasjpg#trainingSample.zip



















    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        mousePath.Reset()
        Dim g As Graphics = Graphics.FromImage(CanvasPredict.Image)
        g.FillRectangle(Brushes.White, 0, 0, CanvasPredict.Width, CanvasPredict.Height)
        CanvasPredict.Invalidate()
    End Sub











    Private Sub OpenTrainTab() Handles TabTrain.Enter
        Me.Width = 800
        Me.Height = 508
    End Sub
    Private Sub OpenPredictTab() Handles TabPredict.Enter
        Me.Width = 1100
        Me.Height = 774
    End Sub
    Private Sub OpenTabMNIST() Handles TabMNIST.Enter
        Me.Width = 984
        Me.Height = 327
    End Sub











    Private Sub BtnTrainAddToTSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrainAddToTSet.Click

        PrgBarCompare.Value = 0

        Dim bm As New Bitmap(CanvasTrain.Image)
        Dim label As String = CmbTrainLabelSelector.Text

        AddBMToTrainingSet(bm, label, False, False, True)

        'Clear canvas
        mousePath2.Reset()
        Dim g As Graphics = Graphics.FromImage(CanvasTrain.Image)
        g.FillRectangle(Brushes.White, 0, 0, CanvasTrain.Width, CanvasTrain.Height)
        CanvasTrain.Invalidate()

        LblTY.Visible = True
        TimerTY.Enabled = True
        BtnTrainAddToTSet.Enabled = False
        HasDrawnForTraining = False

    End Sub
    Private Sub TimerTY_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerTY.Tick
        LblTY.Visible = False
        PicTrainPrepped.Visible = False
        TimerTY.Enabled = False
    End Sub

    Private Sub BtnTrainTypeShape_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrainTypeShape.Click
        With BtnTrainTypeShape.FlatAppearance
            .BorderColor = Color.DarkTurquoise
            .BorderSize = 2
        End With
        With BtnTrainTypeNumber.FlatAppearance
            .BorderColor = Color.DarkGray
            .BorderSize = 1
        End With
    End Sub

    Private Sub BtnTrainTypeNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrainTypeNumber.Click
        With BtnTrainTypeNumber.FlatAppearance
            .BorderColor = Color.DarkTurquoise
            .BorderSize = 2
        End With
        With BtnTrainTypeShape.FlatAppearance
            .BorderColor = Color.DarkGray
            .BorderSize = 1
        End With
    End Sub








    Private Sub AddBMToTrainingSet(ByVal bm As Bitmap, ByVal label As String, ByVal NeedsConvertingToBW As Boolean, ByVal InvertBW As Boolean, ByVal FromCanvas As Boolean)

        bm = CompressBM(bm, 300)

        If NeedsConvertingToBW = True Or InvertBW = True Then bm = BMConvertToBW(bm, InvertBW)

        bm = BMCropToChar(bm)

        Dim bmstrStretch As String = CreatePixelString(BMStretchToSize(bm, 20, 20))
        Dim bmstrFit As String = CreatePixelString(BMFitToSize(bm, 20))

        If FromCanvas = True Then
            PicTrainPrepped.Image = bm
            PicTrainPrepped.Visible = True
        End If

        If File.Exists(TRAINING_SET_FILE_LOC) <> True Then
            File.Create(TRAINING_SET_FILE_LOC).Close()
            ConsoleTFTS.W("New training set file created.")
        End If

        Dim bmid As Integer = File.ReadAllLines(TRAINING_SET_FILE_LOC).Length + 1


        Dim firstline As String = File.ReadLines(TRAINING_SET_FILE_LOC)(0)
        If Strings.Left(firstline, 7) <> "labels:" Then
            With New StreamWriter(TRAINING_SET_FILE_LOC, True)
                .WriteLine("labels:" & label)
                .Close()
            End With
        Else
            firstline = Strings.Right(firstline, firstline.Length - 7)
            Dim IsLabelInTrainingSetIndex As Boolean = False
            For Each storedlabel In firstline.Split(",")
                If label = storedlabel Then IsLabelInTrainingSetIndex = True
            Next
            If IsLabelInTrainingSetIndex = False Then
                Dim TextFileLines() As String = File.ReadAllLines(TRAINING_SET_FILE_LOC)
                TextFileLines(0) &= "," & label
                With New StreamWriter(TRAINING_SET_FILE_LOC, False)
                    For Each line In TextFileLines
                        .WriteLine(line)
                    Next
                    .Close()
                End With
            End If
        End If


        'Write to training set
        Dim sw As New StreamWriter(TRAINING_SET_FILE_LOC, True)
        sw.WriteLine(bmid & ":" & label & ":" & bmstrStretch & ":" & bmstrFit)
        sw.Close()

    End Sub







    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TFTS_DisplayImageCheck()
    End Sub
    Private Sub TFTS_DisplayImageCheck()

        Dim FirstLabel As String = CmbPossLbls.Text.Split(",")(0)

        Dim InvertBW As Boolean = False
        If ChkInvertBW.Checked = True Then InvertBW = True

        Dim TrainingSetLoc As String = TxtDatasetLoc.Text
        If Strings.Right(TrainingSetLoc, 1) <> "\" Then TrainingSetLoc &= "\"

        Dim ImageFileType As String = CmbTSFileType.Text
        If ImageFileType.Contains(".") Then ImageFileType = ImageFileType.Replace(".", "")

        Dim file As String
        file = Directory.GetFiles(TrainingSetLoc & FirstLabel, "*." & ImageFileType)(0)
        Dim bm As New Bitmap(file)
        bm = New Bitmap(bm) 'Draws the bitmap from the image file (which has a colour palette and therefore has indexed pixels) onto a newly generated bitmap, returning a bitmap with non-indexed pixels. This is needed for functions which draw onto a bitmap, such as SetPixel, to operate.
        CompressBM(bm, 300)
        bm = BMConvertToBW(bm, InvertBW)
        PicTrainCheck.Image = bm


        'Hide/show UI elements after successfully loading preview image to a bitmap variable:
        PicTrainCheck.Visible = True
        LblTrainCheck.Visible = True
        BtnTrainCont.Visible = True
        BtnTrainAbort.Visible = True
        TFTSPrgBar.Visible = False
        TFTSLstConsole.Visible = False

    End Sub


    Private Sub BtnTrainCont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTrainCont.Click

        Dim TrainingSetLoc As String = TxtDatasetLoc.Text
        If Strings.Right(TrainingSetLoc, 1) <> "\" Then TrainingSetLoc &= "\"

        'Dim NumberOfImagesToAdd As Integer = Directory.GetFiles(TrainingSetLoc).Count()

        'Hide/show UI elements:
        With TFTSPrgBar
            .Visible = True
            .Value = 0
            '.Maximum = NumberOfImagesToAdd
            .Maximum = 1000 ' Arbitrary number
        End With
        TFTSLstConsole.Visible = True
        PicTrainCheck.Visible = False
        LblTrainCheck.Visible = False
        BtnTrainCont.Visible = False
        BtnTrainAbort.Visible = False


        Dim PossibleLabels() As String = CmbPossLbls.Text.Split(",")

        Dim InvertBW As Boolean = False
        If ChkInvertBW.Checked = True Then InvertBW = True

        Dim NeedsBWConversion As Boolean = False
        If ChkNeedsBWConversion.Checked = True Then NeedsBWConversion = True

        Dim ImageFileType As String = CmbTSFileType.Text
        If ImageFileType.Contains(".") Then ImageFileType = ImageFileType.Replace(".", "")

        'Variables for counting the number of images added and timing the process:
        Dim count As Integer = 0
        CountTimer.StartTimer()


        For Each label In PossibleLabels
            Dim path As String = TrainingSetLoc & label

            Dim files As String()
            Dim bm As Bitmap
            files = Directory.GetFiles(path, "*." & ImageFileType)
            For Each File In files
                bm = New Bitmap(File)
                bm = New Bitmap(bm)
                AddBMToTrainingSet(bm, label, NeedsBWConversion, InvertBW, False) 'Should be image not canvas, but this switches off the b/w conversion to improve speed with big images.
                TFTSPrgBar.PerformStep()
                ConsoleTFTS.W(Strings.Right(File, Len(File) - Len(path)) & " has been added to the training set.")
                Me.Refresh()
                count += 1
            Next
        Next

        ConsoleTFTS.W("Training set creation complete. " & count & " items were added in " & CountTimer.StopTimer() & " seconds.")

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTSFileType.SelectedIndexChanged
        If CmbTSFileType.Text = "Other" Then TxtTSOtherFileType.Enabled = True Else TxtTSOtherFileType.Enabled = False
    End Sub


    Private Sub ChkNeedsBWConversion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkNeedsBWConversion.CheckedChanged
        If ChkNeedsBWConversion.CheckState = CheckState.Checked Then
            ChkInvertBW.Enabled = True
        Else
            With ChkInvertBW
                .CheckState = CheckState.Unchecked
                .Enabled = False
            End With
        End If
    End Sub

End Class