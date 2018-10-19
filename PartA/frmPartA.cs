using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartA
{
    public partial class frmPartA : Form
    {
        StackList stack = new StackList();
        string stringHolder;
        public frmPartA()
        {
            InitializeComponent();
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            stack.Push(txtInput.Text);

            //Tried a for loop first, but it wasn't giving me the behavior I wanted
            /*
            for (int i = 0; i < stack.Count; i++)
            {
                richTextBox.AppendText(String.Format("{0}\n", stack[i]));            
            }
            */

            //So I made a while loop with an int that is reset every time the button is clicked
            //This seems to work the way I want
            int i = 0;
            richTextBox.Text = "";
            while( i < stack.Count){
                //Also had to figure out how to add stuff to a richtextbox again
                //Without blowing away the previous lines
                //Used this link: https://stackoverflow.com/questions/6485156/adding-strings-to-a-richtextbox-in-c-sharp/6485178
                richTextBox.AppendText(String.Format("{0}\n", stack[i]));
                i++;
            }            
            
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            //Compared to the push, this was easy! But mostly just because I figured out the 
            //while loop. Displaying the stack was the hardest part about this one
            stack.Pop();

            int i = 0;
            richTextBox.Text = "";
            while (i < stack.Count)
            {                
                richTextBox.AppendText(String.Format("{0}\n", stack[i]));
                i++;
            }
        }
    }
}
