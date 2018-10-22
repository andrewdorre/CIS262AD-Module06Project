/*
 * Andrew Dorre
 * Module 06 Project
 * Part B
 * 
 * This program generates 10 random numbers, and sorts them in order, displaying them in a richtextbox.
 * A user can enter any number into the field, and it will automatically add the number to the correct
 * spot in the list. When a user decides to hit "Calculate" it will display the sum of all numbers in the
 * list, and an average of all numbers in floating point format.
 * 
 * Test Cases:
 *              1. 240          -> (random numbers should be in correct order, 240 should be at the end since
 *                                  the random numbers are set for 0-99) Sum and average would be calculated correctly
 *                                   but since numbers are random, I can't display the exact solution here
 *              2. 999999999    -> (random numbers should be in correct order, 999999999 should be at the end since
 *                                  the random numbers are set for 0-99) Sum and average would be calculated correctly,
 *                                  however, they would most likely appear in scientific notation
 *              3. 0
 *              4. <empty field>
 * 
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * This is by far the hardest program I've had to make. I spent hours and hours trying to sort
 * the list without much success. I googled it a couple of times to try and figure out what
 * was going on. There were some solutions (that don't use existing sort methods for generic lists or arrays)
 * but they were complicated. About the only real one I could find talked about a pivot point, and
 * using the lower and higher numbers on each side of the pivot point, but I had a really hard time
 * following what they were doing.
 * For whatever reason, trying to traverse through a list and compare each data point never worked. I tried
 * making some methods for this in the LinkedList class, but it just hurts my head even trying to think
 * about how to get it working.
 * Finally a solution hit me that was really simple. I could use two lists, one empty and one full
 * of the unordered, random numbers. I would just find the lowest number in the unordered list, add it
 * to the empty list, and remove it from the first list. Rinse and repeat.
 * Honestly, this kind of felt like cheating. I'm not exactly sure what was expected on this project, but
 * I get the feeling I was supposed to make a method in the linkedlist that checks the numbers and modifies
 * the node references somehow. I just couldn't wrap my head around how to do that.
 * I went over the BetterCoder videos again and rebuilt the entire node and linkedlist classes to try 
 * and get a better understanding of them. I think that is partly what helped me come up with this
 * solution at least. I'm still kind of foggy on the specifics of lists, but I understand the concept
 * really well I think.
 * 
 * TL;DR: felt like I cheated by using two lists and the remove method. Sorry for the wall o' text.
 */ 
namespace PartB
{    
    public partial class frmPartB : Form
    {
        //List that will store the numbers
        LinkedList list1 = new LinkedList();
        //list2 will start empty, and then be filled with the random numbers in the correct order
        LinkedList list2 = new LinkedList();

        Random rand = new Random();        
        
