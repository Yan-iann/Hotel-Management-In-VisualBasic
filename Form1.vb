Imports IBM.Data.DB2
Public Class Form1
    Dim HotelConn As Common.DbConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Try
            HotelConn = New DB2Connection("server=localhost;database=hotel;" + "uid = db2admin;password=db2admin;")
            HotelConn.Open()
            RoomView.ReadOnly = True
            RoomView.AllowUserToResizeRows = False
            RoomView.AllowUserToResizeColumns = False
            With Me.RoomView
                .ColumnCount = 4
                .Columns(0).Name = "Room ID"
                .Columns(1).Name = "Room Type"
                .Columns(2).Name = "Room Cost"
                .Columns(3).Name = "Rooms Available"
            End With

            str = "select * from table(REFRESHTableROOM())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
                Me.RoomView.Rows.Add(row)
            End While
            rdr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim roomId As String
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()

        roomId = roomIdTxt.Text
        str = "select * from table(GetRoomTable('" & roomId & "'))As udf"

        cmd = New DB2Command(str, HotelConn)
        rdr = cmd.ExecuteReader
        While rdr.Read
            row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
            Me.RoomView.Rows.Add(row)
        End While
        rdr.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        HotelConn.Close()
        Me.Close()

    End Sub

    Private Sub RoomView_MouseUp(sender As Object, e As MouseEventArgs) Handles RoomView.MouseUp
        Me.roomIdText.Text = Me.RoomView.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Dim p1, p2, p3, p4, p5, p6, p7
        Try
            str = "Call RESERVATIONINSERT(?,?,?,?,?,?)"
            cmd = New DB2Command(str, HotelConn)

            p1 = cmd.Parameters.Add("@n1", DB2Type.Integer)
            p1.Direction = ParameterDirection.Input
            cmd.Parameters("@n1").Value = guestIdTxt.Text

            p2 = cmd.Parameters.Add("@n2", DB2Type.VarChar)
            p2.Direction = ParameterDirection.Input
            cmd.Parameters("@n2").Value = checkInTxt.Text

            p3 = cmd.Parameters.Add("@n3", DB2Type.VarChar)
            p3.Direction = ParameterDirection.Input
            cmd.Parameters("@n3").Value = checkOutTxt.Text

            p4 = cmd.Parameters.Add("@n4", DB2Type.Integer)
            p4.Direction = ParameterDirection.Input
            cmd.Parameters("@n4").Value = roomIdText.Text

            p5 = cmd.Parameters.Add("@n5", DB2Type.VarChar)
            p5.Direction = ParameterDirection.Input
            cmd.Parameters("@n5").Value = statusTxt.Text

            p6 = cmd.Parameters.Add("@n6", DB2Type.Integer)
            p6.Direction = ParameterDirection.Input
            cmd.Parameters("@n6").Value = noGuestTxt.Text
            rdr = cmd.ExecuteReader



            str = "select * from table(REFRESHTableROOM())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            Me.RoomView.Rows.Clear()
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
                Me.RoomView.Rows.Add(row)
            End While
            rdr.Close()

            MessageBox.Show("Reservation Succesful")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ReservationViewFRM.Show()
    End Sub

    Private Sub clear()
        Me.guestIdTxt.Clear()
        Me.checkInTxt.Clear()
        Me.checkOutTxt.Clear()
        Me.roomIdText.Clear()
        Me.noGuestTxt.Clear()
        Me.guestIdTxt.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Try
            str = "select * from table(REFRESHTableROOM())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            Me.RoomView.Rows.Clear()
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3)}
                Me.RoomView.Rows.Add(row)
            End While
            rdr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub NOEntry()

    End Sub
End Class
