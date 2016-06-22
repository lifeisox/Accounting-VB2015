Imports System.ComponentModel

Public Class IncomeForm
    Private MaxQueryCount As Integer = 12
    Private Enum queryENUM
        READ_SLIP_ALL
        READ_SLIP
        READ_SLIPITEM_ALL
        INSERT_SLIP
        INSERT_SLIPITEM
        UPDATE_SLIP
        DELETE_SLIP
        DELETE_SLIPITEM
        READ_MEMBER
        READ_DEDICATOR
        READ_ACCOUNT
        READ_DEDICATOR_FOR_MEMBER
    End Enum
    Private _SQL(MaxQueryCount) As String
    Private _Conn As SqlConnection = Nothing
    Private _FirstSW As Boolean = True
    Private _AddSW As Boolean = False
    Private _UpdateSW As Boolean = False
    Private _ChangedSW As Boolean = False
    Private _jobDate As Date
    Private _Index As Integer

    Private _lblItem() As Label
    Private _accountCode() As String
    Private _txtItem() As NumericUpDown
    Private _chkItem() As CheckBox

    Private Const CntlLblLeft As Integer = 10
    Private Const CntlTxtLeft As Integer = 136
    Private Const CntlChkLeft As Integer = 216
    Private Const CntlLblWidth As Integer = 120
    Private Const CntlTxtWidth As Integer = 90
    Private Const CntlHeight As Integer = 23
    Private Const CntlTop As Integer = 76
    Private Const CntlYGap As Integer = 29
    Private Const CntlXGap As Integer = 230

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        _SQL(queryENUM.READ_SLIP_ALL) = "
            SELECT s.SlipNo, s.MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, 
                IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', 
                EnglishName, ')'))) AS ViewName, CheckAmount + CashAmount AS ViewAmount 
            FROM Tbl_Slip s, Tbl_Member m
            WHERE m.MemberCode = s.MemberCode AND s.SlipDate = @SlipDate
            ORDER BY s.SlipNo
        "
        _SQL(queryENUM.READ_SLIP) = "
            SELECT s.MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, 
                IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', 
                EnglishName, ')'))) AS ViewName, CheckAmount + CashAmount AS ViewAmount, s.Remark 
            FROM Tbl_Slip s, Tbl_Member m
            WHERE m.MemberCode = s.MemberCode AND s.SlipNo = @SlipNo
        "
        _SQL(queryENUM.READ_SLIPITEM_ALL) = "
            SELECT SlipNo, SlipSeq, i.AccountCode, IIF(AccountNameKr IS NULL OR AccountNameKr = '', 
                AccountName, IIF(AccountName Is NULL Or AccountName = '', AccountNameKr, 
                CONCAT(AccountNameKr, '(', AccountName, ')'))) AS ViewName, i.Amount, i.HST 
            FROM Tbl_SlipItem i, Tbl_Account a
            WHERE a.AccountCode = i.AccountCode AND SlipNo = @SlipNo
        "
        _SQL(queryENUM.INSERT_SLIP) = "
            INSERT INTO Tbl_Slip ( [SlipDate], [MemberCode], [Division], [CashAmount], [Remark] ) 
                VALUES ( @SlipDate, @MemberCode, @Division, @CashAmount, @Remark );
            SELECT CAST(SCOPE_IDENTITY() AS Int);
        "
        _SQL(queryENUM.INSERT_SLIPITEM) = "
            INSERT INTO Tbl_SlipItem ( [SlipNo], [SlipSeq], [AccountCode], [Amount] ) 
                VALUES ( @SlipNo, @SlipSeq, @AccountCode, @Amount )
        "
        _SQL(queryENUM.UPDATE_SLIP) = "
            UPDATE Tbl_Slip SET [CashAmount] = @CashAmount, [Remark] = @Remark
            WHERE SlipNo = @SlipNo
        "
        _SQL(queryENUM.DELETE_SLIP) = "
            DELETE FROM Tbl_Slip 
            WHERE SlipNo = @SlipNo
        "
        _SQL(queryENUM.DELETE_SLIPITEM) = "
            DELETE FROM Tbl_SlipItem 
            WHERE SlipNo = @SlipNo AND SlipSeq = @SlipSeq
        "
        _SQL(queryENUM.READ_MEMBER) = "
            SELECT MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, 
                IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', 
                EnglishName, ')'))) AS ViewName 
            FROM Tbl_Member
            ORDER BY ViewName
        "
        _SQL(queryENUM.READ_DEDICATOR) = "
            SELECT DedicatorCode
            FROM Tbl_Dedicator
            WHERE DedicatorYear = @DedicatorYear AND MemberCode = @MemberCode
        "
        _SQL(queryENUM.READ_ACCOUNT) = "
            SELECT AccountCode, IIF(AccountName IS NULL OR AccountName = '', AccountNameKr, 
                AccountName) AS ViewAccountName 
            FROM Tbl_Account
            WHERE AccountYear = @AccountYear AND IsComputed = 'N' AND Division = 'I' AND
                AccountCode LIKE '00%'
            ORDER BY AccountCode
        "
        _SQL(queryENUM.READ_DEDICATOR_FOR_MEMBER) = "
            SELECT DedicatorCode, d.MemberCode, IIF(KoreanName IS NULL OR KoreanName = '', EnglishName, 
                IIF(EngLishName Is NULL Or EnglishName = '', KoreanName, CONCAT(KoreanName, '(', 
                EnglishName, ')'))) AS DedicatorName 
            FROM Tbl_Dedicator d, Tbl_Member m
            WHERE DedicatorYear = @DedicatorYear AND m.MemberCode = d.MemberCode AND
                 DedicatorCode = @DedicatorCode
        "

        _Conn = New SqlConnection(My.Settings.DbConn)
        _Conn.Open()
    End Sub

    Protected Overrides Sub Finalize()
        _Conn.Close()
        MyBase.Finalize()
    End Sub

    Private Sub IncomeForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        checkChangedField()
    End Sub

    Private Sub IncomeForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        If _FirstSW = True Then
            _Index = 0
            _jobDate = calSlipDate.TodayDate ' yyyy-mm-dd
            lblSlipDate.Text = FormatDateTime(_jobDate, DateFormat.LongDate)
            fillComboData()
            fillGrid()
            _FirstSW = False
        End If
    End Sub

    Private Sub menuButtons_Click(sender As Object, e As EventArgs) Handles newTSB.Click, deleteTSB.Click,
        firstTSB.Click, previousTSB.Click, nextTSB.Click, lastTSB.Click, refreshTSB.Click, saveTSB.Click,
        closeTSB.Click

        If sender.Name <> "saveTSB" Then
            checkChangedField()
        End If

        Select Case sender.Name
            Case "newTSB"
                clearAllFields()
            Case "deleteTSB" : deleteCurrentRecord()
            Case "firstTSB"
                grdSlip.CurrentCell = grdSlip(0, 0)
            Case "previousTSB"
                If grdSlip.CurrentRow.Index > 0 Then
                    grdSlip.CurrentCell = grdSlip(0, grdSlip.CurrentRow.Index - 1)
                End If
            Case "nextTSB"
                If grdSlip.CurrentRow.Index < grdSlip.RowCount - 1 Then
                    grdSlip.CurrentCell = grdSlip(0, grdSlip.CurrentRow.Index + 1)
                End If
            Case "lastTSB" : grdSlip.CurrentCell = grdSlip(0, grdSlip.RowCount - 1)
            Case "refreshTSB" : fillGrid()
            Case "saveTSB" : saveCurrentRecord()
            Case "closeTSB" : Close()
        End Select
    End Sub

    Private Sub calSlipDate_DateChanged(sender As Object, e As DateRangeEventArgs) Handles calSlipDate.DateChanged
        _jobDate = e.End
        lblSlipDate.Text = FormatDateTime(_jobDate, DateFormat.LongDate)
        fillGrid()
    End Sub

    Private Sub grdSlip_CurrentCellChanged(sender As Object, e As EventArgs) Handles grdSlip.CurrentCellChanged
        checkChangedField()
        If grdSlip.SelectedRows.Count <> 1 Then Return

        Dim index As Integer = grdSlip.SelectedRows(0).Index
        If grdSlip.SelectedRows.Count = 1 And index <= grdSlip.Rows.Count - 1 And _FirstSW = False Then
            fillData(grdSlip("SlipNo", index).Value)
        End If
    End Sub

    Private Sub checkChangedField()
        If (_AddSW = True Or _UpdateSW = True) And _ChangedSW = True Then
            Dim result As DialogResult = MessageBox.Show("There are some changed data. Save it?",
                "Confirmation To save", MessageBoxButtons.YesNo)
            If result = vbYes Then
                saveCurrentRecord()
            Else
                _AddSW = False
                _UpdateSW = False
                _ChangedSW = False
            End If
        End If
    End Sub

    Private Sub enableAllToolStripButton(ByVal status As Boolean)
        For Each menu As ToolStripItem In menuTS.Items
            If TypeOf menu Is ToolStripButton And menu.Name <> "closeTSB" Then
                menu.Enabled = status
            End If
        Next
    End Sub

    Private Sub fillComboData()
        cboMemberName.DataSource = GetMemberItems()
        cboMemberName.DisplayMember = "Name"
        cboMemberName.ValueMember = "Code"

        Dim mok, nam As Integer
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_ACCOUNT), _Conn)
        cmd.Parameters.Add("@AccountYear", SqlDbType.Char).Value = _jobDate.Year
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        _Index = 0
        If rdr.HasRows Then
            While rdr.Read()
                ReDim Preserve _lblItem(_Index)
                ReDim Preserve _accountCode(_Index)
                ReDim Preserve _txtItem(_Index)
                ReDim Preserve _chkItem(_Index)
                _lblItem(_Index) = New Label
                _txtItem(_Index) = New NumericUpDown
                _chkItem(_Index) = New CheckBox
                mok = _Index \ 6
                nam = _Index Mod 6

                With _lblItem(_Index)
                    .Location = New Point(CntlLblLeft + mok * CntlXGap, CntlTop + nam * CntlYGap)
                    .Size = New Drawing.Size(CntlLblWidth, CntlHeight)
                    .TextAlign = ContentAlignment.MiddleRight
                    .Text = rdr("ViewAccountName") + ":"
                    .TabStop = False
                End With

                With _txtItem(_Index)
                    .Location = New Point(CntlTxtLeft + mok * CntlXGap, CntlTop + nam * CntlYGap)
                    .Size = New Drawing.Size(CntlTxtWidth, CntlHeight)
                    .TextAlign = HorizontalAlignment.Right
                    .Maximum = 9999999.99
                    .Minimum = -9999999.99
                    .DecimalPlaces = 2
                    .ThousandsSeparator = True
                    .TabIndex = _Index + 2
                    .TabStop = True
                    .Name = "txtBox" & _Index.ToString()
                    ' Disappear Updown button
                    .Region = New Region(New Rectangle(0, 0, .Width - .Controls(0).Width + 1, .Height))
                    AddHandler .GotFocus, AddressOf TextBox_GotFocus
                    AddHandler .KeyDown, AddressOf TextBox_KeyDown
                    AddHandler .ValueChanged, AddressOf TextBox_ValueChanged
                    If Not (_Index < 3 Or _Index = 4 Or _Index = 5) Then .Enabled = False
                End With

                With _chkItem(_Index)
                    .Location = New Point(CntlChkLeft + mok * CntlXGap, CntlTop + nam * CntlYGap)
                    .Size = New Drawing.Size(40, CntlHeight)
                    .Text = "On"
                    .TabStop = False
                    .Checked = IIf(_Index < 3 Or _Index = 4 Or _Index = 5, True, False)
                    .Name = "chkBox" & _Index.ToString()
                    AddHandler .CheckedChanged, AddressOf CheckBox_CheckedChanged
                End With

                pnlMain.Controls.Add(_lblItem(_Index))
                pnlMain.Controls.Add(_txtItem(_Index))
                pnlMain.Controls.Add(_chkItem(_Index))

                _accountCode(_Index) = rdr("AccountCode")
                _Index = _Index + 1
            End While
            rdr.Close()
        Else
            rdr.Close()
            MessageBox.Show("An error occured because there are no account code data.", "Data Error", MessageBoxButtons.OK)
            Close()
        End If
    End Sub

    Private Sub TextBox_GotFocus(sender As Object, e As EventArgs)
        Dim obj As NumericUpDown = DirectCast(sender, NumericUpDown)
        obj.Select(0, obj.ToString.Length)
    End Sub

    Private Sub TextBox_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Dim obj As NumericUpDown = DirectCast(sender, NumericUpDown)
            Dim idx = CInt(obj.Name.Substring(6))
            Dim lastControl = True
            For i As Integer = idx + 1 To _txtItem.Length - 1
                If _txtItem(i).Enabled = True Then
                    lastControl = False
                    Exit For
                End If
            Next
            If lastControl Then
                txtRemark.Focus()
            Else
                SendKeys.Send("{TAB}")
            End If
            e.SuppressKeyPress = True   'This will prevent ding sound.
        End If
    End Sub

    Private Sub TextBox_ValueChanged(sender As Object, e As EventArgs)
        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        Dim obj As CheckBox = DirectCast(sender, CheckBox)
        Dim idx = CInt(obj.Name.Substring(6))
        If _AddSW = True Or _UpdateSW = True Then
            If obj.Checked = False And _txtItem(idx).Value <> 0 Then
                obj.Checked = True
            Else
                _txtItem(idx).Enabled = IIf(obj.Checked, True, False)
            End If
        End If
    End Sub

    Private Sub txtDedicatorCode_GotFocus(sender As Object, e As EventArgs) Handles txtDedicatorCode.GotFocus
        SendKeys.Send("{DEL}")
    End Sub

    Private Sub txtDedicatorCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDedicatorCode.KeyDown, cboMemberName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRemark.Focus()
            e.SuppressKeyPress = True   'This will prevent ding sound.
        End If
    End Sub

    Private Sub cboMemberName_Validating(sender As Object, e As CancelEventArgs) Handles cboMemberName.Validating
        If _AddSW = False Then Exit Sub
        If cboMemberName.SelectedIndex < 0 Then
            MessageBox.Show("You have to select a member at least.",
                "No Selection", MessageBoxButtons.OK)
            cboMemberName.Focus()
            e.Cancel = True
        Else
            txtDedicatorCode.Text = ""
            txtRemark.Focus()
        End If
    End Sub

    Private Sub txtDedicatorCode_Validating(sender As Object, e As CancelEventArgs) Handles txtDedicatorCode.Validating
        If _AddSW = False Then Exit Sub

        If txtDedicatorCode.Text.Length = 3 Then
            Dim cmd As New SqlCommand(_SQL(queryENUM.READ_DEDICATOR_FOR_MEMBER), _Conn)
            cmd.Parameters.Add("@DedicatorYear", SqlDbType.Char).Value = _jobDate.Year
            cmd.Parameters.Add("@DedicatorCode", SqlDbType.Char).Value = txtDedicatorCode.Text
            Dim rdr As SqlDataReader = cmd.ExecuteReader()
            If rdr.HasRows Then
                rdr.Read()
                cboMemberName.SelectedValue = rdr("MemberCode")
                txtRemark.Focus()
            Else
                MessageBox.Show("The code has not registered before. Use an another code!",
                "Can't Find the code", MessageBoxButtons.OK)
                txtDedicatorCode.Focus()
                e.Cancel = True
            End If
            rdr.Close()
        Else
            txtDedicatorCode.Text = ""
            cboMemberName.Focus()
        End If
    End Sub

    Private Sub txtRemark_GotFocus(sender As Object, e As EventArgs) Handles txtRemark.GotFocus
        txtRemark.Select()
    End Sub

    Private Sub txtRemark_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRemark.KeyDown
        If e.KeyCode = Keys.Enter Then
            _txtItem(0).Focus()
            e.SuppressKeyPress = True   'This will prevent ding sound.
        End If
    End Sub

    Private Sub txtRemark_TextChanged(sender As Object, e As EventArgs) Handles txtRemark.TextChanged
        If _AddSW = True Or _UpdateSW = True Then
            _ChangedSW = True
            saveTSB.Enabled = True
        End If
    End Sub

    Private Sub fillGrid()
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_SLIP_ALL), _Conn)
        cmd.Parameters.Add("@SlipDate", SqlDbType.Date).Value = _jobDate

        grdSlip.RowCount = 0

        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            While rdr.Read()
                grdSlip.Rows.Add(rdr("SlipNo"), rdr("MemberCode"), rdr("ViewName"), rdr("ViewAmount"))
            End While
            rdr.Close()
            grdSlip.CurrentCell = grdSlip(0, grdSlip.RowCount - 1)
            fillData(grdSlip.CurrentCell.Value)
            enableAllToolStripButton(True)
            saveTSB.Enabled = False
        Else
            rdr.Close()
            EnabletxtItem(False)
            grdSlipItem.RowCount = 0
            enableAllToolStripButton(False)
            newTSB.Enabled = True
        End If
    End Sub

    Private Sub fillData(ByVal code As Integer)
        ' Initialize offering input
        EnabletxtItem(True)
        txtDedicatorCode.Enabled = False
        cboMemberName.Enabled = False
        ' Read Slip table
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_SLIP), _Conn)
        cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = code
        Dim rdr As SqlDataReader = cmd.ExecuteReader()
        If rdr.HasRows Then
            rdr.Read()
            cboMemberName.SelectedValue = rdr("MemberCode")
            txtRemark.Text = rdr("Remark")
            txtRemark.Enabled = True
            rdr.Close()
            ' Find Dedicator code
            cmd.CommandText = _SQL(queryENUM.READ_DEDICATOR)
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@DedicatorYear", SqlDbType.Char).Value = _jobDate.Year
            cmd.Parameters.Add("@MemberCode", SqlDbType.Char).Value = cboMemberName.SelectedValue
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                rdr.Read()
                txtDedicatorCode.Text = rdr("DedicatorCode")
            Else
                txtDedicatorCode.Text = ""
            End If
            rdr.Close()
            ' Read SlipItem table
            grdSlipItem.RowCount = 0
            cmd.CommandText = _SQL(queryENUM.READ_SLIPITEM_ALL)
            cmd.Parameters.Clear()
            cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = code
            rdr = cmd.ExecuteReader()
            If rdr.HasRows Then
                While rdr.Read()
                    For i As Integer = 0 To _txtItem.Length - 1
                        If _accountCode(i) = rdr("AccountCode") Then
                            _txtItem(i).Value = rdr("Amount")
                            _txtItem(i).Enabled = True
                            _chkItem(i).Checked = True
                            Exit For
                        End If
                    Next
                    grdSlipItem.Rows.Add(rdr("SlipSeq"), rdr("AccountCode"), rdr("ViewName"), rdr("Amount"))
                End While
            End If
            rdr.Close()
        Else
            rdr.Close()
        End If

        _UpdateSW = True
        _ChangedSW = False
        _AddSW = False

        newTSB.Enabled = True
        saveTSB.Enabled = False
        deleteTSB.Enabled = True

        txtRemark.Focus()
    End Sub

    Private Sub clearAllFields()
        txtDedicatorCode.Text = ""
        txtDedicatorCode.BackColor = SystemColors.Window
        txtDedicatorCode.ReadOnly = False
        cboMemberName.SelectedIndex = -1
        cboMemberName.BackColor = SystemColors.Window
        cboMemberName.Enabled = True
        txtRemark.Text = ""

        EnabletxtItem(True)
        For i As Integer = 0 To _txtItem.Length - 1
            _txtItem(i).Value = 0.0
        Next
        grdSlipItem.RowCount = 0

        _AddSW = True
        _ChangedSW = False

        newTSB.Enabled = False
        saveTSB.Enabled = False
        deleteTSB.Enabled = False

        txtDedicatorCode.Focus()
    End Sub

    Private Sub EnabletxtItem(ByVal status)
        txtDedicatorCode.Enabled = status
        txtDedicatorCode.Text = ""
        cboMemberName.Enabled = status
        cboMemberName.SelectedIndex = 0
        txtRemark.Enabled = status
        txtRemark.Text = ""
        For i As Integer = 0 To _txtItem.Length - 1
            _chkItem(i).Enabled = status
            _txtItem(i).Enabled = IIf(_chkItem(i).Checked, status, False)
            _txtItem(i).Value = 0
        Next
    End Sub

    Private Sub saveCurrentRecord()
        If _AddSW = True Then
            insertTable()
        Else
            updateTable()
        End If
    End Sub

    Private Sub insertTable()
        Dim autoKey As Int32  ' Primary key for Slip Table
        Dim seq As Int32 = 0

        ' Compute Offering Total
        Dim amount As Decimal = 0
        For i As Integer = 0 To _txtItem.Length - 1
            If _txtItem(i).Enabled Then
                amount = amount + _txtItem(i).Value
            End If
        Next

        ' Insert Tbl_Slip and Read Auto Increasement Key of Slip Table
        Dim cmd As New SqlCommand(_SQL(queryENUM.INSERT_SLIP), _Conn)
        cmd.Parameters.Add("@SlipDate", SqlDbType.SmallDateTime).Value = _jobDate
        cmd.Parameters.Add("@MemberCode", SqlDbType.Char).Value = cboMemberName.SelectedValue
        cmd.Parameters.Add("@Division", SqlDbType.Char).Value = "I"
        cmd.Parameters.Add("@CashAmount", SqlDbType.Decimal).Value = amount
        cmd.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text
        autoKey = Convert.ToInt32(cmd.ExecuteScalar())

        ' Insert Tbl_SlipItem
        cmd.CommandText = _SQL(queryENUM.INSERT_SLIPITEM)
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = autoKey
        cmd.Parameters.Add("@SlipSeq", SqlDbType.SmallInt)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters.Add("@Amount", SqlDbType.Decimal)
        For i As Integer = 0 To _txtItem.Length - 1
            If _txtItem(i).Enabled And _txtItem(i).Value <> 0 Then
                cmd.Parameters("@SlipSeq").Value = seq + 1
                cmd.Parameters("@AccountCode").Value = _accountCode(i)
                cmd.Parameters("@Amount").Value = _txtItem(i).Value
                cmd.ExecuteNonQuery()
                grdSlipItem.Rows.Add(seq + 1, _accountCode(i), _lblItem(i).Text, _txtItem(i).Value)
                seq = seq + 1
            End If
        Next

        ' Set switches
        _AddSW = False
        _ChangedSW = False
        newTSB.Enabled = True
        deleteTSB.Enabled = True
        saveTSB.Enabled = False

        ' Add new row in Slip Grid at the left side
        grdSlip.Rows.Add(autoKey, cboMemberName.SelectedValue, cboMemberName.Text, amount)
        grdSlip.CurrentCell = grdSlip(0, grdSlip.RowCount - 1)
    End Sub

    Private Sub updateTable()
        Dim seq As Int32 = 0

        ' Delete SlipItem First (It's important because of the delete triger of Slipitem table
        Dim cmd As New SqlCommand(_SQL(queryENUM.DELETE_SLIPITEM), _Conn)
        cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = grdSlip("SlipNo", grdSlip.CurrentRow.Index).Value
        cmd.Parameters.Add("@SlipSeq", SqlDbType.SmallInt)
        For i As Integer = 0 To grdSlipItem.RowCount - 1
            cmd.Parameters("@SlipSeq").Value = grdSlipItem("SlipSeq", i).Value
            cmd.ExecuteNonQuery()
        Next
        grdSlipItem.RowCount = 0

        ' Insert Tbl_SlipItem
        cmd.CommandText = _SQL(queryENUM.INSERT_SLIPITEM)
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = grdSlip("SlipNo", grdSlip.CurrentRow.Index).Value
        cmd.Parameters.Add("@SlipSeq", SqlDbType.SmallInt)
        cmd.Parameters.Add("@AccountCode", SqlDbType.Char)
        cmd.Parameters.Add("@Amount", SqlDbType.Decimal)
        For i As Integer = 0 To _txtItem.Length - 1
            If _txtItem(i).Enabled And _txtItem(i).Value <> 0 Then
                cmd.Parameters("@SlipSeq").Value = seq + 1
                cmd.Parameters("@AccountCode").Value = _accountCode(i)
                cmd.Parameters("@Amount").Value = _txtItem(i).Value
                cmd.ExecuteNonQuery()
                grdSlipItem.Rows.Add(seq + 1, _accountCode(i), _lblItem(i).Text, _txtItem(i).Value)
                seq = seq + 1
            End If
        Next

        ' Compute Offering Total
        Dim amount As Decimal = 0
        For i As Integer = 0 To _txtItem.Length - 1
            If _txtItem(i).Enabled Then
                amount = amount + _txtItem(i).Value
            End If
        Next

        ' Update Tbl_Slip
        cmd.CommandText = _SQL(queryENUM.UPDATE_SLIP)
        cmd.Parameters.Clear()
        cmd.Parameters.Add("@CashAmount", SqlDbType.Decimal).Value = amount
        cmd.Parameters.Add("@Remark", SqlDbType.VarChar).Value = txtRemark.Text
        cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = grdSlip("SlipNo", grdSlip.CurrentRow.Index).Value
        cmd.ExecuteNonQuery()

        _UpdateSW = True
        _ChangedSW = False

        newTSB.Enabled = True
        deleteTSB.Enabled = True
        saveTSB.Enabled = False

        grdSlip("Amount", grdSlip.CurrentRow.Index).Value = amount
    End Sub

    Private Sub deleteCurrentRecord()
        Dim result As DialogResult = MessageBox.Show("Deleted data can't be recovered. Delete it?",
                "Confirmation to delete", MessageBoxButtons.YesNo)
        If result = vbNo Then Exit Sub

        ' Delete SlipItem First (It's important because of the delete triger of Slipitem table
        Dim cmd As New SqlCommand(_SQL(queryENUM.DELETE_SLIPITEM), _Conn)
        cmd.Parameters.Add("@SlipNo", SqlDbType.Int).Value = grdSlip("SlipNo", grdSlip.CurrentRow.Index).Value
        cmd.Parameters.Add("@SlipSeq", SqlDbType.SmallInt)
        For i As Integer = 0 To grdSlipItem.RowCount - 1
            cmd.Parameters("@SlipSeq").Value = grdSlipItem("SlipSeq", i).Value
            cmd.ExecuteNonQuery()
        Next
        grdSlipItem.RowCount = 0

        cmd.CommandText = _SQL(queryENUM.DELETE_SLIP)
        cmd.Parameters("@SlipNo").Value = grdSlip("SlipNo", grdSlip.CurrentRow.Index).Value
        cmd.ExecuteNonQuery()

        Dim saveCurrentRow = grdSlip.CurrentRow.Index
        grdSlip.Rows.RemoveAt(saveCurrentRow)
        If grdSlip.RowCount < 1 Then
            clearAllFields()
            EnabletxtItem(False)
            _AddSW = False
            _UpdateSW = False
            enableAllToolStripButton(False)
            newTSB.Enabled = True
        ElseIf saveCurrentRow > grdSlip.RowCount - 1 Then
            grdSlip.CurrentCell = grdSlip(0, grdSlip.RowCount - 1)
            fillData(grdSlip.CurrentCell.Value)
        Else
            grdSlip.CurrentCell = grdSlip(0, saveCurrentRow)
            fillData(grdSlip.CurrentCell.Value)
        End If

    End Sub

    Private Function GetMemberItems() As List(Of ItemStructure)
        Dim items = New List(Of ItemStructure)
        Dim cmd As New SqlCommand(_SQL(queryENUM.READ_MEMBER), _Conn)

        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            While reader.Read()
                items.Add(New ItemStructure(reader("MemberCode"), reader("ViewName")))
            End While
            reader.Close()
            Return items
        Else
            reader.Close()
            MessageBox.Show("There should be more than one data for Member code!", "Empty data", MessageBoxButtons.OK)
            Close()
            Return Nothing
        End If
    End Function

End Class
