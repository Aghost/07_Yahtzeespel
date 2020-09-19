using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Yahtzeespel
{
    public partial class Form1 : Form
    {
        public Bitmap[] ImgArray = new Bitmap[6];
        public int[] Selected_Dice = { 1, 1, 1, 1, 1 };
        public int[] Dice_Values = { 0, 0, 0, 0, 0 };

        public Form1()
        {
            InitializeComponent();
            Load_Images();
            Load_Dice();
        }

        private void Load_Images()
        {
            for (int i = 1; i <= 6; i++)
            {
                ImgArray[i - 1] = new Bitmap(@$".\img\{i}.png");
            }
        }

        private void Load_Dice()
        {
            PictureBox[] all_dice = { Die1, Die2, Die3, Die4, Die5 };

            for (int i = 0; i < 5; i++)
            {
                all_dice[i].Image = ImgArray[i];
                Dice_Values[i] = i + 1;
            }
        }

        private void Select_Die(int element) // 1 - 5
        {
            if (Selected_Dice[element] == 0) {
                Selected_Dice[element] = 1;
            } else {
                Selected_Dice[element] = 0;
            }
        }

        private void Roll_Dice(int[] dice)
        {
            PictureBox[] all_dice = { Die1, Die2, Die3, Die4, Die5 };
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                if (dice[i] == 1)
                {
                    int value = rnd.Next(0, 6);
                    all_dice[i].Image = ImgArray[value];
                    Dice_Values[i] = value + 1;
                }

                Console.WriteLine(Selected_Dice[i]);
            }
        }

        private void Btn_RollDie_Click(object sender, EventArgs e)
        {
            Roll_Dice(Selected_Dice);
        }

        private void Btn_Die_Click(object sender, EventArgs e)
        {
            PictureBox tempbox = (PictureBox)sender;
            
            int selected = tempbox.Name.ToCharArray().Last() - 49;

            Console.WriteLine(Dice_Values[selected]);
            Console.WriteLine(Selected_Dice[selected]);

            Select_Die(selected);
        }
    }
}
