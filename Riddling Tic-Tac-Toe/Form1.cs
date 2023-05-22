using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Riddling_Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        String[] gameBoard = new String[9];
        int currentTurn = 0;

        private bool canMakeMove;
        public string returnSymbol(int turn)
        {
            if (turn % 2 == 0)
            {
                return "O";
            }
            else
            {
                return "X";
            }
        }
        public Form1()
        {
            InitializeComponent();
            topBox.Visible = false;
            restartButton.Visible = false;
            whenTimeTicks();
        }

        public void checkForWinner()
        {
            for (int i = 0; i < 8; i++)
            {
                string combination = "";
                switch (i)
                {
                    case 0:
                        combination = gameBoard[0] + gameBoard[4] + gameBoard[8];
                        break;

                    case 1:
                        combination = gameBoard[2] + gameBoard[4] + gameBoard[6];
                        break;

                    case 2:
                        combination = gameBoard[0] + gameBoard[1] + gameBoard[2];
                        break;

                    case 3:
                        combination = gameBoard[3] + gameBoard[4] + gameBoard[5];
                        break;

                    case 4:
                        combination = gameBoard[6] + gameBoard[7] + gameBoard[8];
                        break;

                    case 5:
                        combination = gameBoard[0] + gameBoard[3] + gameBoard[6];
                        break;

                    case 6:
                        combination = gameBoard[1] + gameBoard[4] + gameBoard[7];
                        break;

                    case 7:
                        combination = gameBoard[2] + gameBoard[5] + gameBoard[8];
                        break;
                }

                checkForDraw();

                if (combination.Equals("XXX"))
                {
                    rndNumGenerate = false;
                    timer.Stop();
                    questionBox.Visible = false;
                    topBox.Visible = true;
                    topBox.Text = "Game Over!! ... X is the winner";
                    gameOver = true;
                }
                if (combination.Equals("OOO"))
                {
                    rndNumGenerate = false;
                    timer.Stop();
                    questionBox.Visible = false;
                    topBox.Visible = true;
                    topBox.Text = "Game Over!! ... O is the Winner";
                    gameOver = true;
                }
            }
        }

        public void checkForDraw()
        {
            int counter = 0;
            for (int i = 0; i < gameBoard.Length; i++)
            {
                if (gameBoard[i] != null)
                {
                    counter++;
                }
                if (counter == 9)
                {
                    rndNumGenerate = false;
                    timer.Stop();
                    questionBox.Visible = false;
                    topBox.Visible = true;
                    topBox.Text = "Game Over!! ... THAT'S A DRAW";
                    gameOver = true;
                }
            }
        }

        public void reset()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            gameBoard = new string[9];
            currentTurn = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[0] = returnSymbol(currentTurn);
                if (button1.Text == "")
                {
                    button1.Text = gameBoard[0];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[1] = returnSymbol(currentTurn);
                if (button2.Text == "")
                {
                    button2.Text = gameBoard[1];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[2] = returnSymbol(currentTurn);
                if (button3.Text == "")
                {
                    button3.Text = gameBoard[2];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[3] = returnSymbol(currentTurn);
                if (button4.Text == "")
                {
                    button4.Text = gameBoard[3];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[4] = returnSymbol(currentTurn);
                if (button5.Text == "")
                {
                    button5.Text = gameBoard[4];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[5] = returnSymbol(currentTurn);
                if (button6.Text == "")
                {
                    button6.Text = gameBoard[5];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[6] = returnSymbol(currentTurn);
                if (button7.Text == "")
                {
                    button7.Text = gameBoard[6];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[7] = returnSymbol(currentTurn);
                if (button8.Text == "")
                {
                    button8.Text = gameBoard[7];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (canMakeMove == true)
            {
                gameBoard[8] = returnSymbol(currentTurn);
                if (button9.Text == "")
                {
                    button9.Text = gameBoard[8];
                }
                checkForWinner();
                answerBox.Text = "";
                decisionBox.Text = "";
                whenTimeTicks();
                canMakeMove = false;
                answerBox.Enabled = true;
                checkButton.Enabled = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                reset();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                reset();
            }
        }

        private bool gameOver;
        private void restartButton_Click(object sender, EventArgs e)
        {
            gameOver = false;
            reset();
            num.Clear();
            decisionBox.Text = "";
            answerBox.Text = "";
            restartButton.Visible = false;
            decisionBox.Text = "";
            checkButton.Enabled = true;
            nextButton.Enabled = false;
            answerBox.Enabled = true;
            turnLabel.Text = "X's Turn";
            rndNumGenerate = true;
            resultDisplay.Text = "";
            topBox.Visible = false;
            questionBox.Visible = true;

            timer.Start();
        }

        // QUESTION PART

        private Random number = new Random();
        private int rndnum;
        private List<int> num = new List<int>();

        private bool rndNumGenerate = true;
        public void whenTimeTicks()
        {
            if (gameOver == true)
            {
                timer.Stop();
                canMakeMove = false;
                restartButton.Visible = true;
                checkButton.Enabled = false;
                nextButton.Enabled = false;
                answerBox.Enabled = false;
                turnLabel.Text = "";
                resultDisplay.Text = "Click on Restart! -->";
                questionBox.Text = "";
            }

            if (gameOver == false)
            {
                if (currentTurn % 2 == 0)
                {
                    turnLabel.Text = "X's Turn";                   
                }
                else
                {
                    turnLabel.Text = "O's Turn";
                }
            }

            if (rndNumGenerate)
            {
                do
                {
                    rndnum = number.Next(0, 28);

                } while (num.Contains(rndnum));
            }

            num.Add(rndnum);

            switch (rndnum)
            {
                case 0:
                    timer.Stop();
                    questionBox.Text = "What is round and bright and important to earth?(3 letters)";
                    break;

                case 1:
                    timer.Stop();
                    questionBox.Text = "What is white and yellow and an important source of protein?(6 letters)";
                    break;

                case 2:
                    timer.Stop();
                    questionBox.Text = "What is 5×5+6÷2-28+1?";
                    break;

                case 3:
                    timer.Stop();
                    questionBox.Text = "What is the national animal of Nepal?(3 letters)";
                    break;

                case 4:
                    timer.Stop();
                    questionBox.Text = "Who won the football world cup 2022?(9 letters)";
                    break;

                case 5:
                    timer.Stop();
                    questionBox.Text = "Which country founded samsung?(2 words 5 letters each)";
                    break;

                case 6:
                    timer.Stop();
                    questionBox.Text = "Who is the founder of Tesla?(2 words and 4 letters each)";
                    break;

                case 7:
                    timer.Stop();
                    questionBox.Text = "I am a rich source of protein, yellow from inside and white from outside.Who am I?(3 letters)";
                    break;

                case 8:
                    timer.Stop();
                    questionBox.Text = "I fly high in the sky and compete with the birds. Who am I?(9 letters)";
                    break;

                case 9:
                    timer.Stop();
                    questionBox.Text = "I am a friend of moon but I am more in number. Who am I?(4 letters)";
                    break;

                case 10:
                    timer.Stop();
                    questionBox.Text = "I am considered as the enemy of the dog. Who am I? (3 letters)";
                    break;

                case 11:
                    timer.Stop();
                    questionBox.Text = "I am a loyal pet and often referred to as man's best friend. Who am I? (3 letters)";
                    break;

                case 12:
                    timer.Stop();
                    questionBox.Text = "I am a container used for holding beverages. What am I? (3 letters)";
                    break;

                case 13:
                    timer.Stop();
                    questionBox.Text = " I contain stories, information, or ideas and are often read for entertainment or learning. What am I? (4 letters)";
                    break;

                case 14:
                    timer.Stop();
                    questionBox.Text = " I am a piece of furniture designed for sitting on. What am I? (5 letters)";
                    break;

                case 15:
                    timer.Stop();
                    questionBox.Text = "I am a tall plant with a trunk and branches, usually found in nature. What am I? (4 letters)";
                    break;

                case 16:
                    timer.Stop();
                    questionBox.Text = "I am a round object used in various sports and games. What am I? (4 letters)";
                    break;

                case 17:
                    timer.Stop();
                    questionBox.Text = " I am worn on the feet for protection and comfort. What am I? (4 letters)";
                    break;

                case 18:
                    timer.Stop();
                    questionBox.Text = "What is 8 + 3 × 2 - 5 ÷ 1?";
                    break;

                case 19:
                    timer.Stop();
                    questionBox.Text = "What is 12 - 4 × 3 + 6 ÷ 2?";
                    break;
                case 20:
                    timer.Stop();
                    questionBox.Text = "What is 9 + 6 ÷ 3 - 2 × 4?";
                    break;
                case 21:
                    timer.Stop();
                    questionBox.Text = "What is 16 - 2 × 5 + 3 ÷ 3?";
                    break;
                case 22:
                    timer.Stop();
                    questionBox.Text = "What is 4 + 2 × 3 - 6 ÷ 2?";
                    break;
                case 23:
                    timer.Stop();
                    questionBox.Text = "What is 10 - 5 ÷ 2 × 4?";
                    break;
                case 24:
                    timer.Stop();
                    questionBox.Text = "What is 20 + 12 ÷ 4 - 5 × 2?";
                    break;
                case 25:
                    timer.Stop();
                    questionBox.Text = "What is 14 - 3 ÷ 3 × 5?";
                    break;
                case 26:
                    timer.Stop();
                    questionBox.Text = "What is 18 + 4 × 2 - 7 ÷ 1?";
                    break;
                case 27:
                    timer.Stop();
                    questionBox.Text = "What is 6 - 8 ÷ 2 × 3?";
                    break;


            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            whenTimeTicks();
        }

        public void boardmark()
        {
            if (decisionBox.Text == "Correct." && currentTurn % 2 == 0)
            {
                boardMark.Text = "<- Mark 'O' in empty boxes";
            }

            else if (decisionBox.Text == "Correct." && currentTurn % 2 != 0)
            {
                boardMark.Text = "<- Mark 'X' in empty boxes";
            }
        }

        public void decider()
        {
            if (questionBox.Text == "What is round and bright and important to earth?(3 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "SUN" || answerBox.Text == "sun" || answerBox.Text == "Sun")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {

                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "What is white and yellow and an important source of protein?(6 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "Banana" || answerBox.Text == "banana" || answerBox.Text == "BANANA")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "What is 5×5+6÷2-28+1?")
            {
                currentTurn++;
                if (answerBox.Text == "1" || answerBox.Text == "+1")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "What is the national animal of Nepal?(3 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "Cow" || answerBox.Text == "cow" || answerBox.Text == "COW")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "Who won the football world cup 2022?(9 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "Argentina" || answerBox.Text == "ARGENTINA" || answerBox.Text == "argentina") // Problem
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }

                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "Which country founded samsung?(2 words 5 letters each)")
            {
                currentTurn++;
                if (answerBox.Text == "South Korea" || answerBox.Text == "SOUTH KOREA" || answerBox.Text == "south korea") // Problem
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }

                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "Who is the founder of Tesla?(2 words and 4 letters each)")
            {
                currentTurn++;
                if (answerBox.Text == "Elon Musk" || answerBox.Text == "ELON MUSK" || answerBox.Text == "elon musk") // Problem
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }

                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I am a rich source of protein, yellow from inside and white from outside.Who am I?(3 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "Egg" || answerBox.Text == "egg" || answerBox.Text == "EGG")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I fly high in the sky and compete with the birds. Who am I?(9 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "aeroplane" || answerBox.Text == "Aeroplane" || answerBox.Text == "AEROPLANE")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I am a friend of moon but I am more in number. Who am I?(4 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "Star" || answerBox.Text == "STAR" || answerBox.Text == "star")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I am considered as the enemy of the dog. Who am I? (3 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "CAT" || answerBox.Text == "cat" || answerBox.Text == "Cat")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I am a loyal pet and often referred to as man's best friend. Who am I? (3 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "DOG" || answerBox.Text == "dog" || answerBox.Text == "Dog")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I am a container used for holding beverages. What am I? (3 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "CUP" || answerBox.Text == "cup" || answerBox.Text == "Cup")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }

            }

            if (questionBox.Text == " I contain stories, information, or ideas and are often read for entertainment or learning. What am I? (4 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "BOOK" || answerBox.Text == "book" || answerBox.Text == "Book")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == " I am a piece of furniture designed for sitting on. What am I? (5 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "CHAIR" || answerBox.Text == "chair" || answerBox.Text == "Chair")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == "I am a tall plant with a trunk and branches, usually found in nature. What am I? (4 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "TREE" || answerBox.Text == "tree" || answerBox.Text == "Tree")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;

                }
            }

            if (questionBox.Text == "I am a round object used in various sports and games. What am I? (4 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "BALL" || answerBox.Text == "ball" || answerBox.Text == "Ball")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if (questionBox.Text == " I am worn on the feet for protection and comfort. What am I? (4 letters)")
            {
                currentTurn++;
                if (answerBox.Text == "SHOE" || answerBox.Text == "shoe" || answerBox.Text == "Shoe")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if(questionBox.Text== "What is 8 + 3 × 2 - 5 ÷ 1?")
            {
                currentTurn++;
                if(answerBox.Text=="9"||answerBox.Text=="+9"||answerBox.Text=="NINE" || answerBox.Text == "nine" || answerBox.Text == "Nine")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            if(questionBox.Text== "What is 12 - 4 × 3 + 6 ÷ 2?")
            {
                currentTurn++;
                if (answerBox.Text == "3" || answerBox.Text == "+3" || answerBox.Text == "THREE" || answerBox.Text == "three" || answerBox.Text == "Three")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 9 + 6 ÷ 3 - 2 × 4?")
            {
                currentTurn++;
                if (answerBox.Text == "3" || answerBox.Text == "+3" || answerBox.Text == "THREE" || answerBox.Text == "three" || answerBox.Text == "Three")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }
            else if (questionBox.Text == "What is 16 - 2 × 5 + 3 ÷ 3?")
            {
                currentTurn++;
                if (answerBox.Text == "7" || answerBox.Text == "+7" || answerBox.Text == "SEVEN" || answerBox.Text == "seven" || answerBox.Text == "Seven")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 4 + 2 × 3 - 6 ÷ 2?")
            {
                currentTurn++;
                if (answerBox.Text == "7" || answerBox.Text == "+7" || answerBox.Text == "SEVEN" || answerBox.Text == "seven" || answerBox.Text == "Seven")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 10 - 5 ÷ 2 × 4?")
            {
                currentTurn++;
                if (answerBox.Text == "2" || answerBox.Text == "+2" || answerBox.Text == "TWO" || answerBox.Text == "two" || answerBox.Text == "Two")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 20 + 12 ÷ 4 - 5 × 2?")
            {
                currentTurn++;
                if (answerBox.Text == "13" || answerBox.Text == "+13" || answerBox.Text == "THIRTEEN" || answerBox.Text == "thirteen" || answerBox.Text == "Thirteen")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 14 - 3 ÷ 3 × 5?")
            {
                currentTurn++;
                if (answerBox.Text == "9" || answerBox.Text == "+9" || answerBox.Text == "NINE" || answerBox.Text == "nine" || answerBox.Text == "Nine")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 18 + 4 × 2 - 7 ÷ 1?")
            {
                currentTurn++;
                if (answerBox.Text == "19" || answerBox.Text == "+19" || answerBox.Text == "NINETEEN" || answerBox.Text == "nineteen" || answerBox.Text == "Nineteen")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }

            else if (questionBox.Text == "What is 6 - 8 ÷ 2 × 3?")
            {
                currentTurn++;
                if (answerBox.Text == "-6" || answerBox.Text == "-6" || answerBox.Text == "MINUS SIX" || answerBox.Text == "minus six" || answerBox.Text == "Minus Six")
                {
                    canMakeMove = true;
                    decisionBox.Text = "Correct.";
                    nextButton.Enabled = false;
                    answerBox.Enabled = false;
                    boardmark();
                }
                else
                {
                    canMakeMove = false;
                    decisionBox.Text = "Incorrect! Click on 'Next'";
                    nextButton.Enabled = true;
                    checkButton.Enabled = false;
                    answerBox.Enabled = false;
                }
            }
        }

        bool checkClick;

        private void checkButton_Click(object sender, EventArgs e)
        {
            checkButton.Enabled = false;
            if (answerBox.Text == "")
            {
                decisionBox.Text = "Please type your answer!";
                checkButton.Enabled = true;
            }



            else
            {
                decider();
            }
        }

        bool nextClick;

        private void nextButton_Click(object sender, EventArgs e)
        {
            answerBox.Enabled = true;
            nextButton.Enabled = false;
            checkButton.Enabled = true;
            if (answerBox.Text == "")
            {
                decisionBox.Text = "First, type your answer!";
            }

            if (decisionBox.Text == "Correct.")
            {
                canMakeMove = true;
                answerBox.Text = "";
                decisionBox.Text = "";

                whenTimeTicks();
            }

            else if (decisionBox.Text == "Incorrect! Click on 'Next'")
            {
                nextButton.Enabled = true;
                canMakeMove = false;
                answerBox.Text = "";
                decisionBox.Text = "";

                whenTimeTicks();
            }
        }


    }
}