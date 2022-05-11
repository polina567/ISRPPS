using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command
{
    //вызывающий
    public partial class Form1 : Form
    {
        private List<Command> commands = new List<Command>();
        private Complex result;
        private int current = 0;
        //конструктор
        public Form1()
        {
            InitializeComponent();
        }
        //справка
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show( "Для использования калькулятора введите все данные (действительные и мнимые части интересующих чисел, не забывайте про знаки). Если какая-либо часть комплексного числа равна нулю, то введите 0. Не забывайте про существование коэффициента!\n\n");
        }
        //печать результата
        public void Print() { textBoxRes.Text = result.Print(); }
        //функция повторить
        public void Redo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current < commands.Count)
                {
                    result = commands[current++].Execute();
                    Print();
                }
        }
        //функция отменить
        public void Undo(int levels)
        {
            for (int i = 0; i < levels; i++)
                if (current > 0)
                {
                    result = commands[--current].UnExecute();
                    Print();
                }
        }
        //функция подсчета
        public void Compute(Command command)
        {
            result = command.Execute();
            commands.Add(command);
            current++;
            Print();
        }

        private void Назад_Click(object sender, EventArgs e)
        {
            Undo(1);
        }

        private void Повторить_Click(object sender, EventArgs e)
        {
            Redo(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Command command = new SumCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Command command = new SubtractionCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Command command = new MultiplicationCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Command command = new SegmentationCommand(new Complex(Convert.ToDouble(textBoxA1.Text), Convert.ToDouble(textBoxB1.Text)),
                                             new Complex(Convert.ToDouble(textBoxA2.Text), Convert.ToDouble(textBoxB2.Text)));
            Compute(command);
        }
    }
}
