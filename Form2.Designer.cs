
namespace Kinoprokat
{
    partial class ScheduleEditor
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.AddFilmsInput = new System.Windows.Forms.ComboBox();
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.freeTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveIdInput = new System.Windows.Forms.ComboBox();
            this.RemoveFilmButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NewFilmsList = new System.Windows.Forms.ListBox();
            this.OldFilmsList = new System.Windows.Forms.ListBox();
            this.SaveSeqButton = new System.Windows.Forms.Button();
            this.RightMoveButton = new System.Windows.Forms.Button();
            this.LeftMoveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.NewFilmsList);
            this.splitContainer1.Panel2.Controls.Add(this.OldFilmsList);
            this.splitContainer1.Panel2.Controls.Add(this.SaveSeqButton);
            this.splitContainer1.Panel2.Controls.Add(this.RightMoveButton);
            this.splitContainer1.Panel2.Controls.Add(this.LeftMoveButton);
            this.splitContainer1.Size = new System.Drawing.Size(788, 342);
            this.splitContainer1.SplitterDistance = 375;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddFilmsInput);
            this.splitContainer2.Panel1.Controls.Add(this.AddFilmButton);
            this.splitContainer2.Panel1.Controls.Add(this.freeTime);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RemoveIdInput);
            this.splitContainer2.Panel2.Controls.Add(this.RemoveFilmButton);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Size = new System.Drawing.Size(375, 342);
            this.splitContainer2.SplitterDistance = 162;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // AddFilmsInput
            // 
            this.AddFilmsInput.FormattingEnabled = true;
            this.AddFilmsInput.Location = new System.Drawing.Point(12, 36);
            this.AddFilmsInput.Name = "AddFilmsInput";
            this.AddFilmsInput.Size = new System.Drawing.Size(157, 21);
            this.AddFilmsInput.TabIndex = 6;
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddFilmButton.Location = new System.Drawing.Point(0, 136);
            this.AddFilmButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(375, 26);
            this.AddFilmButton.TabIndex = 5;
            this.AddFilmButton.Text = "Добавь в расписание";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // freeTime
            // 
            this.freeTime.FormattingEnabled = true;
            this.freeTime.Location = new System.Drawing.Point(11, 89);
            this.freeTime.Margin = new System.Windows.Forms.Padding(2);
            this.freeTime.Name = "freeTime";
            this.freeTime.Size = new System.Drawing.Size(158, 21);
            this.freeTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите начало фильма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите ID фильма:";
            // 
            // RemoveIdInput
            // 
            this.RemoveIdInput.FormattingEnabled = true;
            this.RemoveIdInput.Location = new System.Drawing.Point(11, 39);
            this.RemoveIdInput.Name = "RemoveIdInput";
            this.RemoveIdInput.Size = new System.Drawing.Size(157, 21);
            this.RemoveIdInput.TabIndex = 11;
            // 
            // RemoveFilmButton
            // 
            this.RemoveFilmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveFilmButton.Location = new System.Drawing.Point(0, 151);
            this.RemoveFilmButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveFilmButton.Name = "RemoveFilmButton";
            this.RemoveFilmButton.Size = new System.Drawing.Size(375, 26);
            this.RemoveFilmButton.TabIndex = 10;
            this.RemoveFilmButton.Text = "Удалить из расписания";
            this.RemoveFilmButton.UseVisualStyleBackColor = true;
            this.RemoveFilmButton.Click += new System.EventHandler(this.RemoveFilmButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Укажите ID фильма:";
            // 
            // NewFilmsList
            // 
            this.NewFilmsList.FormattingEnabled = true;
            this.NewFilmsList.Location = new System.Drawing.Point(263, 31);
            this.NewFilmsList.Margin = new System.Windows.Forms.Padding(2);
            this.NewFilmsList.Name = "NewFilmsList";
            this.NewFilmsList.Size = new System.Drawing.Size(136, 264);
            this.NewFilmsList.TabIndex = 14;
            // 
            // OldFilmsList
            // 
            this.OldFilmsList.FormattingEnabled = true;
            this.OldFilmsList.Location = new System.Drawing.Point(10, 31);
            this.OldFilmsList.Margin = new System.Windows.Forms.Padding(2);
            this.OldFilmsList.Name = "OldFilmsList";
            this.OldFilmsList.Size = new System.Drawing.Size(136, 264);
            this.OldFilmsList.TabIndex = 13;
            // 
            // SaveSeqButton
            // 
            this.SaveSeqButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveSeqButton.Location = new System.Drawing.Point(0, 316);
            this.SaveSeqButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveSeqButton.Name = "SaveSeqButton";
            this.SaveSeqButton.Size = new System.Drawing.Size(410, 26);
            this.SaveSeqButton.TabIndex = 11;
            this.SaveSeqButton.Text = "Сохранить порядок";
            this.SaveSeqButton.UseVisualStyleBackColor = true;
            this.SaveSeqButton.Click += new System.EventHandler(this.SaveSeqButton_Click);
            // 
            // RightMoveButton
            // 
            this.RightMoveButton.Location = new System.Drawing.Point(165, 136);
            this.RightMoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RightMoveButton.Name = "RightMoveButton";
            this.RightMoveButton.Size = new System.Drawing.Size(80, 26);
            this.RightMoveButton.TabIndex = 12;
            this.RightMoveButton.Text = "Вправо";
            this.RightMoveButton.UseVisualStyleBackColor = true;
            this.RightMoveButton.Click += new System.EventHandler(this.RightMoveButton_Click);
            // 
            // LeftMoveButton
            // 
            this.LeftMoveButton.Location = new System.Drawing.Point(165, 174);
            this.LeftMoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.LeftMoveButton.Name = "LeftMoveButton";
            this.LeftMoveButton.Size = new System.Drawing.Size(80, 26);
            this.LeftMoveButton.TabIndex = 11;
            this.LeftMoveButton.Text = "Влево";
            this.LeftMoveButton.UseVisualStyleBackColor = true;
            this.LeftMoveButton.Click += new System.EventHandler(this.LeftMoveButton_Click);
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 342);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ScheduleEditor";
            this.Text = "Управление расписанием";
            this.Load += new System.EventHandler(this.ScheduleEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button AddFilmButton;
        private System.Windows.Forms.ComboBox freeTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveFilmButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveSeqButton;
        private System.Windows.Forms.Button RightMoveButton;
        private System.Windows.Forms.Button LeftMoveButton;
        private System.Windows.Forms.ListBox NewFilmsList;
        private System.Windows.Forms.ListBox OldFilmsList;
        private System.Windows.Forms.ComboBox AddFilmsInput;
        private System.Windows.Forms.ComboBox RemoveIdInput;
    }
}