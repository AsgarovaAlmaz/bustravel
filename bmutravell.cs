using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BMUTravel
{
    public partial class Form1 : Form
    {
        // Əsas elementlər
        Panel headerPanel;

        GroupBox travelGroup;
        GroupBox personGroup;

        Label lblTitle;
        Label lblFrom;
        Label lblTo;
        Label lblDate;
        Label lblTime;
        Label lblPlace;

        Label lblName;
        Label lblFin;
        Label lblEmail;
        Label lblPhone;

        ComboBox cmbFrom;
        ComboBox cmbTo;

        MaskedTextBox txtDate;
        MaskedTextBox txtTime;
        MaskedTextBox txtPhone;

        TextBox txtPlace;
        TextBox txtName;
        TextBox txtFin;
        TextBox txtEmail;

        Button btnLeft;
        Button btnRight;
        Button btnBuy;
        Button btnDelete;
        Button btnExit;

        ListBox lstTickets;

        public Form1()
        {
            

            CreateForm();
            CreateHeader();
            CreateTravelGroup();
            CreatePersonGroup();
            CreateBottom();
        }

        // =========================================================
        // FORM
        // =========================================================

        private void CreateForm()
        {
            this.Text = "BMU TRAVEL";
            this.Size = new Size(850, 560);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Gray;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        // =========================================================
        // HEADER
        // =========================================================

        private void CreateHeader()
        {
            headerPanel = new Panel();

            headerPanel.Location = new Point(0, 0);
            headerPanel.Size = new Size(850, 100);
            headerPanel.BackColor = Color.LightGray;

            this.Controls.Add(headerPanel);

            // BMU yazısı
            Label lblBMU = new Label();

            lblBMU.Text = "BMU";
            lblBMU.Font = new Font("Arial", 30, FontStyle.Bold);
            lblBMU.ForeColor = Color.White;
            lblBMU.Location = new Point(70, 25);
            lblBMU.AutoSize = true;

            headerPanel.Controls.Add(lblBMU);

            // Şaquli xətt
            Label line = new Label();

            line.BackColor = Color.White;
            line.Location = new Point(150, 15);
            line.Size = new Size(2, 70);

            headerPanel.Controls.Add(line);

            // Başlıq
            lblTitle = new Label();

            lblTitle.Text = "BMU TRAVEL";
            lblTitle.Font = new Font("Arial", 22, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(350, 35);

            headerPanel.Controls.Add(lblTitle);

            // Avtobus işarəsi
            Label bus = new Label();

            bus.Text = "🚌";
            bus.Font = new Font("Segoe UI Emoji", 35);
            bus.AutoSize = true;
            bus.Location = new Point(745, 25);

            headerPanel.Controls.Add(bus);
        }

        // =========================================================
        // TRAVEL INFORMATION
        // =========================================================

        private void CreateTravelGroup()
        {
            travelGroup = new GroupBox();

            travelGroup.Text = "Travel information";
            travelGroup.Font = new Font("Arial", 11, FontStyle.Bold);
            travelGroup.ForeColor = Color.White;

            travelGroup.Location = new Point(15, 110);
            travelGroup.Size = new Size(400, 250);

            this.Controls.Add(travelGroup);

            // -------------------------
            // HARADAN
            // -------------------------

            lblFrom = CreateLabel(
                "Haradan:",
                new Point(15, 35)
            );

            travelGroup.Controls.Add(lblFrom);

            cmbFrom = new ComboBox();

            cmbFrom.Name = "cmbFrom";
            cmbFrom.Location = new Point(110, 32);
            cmbFrom.Size = new Size(165, 30);
            cmbFrom.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbFrom.Items.Add("Bakı");
            cmbFrom.Items.Add("Gəncə");
            cmbFrom.Items.Add("Sumqayıt");
            cmbFrom.Items.Add("Qəbələ");
            cmbFrom.Items.Add("Şəki");

            travelGroup.Controls.Add(cmbFrom);

            // -------------------------
            // HARAYA
            // -------------------------

            lblTo = CreateLabel(
                "Haraya:",
                new Point(15, 80)
            );

            travelGroup.Controls.Add(lblTo);

            cmbTo = new ComboBox();

            cmbTo.Name = "cmbTo";
            cmbTo.Location = new Point(110, 77);
            cmbTo.Size = new Size(165, 30);
            cmbTo.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbTo.Items.Add("Bakı");
            cmbTo.Items.Add("Gəncə");
            cmbTo.Items.Add("Sumqayıt");
            cmbTo.Items.Add("Qəbələ");
            cmbTo.Items.Add("Şəki");

            travelGroup.Controls.Add(cmbTo);

            // -------------------------
            // <
            // -------------------------

            btnLeft = new Button();

            btnLeft.Name = "btnLeft";
            btnLeft.Text = "<";
            btnLeft.Font = new Font("Arial", 14, FontStyle.Bold);
            btnLeft.BackColor = Color.DarkRed;
            btnLeft.ForeColor = Color.White;
            btnLeft.FlatStyle = FlatStyle.Flat;
            btnLeft.Location = new Point(290, 35);
            btnLeft.Size = new Size(70, 45);

            btnLeft.Click += BtnLeft_Click;

            travelGroup.Controls.Add(btnLeft);

            // -------------------------
            // >
            // -------------------------

            btnRight = new Button();

            btnRight.Name = "btnRight";
            btnRight.Text = ">";
            btnRight.Font = new Font("Arial", 14, FontStyle.Bold);
            btnRight.BackColor = Color.DarkRed;
            btnRight.ForeColor = Color.White;
            btnRight.FlatStyle = FlatStyle.Flat;
            btnRight.Location = new Point(290, 80);
            btnRight.Size = new Size(70, 45);

            btnRight.Click += BtnRight_Click;

            travelGroup.Controls.Add(btnRight);

            // -------------------------
            // TARİX
            // -------------------------

            lblDate = CreateLabel(
                "Tarix:",
                new Point(15, 130)
            );

            travelGroup.Controls.Add(lblDate);

            txtDate = new MaskedTextBox();

            txtDate.Mask = "00/00/0000";
            txtDate.Location = new Point(110, 127);
            txtDate.Size = new Size(165, 30);
            txtDate.Font = new Font("Arial", 11);

            travelGroup.Controls.Add(txtDate);

            // -------------------------
            // SAAT
            // -------------------------

            lblTime = CreateLabel(
                "Saat:",
                new Point(15, 175)
            );

            travelGroup.Controls.Add(lblTime);

            txtTime = new MaskedTextBox();

            txtTime.Mask = "00:00";
            txtTime.Location = new Point(110, 172);
            txtTime.Size = new Size(165, 30);
            txtTime.Font = new Font("Arial", 11);

            travelGroup.Controls.Add(txtTime);

            // -------------------------
            // YER
            // -------------------------

            lblPlace = CreateLabel(
                "Yer:",
                new Point(15, 215)
            );

            travelGroup.Controls.Add(lblPlace);

            txtPlace = new TextBox();

            txtPlace.Location = new Point(110, 212);
            txtPlace.Size = new Size(165, 30);

            travelGroup.Controls.Add(txtPlace);
        }

        // =========================================================
        // PERSON INFORMATION
        // =========================================================

        private void CreatePersonGroup()
        {
            personGroup = new GroupBox();

            personGroup.Text = "Person information";
            personGroup.Font = new Font("Arial", 11, FontStyle.Bold);
            personGroup.ForeColor = Color.White;

            personGroup.Location = new Point(435, 110);
            personGroup.Size = new Size(380, 250);

            this.Controls.Add(personGroup);

            // AD SOYAD

            lblName = CreateLabel(
                "Ad və soyad:",
                new Point(15, 35)
            );

            personGroup.Controls.Add(lblName);

            txtName = new TextBox();

            txtName.Location = new Point(150, 32);
            txtName.Size = new Size(200, 30);

            personGroup.Controls.Add(txtName);

            // FİN

            lblFin = CreateLabel(
                "FİN:",
                new Point(15, 80)
            );

            personGroup.Controls.Add(lblFin);

            txtFin = new TextBox();

            txtFin.Location = new Point(150, 77);
            txtFin.Size = new Size(200, 30);
            txtFin.MaxLength = 7;

            personGroup.Controls.Add(txtFin);

            // EMAIL

            lblEmail = CreateLabel(
                "Email:",
                new Point(15, 125)
            );

            personGroup.Controls.Add(lblEmail);

            txtEmail = new TextBox();

            txtEmail.Location = new Point(150, 122);
            txtEmail.Size = new Size(200, 30);

            personGroup.Controls.Add(txtEmail);

            // TELEFON

            lblPhone = CreateLabel(
                "Telefon:",
                new Point(15, 170)
            );

            personGroup.Controls.Add(lblPhone);

            txtPhone = new MaskedTextBox();

            txtPhone.Mask = "(000) 00-000-00-00";
            txtPhone.Location = new Point(150, 167);
            txtPhone.Size = new Size(200, 30);

            personGroup.Controls.Add(txtPhone);

            // BİLET AL

            btnBuy = new Button();

            btnBuy.Text = "Bilet al";
            btnBuy.Font = new Font("Arial", 12, FontStyle.Bold);
            btnBuy.BackColor = Color.Green;
            btnBuy.ForeColor = Color.White;
            btnBuy.FlatStyle = FlatStyle.Flat;

            btnBuy.Location = new Point(150, 207);
            btnBuy.Size = new Size(200, 40);

            btnBuy.Click += BtnBuy_Click;

            personGroup.Controls.Add(btnBuy);
        }

        // =========================================================
        // AŞAĞI HİSSƏ
        // =========================================================

        private void CreateBottom()
        {
            // ListBox

            lstTickets = new ListBox();

            lstTickets.Name = "lstTickets";
            lstTickets.Location = new Point(15, 370);
            lstTickets.Size = new Size(800, 90);

            this.Controls.Add(lstTickets);

            // BİLETİ SİL

            btnDelete = new Button();

            btnDelete.Text = "Bileti sil";
            btnDelete.Font = new Font("Arial", 12, FontStyle.Bold);
            btnDelete.BackColor = Color.Teal;
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;

            btnDelete.Location = new Point(15, 475);
            btnDelete.Size = new Size(210, 45);

            btnDelete.Click += BtnDelete_Click;

            this.Controls.Add(btnDelete);

            // PROQRAM ÇIX

            btnExit = new Button();

            btnExit.Text = "Proqram çıx";
            btnExit.Font = new Font("Arial", 12, FontStyle.Bold);
            btnExit.BackColor = Color.Teal;
            btnExit.ForeColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;

            btnExit.Location = new Point(605, 475);
            btnExit.Size = new Size(210, 45);

            btnExit.Click += BtnExit_Click;

            this.Controls.Add(btnExit);
        }

        // =========================================================
        // LABEL YARATMAQ ÜÇÜN FUNKSİYA
        // =========================================================

        private Label CreateLabel(string text, Point location)
        {
            Label label = new Label();

            label.Text = text;
            label.Font = new Font("Arial", 11, FontStyle.Bold);
            label.ForeColor = Color.White;
            label.AutoSize = true;
            label.Location = location;

            return label;
        }

        // =========================================================
        // BİLET AL
        // =========================================================

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            // Haradan yoxlaması

            if (cmbFrom.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Zəhmət olmasa 'Haradan' seçin!",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Haraya yoxlaması

            if (cmbTo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Zəhmət olmasa 'Haraya' seçin!",
                    "Xəbərdarlıq",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            // Eyni şəhər yoxlaması

            if (cmbFrom.Text == cmbTo.Text)
            {
                MessageBox.Show(
                    "Haradan və Haraya eyni ola bilməz!",
                    "Xəta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return;
            }

            // Ad yoxlaması

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Ad və soyadı daxil edin!");
                return;
            }

            // FİN yoxlaması

            if (txtFin.Text.Length != 7)
            {
                MessageBox.Show(
                    "FİN 7 simvoldan ibarət olmalıdır!"
                );

                return;
            }

            // Email yoxlaması

            if (!Regex.IsMatch(
                txtEmail.Text,
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show(
                    "Email düzgün daxil edilməyib!"
                );

                return;
            }

            // Bilet məlumatı

            string ticket =
                "Ad: " + txtName.Text +
                " | " +
                cmbFrom.Text +
                " → " +
                cmbTo.Text +
                " | Tarix: " +
                txtDate.Text +
                " | Saat: " +
                txtTime.Text +
                " | Yer: " +
                txtPlace.Text;

            // ListBox-a əlavə et

            lstTickets.Items.Add(ticket);

            MessageBox.Show(
                "Bilet uğurla alındı!",
                "BMU TRAVEL",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // =========================================================
        // BİLETİ SİL
        // =========================================================

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstTickets.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Silmək üçün bilet seçin!"
                );

                return;
            }

            lstTickets.Items.RemoveAt(
                lstTickets.SelectedIndex
            );
        }

        // =========================================================
        // PROQRAMDAN ÇIX
        // =========================================================

        private void BtnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Proqramdan çıxmaq istəyirsiniz?",
                "BMU TRAVEL",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // =========================================================
        // < DÜYMƏSİ
        // =========================================================

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            string temp = cmbFrom.Text;

            cmbFrom.Text = cmbTo.Text;
            cmbTo.Text = temp;
        }

        // =========================================================
        // > DÜYMƏSİ
        // =========================================================

        private void BtnRight_Click(object sender, EventArgs e)
        {
            string temp = cmbFrom.Text;

            cmbFrom.Text = cmbTo.Text;
            cmbTo.Text = temp;
        }
    }
}