namespace CS_Gym
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Meet1_delegate meet1_Delegate = new Meet1_delegate();
            meet1_Delegate.Run();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meet1_Events meet1_Events = new Meet1_Events();
             
            Operate  operate  = new Operate();
            operate.Init();
        }
    }
}