using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    public class ArticlesDialogbox : DialogBox
    {
        private ListBox articleListBox;
        private TextBox titleTextBox;
        private Button saveButton;
        
        public ArticlesDialogbox()
        {
            this.saveButton = new Button(this);
            this.titleTextBox = new TextBox(this);
            this.articleListBox = new ListBox(this);
        }

        public void simulateUserIntraction()
        {
            articleListBox.Selection = "Article1";
            titleTextBox.Content = "";
            titleTextBox.Content = "Article 2";
            Console.WriteLine("textBox " + titleTextBox.Content);
            Console.WriteLine("Button "  + saveButton.IsEnabled);
        }
        public override void Changed(UIControl control)
        {
            if (control == articleListBox)
            {
                ArticleSelected();
            }
            else if (control == titleTextBox)
            {
                titleChanged();
            }
        }

        private void titleChanged()
        {
            var content = titleTextBox.Content;
            var isEmpty = (content == null || string.IsNullOrWhiteSpace(content));
            saveButton.IsEnabled = !isEmpty;
        }

        private void ArticleSelected()
        {
            titleTextBox.Content = articleListBox.Selection;
            saveButton.IsEnabled = true;
        }
    }
}
