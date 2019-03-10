<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarList
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
        Me.lblResult = New System.Windows.Forms.Label()
        Me.lvwCar = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.colYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(14, 495)
        Me.lblResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(440, 74)
        Me.lblResult.TabIndex = 10
        '
        'lvwCar
        '
        Me.lvwCar.CheckBoxes = True
        Me.lvwCar.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colID, Me.colMake, Me.colModel, Me.colYear, Me.colPrice})
        Me.lvwCar.FullRowSelect = True
        Me.lvwCar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCar.Location = New System.Drawing.Point(14, 189)
        Me.lvwCar.Margin = New System.Windows.Forms.Padding(4)
        Me.lvwCar.MultiSelect = False
        Me.lvwCar.Name = "lvwCar"
        Me.lvwCar.Size = New System.Drawing.Size(439, 302)
        Me.lvwCar.TabIndex = 9
        Me.lvwCar.UseCompatibleStateImageBehavior = False
        Me.lvwCar.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 50
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 50
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 50
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 50
        '
        'colPrice
        '
        Me.colPrice.Text = "Price"
        Me.colPrice.Width = 50
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(61, 158)
        Me.chkNew.Margin = New System.Windows.Forms.Padding(4)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(82, 30)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New:"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(27, 125)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 16)
        Me.lblPrice.TabIndex = 3
        Me.lblPrice.Text = "&Price: "
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(27, 51)
        Me.lblModel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(88, 16)
        Me.lblModel.TabIndex = 1
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblModel.UseWaitCursor = True
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(27, 18)
        Me.lblMake.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(88, 16)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make: "
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Acura", "Alfa Romeo", "Aston Martin", "Audi", "Bentley", "BMW", "Bugatti", "Cadillac", "Chevrolet", "Chrysler", "Dodge", "Ferrari", "Fiat", "Ford", "Genesis", "Honda", "Hyundai", "Jaguar", "Jeep", "Kia", "Lamborghini", "Land Rover", "Lexus", "Maserati", "Mazda", "Mclaren", "Mercedes-Benz", "Nissan", "Porshe", "Renault", "Rolls-Royce", "Suzuki", "Tesla", "Toyota", "Volkswagen"})
        Me.cmbMake.Location = New System.Drawing.Point(123, 18)
        Me.cmbMake.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(160, 24)
        Me.cmbMake.TabIndex = 4
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(123, 121)
        Me.tbPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(160, 22)
        Me.tbPrice.TabIndex = 7
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(123, 51)
        Me.tbModel.Margin = New System.Windows.Forms.Padding(4)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(160, 22)
        Me.tbModel.TabIndex = 5
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(354, 575)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(246, 575)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(100, 28)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(138, 575)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(100, 28)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(28, 86)
        Me.lblYear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(88, 16)
        Me.lblYear.TabIndex = 2
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbYear.Location = New System.Drawing.Point(124, 86)
        Me.cmbYear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(160, 24)
        Me.cmbYear.TabIndex = 6
        '
        'colYear
        '
        Me.colYear.Text = "Year"
        Me.colYear.Width = 50
        '
        'frmCarList
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(483, 645)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lvwCar)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents lvwCar As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colPrice As ColumnHeader
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents tbPrice As TextBox
    Friend WithEvents tbModel As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents colYear As ColumnHeader
End Class
