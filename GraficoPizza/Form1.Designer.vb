<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Me.btn_gerar = New System.Windows.Forms.Button()
        Me.chart_pizza = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.chart_pizza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_gerar
        '
        Me.btn_gerar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_gerar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gerar.FlatAppearance.BorderSize = 0
        Me.btn_gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_gerar.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_gerar.Location = New System.Drawing.Point(293, 359)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(154, 65)
        Me.btn_gerar.TabIndex = 0
        Me.btn_gerar.Text = "Gerar"
        Me.btn_gerar.UseVisualStyleBackColor = False
        '
        'chart_pizza
        '
        ChartArea1.Name = "ChartArea1"
        Me.chart_pizza.ChartAreas.Add(ChartArea1)
        Me.chart_pizza.Location = New System.Drawing.Point(32, 12)
        Me.chart_pizza.Name = "chart_pizza"
        Me.chart_pizza.Size = New System.Drawing.Size(668, 341)
        Me.chart_pizza.TabIndex = 1
        Me.chart_pizza.Text = "Chart1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkOrange
        Me.ClientSize = New System.Drawing.Size(733, 436)
        Me.Controls.Add(Me.chart_pizza)
        Me.Controls.Add(Me.btn_gerar)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.RoyalBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Grafico_Pizza"
        CType(Me.chart_pizza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_gerar As Button
    Friend WithEvents chart_pizza As DataVisualization.Charting.Chart
End Class
