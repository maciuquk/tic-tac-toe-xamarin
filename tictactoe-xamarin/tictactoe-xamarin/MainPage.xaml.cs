using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tictactoe_xamarin
{
    public partial class MainPage : ContentPage
    {
        public bool IsPlayer1 { get; set; } = true;
        public int Turn { get; set; }
        public string[,] Array = new string [5,5];

        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;

            if (button.Text == null)
            {
                if (IsPlayer1)
                {
                    
                    button.Text = "X";
                    button.TextColor = Color.Red;
                    whichTurnLabel.Text = "O";
                }
                else
                {
                    button.Text = "O";
                    button.TextColor = Color.Blue;
                    whichTurnLabel.Text = "X";
                }
                
                IsPlayer1 ^= true;
                Turn++;

                CheckAllFields();
            }
        }

        private void Win(string ktoWygral)
        {
            DisplayAlert("Wygrana!", "Wygrał " + ktoWygral, "Rozpocznij nową grę");
            StartNewGame();

        }
        private void NoBodyWin()
        {
            DisplayAlert("Nikt nie wygrał!", "", "Rozpocznij nową grę");
            StartNewGame();

        }

        private void StartNewGame()
        {
            Turn = 0;
            button1.Text = null;
            button2.Text = null;
            button3.Text = null;
            button4.Text = null;
            button5.Text = null;
            button6.Text = null;
            button7.Text = null;
            button8.Text = null;
            button9.Text = null;
            button10.Text = null;
            button11.Text = null;
            button12.Text = null;
            button13.Text = null;
            button14.Text = null;
            button15.Text = null;
            button16.Text = null;
            button17.Text = null;
            button18.Text = null;
            button19.Text = null;
            button20.Text = null;
            button21.Text = null;
            button22.Text = null;
            button23.Text = null;
            button24.Text = null;
            button25.Text = null;
        }

        public void CheckAllFields()
        {
            Array[0, 0] = button1.Text; 
            Array[0, 1] = button2.Text; 
            Array[0, 2] = button3.Text; 
            Array[0, 3] = button4.Text; 
            Array[0, 4] = button5.Text; 
            Array[1, 0] = button6.Text; 
            Array[1, 1] = button7.Text; 
            Array[1, 2] = button8.Text;
            Array[1, 3] = button9.Text; 
            Array[1, 4] = button10.Text;
            Array[2, 0] = button11.Text;
            Array[2, 1] = button12.Text;
            Array[2, 2] = button13.Text;
            Array[2, 3] = button14.Text;
            Array[2, 4] = button15.Text;
            Array[3, 0] = button16.Text;
            Array[3, 1] = button17.Text;
            Array[3, 2] = button18.Text;
            Array[3, 3] = button19.Text;
            Array[3, 4] = button20.Text;
            Array[4, 0] = button21.Text;
            Array[4, 1] = button22.Text;
            Array[4, 2] = button23.Text;
            Array[4, 3] = button24.Text;
            Array[4, 4] = button25.Text;

            //  check at right angle
            if (Array[0,0] == Array[1,1] && Array[1,1] == Array[2,2] && Array[2,2] == Array[3,3] && Array[3,3] == Array[4,4] 
                && Array[0,0] != null && Array[1, 1] != null && Array[2, 2] != null && Array[3, 3] != null && Array[4, 4] != null )
            {
                Win(Array[0,0]);
            }

            //  check at left angle
            if (Array[4,0] == Array[3,1] && Array[3,1] == Array[2,2] && Array[2,2] == Array[1,3] && Array[1,3] == Array[0,4] 
                && Array[4,0] != null && Array[3, 1] != null && Array[2, 2] != null && Array[1, 3] != null && Array[0, 4] != null )
            {
                Win(Array[4,0]);
            }

            // vertical check
            string player = "O";
            for (int i = 0; i <= 4; i++)
            {
                if (Array[0, i] == player &&
                    Array[1, i] == player &&
                    Array[2, i] == player &&
                    Array[3, i] == player &&
                    Array[4, i] == player )
                {
                    if (Array[0, i] != null)
                    {
                        Win(player);
                    }
                }
            }
            
            player = "X";
            for (int i = 0; i <= 4; i++)
            {
                if (Array[0, i] == player &&
                    Array[1, i] == player &&
                    Array[2, i] == player &&
                    Array[3, i] == player &&
                    Array[4, i] == player )
                {
                    if (Array[0, i] != null)
                    {
                        Win(player);
                    }
                }
            }

            // horizontal check
            player = "O";
            for (int i = 0; i <= 4; i++)
            {
                if (Array[i, 0] == player &&
                    Array[i, 1] == player &&
                    Array[i, 2] == player &&
                    Array[i, 3] == player &&
                    Array[i, 4] == player)
                {
                    if (Array[i, 0] != null)
                    {
                        Win(player);
                    }
                }
            }
            
            player = "X";
            for (int i = 0; i <= 4; i++)
            {
                if (Array[i, 0] == player &&
                    Array[i, 1] == player &&
                    Array[i, 2] == player &&
                    Array[i, 3] == player &&
                    Array[i, 4] == player)
                {
                    if (Array[i, 0] != null)
                    {
                        Win(player);
                    }
                }
            }

            // check if nobody wins
            if (Turn == 25)
            {
                NoBodyWin();
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            StartNewGame();
        }
    }
}
