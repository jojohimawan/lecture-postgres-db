<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.cbConfirm = New System.Windows.Forms.ComboBox()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Access_bakeryDataSet = New ForrmBismillah.access_bakeryDataSet()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New ForrmBismillah.access_bakeryDataSetTableAdapters.customersTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreetaddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZipcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddtomailinglistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthernotesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Access_bakeryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnKeluar
        '
        Me.btnKeluar.Location = New System.Drawing.Point(1065, 696)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(111, 41)
        Me.btnKeluar.TabIndex = 1
        Me.btnKeluar.Text = "METU"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(930, 696)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(111, 41)
        Me.btnSimpan.TabIndex = 2
        Me.btnSimpan.Text = "SAVE"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Plus Jakarta Sans ExtraBold", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(440, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(400, 77)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer Form"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(195, 136)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(180, 20)
        Me.txtFirstName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(60, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(60, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(60, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(60, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(60, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Street Address"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(60, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "City"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(534, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 16)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(534, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 16)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Zip Code"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Gilroy Light", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(534, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Confirm"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(195, 183)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(180, 20)
        Me.txtLastName.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(195, 227)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(180, 20)
        Me.txtEmail.TabIndex = 16
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Location = New System.Drawing.Point(195, 274)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(180, 20)
        Me.txtPhoneNumber.TabIndex = 17
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Location = New System.Drawing.Point(195, 318)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(180, 20)
        Me.txtStreetAddress.TabIndex = 18
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(195, 368)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(180, 20)
        Me.txtCity.TabIndex = 19
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(633, 136)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(180, 20)
        Me.txtState.TabIndex = 20
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(633, 183)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(180, 20)
        Me.txtZipCode.TabIndex = 21
        '
        'cbConfirm
        '
        Me.cbConfirm.FormattingEnabled = True
        Me.cbConfirm.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbConfirm.Location = New System.Drawing.Point(633, 225)
        Me.cbConfirm.Name = "cbConfirm"
        Me.cbConfirm.Size = New System.Drawing.Size(121, 21)
        Me.cbConfirm.TabIndex = 22
        '
        'btnBersihkan
        '
        Me.btnBersihkan.Location = New System.Drawing.Point(63, 696)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(111, 41)
        Me.btnBersihkan.TabIndex = 23
        Me.btnBersihkan.Text = "BERSIHKAN"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.StreetaddressDataGridViewTextBoxColumn, Me.StateDataGridViewTextBoxColumn, Me.ZipcodeDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.PhonenumberDataGridViewTextBoxColumn, Me.CityDataGridViewTextBoxColumn, Me.AddtomailinglistDataGridViewTextBoxColumn, Me.OthernotesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(63, 415)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1113, 275)
        Me.DataGridView1.TabIndex = 24
        '
        'Access_bakeryDataSet
        '
        Me.Access_bakeryDataSet.DataSetName = "access_bakeryDataSet"
        Me.Access_bakeryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "customers"
        Me.CustomersBindingSource.DataSource = Me.Access_bakeryDataSet
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "first_name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "last_name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        '
        'StreetaddressDataGridViewTextBoxColumn
        '
        Me.StreetaddressDataGridViewTextBoxColumn.DataPropertyName = "street_address"
        Me.StreetaddressDataGridViewTextBoxColumn.HeaderText = "street_address"
        Me.StreetaddressDataGridViewTextBoxColumn.Name = "StreetaddressDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "state"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "state"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'ZipcodeDataGridViewTextBoxColumn
        '
        Me.ZipcodeDataGridViewTextBoxColumn.DataPropertyName = "zip_code"
        Me.ZipcodeDataGridViewTextBoxColumn.HeaderText = "zip_code"
        Me.ZipcodeDataGridViewTextBoxColumn.Name = "ZipcodeDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'PhonenumberDataGridViewTextBoxColumn
        '
        Me.PhonenumberDataGridViewTextBoxColumn.DataPropertyName = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.HeaderText = "phone_number"
        Me.PhonenumberDataGridViewTextBoxColumn.Name = "PhonenumberDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "city"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "city"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'AddtomailinglistDataGridViewTextBoxColumn
        '
        Me.AddtomailinglistDataGridViewTextBoxColumn.DataPropertyName = "add_to_mailing_list"
        Me.AddtomailinglistDataGridViewTextBoxColumn.HeaderText = "add_to_mailing_list"
        Me.AddtomailinglistDataGridViewTextBoxColumn.Name = "AddtomailinglistDataGridViewTextBoxColumn"
        '
        'OthernotesDataGridViewTextBoxColumn
        '
        Me.OthernotesDataGridViewTextBoxColumn.DataPropertyName = "other_notes"
        Me.OthernotesDataGridViewTextBoxColumn.HeaderText = "other_notes"
        Me.OthernotesDataGridViewTextBoxColumn.Name = "OthernotesDataGridViewTextBoxColumn"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(180, 696)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(744, 41)
        Me.btnDelete.TabIndex = 25
        Me.btnDelete.Text = "HAPUS"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 749)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.cbConfirm)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtPhoneNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnKeluar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Access_bakeryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKeluar As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents cbConfirm As ComboBox
    Friend WithEvents btnBersihkan As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Access_bakeryDataSet As access_bakeryDataSet
    Friend WithEvents CustomersBindingSource As BindingSource
    Friend WithEvents CustomersTableAdapter As access_bakeryDataSetTableAdapters.customersTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreetaddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZipcodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhonenumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddtomailinglistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthernotesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As Button
End Class
