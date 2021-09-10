
namespace WindowsFormsApp2
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
            this.clubListBox = new System.Windows.Forms.ListBox();
            this.swimmerListBox = new System.Windows.Forms.ListBox();
            this.swimmerNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.swimmerDOBTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.swimmerStreetTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.swimmerPhoneTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.swimmerIDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.swimmerPCodeTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.swimmerProvinceTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.swimmerCityTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.clubPCodeTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.clubProvinceTB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.clubCityTB = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.clubStreetTB = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.clubPhoneTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.clubNameTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.clubAddBtn = new System.Windows.Forms.Button();
            this.swimmerAddBtn = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.DisplayView = new System.Windows.Forms.ListView();
            this.DISPLAY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clubListBox
            // 
            this.clubListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubListBox.FormattingEnabled = true;
            this.clubListBox.ItemHeight = 29;
            this.clubListBox.Location = new System.Drawing.Point(610, 500);
            this.clubListBox.Name = "clubListBox";
            this.clubListBox.Size = new System.Drawing.Size(436, 497);
            this.clubListBox.TabIndex = 0;
            this.clubListBox.SelectedIndexChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // swimmerListBox
            // 
            this.swimmerListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerListBox.FormattingEnabled = true;
            this.swimmerListBox.ItemHeight = 29;
            this.swimmerListBox.Location = new System.Drawing.Point(1086, 500);
            this.swimmerListBox.Name = "swimmerListBox";
            this.swimmerListBox.Size = new System.Drawing.Size(418, 497);
            this.swimmerListBox.TabIndex = 1;
            this.swimmerListBox.SelectedIndexChanged += new System.EventHandler(this.swimmerListBox_SelectedIndexChanged);
            // 
            // swimmerNameTB
            // 
            this.swimmerNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerNameTB.Location = new System.Drawing.Point(208, 85);
            this.swimmerNameTB.Name = "swimmerNameTB";
            this.swimmerNameTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerNameTB.TabIndex = 2;
            this.swimmerNameTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "DOB:";
            // 
            // swimmerDOBTB
            // 
            this.swimmerDOBTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerDOBTB.Location = new System.Drawing.Point(208, 145);
            this.swimmerDOBTB.Name = "swimmerDOBTB";
            this.swimmerDOBTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerDOBTB.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Street:";
            // 
            // swimmerStreetTB
            // 
            this.swimmerStreetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerStreetTB.Location = new System.Drawing.Point(208, 262);
            this.swimmerStreetTB.Name = "swimmerStreetTB";
            this.swimmerStreetTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerStreetTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone:";
            // 
            // swimmerPhoneTB
            // 
            this.swimmerPhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerPhoneTB.Location = new System.Drawing.Point(208, 201);
            this.swimmerPhoneTB.Name = "swimmerPhoneTB";
            this.swimmerPhoneTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerPhoneTB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 499);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID(optional)";
            // 
            // swimmerIDTB
            // 
            this.swimmerIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerIDTB.Location = new System.Drawing.Point(208, 499);
            this.swimmerIDTB.Name = "swimmerIDTB";
            this.swimmerIDTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerIDTB.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(51, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Postal Code:";
            // 
            // swimmerPCodeTB
            // 
            this.swimmerPCodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerPCodeTB.Location = new System.Drawing.Point(208, 439);
            this.swimmerPCodeTB.Name = "swimmerPCodeTB";
            this.swimmerPCodeTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerPCodeTB.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(77, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Province:";
            // 
            // swimmerProvinceTB
            // 
            this.swimmerProvinceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerProvinceTB.Location = new System.Drawing.Point(208, 383);
            this.swimmerProvinceTB.Name = "swimmerProvinceTB";
            this.swimmerProvinceTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerProvinceTB.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(101, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "City:";
            // 
            // swimmerCityTB
            // 
            this.swimmerCityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerCityTB.Location = new System.Drawing.Point(208, 324);
            this.swimmerCityTB.Name = "swimmerCityTB";
            this.swimmerCityTB.Size = new System.Drawing.Size(264, 35);
            this.swimmerCityTB.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 996);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 29);
            this.label11.TabIndex = 29;
            this.label11.Text = "Postal Code:";
            // 
            // clubPCodeTB
            // 
            this.clubPCodeTB.AcceptsReturn = true;
            this.clubPCodeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubPCodeTB.Location = new System.Drawing.Point(208, 991);
            this.clubPCodeTB.Name = "clubPCodeTB";
            this.clubPCodeTB.Size = new System.Drawing.Size(264, 35);
            this.clubPCodeTB.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(72, 936);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 29);
            this.label12.TabIndex = 27;
            this.label12.Text = "Province:";
            // 
            // clubProvinceTB
            // 
            this.clubProvinceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubProvinceTB.Location = new System.Drawing.Point(208, 931);
            this.clubProvinceTB.Name = "clubProvinceTB";
            this.clubProvinceTB.Size = new System.Drawing.Size(264, 35);
            this.clubProvinceTB.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(101, 872);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 29);
            this.label13.TabIndex = 25;
            this.label13.Text = "City:";
            // 
            // clubCityTB
            // 
            this.clubCityTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubCityTB.Location = new System.Drawing.Point(208, 870);
            this.clubCityTB.Name = "clubCityTB";
            this.clubCityTB.Size = new System.Drawing.Size(264, 35);
            this.clubCityTB.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(101, 812);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 29);
            this.label14.TabIndex = 23;
            this.label14.Text = "Street:";
            // 
            // clubStreetTB
            // 
            this.clubStreetTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubStreetTB.Location = new System.Drawing.Point(208, 810);
            this.clubStreetTB.Name = "clubStreetTB";
            this.clubStreetTB.Size = new System.Drawing.Size(264, 35);
            this.clubStreetTB.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(82, 759);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 29);
            this.label15.TabIndex = 21;
            this.label15.Text = "Phone #:";
            // 
            // clubPhoneTB
            // 
            this.clubPhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubPhoneTB.Location = new System.Drawing.Point(208, 753);
            this.clubPhoneTB.Name = "clubPhoneTB";
            this.clubPhoneTB.Size = new System.Drawing.Size(264, 35);
            this.clubPhoneTB.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(101, 695);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 29);
            this.label16.TabIndex = 19;
            this.label16.Text = "Name:";
            // 
            // clubNameTB
            // 
            this.clubNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubNameTB.Location = new System.Drawing.Point(208, 693);
            this.clubNameTB.Name = "clubNameTB";
            this.clubNameTB.Size = new System.Drawing.Size(264, 35);
            this.clubNameTB.TabIndex = 18;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(287, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(130, 29);
            this.label17.TabIndex = 34;
            this.label17.Text = "SWIMMER";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(311, 646);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(76, 29);
            this.label18.TabIndex = 35;
            this.label18.Text = "CLUB";
            // 
            // clubAddBtn
            // 
            this.clubAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clubAddBtn.Location = new System.Drawing.Point(263, 1047);
            this.clubAddBtn.Name = "clubAddBtn";
            this.clubAddBtn.Size = new System.Drawing.Size(168, 86);
            this.clubAddBtn.TabIndex = 36;
            this.clubAddBtn.Text = "ADD CLUB";
            this.clubAddBtn.UseVisualStyleBackColor = true;
            this.clubAddBtn.Click += new System.EventHandler(this.clubAddBtn_Click);
            // 
            // swimmerAddBtn
            // 
            this.swimmerAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmerAddBtn.Location = new System.Drawing.Point(247, 545);
            this.swimmerAddBtn.Name = "swimmerAddBtn";
            this.swimmerAddBtn.Size = new System.Drawing.Size(150, 85);
            this.swimmerAddBtn.TabIndex = 37;
            this.swimmerAddBtn.Text = "ADD SWIMMER";
            this.swimmerAddBtn.UseVisualStyleBackColor = true;
            this.swimmerAddBtn.Click += new System.EventHandler(this.swimmerAddBtn_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(779, 439);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 29);
            this.label19.TabIndex = 38;
            this.label19.Text = "CLUBS";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1222, 438);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(146, 29);
            this.label20.TabIndex = 39;
            this.label20.Text = "SWIMMERS";
            // 
            // DisplayView
            // 
            this.DisplayView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayView.HideSelection = false;
            this.DisplayView.Location = new System.Drawing.Point(676, 45);
            this.DisplayView.Margin = new System.Windows.Forms.Padding(10);
            this.DisplayView.Name = "DisplayView";
            this.DisplayView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DisplayView.Size = new System.Drawing.Size(323, 387);
            this.DisplayView.TabIndex = 40;
            this.DisplayView.UseCompatibleStateImageBehavior = false;
            this.DisplayView.View = System.Windows.Forms.View.Tile;
            this.DisplayView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DISPLAY
            // 
            this.DISPLAY.AutoSize = true;
            this.DISPLAY.Location = new System.Drawing.Point(777, 6);
            this.DISPLAY.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DISPLAY.Name = "DISPLAY";
            this.DISPLAY.Size = new System.Drawing.Size(118, 29);
            this.DISPLAY.TabIndex = 41;
            this.DISPLAY.Text = "DISPLAY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1960, 1339);
            this.Controls.Add(this.DISPLAY);
            this.Controls.Add(this.DisplayView);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.swimmerAddBtn);
            this.Controls.Add(this.clubAddBtn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.clubPCodeTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clubProvinceTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clubCityTB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.clubStreetTB);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.clubPhoneTB);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.clubNameTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.swimmerIDTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.swimmerPCodeTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.swimmerProvinceTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.swimmerCityTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.swimmerStreetTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.swimmerPhoneTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.swimmerDOBTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swimmerNameTB);
            this.Controls.Add(this.swimmerListBox);
            this.Controls.Add(this.clubListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clubListBox;
        private System.Windows.Forms.ListBox swimmerListBox;
        private System.Windows.Forms.TextBox swimmerNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox swimmerDOBTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox swimmerStreetTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox swimmerPhoneTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox swimmerIDTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox swimmerPCodeTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox swimmerProvinceTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox swimmerCityTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox clubPCodeTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox clubProvinceTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox clubCityTB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox clubStreetTB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox clubPhoneTB;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox clubNameTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button clubAddBtn;
        private System.Windows.Forms.Button swimmerAddBtn;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label DISPLAY;
        private System.Windows.Forms.ListView DisplayView;
    }
}

