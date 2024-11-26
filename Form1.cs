namespace HW.WishList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeWishList();
        }

        private void InitializeWishList()
        {
            ListView listView1 = new ListView
            {
                View = View.Details,
                CheckBoxes = true,
                FullRowSelect = true,
                GridLines = true,
                Dock = DockStyle.Fill
            };

            listView1.Columns.Add("", 40);
            listView1.Columns.Add("", 5);
            listView1.Columns.Add("Название", 150);
            listView1.Columns.Add("Цена", 100);

            string[] items = { "Получить права", "Начать работать дизайнером на фрилансе", "Летняя резина на машину", "Татуировка", "Купить квартиру" };
            int[] prices = { 22000, 0, 8000, 10000, 1000000 };
            ImageList imageList = new ImageList();

            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\Rog\Desktop\icons\sheet_13824321.png"));
            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\Rog\Desktop\icons\paint_1313511.png"));
            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\Rog\Desktop\icons\wheel_10745657.png"));
            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\Rog\Desktop\icons\tattoo_1685860.png"));
            imageList.Images.Add(Bitmap.FromFile(@"C:\Users\Rog\Desktop\icons\house_1353008.png"));

            listView1.SmallImageList = imageList;

            for (int i = 0; i < items.Length; i++)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.SubItems.Add("");
                listItem.SubItems.Add(items[i]);
                listItem.SubItems.Add(prices[i].ToString() + " грн");
                listItem.ImageIndex = i;

                listView1.Items.Add(listItem);
            }
            this.Controls.Add(listView1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
