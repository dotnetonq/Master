using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWeb
{
    public partial class MyUserControl : System.Web.UI.UserControl
    {
         TextBox MyTextBox = new TextBox();

         Button MyButton = new Button();

         ListBox MyListBox = new ListBox();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateChildControls();
        }

        protected override void CreateChildControls()

         {
           

            base.CreateChildControls();

            Controls.Add(MyTextBox);

            Controls.Add(MyButton);

            Controls.Add(MyListBox);

            MyButton.Text = "Change Vowels";

            }

            protected void Render(System.Web.UI.HtmlTextWriter writer)

            {
                 base.Render(writer);

            }

                 public String changeVowels(String s)

                 {

                 s.Replace("A", "O");

                 s.Replace("E", "A");

                 s.Replace("I", "U");

                 s.Replace("O", "E");

                 s.Replace("U", "I");

                 return MyListBox.SelectedItem.ToString() +s;

                 }

                 void MyButton_Click(object sender, EventArgs e)

                 {

                 MyButton.Text = changeVowels(MyTextBox.Text);

                 try

                 {

                 StreamWriter SW = File.AppendText("c:\\MyTextFile.txt");

                 SW.WriteLine(MyTextBox.Text);

                 SW.Flush();

                 }

                 catch (Exception ex)

                 {

                }


                 }

                        }
                    }
                