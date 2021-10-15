
Imports System.ComponentModel

<System.Drawing.ToolboxBitmap(GetType(System.Windows.Forms.DataGridViewCheckBoxColumn))>
Public Class DataGridViewCheckBoxHeaderColumn
    Inherits DataGridViewCheckBoxColumn

    Public Sub New()
        Dim datagridViewCheckBoxHeaderCell As DatagridViewCheckBoxHeaderCell = New DatagridViewCheckBoxHeaderCell()
        Me.HeaderCell = datagridViewCheckBoxHeaderCell
        Me.Width = 50
        AddHandler datagridViewCheckBoxHeaderCell.OnCheckBoxClicked, New CheckBoxClickedHandler(AddressOf datagridViewCheckBoxHeaderCell_OnCheckBoxClicked)
    End Sub

    Private Sub datagridViewCheckBoxHeaderCell_OnCheckBoxClicked(ByVal columnIndex As Integer, ByVal state As Boolean)
        DataGridView.RefreshEdit()

        For Each row As DataGridViewRow In Me.DataGridView.Rows

            If Not row.Cells(columnIndex).[ReadOnly] Then
                row.Cells(columnIndex).Value = state
            End If
        Next

        DataGridView.RefreshEdit()
    End Sub
End Class

Public Delegate Sub CheckBoxClickedHandler(ByVal columnIndex As Integer, ByVal state As Boolean)

Public Class DataGridViewCheckBoxHeaderCellEventArgs
    Inherits EventArgs

    Private _bChecked As Boolean

    Public Sub New(ByVal columnIndex As Integer, ByVal bChecked As Boolean)
        _bChecked = bChecked
    End Sub

    Public ReadOnly Property Checked As Boolean
        Get
            Return _bChecked
        End Get
    End Property
End Class

Class DatagridViewCheckBoxHeaderCell
    Inherits DataGridViewColumnHeaderCell

    Private checkBoxLocation As Point
    Private checkBoxSize As Size
    Public Checked As Boolean = False
    Private _cellLocation As Point = New Point()
    Private _cbState As System.Windows.Forms.VisualStyles.CheckBoxState = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal
    Public Event OnCheckBoxClicked As CheckBoxClickedHandler

    Public Sub New()
    End Sub

    Protected Overrides Sub Paint(ByVal graphics As System.Drawing.Graphics, ByVal clipBounds As System.Drawing.Rectangle, ByVal cellBounds As System.Drawing.Rectangle, ByVal rowIndex As Integer, ByVal dataGridViewElementState As DataGridViewElementStates, ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, ByVal paintParts As DataGridViewPaintParts)
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts)
        Dim p As Point = New Point()
        Dim s As Size = CheckBoxRenderer.GetGlyphSize(graphics, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal)
        p.X = cellBounds.Location.X + (cellBounds.Width / 2) - (s.Width / 2)
        p.Y = cellBounds.Location.Y + (cellBounds.Height / 2) - (s.Height / 2)
        _cellLocation = cellBounds.Location
        checkBoxLocation = p
        checkBoxSize = s

        If Checked Then
            _cbState = System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal
        Else
            _cbState = System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal
        End If

        CheckBoxRenderer.DrawCheckBox(graphics, checkBoxLocation, _cbState)
    End Sub

    Protected Overrides Sub OnMouseClick(ByVal e As DataGridViewCellMouseEventArgs)
        Dim p As Point = New Point(e.X + _cellLocation.X, e.Y + _cellLocation.Y)

        If p.X >= checkBoxLocation.X AndAlso p.X <= checkBoxLocation.X + checkBoxSize.Width AndAlso p.Y >= checkBoxLocation.Y AndAlso p.Y <= checkBoxLocation.Y + checkBoxSize.Height Then
            Checked = Not Checked

            RaiseEvent OnCheckBoxClicked(e.ColumnIndex, Checked)
            Me.DataGridView.InvalidateCell(Me)
        End If

        MyBase.OnMouseClick(e)
    End Sub
End Class

Class DataGridViewColumnSelector
    Private mDataGridView As DataGridView = Nothing
    Private mCheckedListBox As CheckedListBox
    Private mPopup As ToolStripDropDown
    Public MaxHeight As Integer = 300
    Public Width As Integer = 200

    Public Property DataGridView As DataGridView
        Get
            Return mDataGridView
        End Get
        Set(ByVal value As DataGridView)
            If mDataGridView IsNot Nothing Then RemoveHandler mDataGridView.CellMouseClick, New DataGridViewCellMouseEventHandler(AddressOf mDataGridView_CellMouseClick)
            mDataGridView = value
            If mDataGridView IsNot Nothing Then AddHandler mDataGridView.CellMouseClick, New DataGridViewCellMouseEventHandler(AddressOf mDataGridView_CellMouseClick)
        End Set
    End Property

    Private Sub mDataGridView_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs)
        If e.Button = MouseButtons.Right AndAlso e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            mCheckedListBox.Items.Clear()

            For Each c As DataGridViewColumn In mDataGridView.Columns
                mCheckedListBox.Items.Add(c.HeaderText, c.Visible)
            Next

            Dim PreferredHeight As Integer = (mCheckedListBox.Items.Count * 16) + 7
            mCheckedListBox.Height = If((PreferredHeight < MaxHeight), PreferredHeight, MaxHeight)
            mCheckedListBox.Width = Me.Width
            mPopup.Show(mDataGridView.PointToScreen(New Point(e.X, e.Y)))
        End If
    End Sub

    Public Sub New()
        mCheckedListBox = New CheckedListBox()
        mCheckedListBox.CheckOnClick = True
        AddHandler mCheckedListBox.ItemCheck, New ItemCheckEventHandler(AddressOf mCheckedListBox_ItemCheck)
        Dim mControlHost As ToolStripControlHost = New ToolStripControlHost(mCheckedListBox)
        mControlHost.Padding = Padding.Empty
        mControlHost.Margin = Padding.Empty
        mControlHost.AutoSize = False
        mPopup = New ToolStripDropDown()
        mPopup.Padding = Padding.Empty
        mPopup.Items.Add(mControlHost)
    End Sub

    Public Sub New(ByVal dgv As DataGridView)
        Me.New()
        Me.DataGridView = dgv
    End Sub

    Private Sub mCheckedListBox_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        mDataGridView.Columns(e.Index).Visible = (e.NewValue = CheckState.Checked)
    End Sub
End Class