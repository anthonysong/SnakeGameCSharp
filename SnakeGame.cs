using System.Windows;

namespace SnakeGame
{
    internal class SnakeGame
    {
    }

    public class SnakePart
    {
        //public UIElement UiElement { get; set; }

        public Point Position { get; set; }

        public bool IsHead { get; set; }
    }

    ////食物类
    //public class Bean
    //{
    //    //用于画食物的顶端坐标
    //    private Point _origin;

    //    public Point Origin
    //    {
    //        get { return _origin; }
    //        set { _origin = value; }
    //    }

    //    //显示食物
    //    public void ShowBean(Graphics g)
    //    {
    //        //定义红色的画笔
    //        SolidBrush brush = new SolidBrush(Color.Red);
    //        //画实心矩形表示食物
    //        g.FillRectangle(brush, Origin.X, Origin.Y, 15, 15);
    //    }

    //    public void UnShowBean(Graphics g)
    //    {
    //        //定义系统背景颜色的画笔
    //        SolidBrush brush = new SolidBrush(Color.Silver);
    //        //画实心矩形颜色为系统背景颜色，相当于食物被吃掉了
    //        g.FillRectangle(brush, Origin.X, Origin.Y, 15, 15);
    //    }
    //}

    ////蛇身体的每一单元，简称块
    //public class Block
    //{
    //    //是否为蛇头
    //    private bool _isHead;

    //    public bool IsHead
    //    {
    //        get { return _isHead; }
    //        set { _isHead = value; }
    //    }
    //    //蛇块的编号
    //    private int _blockNumber;

    //    public int BlockNumber
    //    {
    //        get { return _blockNumber; }
    //        set { _blockNumber = value; }
    //    }
    //    //蛇块的左上角位置
    //    private Point _origin;

    //    public Point Origin
    //    {
    //        get { return _origin; }
    //        set { _origin = value; }
    //    }

    //    //根据指定位置画蛇块
    //    public void ShowBlock(Graphics g)
    //    {
    //        Bitmap bitMap;
    //        if (IsHead)
    //        {
    //            //蛇头
    //            bitMap = new Bitmap(Image.FromFile("Blue.gif"));
    //        }
    //        else
    //        {
    //            bitMap = new Bitmap(Image.FromFile("Yellow.gif"));
    //        }
    //        g.DrawImage(bitMap, Origin.X, Origin.Y, 15, 15);
    //    }

    //    //消除蛇块
    //    public void UnShowBlock(Graphics g)
    //    {
    //        SolidBrush brush = new SolidBrush(Color.Silver);
    //        g.FillRectangle(brush, Origin.X, Origin.Y, 15, 15);
    //    }
    //}

    //public class Snake
    //{
    //    //用于存放蛇的集合
    //    private List<Block> blocksList;
    //    //0-上，1-右，2-下，3-左
    //    private int direction = 1;
    //    //蛇头的编号，蛇的长度
    //    private int headNumber;
    //    //蛇头左上角坐标
    //    private Point headPoint;
    //    private Point mapLeft;
    //    //游戏开始时，初始的蛇
    //    public Snake(Point map, int count)
    //    {
    //        mapLeft = map;
    //        Block blockSnake;
    //        //定义蛇的起始位置（蛇尾）
    //        Point p = new Point(map.X + 15, map.Y + 15);
    //        blocksList = new List<Block>();
    //        //循环画蛇块用于填充蛇集合
    //        for (int i = 0; i < count; i++)
    //        {
    //            //x坐标加15
    //            p.X += 15;
    //            //实例化蛇块
    //            blockSnake = new Block();
    //            //定义蛇块的左上角位置
    //            blockSnake.Origin = p;
    //            //定义蛇块的编号1，2，3...
    //            blockSnake.BlockNumber = i + 1;
    //            if (i == count - 1)
    //            {
    //                //蛇头
    //                //给蛇头位置赋值
    //                headPoint = blockSnake.Origin;
    //                blockSnake.IsHead = true;
    //            }
    //            blocksList.Add(blockSnake);

