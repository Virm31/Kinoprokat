
namespace Kinoprokat
{
    partial class SessionsEditor
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
            this.filmGenre = new System.Windows.Forms.ComboBox();
            this.filmDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filmTitle = new System.Windows.Forms.TextBox();
            this.filmDuration = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RemoveIDList = new System.Windows.Forms.ComboBox();
            this.filmYear = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.filmYear);
            this.splitContainer1.Panel1.Controls.Add(this.filmGenre);
            this.splitContainer1.Panel1.Controls.Add(this.filmDesc);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.filmTitle);
            this.splitContainer1.Panel1.Controls.Add(this.filmDuration);
            this.splitContainer1.Panel1.Controls.Add(this.AddButton);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveButton);
            this.splitContainer1.Panel2.Controls.Add(this.RemoveIDList);
            this.splitContainer1.Size = new System.Drawing.Size(188, 580);
            this.splitContainer1.SplitterDistance = 390;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // filmGenre
            // 
            this.filmGenre.FormattingEnabled = true;
            this.filmGenre.Location = new System.Drawing.Point(19, 150);
            this.filmGenre.Name = "filmGenre";
            this.filmGenre.Size = new System.Drawing.Size(152, 21);
            this.filmGenre.TabIndex = 14;
            // 
            // filmDesc
            // 
            this.filmDesc.Location = new System.Drawing.Point(19, 248);
            this.filmDesc.Name = "filmDesc";
            this.filmDesc.Size = new System.Drawing.Size(152, 79);
            this.filmDesc.TabIndex = 13;
            this.filmDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Продолжительность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Жанр";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата релиза";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // filmTitle
            // 
            this.filmTitle.Location = new System.Drawing.Point(19, 45);
            this.filmTitle.Margin = new System.Windows.Forms.Padding(2);
            this.filmTitle.Name = "filmTitle";
            this.filmTitle.Size = new System.Drawing.Size(152, 20);
            this.filmTitle.TabIndex = 7;
            // 
            // filmDuration
            // 
            this.filmDuration.Location = new System.Drawing.Point(19, 203);
            this.filmDuration.Margin = new System.Windows.Forms.Padding(2);
            this.filmDuration.Name = "filmDuration";
            this.filmDuration.Size = new System.Drawing.Size(152, 20);
            this.filmDuration.TabIndex = 4;
            this.filmDuration.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.filmDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.filmDuration_KeyPress);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(40, 348);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(105, 27);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID фильма";
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(40, 128);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 27);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Удалить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RemoveIDList
            // 
            this.RemoveIDList.FormattingEnabled = true;
            this.RemoveIDList.Location = new System.Drawing.Point(19, 47);
            this.RemoveIDList.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveIDList.Name = "RemoveIDList";
            this.RemoveIDList.Size = new System.Drawing.Size(152, 21);
            this.RemoveIDList.TabIndex = 2;
            // 
            // filmYear
            // 
            this.filmYear.Location = new System.Drawing.Point(19, 95);
            this.filmYear.Name = "filmYear";
            this.filmYear.Size = new System.Drawing.Size(152, 20);
            this.filmYear.TabIndex = 15;
            // 
            // SessionsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 580);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SessionsEditor";
            this.Text = "Редактор";
            this.Load += new System.EventHandler(this.SessionsEditor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.ComboBox RemoveIDList;
        private System.Windows.Forms.TextBox filmDuration;
        private System.Windows.Forms.TextBox filmTitle;
        private System.Windows.Forms.RichTextBox filmDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox filmGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker filmYear;
    }
}