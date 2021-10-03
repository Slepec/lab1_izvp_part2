using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_izvp_part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hashtable hashtable = new Hashtable();
       
        private void Form1_Load(object sender, EventArgs e)
        {
            hashtable.Add("Перша книга","Фантастика;Сігов");
            hashtable.Add("Друга книга", "Класичний;Сігов");
            hashtable.Add("Третя книга", "Детектив;Січов");
            hashtable.Add("Четверта книга", "Класичний;Сиров");
            foreach(DictionaryEntry de in hashtable)
            {
                string[] values = de.Value.ToString().Split(';');
                dataGridView1.Rows.Add(de.Key, values[0], values[1]);

            }
          
            foreach (DictionaryEntry de in hashtable)
            {
                string[] values = de.Value.ToString().Split(';');
                if(values[0].ToString().ToLower()=="класичний")
                    dataGridView2.Rows.Add(de.Key, values[0], values[1]);
            }
            dataGridView2.Sort(dataGridView2.Columns[2],ListSortDirection.Descending);
            label3.Text = "Кількість класичних книг: "+(dataGridView2.Rows.Count-1)+"\n";
            int num = dataGridView2.Rows.Count-1;
            if(dataGridView1.Rows.Count-num-1< num) { 
                label3.Text += "Класичних книг більше ніж інших на " + Math.Abs(dataGridView1.Rows.Count - num*2 - 1); 
            }
            else if (dataGridView1.Rows.Count - num - 1 == num)
            {
                label3.Text += "Класичних книг порівну ";
            }else label3.Text += "Класичних книг менше ніж інших на " + Math.Abs(dataGridView1.Rows.Count - num * 2 - 1);
        }
    }
}
