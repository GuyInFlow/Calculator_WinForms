namespace Calculator_WF
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            PlentyTextBox = new TextBox();
            MainTextBox = new TextBox();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            roundButton1 = new CustomControlers.RoundButton();
            roundButton2 = new CustomControlers.RoundButton();
            roundButton3 = new CustomControlers.RoundButton();
            roundButton4 = new CustomControlers.RoundButton();
            roundButton5 = new CustomControlers.RoundButton();
            roundButton6 = new CustomControlers.RoundButton();
            roundButton7 = new CustomControlers.RoundButton();
            roundButton8 = new CustomControlers.RoundButton();
            roundButton9 = new CustomControlers.RoundButton();
            roundButton10 = new CustomControlers.RoundButton();
            roundButton11 = new CustomControlers.RoundButton();
            roundButton12 = new CustomControlers.RoundButton();
            roundButton13 = new CustomControlers.RoundButton();
            roundButton14 = new CustomControlers.RoundButton();
            roundButton15 = new CustomControlers.RoundButton();
            roundButton16 = new CustomControlers.RoundButton();
            roundButton17 = new CustomControlers.RoundButton();
            roundButton18 = new CustomControlers.RoundButton();
            roundButton19 = new CustomControlers.RoundButton();
            roundButton20 = new CustomControlers.RoundButton();
            roundButton21 = new CustomControlers.RoundButton();
            roundButton22 = new CustomControlers.RoundButton();
            roundButton23 = new CustomControlers.RoundButton();
            roundButton24 = new CustomControlers.RoundButton();
            HistoryPanel = new Panel();
            TrashButton = new Button();
            HistoryTextBox = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            HistoryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 40);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(255, 0);
            button3.Name = "button3";
            button3.Size = new Size(50, 40);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += MaximizeButton_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(205, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 40);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += HideButton_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(300, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += CloseButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 40);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(50, 40);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += MenuButton_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(300, -3);
            button4.Name = "button4";
            button4.Size = new Size(50, 40);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += HistoryButton_Click;
            // 
            // PlentyTextBox
            // 
            PlentyTextBox.BackColor = Color.FromArgb(32, 32, 32);
            PlentyTextBox.BorderStyle = BorderStyle.None;
            PlentyTextBox.Dock = DockStyle.Top;
            PlentyTextBox.Font = new Font("Microsoft Sans Serif", 14F);
            PlentyTextBox.ForeColor = SystemColors.WindowFrame;
            PlentyTextBox.Location = new Point(0, 80);
            PlentyTextBox.Multiline = true;
            PlentyTextBox.Name = "PlentyTextBox";
            PlentyTextBox.Size = new Size(350, 22);
            PlentyTextBox.TabIndex = 2;
            PlentyTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // MainTextBox
            // 
            MainTextBox.BackColor = Color.FromArgb(32, 32, 32);
            MainTextBox.BorderStyle = BorderStyle.None;
            MainTextBox.Dock = DockStyle.Top;
            MainTextBox.Font = new Font("Segoe UI", 24F);
            MainTextBox.ForeColor = Color.White;
            MainTextBox.Location = new Point(0, 102);
            MainTextBox.MaximumSize = new Size(350, 46);
            MainTextBox.Multiline = true;
            MainTextBox.Name = "MainTextBox";
            MainTextBox.Size = new Size(350, 46);
            MainTextBox.TabIndex = 3;
            MainTextBox.Text = "0";
            MainTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 14F);
            button6.Location = new Point(300, 154);
            button6.Name = "button6";
            button6.Size = new Size(50, 40);
            button6.TabIndex = 4;
            button6.Text = "M~";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Segoe UI", 14F);
            button7.Location = new Point(240, 154);
            button7.Name = "button7";
            button7.Size = new Size(50, 40);
            button7.TabIndex = 5;
            button7.Text = "MS";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Segoe UI", 14F);
            button8.Location = new Point(180, 154);
            button8.Name = "button8";
            button8.Size = new Size(50, 40);
            button8.TabIndex = 6;
            button8.Text = "M-";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 14F);
            button9.Location = new Point(120, 154);
            button9.Name = "button9";
            button9.Size = new Size(50, 40);
            button9.TabIndex = 7;
            button9.Text = "M+";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 14F);
            button10.Location = new Point(60, 154);
            button10.Name = "button10";
            button10.Size = new Size(50, 40);
            button10.TabIndex = 8;
            button10.Text = "MR";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 14F);
            button11.Location = new Point(0, 154);
            button11.Name = "button11";
            button11.Size = new Size(50, 40);
            button11.TabIndex = 9;
            button11.Text = "MC";
            button11.UseVisualStyleBackColor = true;
            // 
            // roundButton1
            // 
            roundButton1.BackColor = Color.FromArgb(50, 50, 50);
            roundButton1.BackgroundImageLayout = ImageLayout.Center;
            roundButton1.FlatAppearance.BorderSize = 0;
            roundButton1.FlatStyle = FlatStyle.Flat;
            roundButton1.ForeColor = Color.White;
            roundButton1.Image = (Image)resources.GetObject("roundButton1.Image");
            roundButton1.Location = new Point(264, 209);
            roundButton1.Name = "roundButton1";
            roundButton1.Size = new Size(85, 55);
            roundButton1.TabIndex = 10;
            roundButton1.UseVisualStyleBackColor = false;
            roundButton1.Click += DeleteKeyButton_Click;
            // 
            // roundButton2
            // 
            roundButton2.BackColor = Color.FromArgb(50, 50, 50);
            roundButton2.FlatAppearance.BorderSize = 0;
            roundButton2.FlatStyle = FlatStyle.Flat;
            roundButton2.Font = new Font("Segoe UI", 14F);
            roundButton2.ForeColor = Color.White;
            roundButton2.Location = new Point(176, 209);
            roundButton2.Name = "roundButton2";
            roundButton2.Size = new Size(85, 55);
            roundButton2.TabIndex = 11;
            roundButton2.Text = "C";
            roundButton2.UseVisualStyleBackColor = false;
            roundButton2.Click += ButtonClearAll_Click;
            // 
            // roundButton3
            // 
            roundButton3.BackColor = Color.FromArgb(50, 50, 50);
            roundButton3.FlatAppearance.BorderSize = 0;
            roundButton3.FlatStyle = FlatStyle.Flat;
            roundButton3.Font = new Font("Segoe UI", 14F);
            roundButton3.ForeColor = Color.White;
            roundButton3.Location = new Point(88, 209);
            roundButton3.Name = "roundButton3";
            roundButton3.Size = new Size(85, 55);
            roundButton3.TabIndex = 12;
            roundButton3.Text = "CE";
            roundButton3.UseVisualStyleBackColor = false;
            roundButton3.Click += ButtonClearAll_Click;
            // 
            // roundButton4
            // 
            roundButton4.BackColor = Color.FromArgb(50, 50, 50);
            roundButton4.FlatAppearance.BorderSize = 0;
            roundButton4.FlatStyle = FlatStyle.Flat;
            roundButton4.Font = new Font("Segoe UI", 14F);
            roundButton4.ForeColor = Color.White;
            roundButton4.Location = new Point(0, 209);
            roundButton4.Name = "roundButton4";
            roundButton4.Size = new Size(85, 55);
            roundButton4.TabIndex = 13;
            roundButton4.Text = "%";
            roundButton4.UseVisualStyleBackColor = false;
            roundButton4.Click += ButtonMathOperation_Click;
            // 
            // roundButton5
            // 
            roundButton5.BackColor = Color.FromArgb(50, 50, 50);
            roundButton5.FlatAppearance.BorderSize = 0;
            roundButton5.FlatStyle = FlatStyle.Flat;
            roundButton5.Font = new Font("Segoe UI", 14F);
            roundButton5.ForeColor = Color.White;
            roundButton5.Location = new Point(0, 266);
            roundButton5.Name = "roundButton5";
            roundButton5.Size = new Size(85, 55);
            roundButton5.TabIndex = 17;
            roundButton5.Text = "1/x";
            roundButton5.UseVisualStyleBackColor = false;
            roundButton5.Click += DenominatorDivisionButton_Click;
            // 
            // roundButton6
            // 
            roundButton6.BackColor = Color.FromArgb(50, 50, 50);
            roundButton6.FlatAppearance.BorderSize = 0;
            roundButton6.FlatStyle = FlatStyle.Flat;
            roundButton6.Font = new Font("Segoe UI", 14F);
            roundButton6.ForeColor = Color.White;
            roundButton6.Location = new Point(88, 266);
            roundButton6.Name = "roundButton6";
            roundButton6.Size = new Size(85, 55);
            roundButton6.TabIndex = 16;
            roundButton6.Text = "^";
            roundButton6.UseVisualStyleBackColor = false;
            roundButton6.Click += ButtonMathOperation_Click;
            // 
            // roundButton7
            // 
            roundButton7.BackColor = Color.FromArgb(50, 50, 50);
            roundButton7.FlatAppearance.BorderSize = 0;
            roundButton7.FlatStyle = FlatStyle.Flat;
            roundButton7.Font = new Font("Segoe UI", 14F);
            roundButton7.ForeColor = Color.White;
            roundButton7.Location = new Point(176, 266);
            roundButton7.Name = "roundButton7";
            roundButton7.Size = new Size(85, 55);
            roundButton7.TabIndex = 15;
            roundButton7.Text = "√";
            roundButton7.UseVisualStyleBackColor = false;
            roundButton7.Click += ButtonMathOperation_Click;
            // 
            // roundButton8
            // 
            roundButton8.BackColor = Color.FromArgb(50, 50, 50);
            roundButton8.FlatAppearance.BorderSize = 0;
            roundButton8.FlatStyle = FlatStyle.Flat;
            roundButton8.Font = new Font("Segoe UI", 14F);
            roundButton8.ForeColor = Color.White;
            roundButton8.Location = new Point(264, 266);
            roundButton8.Name = "roundButton8";
            roundButton8.Size = new Size(85, 55);
            roundButton8.TabIndex = 14;
            roundButton8.Text = "/";
            roundButton8.UseVisualStyleBackColor = false;
            roundButton8.Click += ButtonMathOperation_Click;
            // 
            // roundButton9
            // 
            roundButton9.BackColor = Color.FromArgb(60, 60, 60);
            roundButton9.FlatAppearance.BorderSize = 0;
            roundButton9.FlatStyle = FlatStyle.Flat;
            roundButton9.Font = new Font("Segoe UI", 14F);
            roundButton9.ForeColor = Color.White;
            roundButton9.Location = new Point(0, 324);
            roundButton9.Name = "roundButton9";
            roundButton9.Size = new Size(85, 55);
            roundButton9.TabIndex = 21;
            roundButton9.Text = "7";
            roundButton9.UseVisualStyleBackColor = false;
            roundButton9.Click += ButtonNumber_Click;
            // 
            // roundButton10
            // 
            roundButton10.BackColor = Color.FromArgb(60, 60, 60);
            roundButton10.FlatAppearance.BorderSize = 0;
            roundButton10.FlatStyle = FlatStyle.Flat;
            roundButton10.Font = new Font("Segoe UI", 14F);
            roundButton10.ForeColor = Color.White;
            roundButton10.Location = new Point(88, 324);
            roundButton10.Name = "roundButton10";
            roundButton10.Size = new Size(85, 55);
            roundButton10.TabIndex = 20;
            roundButton10.Text = "8";
            roundButton10.UseVisualStyleBackColor = false;
            roundButton10.Click += ButtonNumber_Click;
            // 
            // roundButton11
            // 
            roundButton11.BackColor = Color.FromArgb(60, 60, 60);
            roundButton11.FlatAppearance.BorderSize = 0;
            roundButton11.FlatStyle = FlatStyle.Flat;
            roundButton11.Font = new Font("Segoe UI", 14F);
            roundButton11.ForeColor = Color.White;
            roundButton11.Location = new Point(176, 324);
            roundButton11.Name = "roundButton11";
            roundButton11.Size = new Size(85, 55);
            roundButton11.TabIndex = 19;
            roundButton11.Text = "9";
            roundButton11.UseVisualStyleBackColor = false;
            roundButton11.Click += ButtonNumber_Click;
            // 
            // roundButton12
            // 
            roundButton12.BackColor = Color.FromArgb(50, 50, 50);
            roundButton12.FlatAppearance.BorderSize = 0;
            roundButton12.FlatStyle = FlatStyle.Flat;
            roundButton12.Font = new Font("Segoe UI", 14F);
            roundButton12.ForeColor = Color.White;
            roundButton12.Location = new Point(264, 324);
            roundButton12.Name = "roundButton12";
            roundButton12.Size = new Size(85, 55);
            roundButton12.TabIndex = 18;
            roundButton12.Text = "x";
            roundButton12.UseVisualStyleBackColor = false;
            roundButton12.Click += ButtonMathOperation_Click;
            // 
            // roundButton13
            // 
            roundButton13.BackColor = Color.FromArgb(60, 60, 60);
            roundButton13.FlatAppearance.BorderSize = 0;
            roundButton13.FlatStyle = FlatStyle.Flat;
            roundButton13.Font = new Font("Segoe UI", 14F);
            roundButton13.ForeColor = Color.White;
            roundButton13.Location = new Point(0, 382);
            roundButton13.Name = "roundButton13";
            roundButton13.Size = new Size(85, 55);
            roundButton13.TabIndex = 25;
            roundButton13.Text = "4";
            roundButton13.UseVisualStyleBackColor = false;
            roundButton13.Click += ButtonNumber_Click;
            // 
            // roundButton14
            // 
            roundButton14.BackColor = Color.FromArgb(60, 60, 60);
            roundButton14.FlatAppearance.BorderSize = 0;
            roundButton14.FlatStyle = FlatStyle.Flat;
            roundButton14.Font = new Font("Segoe UI", 14F);
            roundButton14.ForeColor = Color.White;
            roundButton14.Location = new Point(88, 382);
            roundButton14.Name = "roundButton14";
            roundButton14.Size = new Size(85, 55);
            roundButton14.TabIndex = 24;
            roundButton14.Text = "5";
            roundButton14.UseVisualStyleBackColor = false;
            roundButton14.Click += ButtonNumber_Click;
            // 
            // roundButton15
            // 
            roundButton15.BackColor = Color.FromArgb(60, 60, 60);
            roundButton15.FlatAppearance.BorderSize = 0;
            roundButton15.FlatStyle = FlatStyle.Flat;
            roundButton15.Font = new Font("Segoe UI", 14F);
            roundButton15.ForeColor = Color.White;
            roundButton15.Location = new Point(176, 382);
            roundButton15.Name = "roundButton15";
            roundButton15.Size = new Size(85, 55);
            roundButton15.TabIndex = 23;
            roundButton15.Text = "6";
            roundButton15.UseVisualStyleBackColor = false;
            roundButton15.Click += ButtonNumber_Click;
            // 
            // roundButton16
            // 
            roundButton16.BackColor = Color.FromArgb(50, 50, 50);
            roundButton16.FlatAppearance.BorderSize = 0;
            roundButton16.FlatStyle = FlatStyle.Flat;
            roundButton16.Font = new Font("Segoe UI", 14F);
            roundButton16.ForeColor = Color.White;
            roundButton16.Location = new Point(264, 382);
            roundButton16.Name = "roundButton16";
            roundButton16.Size = new Size(85, 55);
            roundButton16.TabIndex = 22;
            roundButton16.Text = "-";
            roundButton16.UseVisualStyleBackColor = false;
            roundButton16.Click += ButtonMathOperation_Click;
            // 
            // roundButton17
            // 
            roundButton17.BackColor = Color.FromArgb(60, 60, 60);
            roundButton17.FlatAppearance.BorderSize = 0;
            roundButton17.FlatStyle = FlatStyle.Flat;
            roundButton17.Font = new Font("Segoe UI", 14F);
            roundButton17.ForeColor = Color.White;
            roundButton17.Location = new Point(0, 439);
            roundButton17.Name = "roundButton17";
            roundButton17.Size = new Size(85, 55);
            roundButton17.TabIndex = 29;
            roundButton17.Text = "1";
            roundButton17.UseVisualStyleBackColor = false;
            roundButton17.Click += ButtonNumber_Click;
            // 
            // roundButton18
            // 
            roundButton18.BackColor = Color.FromArgb(60, 60, 60);
            roundButton18.FlatAppearance.BorderSize = 0;
            roundButton18.FlatStyle = FlatStyle.Flat;
            roundButton18.Font = new Font("Segoe UI", 14F);
            roundButton18.ForeColor = Color.White;
            roundButton18.Location = new Point(88, 439);
            roundButton18.Name = "roundButton18";
            roundButton18.Size = new Size(85, 55);
            roundButton18.TabIndex = 28;
            roundButton18.Text = "2";
            roundButton18.UseVisualStyleBackColor = false;
            roundButton18.Click += ButtonNumber_Click;
            // 
            // roundButton19
            // 
            roundButton19.BackColor = Color.FromArgb(60, 60, 60);
            roundButton19.FlatAppearance.BorderSize = 0;
            roundButton19.FlatStyle = FlatStyle.Flat;
            roundButton19.Font = new Font("Segoe UI", 14F);
            roundButton19.ForeColor = Color.White;
            roundButton19.Location = new Point(176, 439);
            roundButton19.Name = "roundButton19";
            roundButton19.Size = new Size(85, 55);
            roundButton19.TabIndex = 27;
            roundButton19.Text = "3";
            roundButton19.UseVisualStyleBackColor = false;
            roundButton19.Click += ButtonNumber_Click;
            // 
            // roundButton20
            // 
            roundButton20.BackColor = Color.FromArgb(50, 50, 50);
            roundButton20.FlatAppearance.BorderSize = 0;
            roundButton20.FlatStyle = FlatStyle.Flat;
            roundButton20.Font = new Font("Segoe UI", 14F);
            roundButton20.ForeColor = Color.White;
            roundButton20.Location = new Point(264, 439);
            roundButton20.Name = "roundButton20";
            roundButton20.Size = new Size(85, 55);
            roundButton20.TabIndex = 26;
            roundButton20.Text = "+";
            roundButton20.UseVisualStyleBackColor = false;
            roundButton20.Click += ButtonMathOperation_Click;
            // 
            // roundButton21
            // 
            roundButton21.BackColor = Color.FromArgb(60, 60, 60);
            roundButton21.FlatAppearance.BorderSize = 0;
            roundButton21.FlatStyle = FlatStyle.Flat;
            roundButton21.Font = new Font("Segoe UI", 14F);
            roundButton21.ForeColor = Color.White;
            roundButton21.Location = new Point(0, 496);
            roundButton21.Name = "roundButton21";
            roundButton21.Size = new Size(85, 55);
            roundButton21.TabIndex = 33;
            roundButton21.Text = "+-";
            roundButton21.UseVisualStyleBackColor = false;
            roundButton21.Click += PlusMinusButton_Click;
            // 
            // roundButton22
            // 
            roundButton22.BackColor = Color.FromArgb(60, 60, 60);
            roundButton22.FlatAppearance.BorderSize = 0;
            roundButton22.FlatStyle = FlatStyle.Flat;
            roundButton22.Font = new Font("Segoe UI", 14F);
            roundButton22.ForeColor = Color.White;
            roundButton22.Location = new Point(88, 496);
            roundButton22.Name = "roundButton22";
            roundButton22.Size = new Size(85, 55);
            roundButton22.TabIndex = 32;
            roundButton22.Text = "0";
            roundButton22.UseVisualStyleBackColor = false;
            roundButton22.Click += ButtonNumber_Click;
            // 
            // roundButton23
            // 
            roundButton23.BackColor = Color.FromArgb(60, 60, 60);
            roundButton23.FlatAppearance.BorderSize = 0;
            roundButton23.FlatStyle = FlatStyle.Flat;
            roundButton23.Font = new Font("Segoe UI", 14F);
            roundButton23.ForeColor = Color.White;
            roundButton23.Location = new Point(176, 496);
            roundButton23.Name = "roundButton23";
            roundButton23.Size = new Size(85, 55);
            roundButton23.TabIndex = 31;
            roundButton23.Text = ",";
            roundButton23.UseVisualStyleBackColor = false;
            roundButton23.Click += CommaButton_Click;
            // 
            // roundButton24
            // 
            roundButton24.BackColor = SystemColors.HotTrack;
            roundButton24.FlatAppearance.BorderSize = 0;
            roundButton24.FlatStyle = FlatStyle.Flat;
            roundButton24.Font = new Font("Segoe UI", 14F);
            roundButton24.ForeColor = Color.White;
            roundButton24.Location = new Point(264, 496);
            roundButton24.Name = "roundButton24";
            roundButton24.Size = new Size(85, 55);
            roundButton24.TabIndex = 30;
            roundButton24.Text = "=";
            roundButton24.UseVisualStyleBackColor = false;
            roundButton24.Click += ButtonEqual_Click;
            // 
            // HistoryPanel
            // 
            HistoryPanel.Controls.Add(TrashButton);
            HistoryPanel.Controls.Add(HistoryTextBox);
            HistoryPanel.Dock = DockStyle.Bottom;
            HistoryPanel.Location = new Point(0, 569);
            HistoryPanel.Name = "HistoryPanel";
            HistoryPanel.Size = new Size(350, 1);
            HistoryPanel.TabIndex = 34;
            // 
            // TrashButton
            // 
            TrashButton.BackgroundImage = (Image)resources.GetObject("TrashButton.BackgroundImage");
            TrashButton.BackgroundImageLayout = ImageLayout.Zoom;
            TrashButton.Dock = DockStyle.Bottom;
            TrashButton.FlatStyle = FlatStyle.Flat;
            TrashButton.ForeColor = Color.FromArgb(32, 32, 32);
            TrashButton.Location = new Point(0, -39);
            TrashButton.Name = "TrashButton";
            TrashButton.Size = new Size(350, 40);
            TrashButton.TabIndex = 1;
            TrashButton.UseVisualStyleBackColor = true;
            TrashButton.Click += TrashButton_Click;
            // 
            // HistoryTextBox
            // 
            HistoryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            HistoryTextBox.BackColor = Color.FromArgb(32, 32, 32);
            HistoryTextBox.BorderStyle = BorderStyle.None;
            HistoryTextBox.Font = new Font("Segoe UI", 14F);
            HistoryTextBox.ForeColor = Color.White;
            HistoryTextBox.Location = new Point(0, 0);
            HistoryTextBox.Name = "HistoryTextBox";
            HistoryTextBox.Size = new Size(350, 0);
            HistoryTextBox.TabIndex = 0;
            HistoryTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(350, 570);
            Controls.Add(HistoryPanel);
            Controls.Add(roundButton21);
            Controls.Add(roundButton22);
            Controls.Add(roundButton23);
            Controls.Add(roundButton24);
            Controls.Add(roundButton17);
            Controls.Add(roundButton18);
            Controls.Add(roundButton19);
            Controls.Add(roundButton20);
            Controls.Add(roundButton13);
            Controls.Add(roundButton14);
            Controls.Add(roundButton15);
            Controls.Add(roundButton16);
            Controls.Add(roundButton9);
            Controls.Add(roundButton10);
            Controls.Add(roundButton11);
            Controls.Add(roundButton12);
            Controls.Add(roundButton5);
            Controls.Add(roundButton6);
            Controls.Add(roundButton7);
            Controls.Add(roundButton8);
            Controls.Add(roundButton4);
            Controls.Add(roundButton3);
            Controls.Add(roundButton2);
            Controls.Add(roundButton1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(MainTextBox);
            Controls.Add(PlentyTextBox);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            HistoryPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button button5;
        private Button button4;
        private TextBox PlentyTextBox;
        private TextBox MainTextBox;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private CustomControlers.RoundButton roundButton1;
        private CustomControlers.RoundButton roundButton2;
        private CustomControlers.RoundButton roundButton3;
        private CustomControlers.RoundButton roundButton4;
        private CustomControlers.RoundButton roundButton5;
        private CustomControlers.RoundButton roundButton6;
        private CustomControlers.RoundButton roundButton7;
        private CustomControlers.RoundButton roundButton8;
        private CustomControlers.RoundButton roundButton9;
        private CustomControlers.RoundButton roundButton10;
        private CustomControlers.RoundButton roundButton11;
        private CustomControlers.RoundButton roundButton12;
        private CustomControlers.RoundButton roundButton13;
        private CustomControlers.RoundButton roundButton14;
        private CustomControlers.RoundButton roundButton15;
        private CustomControlers.RoundButton roundButton16;
        private CustomControlers.RoundButton roundButton17;
        private CustomControlers.RoundButton roundButton18;
        private CustomControlers.RoundButton roundButton19;
        private CustomControlers.RoundButton roundButton20;
        private CustomControlers.RoundButton roundButton21;
        private CustomControlers.RoundButton roundButton22;
        private CustomControlers.RoundButton roundButton23;
        private CustomControlers.RoundButton roundButton24;
        private Panel HistoryPanel;
        private RichTextBox HistoryTextBox;
        private Button TrashButton;
    }
}
