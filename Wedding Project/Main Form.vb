' Project Name: Wedding Project
' Purpose: To display the number of Tables needed at the Wedding
' Programmer: Andrew Kuykendall on 9/29/2017 - Row 2

Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private Sub txtGuests_TextChanged(sender As Object, e As EventArgs) Handles txtGuests.TextChanged
        lblTables.Text = String.Empty

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim dlgResult As DialogResult
        dlgResult = MessageBox.Show("Are you sure you want to exit?", "Exit?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dlgResult = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Constants and Variables
        Dim intGuests As Integer
        Const intPer_Table As Integer = 8
        Dim dblTables_Needed As Double
        Integer.TryParse(txtGuests.Text, intGuests)

        'Calculate Tables Needed (0.49 will force it to round up to the nearest table if there's an extra guest left over)
        If intGuests > 8 Then
            dblTables_Needed = (intGuests / intPer_Table) + 0.49
        Else
            dblTables_Needed = 1

        End If
        lblTables.Text = dblTables_Needed.ToString("N0")

    End Sub

    Private Sub txtGuests_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _
        txtGuests.KeyPress
        ' box only accepts numbers and backspace
        If (e.KeyChar < "0" Or e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtGuests_Enter(sender As Object, e As EventArgs) Handles txtGuests.Enter
        txtGuests.SelectAll()

    End Sub
End Class
