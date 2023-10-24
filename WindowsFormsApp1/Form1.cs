using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Director director = new Director();
        IBuilder builder { get; set; }
        public static List<IBuilder> collection1 = new List<IBuilder>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(textBoxA.Text!="" && textBoxB.Text != "" && textBoxC.Text != "" && textBoxD.Text != "" && textBoxE.Text != "" && textBoxF.Text != "")
            switch (CompBox.Text)
            {
                case "Минимальная сборка":
                    {
                        builder = new MinComputerBuilder();
                        director.Builder = builder;
                        director.constructComputer(textBoxA.Text, textBoxB.Text, textBoxC.Text, textBoxD.Text, textBoxE.Text, textBoxF.Text);
                        collection1.Add(builder);
                        Coll1.Items.Add($"{Coll1.Items.Count+1} компьютер");
                        result.Text = "Компьютер с минимальной сборкой собран";
                        break;
                    }
                case "Рабочая сборка":
                    {
                        builder = new WorkstationComputerBuilder();
                        director.Builder = builder;
                        director.constructComputer(textBoxA.Text, textBoxB.Text, textBoxC.Text, textBoxD.Text, textBoxE.Text, textBoxF.Text);
                        collection1.Add(builder);
                        Coll1.Items.Add($"{Coll1.Items.Count + 1} компьютер");
                        result.Text = "Компьютер с рабочей сборкой собран";
                        break;
                    }
                case "Игровая сборка":
                    {
                        builder = new GamingComputerBuilder();
                        director.Builder = builder;
                        director.constructComputer(textBoxA.Text, textBoxB.Text, textBoxC.Text, textBoxD.Text, textBoxE.Text, textBoxF.Text);
                        collection1.Add(builder);
                        Coll1.Items.Add($"{Coll1.Items.Count + 1} компьютер");
                        result.Text = "Компьютер с игровой сборкой собран";
                        break;
                    }
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            int i =Coll1.SelectedIndex;
            result.Text = collection1[i].GetProduct().ToString();
        }
    }
}
