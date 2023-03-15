namespace _5_угол
{
    public partial class Forma_zadanie : Form
    {
        public Forma_zadanie()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Forma_zadanie_Load(object sender, EventArgs e)
        {
            // 1. Объявить экземпляр типа GraphicsPath - класс биб-лиотеки .NET Framework,
            // который устанавливает последовательность соединенных линий и кривых.
            System.Drawing.Drawing2D.GraphicsPath gp = new
            System.Drawing.Drawing2D.GraphicsPath();

            // 2. Создать массив точек, соответствующих координатам
            //    пятиугольника, образовывающего форму.
            // 2.1. Объявить экземпляр типа "массив точек Point[]".
            //    Point - это класс, который описывает точку на экране.
            Point[] mp = new Point[5];

            // 2.2. Выделить память для каждой точки и заполнить
            //         ее значениями.
            mp[0] = new Point(50, 150);
            mp[1] = new Point(100, 20);
            mp[2] = new Point(300, 20);
            mp[3] = new Point(350, 150);
            mp[4] = new Point(200, 270);

            // 3. Добавить массив точек Point[] в экземпляр gp
            gp.AddPolygon(mp);

            // 4. Создать область (Region) на основе последователь-ности точек gp
            Region rg = new Region(gp);

            // 5. Установить область формы this.Region
            //       в новое значение rg
            this.Region = rg;
            
        }
    }
}