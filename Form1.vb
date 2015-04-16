Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Item As String = TextBox1.Text.ToString()
        Dim index As Integer = ListBox1.FindString(Item)
        If index = -1 Then
            ListBox1.SelectedIndex = ListBox1.SelectedIndex
        Else
            ListBox1.SetSelected(index, True)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "abacus" Then
            TextBox2.Text = "A manual computing device consisting of a frame holding parallel rods strung with movable counters."
        ElseIf TextBox1.Text = "abash" Then
            TextBox2.Text = "To make ashamed or uneasy; disconcert."
        Else
            'A message box will show up if the entered word is not found
            MsgBox("No mathcing results where found")

        End If

    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        TextBox1.Text = ListBox1.SelectedItem
        Button1.PerformClick()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The following code will get the words from a text file and put them into the dictionary
        Dim reader As IO.StreamReader = New IO.StreamReader("C:\Users\Eisner\Documents\Visual Studio 2013\Projects\txtdictionary\txtdictionary\bin\words.txt")
        Do While reader.EndOfStream = False
            ListBox1.Items.Add(reader.ReadLine)
        Loop
        reader.Close()
        'The following code will ensure that words are listed in alphabetical order.
        ListBox1.Sorted = True

    End Sub
End Class
