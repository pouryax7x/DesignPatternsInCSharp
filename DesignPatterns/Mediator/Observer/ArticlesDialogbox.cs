using System;

namespace DesignPatterns.Mediator.Observer
{
    public class ArticlesDialogbox 
    {
        private ListBox articleListBox = new ListBox();
        private TextBox titleTextBox= new TextBox();
        private Button saveButton = new Button();

        public ArticlesDialogbox()
        {
            articleListBox.Attach(new ObserverClass());  
        }
        public void simulateUserIntraction()
        {
            articleListBox.Selection = "Article1";
            titleTextBox.Content = "";
            titleTextBox.Content = "Article 2";
            Console.WriteLine("textBox " + titleTextBox.Content);
            Console.WriteLine("Button "  + saveButton.IsEnabled);
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
