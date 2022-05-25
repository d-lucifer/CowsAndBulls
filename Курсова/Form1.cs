using System;
using System.Linq;
using System.Windows.Forms;

namespace Курсова
{
    public partial class Form1 : Form
    {
        private int cows;
        private int bull;
        private string rn;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            label1.Font.Size.Equals(20);
            label1.Text = "Загадане число";
            label1.Visible = true;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            button1.Enabled = false;

        }

        public void modePC(string userNum, string random)
        {
            rn = random;
            textBox1.Enabled = true;
            bool notWinner = true;
            string pcNum = Convert.ToString(rand.Next(1000, 9999)); // число пк конвертоване в тип string
            userNum = textBox1.Text;
            textBox2.Text = pcNum;
            checkBox2.Checked = true;
            char[] rNums = rn.ToCharArray(); //угадуване число
            char[] userGuess = userNum.ToCharArray(); //число гравця
            char[] pcGuess = pcNum.ToCharArray(); // число пк
            while (notWinner)
            {
                char[] result = new char[4];
                for (int i = 0; i < pcNum.Length; i++)// PC
                {
                    if (pcGuess[i] == rNums[i])//якщо відгадана правильна позиція
                    {
                        bull += 1;
                        result[i] = pcGuess[i];

                    }
                    else if (pcGuess.Contains(rNums[i]))
                    {
                        cows += 1;
                        result[i] = '*';
                    }
                    else
                    {
                        result[i] = '*';
                    }
                    richTextBox2.Text += Convert.ToString(result[i]);
                    if (i == 3)
                    {
                        richTextBox2.Text += "\n";
                    }
                }
                if (richTextBox2.Text == label1.Text) //Перевірка чи відповідь пк рівна загадоному числу
                {
                    labelpl2.Text = "Переможець!";
                    labelpl1.Text = "Програв!";
                    button1.Enabled = false;
                    notWinner = false;
                    label1.Visible = true;

                }
                else if (richTextBox1.Text == label1.Text)
                {
                    labelpl1.Text = "Переможець!";
                    labelpl2.Text = "Програв!";
                    button1.Enabled = false;
                    notWinner = false;
                    label1.Visible = true;
                }
                checkBox2.Text = "Биків " + bull + " , Корів " + cows;
                bull = 0;
                cows = 0;

                for (int i = 0; i < userNum.Length; i++)
                {
                    if (userGuess[i] == rNums[i])//якщо відгадана правильна позиція
                    {
                        bull += 1;
                        result[i] = userGuess[i];

                    }
                    else if (rNums.Contains(userGuess[i]))
                    {
                        cows += 1;
                        result[i] = '*';
                    }
                    else
                    {
                        result[i] = '*';
                    }
                    richTextBox1.Text += Convert.ToString(result[i]);
                    if (i == 3)
                    {
                        richTextBox1.Text += "\n";
                    }
                }
                if (textBox1.Text == rn) //Перевірка чи відповідь пк рівна загадоному числу
                {
                    labelpl1.Text = "Переможець!";
                    labelpl2.Text = "Програв!";
                    notWinner = false;
                    button1.Enabled = false;
                    label1.Visible = true;
                }
                else if (textBox2.Text == rn)
                {
                    labelpl1.Text = "Програв!";
                    labelpl2.Text = "Переможець!";
                    notWinner = false;
                    button1.Enabled = false;
                    label1.Visible = true;
                }//for

                checkBox1.Text = "Биків " + bull + " , Корів " + cows;
                notWinner = false;
                textBox1.Visible = true;
                richTextBox1.Visible = true;
            }//while 
            bull = 0;
            cows = 0;
            // labelpl1.Text = "Хід першого гравця!";
        }

