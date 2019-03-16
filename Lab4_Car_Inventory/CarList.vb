Option Strict On


Public Class frmCarList

    Private carList As New SortedList
    Private currentCarIdentificationNumber As String = String.Empty
    Private editMode As Boolean = False


    Private Sub Reset()


        tbModel.Text = String.Empty
        tbPrice.Text = String.Empty
        chkNew.Checked = False
        cmbYear.SelectedIndex = -1
        cmbMake.SelectedIndex = -1
        lblResult.Text = String.Empty

        currentCarIdentificationNumber = String.Empty

    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim car As Cars
        Dim carItem As ListViewItem



        ' validate the data in the form
        If IsValidInput() = True Then

            ' set the edit flag to true
            editMode = True

            ' 
            lblResult.Text = "It worked!"

            If currentCarIdentificationNumber.Trim.Length = 0 Then


                car = New Cars(cmbMake.Text, tbModel.Text, CInt(cmbYear.Text), CInt(tbPrice.Text), chkNew.Checked)

                carList.Add(car.IdentificationNumber.ToString(), car)

            Else

                car = CType(carList.Item(currentCarIdentificationNumber), Cars)

                ' update the data in the specific object
                ' from the controls
                car.Make = cmbMake.Text
                car.Model = tbModel.Text
                car.Year = CInt(cmbYear.Text)
                car.Price = CInt(tbPrice.Text)
                car.NewStatus = chkNew.Checked
            End If


            lvwCar.Items.Clear()


            For Each carEntry As DictionaryEntry In carList


                carItem = New ListViewItem()


                car = CType(carEntry.Value, Cars)


                carItem.Checked = car.NewStatus
                carItem.SubItems.Add(car.IdentificationNumber.ToString())
                carItem.SubItems.Add(car.Make)
                carItem.SubItems.Add(car.Model)
                carItem.SubItems.Add((car.Year).ToString)
                carItem.SubItems.Add((car.Price).ToString)


                lvwCar.Items.Add(carItem)

            Next carEntry


            ' clear the controls
            Reset()


            editMode = False

        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Reset()
    End Sub



    Private Function IsValidInput() As Boolean

        Dim returnValue As Boolean = True
        Dim outputMessage As String = String.Empty


        If cmbMake.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's Make." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If


        If tbModel.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's Model." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If cmbYear.SelectedIndex = -1 Then

            ' If not set the error message
            outputMessage += "Please select the car's Year." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If tbPrice.Text.Trim.Length = 0 Then

            ' If not set the error message
            outputMessage += "Please enter the car's Price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If

        If Not IsNumeric(tbPrice.Text) Then

            ' If not set the error message
            outputMessage += "Please enter the  numeric value of car's Price." & vbCrLf

            ' And, set the return value to false
            returnValue = False

        End If
        ' check to see if any value
        ' did not validate
        If returnValue = False Then

            ' show the message(s) to the user
            lblResult.Text = "ERRORS" & vbCrLf & outputMessage

        End If

        ' return the boolean value
        ' true if it passed validation
        ' false if it did not pass validation
        Return returnValue

    End Function



    Private Sub lvwCar_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCar.ItemCheck
        ' if it is not in edit mode
        If editMode = False Then


            e.NewValue = e.CurrentValue

        End If

    End Sub

    Private Sub lvwCar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCar.SelectedIndexChanged

        Const identificationSubItemIndex As Integer = 1


        currentCarIdentificationNumber = lvwCar.Items(lvwCar.FocusedItem.Index).SubItems(identificationSubItemIndex).Text


        Dim car As Cars = CType(carList.Item(currentCarIdentificationNumber), Cars)

        ' set the controls on the form
        tbModel.Text = car.Model
        tbPrice.Text = (car.Price).ToString
        cmbMake.Text = car.Make
        cmbYear.Text = (car.Year).ToString

        chkNew.Checked = car.NewStatus

        lblResult.Text = car.GetSalutation()


    End Sub
End Class
