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
            for (int i = 0; i < 6; i++)
                ImgArray[i] = new Bitmap(@$".\img\{i + 1}.png");
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

        private void Roll_Dice(bool[] dice)
        {
            PictureBox[] all_dice = { Die1, Die2, Die3, Die4, Die5 };
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
                if (dice[i])
                {
                    int value = rnd.Next(0, 6);
                    all_dice[i].Image = ImgArray[value];
                    Dice_Values[i] = value + 1;
                }
        }

        private void Score()
        {
            Array.Sort(Dice_Values);
            int[] cnt = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i <= Dice_Values.Length; i++)                   // int[] for dice values 
                for (int j = 0; j < Dice_Values.Length; j++)
                    if (Dice_Values[j] == i + 1)
                        cnt[i] += 1;

            if (cnt.Any(e => e == 5))                                       // yahtzee
                Console.WriteLine("YAHTZEE");
            else if (cnt.Any(e => e == 4))                                  // 4 of a kind
                Console.WriteLine("4 OF A KIND");
            else if (cnt.Any(e => e == 3) && cnt.Any(e => e == 2))          // full house
                Console.WriteLine("FULL HOUSE");
            else if ((cnt[0] == 0 || cnt[5] == 0) && cnt.All(e => e <= 1))    // streets
                Console.Write("BIG STREET");
            else
                for (int i = 0; i < 4; i++)
                    if (cnt[i] != 0 && cnt[i + 1] != 0 && cnt[i + 2] != 0 && cnt[i + 3] != 0)
                        Console.Write("SMALL STREET");
        }

        private void Btn_RollDie_Click(object sender, EventArgs e)
        {
            if (Rolls < 20) {
                Roll_Dice(Selected_Dice);
                Rolls++;
                Lbl_Rolls.Text = Rolls.ToString();
            } else
                Score();
        }

        private void Btn_Die_Click(object sender, EventArgs e)
        {
            PictureBox tempbox = (PictureBox)sender;
            
            int selected = tempbox.Name.ToCharArray().Last() - 49;
            Selected_Dice[selected] = !Selected_Dice[selected];

            tempbox.Cursor = Cursors.Default;

            Console.WriteLine($"{Dice_Values[selected]} - {Selected_Dice[selected]}");
        }
    }
}