        public void withFriend(string numUser1, string numUser2, string random)
        {
            if (textBox1.Text.Length < 4)
            {
                MessageBox.Show("Потрібно ввести 4-значчне число!");
            }
            rn = random;
            bool notWinner = true;
            numUser1 = textBox1.Text;
            numUser2 = textBox2.Text;

            char[] rNums = rn.ToCharArray(); //угадуване число
            char[] user1Guess = numUser1.ToCharArray(); //число гравця
            char[] user2Guess = numUser2.ToCharArray(); // число пк
            while (notWinner)
            {
                char[] result = new char[4];
                for (int i = 0; i < numUser1.Length; i++)// PC
                {

                    if (user1Guess[i] == rNums[i])//якщо відгадана правильна позиція
                    {
                        bull += 1;
                        result[i] = user1Guess[i];
                    }
                    else if (user1Guess.Contains(rNums[i]))
                    {
                        cows += 1;
                        result[i] = '*';
                    }
                    else
                    {
                        result[i] = '*';
                    }
                    richTextBox1.Text += Convert.ToString(result[i]);
                    if (i == 3)
                    {
                        richTextBox1.Text += "\n";
                    }

                }
                if (richTextBox1.Text == label1.Text) //Перевірка чи відповідь пк рівна загадоному числу
                {
                    labelpl1.Text = "Переможець!";
                    labelpl2.Text = "Програв!";
                    button1.Enabled = false;
                    notWinner = false;
                    label1.Visible = true;

                }
                else if (richTextBox2.Text == label1.Text)
                {
                    labelpl2.Text = "Переможець!";
                    labelpl1.Text = "Програв!";
                    button1.Enabled = false;
                    notWinner = false;
                    label1.Visible = true;
                }
                checkBox1.Text = "Биків " + bull + " , Корів " + cows;
                bull = 0;
                cows = 0;

                for (int i = 0; i < numUser2.Length; i++)
                {
                    if (user2Guess[i] == rNums[i])//якщо відгадана правильна позиція
                    {
                        bull += 1;
                        result[i] = user2Guess[i];

                    }
                    else if (rNums.Contains(user2Guess[i]))
                    {
                        cows += 1;
                        result[i] = '*';
                    }
                    else
                    {
                        result[i] = '*';
                    }
                    richTextBox2.Text += Convert.ToString(result[i]);
                    if (i == 3)
                    {
                        richTextBox2.Text += "\n";
                    }
                }
                if (textBox2.Text == rn) //Перевірка чи відповідь пк рівна загадоному числу
                {
                    labelpl2.Text = "Переможець!";
                    labelpl1.Text = "Програв!";
                    notWinner = false;
                    button1.Enabled = false;
                    label1.Visible = true;
                }
                else if (textBox1.Text == rn)
                {
                    labelpl2.Text = "Програв!";
                    labelpl1.Text = "Переможець!";
                    notWinner = false;
                    button1.Enabled = false;
                    label1.Visible = true;
                }

                checkBox2.Text = "Биків " + bull + " , Корів " + cows;
                notWinner = false;
                textBox1.Visible = true;
                richTextBox1.Visible = true;
            }
            bull = 0;
            cows = 0;
            textBox1.Enabled = true;
        }


        private void зДругомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelpl2.Text = "Гравець 2";

            textBox1.Visible = true;


        }
        private void withPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelpl2.Text = "Комп'ютер";
            textBox2.Enabled = false;
            richTextBox2.Visible = false;
            label1.Visible = false;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            richTextBox1.Visible = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (labelpl2.Text == "Комп'ютер")
            {
                modePC(textBox1.Text, label1.Text);
            }
            else if (labelpl2.Text == "Гравець 2")
            {
                withFriend(textBox1.Text, textBox2.Text, label1.Text);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 4)
            {
                checkBox1.Checked = true;
                textBox1.Visible = false;
                richTextBox1.Visible = false;
                textBox2.Visible = true;
                richTextBox2.Visible = true;
                checkBox2.Checked = false;
                labelpl1.Text = "Хід другого гравця!";
                if (labelpl2.Text == "Комп'ютер")
                {
                    richTextBox2.Visible = false;
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 4)
            {
                checkBox2.Checked = true;
                checkBox1.Checked = true;
                labelpl1.Text = "Хід першого гравця!";
            }
            if (checkBox2.Checked == true)
            {
                textBox2.Visible = false;
                richTextBox2.Visible = false;
                textBox1.Visible = false;
                richTextBox1.Visible = false;
            }
        }
        private void новаГраToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            richTextBox1.Text = " ";
            richTextBox2.Text = " ";
            textBox1.Text = " ";
            textBox2.Text = " ";
            labelpl1.Text = "Гравець 1";
            labelpl2.Text = "Гравець 2";
            checkBox1.Checked = false;
            checkBox1.Text = " ";
            checkBox2.Text = " ";
            checkBox2.Checked = false;
        }

        private void початиГруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(rand.Next(1000, 9999));
            labelpl1.Text = "Хід першого гравця!";
            label1.Visible = false;
            textBox2.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;
            button1.Enabled = true;
        }
    }
}
