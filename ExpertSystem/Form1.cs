using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class Form1 : Form
    {
        Analiz analiz;
        int numberQuestion = 0;
        //List<bool> answers;
        public Form1()
        {
            analiz = new Analiz();
            //answers = new List<bool>();
            InitializeComponent();
            checkBox.Checked = false;
            checkBox.Text = Expert.RulesList[numberQuestion].TextRule;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сохранил выбор
            Expert.RulesList[numberQuestion].Is = checkBox.Checked;
            checkBox.Checked = false;
            numberQuestion++;
            if (numberQuestion <= Expert.RulesList.Count-1)
            {
                checkBox.Text = Expert.RulesList[numberQuestion].TextRule;

                if (numberQuestion == Expert.RulesList.Count-1)
                {
                    button1.Text = "Завершить";
                    button1.Enabled = false;
                    labelType.Text = analiz.GetResult();
                }
            }
        }
    }
}
