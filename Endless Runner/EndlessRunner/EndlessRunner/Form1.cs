using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndlessRunner
{
    public partial class Form1 : Form
    {
        const string highScoreFilePath = @"H:\Unit 16 OOP Jhora\video game project\Endless Runner\EndlessRunner\EndlessRunner\bin\Debug\Score.txt";
        string message;

        Player playerObj;
        Obstacles ObstacleOne;
        Obstacles ObstacleTwo;

        bool isGameOver = false;

        int tempInt = 0;

        int playerScore = 0;
        int jumpForce = 12;
        int jumpSpeed = 10;

        bool isJumping = false;

        int obstacleSpeed = 10;

        string newLine = Environment.NewLine;

        Image playerImage = Image.FromFile($@"H:\Unit 16 OOP Jhora\video game project\Endless Runner\EndlessRunner\EndlessRunner\bin\Debug\running.gif");
        Image obstacle1Image = Image.FromFile($@"H:\Unit 16 OOP Jhora\video game project\Endless Runner\EndlessRunner\EndlessRunner\bin\Debug\obstacle-1.gif");
        Image obstacle2Image = Image.FromFile($@"H:\Unit 16 OOP Jhora\video game project\Endless Runner\EndlessRunner\EndlessRunner\bin\Debug\obstacle-2.gif");

        Random random = new Random();
        
        List<Player> playerList = new List<Player>();   

        CSVReader reader = new CSVReader(highScoreFilePath);
        public Form1()
        {
            InitializeComponent();

            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InstantiateObjects();

            


            playerList = reader.GetAllPlayersFromFile();
            highscoreBox.Text = "High Score: " + playerList[0].playerScore.ToString();


        }

        private void gameEvent(object sender, EventArgs e)
        {

            playerCharacterBox.Top += playerObj.jumpSpeed;
            // show the score on the score text label
            scoreLBL.Text = "Score: " + playerObj.playerScore;

            // if jumping is true and force is less than 0
            // then change jumping to false
            if (playerObj.isJumping && playerObj.jumpForce < 0)
            {
                playerObj.isJumping = false;
            }
            // if jumping is true
            // then change jump speed to -12 
            // reduce force by 1
            if (playerObj.isJumping)
            {
                playerObj.jumpSpeed = -12;
                playerObj.jumpForce -= 1;
            }
            else
            {
                // else change the jump speed to 12
                playerObj.jumpSpeed = 12;
            }
            foreach (Control x in this.Controls)
            {
                // is X is a picture box and it has a tag of obstacle
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    x.Left -= obstacleSpeed; // move the obstacles towards the left
                    if (x.Left + x.Width < -120)
                    {
                        // if the obstacles have gone off the screen
                        // then we respawn it off the far right
                        // in this case we are calculating the form width and a random number between 200 and 800
                        x.Left = this.ClientSize.Width + random.Next(200, 800);
                        // we will add one to the score
                        playerObj.playerScore++;
                    }
                    // if the t rex collides with the obstacles
                    if (playerCharacterBox.Bounds.IntersectsWith(x.Bounds))
                    {

                        // we stop the timer
                        gameTimer.Stop();
                        // change the t rex image to the dead one
                        playerCharacterBox.Image = Image.FromFile($@"H:\Unit 16 OOP Jhora\video game project\Endless Runner\EndlessRunner\EndlessRunner\bin\Debug\dead.png");
                        // show press r to restart on the score text label
                        scoreLBL.Text += "  Press R to restart";
                        isGameOver = true;

                        if (isGameOver == true)
                        {
                            highscoreBox.Text = $"High Score: {playerObj.playerScore}";
                        }

                    }
                }
            }
            // if the t rex top is greater than or equals to 380 AND
            // jumping is not true
            if (playerCharacterBox.Top >= 380 && !playerObj.isJumping)
            {
                // then we do the following
                playerObj.jumpForce = 12; // set the force to 12
                playerCharacterBox.Top = floor.Top - playerCharacterBox.Height; // also we place the player on top of the picture box
                jumpSpeed = 0; // set the jump speed to 0
            }
            // if score is equals or greater than 10
            if (playerObj.playerScore >= 10)
            {
                // the obstacle speed change to 15
                obstacleSpeed = 15;
            }
            
            if (isGameOver == true)
            {
                //playerObj.playerScore = playerScore;
                reader.AddPlayers(playerObj);
                reader.WriteAllPlayersToFile();
                foreach (Player p in playerList)
                {
                    message += $"High Score: {p.playerScore}" + newLine;
                }
                highscoreBox.Text = message;
               
            }

        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !playerObj.isJumping)
            {
                playerObj.isJumping = true;
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                ResetGame();
            }

        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {

            //when the keys are released we check if jumping is true
            // if so we need to set it back to false so the player can jump again
            if (playerObj.isJumping)
            {
                playerObj.isJumping = false;
            }
        }

        public void ResetGame()
        {
            //playerList = reader.GetAllPlayersFromFile();
            // This is the reset function
            isGameOver = false;
            jumpForce = 12; // set the force to 8
            playerCharacterBox.Top = floor.Top - playerCharacterBox.Height; // also we place the player on top of the picture box
            jumpSpeed = 0; // set the jump speed to 0
            isJumping = false; // change jumping to false
            playerScore = 0; // set score to 0
            obstacleSpeed = 10; // set obstacle speed back to 10
            scoreLBL.Text = "Score: " + playerScore; // change the score text to just show the score
            playerCharacterBox.Image = playerImage;

            playerList.Clear();

            InstantiateObjects();
            foreach (Control x in this.Controls)
            {
                // is X is a picture box and it has a tag of obstacle
                if (x is PictureBox && x.Tag == "obstacle")
                {
                    // generate a random number in the position integer between 600 and 1000
                    int position = this.ClientSize.Width + random.Next(500, 600) + (x.Width * 10);
                    // change the obstacles left position to a random location begining of the game
                    x.Left = 640 + (x.Left + position + x.Width * 3);
                }
            }



            
            gameTimer.Start(); // start the timer
        }

        public void InstantiateObjects()
        {

            playerObj = new Player(playerImage, isJumping, jumpForce, playerScore, jumpSpeed);

            ObstacleOne = new Obstacles(obstacle1Image, obstacleSpeed);
            ObstacleTwo = new Obstacles(obstacle2Image, obstacleSpeed);

            obstacle1.Image = ObstacleOne.obstacleImg;
            obstacle2.Image = ObstacleTwo.obstacleImg;

            playerCharacterBox.Image = playerObj.characterImg;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
