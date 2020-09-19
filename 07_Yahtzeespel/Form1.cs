using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace _07_Yahtzeespel
{
    public partial class Form1 : Form
    {
        Bitmap[] ImgArray = new Bitmap[6];
        bool[] Selected_Dice = { true, true, true, true, true };
        int[] Dice_Values = { 0, 0, 0, 0, 0 };
        int Rolls = 0;

        public Form1()
        {
            InitializeComponent();
            Load_Images();
            Load_Dice();
        }

        private void Load_Images()
        {
            for (int i = 1; i <= 6; i++)
                ImgArray[i - 1] = new Bitmap(@$".\img\{i}.png");
        }

        private void Load_Dice()
        {
            PictureBox[] all_dice = { Die1, Die2, Die3, Die4, Die5 };

            for (int i = 0; i < 5; i++)
            {
                all_dice[i].Image = ImgArray[i];
                Dice_Values[i] = i + 1;
            }

            Rolls = 0;
            Lbl_Rolls.Text = Rolls.ToString();
        }

        private void Select_Die(int element)
        {
            Selected_Dice[element] = !Selected_Dice[element];
        }

        private void Roll_Dice(bool[] dice)
        {
            PictureBox[] all_dice = { Die1, Die2, Die3, Die4, Die5 };
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                if (dice[i])
                {
                    int value = rnd.Next(0, 6);
                    all_dice[i].Image = ImgArray[value];
                    Dice_Values[i] = value + 1;
                }
            }

        }

        private void Score()
        {
            Array.Sort(Dice_Values);
            int[] cnt = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < Dice_Values.Length; i++)
            {
                for (int j = 0; j < Dice_Values.Length; j++)
                    if (Dice_Values[j] == i + 1)
                    {
                        cnt[i] += 1;
                    }
            }

            foreach (int i in cnt) { Console.Write(i); }                    // print
            Console.WriteLine("");

            foreach (int i in Dice_Values)
                Console.Write($"| {i} | ");
            Console.WriteLine("");

            if (Dice_Values.All(element => element == Dice_Values[0]))      // Check Yahtzee
                Console.Write($"|YAHTZEE|\n");

            string tempstring = "";                                         // check big street
            foreach (char chr in cnt) { tempstring += (char)(chr + 48); }

            if (tempstring == "111110" || tempstring == "011111")           
                Console.Write("street");

            //else if (tempstring[0] != 0 && tempstring[1] != 0 && tempstring[2] != 0 )

            int j = 0;
            if (tempstring[j] != 0 && tempstring[j + 1] != 0 && tempstring[j + 2] != 0)
                        Console.Write("test");
        }

        private void Btn_RollDie_Click(object sender, EventArgs e)
        {
            if (Rolls < 20)
            {
                Roll_Dice(Selected_Dice);
                Rolls += 1;
                Lbl_Rolls.Text = Rolls.ToString();
            }
            else
            {
                Score();
            }

        }

        private void Btn_Die_Click(object sender, EventArgs e)
        {
            PictureBox tempbox = (PictureBox)sender;
            
            int selected = tempbox.Name.ToCharArray().Last() - 49;
            Select_Die(selected);

            Console.WriteLine($"{Dice_Values[selected]} - {Selected_Dice[selected]}");
        }
    }
}