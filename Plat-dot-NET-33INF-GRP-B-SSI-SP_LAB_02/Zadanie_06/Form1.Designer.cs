namespace Zadanie_06
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
            buttonAdd = new Button();
            buttonSearch = new Button();
            buttonSortByName = new Button();
            buttonSortByDOB = new Button();
            listViewContacts = new ListView();
            textBoxSearch = new TextBox();
            dateTimePickerDOB = new DateTimePicker();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ActiveCaption;
            buttonAdd.Font = new Font("Yu Gothic", 12F);
            buttonAdd.Location = new Point(32, 96);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(140, 34);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSearch
            // 
            buttonSearch.Font = new Font("Yu Gothic", 12F);
            buttonSearch.Location = new Point(30, 199);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(140, 35);
            buttonSearch.TabIndex = 2;
            buttonSearch.Text = "Wyszukaj";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonSortByName
            // 
            buttonSortByName.Font = new Font("Yu Gothic", 12F);
            buttonSortByName.Location = new Point(30, 280);
            buttonSortByName.Name = "buttonSortByName";
            buttonSortByName.Size = new Size(302, 36);
            buttonSortByName.TabIndex = 3;
            buttonSortByName.Text = "Sortuj przez imie (A-Z)";
            buttonSortByName.UseVisualStyleBackColor = true;
            buttonSortByName.Click += buttonSortByName_Click;
            // 
            // buttonSortByDOB
            // 
            buttonSortByDOB.Font = new Font("Yu Gothic", 12F);
            buttonSortByDOB.Location = new Point(30, 364);
            buttonSortByDOB.Name = "buttonSortByDOB";
            buttonSortByDOB.Size = new Size(302, 34);
            buttonSortByDOB.TabIndex = 4;
            buttonSortByDOB.Text = "Sortuj przez date (najnowsze)";
            buttonSortByDOB.UseVisualStyleBackColor = true;
            buttonSortByDOB.Click += buttonSortByDOB_Click;
            // 
            // listViewContacts
            // 
            listViewContacts.Font = new Font("Yu Gothic", 12F);
            listViewContacts.Location = new Point(399, 50);
            listViewContacts.Name = "listViewContacts";
            listViewContacts.Size = new Size(344, 394);
            listViewContacts.TabIndex = 5;
            listViewContacts.UseCompatibleStateImageBehavior = false;
            listViewContacts.SelectedIndexChanged += listViewContacts_SelectedIndexChanged;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Font = new Font("Yu Gothic", 12F);
            textBoxSearch.Location = new Point(30, 153);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(255, 40);
            textBoxSearch.TabIndex = 6;
            // 
            // dateTimePickerDOB
            // 
            dateTimePickerDOB.Font = new Font("Yu Gothic", 12F);
            dateTimePickerDOB.Location = new Point(32, 404);
            dateTimePickerDOB.Name = "dateTimePickerDOB";
            dateTimePickerDOB.Size = new Size(300, 40);
            dateTimePickerDOB.TabIndex = 7;
            dateTimePickerDOB.ValueChanged += dateTimePickerDOB_ValueChanged;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Yu Gothic", 12F);
            textBoxName.Location = new Point(32, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(255, 40);
            textBoxName.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 484);
            Controls.Add(textBoxName);
            Controls.Add(dateTimePickerDOB);
            Controls.Add(textBoxSearch);
            Controls.Add(listViewContacts);
            Controls.Add(buttonSortByDOB);
            Controls.Add(buttonSortByName);
            Controls.Add(buttonSearch);
            Controls.Add(buttonAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAdd;
        private Button buttonSearch;
        private Button buttonSortByName;
        private Button buttonSortByDOB;
        private ListView listViewContacts;
        private TextBox textBoxSearch;
        private DateTimePicker dateTimePickerDOB;
        private TextBox textBoxName;
    }
}
