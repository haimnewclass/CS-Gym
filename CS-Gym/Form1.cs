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

        private void button3_Click(object sender, EventArgs e)
        {
            Meet2_foreach meet2_Foreach = new Meet2_foreach();
            meet2_Foreach.RunMyItems();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Meet3_RefVal meet3_RefVal = new Meet3_RefVal();
            meet3_RefVal.Val();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Meet4_Linq_1 meet4_Linq_1 = new Meet4_Linq_1();
            meet4_Linq_1.Run3();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Meet5_ExtensionMethods meet5_ExtensionMethods = new Meet5_ExtensionMethods();
            meet5_ExtensionMethods.Run();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Meet5_GarbageCollector meet5_GarbageCollector = new Meet5_GarbageCollector();   

        }
    }
}