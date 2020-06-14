using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopbowl
{
    public partial class Dashboard : Form
    {
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button InsertRecordButton;
        private Label PhonenumberInsLable;
        private TextBox PhoneNumberInsText;
        private Label CityNameInsLable;
        private TextBox CityNameInsText;
        private Label AddressNameInsLable;
        private TextBox AddressNameInsText;
        private Label ThreeNameInsLable;
        private TextBox ThreeNameInsText;
        private Label LastNameInsLable;
        private TextBox LastNameInsText;
        private Label FirstNameInsLable;
        private TextBox FirstNameInsText;
        private Button searchButton;
        private Label LastNameLable;
        private TextBox LastNameText;
        private TabPage tabPage3;
        private Label DataInSystemLable;
        private TextBox DataInSystemData;
        private Label PriorSalaryLable;
        private Label SalaryLable;
        private Label PostNameLable;
        private Label ThreeNameLable;
        private Label LasttNameLable;
        private Label FirstNameLable;
        private TextBox PriorSalaryInt;
        private TextBox SalaryInt;
        private TextBox PostText;
        private TextBox ThreeNameText;
        private TextBox TwoNameText;
        private TextBox FirstNameText;
        private Button InsertEmploees;
        private TextBox LastNameTextE;
        private Label LastNameLableE;
        private ListBox EmploeesFoundListBox;
        private Button SerchButtonE;
        private ListBox peopleFoundListbox;
        private Button DeleteEmployeesButton;
        private TextBox DeleteIdText;
        private Label DeleteId;
        private Label CountryNameInsLable;
        private TextBox CountryNameText;
        private Label CompanyNameInsLable;
        private TextBox CompanyNameText;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button InsertMakerButton;
        private GroupBox groupBox3;
        private Button DescriptButton;
        private TextBox DescriptText;
        private Label label1;
        private GroupBox groupBox2;
        private Button InsertTypePtoductButton;
        private TextBox TypeProductText;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button InsertDescriptButton;
        private Button InsertDe;
        private TextBox DecriptText;
        private ListBox ShowAllListBox;
        private Button DescriptionShowButton;
        private Button TypeProsuctShowButton;
        private Button MakerShowButton;
        private TabPage tabPage5;
        private TabPage tabPage4;
        private TextBox MakerIansText;
        private TextBox DescriptInsText;
        private TextBox TypeGoodsInsText;
        private TextBox NameGoodsInsText;
        private ListBox ShowInfoProductsList;
        private TextBox PriceDolarInsText;
        private TextBox CountGoodsInsText;
        private TextBox FoundGoodstext;
        private Label label9;
        private Button button5;
        private GroupBox groupBox4;
        private Button button3;
        private Button button4;
        private GroupBox groupBox5;
        private Label label7;
        private Label label3;
        private Label label8;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox6;
        private TextBox IdOrderText;
        private Label label18;
        private TextBox CountGoodsText;
        private Label label15;
        private TextBox IDGoodsText;
        private Label label16;
        private TextBox IDTableOrdersText;
        private Label label17;
        private TextBox SplitDateText;
        private Label label13;
        private TextBox OrderDateText;
        private Label label12;
        private TextBox IdEmploeeText;
        private Label label11;
        private TextBox IdCustomerText;
        private Label label10;
        private Button button7;
        private Button button6;
        private IContainer components;
        private BowlingStormAccessoriesDataSet bowlingStormAccessoriesDataSet;
        private BindingSource ordersBindingSource;
        private BowlingStormAccessoriesDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private BindingSource bowlingStormAccessoriesDataSetBindingSource;
        private BindingSource ordersDetailsBindingSource;
        private BowlingStormAccessoriesDataSetTableAdapters.OrdersDetailsTableAdapter ordersDetailsTableAdapter;
        private BindingSource bowlingStormAccessoriesDataSetBindingSource1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Button button8;
        private Label label14;
        private TextBox IdNumberUpdateText;
        private Button button9;
        private Button InsertDesriptButton;





  

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ordersDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bowlingStormAccessoriesDataSet = new Shopbowl.BowlingStormAccessoriesDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InsertDescriptButton = new System.Windows.Forms.Button();
            this.InsertDe = new System.Windows.Forms.Button();
            this.InsertDesriptButton = new System.Windows.Forms.Button();
            this.DecriptText = new System.Windows.Forms.TextBox();
            this.ordersTableAdapter = new Shopbowl.BowlingStormAccessoriesDataSetTableAdapters.OrdersTableAdapter();
            this.bowlingStormAccessoriesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDetailsTableAdapter = new Shopbowl.BowlingStormAccessoriesDataSetTableAdapters.OrdersDetailsTableAdapter();
            this.bowlingStormAccessoriesDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.peopleFoundListbox = new System.Windows.Forms.ListBox();
            this.DataInSystemLable = new System.Windows.Forms.Label();
            this.DataInSystemData = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.PhonenumberInsLable = new System.Windows.Forms.Label();
            this.PhoneNumberInsText = new System.Windows.Forms.TextBox();
            this.CityNameInsLable = new System.Windows.Forms.Label();
            this.CityNameInsText = new System.Windows.Forms.TextBox();
            this.AddressNameInsLable = new System.Windows.Forms.Label();
            this.AddressNameInsText = new System.Windows.Forms.TextBox();
            this.ThreeNameInsLable = new System.Windows.Forms.Label();
            this.ThreeNameInsText = new System.Windows.Forms.TextBox();
            this.LastNameInsLable = new System.Windows.Forms.Label();
            this.LastNameInsText = new System.Windows.Forms.TextBox();
            this.FirstNameInsLable = new System.Windows.Forms.Label();
            this.FirstNameInsText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.LastNameLable = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DeleteEmployeesButton = new System.Windows.Forms.Button();
            this.DeleteIdText = new System.Windows.Forms.TextBox();
            this.DeleteId = new System.Windows.Forms.Label();
            this.SerchButtonE = new System.Windows.Forms.Button();
            this.LastNameTextE = new System.Windows.Forms.TextBox();
            this.LastNameLableE = new System.Windows.Forms.Label();
            this.EmploeesFoundListBox = new System.Windows.Forms.ListBox();
            this.InsertEmploees = new System.Windows.Forms.Button();
            this.PriorSalaryInt = new System.Windows.Forms.TextBox();
            this.SalaryInt = new System.Windows.Forms.TextBox();
            this.PostText = new System.Windows.Forms.TextBox();
            this.ThreeNameText = new System.Windows.Forms.TextBox();
            this.TwoNameText = new System.Windows.Forms.TextBox();
            this.FirstNameText = new System.Windows.Forms.TextBox();
            this.PriorSalaryLable = new System.Windows.Forms.Label();
            this.SalaryLable = new System.Windows.Forms.Label();
            this.PostNameLable = new System.Windows.Forms.Label();
            this.ThreeNameLable = new System.Windows.Forms.Label();
            this.LasttNameLable = new System.Windows.Forms.Label();
            this.FirstNameLable = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DescriptionShowButton = new System.Windows.Forms.Button();
            this.TypeProsuctShowButton = new System.Windows.Forms.Button();
            this.MakerShowButton = new System.Windows.Forms.Button();
            this.ShowAllListBox = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DescriptButton = new System.Windows.Forms.Button();
            this.DescriptText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InsertTypePtoductButton = new System.Windows.Forms.Button();
            this.TypeProductText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InsertMakerButton = new System.Windows.Forms.Button();
            this.CompanyNameText = new System.Windows.Forms.TextBox();
            this.CountryNameInsLable = new System.Windows.Forms.Label();
            this.CompanyNameInsLable = new System.Windows.Forms.Label();
            this.CountryNameText = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.FoundGoodstext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.IdNumberUpdateText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.DescriptInsText = new System.Windows.Forms.TextBox();
            this.NameGoodsInsText = new System.Windows.Forms.TextBox();
            this.PriceDolarInsText = new System.Windows.Forms.TextBox();
            this.TypeGoodsInsText = new System.Windows.Forms.TextBox();
            this.CountGoodsInsText = new System.Windows.Forms.TextBox();
            this.MakerIansText = new System.Windows.Forms.TextBox();
            this.ShowInfoProductsList = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.IdOrderText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.CountGoodsText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.IDGoodsText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.IDTableOrdersText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SplitDateText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.OrderDateText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IdEmploeeText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IdCustomerText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingStormAccessoriesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingStormAccessoriesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingStormAccessoriesDataSetBindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1297, 706);
            this.tabControl1.TabIndex = 17;
            // 
            // ordersDetailsBindingSource
            // 
            this.ordersDetailsBindingSource.DataMember = "OrdersDetails";
            this.ordersDetailsBindingSource.DataSource = this.bowlingStormAccessoriesDataSet;
            // 
            // bowlingStormAccessoriesDataSet
            // 
            this.bowlingStormAccessoriesDataSet.DataSetName = "BowlingStormAccessoriesDataSet";
            this.bowlingStormAccessoriesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.bowlingStormAccessoriesDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(227, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(227, 100);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Insert";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // InsertDescriptButton
            // 
            this.InsertDescriptButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertDescriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertDescriptButton.ForeColor = System.Drawing.Color.Black;
            this.InsertDescriptButton.Location = new System.Drawing.Point(227, 100);
            this.InsertDescriptButton.Name = "InsertDescriptButton";
            this.InsertDescriptButton.Size = new System.Drawing.Size(148, 54);
            this.InsertDescriptButton.TabIndex = 4;
            this.InsertDescriptButton.Text = "Insert";
            this.InsertDescriptButton.UseVisualStyleBackColor = false;
            // 
            // InsertDe
            // 
            this.InsertDe.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertDe.ForeColor = System.Drawing.Color.Black;
            this.InsertDe.Location = new System.Drawing.Point(227, 100);
            this.InsertDe.Name = "InsertDe";
            this.InsertDe.Size = new System.Drawing.Size(148, 54);
            this.InsertDe.TabIndex = 4;
            this.InsertDe.Text = "Insert";
            this.InsertDe.UseVisualStyleBackColor = false;
            this.InsertDe.Click += new System.EventHandler(this.button3_Click);
            // 
            // InsertDesriptButton
            // 
            this.InsertDesriptButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertDesriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertDesriptButton.ForeColor = System.Drawing.Color.Black;
            this.InsertDesriptButton.Location = new System.Drawing.Point(227, 100);
            this.InsertDesriptButton.Name = "InsertDesriptButton";
            this.InsertDesriptButton.Size = new System.Drawing.Size(148, 54);
            this.InsertDesriptButton.TabIndex = 4;
            this.InsertDesriptButton.Text = "Insert";
            this.InsertDesriptButton.UseVisualStyleBackColor = false;
            this.InsertDesriptButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DecriptText
            // 
            this.DecriptText.Location = new System.Drawing.Point(164, 44);
            this.DecriptText.Name = "DecriptText";
            this.DecriptText.Size = new System.Drawing.Size(299, 26);
            this.DecriptText.TabIndex = 0;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // bowlingStormAccessoriesDataSetBindingSource
            // 
            this.bowlingStormAccessoriesDataSetBindingSource.DataSource = this.bowlingStormAccessoriesDataSet;
            this.bowlingStormAccessoriesDataSetBindingSource.Position = 0;
            // 
            // ordersDetailsTableAdapter
            // 
            this.ordersDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bowlingStormAccessoriesDataSetBindingSource1
            // 
            this.bowlingStormAccessoriesDataSetBindingSource1.DataSource = this.bowlingStormAccessoriesDataSet;
            this.bowlingStormAccessoriesDataSetBindingSource1.Position = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.BackgroundImage = global::Shopbowl.Properties.Resources.Товар;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.peopleFoundListbox);
            this.tabPage1.Controls.Add(this.DataInSystemLable);
            this.tabPage1.Controls.Add(this.DataInSystemData);
            this.tabPage1.Controls.Add(this.InsertRecordButton);
            this.tabPage1.Controls.Add(this.PhonenumberInsLable);
            this.tabPage1.Controls.Add(this.PhoneNumberInsText);
            this.tabPage1.Controls.Add(this.CityNameInsLable);
            this.tabPage1.Controls.Add(this.CityNameInsText);
            this.tabPage1.Controls.Add(this.AddressNameInsLable);
            this.tabPage1.Controls.Add(this.AddressNameInsText);
            this.tabPage1.Controls.Add(this.ThreeNameInsLable);
            this.tabPage1.Controls.Add(this.ThreeNameInsText);
            this.tabPage1.Controls.Add(this.LastNameInsLable);
            this.tabPage1.Controls.Add(this.LastNameInsText);
            this.tabPage1.Controls.Add(this.FirstNameInsLable);
            this.tabPage1.Controls.Add(this.FirstNameInsText);
            this.tabPage1.Controls.Add(this.searchButton);
            this.tabPage1.Controls.Add(this.LastNameLable);
            this.tabPage1.Controls.Add(this.LastNameText);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1289, 667);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клієнти";
            // 
            // peopleFoundListbox
            // 
            this.peopleFoundListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.peopleFoundListbox.FormattingEnabled = true;
            this.peopleFoundListbox.HorizontalScrollbar = true;
            this.peopleFoundListbox.ItemHeight = 15;
            this.peopleFoundListbox.Location = new System.Drawing.Point(578, 156);
            this.peopleFoundListbox.Name = "peopleFoundListbox";
            this.peopleFoundListbox.Size = new System.Drawing.Size(659, 274);
            this.peopleFoundListbox.TabIndex = 36;
            // 
            // DataInSystemLable
            // 
            this.DataInSystemLable.AutoSize = true;
            this.DataInSystemLable.BackColor = System.Drawing.SystemColors.Control;
            this.DataInSystemLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataInSystemLable.Location = new System.Drawing.Point(1, 421);
            this.DataInSystemLable.Name = "DataInSystemLable";
            this.DataInSystemLable.Size = new System.Drawing.Size(237, 25);
            this.DataInSystemLable.TabIndex = 35;
            this.DataInSystemLable.Text = "Дата реєстрації клієнта";
            // 
            // DataInSystemData
            // 
            this.DataInSystemData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataInSystemData.Location = new System.Drawing.Point(174, 418);
            this.DataInSystemData.Name = "DataInSystemData";
            this.DataInSystemData.Size = new System.Drawing.Size(297, 30);
            this.DataInSystemData.TabIndex = 34;
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertRecordButton.Location = new System.Drawing.Point(219, 482);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(151, 59);
            this.InsertRecordButton.TabIndex = 33;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = false;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click_1);
            // 
            // PhonenumberInsLable
            // 
            this.PhonenumberInsLable.AutoSize = true;
            this.PhonenumberInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.PhonenumberInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhonenumberInsLable.Location = new System.Drawing.Point(1, 368);
            this.PhonenumberInsLable.Name = "PhonenumberInsLable";
            this.PhonenumberInsLable.Size = new System.Drawing.Size(182, 25);
            this.PhonenumberInsLable.TabIndex = 32;
            this.PhonenumberInsLable.Text = "Номер телефону:";
            // 
            // PhoneNumberInsText
            // 
            this.PhoneNumberInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberInsText.Location = new System.Drawing.Point(174, 365);
            this.PhoneNumberInsText.Name = "PhoneNumberInsText";
            this.PhoneNumberInsText.Size = new System.Drawing.Size(297, 30);
            this.PhoneNumberInsText.TabIndex = 31;
            // 
            // CityNameInsLable
            // 
            this.CityNameInsLable.AutoSize = true;
            this.CityNameInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.CityNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityNameInsLable.Location = new System.Drawing.Point(7, 312);
            this.CityNameInsLable.Name = "CityNameInsLable";
            this.CityNameInsLable.Size = new System.Drawing.Size(71, 25);
            this.CityNameInsLable.TabIndex = 30;
            this.CityNameInsLable.Text = "Місто:";
            // 
            // CityNameInsText
            // 
            this.CityNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityNameInsText.Location = new System.Drawing.Point(174, 312);
            this.CityNameInsText.Name = "CityNameInsText";
            this.CityNameInsText.Size = new System.Drawing.Size(297, 30);
            this.CityNameInsText.TabIndex = 29;
            // 
            // AddressNameInsLable
            // 
            this.AddressNameInsLable.AutoSize = true;
            this.AddressNameInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.AddressNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressNameInsLable.Location = new System.Drawing.Point(7, 250);
            this.AddressNameInsLable.Name = "AddressNameInsLable";
            this.AddressNameInsLable.Size = new System.Drawing.Size(85, 25);
            this.AddressNameInsLable.TabIndex = 28;
            this.AddressNameInsLable.Text = "Адреса:";
            // 
            // AddressNameInsText
            // 
            this.AddressNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressNameInsText.Location = new System.Drawing.Point(174, 247);
            this.AddressNameInsText.Name = "AddressNameInsText";
            this.AddressNameInsText.Size = new System.Drawing.Size(297, 30);
            this.AddressNameInsText.TabIndex = 27;
            // 
            // ThreeNameInsLable
            // 
            this.ThreeNameInsLable.AutoSize = true;
            this.ThreeNameInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.ThreeNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeNameInsLable.Location = new System.Drawing.Point(7, 196);
            this.ThreeNameInsLable.Name = "ThreeNameInsLable";
            this.ThreeNameInsLable.Size = new System.Drawing.Size(128, 25);
            this.ThreeNameInsLable.TabIndex = 26;
            this.ThreeNameInsLable.Text = "По-батькові:";
            // 
            // ThreeNameInsText
            // 
            this.ThreeNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeNameInsText.Location = new System.Drawing.Point(174, 193);
            this.ThreeNameInsText.Name = "ThreeNameInsText";
            this.ThreeNameInsText.Size = new System.Drawing.Size(297, 30);
            this.ThreeNameInsText.TabIndex = 25;
            // 
            // LastNameInsLable
            // 
            this.LastNameInsLable.AutoSize = true;
            this.LastNameInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.LastNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameInsLable.Location = new System.Drawing.Point(7, 142);
            this.LastNameInsLable.Name = "LastNameInsLable";
            this.LastNameInsLable.Size = new System.Drawing.Size(107, 25);
            this.LastNameInsLable.TabIndex = 24;
            this.LastNameInsLable.Text = "Прізвище:";
            // 
            // LastNameInsText
            // 
            this.LastNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameInsText.Location = new System.Drawing.Point(174, 139);
            this.LastNameInsText.Name = "LastNameInsText";
            this.LastNameInsText.Size = new System.Drawing.Size(297, 30);
            this.LastNameInsText.TabIndex = 23;
            // 
            // FirstNameInsLable
            // 
            this.FirstNameInsLable.AutoSize = true;
            this.FirstNameInsLable.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.FirstNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameInsLable.Location = new System.Drawing.Point(7, 77);
            this.FirstNameInsLable.Name = "FirstNameInsLable";
            this.FirstNameInsLable.Size = new System.Drawing.Size(55, 25);
            this.FirstNameInsLable.TabIndex = 22;
            this.FirstNameInsLable.Text = "Ім\'я:";
            // 
            // FirstNameInsText
            // 
            this.FirstNameInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameInsText.Location = new System.Drawing.Point(174, 77);
            this.FirstNameInsText.Name = "FirstNameInsText";
            this.FirstNameInsText.Size = new System.Drawing.Size(297, 30);
            this.FirstNameInsText.TabIndex = 21;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchButton.Location = new System.Drawing.Point(821, 482);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(166, 59);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // LastNameLable
            // 
            this.LastNameLable.AutoSize = true;
            this.LastNameLable.BackColor = System.Drawing.SystemColors.Control;
            this.LastNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLable.Location = new System.Drawing.Point(573, 115);
            this.LastNameLable.Name = "LastNameLable";
            this.LastNameLable.Size = new System.Drawing.Size(361, 29);
            this.LastNameLable.TabIndex = 19;
            this.LastNameLable.Text = "Введіть прізвище для пошуку:";
            // 
            // LastNameText
            // 
            this.LastNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameText.Location = new System.Drawing.Point(868, 115);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(369, 30);
            this.LastNameText.TabIndex = 18;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Shopbowl.Properties.Resources.Товар;
            this.tabPage2.Controls.Add(this.DeleteEmployeesButton);
            this.tabPage2.Controls.Add(this.DeleteIdText);
            this.tabPage2.Controls.Add(this.DeleteId);
            this.tabPage2.Controls.Add(this.SerchButtonE);
            this.tabPage2.Controls.Add(this.LastNameTextE);
            this.tabPage2.Controls.Add(this.LastNameLableE);
            this.tabPage2.Controls.Add(this.EmploeesFoundListBox);
            this.tabPage2.Controls.Add(this.InsertEmploees);
            this.tabPage2.Controls.Add(this.PriorSalaryInt);
            this.tabPage2.Controls.Add(this.SalaryInt);
            this.tabPage2.Controls.Add(this.PostText);
            this.tabPage2.Controls.Add(this.ThreeNameText);
            this.tabPage2.Controls.Add(this.TwoNameText);
            this.tabPage2.Controls.Add(this.FirstNameText);
            this.tabPage2.Controls.Add(this.PriorSalaryLable);
            this.tabPage2.Controls.Add(this.SalaryLable);
            this.tabPage2.Controls.Add(this.PostNameLable);
            this.tabPage2.Controls.Add(this.ThreeNameLable);
            this.tabPage2.Controls.Add(this.LasttNameLable);
            this.tabPage2.Controls.Add(this.FirstNameLable);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1289, 667);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Працівники";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DeleteEmployeesButton
            // 
            this.DeleteEmployeesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteEmployeesButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteEmployeesButton.Location = new System.Drawing.Point(1114, 78);
            this.DeleteEmployeesButton.Name = "DeleteEmployeesButton";
            this.DeleteEmployeesButton.Size = new System.Drawing.Size(125, 39);
            this.DeleteEmployeesButton.TabIndex = 19;
            this.DeleteEmployeesButton.Text = "Delete";
            this.DeleteEmployeesButton.UseVisualStyleBackColor = false;
            this.DeleteEmployeesButton.Click += new System.EventHandler(this.DeleteEmployeesButton_Click);
            // 
            // DeleteIdText
            // 
            this.DeleteIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteIdText.Location = new System.Drawing.Point(864, 84);
            this.DeleteIdText.Name = "DeleteIdText";
            this.DeleteIdText.Size = new System.Drawing.Size(244, 30);
            this.DeleteIdText.TabIndex = 18;
            // 
            // DeleteId
            // 
            this.DeleteId.AutoSize = true;
            this.DeleteId.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteId.Location = new System.Drawing.Point(579, 88);
            this.DeleteId.Name = "DeleteId";
            this.DeleteId.Size = new System.Drawing.Size(356, 25);
            this.DeleteId.TabIndex = 17;
            this.DeleteId.Text = "Введіть ID працівника для видалення";
            // 
            // SerchButtonE
            // 
            this.SerchButtonE.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SerchButtonE.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SerchButtonE.Location = new System.Drawing.Point(822, 463);
            this.SerchButtonE.Name = "SerchButtonE";
            this.SerchButtonE.Size = new System.Drawing.Size(161, 60);
            this.SerchButtonE.TabIndex = 16;
            this.SerchButtonE.Text = "Serch";
            this.SerchButtonE.UseVisualStyleBackColor = false;
            this.SerchButtonE.Click += new System.EventHandler(this.SerchButtonE_Click);
            // 
            // LastNameTextE
            // 
            this.LastNameTextE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameTextE.Location = new System.Drawing.Point(864, 130);
            this.LastNameTextE.Name = "LastNameTextE";
            this.LastNameTextE.Size = new System.Drawing.Size(375, 30);
            this.LastNameTextE.TabIndex = 15;
            // 
            // LastNameLableE
            // 
            this.LastNameLableE.AutoSize = true;
            this.LastNameLableE.BackColor = System.Drawing.SystemColors.Control;
            this.LastNameLableE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLableE.Location = new System.Drawing.Point(579, 133);
            this.LastNameLableE.Name = "LastNameLableE";
            this.LastNameLableE.Size = new System.Drawing.Size(279, 25);
            this.LastNameLableE.TabIndex = 14;
            this.LastNameLableE.Text = "Введіть прізвище працівника";
            // 
            // EmploeesFoundListBox
            // 
            this.EmploeesFoundListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(204)));
            this.EmploeesFoundListBox.FormattingEnabled = true;
            this.EmploeesFoundListBox.ItemHeight = 15;
            this.EmploeesFoundListBox.Location = new System.Drawing.Point(584, 173);
            this.EmploeesFoundListBox.Name = "EmploeesFoundListBox";
            this.EmploeesFoundListBox.Size = new System.Drawing.Size(655, 229);
            this.EmploeesFoundListBox.TabIndex = 13;
            // 
            // InsertEmploees
            // 
            this.InsertEmploees.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertEmploees.Location = new System.Drawing.Point(231, 463);
            this.InsertEmploees.Name = "InsertEmploees";
            this.InsertEmploees.Size = new System.Drawing.Size(167, 60);
            this.InsertEmploees.TabIndex = 12;
            this.InsertEmploees.Text = "Insert";
            this.InsertEmploees.UseVisualStyleBackColor = false;
            this.InsertEmploees.Click += new System.EventHandler(this.InsertEmploees_Click);
            // 
            // PriorSalaryInt
            // 
            this.PriorSalaryInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorSalaryInt.Location = new System.Drawing.Point(162, 383);
            this.PriorSalaryInt.Name = "PriorSalaryInt";
            this.PriorSalaryInt.Size = new System.Drawing.Size(309, 30);
            this.PriorSalaryInt.TabIndex = 11;
            // 
            // SalaryInt
            // 
            this.SalaryInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryInt.Location = new System.Drawing.Point(162, 318);
            this.SalaryInt.Name = "SalaryInt";
            this.SalaryInt.Size = new System.Drawing.Size(309, 30);
            this.SalaryInt.TabIndex = 10;
            // 
            // PostText
            // 
            this.PostText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostText.Location = new System.Drawing.Point(162, 262);
            this.PostText.Name = "PostText";
            this.PostText.Size = new System.Drawing.Size(309, 30);
            this.PostText.TabIndex = 9;
            // 
            // ThreeNameText
            // 
            this.ThreeNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeNameText.Location = new System.Drawing.Point(162, 201);
            this.ThreeNameText.Name = "ThreeNameText";
            this.ThreeNameText.Size = new System.Drawing.Size(309, 30);
            this.ThreeNameText.TabIndex = 8;
            // 
            // TwoNameText
            // 
            this.TwoNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TwoNameText.Location = new System.Drawing.Point(162, 142);
            this.TwoNameText.Name = "TwoNameText";
            this.TwoNameText.Size = new System.Drawing.Size(309, 30);
            this.TwoNameText.TabIndex = 7;
            // 
            // FirstNameText
            // 
            this.FirstNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameText.Location = new System.Drawing.Point(162, 87);
            this.FirstNameText.Name = "FirstNameText";
            this.FirstNameText.Size = new System.Drawing.Size(309, 30);
            this.FirstNameText.TabIndex = 6;
            // 
            // PriorSalaryLable
            // 
            this.PriorSalaryLable.AutoSize = true;
            this.PriorSalaryLable.BackColor = System.Drawing.SystemColors.Control;
            this.PriorSalaryLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorSalaryLable.Location = new System.Drawing.Point(11, 389);
            this.PriorSalaryLable.Name = "PriorSalaryLable";
            this.PriorSalaryLable.Size = new System.Drawing.Size(80, 25);
            this.PriorSalaryLable.TabIndex = 5;
            this.PriorSalaryLable.Text = "Премія";
            // 
            // SalaryLable
            // 
            this.SalaryLable.AutoSize = true;
            this.SalaryLable.BackColor = System.Drawing.SystemColors.Control;
            this.SalaryLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SalaryLable.Location = new System.Drawing.Point(11, 324);
            this.SalaryLable.Name = "SalaryLable";
            this.SalaryLable.Size = new System.Drawing.Size(101, 25);
            this.SalaryLable.TabIndex = 4;
            this.SalaryLable.Text = "Зарплата";
            // 
            // PostNameLable
            // 
            this.PostNameLable.AutoSize = true;
            this.PostNameLable.BackColor = System.Drawing.SystemColors.Control;
            this.PostNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostNameLable.Location = new System.Drawing.Point(11, 262);
            this.PostNameLable.Name = "PostNameLable";
            this.PostNameLable.Size = new System.Drawing.Size(79, 25);
            this.PostNameLable.TabIndex = 3;
            this.PostNameLable.Text = "Посада";
            // 
            // ThreeNameLable
            // 
            this.ThreeNameLable.AutoSize = true;
            this.ThreeNameLable.BackColor = System.Drawing.SystemColors.Control;
            this.ThreeNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThreeNameLable.Location = new System.Drawing.Point(11, 207);
            this.ThreeNameLable.Name = "ThreeNameLable";
            this.ThreeNameLable.Size = new System.Drawing.Size(122, 25);
            this.ThreeNameLable.TabIndex = 2;
            this.ThreeNameLable.Text = "По-батькові";
            // 
            // LasttNameLable
            // 
            this.LasttNameLable.AutoSize = true;
            this.LasttNameLable.BackColor = System.Drawing.SystemColors.Control;
            this.LasttNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LasttNameLable.Location = new System.Drawing.Point(11, 142);
            this.LasttNameLable.Name = "LasttNameLable";
            this.LasttNameLable.Size = new System.Drawing.Size(106, 25);
            this.LasttNameLable.TabIndex = 1;
            this.LasttNameLable.Text = "Прізвище ";
            // 
            // FirstNameLable
            // 
            this.FirstNameLable.AutoSize = true;
            this.FirstNameLable.BackColor = System.Drawing.SystemColors.Control;
            this.FirstNameLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstNameLable.Location = new System.Drawing.Point(11, 87);
            this.FirstNameLable.Name = "FirstNameLable";
            this.FirstNameLable.Size = new System.Drawing.Size(49, 25);
            this.FirstNameLable.TabIndex = 0;
            this.FirstNameLable.Text = "Ім\'я";
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Shopbowl.Properties.Resources.Товар;
            this.tabPage3.Controls.Add(this.DescriptionShowButton);
            this.tabPage3.Controls.Add(this.TypeProsuctShowButton);
            this.tabPage3.Controls.Add(this.MakerShowButton);
            this.tabPage3.Controls.Add(this.ShowAllListBox);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.pictureBox6);
            this.tabPage3.Controls.Add(this.pictureBox5);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.pictureBox3);
            this.tabPage3.Controls.Add(this.pictureBox2);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1289, 667);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Виробники Тип продукту Опис продукту";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DescriptionShowButton
            // 
            this.DescriptionShowButton.BackColor = System.Drawing.Color.LightCoral;
            this.DescriptionShowButton.Location = new System.Drawing.Point(530, 514);
            this.DescriptionShowButton.Name = "DescriptionShowButton";
            this.DescriptionShowButton.Size = new System.Drawing.Size(122, 35);
            this.DescriptionShowButton.TabIndex = 13;
            this.DescriptionShowButton.Text = "Show All";
            this.DescriptionShowButton.UseVisualStyleBackColor = false;
            this.DescriptionShowButton.Click += new System.EventHandler(this.DescriptionShowButton_Click);
            // 
            // TypeProsuctShowButton
            // 
            this.TypeProsuctShowButton.BackColor = System.Drawing.Color.LightCoral;
            this.TypeProsuctShowButton.Location = new System.Drawing.Point(530, 343);
            this.TypeProsuctShowButton.Name = "TypeProsuctShowButton";
            this.TypeProsuctShowButton.Size = new System.Drawing.Size(122, 35);
            this.TypeProsuctShowButton.TabIndex = 12;
            this.TypeProsuctShowButton.Text = "Show All";
            this.TypeProsuctShowButton.UseVisualStyleBackColor = false;
            this.TypeProsuctShowButton.Click += new System.EventHandler(this.TypeProsuctShowButton_Click);
            // 
            // MakerShowButton
            // 
            this.MakerShowButton.BackColor = System.Drawing.Color.LightCoral;
            this.MakerShowButton.Location = new System.Drawing.Point(530, 183);
            this.MakerShowButton.Name = "MakerShowButton";
            this.MakerShowButton.Size = new System.Drawing.Size(122, 35);
            this.MakerShowButton.TabIndex = 11;
            this.MakerShowButton.Text = "Show All";
            this.MakerShowButton.UseVisualStyleBackColor = false;
            this.MakerShowButton.Click += new System.EventHandler(this.MakerShowButton_Click);
            // 
            // ShowAllListBox
            // 
            this.ShowAllListBox.FormattingEnabled = true;
            this.ShowAllListBox.ItemHeight = 26;
            this.ShowAllListBox.Location = new System.Drawing.Point(658, 101);
            this.ShowAllListBox.Name = "ShowAllListBox";
            this.ShowAllListBox.Size = new System.Drawing.Size(597, 524);
            this.ShowAllListBox.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightGray;
            this.groupBox3.Controls.Add(this.DescriptButton);
            this.groupBox3.Controls.Add(this.DescriptText);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(8, 465);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 160);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Опис продукта";
            // 
            // DescriptButton
            // 
            this.DescriptButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.DescriptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptButton.ForeColor = System.Drawing.Color.Black;
            this.DescriptButton.Location = new System.Drawing.Point(227, 100);
            this.DescriptButton.Name = "DescriptButton";
            this.DescriptButton.Size = new System.Drawing.Size(148, 54);
            this.DescriptButton.TabIndex = 4;
            this.DescriptButton.Text = "Insert";
            this.DescriptButton.UseVisualStyleBackColor = false;
            this.DescriptButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DescriptText
            // 
            this.DescriptText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptText.Location = new System.Drawing.Point(164, 44);
            this.DescriptText.Name = "DescriptText";
            this.DescriptText.Size = new System.Drawing.Size(299, 35);
            this.DescriptText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Опис продукції";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightGray;
            this.groupBox2.Controls.Add(this.InsertTypePtoductButton);
            this.groupBox2.Controls.Add(this.TypeProductText);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 299);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 160);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип продукції";
            // 
            // InsertTypePtoductButton
            // 
            this.InsertTypePtoductButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertTypePtoductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertTypePtoductButton.ForeColor = System.Drawing.Color.Black;
            this.InsertTypePtoductButton.Location = new System.Drawing.Point(227, 100);
            this.InsertTypePtoductButton.Name = "InsertTypePtoductButton";
            this.InsertTypePtoductButton.Size = new System.Drawing.Size(148, 54);
            this.InsertTypePtoductButton.TabIndex = 4;
            this.InsertTypePtoductButton.Text = "Insert";
            this.InsertTypePtoductButton.UseVisualStyleBackColor = false;
            this.InsertTypePtoductButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // TypeProductText
            // 
            this.TypeProductText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeProductText.Location = new System.Drawing.Point(164, 44);
            this.TypeProductText.Name = "TypeProductText";
            this.TypeProductText.Size = new System.Drawing.Size(299, 35);
            this.TypeProductText.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Тип продукції";
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Shopbowl.Properties.Resources.Radical;
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(1061, 16);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(181, 64);
            this.pictureBox6.TabIndex = 8;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Shopbowl.Properties.Resources.Lusd;
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(860, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(127, 65);
            this.pictureBox5.TabIndex = 7;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Shopbowl.Properties.Resources.Storm_logos;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(42, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(132, 65);
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Shopbowl.Properties.Resources.Track_logo;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(441, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(126, 65);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Shopbowl.Properties.Resources.LogosE;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(658, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 64);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Shopbowl.Properties.Resources.Logo_motiv;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(264, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 65);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGray;
            this.groupBox1.Controls.Add(this.InsertMakerButton);
            this.groupBox1.Controls.Add(this.CompanyNameText);
            this.groupBox1.Controls.Add(this.CountryNameInsLable);
            this.groupBox1.Controls.Add(this.CompanyNameInsLable);
            this.groupBox1.Controls.Add(this.CountryNameText);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(8, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(507, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Виробник";
            // 
            // InsertMakerButton
            // 
            this.InsertMakerButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertMakerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsertMakerButton.ForeColor = System.Drawing.Color.Black;
            this.InsertMakerButton.Location = new System.Drawing.Point(227, 135);
            this.InsertMakerButton.Name = "InsertMakerButton";
            this.InsertMakerButton.Size = new System.Drawing.Size(148, 54);
            this.InsertMakerButton.TabIndex = 4;
            this.InsertMakerButton.Text = "Insert";
            this.InsertMakerButton.UseVisualStyleBackColor = false;
            this.InsertMakerButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CompanyNameText
            // 
            this.CompanyNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameText.Location = new System.Drawing.Point(164, 34);
            this.CompanyNameText.Name = "CompanyNameText";
            this.CompanyNameText.Size = new System.Drawing.Size(299, 35);
            this.CompanyNameText.TabIndex = 0;
            // 
            // CountryNameInsLable
            // 
            this.CountryNameInsLable.AutoSize = true;
            this.CountryNameInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.CountryNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryNameInsLable.ForeColor = System.Drawing.Color.Black;
            this.CountryNameInsLable.Location = new System.Drawing.Point(6, 90);
            this.CountryNameInsLable.Name = "CountryNameInsLable";
            this.CountryNameInsLable.Size = new System.Drawing.Size(80, 26);
            this.CountryNameInsLable.TabIndex = 3;
            this.CountryNameInsLable.Text = "Країна";
            // 
            // CompanyNameInsLable
            // 
            this.CompanyNameInsLable.AutoSize = true;
            this.CompanyNameInsLable.BackColor = System.Drawing.SystemColors.Control;
            this.CompanyNameInsLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyNameInsLable.ForeColor = System.Drawing.Color.Black;
            this.CompanyNameInsLable.Location = new System.Drawing.Point(6, 39);
            this.CompanyNameInsLable.Name = "CompanyNameInsLable";
            this.CompanyNameInsLable.Size = new System.Drawing.Size(166, 26);
            this.CompanyNameInsLable.TabIndex = 1;
            this.CompanyNameInsLable.Text = "Назва компанії";
            // 
            // CountryNameText
            // 
            this.CountryNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountryNameText.Location = new System.Drawing.Point(164, 85);
            this.CountryNameText.Name = "CountryNameText";
            this.CountryNameText.Size = new System.Drawing.Size(299, 35);
            this.CountryNameText.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::Shopbowl.Properties.Resources.БД;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Controls.Add(this.ShowInfoProductsList);
            this.tabPage4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1289, 667);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Товари";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Controls.Add(this.FoundGoodstext);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(190, 403);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(913, 77);
            this.groupBox5.TabIndex = 17;
            this.groupBox5.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCoral;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(753, 20);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 37);
            this.button5.TabIndex = 15;
            this.button5.Text = "Show Info";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FoundGoodstext
            // 
            this.FoundGoodstext.Location = new System.Drawing.Point(374, 26);
            this.FoundGoodstext.Name = "FoundGoodstext";
            this.FoundGoodstext.Size = new System.Drawing.Size(373, 35);
            this.FoundGoodstext.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(22, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(508, 26);
            this.label9.TabIndex = 16;
            this.label9.Text = "Введіть назву товару щоб побачити інформацію";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.IdNumberUpdateText);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.DescriptInsText);
            this.groupBox4.Controls.Add(this.NameGoodsInsText);
            this.groupBox4.Controls.Add(this.PriceDolarInsText);
            this.groupBox4.Controls.Add(this.TypeGoodsInsText);
            this.groupBox4.Controls.Add(this.CountGoodsInsText);
            this.groupBox4.Controls.Add(this.MakerIansText);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(322, 31);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(644, 363);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Товари";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(70, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 26);
            this.label14.TabIndex = 22;
            this.label14.Text = "(ID) - товару ";
            // 
            // IdNumberUpdateText
            // 
            this.IdNumberUpdateText.Location = new System.Drawing.Point(381, 41);
            this.IdNumberUpdateText.Name = "IdNumberUpdateText";
            this.IdNumberUpdateText.Size = new System.Drawing.Size(98, 35);
            this.IdNumberUpdateText.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(70, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 26);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ціна в доларах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(70, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 26);
            this.label3.TabIndex = 15;
            this.label3.Text = "Назва товару";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(70, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Кількість товару";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(70, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "(ID) - типу товару";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(70, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 26);
            this.label5.TabIndex = 17;
            this.label5.Text = "(ID) - опис товару ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(70, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "(ID) - Виробника";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aquamarine;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(112, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 44);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(363, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 44);
            this.button4.TabIndex = 13;
            this.button4.Text = "Insert";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // DescriptInsText
            // 
            this.DescriptInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptInsText.Location = new System.Drawing.Point(312, 158);
            this.DescriptInsText.Name = "DescriptInsText";
            this.DescriptInsText.Size = new System.Drawing.Size(239, 35);
            this.DescriptInsText.TabIndex = 4;
            // 
            // NameGoodsInsText
            // 
            this.NameGoodsInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGoodsInsText.Location = new System.Drawing.Point(312, 82);
            this.NameGoodsInsText.Name = "NameGoodsInsText";
            this.NameGoodsInsText.Size = new System.Drawing.Size(239, 35);
            this.NameGoodsInsText.TabIndex = 0;
            // 
            // PriceDolarInsText
            // 
            this.PriceDolarInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceDolarInsText.Location = new System.Drawing.Point(312, 272);
            this.PriceDolarInsText.Name = "PriceDolarInsText";
            this.PriceDolarInsText.Size = new System.Drawing.Size(239, 35);
            this.PriceDolarInsText.TabIndex = 10;
            // 
            // TypeGoodsInsText
            // 
            this.TypeGoodsInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeGoodsInsText.Location = new System.Drawing.Point(312, 120);
            this.TypeGoodsInsText.Name = "TypeGoodsInsText";
            this.TypeGoodsInsText.Size = new System.Drawing.Size(239, 35);
            this.TypeGoodsInsText.TabIndex = 2;
            // 
            // CountGoodsInsText
            // 
            this.CountGoodsInsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountGoodsInsText.Location = new System.Drawing.Point(312, 234);
            this.CountGoodsInsText.Name = "CountGoodsInsText";
            this.CountGoodsInsText.Size = new System.Drawing.Size(239, 35);
            this.CountGoodsInsText.TabIndex = 8;
            // 
            // MakerIansText
            // 
            this.MakerIansText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakerIansText.Location = new System.Drawing.Point(312, 196);
            this.MakerIansText.Name = "MakerIansText";
            this.MakerIansText.Size = new System.Drawing.Size(239, 35);
            this.MakerIansText.TabIndex = 6;
            // 
            // ShowInfoProductsList
            // 
            this.ShowInfoProductsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowInfoProductsList.FormattingEnabled = true;
            this.ShowInfoProductsList.ItemHeight = 32;
            this.ShowInfoProductsList.Location = new System.Drawing.Point(117, 486);
            this.ShowInfoProductsList.Name = "ShowInfoProductsList";
            this.ShowInfoProductsList.Size = new System.Drawing.Size(1048, 132);
            this.ShowInfoProductsList.TabIndex = 12;
            // 
            // tabPage5
            // 
            this.tabPage5.BackgroundImage = global::Shopbowl.Properties.Resources.БД;
            this.tabPage5.Controls.Add(this.button8);
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Controls.Add(this.dataGridView1);
            this.tabPage5.Controls.Add(this.groupBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 35);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1289, 667);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Замовлення";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.SteelBlue;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(799, 557);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(306, 44);
            this.button8.TabIndex = 20;
            this.button8.Text = "Показати чек";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(579, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(683, 218);
            this.dataGridView2.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(579, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(683, 275);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.LightSlateGray;
            this.groupBox6.Controls.Add(this.button9);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Controls.Add(this.button6);
            this.groupBox6.Controls.Add(this.IdOrderText);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.CountGoodsText);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.IDGoodsText);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.IDTableOrdersText);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.SplitDateText);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.OrderDateText);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.IdEmploeeText);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.IdCustomerText);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.Color.White;
            this.groupBox6.Location = new System.Drawing.Point(26, 42);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(526, 559);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Замовлення";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGray;
            this.button9.BackgroundImage = global::Shopbowl.Properties.Resources.cloud_sync_256;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(384, 461);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(99, 85);
            this.button9.TabIndex = 20;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightCoral;
            this.button7.Location = new System.Drawing.Point(105, 273);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(306, 44);
            this.button7.TabIndex = 19;
            this.button7.Text = "Додати";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(31, 480);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(306, 46);
            this.button6.TabIndex = 18;
            this.button6.Text = "Додати ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // IdOrderText
            // 
            this.IdOrderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdOrderText.Location = new System.Drawing.Point(265, 46);
            this.IdOrderText.Name = "IdOrderText";
            this.IdOrderText.Size = new System.Drawing.Size(240, 35);
            this.IdOrderText.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(26, 49);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(281, 29);
            this.label18.TabIndex = 16;
            this.label18.Text = "ID - номер замовлення";
            // 
            // CountGoodsText
            // 
            this.CountGoodsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountGoodsText.Location = new System.Drawing.Point(264, 422);
            this.CountGoodsText.Name = "CountGoodsText";
            this.CountGoodsText.Size = new System.Drawing.Size(241, 35);
            this.CountGoodsText.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(26, 422);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(209, 29);
            this.label15.TabIndex = 12;
            this.label15.Text = "Кількість товарів";
            // 
            // IDGoodsText
            // 
            this.IDGoodsText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDGoodsText.Location = new System.Drawing.Point(264, 381);
            this.IDGoodsText.Name = "IDGoodsText";
            this.IDGoodsText.Size = new System.Drawing.Size(241, 35);
            this.IDGoodsText.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(26, 384);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(137, 29);
            this.label16.TabIndex = 10;
            this.label16.Text = "ID - Товару";
            // 
            // IDTableOrdersText
            // 
            this.IDTableOrdersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTableOrdersText.Location = new System.Drawing.Point(264, 340);
            this.IDTableOrdersText.Name = "IDTableOrdersText";
            this.IDTableOrdersText.Size = new System.Drawing.Size(241, 35);
            this.IDTableOrdersText.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(26, 346);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(202, 29);
            this.label17.TabIndex = 8;
            this.label17.Text = "ID - Замовлення";
            // 
            // SplitDateText
            // 
            this.SplitDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SplitDateText.Location = new System.Drawing.Point(266, 210);
            this.SplitDateText.Name = "SplitDateText";
            this.SplitDateText.Size = new System.Drawing.Size(240, 35);
            this.SplitDateText.TabIndex = 7;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(26, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 29);
            this.label13.TabIndex = 6;
            this.label13.Text = "Дата сплати";
            // 
            // OrderDateText
            // 
            this.OrderDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDateText.Location = new System.Drawing.Point(266, 169);
            this.OrderDateText.Name = "OrderDateText";
            this.OrderDateText.Size = new System.Drawing.Size(240, 35);
            this.OrderDateText.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(26, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 29);
            this.label12.TabIndex = 4;
            this.label12.Text = "Дата замовлення";
            // 
            // IdEmploeeText
            // 
            this.IdEmploeeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdEmploeeText.Location = new System.Drawing.Point(266, 128);
            this.IdEmploeeText.Name = "IdEmploeeText";
            this.IdEmploeeText.Size = new System.Drawing.Size(240, 35);
            this.IdEmploeeText.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(26, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 29);
            this.label11.TabIndex = 2;
            this.label11.Text = "(ID) - працівника";
            // 
            // IdCustomerText
            // 
            this.IdCustomerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdCustomerText.Location = new System.Drawing.Point(266, 87);
            this.IdCustomerText.Name = "IdCustomerText";
            this.IdCustomerText.Size = new System.Drawing.Size(240, 35);
            this.IdCustomerText.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(26, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "(ID) - клієнта";
            // 
            // Dashboard
            // 
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1297, 706);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingStormAccessoriesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingStormAccessoriesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bowlingStormAccessoriesDataSetBindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }




        List<Customers> customers = new List<Customers>();
        List<Emploees> emploees = new List<Emploees>();
        List<Maker> makers = new List<Maker>();
        List<TypeProduct> typeproducts = new List<TypeProduct>();
        List<Descript> descripts = new List<Descript>();
        List<Goods> goods = new List<Goods>();
        List<Order> orders = new List<Order>();
        List<OrdersTwo> ordertwo = new List<OrdersTwo>();

        public Dashboard()
        {
            InitializeComponent();
            UpdateBinding();
            UpdateEmploees();
            UpdateMaker();
            UpdateTypeProduct();
            UpdateDescript();
            UpdateGoods();
        }
        private void UpdateGoods()
        {
            ShowInfoProductsList.DataSource = goods;
            ShowInfoProductsList.DisplayMember = "FullInfoGoods";
        }

        private void UpdateBinding()
        {

            peopleFoundListbox.DataSource = customers;
            peopleFoundListbox.DisplayMember = "FullInfo";
        }

        public void UpdateEmploees()
        {

            EmploeesFoundListBox.DataSource = emploees;
            EmploeesFoundListBox.DisplayMember = "FullInfoEmploees";
        }
        public void UpdateMaker()
        {

            ShowAllListBox.DataSource = makers;
            ShowAllListBox.DisplayMember = "FullInfoMaker";
        }
        public void UpdateTypeProduct()
        {

            ShowAllListBox.DataSource = typeproducts;
            ShowAllListBox.DisplayMember = "FullInfoTypeProduct";
        }
        public void UpdateDescript()
        {

            ShowAllListBox.DataSource = descripts;
            ShowAllListBox.DisplayMember = "FullInfoDescript";
        }






        private void searchButton_Click_1(object sender, EventArgs e)
        { 
            DataAccess db = new DataAccess();
            customers = db.GetCustomers  (LastNameText.Text);

            peopleFoundListbox.DataSource = customers;
            peopleFoundListbox.DisplayMember = "FullInfo";

            UpdateBinding();
        }
        private void InsertRecordButton_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertCustomers(FirstNameInsText.Text, LastNameInsText.Text, ThreeNameInsText.Text,
                AddressNameInsText.Text, CityNameInsText.Text, PhoneNumberInsText.Text, DataInSystemData.Text);

            FirstNameInsText.Text = "";
            LastNameInsText.Text = "";
            ThreeNameInsText.Text = "";
            AddressNameInsText.Text = "";
            CityNameInsText.Text = "";
            PhoneNumberInsText.Text = "";
            DataInSystemData.Text = "";
        }

        private void SerchButtonE_Click(object sender, EventArgs e)
        {
            DataAccess ddb = new DataAccess();
            emploees = ddb.GetEmploees (LastNameTextE.Text);
            UpdateEmploees();
            if(string.IsNullOrEmpty(EmploeesFoundListBox.Text) || string.IsNullOrWhiteSpace(EmploeesFoundListBox.Text))
            {
                MessageBox.Show("Такого працівника не знайдено!");
            }
        }

        private void InsertEmploees_Click(object sender, EventArgs e)
        {
           
            DataAccess db = new DataAccess();
            db.InsertEmploees(FirstNameText.Text, TwoNameText.Text, ThreeNameText.Text,
            PostText.Text, SalaryInt.Text, PriorSalaryInt.Text);
            FirstNameText.Text = "";
            TwoNameText.Text = "";
            ThreeNameText.Text = "";
            PostText.Text = "";
            SalaryInt.Text = "";
            PriorSalaryInt.Text = "";
        }
        private void DeleteEmployeesButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.DeleteEmploees(DeleteIdText.Text);
            DeleteIdText.Text = "";
        }

        private void MakerShowButton_Click(object sender, EventArgs e)
        {
            DataAccess ddb = new DataAccess();
            makers = ddb.GetMaker();
            ShowAllListBox.DataSource = makers;
            ShowAllListBox.DisplayMember = "FullInfoMaker";

            UpdateMaker();
        }

        private void TypeProsuctShowButton_Click(object sender, EventArgs e)
        {
            DataAccess ddb = new DataAccess();
            typeproducts = ddb.GetTypeProduct();
            ShowAllListBox.DataSource = typeproducts;
            ShowAllListBox.DisplayMember = "FullInfoTypeProduct";

            UpdateTypeProduct();
        }

        private void DescriptionShowButton_Click(object sender, EventArgs e)
        {
            DataAccess ddb = new DataAccess();
            descripts = ddb.GetDescript();
            ShowAllListBox.DataSource = descripts;
            ShowAllListBox.DisplayMember = "FullInfoDescript";

            UpdateDescript();
        }

        private void button1_Click(object sender, EventArgs e)      /*MakerBUTTON*/
        {
            DataAccess db = new DataAccess();
            db.InsertMaker(CompanyNameText.Text, CountryNameText.Text);
            CompanyNameText.Text = "";
            CountryNameText.Text = "";
        }

       
        private void button2_Click(object sender, EventArgs e)      /*TypeProductBUTTON*/
        {
            DataAccess db = new DataAccess();
            db.InsertTypeProduct(TypeProductText.Text);
            TypeProductText.Text = "";
        }
        
        private void button3_Click(object sender, EventArgs e)     /*DescriptionBUTTON*/
        {
            DataAccess db = new DataAccess();
            db.InsertDescript(DescriptText.Text);
            DescriptText.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            goods = db.GetGoods(FoundGoodstext.Text);
            FoundGoodstext.Text = "";
            UpdateGoods();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.InsertGoods(NameGoodsInsText.Text, TypeGoodsInsText.Text, DescriptInsText.Text, MakerIansText.Text, CountGoodsInsText.Text, PriceDolarInsText.Text);
            NameGoodsInsText.Text = "";
            TypeGoodsInsText.Text = "";
            DescriptInsText.Text = "";
            MakerIansText.Text = "";
            CountGoodsInsText.Text = "";
            PriceDolarInsText.Text = "";
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.UpdateGoods(IdNumberUpdateText.Text, NameGoodsInsText.Text, TypeGoodsInsText.Text, DescriptInsText.Text, MakerIansText.Text, CountGoodsInsText.Text, PriceDolarInsText.Text);
            IdNumberUpdateText.Text = "";
            NameGoodsInsText.Text = "";
            TypeGoodsInsText.Text = "";
            DescriptInsText.Text = "";
            MakerIansText.Text = "";
            CountGoodsInsText.Text = "";
            PriceDolarInsText.Text = "";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.AddOrders1(IdOrderText.Text, IdCustomerText.Text, IdEmploeeText.Text, OrderDateText.Text, SplitDateText.Text);
            IdCustomerText.Text = "";
            IdCustomerText.Text = "";
            IdEmploeeText.Text = "";
            OrderDateText.Text = "";
            SplitDateText.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            db.AddOrders2(IDTableOrdersText.Text, IDGoodsText.Text, CountGoodsText.Text);
            IDTableOrdersText.Text = "";
            IDGoodsText.Text = "";
            CountGoodsText.Text = "";

        }
        string connectionString = "Data Source=DESKTOP-HGQAP5N;Initial Catalog=BowlingStormAccessories;Integrated Security=True";
        private void Dashboard_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("TOrdersShow", sqlConnection);
                SqlCommand command2 = new SqlCommand("DetOrders", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command2.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt.Load(command.ExecuteReader());
                dt2.Load(command2.ExecuteReader());
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                sqlConnection.Close();
            }
           
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("TOrdersShow", sqlConnection);
                SqlCommand command2 = new SqlCommand("DetOrders", sqlConnection);
                command.CommandType = CommandType.StoredProcedure;
                command2.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                dt.Load(command.ExecuteReader());
                dt2.Load(command2.ExecuteReader());
                dataGridView1.DataSource = dt;
                dataGridView2.DataSource = dt2;
                sqlConnection.Close();
            }
        }
    }
}
