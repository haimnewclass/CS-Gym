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

        private void button8_Click(object sender, EventArgs e)
        {
            Meet6_check meet6_Check = new Meet6_check();
            meet6_Check.Run();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Meet6_isas meet6_Isas = new Meet6_isas();
            meet6_Isas.Run();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Meet6_idispose meet6_Idispose = new Meet6_idispose();
            meet6_Idispose.Run();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Meet7_type meet7_Type = new Meet7_type();
            meet7_Type.Run1();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Meet8_Generics meet8_Generics = new Meet8_Generics();
            meet8_Generics.Run();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Meet9_JSON_Serialization meet9_JSON_Serialization = new Meet9_JSON_Serialization();
            meet9_JSON_Serialization.RunDe();
        }
    }
}