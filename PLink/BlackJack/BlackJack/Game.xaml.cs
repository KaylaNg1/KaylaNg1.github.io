using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        private int count;
        private int computerCount;
        private int hit;
        private String cards;
        private String[] deck;
        private String[] newDeck;
        private Image[] cardImages;
        private Image[] cardImages2;
        private Image[] cardImages3;
        private Image[] cardImages4;
        private Image[] cardImages5;
        private Image[] cardImages6;
        private Image[] computerCardImages;
        private Image[] computerCardImages2;
        private Image[] computerCardImages3;
        private Image[] computerCardImages4;
        private Image[] computerCardImages5;
        private Image[] computerCardImages6;
        private int imageIndex;
        private int computerimageIndex;
        private int blackJack10;
        private int compBlackJack10;
        private Boolean faceCard;
        private Boolean compFaceCard;
        private int blackJack102;
        private Boolean faceCard2;
        private Boolean compFaceCard2;
        private int compBlackJack102;
        private Boolean cardAce;
        private Boolean cardAce2;
        private Boolean compCardAce;
        private Boolean compCardAce2;

        public Game()
        {
            InitializeComponent();
            count = 0;
            compCardAce = false;
            compCardAce2=false;
            cardAce = false;
            cardAce2 = false;
            blackJack10 = 0;
            faceCard = false;
            blackJack102 = 0;
            faceCard2 = false;
            compBlackJack10 = 0;
            compFaceCard = false;
            compBlackJack102 = 0;
            compFaceCard2 = false;
            CardBtn2.IsEnabled = false;
            Hitbtn.IsEnabled = false;
            ComputerBtn.IsEnabled = false;
            RestartBtn.IsEnabled = false;
            FoldBtn.IsEnabled = false;
            TwoOfDiamonds.Visibility = Visibility.Hidden;
            ThreeOfDiamonds.Visibility = Visibility.Visible;
            Val1.Visibility = Visibility.Hidden;
            Val2.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
            imageIndex = 0;
            computerimageIndex = 0;
            hit = 0;
            cards = "";
            computerCount = 0;

            deck = new String[52];
            newDeck = new String[deck.Length];
            int index = 0;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    if (i == 1)
                    {
                        deck[index] = j + " of diamonds";
                    }
                    else if (i == 2)
                    {
                        deck[index] = j + " of hearts";
                    }
                    else if (i == 3)
                    {
                        deck[index] = j + " of clubs";
                    }
                    else
                    {
                        deck[index] = j + " of spades";
                    }
                    index++;
                }
            }
            
            /*for (int i = 1; i <= 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    if (i == 1)
                    {
                        deck[index] = 14 + " of diamonds";
                    }
                    else if (i == 2)
                    {
                        deck[index] = 11 + " of hearts";
                    }
                    else if (i == 3)
                    {
                        deck[index] = 14 + " of clubs";
                    }
                    else
                    {
                        deck[index] = 11 + " of spades";
                    }
                    index++;
                }
                
            }
            */
            cardImages= new Image[]{ TwoOfDiamonds, ThreeOfDiamonds, FourOfDiamonds, FiveOfDiamonds, SixOfDiamonds, SevenOfDiamonds, EightOfDiamonds, NineOfDiamonds, TenOfDiamonds, JackOfDiamonds, QueenOfDiamonds, KingOfDiamonds, AceOfDiamonds
            , TwoOfHearts, ThreeOfHearts, FourOfHearts, FiveOfHearts, SixOfHearts, SevenOfHearts, EightOfHearts, NineOfHearts, TenOfHearts, JackOfHearts, QueenOfHearts, KingOfHearts, AceOfHearts
            , TwoOfClubs, ThreeOfClubs, FourOfClubs, FiveOfClubs, SixOfClubs, SevenOfClubs, EightOfClubs, NineOfClubs, TenOfCLubs, JackOfClubs, QueenOfClubs, KingOfClubs, AceOfClubs
            , TwoOfSpades, ThreeOfSpades, FourOfSpades, FiveOfSpades, SixOfSpades, SevenOfSpades, EightOfSpades, NineOfSpades, TenOfSpades, JackOfSpades, QueenOfSpades, KingOfSpades, AceOfSpades};

            cardImages2 = new Image[]{ TwoOfDiamonds_Copy, ThreeOfDiamonds_Copy, FourOfDiamonds_Copy, FiveOfDiamonds_Copy, SixOfDiamonds_Copy, SevenOfDiamonds_Copy, EightOfDiamonds_Copy, NineOfDiamonds_Copy, TenOfDiamonds_Copy, JackOfDiamonds_Copy, QueenOfDiamonds_Copy, KingOfDiamonds_Copy, AceOfDiamonds_Copy
            , TwoOfHearts_Copy, ThreeOfHearts_Copy, FourOfHearts_Copy, FiveOfHearts_Copy, SixOfHearts_Copy, SevenOfHearts_Copy, EightOfHearts_Copy, NineOfHearts_Copy, TenOfHearts_Copy, JackOfHearts_Copy, QueenOfHearts_Copy, KingOfHearts_Copy, AceOfHearts_Copy
            , TwoOfClubs_Copy, ThreeOfClubs_Copy, FourOfClubs_Copy, FiveOfClubs_Copy, SixOfClubs_Copy, SevenOfClubs_Copy, EightOfClubs_Copy, NineOfClubs_Copy, TenOfCLubs_Copy, JackOfClubs_Copy, QueenOfClubs_Copy, KingOfClubs_Copy, AceOfClubs_Copy
            , TwoOfSpades_Copy, ThreeOfSpades_Copy, FourOfSpades_Copy, FiveOfSpades_Copy, SixOfSpades_Copy, SevenOfSpades_Copy, EightOfSpades_Copy, NineOfSpades_Copy, TenOfSpades_Copy, JackOfSpades_Copy, QueenOfSpades_Copy, KingOfSpades_Copy, AceOfSpades_Copy};

            cardImages3 = new Image[]{ TwoOfDiamonds_Copy3, ThreeOfDiamonds_Copy3, FourOfDiamonds_Copy3, FiveOfDiamonds_Copy3, SixOfDiamonds_Copy3, SevenOfDiamonds_Copy3, EightOfDiamonds_Copy3, NineOfDiamonds_Copy3, TenOfDiamonds_Copy3, JackOfDiamonds_Copy3, QueenOfDiamonds_Copy3, KingOfDiamonds_Copy3, AceOfDiamonds_Copy3
            , TwoOfHearts_Copy3, ThreeOfHearts_Copy3, FourOfHearts_Copy3, FiveOfHearts_Copy3, SixOfHearts_Copy3, SevenOfHearts_Copy3, EightOfHearts_Copy3, NineOfHearts_Copy3, TenOfHearts_Copy3, JackOfHearts_Copy3, QueenOfHearts_Copy3, KingOfHearts_Copy3, AceOfHearts_Copy3
            , TwoOfClubs_Copy3, ThreeOfClubs_Copy3, FourOfClubs_Copy3, FiveOfClubs_Copy3, SixOfClubs_Copy3, SevenOfClubs_Copy3, EightOfClubs_Copy3, NineOfClubs_Copy3, TenOfCLubs_Copy3, JackOfClubs_Copy3, QueenOfClubs_Copy3, KingOfClubs_Copy3, AceOfClubs_Copy3
            , TwoOfSpades_Copy3, ThreeOfSpades_Copy3, FourOfSpades_Copy3, FiveOfSpades_Copy3, SixOfSpades_Copy3, SevenOfSpades_Copy3, EightOfSpades_Copy3, NineOfSpades_Copy3, TenOfSpades_Copy3, JackOfSpades_Copy3, QueenOfSpades_Copy3, KingOfSpades_Copy3, AceOfSpades_Copy3};

            cardImages4 = new Image[]{ TwoOfDiamonds_Copy1, ThreeOfDiamonds_Copy1, FourOfDiamonds_Copy1, FiveOfDiamonds_Copy1, SixOfDiamonds_Copy1, SevenOfDiamonds_Copy1, EightOfDiamonds_Copy1, NineOfDiamonds_Copy1, TenOfDiamonds_Copy1, JackOfDiamonds_Copy1, QueenOfDiamonds_Copy1, KingOfDiamonds_Copy1, AceOfDiamonds_Copy1
            , TwoOfHearts_Copy1, ThreeOfHearts_Copy1, FourOfHearts_Copy1, FiveOfHearts_Copy1, SixOfHearts_Copy1, SevenOfHearts_Copy1, EightOfHearts_Copy1, NineOfHearts_Copy1, TenOfHearts_Copy1, JackOfHearts_Copy1, QueenOfHearts_Copy1, KingOfHearts_Copy1, AceOfHearts_Copy1
            , TwoOfClubs_Copy1, ThreeOfClubs_Copy1, FourOfClubs_Copy1, FiveOfClubs_Copy1, SixOfClubs_Copy1, SevenOfClubs_Copy1, EightOfClubs_Copy1, NineOfClubs_Copy1, TenOfCLubs_Copy1, JackOfClubs_Copy1, QueenOfClubs_Copy1, KingOfClubs_Copy1, AceOfClubs_Copy1
            , TwoOfSpades_Copy1, ThreeOfSpades_Copy1, FourOfSpades_Copy1, FiveOfSpades_Copy1, SixOfSpades_Copy1, SevenOfSpades_Copy1, EightOfSpades_Copy1, NineOfSpades_Copy1, TenOfSpades_Copy1, JackOfSpades_Copy1, QueenOfSpades_Copy1, KingOfSpades_Copy1, AceOfSpades_Copy1};

            cardImages5 = new Image[]{ TwoOfDiamonds_Copy2, ThreeOfDiamonds_Copy2, FourOfDiamonds_Copy2, FiveOfDiamonds_Copy2, SixOfDiamonds_Copy2, SevenOfDiamonds_Copy2, EightOfDiamonds_Copy2, NineOfDiamonds_Copy2, TenOfDiamonds_Copy2, JackOfDiamonds_Copy2, QueenOfDiamonds_Copy2, KingOfDiamonds_Copy2, AceOfDiamonds_Copy2
            , TwoOfHearts_Copy2, ThreeOfHearts_Copy2, FourOfHearts_Copy2, FiveOfHearts_Copy2, SixOfHearts_Copy2, SevenOfHearts_Copy2, EightOfHearts_Copy2, NineOfHearts_Copy2, TenOfHearts_Copy2, JackOfHearts_Copy2, QueenOfHearts_Copy2, KingOfHearts_Copy2, AceOfHearts_Copy2
            , TwoOfClubs_Copy2, ThreeOfClubs_Copy2, FourOfClubs_Copy2, FiveOfClubs_Copy2, SixOfClubs_Copy2, SevenOfClubs_Copy2, EightOfClubs_Copy2, NineOfClubs_Copy2, TenOfCLubs_Copy2, JackOfClubs_Copy2, QueenOfClubs_Copy2, KingOfClubs_Copy2, AceOfClubs_Copy2
            , TwoOfSpades_Copy2, ThreeOfSpades_Copy2, FourOfSpades_Copy2, FiveOfSpades_Copy2, SixOfSpades_Copy2, SevenOfSpades_Copy2, EightOfSpades_Copy2, NineOfSpades_Copy2, TenOfSpades_Copy2, JackOfSpades_Copy2, QueenOfSpades_Copy2, KingOfSpades_Copy2, AceOfSpades_Copy2};

            cardImages6 = new Image[]{ TwoOfDiamonds_Copy4, ThreeOfDiamonds_Copy4, FourOfDiamonds_Copy4, FiveOfDiamonds_Copy4, SixOfDiamonds_Copy4, SevenOfDiamonds_Copy4, EightOfDiamonds_Copy4, NineOfDiamonds_Copy4, TenOfDiamonds_Copy4, JackOfDiamonds_Copy4, QueenOfDiamonds_Copy4, KingOfDiamonds_Copy4, AceOfDiamonds_Copy4
            , TwoOfHearts_Copy4, ThreeOfHearts_Copy4, FourOfHearts_Copy4, FiveOfHearts_Copy4, SixOfHearts_Copy4, SevenOfHearts_Copy4, EightOfHearts_Copy4, NineOfHearts_Copy4, TenOfHearts_Copy4, JackOfHearts_Copy4, QueenOfHearts_Copy4, KingOfHearts_Copy4, AceOfHearts_Copy4
            , TwoOfClubs_Copy4, ThreeOfClubs_Copy4, FourOfClubs_Copy4, FiveOfClubs_Copy4, SixOfClubs_Copy4, SevenOfClubs_Copy4, EightOfClubs_Copy4, NineOfClubs_Copy4, TenOfCLubs_Copy4, JackOfClubs_Copy4, QueenOfClubs_Copy4, KingOfClubs_Copy4, AceOfClubs_Copy4
            , TwoOfSpades_Copy4, ThreeOfSpades_Copy4, FourOfSpades_Copy4, FiveOfSpades_Copy4, SixOfSpades_Copy4, SevenOfSpades_Copy4, EightOfSpades_Copy4, NineOfSpades_Copy4, TenOfSpades_Copy4, JackOfSpades_Copy4, QueenOfSpades_Copy4, KingOfSpades_Copy4, AceOfSpades_Copy4};
            for (int i=0; i<cardImages.Length; i++)
            {
                cardImages[i].Visibility = Visibility.Hidden;
                cardImages2[i].Visibility = Visibility.Hidden;
                cardImages3[i].Visibility = Visibility.Hidden;
                cardImages4[i].Visibility = Visibility.Hidden;
                cardImages5[i].Visibility = Visibility.Hidden;
                cardImages6[i].Visibility = Visibility.Hidden;
            }

            computerCardImages = new Image[] { TwoOfDiamonds_Copy5, ThreeOfDiamonds_Copy5, FourOfDiamonds_Copy5, FiveOfDiamonds_Copy5, SixOfDiamonds_Copy5, SevenOfDiamonds_Copy5, EightOfDiamonds_Copy5, NineOfDiamonds_Copy5, TenOfDiamonds_Copy5, JackOfDiamonds_Copy5, QueenOfDiamonds_Copy5, KingOfDiamonds_Copy5, AceOfDiamonds_Copy5
            , TwoOfHearts_Copy5, ThreeOfHearts_Copy5, FourOfHearts_Copy5, FiveOfHearts_Copy5, SixOfHearts_Copy5, SevenOfHearts_Copy5, EightOfHearts_Copy5, NineOfHearts_Copy5, TenOfHearts_Copy5, JackOfHearts_Copy5, QueenOfHearts_Copy5, KingOfHearts_Copy5, AceOfHearts_Copy5
            , TwoOfClubs_Copy5, ThreeOfClubs_Copy5, FourOfClubs_Copy5, FiveOfClubs_Copy5, SixOfClubs_Copy5, SevenOfClubs_Copy5, EightOfClubs_Copy5, NineOfClubs_Copy5, TenOfCLubs_Copy5, JackOfClubs_Copy5, QueenOfClubs_Copy5, KingOfClubs_Copy5, AceOfClubs_Copy5
            , TwoOfSpades_Copy5, ThreeOfSpades_Copy5, FourOfSpades_Copy5, FiveOfSpades_Copy5, SixOfSpades_Copy5, SevenOfSpades_Copy5, EightOfSpades_Copy5, NineOfSpades_Copy5, TenOfSpades_Copy5, JackOfSpades_Copy5, QueenOfSpades_Copy5, KingOfSpades_Copy5, AceOfSpades_Copy5};

            computerCardImages2 = new Image[] { TwoOfDiamonds_Copy6, ThreeOfDiamonds_Copy6, FourOfDiamonds_Copy6, FiveOfDiamonds_Copy6, SixOfDiamonds_Copy6, SevenOfDiamonds_Copy6, EightOfDiamonds_Copy6, NineOfDiamonds_Copy6, TenOfDiamonds_Copy6, JackOfDiamonds_Copy6, QueenOfDiamonds_Copy6, KingOfDiamonds_Copy6, AceOfDiamonds_Copy6
            , TwoOfHearts_Copy6, ThreeOfHearts_Copy6, FourOfHearts_Copy6, FiveOfHearts_Copy6, SixOfHearts_Copy6, SevenOfHearts_Copy6, EightOfHearts_Copy6, NineOfHearts_Copy6, TenOfHearts_Copy6, JackOfHearts_Copy6, QueenOfHearts_Copy6, KingOfHearts_Copy6, AceOfHearts_Copy6
            , TwoOfClubs_Copy6, ThreeOfClubs_Copy6, FourOfClubs_Copy6, FiveOfClubs_Copy6, SixOfClubs_Copy6, SevenOfClubs_Copy6, EightOfClubs_Copy6, NineOfClubs_Copy6, TenOfCLubs_Copy6, JackOfClubs_Copy6, QueenOfClubs_Copy6, KingOfClubs_Copy6, AceOfClubs_Copy6
            , TwoOfSpades_Copy6, ThreeOfSpades_Copy6, FourOfSpades_Copy6, FiveOfSpades_Copy6, SixOfSpades_Copy6, SevenOfSpades_Copy6, EightOfSpades_Copy6, NineOfSpades_Copy6, TenOfSpades_Copy6, JackOfSpades_Copy6, QueenOfSpades_Copy6, KingOfSpades_Copy6, AceOfSpades_Copy6};

            computerCardImages3 = new Image[] { TwoOfDiamonds_Copy7, ThreeOfDiamonds_Copy7, FourOfDiamonds_Copy7, FiveOfDiamonds_Copy7, SixOfDiamonds_Copy7, SevenOfDiamonds_Copy7, EightOfDiamonds_Copy7, NineOfDiamonds_Copy7, TenOfDiamonds_Copy7, JackOfDiamonds_Copy7, QueenOfDiamonds_Copy7, KingOfDiamonds_Copy7, AceOfDiamonds_Copy7
            , TwoOfHearts_Copy7, ThreeOfHearts_Copy7, FourOfHearts_Copy7, FiveOfHearts_Copy7, SixOfHearts_Copy7, SevenOfHearts_Copy7, EightOfHearts_Copy7, NineOfHearts_Copy7, TenOfHearts_Copy7, JackOfHearts_Copy7, QueenOfHearts_Copy7, KingOfHearts_Copy7, AceOfHearts_Copy7
            , TwoOfClubs_Copy7, ThreeOfClubs_Copy7, FourOfClubs_Copy7, FiveOfClubs_Copy7, SixOfClubs_Copy7, SevenOfClubs_Copy7, EightOfClubs_Copy7, NineOfClubs_Copy7, TenOfCLubs_Copy7, JackOfClubs_Copy7, QueenOfClubs_Copy7, KingOfClubs_Copy7, AceOfClubs_Copy7
            , TwoOfSpades_Copy7, ThreeOfSpades_Copy7, FourOfSpades_Copy7, FiveOfSpades_Copy7, SixOfSpades_Copy7, SevenOfSpades_Copy7, EightOfSpades_Copy7, NineOfSpades_Copy7, TenOfSpades_Copy7, JackOfSpades_Copy7, QueenOfSpades_Copy7, KingOfSpades_Copy7, AceOfSpades_Copy7};

            computerCardImages4 = new Image[] { TwoOfDiamonds_Copy8, ThreeOfDiamonds_Copy8, FourOfDiamonds_Copy8, FiveOfDiamonds_Copy8, SixOfDiamonds_Copy8, SevenOfDiamonds_Copy8, EightOfDiamonds_Copy8, NineOfDiamonds_Copy8, TenOfDiamonds_Copy8, JackOfDiamonds_Copy8, QueenOfDiamonds_Copy8, KingOfDiamonds_Copy8, AceOfDiamonds_Copy8
            , TwoOfHearts_Copy8, ThreeOfHearts_Copy8, FourOfHearts_Copy8, FiveOfHearts_Copy8, SixOfHearts_Copy8, SevenOfHearts_Copy8, EightOfHearts_Copy8, NineOfHearts_Copy8, TenOfHearts_Copy8, JackOfHearts_Copy8, QueenOfHearts_Copy8, KingOfHearts_Copy8, AceOfHearts_Copy8
            , TwoOfClubs_Copy8, ThreeOfClubs_Copy8, FourOfClubs_Copy8, FiveOfClubs_Copy8, SixOfClubs_Copy8, SevenOfClubs_Copy8, EightOfClubs_Copy8, NineOfClubs_Copy8, TenOfCLubs_Copy8, JackOfClubs_Copy8, QueenOfClubs_Copy8, KingOfClubs_Copy8, AceOfClubs_Copy8
            , TwoOfSpades_Copy8, ThreeOfSpades_Copy8, FourOfSpades_Copy8, FiveOfSpades_Copy8, SixOfSpades_Copy8, SevenOfSpades_Copy8, EightOfSpades_Copy8, NineOfSpades_Copy8, TenOfSpades_Copy8, JackOfSpades_Copy8, QueenOfSpades_Copy8, KingOfSpades_Copy8, AceOfSpades_Copy8};

            computerCardImages5 = new Image[] { TwoOfDiamonds_Copy9, ThreeOfDiamonds_Copy9, FourOfDiamonds_Copy9, FiveOfDiamonds_Copy9, SixOfDiamonds_Copy9, SevenOfDiamonds_Copy9, EightOfDiamonds_Copy9, NineOfDiamonds_Copy9, TenOfDiamonds_Copy9, JackOfDiamonds_Copy9, QueenOfDiamonds_Copy9, KingOfDiamonds_Copy9, AceOfDiamonds_Copy9
            , TwoOfHearts_Copy9, ThreeOfHearts_Copy9, FourOfHearts_Copy9, FiveOfHearts_Copy9, SixOfHearts_Copy9, SevenOfHearts_Copy9, EightOfHearts_Copy9, NineOfHearts_Copy9, TenOfHearts_Copy9, JackOfHearts_Copy9, QueenOfHearts_Copy9, KingOfHearts_Copy9, AceOfHearts_Copy9
            , TwoOfClubs_Copy9, ThreeOfClubs_Copy9, FourOfClubs_Copy9, FiveOfClubs_Copy9, SixOfClubs_Copy9, SevenOfClubs_Copy9, EightOfClubs_Copy9, NineOfClubs_Copy9, TenOfCLubs_Copy9, JackOfClubs_Copy9, QueenOfClubs_Copy9, KingOfClubs_Copy9, AceOfClubs_Copy9
            , TwoOfSpades_Copy9, ThreeOfSpades_Copy9, FourOfSpades_Copy9, FiveOfSpades_Copy9, SixOfSpades_Copy9, SevenOfSpades_Copy9, EightOfSpades_Copy9, NineOfSpades_Copy9, TenOfSpades_Copy9, JackOfSpades_Copy9, QueenOfSpades_Copy9, KingOfSpades_Copy9, AceOfSpades_Copy9};

            computerCardImages6 = new Image[] { TwoOfDiamonds_Copy10, ThreeOfDiamonds_Copy10, FourOfDiamonds_Copy10, FiveOfDiamonds_Copy10, SixOfDiamonds_Copy10, SevenOfDiamonds_Copy10, EightOfDiamonds_Copy10, NineOfDiamonds_Copy10, TenOfDiamonds_Copy10, JackOfDiamonds_Copy10, QueenOfDiamonds_Copy10, KingOfDiamonds_Copy10, AceOfDiamonds_Copy10
            , TwoOfHearts_Copy10, ThreeOfHearts_Copy10, FourOfHearts_Copy10, FiveOfHearts_Copy10, SixOfHearts_Copy10, SevenOfHearts_Copy10, EightOfHearts_Copy10, NineOfHearts_Copy10, TenOfHearts_Copy10, JackOfHearts_Copy10, QueenOfHearts_Copy10, KingOfHearts_Copy10, AceOfHearts_Copy10
            , TwoOfClubs_Copy10, ThreeOfClubs_Copy10, FourOfClubs_Copy10, FiveOfClubs_Copy10, SixOfClubs_Copy10, SevenOfClubs_Copy10, EightOfClubs_Copy10, NineOfClubs_Copy10, TenOfCLubs_Copy10, JackOfClubs_Copy10, QueenOfClubs_Copy10, KingOfClubs_Copy10, AceOfClubs_Copy10
            , TwoOfSpades_Copy10, ThreeOfSpades_Copy10, FourOfSpades_Copy10, FiveOfSpades_Copy10, SixOfSpades_Copy10, SevenOfSpades_Copy10, EightOfSpades_Copy10, NineOfSpades_Copy10, TenOfSpades_Copy10, JackOfSpades_Copy10, QueenOfSpades_Copy10, KingOfSpades_Copy10, AceOfSpades_Copy10};

            for (int i = 0; i < computerCardImages.Length; i++)
            {
                computerCardImages[i].Visibility = Visibility.Hidden;
                computerCardImages2[i].Visibility = Visibility.Hidden;
                computerCardImages3[i].Visibility = Visibility.Hidden;
                computerCardImages4[i].Visibility = Visibility.Hidden;
                computerCardImages5[i].Visibility = Visibility.Hidden;
                computerCardImages6[i].Visibility = Visibility.Hidden;
            }
        }

        public void Cardbtn_Click(object sender, RoutedEventArgs e)
        {
            int card1 = numGenerator();
            String card = "";
            if (deck[card1] == null)
            {
                while (deck[card1] == null) { //loops until we get a card that doesn't have a null value
                    //card1 = numGenerator();
                    card1 += 1;
                }
            }
            card = deck[card1];
            String royal1 = royalty(card);

            if (royal1 == null) //not apart of royal
            {
                count += cardValue(card);
                CountBox.Text = "Your total: " + count + "";
                if (cardValue(card) == 10)
                {
                    blackJack10 = 10;
                }
            }
            else
            {
                if (royal1.Equals("Ace"))
                {
                    Val1.Visibility = Visibility.Visible;
                    Val2.Visibility = Visibility.Visible;
                    Test.Visibility = Visibility.Visible;
                    Val1.IsEnabled = true;
                    Val2.IsEnabled = true;
                    CountBox.Text = "Your total: " + count + "";
                    cardAce = true;
                }
                else
                {
                    count += 10;
                    CountBox.Text = "Your total: " + count + "";
                    faceCard = true;
                }
                
            }
            cardImages[card1].Visibility = Visibility.Visible;
            imageIndex = card1;
            Cardbtn.IsEnabled = false;
            CardBtn2.IsEnabled = true;
            if (game() == true)
            {
                MessageBox.Show("GAME OVER! You WIN!");
                RestartBtn.IsEnabled = true;
            }
            newDeck[card1] = deck[card1];
            deck[card1] = null;
        }

        public int numGenerator()
        {
            Random r = new Random();
            int genRand = r.Next(0, 51);
            return genRand;
        }

        public int cardValue(String card)
        {
            int cardVal = 0;
            String card2;
            if (card.Contains(" of diamonds"))
            {
                card2 = card.Substring(0, card.Length - 12);
            }
            else if (card.Contains(" of hearts"))
            {
                card2 = card.Substring(0, card.Length - 10);
            }
            else if (card.Contains(" of clubs"))
            {
                card2 = card.Substring(0, card.Length - 9);
            }
            else
            {
                card2 = card.Substring(0, card.Length - 10);
            }
            cardVal = int.Parse(card2);
            return cardVal;
        }

        public String houseValue(String card)
        {
            String card2="";
            if (card.Contains(" of diamonds"))
            {
                card2 = " of diamonds";
            }
            else if (card.Contains(" of hearts"))
            {
                card2 = " of hearts";
            }
            else if (card.Contains(" of clubs"))
            {
                card2 = " of clubs";
            }
            else if(card.Contains(" of spades"))
            {
                card2 = " of spades";
            }
            return card2;
        }

        public String royalty(String card)
        {
            String royal = null;
            if (card.Contains("11"))
            {
                royal = "Jack";
            }
            if (card.Contains("12"))
            {
                royal = "Queen";
            }
            if (card.Contains("13"))
            {
                royal = "King";
            }
            if (card.Contains("14"))
            {
                royal = "Ace";
            }

            return royal;
        }

        public void CardBtn2_Click(object sender, RoutedEventArgs e)
        {
            RestartBtn.IsEnabled = true;
            FoldBtn.IsEnabled = true;
            int card1 = numGenerator();
            if (deck[card1] == null)
            {
                while (deck[card1] == null)
                {
                    //card1 = numGenerator();
                    card1 += 1;
                }
            }
            String card = deck[card1];
            String royal1 = royalty(card);

            if (royal1 == null)
            {
                count += cardValue(card);
                CountBox.Text = "Your total: " + count + "";
                if (cardValue(card) == 10)
                {
                    blackJack102 = 10;
                }
            }
            else
            {
                if (royal1.Equals("Ace"))
                {
                    Val1.Visibility = Visibility.Visible;
                    Val2.Visibility = Visibility.Visible;
                    Test.Visibility = Visibility.Visible;
                    Val1.IsEnabled = true;
                    Val2.IsEnabled = true;
                    cardAce2 = true;
                }
                else
                {
                    count += 10;
                    CountBox.Text = "Your total: " + count + "";
                    faceCard2 = true;
                }
               
            }
            newDeck[card1] = deck[card1];
            deck[card1] = null;
            /*if (playerBlackJack() == true)
            {
                MessageBox.Show("blackjack test");
                ComputerBox.Text = "blah";
            }
           */
            cards += computerCard1();
            cards += computerCard2();

            if(computerBlackJack()==true && playerBlackJack() == false)
            {
                MessageBox.Show("OPPONENT GOT BLACKJACK YOU LOSE!!");
                computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
                ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }

            if (playerBlackJack() == true) //if player has 21 & blackjack
            {
                computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
                computerCardGenerator();
                if (count > computerCount)
                {
                    //ComputerBox.Text = computerCount + "hi 1";
                    MessageBox.Show("BLACKJACK YOU WIN!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount && computerBlackJack() == true)
                {
                    MessageBox.Show("Draw!! Both you and the dealer got blackjack");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else //opponent doesn't have blackjack or opponent is greater than count meaning over 21
                {
                    //ComputerBox.Text = computerCount + "hi";
                    MessageBox.Show("BLACKJACK YOU WIN!!");
                    //ComputerBox.Text = computerCount + "CHECKKK2";
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";

                }
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            else if (game() == true) // player gets 21 not black jack
            {
                computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
                computerCardGenerator();
                if (count > computerCount && count == 21)
                {
                    MessageBox.Show("YOU WIN!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount && computerBlackJack() == true)
                {
                    MessageBox.Show("SORRY YOU LOSE! DEALER GOT BLACKJACK");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount)
                {
                    MessageBox.Show("DRAW!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            else if (count > 21)
            {
                MessageBox.Show("BUST!! SORRY YOU LOSE!");
                computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
                ComputerBox.Text = "DEALER SCORE: " + computerCount + ""; ;
            }

            cardImages2[card1].Visibility = Visibility.Visible;
            imageIndex = card1;
            CardBtn2.IsEnabled = false;
            Hitbtn.IsEnabled = true;
            ComputerBtn.IsEnabled = true;
            //computerCardImages[computerimageIndex].Visibility = Visibility.Visible;
        }

        public void Hitbtn_Click(object sender, RoutedEventArgs e)
        {
            FoldBtn.IsEnabled = false;
            if (hit == 0)
            {
                int card1 = numGenerator();
                if (deck[card1] == null)
                {
                    while (deck[card1] == null)
                    {
                        //card1 = numGenerator();
                        card1 += 1;
                    }
                }
                String card = deck[card1];
                String royal1 = royalty(card);

                if (royal1 == null)
                {
                    count += cardValue(card);
                    CountBox.Text = "Your total: " + count + "";
                }
                else
                {
                    if (royal1.Equals("Ace"))
                    {
                        Val1.Visibility = Visibility.Visible;
                        Val2.Visibility = Visibility.Visible;
                        Test.Visibility = Visibility.Visible;
                        Val1.IsEnabled = true;
                        Val2.IsEnabled = true;
                    }
                    else
                    {
                        count += 10;
                        CountBox.Text = "Your total: " + count + "";
                    }

                }
                cardImages3[card1].Visibility = Visibility.Visible;
                imageIndex = card1;
                newDeck[card1] = deck[card1];
                deck[card1] = null;
            }
            else if (hit == 1)
            {
                int card2 = numGenerator();
                if (deck[card2] == null)
                {
                    while (deck[card2] == null)
                    {
                        //card2 = numGenerator();
                        card2 += 1;
                    }
                }
                String card = deck[card2];
                String royal2 = royalty(card);

                if (royal2 == null)
                {
                    count += cardValue(card);
                    CountBox.Text = "Your total: " + count + "";
                }
                else
                {
                    if (royal2.Equals("Ace"))
                    {
                        Val1.Visibility = Visibility.Visible;
                        Val2.Visibility = Visibility.Visible;
                        Test.Visibility = Visibility.Visible;
                        Val1.IsEnabled = true;
                        Val2.IsEnabled = true;
                    }
                    else
                    {
                        count += 10;
                        CountBox.Text = "Your total: " + count + "";
                    }

                }
                cardImages4[card2].Visibility = Visibility.Visible;
                imageIndex = card2;
                newDeck[card2] = deck[card2];
                deck[card2] = null;
            }

            else if (hit == 2)
            {
                int card3 = numGenerator();
                if (deck[card3] == null)
                {
                    while (deck[card3] == null)
                    {
                        //card3 = numGenerator();
                        card3+= 1;
                    }
                }
                String card = deck[card3];
                String royal3 = royalty(card);

                if (royal3 == null)
                {
                    count += cardValue(card);
                    CountBox.Text = "Your total: " + count + "";
                }
                else
                {
                    if (royal3.Equals("Ace"))
                    {
                        Val1.Visibility = Visibility.Visible;
                        Val2.Visibility = Visibility.Visible;
                        Test.Visibility = Visibility.Visible;
                        Val1.IsEnabled = true;
                        Val2.IsEnabled = true;
                    }
                    else
                    {
                        count += 10;
                        CountBox.Text = "Your total: " + count + "";
                    }

                }
                cardImages5[card3].Visibility = Visibility.Visible;
                imageIndex = card3;
                newDeck[card3] = deck[card3];
                deck[card3] = null;
            }
            else if (hit == 3)
            {
                int card4 = numGenerator();
                if (deck[card4] == null)
                {
                    while (deck[card4] == null)
                    {
                        //card4 = numGenerator();
                        card4 += 1;
                    }
                }
                String card = deck[card4];
                String royal4 = royalty(card);

                if (royal4 == null)
                {
                    count += cardValue(card);
                    CountBox.Text = "Your total: " + count + "";
                }
                else
                {
                    if (royal4.Equals("Ace"))
                    {
                        Val1.Visibility = Visibility.Visible;
                        Val2.Visibility = Visibility.Visible;
                        Test.Visibility = Visibility.Visible;
                        Val1.IsEnabled = true;
                        Val2.IsEnabled = true;
                    }
                    else
                    {
                        count += 10;
                        CountBox.Text = "Your total: " + count + "";
                    }

                }
                cardImages6[card4].Visibility = Visibility.Visible;
                imageIndex = card4;
                newDeck[card4] = deck[card4];
                deck[card4] = null;
            }
            else
            {
                int card5 = numGenerator();
                if (deck[card5] == null)
                {
                    while (deck[card5] == null)
                    {
                        //card5 = numGenerator();
                        card5 += 1;
                    }
                }
                String card = deck[card5];
                String royal5 = royalty(card);

                if (royal5 == null)
                {
                    count += cardValue(card);
                    CountBox.Text = "Your total: " + count + "";
                }
                else
                {
                    if (royal5.Equals("Ace"))
                    {
                        Val1.Visibility = Visibility.Visible;
                        Val2.Visibility = Visibility.Visible;
                        Test.Visibility = Visibility.Visible;
                        Val1.IsEnabled = true;
                        Val2.IsEnabled = true;
                    }
                    else
                    {
                        count += 10;
                        CountBox.Text = "Your total: " + count + "";
                    }

                }
                cardImages[card5].Visibility = Visibility.Visible;
                imageIndex = card5;
                newDeck[card5] = deck[card5];
                deck[card5] = null;
            }
            hit++;

           /* if (game() == true)
            {
                MessageBox.Show("YOU WIN!!");
                ComputerBox.Text = computerCount + "";
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            if (count > 21)
            {
                MessageBox.Show("BUST! SORRY YOU LOSE!");
                ComputerBox.Text = computerCount + "";
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            */
            if (count == 21) // player gets 21 
            {
                computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
                computerCardGenerator();
                if (computerCount > 21)
                {
                    MessageBox.Show("YOU WIN!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count > computerCount)
                {
                    MessageBox.Show("YOU WIN!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount && computerBlackJack() == true)
                {
                    MessageBox.Show("SORRY YOU LOSE! DEALER GOT BLACKJACK");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else 
                {
                    MessageBox.Show("DRAW!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            else if (count > 21)
            {
                computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
                MessageBox.Show("BUST!! SORRY YOU LOSE!");
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
                ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
            }
        }
        public Boolean game()
        {
            if (count == 21)
            {
                return true;
            }
            return false;
        }

        public Boolean computerGame()
        {
            if (computerCount == 21)
            {
                return true;
            }
            return false;
        }

        //public Boolean perfectWin()
        //{
        //    if(coun)
        //}

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private String computerCard1()
        {
            int card1 = numGenerator();
            if (deck[card1] == null)
            {
                while (deck[card1] == null)
                {
                    //card1 = numGenerator();
                    card1 += 1;
                }
            }
            String card = deck[card1];
            String royal1 = royalty(card);
            String temp;

            if (royal1 == null)
            {
                temp = card + "  ";
                computerCount += cardValue(card);
                if (card1 == 10)
                {
                    compBlackJack10 = 10;
                }
            }
            else
            {
                temp = royal1 + houseValue(card) + "  ";
                if (royal1.Equals("Ace"))
                {
                    computerCount += 11;
                    compCardAce = true;
                }
                else
                {
                    computerCount += 10;
                    compFaceCard = true;
                }
                

            }
            computerCardImages[card1].Visibility = Visibility.Visible;
            newDeck[card1] = deck[card1];
            deck[card1] = null;
            return temp;
        }

        private String computerCard2()
        {
            int card1 = numGenerator();
            if (deck[card1] == null)
            {
                while (deck[card1] == null)
                {
                    //card1 = numGenerator();
                    card1 += 1;
                }
            }
            String card = deck[card1];
            String royal1 = royalty(card);
            String temp;

            if (royal1 == null)
            {
                temp = card + "  ";
                computerCount += cardValue(card);
                if (card1 == 10)
                {
                    compBlackJack102 = 10;
                }
            }
            else
            {
                temp = royal1 + houseValue(card) + "  ";
                if (royal1.Equals("Ace"))
                {
                    computerCount += 11;
                    compCardAce2 = true;
                }
                else
                {
                    computerCount += 10;
                    compFaceCard2 = true;
                }
                
            }
            computerimageIndex = card1;
            newDeck[card1] = deck[card1];
            deck[card1] = null;
            return temp;
        }

        private void ComputerBtn_Click(object sender, RoutedEventArgs e)
        {
            FoldBtn.IsEnabled = false;
            //cardImages[imageIndex].Visibility = Visibility.Hidden;
            computerCardImages2[computerimageIndex].Visibility = Visibility.Visible;
            int count1 = 0;
            while (computerCount < 17)
            {
                int card1 = numGenerator();
                if (deck[card1] == null)
                {
                    while (deck[card1] == null)
                    {
                        //card1 = numGenerator();
                        card1 += 1;
                    }
                }
                String card = deck[card1];
                String royal1 = royalty(card);
                String temp;

                if (royal1 == null)
                {
                    temp = card + "  ";
                    computerCount += cardValue(card);
                }
                else
                {
                    temp = royal1 + houseValue(card) + "  ";
                    if (royal1.Equals("Ace"))
                    {
                        computerCount += 1;
                    }
                    else
                    {
                        computerCount += 10;
                    }

                }
                newDeck[card1] = deck[card1];
                deck[card1] = null;
                if (count1 == 0)
                {
                    computerCardImages3[card1].Visibility = Visibility.Visible;
                }
                else if (count1 == 1)
                {
                    computerCardImages4[card1].Visibility = Visibility.Visible;
                }
                else if (count1 == 2)
                {
                    computerCardImages5[card1].Visibility = Visibility.Visible;
                }
                else if (count1 == 3)
                {
                    computerCardImages6[card1].Visibility = Visibility.Visible;
                }
                count1++;
            }

            ComputerBox.Text = "DEALER SCORE: " + computerCount + "";


            if (computerCount==21 && computerBlackJack()==true)
            {
                MessageBox.Show("DEALER GOT BLACKJACK! YOU LOSE");
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
            }
            else if (computerCount == 21)
            {
                MessageBox.Show("DEALER GOT 21! YOU LOSE!");

            }
            else if (computerCount > 21)
            {
                MessageBox.Show("DEALER BUST! YOU WIN!");
            }

            else if (computerCount<count)
            {
                MessageBox.Show("YOU WIN!!!");
            }
            else if (count == computerCount)
            {
                MessageBox.Show("DRAW!!");
            }
            else //if (computerCount == count)
            {
                MessageBox.Show("YOU LOSE!");
            }
            Hitbtn.IsEnabled = false;
            ComputerBtn.IsEnabled = false;
            RestartBtn.IsEnabled = true;
        }

        private void HelpBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("DIRECTIONS: Begin the game by pressing on the 2 Get your Card buttons to receive your first 2 cards. Next, you can choose to press the Hit button, to get more cards, the Fold button to end the game OR you can press the Stay button for the Dealer to go. Once you press Stay, your total is final. After pressing Stay, the computer opponent will do their actions and a message will appear, telling you the outcome of the game. REMEMBER, the point of the game is to get the closest to 21 as possible. If you wish to replay, press the play again button! If you want to leave the game press the Exit button! To get blackjack, your first 2 cards must be an Ace and either a 10 or a face card. If you go over 21 you lose!");
        }

        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        { 
            
                for(int j=0; j<deck.Length; j++)
                {
                    if (deck[j] == null)
                    {
                        deck[j] = newDeck[j];
                    }
                }
            
            count = 0;
            computerCount = 0;
            Cardbtn.IsEnabled = true;
            Hitbtn.IsEnabled = false;
            FoldBtn.IsEnabled = false;
            ComputerBtn.IsEnabled = false;
            RestartBtn.IsEnabled = false;
            //Val1.Visibility = Visibility.Visible;
            //Val2.Visibility = Visibility.Visible;
            cardImages[imageIndex].Visibility = Visibility.Hidden;
            computerCardImages[computerimageIndex].Visibility = Visibility.Hidden;
            ComputerBox.Text = "";
            CountBox.Text = "";
            hit = 0;
            cardAce = false;
            cardAce2 = false;
            blackJack10 = 0;
            faceCard = false;
            blackJack102 = 0;
            faceCard2 = false;
            compBlackJack10 = 0;
            compFaceCard = false;
            compBlackJack102 = 0;
            compFaceCard2 = false;
            compCardAce = false;
            compCardAce2 = false;
            for (int i = 0; i < cardImages.Length; i++)
            {
                cardImages[i].Visibility = Visibility.Hidden;
                cardImages2[i].Visibility = Visibility.Hidden;
                cardImages3[i].Visibility = Visibility.Hidden;
                cardImages4[i].Visibility = Visibility.Hidden;
                cardImages5[i].Visibility = Visibility.Hidden;
                cardImages6[i].Visibility = Visibility.Hidden;
            }

            for (int i = 0; i < computerCardImages.Length; i++)
            {
                computerCardImages[i].Visibility = Visibility.Hidden;
                computerCardImages2[i].Visibility = Visibility.Hidden;
                computerCardImages3[i].Visibility = Visibility.Hidden;
                computerCardImages4[i].Visibility = Visibility.Hidden;
                computerCardImages5[i].Visibility = Visibility.Hidden;
                computerCardImages6[i].Visibility = Visibility.Hidden;
            }
        }

        public void Val1_Click(object sender, RoutedEventArgs e)
        {
            count += 1;
            CountBox.Text = "Your total: " + count + "";
            if (count > 21)
            {
                MessageBox.Show("BUST YOU LOSE");
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                RestartBtn.IsEnabled = true;
            }
            if (game() == true)
            {
                MessageBox.Show("YOU WIN!!");
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
            }
            Val1.IsEnabled = false;
            Val2.IsEnabled = false;

            Val1.Visibility = Visibility.Hidden;
            Val2.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
        }

        public void Val2_Click(object sender, RoutedEventArgs e)
        {
            count += 11;
            CountBox.Text = "Your total: " + count + "";
            /*if (playerBlackJack() == true)
            {
                MessageBox.Show("blackjack test");
                ComputerBox.Text = "blah";
            }
            
            if (count > 21)
            {
                MessageBox.Show("YOU LOSE");
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                RestartBtn.IsEnabled = true;
            }

            if (game() == true && playerBlackJack()==true)
            {
                MessageBox.Show("BLACK JACK!! YOU WIN!!");
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
            }
            else if (count == 21)
            {
                MessageBox.Show("YOU WIN!!");
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
            }
            */
            if (count == 21 && playerBlackJack() == true) //if player has 21 & blackjack
            {
                computerCardGenerator();
                if (count > computerCount)
                {
                    //ComputerBox.Text = computerCount + "hi 1";
                    MessageBox.Show("BLACKJACK YOU WIN!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount && computerBlackJack() == true)
                {
                    MessageBox.Show("Draw!! Both you and the dealer got blackjack");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else//opponent doesn't have blackjack or is greater than 21
                {
                    //ComputerBox.Text = computerCount + "hi";
                    MessageBox.Show("BLACKJACK YOU WIN!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";

                }
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            else if (game() == true) // player gets 21 not black jack
            {
                computerCardGenerator();
                if (count > computerCount && count == 21)
                {
                    MessageBox.Show("YOU WIN!!");
                     ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount && computerBlackJack() == true)
                {
                    MessageBox.Show("SORRY YOU LOSE! OPPONENT GOT BLACKJACK");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                else if (count == computerCount)
                {
                    MessageBox.Show("DRAW!!");
                    ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
                }
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
            }
            else if (count > 21)
            {
                MessageBox.Show("BUST!! SORRY YOU LOSE!");
                RestartBtn.IsEnabled = true;
                Hitbtn.IsEnabled = false;
                ComputerBtn.IsEnabled = false;
                FoldBtn.IsEnabled = false;
                ComputerBox.Text = "DEALER SCORE: " + computerCount + "";
            }

            Val1.IsEnabled = false;
            Val2.IsEnabled = false;
            Val1.Visibility = Visibility.Hidden;
            Val2.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
        }

        private void FoldBtn_Click(object sender, RoutedEventArgs e)
        {
            RestartBtn.IsEnabled = true;
            Hitbtn.IsEnabled = false;
            ComputerBtn.IsEnabled = false;
            Val1.IsEnabled = false;
            Val2.IsEnabled = false;
            Val1.Visibility = Visibility.Hidden;
            Val2.Visibility = Visibility.Hidden;
            Test.Visibility = Visibility.Hidden;
        }

        public void computerCardGenerator()
        {
            int count = 0;
            while (computerCount < 17)
            {
                int card1 = numGenerator();
                if (deck[card1] == null)
                {
                    while (deck[card1] == null)
                    {
                        //card1 = numGenerator();
                        card1 += 1;
                    }
                }
                String card = deck[card1];
                String royal1 = royalty(card);
                String temp;

                if (royal1 == null)
                {
                    temp = card + "  ";
                    computerCount += cardValue(card);
                }
                else
                {
                    temp = royal1 + houseValue(card) + "  ";
                    if (royal1.Equals("Ace"))
                    {
                        computerCount += 1;
                    }
                    else
                    {
                        computerCount += 10;
                    }

                }if (count == 0)
                {
                    computerCardImages3[card1].Visibility = Visibility.Visible;
                }
                else if (count == 1)
                {
                    computerCardImages4[card1].Visibility = Visibility.Visible;
                }
                else if (count == 2)
                {
                    computerCardImages5[card1].Visibility = Visibility.Visible;
                }
                else if (count == 3)
                {
                    computerCardImages6[card1].Visibility = Visibility.Visible;
                }
                count++;
                newDeck[card1] = deck[card1];
                deck[card1] = null;
            }
        }
        public Boolean playerBlackJack()
        {
            if(count==21 && cardAce==true && cardAce2==false )//if the first card is an ace
                 {
                if(blackJack102 == 10 || faceCard2 == true) { 
                    return true;
                    }
                return false;
                
                 }
            if(count==21 && cardAce2==true && cardAce==false)//if the second card is an ace
            {
                if (blackJack10 == 10 || faceCard == true)
                {
                    return true;
                }
                return false;
                
            }
           
            return false;
        }

        public Boolean computerBlackJack()
        {
            if (computerCount == 21 && compCardAce == true && compCardAce2 == false)//if the first card is an ace
            {
                if (compBlackJack102 == 10 || compFaceCard2 == true)
                {
                    return true;
                }
                return false;

            }
            if (computerCount == 21 && compCardAce2 == true && compCardAce == false)//if the second card is an ace
            {
                if (compBlackJack10 == 10 || compFaceCard == true)
                {
                    return true;
                }
                return false;

            }

            return false;
        }
    }
}