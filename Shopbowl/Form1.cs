using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopbowl
{
    public partial class Dashboard : Form
    {
        private ListBox peopleFoundListbox;
        private TextBox LastNameText;
        private Label LastNameLable;
        private Button searchButton;
        private Label FirstNameInsLable;
        private TextBox FirstNameInsText;
        private Label LastNameInsLable;
        private TextBox LastNameInsText;
        private Label ThreeNameInsLable;
        private TextBox ThreeNameInsText;
        private Label AddressNameInsLable;
        private TextBox AddressNameInsText;
        private Label CityNameInsLable;
        private TextBox CityNameInsText;
        private Label PhonenumberInsLable;
        private TextBox PhoneNumberInsText;
        private Button InsertRecordButton;
        List<Customers> customers = new List<Customers>();


        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
        } 

        private void UpdateBinding()
        {

            peopleFoundListbox.DataSource = customers;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        private void InitializeComponent()
        {
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.FirstNameInsLable = new System.Windows.Forms.Label();
            this.FirstNameInsText = new System.Windows.Forms.TextBox();
            this.LastNameInsLable = new System.Windows.Forms.Label();
            this.LastNameInsText = new System.Windows.Forms.TextBox();
            this.ThreeNameInsLable = new System.Windows.Forms.Label();
            this.ThreeNameInsText = new System.Windows.Forms.TextBox();
            this.AddressNameInsLable = new System.Windows.Forms.Label();
            this.AddressNameInsText = new System.Windows.Forms.TextBox();
            this.CityNameInsLable = new System.Windows.Forms.Label();
            this.CityNameInsText = new System.Windows.Forms.TextBox();
            this.PhonenumberInsLable = new System.Windows.Forms.Label();
            this.PhoneNumberInsText = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.ItemHeight = 20;
            this.peopleFoundListbox.Location = new System.Drawing.Point(494, 167);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(770, 304);
            this.peopleFoundListbox.TabIndex = 0;
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(730, 118);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(304, 26);
            this.LastNameText.TabIndex = 1;
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.Location = new System.Drawing.Point(492, 124);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(232, 20);
            this.LastNameLable.TabIndex = 2;
            this.LastNameLable.Text = "Введіть фамілію для пошуку:";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(1055, 101);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(191, 60);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // FirstNameInsLable
            // 
            this.FirstNameInsLable.AutoSize = true;
            this.FirstNameInsLable.Location = new System.Drawing.Point(9, 145);
            this.FirstNameInsLable.Name = "FirstNameInsLable";
            this.FirstNameInsLable.Size = new System.Drawing.Size(41, 20);
            this.FirstNameInsLable.TabIndex = 5;
            this.FirstNameInsLable.Text = "Ім\'я:";
            // 
            // FirstNameInsText
            // 
            this.FirstNameInsText.Location = new System.Drawing.Point(157, 145);
            this.FirstNameInsText.Name = "FirstNameInsText";
            this.FirstNameInsText.Size = new System.Drawing.Size(297, 26);
            this.FirstNameInsText.TabIndex = 4;
            // 
            // LastNameInsLable
            // 
            this.LastNameInsLable.AutoSize = true;
            this.LastNameInsLable.Location = new System.Drawing.Point(9, 210);
            this.LastNameInsLable.Name = "LastNameInsLable";
            this.LastNameInsLable.Size = new System.Drawing.Size(73, 20);
            this.LastNameInsLable.TabIndex = 7;
            this.LastNameInsLable.Text = "Фамілія:";
            // 
            // LastNameInsText
            // 
            this.LastNameInsText.Location = new System.Drawing.Point(157, 207);
            this.LastNameInsText.Name = "LastNameInsText";
            this.LastNameInsText.Size = new System.Drawing.Size(297, 26);
            this.LastNameInsText.TabIndex = 6;
            this.LastNameInsText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ThreeNameInsLable
            // 
            this.ThreeNameInsLable.AutoSize = true;
            this.ThreeNameInsLable.Location = new System.Drawing.Point(9, 264);
            this.ThreeNameInsLable.Name = "ThreeNameInsLable";
            this.ThreeNameInsLable.Size = new System.Drawing.Size(104, 20);
            this.ThreeNameInsLable.TabIndex = 9;
            this.ThreeNameInsLable.Text = "По-батькові:";
            // 
            // ThreeNameInsText
            // 
            this.ThreeNameInsText.Location = new System.Drawing.Point(157, 261);
            this.ThreeNameInsText.Name = "ThreeNameInsText";
            this.ThreeNameInsText.Size = new System.Drawing.Size(297, 26);
            this.ThreeNameInsText.TabIndex = 8;
            // 
            // AddressNameInsLable
            // 
            this.AddressNameInsLable.AutoSize = true;
            this.AddressNameInsLable.Location = new System.Drawing.Point(9, 318);
            this.AddressNameInsLable.Name = "AddressNameInsLable";
            this.AddressNameInsLable.Size = new System.Drawing.Size(70, 20);
            this.AddressNameInsLable.TabIndex = 11;
            this.AddressNameInsLable.Text = "Адреса:";
            // 
            // AddressNameInsText
            // 
            this.AddressNameInsText.Location = new System.Drawing.Point(157, 315);
            this.AddressNameInsText.Name = "AddressNameInsText";
            this.AddressNameInsText.Size = new System.Drawing.Size(297, 26);
            this.AddressNameInsText.TabIndex = 10;
            // 
            // CityNameInsLable
            // 
            this.CityNameInsLable.AutoSize = true;
            this.CityNameInsLable.Location = new System.Drawing.Point(9, 380);
            this.CityNameInsLable.Name = "CityNameInsLable";
            this.CityNameInsLable.Size = new System.Drawing.Size(55, 20);
            this.CityNameInsLable.TabIndex = 13;
            this.CityNameInsLable.Text = "Місто:";
            this.CityNameInsLable.Click += new System.EventHandler(this.label1_Click);
            // 
            // CityNameInsText
            // 
            this.CityNameInsText.Location = new System.Drawing.Point(157, 380);
            this.CityNameInsText.Name = "CityNameInsText";
            this.CityNameInsText.Size = new System.Drawing.Size(297, 26);
            this.CityNameInsText.TabIndex = 12;
            // 
            // PhonenumberInsLable
            // 
            this.PhonenumberInsLable.AutoSize = true;
            this.PhonenumberInsLable.Location = new System.Drawing.Point(9, 436);
            this.PhonenumberInsLable.Name = "PhonenumberInsLable";
            this.PhonenumberInsLable.Size = new System.Drawing.Size(144, 20);
            this.PhonenumberInsLable.TabIndex = 15;
            this.PhonenumberInsLable.Text = "Номер телефону:";
            this.PhonenumberInsLable.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PhoneNumberInsText
            // 
            this.PhoneNumberInsText.Location = new System.Drawing.Point(157, 433);
            this.PhoneNumberInsText.Name = "PhoneNumberInsText";
            this.PhoneNumberInsText.Size = new System.Drawing.Size(297, 26);
            this.PhoneNumberInsText.TabIndex = 14;
            this.PhoneNumberInsText.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(157, 507);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(151, 59);
            this.InsertRecordButton.TabIndex = 16;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // Dashboard
            // 
            this.ClientSize = new System.Drawing.Size(1471, 807);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.PhonenumberInsLable);
            this.Controls.Add(this.PhoneNumberInsText);
            this.Controls.Add(this.CityNameInsLable);
            this.Controls.Add(this.CityNameInsText);
            this.Controls.Add(this.AddressNameInsLable);
            this.Controls.Add(this.AddressNameInsText);
            this.Controls.Add(this.ThreeNameInsLable);
            this.Controls.Add(this.ThreeNameInsText);
            this.Controls.Add(this.LastNameInsLable);
            this.Controls.Add(this.LastNameInsText);
            this.Controls.Add(this.FirstNameInsLable);
            this.Controls.Add(this.FirstNameInsText);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.LastNameLable);
            this.Controls.Add(this.LastNameText);
            this.Controls.Add(this.peopleFoundListbox);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void searchButton_Click(object sender, EventArgs e)
        { 
            DataAccess db = new DataAccess();
            customers = db.GetCustomers  (LastNameText.Text);

            peopleFoundListbox.DataSource = customers;
            peopleFoundListbox.DisplayMember = "FullInfo";

            UpdateBinding();
        }
        private void InsertRecordButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertCustomers(FirstNameInsText.Text, LastNameInsText.Text, ThreeNameInsText.Text,
                AddressNameInsText.Text, CityNameInsText.Text, PhoneNumberInsText.Text);

            FirstNameInsText.Text = "";
            LastNameInsText.Text = "";
            ThreeNameInsText.Text = "";
            AddressNameInsText.Text = "";
            CityNameInsText.Text = "";
            PhoneNumberInsText.Text = "";

        }










        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
