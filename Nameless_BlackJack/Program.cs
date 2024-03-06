using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Riley_Nameless_BlackJack3
{
    public partial class Form1 : Form
    {
        Card[] CardArray = new Card[52];

        public void CreatCards() 
        {
            Card card1 = new Card(10, @"Cards/10_of_clubs.png");
            Card card2 = new Card(10, @"Cards/10_of_diamonds.png"); 
            Card card3 = new Card(10, @"Cards/10_of_hearts.png");
            Card card4 = new Card(10, @"Cards/10_of_spades.png");

            Card card5 = new Card(2, @"Cards/2_of_clubs.png");
            Card card6 = new Card(2, @"Cards/2_of_diamonds.png");   
            Card card7 = new Card(2, @"Cards/2_of_hearts.png");
            Card card8 = new Card(2, @"Cards/2_of_spades.png");

            Card card9 = new Card(3, @"Cards/3_of_clubs.png");
            Card card10 = new Card(3, @"Cards/3_of_diamonds.png");
            Card card11 = new Card(3, @"Cards/3_of_hearts.png");
            Card card12 = new Card(3, @"Cards/3_of_spades.png");

            Card card13 = new Card(4, @"Cards/4_of_clubs.png");
            Card card14 = new Card(4, @"Cards/4_of_diamonds.png");
            Card card15 = new Card(4, @"Cards/4_of_hearts.png");
            Card card16 = new Card(4, @"Cards/4_of_spades.png");

            Card card17 = new Card(5, @"Cards/5_of_clubs.png");
            Card card18 = new Card(5, @"Cards/5_of_diamonds.png");
            Card card19 = new Card(5, @"Cards/5_of_hearts.png");
            Card card20 = new Card(5, @"Cards/5_of_spades.png");

            Card card21 = new Card(6, @"Cards/6_of_clubs.png");
            Card card22 = new Card(6, @"Cards/6_of_diamonds.png");
            Card card23 = new Card(6, @"Cards/6_of_hearts.png");
            Card card24 = new Card(6, @"Cards/6_of_spades.png");

            Card card25 = new Card(7, @"Cards/7_of_clubs.png");
            Card card26 = new Card(7, @"Cards/7_of_diamonds.png");
            Card card27 = new Card(7, @"Cards/7_of_hearts.png");
            Card card28 = new Card(7, @"Cards/7_of_spades.png");

            Card card29 = new Card(8, @"Cards/8_of_clubs.png");
            Card card30 = new Card(8, @"Cards/8_of_diamonds.png");
            Card card31 = new Card(8, @"Cards/8_of_hearts.png");
            Card card32 = new Card(8, @"Cards/8_of_spades.png");

            Card card33 = new Card(9, @"Cards/9_of_clubs.png");
            Card card34 = new Card(9, @"Cards/9_of_diamonds.png");
            Card card35 = new Card(9, @"Cards/9_of_hearts.png");
            Card card36 = new Card(9, @"Cards/9_of_spades.png");

            Card card37 = new Card(11, @"Cards/ace_of_clubs.png");
            Card card38 = new Card(11, @"Cards/ace_of_diamonds.png");
            Card card39 = new Card(11, @"Cards/ace_of_hearts.png");
            Card card40 = new Card(11, @"Cards/ace_of_spades.png");

            Card card41 = new Card(10, @"Cards/jack_of_clubs.png");
            Card card42 = new Card(10, @"Cards/jack_of_diamonds.png");
            Card card43 = new Card(10, @"Cards/jack_of_hearts.png");
            Card card44 = new Card(10, @"Cards/jack_of_spades.png");

            Card card45 = new Card(10, @"Cards/queen_of_clubs.png");
            Card card46 = new Card(10, @"Cards/queen_of_diamonds.png");
            Card card47 = new Card(10, @"Cards/queen_of_hearts.png");
            Card card48 = new Card(10, @"Cards/queen_of_spades.png");

            Card card49 = new Card(10, @"Cards/king_of_clubs.png");
            Card card50 = new Card(10, @"Cards/king_of_diamonds.png");
            Card card51 = new Card(10, @"Cards/king_of_hearts.png");
            Card card52 = new Card(10, @"Cards/king_of_spades.png");

            CardArray[0] = card1;
            CardArray[1] = card2;
            CardArray[2] = card3;
            CardArray[3] = card4;
            CardArray[4] = card5;
            CardArray[5] = card6;
            CardArray[6] = card7;
            CardArray[7] = card8;
            CardArray[8] = card9;
            CardArray[9] = card10;
            CardArray[10] = card11;
            CardArray[11] = card12;
            CardArray[12] = card13;
            CardArray[13] = card14;
            CardArray[14] = card15;
            CardArray[15] = card16;
            CardArray[16] = card17;
            CardArray[17] = card18;
            CardArray[18] = card19;
            CardArray[19] = card20;
            CardArray[20] = card21;
            CardArray[21] = card22;
            CardArray[22] = card23;
            CardArray[23] = card24;
            CardArray[24] = card25;
            CardArray[25] = card26;
            CardArray[26] = card27;
            CardArray[27] = card28;
            CardArray[28] = card29;
            CardArray[29] = card30;
            CardArray[30] = card31;
            CardArray[31] = card32;
            CardArray[32] = card33;
            CardArray[33] = card34;
            CardArray[34] = card35;
            CardArray[35] = card36;
            CardArray[36] = card37;
            CardArray[37] = card38;
            CardArray[38] = card39;
            CardArray[39] = card40;
            CardArray[40] = card41;
            CardArray[41] = card42;
            CardArray[42] = card43;
            CardArray[43] = card44;
            CardArray[44] = card45;
            CardArray[45] = card46;
            CardArray[46] = card47;
            CardArray[47] = card48;
            CardArray[48] = card49;
            CardArray[49] = card50;
            CardArray[50] = card51;
            CardArray[51] = card52;



        }

        public Form1()
        {
            InitializeComponent();
        }
        int i;
        private void btnDeal_Click(object sender, EventArgs e)
        {
            if (i > 51) 
            {
                label1.Text = "No more cards";
            }
            else 
            {
                Image Img = Image.FromFile(CardArray[i].ImagePath);
                pictureBox1.Image = Img;
                label1.Text = CardArray[i].PointValue.ToString();
                i++;
            }
            
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            i = 0;
        }
    }
}
