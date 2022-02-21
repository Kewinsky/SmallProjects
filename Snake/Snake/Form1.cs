namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle> ();
        private Circle food = new Circle ();
        public Form1()
        {
            InitializeComponent();

            //Set settings to default
            new Settings();

            // Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen();
            gameTimer.Start ();

            // Start New Game
            StartGame();
        }

        private void StartGame()
        {
            //Set settings to default
            new Settings();

            //Create new player object
            Snake.Clear();
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            lblScore.Text = Settings.Score.ToString();
            GenerateFood();

        }

        // Place random food
        private void GenerateFood()
        {
            int maxXpos = pbCanvas.Size.Width/Settings.Width;
            int maxYpos = pbCanvas.Size.Height/Settings.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pbCanvas_Load(object sender, EventArgs e)
        {

        }
    }
}