
namespace DeanP_301172869_A4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxClubsPath = new System.Windows.Forms.TextBox();
            this.btnLoadClubs = new System.Windows.Forms.Button();
            this.listClubs = new System.Windows.Forms.ListBox();
            this.listSwimmers = new System.Windows.Forms.ListBox();
            this.labelClubs = new System.Windows.Forms.Label();
            this.labelSwimmers = new System.Windows.Forms.Label();
            this.btnAddClub = new System.Windows.Forms.Button();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.btnSaveClubs = new System.Windows.Forms.Button();
            this.btnSaveSwimmers = new System.Windows.Forms.Button();
            this.btnLoadSwimmers = new System.Windows.Forms.Button();
            this.textBoxSwimmersPath = new System.Windows.Forms.TextBox();
            this.grpBoxClub = new System.Windows.Forms.GroupBox();
            this.listBoxClubSwimmers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelClubCoach = new System.Windows.Forms.Label();
            this.labelClubPhone = new System.Windows.Forms.Label();
            this.labelClubName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelClubNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelClubProvince = new System.Windows.Forms.Label();
            this.labelClubPostalCode = new System.Windows.Forms.Label();
            this.labelClubCity = new System.Windows.Forms.Label();
            this.labelClubStreet = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpBoxSwimmer = new System.Windows.Forms.GroupBox();
            this.labelSwimmerNumber = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSwimmerClub = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelSwimmerDOB = new System.Windows.Forms.Label();
            this.labelSwimmerPhone = new System.Windows.Forms.Label();
            this.labelSwimmerName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelSwimmerProvince = new System.Windows.Forms.Label();
            this.labelSwimmerPostalCode = new System.Windows.Forms.Label();
            this.labelSwimmerCity = new System.Windows.Forms.Label();
            this.labelSwimmerStreet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClubBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSwimmersBrowse = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpBoxClub.SuspendLayout();
            this.grpBoxSwimmer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxClubsPath
            // 
            this.txtBoxClubsPath.Location = new System.Drawing.Point(58, 21);
            this.txtBoxClubsPath.Name = "txtBoxClubsPath";
            this.txtBoxClubsPath.Size = new System.Drawing.Size(195, 22);
            this.txtBoxClubsPath.TabIndex = 0;
            // 
            // btnLoadClubs
            // 
            this.btnLoadClubs.Location = new System.Drawing.Point(14, 49);
            this.btnLoadClubs.Name = "btnLoadClubs";
            this.btnLoadClubs.Size = new System.Drawing.Size(118, 23);
            this.btnLoadClubs.TabIndex = 1;
            this.btnLoadClubs.Text = "Load Clubs";
            this.btnLoadClubs.UseVisualStyleBackColor = true;
            this.btnLoadClubs.Click += new System.EventHandler(this.btnLoadClubs_Click);
            // 
            // listClubs
            // 
            this.listClubs.FormattingEnabled = true;
            this.listClubs.ItemHeight = 16;
            this.listClubs.Location = new System.Drawing.Point(14, 56);
            this.listClubs.Name = "listClubs";
            this.listClubs.Size = new System.Drawing.Size(168, 324);
            this.listClubs.TabIndex = 2;
            this.listClubs.SelectedIndexChanged += new System.EventHandler(this.listClubs_SelectedIndexChanged);
            // 
            // listSwimmers
            // 
            this.listSwimmers.FormattingEnabled = true;
            this.listSwimmers.ItemHeight = 16;
            this.listSwimmers.Location = new System.Drawing.Point(191, 56);
            this.listSwimmers.Name = "listSwimmers";
            this.listSwimmers.Size = new System.Drawing.Size(185, 324);
            this.listSwimmers.TabIndex = 3;
            this.listSwimmers.SelectedIndexChanged += new System.EventHandler(this.listSwimmers_SelectedIndexChanged);
            // 
            // labelClubs
            // 
            this.labelClubs.AutoSize = true;
            this.labelClubs.Location = new System.Drawing.Point(14, 33);
            this.labelClubs.Name = "labelClubs";
            this.labelClubs.Size = new System.Drawing.Size(47, 17);
            this.labelClubs.TabIndex = 4;
            this.labelClubs.Text = "Clubs:";
            // 
            // labelSwimmers
            // 
            this.labelSwimmers.AutoSize = true;
            this.labelSwimmers.Location = new System.Drawing.Point(188, 33);
            this.labelSwimmers.Name = "labelSwimmers";
            this.labelSwimmers.Size = new System.Drawing.Size(75, 17);
            this.labelSwimmers.TabIndex = 5;
            this.labelSwimmers.Text = "Swimmers:";
            // 
            // btnAddClub
            // 
            this.btnAddClub.Location = new System.Drawing.Point(67, 30);
            this.btnAddClub.Name = "btnAddClub";
            this.btnAddClub.Size = new System.Drawing.Size(115, 23);
            this.btnAddClub.TabIndex = 6;
            this.btnAddClub.Text = "Add Club";
            this.btnAddClub.UseVisualStyleBackColor = true;
            this.btnAddClub.Click += new System.EventHandler(this.btnAddClub_Click);
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.Location = new System.Drawing.Point(269, 30);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(110, 23);
            this.btnAddSwimmer.TabIndex = 7;
            this.btnAddSwimmer.Text = "Add Swimmer";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // btnSaveClubs
            // 
            this.btnSaveClubs.Location = new System.Drawing.Point(138, 49);
            this.btnSaveClubs.Name = "btnSaveClubs";
            this.btnSaveClubs.Size = new System.Drawing.Size(118, 23);
            this.btnSaveClubs.TabIndex = 8;
            this.btnSaveClubs.Text = "Save Clubs";
            this.btnSaveClubs.UseVisualStyleBackColor = true;
            this.btnSaveClubs.Click += new System.EventHandler(this.btnSaveClubs_Click);
            // 
            // btnSaveSwimmers
            // 
            this.btnSaveSwimmers.Location = new System.Drawing.Point(143, 49);
            this.btnSaveSwimmers.Name = "btnSaveSwimmers";
            this.btnSaveSwimmers.Size = new System.Drawing.Size(131, 23);
            this.btnSaveSwimmers.TabIndex = 11;
            this.btnSaveSwimmers.Text = "Save Swimmers";
            this.btnSaveSwimmers.UseVisualStyleBackColor = true;
            this.btnSaveSwimmers.Click += new System.EventHandler(this.btnSaveSwimmers_Click);
            // 
            // btnLoadSwimmers
            // 
            this.btnLoadSwimmers.Location = new System.Drawing.Point(11, 49);
            this.btnLoadSwimmers.Name = "btnLoadSwimmers";
            this.btnLoadSwimmers.Size = new System.Drawing.Size(126, 23);
            this.btnLoadSwimmers.TabIndex = 10;
            this.btnLoadSwimmers.Text = "Load Swimmers";
            this.btnLoadSwimmers.UseVisualStyleBackColor = true;
            this.btnLoadSwimmers.Click += new System.EventHandler(this.btnLoadSwimmers_Click);
            // 
            // textBoxSwimmersPath
            // 
            this.textBoxSwimmersPath.Location = new System.Drawing.Point(58, 21);
            this.textBoxSwimmersPath.Name = "textBoxSwimmersPath";
            this.textBoxSwimmersPath.Size = new System.Drawing.Size(212, 22);
            this.textBoxSwimmersPath.TabIndex = 9;
            // 
            // grpBoxClub
            // 
            this.grpBoxClub.Controls.Add(this.listBoxClubSwimmers);
            this.grpBoxClub.Controls.Add(this.label6);
            this.grpBoxClub.Controls.Add(this.labelClubCoach);
            this.grpBoxClub.Controls.Add(this.labelClubPhone);
            this.grpBoxClub.Controls.Add(this.labelClubName);
            this.grpBoxClub.Controls.Add(this.label5);
            this.grpBoxClub.Controls.Add(this.labelClubNumber);
            this.grpBoxClub.Controls.Add(this.label4);
            this.grpBoxClub.Controls.Add(this.labelClubProvince);
            this.grpBoxClub.Controls.Add(this.labelClubPostalCode);
            this.grpBoxClub.Controls.Add(this.labelClubCity);
            this.grpBoxClub.Controls.Add(this.labelClubStreet);
            this.grpBoxClub.Controls.Add(this.label3);
            this.grpBoxClub.Controls.Add(this.label2);
            this.grpBoxClub.Controls.Add(this.label1);
            this.grpBoxClub.Location = new System.Drawing.Point(385, 30);
            this.grpBoxClub.Name = "grpBoxClub";
            this.grpBoxClub.Size = new System.Drawing.Size(296, 193);
            this.grpBoxClub.TabIndex = 12;
            this.grpBoxClub.TabStop = false;
            this.grpBoxClub.Text = "Club Information";
            // 
            // listBoxClubSwimmers
            // 
            this.listBoxClubSwimmers.FormattingEnabled = true;
            this.listBoxClubSwimmers.ItemHeight = 16;
            this.listBoxClubSwimmers.Location = new System.Drawing.Point(167, 60);
            this.listBoxClubSwimmers.Name = "listBoxClubSwimmers";
            this.listBoxClubSwimmers.Size = new System.Drawing.Size(120, 116);
            this.listBoxClubSwimmers.TabIndex = 14;
            this.listBoxClubSwimmers.SelectedIndexChanged += new System.EventHandler(this.listBoxClubSwimmers_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Swimmers:";
            // 
            // labelClubCoach
            // 
            this.labelClubCoach.AutoSize = true;
            this.labelClubCoach.Location = new System.Drawing.Point(65, 159);
            this.labelClubCoach.Name = "labelClubCoach";
            this.labelClubCoach.Size = new System.Drawing.Size(0, 17);
            this.labelClubCoach.TabIndex = 12;
            // 
            // labelClubPhone
            // 
            this.labelClubPhone.AutoSize = true;
            this.labelClubPhone.Location = new System.Drawing.Point(65, 142);
            this.labelClubPhone.Name = "labelClubPhone";
            this.labelClubPhone.Size = new System.Drawing.Size(0, 17);
            this.labelClubPhone.TabIndex = 11;
            // 
            // labelClubName
            // 
            this.labelClubName.AutoSize = true;
            this.labelClubName.Location = new System.Drawing.Point(62, 40);
            this.labelClubName.Name = "labelClubName";
            this.labelClubName.Size = new System.Drawing.Size(0, 17);
            this.labelClubName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Coach:";
            // 
            // labelClubNumber
            // 
            this.labelClubNumber.AutoSize = true;
            this.labelClubNumber.Location = new System.Drawing.Point(245, 13);
            this.labelClubNumber.Name = "labelClubNumber";
            this.labelClubNumber.Size = new System.Drawing.Size(0, 17);
            this.labelClubNumber.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reg Number:";
            // 
            // labelClubProvince
            // 
            this.labelClubProvince.AutoSize = true;
            this.labelClubProvince.Location = new System.Drawing.Point(39, 108);
            this.labelClubProvince.Name = "labelClubProvince";
            this.labelClubProvince.Size = new System.Drawing.Size(0, 17);
            this.labelClubProvince.TabIndex = 6;
            // 
            // labelClubPostalCode
            // 
            this.labelClubPostalCode.AutoSize = true;
            this.labelClubPostalCode.Location = new System.Drawing.Point(40, 125);
            this.labelClubPostalCode.Name = "labelClubPostalCode";
            this.labelClubPostalCode.Size = new System.Drawing.Size(0, 17);
            this.labelClubPostalCode.TabIndex = 5;
            // 
            // labelClubCity
            // 
            this.labelClubCity.AutoSize = true;
            this.labelClubCity.Location = new System.Drawing.Point(39, 91);
            this.labelClubCity.Name = "labelClubCity";
            this.labelClubCity.Size = new System.Drawing.Size(0, 17);
            this.labelClubCity.TabIndex = 4;
            // 
            // labelClubStreet
            // 
            this.labelClubStreet.AutoSize = true;
            this.labelClubStreet.Location = new System.Drawing.Point(39, 74);
            this.labelClubStreet.Name = "labelClubStreet";
            this.labelClubStreet.Size = new System.Drawing.Size(0, 17);
            this.labelClubStreet.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // grpBoxSwimmer
            // 
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerNumber);
            this.grpBoxSwimmer.Controls.Add(this.label11);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerClub);
            this.grpBoxSwimmer.Controls.Add(this.label8);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerDOB);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerPhone);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerName);
            this.grpBoxSwimmer.Controls.Add(this.label10);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerProvince);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerPostalCode);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerCity);
            this.grpBoxSwimmer.Controls.Add(this.labelSwimmerStreet);
            this.grpBoxSwimmer.Controls.Add(this.label9);
            this.grpBoxSwimmer.Controls.Add(this.label16);
            this.grpBoxSwimmer.Controls.Add(this.label17);
            this.grpBoxSwimmer.Location = new System.Drawing.Point(385, 229);
            this.grpBoxSwimmer.Name = "grpBoxSwimmer";
            this.grpBoxSwimmer.Size = new System.Drawing.Size(296, 198);
            this.grpBoxSwimmer.TabIndex = 13;
            this.grpBoxSwimmer.TabStop = false;
            this.grpBoxSwimmer.Text = "Swimmer Information";
            // 
            // labelSwimmerNumber
            // 
            this.labelSwimmerNumber.AutoSize = true;
            this.labelSwimmerNumber.Location = new System.Drawing.Point(212, 13);
            this.labelSwimmerNumber.Name = "labelSwimmerNumber";
            this.labelSwimmerNumber.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerNumber.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "ID:";
            // 
            // labelSwimmerClub
            // 
            this.labelSwimmerClub.AutoSize = true;
            this.labelSwimmerClub.Location = new System.Drawing.Point(103, 174);
            this.labelSwimmerClub.Name = "labelSwimmerClub";
            this.labelSwimmerClub.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerClub.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Club:";
            // 
            // labelSwimmerDOB
            // 
            this.labelSwimmerDOB.AutoSize = true;
            this.labelSwimmerDOB.Location = new System.Drawing.Point(103, 157);
            this.labelSwimmerDOB.Name = "labelSwimmerDOB";
            this.labelSwimmerDOB.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerDOB.TabIndex = 23;
            // 
            // labelSwimmerPhone
            // 
            this.labelSwimmerPhone.AutoSize = true;
            this.labelSwimmerPhone.Location = new System.Drawing.Point(103, 140);
            this.labelSwimmerPhone.Name = "labelSwimmerPhone";
            this.labelSwimmerPhone.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerPhone.TabIndex = 22;
            // 
            // labelSwimmerName
            // 
            this.labelSwimmerName.AutoSize = true;
            this.labelSwimmerName.Location = new System.Drawing.Point(61, 38);
            this.labelSwimmerName.Name = "labelSwimmerName";
            this.labelSwimmerName.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerName.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Date of Birth:";
            // 
            // labelSwimmerProvince
            // 
            this.labelSwimmerProvince.AutoSize = true;
            this.labelSwimmerProvince.Location = new System.Drawing.Point(38, 106);
            this.labelSwimmerProvince.Name = "labelSwimmerProvince";
            this.labelSwimmerProvince.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerProvince.TabIndex = 19;
            // 
            // labelSwimmerPostalCode
            // 
            this.labelSwimmerPostalCode.AutoSize = true;
            this.labelSwimmerPostalCode.Location = new System.Drawing.Point(39, 123);
            this.labelSwimmerPostalCode.Name = "labelSwimmerPostalCode";
            this.labelSwimmerPostalCode.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerPostalCode.TabIndex = 18;
            // 
            // labelSwimmerCity
            // 
            this.labelSwimmerCity.AutoSize = true;
            this.labelSwimmerCity.Location = new System.Drawing.Point(38, 89);
            this.labelSwimmerCity.Name = "labelSwimmerCity";
            this.labelSwimmerCity.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerCity.TabIndex = 17;
            // 
            // labelSwimmerStreet
            // 
            this.labelSwimmerStreet.AutoSize = true;
            this.labelSwimmerStreet.Location = new System.Drawing.Point(38, 72);
            this.labelSwimmerStreet.Name = "labelSwimmerStreet";
            this.labelSwimmerStreet.Size = new System.Drawing.Size(0, 17);
            this.labelSwimmerStreet.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Phone:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 14;
            this.label16.Text = "Address:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Name:";
            // 
            // btnAssign
            // 
            this.btnAssign.Location = new System.Drawing.Point(14, 395);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(362, 32);
            this.btnAssign.TabIndex = 14;
            this.btnAssign.Text = "Assign Swimmer";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClubBrowse);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBoxClubsPath);
            this.groupBox1.Controls.Add(this.btnSaveClubs);
            this.groupBox1.Controls.Add(this.btnLoadClubs);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 88);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clubs File Handler";
            // 
            // btnClubBrowse
            // 
            this.btnClubBrowse.Location = new System.Drawing.Point(262, 20);
            this.btnClubBrowse.Name = "btnClubBrowse";
            this.btnClubBrowse.Size = new System.Drawing.Size(75, 53);
            this.btnClubBrowse.TabIndex = 10;
            this.btnClubBrowse.Text = "Browse";
            this.btnClubBrowse.UseVisualStyleBackColor = true;
            this.btnClubBrowse.Click += new System.EventHandler(this.btnClubBrowse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Path:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSwimmersBrowse);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBoxSwimmersPath);
            this.groupBox2.Controls.Add(this.btnSaveSwimmers);
            this.groupBox2.Controls.Add(this.btnLoadSwimmers);
            this.groupBox2.Location = new System.Drawing.Point(363, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 88);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Swimmers File Handler";
            // 
            // btnSwimmersBrowse
            // 
            this.btnSwimmersBrowse.Location = new System.Drawing.Point(276, 20);
            this.btnSwimmersBrowse.Name = "btnSwimmersBrowse";
            this.btnSwimmersBrowse.Size = new System.Drawing.Size(70, 53);
            this.btnSwimmersBrowse.TabIndex = 11;
            this.btnSwimmersBrowse.Text = "Browse";
            this.btnSwimmersBrowse.UseVisualStyleBackColor = true;
            this.btnSwimmersBrowse.Click += new System.EventHandler(this.btnSwimmersBrowse_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Path:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listClubs);
            this.groupBox3.Controls.Add(this.labelClubs);
            this.groupBox3.Controls.Add(this.btnAddClub);
            this.groupBox3.Controls.Add(this.grpBoxSwimmer);
            this.groupBox3.Controls.Add(this.btnAssign);
            this.groupBox3.Controls.Add(this.grpBoxClub);
            this.groupBox3.Controls.Add(this.labelSwimmers);
            this.groupBox3.Controls.Add(this.listSwimmers);
            this.groupBox3.Controls.Add(this.btnAddSwimmer);
            this.groupBox3.Location = new System.Drawing.Point(12, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 438);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 556);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxClub.ResumeLayout(false);
            this.grpBoxClub.PerformLayout();
            this.grpBoxSwimmer.ResumeLayout(false);
            this.grpBoxSwimmer.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxClubsPath;
        private System.Windows.Forms.Button btnLoadClubs;
        private System.Windows.Forms.ListBox listClubs;
        private System.Windows.Forms.ListBox listSwimmers;
        private System.Windows.Forms.Label labelClubs;
        private System.Windows.Forms.Label labelSwimmers;
        private System.Windows.Forms.Button btnAddClub;
        private System.Windows.Forms.Button btnAddSwimmer;
        private System.Windows.Forms.Button btnSaveClubs;
        private System.Windows.Forms.Button btnSaveSwimmers;
        private System.Windows.Forms.Button btnLoadSwimmers;
        private System.Windows.Forms.TextBox textBoxSwimmersPath;
        private System.Windows.Forms.GroupBox grpBoxClub;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelClubCity;
        private System.Windows.Forms.Label labelClubStreet;
        private System.Windows.Forms.Label labelClubProvince;
        private System.Windows.Forms.Label labelClubPostalCode;
        private System.Windows.Forms.Label labelClubNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelClubPhone;
        private System.Windows.Forms.Label labelClubName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxClubSwimmers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelClubCoach;
        private System.Windows.Forms.GroupBox grpBoxSwimmer;
        private System.Windows.Forms.Label labelSwimmerDOB;
        private System.Windows.Forms.Label labelSwimmerPhone;
        private System.Windows.Forms.Label labelSwimmerName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSwimmerProvince;
        private System.Windows.Forms.Label labelSwimmerPostalCode;
        private System.Windows.Forms.Label labelSwimmerCity;
        private System.Windows.Forms.Label labelSwimmerStreet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelSwimmerClub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelSwimmerNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClubBrowse;
        private System.Windows.Forms.Button btnSwimmersBrowse;
    }
}