        public frmPartB()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                list1.Add(rand.Next(100));
            }
            //This was for debugging purposes. I was listing the disordered random list
            //above what I wanted to be an ordered list
            /*
            for (int n = 0; n < list1.Count; n++)
            {
                richTextBox1.AppendText((int)list1.Get(n) + "\n");
            }
            */
            //These variables are for storing information on the numbers that are being sorted
            int sortNumber = 0;
            int indexNumber = 0;
            //while loop made sense once I figured out the crucial piece: removing items from one list 
            //and adding them to another.
            //Basically, while there are items still in list1, take each number and compare it against every other.
            //If it is greater than the number, then the variable becomes the lower number. Once the lowest number is
            //picked, add it to list2, and remove it from list1. Then, repeat, with one less item in list1 to compare
            while (list1.Count > 0)
            {
                for (int i = 0; i < list1.Count; i++)
                {
                    sortNumber = (int)list1.Get(i);
                    for (int n = 0; n < list1.Count; n++)
                    {
                        //not sure why but it has to be >= not >. My brain hurts too much to understand why
                        if (sortNumber >= (int)list1.Get(n))
                        {
                            sortNumber = (int)list1.Get(n);
                            indexNumber = n;
                        }
                    }
                    list2.Add(sortNumber);
                    list1.Remove(indexNumber);
                }
            }
            //these were just for spacing between my disordered list and the attempt at an ordered list
            //richTextBox1.AppendText("\n\n");
            //Here I'm just outputting what would hopefully be the ordered list. This took me WAY too long to
            //figure out.
            for (int n = 0; n < list2.Count; n++)
            {
                richTextBox1.AppendText((int)list2.Get(n) + "\n");
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Sort of similar to the ordering I did above, I needed two variables
            //To hold info, one for the data, one for the index number
            int userIndex = 0;
            int userInput = 0;
            //I was going to use a normal textbox again, but since this is all about numbers
            //I decided to use a masked text box. I set it to 9 digits, since an int max is somewhere in
            //the 2,000,000,000 range. I think for the purpose of this project it works fine,
            //and it prevents a lot of errors with non-number entries.
            //I still had to put something in for the case of an empty field though
            //I tried mskTextInput.Equals("") and .Equals(null), but finally had to google and found this:
            //https://stackoverflow.com/questions/17757612/how-to-check-if-a-maskedtextbox-is-empty-from-a-user-input
            //int failParse;
            if (txtInput.Equals(""))
            {
                userInput = 0;

                //Once again, iterate through the list until the user data is larger than
                //the data point in the list. At that point, set the index to one past the
                //node of the data point.
                for (int n = 0; n < list2.Count; n++)
                {
                    //not sure why but it has to be >= not >. My brain hurts too much to understand why
                    if (userInput >= (int)list2.Get(n))
                    {
                        userIndex = n + 1;
                    }
                }
                //And then add the data to the correct point in the linked list
                list2.Add(userIndex, userInput);

                //Here I'm clearing out the richtextbox so that it will refresh the list
                //on the screen. The instructions said to display it on "Calculate", but 
                //I figured this made it easier to see. Hopefully not a problem.
                richTextBox1.Text = "";

                for (int n = 0; n < list2.Count; n++)
                {
                    richTextBox1.AppendText((int)list2.Get(n) + "\n");
                }
            }
                
            else if (!(int.TryParse(txtInput.Text, out int failParse)))
            {
                MessageBox.Show("Numbers only!");
                txtInput.Text = "";                
            }
            else
            {                
                userInput = int.Parse(txtInput.Text);

                //Once again, iterate through the list until the user data is larger than
                //the data point in the list. At that point, set the index to one past the
                //node of the data point.
                for (int n = 0; n < list2.Count; n++)
                {
                    //not sure why but it has to be >= not >. My brain hurts too much to understand why
                    if (userInput >= (int)list2.Get(n))
                    {
                        userIndex = n + 1;
                    }
                }
                //And then add the data to the correct point in the linked list
                list2.Add(userIndex, userInput);

                //Here I'm clearing out the richtextbox so that it will refresh the list
                //on the screen. The instructions said to display it on "Calculate", but 
                //I figured this made it easier to see. Hopefully not a problem.
                richTextBox1.Text = "";

                for (int n = 0; n < list2.Count; n++)
                {
                    richTextBox1.AppendText((int)list2.Get(n) + "\n");
                }
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Compared to everything else, this was super easy. A couple variables to 
            //hold the sum and the average.
            float sum = 0;
            float average = 0;
            //iterate through every data point in the list and add them together
            for (int i = 0; i < list2.Count; i++)
            {
                sum += (int)list2.Get(i);
            }
            //divide the sum of all items by the number of items for the average
            average = sum / list2.Count;
            //Display the results. viola
            lblCalc.Text = "Sum: " + sum.ToString() + " Average: " + average;
            lblCalc.Visible = true;
            /*
            richTextBox1.AppendText("\n\n");
            for (int n = 0; n < randoms.Length; n++)
            {
                richTextBox1.AppendText(String.Format("{0}\n", randoms[n]));
            }
            */
        }
    }
}
