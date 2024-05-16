namespace Aufgabe_15._5;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lblNewsletter = new Label();
        lblGender = new Label();
        lblMännlich = new Label();
        lblWeiblich = new Label();
        lblEmailProvider = new Label();
        label1 = new Label();
        lblUnter18 = new Label();
        lbl18bis29 = new Label();
        lbl30bis39 = new Label();
        lbl40bis49 = new Label();
        lblÜber50 = new Label();
        lblUnbekannt = new Label();
        cbCity = new ComboBox();
        label2 = new Label();
        dgvCustomers = new DataGridView();
        dataGridView1 = new DataGridView();
        label3 = new Label();
        panel1 = new Panel();
        labelPageNumber = new Label();
        panel2 = new Panel();
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panel1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // lblNewsletter
        // 
        lblNewsletter.AutoSize = true;
        lblNewsletter.ForeColor = Color.White;
        lblNewsletter.Location = new Point(12, 9);
        lblNewsletter.Name = "lblNewsletter";
        lblNewsletter.Size = new Size(196, 15);
        lblNewsletter.TabIndex = 0;
        lblNewsletter.Text = "Anzahl der Newsletter-Abonnenten:";
        // 
        // lblGender
        // 
        lblGender.AutoSize = true;
        lblGender.ForeColor = Color.White;
        lblGender.Location = new Point(12, 41);
        lblGender.Name = "lblGender";
        lblGender.Size = new Size(218, 15);
        lblGender.TabIndex = 1;
        lblGender.Text = "Prozentuale Verteilung nach Geschlecht:";
        // 
        // lblMännlich
        // 
        lblMännlich.AutoSize = true;
        lblMännlich.ForeColor = Color.White;
        lblMännlich.Location = new Point(29, 56);
        lblMännlich.Name = "lblMännlich";
        lblMännlich.Size = new Size(60, 15);
        lblMännlich.TabIndex = 2;
        lblMännlich.Text = "Männlich:";
        // 
        // lblWeiblich
        // 
        lblWeiblich.AutoSize = true;
        lblWeiblich.ForeColor = Color.White;
        lblWeiblich.Location = new Point(33, 71);
        lblWeiblich.Name = "lblWeiblich";
        lblWeiblich.Size = new Size(56, 15);
        lblWeiblich.TabIndex = 3;
        lblWeiblich.Text = "Weiblich:";
        // 
        // lblEmailProvider
        // 
        lblEmailProvider.AutoSize = true;
        lblEmailProvider.ForeColor = Color.White;
        lblEmailProvider.Location = new Point(12, 114);
        lblEmailProvider.Name = "lblEmailProvider";
        lblEmailProvider.Size = new Size(151, 15);
        lblEmailProvider.TabIndex = 4;
        lblEmailProvider.Text = "Häufigster E-Mail-Provider:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.ForeColor = Color.White;
        label1.Location = new Point(12, 144);
        label1.Name = "label1";
        label1.Size = new Size(151, 15);
        label1.TabIndex = 6;
        label1.Text = "Kunden nach Altersgruppe:";
        // 
        // lblUnter18
        // 
        lblUnter18.AutoSize = true;
        lblUnter18.ForeColor = Color.White;
        lblUnter18.Location = new Point(39, 165);
        lblUnter18.Name = "lblUnter18";
        lblUnter18.Size = new Size(54, 15);
        lblUnter18.TabIndex = 7;
        lblUnter18.Text = "Unter 18:";
        // 
        // lbl18bis29
        // 
        lbl18bis29.AutoSize = true;
        lbl18bis29.ForeColor = Color.White;
        lbl18bis29.Location = new Point(48, 180);
        lbl18bis29.Name = "lbl18bis29";
        lbl18bis29.Size = new Size(45, 15);
        lbl18bis29.TabIndex = 8;
        lbl18bis29.Text = "18 - 29:";
        // 
        // lbl30bis39
        // 
        lbl30bis39.AutoSize = true;
        lbl30bis39.ForeColor = Color.White;
        lbl30bis39.Location = new Point(48, 195);
        lbl30bis39.Name = "lbl30bis39";
        lbl30bis39.Size = new Size(45, 15);
        lbl30bis39.TabIndex = 9;
        lbl30bis39.Text = "30 - 39:";
        // 
        // lbl40bis49
        // 
        lbl40bis49.AutoSize = true;
        lbl40bis49.ForeColor = Color.White;
        lbl40bis49.Location = new Point(48, 210);
        lbl40bis49.Name = "lbl40bis49";
        lbl40bis49.Size = new Size(45, 15);
        lbl40bis49.TabIndex = 10;
        lbl40bis49.Text = "40 - 49:";
        // 
        // lblÜber50
        // 
        lblÜber50.AutoSize = true;
        lblÜber50.ForeColor = Color.White;
        lblÜber50.Location = new Point(43, 225);
        lblÜber50.Name = "lblÜber50";
        lblÜber50.Size = new Size(50, 15);
        lblÜber50.TabIndex = 11;
        lblÜber50.Text = "Über 50:";
        // 
        // lblUnbekannt
        // 
        lblUnbekannt.AutoSize = true;
        lblUnbekannt.ForeColor = Color.White;
        lblUnbekannt.Location = new Point(21, 86);
        lblUnbekannt.Name = "lblUnbekannt";
        lblUnbekannt.Size = new Size(68, 15);
        lblUnbekannt.TabIndex = 12;
        lblUnbekannt.Text = "Unbekannt:";
        // 
        // cbCity
        // 
        cbCity.FormattingEnabled = true;
        cbCity.Location = new Point(154, 6);
        cbCity.Name = "cbCity";
        cbCity.Size = new Size(169, 23);
        cbCity.TabIndex = 14;
        cbCity.SelectedIndexChanged += cbCity_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.White;
        label2.Location = new Point(3, 9);
        label2.Name = "label2";
        label2.Size = new Size(145, 15);
        label2.TabIndex = 15;
        label2.Text = "Suche Kunden nach Stadt:";
        // 
        // dgvCustomers
        // 
        dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgvCustomers.BackgroundColor = Color.Black;
        dgvCustomers.BorderStyle = BorderStyle.None;
        dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvCustomers.Dock = DockStyle.Bottom;
        dgvCustomers.Location = new Point(0, 35);
        dgvCustomers.Name = "dgvCustomers";
        dgvCustomers.Size = new Size(688, 242);
        dgvCustomers.TabIndex = 16;
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.BackgroundColor = Color.Black;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Dock = DockStyle.Bottom;
        dataGridView1.Location = new Point(0, 37);
        dataGridView1.MaximumSize = new Size(940, 715);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
        dataGridView1.Size = new Size(940, 715);
        dataGridView1.TabIndex = 17;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.ForeColor = Color.White;
        label3.Location = new Point(12, 4);
        label3.Name = "label3";
        label3.Size = new Size(174, 15);
        label3.TabIndex = 18;
        label3.Text = "Alle Kunden mit Geburtsdatum:";
        // 
        // panel1
        // 
        panel1.Controls.Add(labelPageNumber);
        panel1.Controls.Add(label3);
        panel1.Controls.Add(dataGridView1);
        panel1.Dock = DockStyle.Bottom;
        panel1.Location = new Point(0, 277);
        panel1.Name = "panel1";
        panel1.Size = new Size(940, 752);
        panel1.TabIndex = 19;
        // 
        // labelPageNumber
        // 
        labelPageNumber.AutoSize = true;
        labelPageNumber.ForeColor = Color.White;
        labelPageNumber.Location = new Point(561, 4);
        labelPageNumber.Name = "labelPageNumber";
        labelPageNumber.Size = new Size(32, 15);
        labelPageNumber.TabIndex = 19;
        labelPageNumber.Text = "Seite";
        // 
        // panel2
        // 
        panel2.Controls.Add(cbCity);
        panel2.Controls.Add(dgvCustomers);
        panel2.Controls.Add(label2);
        panel2.Dock = DockStyle.Right;
        panel2.Location = new Point(252, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(688, 277);
        panel2.TabIndex = 20;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(940, 1029);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Controls.Add(lblUnbekannt);
        Controls.Add(lblÜber50);
        Controls.Add(lbl40bis49);
        Controls.Add(lbl30bis39);
        Controls.Add(lbl18bis29);
        Controls.Add(lblUnter18);
        Controls.Add(label1);
        Controls.Add(lblEmailProvider);
        Controls.Add(lblWeiblich);
        Controls.Add(lblMännlich);
        Controls.Add(lblGender);
        Controls.Add(lblNewsletter);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "Form1";
        Text = "CSV Daten Verarbeitung";
        ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label lblNewsletter;
    private Label lblGender;
    private Label lblMännlich;
    private Label lblWeiblich;
    private Label lblEmailProvider;
    private Label label1;
    private Label lblUnter18;
    private Label lbl18bis29;
    private Label lbl30bis39;
    private Label lbl40bis49;
    private Label lblÜber50;
    private Label lblUnbekannt;
    private ComboBox cbCity;
    private Label label2;
    private DataGridView dgvCustomers;
    private DataGridView dataGridView1;
    private Label label3;
    private Panel panel1;
    private Label labelPageNumber;
    private Panel panel2;
}