    //        }
    //        //蛇的长度赋值
    //        headNumber = count;
    //    }
    //    //蛇头坐标的只读属性
    //    public Point HeadPoint
    //    {
    //        get { return headPoint; }
    //    }
    //    //蛇的运动方向的属性
    //    public int Direction
    //    {
    //        get { return direction; }
    //        set { direction = value; }
    //    }
    //    /// <summary>
    //    /// 蛇的转换方向
    //    /// </summary>
    //    /// <param name="pDirection">想要改变的方向</param>
    //    public void TurnDirection(int pDirection)
    //    {
    //        switch (direction)
    //        {
    //            //原来向上运动
    //            case 0:
    //                //希望向左运动
    //                if (pDirection == 3)
    //                    direction = 3;
    //                //希望向右运动
    //                else if (pDirection == 1)
    //                    direction = 1;
    //                break;
    //            //原来向右运动
    //            case 1:
    //                //下
    //                if (pDirection == 2)
    //                    direction = 2;
    //                //上
    //                else if (pDirection == 0)
    //                    direction = 0;
    //                break;
    //            case 2:
    //                if (pDirection == 1)
    //                    direction = 1;
    //                else if (pDirection == 3)
    //                    direction = 3;
    //                break;
    //            case 3:
    //                if (pDirection == 0)
    //                    direction = 0;
    //                else if (pDirection == 2)
    //                    direction = 2;
    //                break;


    //        }
    //    }

    //    public Point getHeadPoint //只读蛇头位置属性
    //    {
    //        get { return headPoint; }
    //    }
    //    //蛇吃到食物后变长，蛇头+1
    //    public void SnakeGrowth()
    //    {
    //        //找到蛇头的坐标
    //        Point head = blocksList[blocksList.Count - 1].Origin;
    //        int x = head.X;
    //        int y = head.Y;
    //        //判断蛇的运动方向,改变蛇头的位置
    //        switch (direction)
    //        {
    //            case 0:
    //                //向上运动
    //                y -= 15;
    //                break;
    //            case 1:
    //                x += 15;
    //                break;
    //            case 2:
    //                y += 15;
    //                break;
    //            case 3:
    //                x -= 15;
    //                break;
    //        }
    //        //把原先蛇头的块变为普通块
    //        blocksList[blocksList.Count - 1].IsHead = false;
    //        //实例化新蛇头
    //        Block headNew = new Block();
    //        headNew.IsHead = true;
    //        headNew.BlockNumber = blocksList.Count + 1;
    //        headNew.Origin = new Point(x, y);
    //        blocksList.Add(headNew);
    //        headNumber++;
    //        headPoint = headNew.Origin;
    //    }

    //    //蛇向前运动（没有吃到食物的情况），蛇尾移除，蛇头移位+1
    //    public void Go(Graphics g)
    //    {
    //        Block snakeTail = blocksList[0];
    //        //消除蛇尾块
    //        snakeTail.UnShowBlock(g);
    //        //集合中移除设为块
    //        blocksList.RemoveAt(0);
    //        foreach (var item in blocksList)
    //        {
    //            item.BlockNumber--;
    //        }
    //        //由于SnakeGrowth中仅仅使蛇头+1，但是headNumber++了。但是此值并没有改变，所以先--
    //        headNumber--;
    //        SnakeGrowth();
    //    }

    //    //画出蛇
    //    public void ShowSnake(Graphics g)
    //    {
    //        foreach (var item in blocksList)
    //        {
    //            item.ShowBlock(g);
    //        }
    //    }
    //    //隐藏蛇
    //    public void UnShowSnake(Graphics g)
    //    {
    //        foreach (var item in blocksList)
    //        {
    //            item.UnShowBlock(g);
    //        }
    //    }
    //    //重置蛇
    //    public void Reset(Point map, int count)
    //    {
    //        Block blockSnake;
    //        //定义蛇的起始位置（蛇尾）
    //        Point p = new Point(mapLeft.X + 15, mapLeft.Y + 15);
    //        blocksList = new List<Block>();
    //        //循环画蛇块用于填充蛇集合
    //        for (int i = 0; i < count; i++)
    //        {
    //            //x坐标加15
    //            p.X += 15;
    //            //实例化蛇块
    //            blockSnake = new Block();
    //            //定义蛇块的左上角位置
    //            blockSnake.Origin = p;
    //            //定义蛇块的编号1，2，3...
    //            blockSnake.BlockNumber = i + 1;
    //            if (i == count - 1)
    //            {
    //                //蛇头
    //                //给蛇头位置赋值
    //                headPoint = blockSnake.Origin;
    //                blockSnake.IsHead = true;
    //            }
    //            blocksList.Add(blockSnake);

