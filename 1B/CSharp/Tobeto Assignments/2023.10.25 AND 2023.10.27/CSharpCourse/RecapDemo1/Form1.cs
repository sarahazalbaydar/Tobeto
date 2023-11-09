namespace RecapDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button button = new Button();       //button nesnesini oluþturduk
            //button.Width = 75;
            //button.Height = 75;
            ////button.Text = "My button";
            //this.Controls.Add(button);          //button'u ekrana koyar
            ////ayný iþlemden farklý nesneler oluþt. onlarý kontrol altýnda tutmak istiyoruz

            GenerateButtons();

        }

        private void GenerateButtons()
        {
            Button[,] buttons = new Button[8, 8];
            int top = 0;
            int left = 0;
            for (int i = 0; i <= buttons.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= buttons.GetUpperBound(1); j++)
                {
                    buttons[i, j] = new Button();
                    buttons[i, j].Width = 75;
                    buttons[i, j].Height = 75;
                    buttons[i, j].Left = left;
                    buttons[i, j].Top = top;
                    left += 75;
                    if ((i + j) % 2 == 0)
                    {
                        buttons[i, j].BackColor = Color.Black;
                    }
                    else
                    {
                        buttons[i, j].BackColor = Color.White;
                    }


                    this.Controls.Add(buttons[i, j]);    //this'den kasýt Form1'dir. Form1'e kontrollerini ekle (her bir button için bunu yapmak lazým)
                }
                top += 75;
                left = 0;
            }
        }
    }
}