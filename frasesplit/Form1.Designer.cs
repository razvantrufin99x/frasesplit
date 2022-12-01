namespace frasesplit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.splitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitFrazeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countNewLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countTabSpacesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countVowelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countConsonantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countWordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countCifresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countNumbersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countOperatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countPunctuationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSplitCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countAllLettersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countAllSplitCharsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countParantezisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countSimbolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.countEmptyLinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 38);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(414, 381);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // splitToolStripMenuItem
            // 
            this.splitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.splitFrazeToolStripMenuItem,
            this.countSpacesToolStripMenuItem,
            this.countNewLinesToolStripMenuItem,
            this.countTabSpacesToolStripMenuItem,
            this.countVowelsToolStripMenuItem,
            this.countConsonantsToolStripMenuItem,
            this.countWordsToolStripMenuItem,
            this.countCifresToolStripMenuItem,
            this.countNumbersToolStripMenuItem,
            this.countOperatorsToolStripMenuItem,
            this.countPunctuationToolStripMenuItem,
            this.countSplitCharsToolStripMenuItem,
            this.countAllLettersToolStripMenuItem,
            this.countAllSplitCharsToolStripMenuItem,
            this.countParantezisToolStripMenuItem,
            this.countSimbolsToolStripMenuItem,
            this.countEmptyLinesToolStripMenuItem});
            this.splitToolStripMenuItem.Name = "splitToolStripMenuItem";
            this.splitToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.splitToolStripMenuItem.Text = "Text Operations";
            // 
            // splitFrazeToolStripMenuItem
            // 
            this.splitFrazeToolStripMenuItem.Name = "splitFrazeToolStripMenuItem";
            this.splitFrazeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.splitFrazeToolStripMenuItem.Text = "Split Fraze";
            this.splitFrazeToolStripMenuItem.Click += new System.EventHandler(this.splitFrazeToolStripMenuItem_Click);
            // 
            // countSpacesToolStripMenuItem
            // 
            this.countSpacesToolStripMenuItem.Name = "countSpacesToolStripMenuItem";
            this.countSpacesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countSpacesToolStripMenuItem.Text = "Count Spaces";
            this.countSpacesToolStripMenuItem.Click += new System.EventHandler(this.countSpacesToolStripMenuItem_Click);
            // 
            // countNewLinesToolStripMenuItem
            // 
            this.countNewLinesToolStripMenuItem.Name = "countNewLinesToolStripMenuItem";
            this.countNewLinesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countNewLinesToolStripMenuItem.Text = "Count NewLines";
            this.countNewLinesToolStripMenuItem.Click += new System.EventHandler(this.countNewLinesToolStripMenuItem_Click);
            // 
            // countTabSpacesToolStripMenuItem
            // 
            this.countTabSpacesToolStripMenuItem.Name = "countTabSpacesToolStripMenuItem";
            this.countTabSpacesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countTabSpacesToolStripMenuItem.Text = "Count TabSpaces";
            // 
            // countVowelsToolStripMenuItem
            // 
            this.countVowelsToolStripMenuItem.Name = "countVowelsToolStripMenuItem";
            this.countVowelsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countVowelsToolStripMenuItem.Text = "Count Vowels";
            this.countVowelsToolStripMenuItem.Click += new System.EventHandler(this.countVowelsToolStripMenuItem_Click);
            // 
            // countConsonantsToolStripMenuItem
            // 
            this.countConsonantsToolStripMenuItem.Name = "countConsonantsToolStripMenuItem";
            this.countConsonantsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countConsonantsToolStripMenuItem.Text = "Count Consonants";
            this.countConsonantsToolStripMenuItem.Click += new System.EventHandler(this.countConsonantsToolStripMenuItem_Click);
            // 
            // countWordsToolStripMenuItem
            // 
            this.countWordsToolStripMenuItem.Name = "countWordsToolStripMenuItem";
            this.countWordsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countWordsToolStripMenuItem.Text = "Count Words";
            this.countWordsToolStripMenuItem.Click += new System.EventHandler(this.countWordsToolStripMenuItem_Click);
            // 
            // countCifresToolStripMenuItem
            // 
            this.countCifresToolStripMenuItem.Name = "countCifresToolStripMenuItem";
            this.countCifresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countCifresToolStripMenuItem.Text = "Count Cifres";
            this.countCifresToolStripMenuItem.Click += new System.EventHandler(this.countCifresToolStripMenuItem_Click);
            // 
            // countNumbersToolStripMenuItem
            // 
            this.countNumbersToolStripMenuItem.Name = "countNumbersToolStripMenuItem";
            this.countNumbersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countNumbersToolStripMenuItem.Text = "Count Numbers";
            // 
            // countOperatorsToolStripMenuItem
            // 
            this.countOperatorsToolStripMenuItem.Name = "countOperatorsToolStripMenuItem";
            this.countOperatorsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countOperatorsToolStripMenuItem.Text = "Count Operators";
            this.countOperatorsToolStripMenuItem.Click += new System.EventHandler(this.countOperatorsToolStripMenuItem_Click);
            // 
            // countPunctuationToolStripMenuItem
            // 
            this.countPunctuationToolStripMenuItem.Name = "countPunctuationToolStripMenuItem";
            this.countPunctuationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countPunctuationToolStripMenuItem.Text = "Count Punctuation";
            this.countPunctuationToolStripMenuItem.Click += new System.EventHandler(this.countPunctuationToolStripMenuItem_Click);
            // 
            // countSplitCharsToolStripMenuItem
            // 
            this.countSplitCharsToolStripMenuItem.Name = "countSplitCharsToolStripMenuItem";
            this.countSplitCharsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countSplitCharsToolStripMenuItem.Text = "Count Split Chars";
            // 
            // countAllLettersToolStripMenuItem
            // 
            this.countAllLettersToolStripMenuItem.Name = "countAllLettersToolStripMenuItem";
            this.countAllLettersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countAllLettersToolStripMenuItem.Text = "Count all Letters";
            this.countAllLettersToolStripMenuItem.Click += new System.EventHandler(this.countAllLettersToolStripMenuItem_Click);
            // 
            // countAllSplitCharsToolStripMenuItem
            // 
            this.countAllSplitCharsToolStripMenuItem.Name = "countAllSplitCharsToolStripMenuItem";
            this.countAllSplitCharsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countAllSplitCharsToolStripMenuItem.Text = "Count All Split Chars";
            this.countAllSplitCharsToolStripMenuItem.Click += new System.EventHandler(this.countAllSplitCharsToolStripMenuItem_Click);
            // 
            // countParantezisToolStripMenuItem
            // 
            this.countParantezisToolStripMenuItem.Name = "countParantezisToolStripMenuItem";
            this.countParantezisToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countParantezisToolStripMenuItem.Text = "Count Parantezis";
            this.countParantezisToolStripMenuItem.Click += new System.EventHandler(this.countParantezisToolStripMenuItem_Click);
            // 
            // countSimbolsToolStripMenuItem
            // 
            this.countSimbolsToolStripMenuItem.Name = "countSimbolsToolStripMenuItem";
            this.countSimbolsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countSimbolsToolStripMenuItem.Text = "Count Simbols";
            this.countSimbolsToolStripMenuItem.Click += new System.EventHandler(this.countSimbolsToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(432, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 147);
            this.listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(433, 192);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 227);
            this.textBox2.TabIndex = 3;
            // 
            // countEmptyLinesToolStripMenuItem
            // 
            this.countEmptyLinesToolStripMenuItem.Name = "countEmptyLinesToolStripMenuItem";
            this.countEmptyLinesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.countEmptyLinesToolStripMenuItem.Text = "Count empty lines";
            this.countEmptyLinesToolStripMenuItem.Click += new System.EventHandler(this.countEmptyLinesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 446);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "String operations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem splitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem splitFrazeToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem countSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countNewLinesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countTabSpacesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countVowelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countConsonantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countWordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countCifresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countNumbersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countOperatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countPunctuationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countSplitCharsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ToolStripMenuItem countAllLettersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countAllSplitCharsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countParantezisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countSimbolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countEmptyLinesToolStripMenuItem;
    }
}

