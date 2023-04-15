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
            this.ClientSize = new System.Drawing.Size(500, 300);
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
        }

        Label lRED;
        Label lGREEN;
        Label lBLUE;

        TrackBar trBarRED;
        TrackBar trBarBLUE;
        TrackBar trBarGREEN;

        Panel panel;
        #endregion
    }
}

