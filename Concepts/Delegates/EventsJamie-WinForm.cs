using System;
using System.Windows.Forms;

class MainClass
{
    static Random random = new Random();
    static void Main()
    {
        var but1 = new Button() { Text = "Button 1" , Left = 50};
        var but2 = new Button() { Text = "Button 2", Top = 100};
        but1.MouseMove += mouseMoved;
        but2.MouseMove += mouseMoved;
        var form = new Form();
        form.Controls.Add(but1);
        form.Controls.Add(but2);
        Application.Run(form);
    }

    static void mouseMoved(object sender, MouseEventArgs e)
    {
        Button b = (Button)sender;
        b.Top = random.Next() % 200;
        b.Left = random.Next() % 200;
        //MessageBox.Show("You moved the mouse : " + e.Location);
    }
}