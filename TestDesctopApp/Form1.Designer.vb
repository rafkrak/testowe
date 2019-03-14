<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Optyk2DataSet = New TestDesctopApp.optyk2DataSet()
        Me.DICTlokalizacjeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DICT_lokalizacjeTableAdapter = New TestDesctopApp.optyk2DataSetTableAdapters.DICT_lokalizacjeTableAdapter()
        Me.IdlokalizacjiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NazwaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdresDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Optyk2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DICTlokalizacjeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdlokalizacjiDataGridViewTextBoxColumn, Me.NazwaDataGridViewTextBoxColumn, Me.AdresDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.OpisDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.DICTlokalizacjeBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(32, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(836, 195)
        Me.DataGridView1.TabIndex = 0
        '
        'Optyk2DataSet
        '
        Me.Optyk2DataSet.DataSetName = "optyk2DataSet"
        Me.Optyk2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DICTlokalizacjeBindingSource
        '
        Me.DICTlokalizacjeBindingSource.DataMember = "DICT_lokalizacje"
        Me.DICTlokalizacjeBindingSource.DataSource = Me.Optyk2DataSet
        '
        'DICT_lokalizacjeTableAdapter
        '
        Me.DICT_lokalizacjeTableAdapter.ClearBeforeFill = True
        '
        'IdlokalizacjiDataGridViewTextBoxColumn
        '
        Me.IdlokalizacjiDataGridViewTextBoxColumn.DataPropertyName = "id_lokalizacji"
        Me.IdlokalizacjiDataGridViewTextBoxColumn.HeaderText = "id_lokalizacji"
        Me.IdlokalizacjiDataGridViewTextBoxColumn.Name = "IdlokalizacjiDataGridViewTextBoxColumn"
        Me.IdlokalizacjiDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NazwaDataGridViewTextBoxColumn
        '
        Me.NazwaDataGridViewTextBoxColumn.DataPropertyName = "nazwa"
        Me.NazwaDataGridViewTextBoxColumn.HeaderText = "nazwa"
        Me.NazwaDataGridViewTextBoxColumn.Name = "NazwaDataGridViewTextBoxColumn"
        '
        'AdresDataGridViewTextBoxColumn
        '
        Me.AdresDataGridViewTextBoxColumn.DataPropertyName = "adres"
        Me.AdresDataGridViewTextBoxColumn.HeaderText = "adres"
        Me.AdresDataGridViewTextBoxColumn.Name = "AdresDataGridViewTextBoxColumn"
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'OpisDataGridViewTextBoxColumn
        '
        Me.OpisDataGridViewTextBoxColumn.DataPropertyName = "opis"
        Me.OpisDataGridViewTextBoxColumn.HeaderText = "opis"
        Me.OpisDataGridViewTextBoxColumn.Name = "OpisDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(32, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(148, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DICTlokalizacjeBindingSource
        Me.ComboBox1.DisplayMember = "nazwa"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(32, 312)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(262, 21)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "id_lokalizacji"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 450)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Optyk2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DICTlokalizacjeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Optyk2DataSet As optyk2DataSet
    Friend WithEvents DICTlokalizacjeBindingSource As BindingSource
    Friend WithEvents DICT_lokalizacjeTableAdapter As optyk2DataSetTableAdapters.DICT_lokalizacjeTableAdapter
    Friend WithEvents IdlokalizacjiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NazwaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdresDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OpisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
