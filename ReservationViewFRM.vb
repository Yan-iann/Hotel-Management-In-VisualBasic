Imports IBM.Data.DB2
Public Class ReservationViewFRM
    Dim HotelConn As Common.DbConnection
    Private Sub ReservationViewFRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Try
            HotelConn = New DB2Connection("server=localhost;database=hotel;" + "uid = db2admin;password=db2admin;")
            HotelConn.Open()
            ReservationView.ReadOnly = True
            ReservationView.AllowUserToResizeRows = False
            ReservationView.AllowUserToResizeColumns = False
            With Me.ReservationView
                .ColumnCount = 7
                .Columns(0).Name = "Reservation ID"
                .Columns(1).Name = "Guest ID"
                .Columns(2).Name = "Check In"
                .Columns(3).Name = "Check Out"
                .Columns(4).Name = "Room ID"
                .Columns(5).Name = "Status"
                .Columns(6).Name = "No Of Guest"
            End With

            str = "select * from table(REFRESHTABLERESERVATION())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6)}
                Me.ReservationView.Rows.Add(row)
            End While
            rdr.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ReservationView_MouseUp(sender As Object, e As MouseEventArgs) Handles ReservationView.MouseUp
        Me.reserveNoTxt.Text = Me.ReservationView.CurrentRow.Cells(0).Value
        Me.guestIdTxt.Text = Me.ReservationView.CurrentRow.Cells(1).Value
        Me.checkInTxt.Text = Me.ReservationView.CurrentRow.Cells(2).Value
        Me.checkOutTxt.Text = Me.ReservationView.CurrentRow.Cells(3).Value
        Me.roomIdTxt.Text = Me.ReservationView.CurrentRow.Cells(4).Value
        Me.statusTxt.Text = Me.ReservationView.CurrentRow.Cells(5).Value
        Me.noGuestTxt.Text = Me.ReservationView.CurrentRow.Cells(6).Value


        Dim str As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim p1, p2
        Try
            str = "Call GETGUESTNAME(?,?)"
            cmd = New DB2Command(str, HotelConn)

            p1 = cmd.Parameters.Add("@n1", DB2Type.Integer)
            p1.Direction = ParameterDirection.Input
            cmd.Parameters("@n1").Value = Me.guestIdTxt.Text

            p2 = cmd.Parameters.Add("@n2", DB2Type.VarChar)
            p2.Direction = ParameterDirection.Output
            rdr = cmd.ExecuteReader
            Me.guestNameTxt.Text = p2.Value.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String
        Dim str2 As String
        Dim cmd As DB2Command
        Dim rdr As DB2DataReader
        Dim row As String()
        Dim p1, p2
        Dim Answer As Integer

        Try
            Answer = MsgBox("Are you sure you want to update the Guest '" & Me.ReservationView.CurrentRow.Cells(1).Value & "' ?", vbQuestion + vbYesNo + vbDefaultButton2, "Delete Confirmation")
            If answer = vbYes Then
                str = "Call UPDATERESERVATION(?,?)"
                cmd = New DB2Command(str, HotelConn)

                p1 = cmd.Parameters.Add("@n1", DB2Type.VarChar)
                p1.Direction = ParameterDirection.Input
                cmd.Parameters("@n1").Value = Me.statusTxt.Text

                p2 = cmd.Parameters.Add("@n2", DB2Type.Integer)
                p2.Direction = ParameterDirection.Input
                cmd.Parameters("@n2").Value = Me.reserveNoTxt.Text

                rdr = cmd.ExecuteReader
            End If
            str = "select * from table(REFRESHTableRESERVATION())As udf"
            cmd = New DB2Command(str, HotelConn)
            rdr = cmd.ExecuteReader
            Me.ReservationView.Rows.Clear()
            While rdr.Read
                row = New String() {rdr.GetString(0), rdr.GetString(1), rdr.GetString(2), rdr.GetString(3), rdr.GetString(4), rdr.GetString(5), rdr.GetString(6)}
                Me.ReservationView.Rows.Add(row)
            End While
            rdr.Close()


            MsgBox("Record Succesfully Updated")
            Call clear()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub clear()
        Me.reserveNoTxt.Clear()
        Me.guestIdTxt.Clear()
        Me.checkInTxt.Clear()
        Me.checkOutTxt.Clear()
        Me.roomIdTxt.Clear()
        Me.noGuestTxt.Clear()
        Me.guestNameTxt.Clear()
        Me.guestIdTxt.Focus()
    End Sub
End Class