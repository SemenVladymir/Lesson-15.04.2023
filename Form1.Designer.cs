using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lesson_15._04._23__ComboBox__ListBox__CheckListBox__ScrollBarr_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Text = "Form1";

            lRED = new Label();
            lRED.Text = "RED";
            lRED.TextAlign = ContentAlignment.TopCenter;
            lRED.Size = new Size(300, 20);
            lRED.Location = new Point(50, 10);
            this.Controls.Add(lRED);

            trBarRED = new TrackBar();
            trBarRED.Maximum = 255;
            trBarRED.Minimum = 0;
            trBarRED.Size = new Size(300, 50);
            trBarRED.Location = new Point(50, 40);
            trBarRED.TickStyle = TickStyle.Both;
            trBarRED.TickFrequency = 10;
            trBarRED.ValueChanged += (s, e) => panel.BackColor = Color.FromArgb(trBarRED.Value, trBarGREEN.Value, trBarBLUE.Value);
            this.Controls.Add(trBarRED);

            lGREEN = new Label();
            lGREEN.Text = "GREEN";
            lGREEN.TextAlign = ContentAlignment.TopCenter;
            lGREEN.Size = new Size(300, 20);
            lGREEN.Location = new Point(50, 110);
            this.Controls.Add(lGREEN);

            trBarGREEN = new TrackBar();
            trBarGREEN.Maximum = 255;
            trBarGREEN.Minimum = 0;
            trBarGREEN.Size = new Size(300, 50);
            trBarGREEN.Location = new Point(50, 130);
            trBarGREEN.TickStyle = TickStyle.Both;
            trBarGREEN.TickFrequency = 10;
            trBarGREEN.ValueChanged += (s, e) =>  panel.BackColor = Color.FromArgb(trBarRED.Value, trBarGREEN.Value, trBarBLUE.Value);
            this.Controls.Add(trBarGREEN);

            lBLUE = new Label();
            lBLUE.Text = "BLUE";
            lBLUE.TextAlign = ContentAlignment.TopCenter;
            lBLUE.Size = new Size(300, 20);
            lBLUE.Location = new Point(50, 200);
            this.Controls.Add(lBLUE);

            trBarBLUE = new TrackBar();
            trBarBLUE.Maximum = 255;
            trBarBLUE.Minimum = 0;
            trBarBLUE.Size = new Size(300, 50);
            trBarBLUE.Location = new Point(50, 220);
            trBarBLUE.TickStyle = TickStyle.Both;
            trBarBLUE.TickFrequency = 10;
            trBarBLUE.ValueChanged += (s, e) => panel.BackColor = Color.FromArgb(trBarRED.Value, trBarGREEN.Value, trBarBLUE.Value);
            this.Controls.Add(trBarBLUE);

            panel = new Panel();
            panel.Text = "Text panel";
            panel.Location = new Point(360, 20);
            panel.Size = new Size(120, 260);
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BackColor = Color.GhostWhite;
            this.Controls.Add(panel);

            btnSave = new Button();
            //btnSave.Text = "Save";
            btnSave.BackgroundImage =  Image.FromFile("C:\\Users\\User\\OneDrive\\Documents\\GitHub\\Lesson 15.04.23 (ComboBox, ListBox, CheckListBox, ScrollBarr)\\Properties\\Image.png");
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.Size = new Size(120, 30);
            btnSave.Location = new Point(360, 300);
            this.Controls.Add(btnSave);
            btnSave.Click += BtnSave_Click;


            savedColors = new ComboBox();
            savedColors.Size = new Size(300, 30);
            savedColors.Location = new Point(50, 300);
            //savedColors.SelectedIndex = 0;
            savedColors.SelectedIndexChanged += SavedColors_SelectedIndexChanged;
            this.Controls.Add(savedColors);

            day = new CheckBox();
            day.Checked = true;
            day.Text = "Set day or night theme";
            day.Size = new Size(day.Text.Length * 12, 30);
            day.Location = new Point(50, 320);
            this.Controls.Add(day);
            day.Click += Day_Click;
        }

        private void SavedColors_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (savedColors.SelectedIndex >= 0)
            {
                string [] colors = savedColors.SelectedItem.ToString().Split(',');
                trBarRED.Value = (Convert.ToInt32(colors[0]));
                trBarGREEN.Value = (Convert.ToInt32(colors[1]));
                trBarBLUE.Value = (Convert.ToInt32(colors[2]));
            }
        }

        private void Day_Click(object sender, EventArgs e)
        {
            if (!day.Checked)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                lGREEN.ForeColor = Color.White;
                lBLUE.ForeColor = Color.White;
                lRED.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                lGREEN.ForeColor = Color.Black;
                lBLUE.ForeColor = Color.Black;
                lRED.ForeColor = Color.Black;
            }
        }

        private void BtnSave_Click(object sender, System.EventArgs e)
        {
            savedColors.Items.Add($"{trBarRED.Value},{trBarGREEN.Value},{trBarBLUE.Value}");
        }

        Label lRED;
        Label lGREEN;
        Label lBLUE;

        TrackBar trBarRED;
        TrackBar trBarBLUE;
        TrackBar trBarGREEN;

        Button btnSave;

        ComboBox savedColors;

        CheckBox day;

        Panel panel;
        #endregion
    }
}

