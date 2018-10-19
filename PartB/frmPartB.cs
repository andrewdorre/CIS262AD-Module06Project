using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartB
{    

    public partial class frmPartB : Form
    {
        //List that will store the numbers
        LinkedList list = new LinkedList();
        //Array to store initial 10 random numbers?
        int[] randoms = new int[10];
        //Random number generator
        Random rand = new Random();
                
        
        public frmPartB()
        {
            InitializeComponent();

            for (int i = 0; i < randoms.Length; i++)
            {
                randoms[i] = rand.Next(100);                
            }
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            for (int n = 0; n < randoms.Length; n++)
            {
                if (list.IsEmpty())
                {
                    list.InsertAtFront(randoms[n]);
                }
                else
                {
                    list.Compare(randoms[n], (int)list.Get(n));
                }
            }
            for (int n = 0; n < randoms.Length; n++)
            {
                richTextBox1.AppendText("\n" + (int)list[n]);                
            }
            richTextBox1.AppendText("\n\n");
            for (int n = 0; n < randoms.Length; n++)
            {
                richTextBox1.AppendText(String.Format("{0}\n", randoms[n]));
            }
        }
    }
}
