using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;


namespace SnakeGame
{
    public partial class SnakeGameForm : Form
    {
        public SnakeGameForm()
        {
            InitializeComponent();
            
        }

        const int SnakeSquareSize = 20;
        const int SnakeStartLength = 3;
        const int SnakeStartSpeed = 400;
        const int SnakeSpeedThreshold = 100;


        public enum SnakeDirection { Left, Right, Up, Down };
        private SnakeDirection snakeDirection = SnakeDirection.Right;
        private List<SnakePart> snakeParts = new List<SnakePart>();

        private Random rnd = new Random();

        private int currentScore = 0;
        private int snakeLength ;

        private System.Drawing.Point snakeFood;
        //定义蛇身
        private Graphics upperGraph;


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            MoveSnake();
        }

        //开始按钮
        private void buttonStart_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            StartNewGame();
        }


        
        //绘制游戏区域
        private void GameArea_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //绘制边框
            g.DrawLine(new Pen(Color.Silver, 20), 0,0,0,420);
            g.DrawLine(new Pen(Color.Silver, 20), 0, 0, 420, 0);
            g.DrawLine(new Pen(Color.Silver, 20), 420, 420, 0, 420);
            g.DrawLine(new Pen(Color.Silver, 20), 420, 420, 420, 0);
            //绘制游戏方格
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Rectangle rect = new Rectangle(10 + i * 20, 10 + j * 20, 20, 20);
                    if ((i + j) % 2 == 0)
                    {
                        g.FillRectangle(Brushes.Black, rect);
                    }
                    else
                    {
                        g.FillRectangle(Brushes.White, rect);
                    }
                }
            }

        }

        //开始新游戏
        private void StartNewGame()
        {
            //清除蛇身列表
            snakeParts.Clear();
            

            // Reset stuff
            currentScore = 0;
            snakeLength = SnakeStartLength;
            snakeDirection = SnakeDirection.Right;
            snakeParts.Add(new SnakePart() { Position = new System.Windows.Point(SnakeSquareSize * 5, SnakeSquareSize * 5) });
            snakeParts.Add(new SnakePart() { Position = new System.Windows.Point(SnakeSquareSize * 6, SnakeSquareSize * 5) });
            snakeParts.Add(new SnakePart() { Position = new System.Windows.Point(SnakeSquareSize * 7, SnakeSquareSize * 5) });
            GameTimer.Interval = (SnakeStartSpeed);
            upperGraph = this.GameArea.CreateGraphics();
            // Draw the snake again and some new food...
            GameArea.Refresh();
            FreshSnakeFood();
            DrawSnakeAndFood();

            // Update status
            UpdateGameStatus();

            // Go!        
            GameTimer.Enabled = true;
        }

        private void DrawSnakeAndFood()
        {
            GameArea.Refresh();
            if (snakeParts.Count == 0)
            {
                snakeParts.Add(new SnakePart() { Position = new System.Windows.Point(SnakeSquareSize * 5, SnakeSquareSize * 5) });
            }

            List<Rectangle> rects = new List<Rectangle>();

            foreach (SnakePart snakePart in snakeParts)
            {

                rects.Add(new Rectangle(10 + (int)snakePart.Position.X, 10 + (int)snakePart.Position.Y, SnakeSquareSize, SnakeSquareSize));
            }

            

            upperGraph.FillRectangles(Brushes.Green, rects.ToArray());
            upperGraph.FillRectangle(Brushes.GreenYellow, rects[rects.Count-1]);
            upperGraph.FillRectangle(Brushes.Orange, new Rectangle(snakeFood.X+10,snakeFood.Y+10, SnakeSquareSize, SnakeSquareSize));


        }

        private void MoveSnake()
        {
            // Remove the last part of the snake, in preparation of the new part added below  
            while (snakeParts.Count >= snakeLength)
            {
                
                snakeParts.RemoveAt(0);
            }
           

            // Determine in which direction to expand the snake, based on the current direction  
            SnakePart snakeHead = snakeParts[snakeParts.Count - 1];
            double nextX = snakeHead.Position.X;
            double nextY = snakeHead.Position.Y;
            switch (snakeDirection)
            {
                case SnakeDirection.Left:
                    nextX -= SnakeSquareSize;
                    break;
                case SnakeDirection.Right:
                    nextX += SnakeSquareSize;
                    break;
                case SnakeDirection.Up:
                    nextY -= SnakeSquareSize;
                    break;
                case SnakeDirection.Down:
                    nextY += SnakeSquareSize;
                    break;
            }

            // Now add the new head part to our list of snake parts...  
            snakeParts.Add(new SnakePart()
            {
                Position = new System.Windows.Point(nextX, nextY),
                IsHead = true
            });
            
            //... and then have it drawn!  
            DrawSnakeAndFood();
            // Finally: Check if it just hit something!  
            DoCollisionCheck();
        }
        //获得食物的下一个位置，避开贪吃蛇身体
        private System.Drawing.Point GetNextFoodPosition()
        {
            int maxX = (int)(GameArea.Width / SnakeSquareSize) - 1;
            int maxY = (int)(GameArea.Height / SnakeSquareSize) - 1;
            int foodX = rnd.Next(0, maxX) * SnakeSquareSize;
            int foodY = rnd.Next(0, maxY) * SnakeSquareSize;

            foreach (SnakePart snakePart in snakeParts)
            {
                if ((snakePart.Position.X == foodX) && (snakePart.Position.Y == foodY))
                    return GetNextFoodPosition();
            }

            return new System.Drawing.Point(foodX, foodY);
        }

        private void FreshSnakeFood()
        {
            //刷新食物位置
            snakeFood = GetNextFoodPosition();

        }

        //碰撞检测：对吃到食物、吃到边框和碰到自己的贪吃蛇身体进行检测
        private void DoCollisionCheck()
        {
            SnakePart snakeHead = snakeParts[snakeParts.Count - 1];
            //Console.WriteLine("Collision: {0} {1}",snakeHead.Position ,snakeFood);
            if (((int)snakeHead.Position.X == snakeFood.X) && ((int)snakeHead.Position.Y == snakeFood.Y))
            {
                EatSnakeFood();
                return;
            }

            if ((snakeHead.Position.Y < 10) || (snakeHead.Position.Y >= GameArea.Height - 30) ||
            (snakeHead.Position.X < 10) || (snakeHead.Position.X >= GameArea.Width - 30))
            {
                EndGame();
            }

            foreach (SnakePart snakeBodyPart in snakeParts.Take(snakeParts.Count - 1))
            {
                if ((snakeHead.Position.X == snakeBodyPart.Position.X) && (snakeHead.Position.Y == snakeBodyPart.Position.Y))
                    EndGame();
            }
        }

        private void EatSnakeFood()
        {
            snakeLength++;
            currentScore++;
            int timerInterval = Math.Max(SnakeSpeedThreshold, (int)GameTimer.Interval - (currentScore * 2));
            GameTimer.Interval = timerInterval;

            //DrawSnakeFood();
            FreshSnakeFood();
            UpdateGameStatus();
        }
        //更新游戏分数
        private void UpdateGameStatus()
        {
            this.labelScoreText.Text = currentScore.ToString();
        }

        private void EndGame()
        {
            GameTimer.Enabled = false;
            MessageBox.Show("游戏结束，得分:"+currentScore.ToString());
        }
        //响应击键
        private void SnakeGameForm_KeyUp(object sender, KeyEventArgs e)
        {
            SnakeDirection originalSnakeDirection = snakeDirection;
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (snakeDirection != SnakeDirection.Down)
                        snakeDirection = SnakeDirection.Up;
                    break;
                case Keys.Down:
                    if (snakeDirection != SnakeDirection.Up)
                        snakeDirection = SnakeDirection.Down;
                    break;
                case Keys.Left:
                    if (snakeDirection != SnakeDirection.Right)
                        snakeDirection = SnakeDirection.Left;
                    break;
                case Keys.Right:
                    if (snakeDirection != SnakeDirection.Left)
                        snakeDirection = SnakeDirection.Right;
                    break;
                case Keys.Space:
                    StartNewGame();
                    break;
            }
            if (snakeDirection != originalSnakeDirection)
                MoveSnake();
        }
    }
}
