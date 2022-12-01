using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace frasesplit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static char[] splitchars = { ' ', '.', ',', '-', '+', '*', '/', '?', '!', '=', '~', '`', '\'', '\"','[',']','{','}', '(', ')', '_','&','^','%','$','#','@','!',',','<','.','>','/','\\',';',':','\n'};
        public static char[] vowelsarray = { 'a','e','i','o','u'};
        public static char[] consonantarray = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'x', 'z', 'y','w'};
        public static char[] cifers = { '0', '1', '2', '3', '4', '5', '6', '7', '8','9'};
        public static char[] punctuation = { ' ','.',',',':',';','?','!','-'};
        public static char[] operators = { '+', '-', '*', '/', '=', '<', '>'};
        public static char[] parantezis = { '(',')','[',']','{','}'};
        public static char[] simbols = {  '~', '`', '\'', '\"', '_', '&', '^', '%', '$', '#', '@',  '\\' };

        public int nroflines = 0;
        public int nrofemptylines = 0;

        public List<string> words = new List<string>();

        public int[] countofsplitchars = new int [splitchars.Length];

        public int nrofspaces = 0;
        public int nrofvowels = 0;
        public int nrofletters = 0;
        public int nrofconsonants = 0;
        public int nrofwords = 0;
        public int nrofchars = 0;
        public int nrofcifers = 0;
        public int nrofpunctuations = 0;
        public int nrofoperators = 0;
        public int nrofparantezis = 0;
        public int nrofsimbols = 0;

        public void countallcharsintextbox()
        {
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                nrofchars++;
            }
            Text = nrofchars.ToString();
        }

        public void initarraywithzero(ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = 0;
            }
        }

        public void printallarray(ref char [] c, ref int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                textBox2.Text += "\r\n" + c[i].ToString() + " " + a[i].ToString();
            }
        }


        public bool existinvector(char x, ref char [] a)
        {
            bool gasit = false;

            for(int i = 0 ;i < a.Length && gasit != true; i++)
            {
                if(a[i] == x){
                    countofsplitchars[i] += 1;
                    gasit = true;
                }
            }
            
            return gasit;
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            initarraywithzero(ref countofsplitchars);
        }

        public bool isFirstChar(int px) 
        {
            if(px==0){return true;}
             return false;
            
        }
        public bool isLastChar(int px, int lenmax)
        {
            if (px == lenmax) { return true; }
            return false;

        }

        public bool prevcharissplitchar(int xpx)
        {
            textBox1.Select(xpx, 1);
            char xv = Convert.ToChar(textBox1.SelectedText);
            if (existinvector(xv, ref splitchars) == true)
            {
                return true;
            }
            return false;
        }

        public bool nextcharissplitchar(int xpx)
        {
            textBox1.Select(xpx, 1);
            char xv = Convert.ToChar(textBox1.SelectedText);
            if (existinvector(xv, ref splitchars) == true)
            {
                return true;
            }
            return false;
        }

       
        private void splitFrazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int px = 0;
            int cx = 0;
            char v ;
            for(int i = 0 ; i < textBox1.Text.Length; i++)
            {
                px = cx;
                textBox1.Select(i,1);
                v = Convert.ToChar(textBox1.SelectedText);

                  if(existinvector(v ,ref splitchars )==true)
                  {
                    cx = i;
                  }

                //if is first
                  //isFirstChar(int px) 
                //if prevchar cx existainvector splitchar
                  //prevcharissplitchar(int xpx)
                //if nextchar cx+k existainvector splitchar
                  //nextcharissplitchar(int xpx)
                //if is last
                  //isLastChar(int px, int lenmax)

                textBox1.Select(px,cx-px);
                if (textBox1.SelectedText.Length >0)
                {
                    listBox1.Items.Add(textBox1.SelectedText);
                    words.Add(textBox1.SelectedText);
                }
                textBox1.Select(cx,1);
            }
            printallarray(ref splitchars, ref countofsplitchars);
        }

        private void countSpacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Spaces count = " + countofsplitchars[0].ToString();
        }

        private void countAllLettersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            countallcharsintextbox();
        }

        public void fcountofallslitshars(ref int [] a)
        {
            int sum = 0;
            for(int i = 0; i<a.Length ;i++){
                sum +=a[i];
            }
            Text = sum.ToString();
        }

        private void countAllSplitCharsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fcountofallslitshars(ref countofsplitchars);
        }

        private void countWordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Words = " + words.Count.ToString();
        }

        private void countNewLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Newlines count = " + countofsplitchars[countofsplitchars.Length-1].ToString();
        }

        private void countVowelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref vowelsarray) == true)
                {
                    nrofvowels++;
                }

            }
            Text = "Vowels = " + nrofvowels.ToString();
        }

        private void countConsonantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref consonantarray) == true)
                {
                    nrofconsonants++;
                }

            }
            Text = "Consonants = " + nrofconsonants.ToString();
        }

        private void countCifresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref cifers) == true)
                {
                    nrofcifers++;
                }

            }
            Text = "Cifers = " + nrofcifers.ToString();
        }

        private void countPunctuationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref punctuation) == true)
                {
                    nrofpunctuations++;
                }

            }
            Text = "Punctuations = " + nrofpunctuations.ToString();
        }

        private void countOperatorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref operators) == true)
                {
                    nrofoperators++;
                }

            }
            Text = "Operators = " + nrofoperators.ToString();
        }

        private void countParantezisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref parantezis) == true)
                {
                    nrofparantezis++;
                }

            }
            Text = "Parantezis = " + nrofparantezis.ToString();
        }

        private void countSimbolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            char v;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                textBox1.Select(i, 1);
                v = Convert.ToChar(textBox1.SelectedText);

                if (existinvector(v, ref simbols) == true)
                {
                   nrofsimbols++;
                }

            }
            Text = "Simbols = " + nrofsimbols.ToString();
        }

        private void countEmptyLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string v;
            nroflines = textBox1.Lines.Length;

            for (int i = 0; i < nroflines; i++)
            {

                v = textBox1.Lines[i];
                
                if (v.Length == 0)
                {

                    nrofemptylines++;
                }

            }
            Text = "No of Lines = " + nroflines.ToString();
            Text = "  No of Empty Lines = " + nrofemptylines.ToString();
        }
    }
}
