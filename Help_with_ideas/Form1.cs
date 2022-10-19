
namespace Help_with_ideas
{
    using System;
    using System.Collections.Generic;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddWorkSpace_Click(object sender, EventArgs e)
        {

            if (checkedListWorkSpace.Items.Contains(NewWorkSpace.Text))
            {
                TheResult.Text = "You have already added this item";

            }

            else
            {
                checkedListWorkSpace.Items.Add(NewWorkSpace.Text, true);
                NewWorkSpace.Text = "";

            }

        }

        private void AddMainIdea_Click(object sender, EventArgs e)
        {
            if (checkedListMainIdea.Items.Contains(NewMainIdea.Text))
            {
                TheResult.Text = "You have already added this item";

            }

            else
            {
                checkedListMainIdea.Items.Add(NewMainIdea.Text, true);
                NewMainIdea.Text = "";

            }

        }

        private void GetTheResult_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var WorkSpaces = new List<string>();

            foreach (var item in checkedListWorkSpace.CheckedItems)
            {

                WorkSpaces.Add(item.ToString());
            }

            var MainIdeas = new List<string>();

            foreach (var item in checkedListMainIdea.CheckedItems)
            {
                MainIdeas.Add(item.ToString());
            }

            if ((MainIdeas.Count == 0) || (WorkSpaces.Count == 0))
            {

                
                TheResult.Text = "Please choose items";

            }
            else
            {
                int indexWS = random.Next(WorkSpaces.Count);
                int indexMI = random.Next(MainIdeas.Count);

                TheResult.Text = WorkSpaces[indexWS] + "\n" + MainIdeas[indexMI];
            }

        }

    }
}