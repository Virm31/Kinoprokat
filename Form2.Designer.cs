
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
            this.AddFilmButton = new System.Windows.Forms.Button();
            this.freeTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkAddIdButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AddIdInput = new System.Windows.Forms.TextBox();
            this.RemoveFilmButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.checkRemoveIdButton = new System.Windows.Forms.Button();
            this.RemoveIdInput = new System.Windows.Forms.TextBox();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 421);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.AddFilmButton);
            this.splitContainer2.Panel1.Controls.Add(this.freeTime);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.checkAddIdButton);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.AddIdInput);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.RemoveFilmButton);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.checkRemoveIdButton);
            this.splitContainer2.Panel2.Controls.Add(this.RemoveIdInput);
            this.splitContainer2.Size = new System.Drawing.Size(382, 421);
            this.splitContainer2.SplitterDistance = 200;
            this.splitContainer2.TabIndex = 0;
            // 
            // AddFilmButton
            // 
            this.AddFilmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddFilmButton.Location = new System.Drawing.Point(0, 168);
            this.AddFilmButton.Name = "AddFilmButton";
            this.AddFilmButton.Size = new System.Drawing.Size(382, 32);
            this.AddFilmButton.TabIndex = 5;
            this.AddFilmButton.Text = "Добавь фильм";
            this.AddFilmButton.UseVisualStyleBackColor = true;
            this.AddFilmButton.Click += new System.EventHandler(this.AddFilmButton_Click);
            // 
            // freeTime
            // 
            this.freeTime.FormattingEnabled = true;
            this.freeTime.Location = new System.Drawing.Point(15, 110);
            this.freeTime.Name = "freeTime";
            this.freeTime.Size = new System.Drawing.Size(209, 24);
            this.freeTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите начало фильма:";
            // 
            // checkAddIdButton
            // 
            this.checkAddIdButton.Location = new System.Drawing.Point(240, 38);
            this.checkAddIdButton.Name = "checkAddIdButton";
            this.checkAddIdButton.Size = new System.Drawing.Size(135, 32);
            this.checkAddIdButton.TabIndex = 2;
            this.checkAddIdButton.Text = "Проверить";
            this.checkAddIdButton.UseVisualStyleBackColor = true;
            this.checkAddIdButton.Click += new System.EventHandler(this.checkAddIdButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Укажите ID фильма:";
            // 
            // AddIdInput
            // 
            this.AddIdInput.Location = new System.Drawing.Point(15, 43);
            this.AddIdInput.Name = "AddIdInput";
            this.AddIdInput.Size = new System.Drawing.Size(209, 22);
            this.AddIdInput.TabIndex = 0;
            // 
            // RemoveFilmButton
            // 
            this.RemoveFilmButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RemoveFilmButton.Location = new System.Drawing.Point(0, 185);
            this.RemoveFilmButton.Name = "RemoveFilmButton";
            this.RemoveFilmButton.Size = new System.Drawing.Size(382, 32);
            this.RemoveFilmButton.TabIndex = 10;
            this.RemoveFilmButton.Text = "Удалить фильм";
            this.RemoveFilmButton.UseVisualStyleBackColor = true;
            this.RemoveFilmButton.Click += new System.EventHandler(this.RemoveFilmButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Укажите ID фильма:";
            // 
            // checkRemoveIdButton
            // 
            this.checkRemoveIdButton.Location = new System.Drawing.Point(240, 42);
            this.checkRemoveIdButton.Name = "checkRemoveIdButton";
            this.checkRemoveIdButton.Size = new System.Drawing.Size(135, 32);
            this.checkRemoveIdButton.TabIndex = 8;
            this.checkRemoveIdButton.Text = "Проверить";
            this.checkRemoveIdButton.UseVisualStyleBackColor = true;
            this.checkRemoveIdButton.Click += new System.EventHandler(this.checkRemoveIdButton_Click);
            // 
            // RemoveIdInput
            // 
            this.RemoveIdInput.Location = new System.Drawing.Point(15, 46);
            this.RemoveIdInput.Name = "RemoveIdInput";
            this.RemoveIdInput.Size = new System.Drawing.Size(209, 22);
            this.RemoveIdInput.TabIndex = 6;
            // 
            // NewFilmsList
            // 
            this.NewFilmsList.FormattingEnabled = true;
            this.NewFilmsList.ItemHeight = 16;
            this.NewFilmsList.Location = new System.Drawing.Point(282, 40);
            this.NewFilmsList.Name = "NewFilmsList";
            this.NewFilmsList.Size = new System.Drawing.Size(120, 324);
            this.NewFilmsList.TabIndex = 14;
            // 
            // OldFilmsList
            // 
            this.OldFilmsList.FormattingEnabled = true;
            this.OldFilmsList.ItemHeight = 16;
            this.OldFilmsList.Location = new System.Drawing.Point(13, 38);
            this.OldFilmsList.Name = "OldFilmsList";
            this.OldFilmsList.Size = new System.Drawing.Size(120, 324);
            this.OldFilmsList.TabIndex = 13;
            // 
            // SaveSeqButton
            // 
            this.SaveSeqButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaveSeqButton.Location = new System.Drawing.Point(0, 389);
            this.SaveSeqButton.Name = "SaveSeqButton";
            this.SaveSeqButton.Size = new System.Drawing.Size(414, 32);
            this.SaveSeqButton.TabIndex = 11;
            this.SaveSeqButton.Text = "Сохранить порядок";
            this.SaveSeqButton.UseVisualStyleBackColor = true;
            this.SaveSeqButton.Click += new System.EventHandler(this.SaveSeqButton_Click);
            // 
            // RightMoveButton
            // 
            this.RightMoveButton.Location = new System.Drawing.Point(153, 132);
            this.RightMoveButton.Name = "RightMoveButton";
            this.RightMoveButton.Size = new System.Drawing.Size(107, 32);
            this.RightMoveButton.TabIndex = 12;
            this.RightMoveButton.Text = "Вправо";
            this.RightMoveButton.UseVisualStyleBackColor = true;
            this.RightMoveButton.Click += new System.EventHandler(this.RightMoveButton_Click);
            // 
            // LeftMoveButton
            // 
            this.LeftMoveButton.Location = new System.Drawing.Point(153, 179);
            this.LeftMoveButton.Name = "LeftMoveButton";
            this.LeftMoveButton.Size = new System.Drawing.Size(107, 32);
            this.LeftMoveButton.TabIndex = 11;
            this.LeftMoveButton.Text = "Влево";
            this.LeftMoveButton.UseVisualStyleBackColor = true;
            this.LeftMoveButton.Click += new System.EventHandler(this.LeftMoveButton_Click);
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ScheduleEditor";
            this.Text = "Управление расписанием";
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
        private System.Windows.Forms.Button checkAddIdButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddIdInput;
        private System.Windows.Forms.Button RemoveFilmButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button checkRemoveIdButton;
        private System.Windows.Forms.TextBox RemoveIdInput;
        private System.Windows.Forms.Button SaveSeqButton;
        private System.Windows.Forms.Button RightMoveButton;
        private System.Windows.Forms.Button LeftMoveButton;
        private System.Windows.Forms.ListBox NewFilmsList;
        private System.Windows.Forms.ListBox OldFilmsList;
    }
}