    //        }
    //        //蛇的长度赋值
    //        headNumber = count;
    //        direction = 1;
    //    }
    //    //是否碰到自己
    //    public bool IsTouchMyself()
    //    {
    //        bool isTouched = false;
    //        for (int i = 0; i < blocksList.Count - 1; i++)
    //        {
    //            if (headPoint == blocksList[i].Origin)
    //            {
    //                isTouched = true;
    //                break;
    //            }
    //        }
    //        return isTouched;
    //    }
    //}

    //public class Map
    //{
    //    private Point mapLeft;
    //    private static int unit = 15;
    //    //定义地图长，为28个蛇块的长度
    //    private readonly int length = 30 * unit;
    //    //定义地图宽，为20个蛇块的宽度
    //    private readonly int width = 25 * unit;
    //    //定义分数
    //    public int score = 0;
    //    //定义蛇
    //    private readonly Snake snake;
    //    public bool victory = false;
    //    public Snake Snake
    //    {
    //        get { return snake; }
    //    }

    //    Bean food;
    //    public Map(Point start)
    //    {
    //        //把地图左上角的点的值赋值给全局变量
    //        mapLeft = start;
    //        //实例化蛇
    //        snake = new Snake(start, 5);
    //        //实例化食物
    //        food = new Bean();
    //        food.Origin = new Point(start.X + 30, start.Y + 30);
    //    }
    //    //显示新食物
    //    public void ShowNewFood(Graphics g)
    //    {
    //        //消除原先食物
    //        food.UnShowBean(g);
    //        //产生随机位置的食物
    //        food = FoodRandom();
    //        //显示食物
    //        food.ShowBean(g);
    //    }
    //    //随机产生一个新食物
    //    private Bean FoodRandom()
    //    {
    //        Random d = new Random();
    //        int x = d.Next(0, length / unit);
    //        int y = d.Next(0, width / unit);
    //        Point origin = new Point(mapLeft.X + x * 15, mapLeft.Y + y * 15);
    //        Bean food = new Bean();
    //        food.Origin = origin;
    //        return food;
    //    }
    //    //画地图
    //    public void ShowMap(Graphics g)
    //    {
    //        //创建一支红笔
    //        Pen pen = new Pen(Color.Blue);
    //        //画出地图的框
    //        g.DrawRectangle(pen, mapLeft.X, mapLeft.Y, length, width);
    //        //显示食物
    //        food.ShowBean(g);
    //        if (CheckBean())
    //        {
    //            //吃到了食物
    //            //显示新食物
    //            ShowNewFood(g);
    //            //蛇变长
    //            snake.SnakeGrowth();
    //            //分数增加
    //            score += 10;
    //            //if (score >= 100)
    //            //{
    //            //    victory = true;
    //            //}
    //            //显示蛇
    //            snake.ShowSnake(g);
    //        }
    //        else
    //        {
    //            snake.Go(g);
    //            snake.ShowSnake(g);
    //        }
    //    }
    //    //判断是否吃到了食物
    //    public bool CheckBean()
    //    {

    //        return food.Origin.Equals(snake.HeadPoint);
    //    }

    //    //检查蛇是否撞墙
    //    public bool CheckSnake()
    //    {
    //        return !(snake.getHeadPoint.X > mapLeft.X - 5 && snake.getHeadPoint.X < (mapLeft.X + length - 5) && snake.getHeadPoint.Y > mapLeft.Y - 5 && snake.getHeadPoint.Y < (mapLeft.Y + width - 5));
    //    }

    //    //重新开始
    //    public void Reset(Graphics g)
    //    {
    //        snake.UnShowSnake(g);
    //        snake.Reset(mapLeft, 5);
    //    }
    //}

}
