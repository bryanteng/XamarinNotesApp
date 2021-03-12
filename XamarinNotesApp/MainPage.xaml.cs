using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace XamarinNotesApp
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Note> Notes { get; set; }
        public string titleField { get; set; }

        public string detailField { get; set; }

        public MainPage()
        {
            InitializeComponent();

            titleField = "Enter title here";
            detailField = "Enter detail here";

            Notes = new ObservableCollection<Note>();
            Notes.Add(new Note
            {
                Title = "Chores",
                Detail = "Dishes and Laundry",
            });

            Notes.Add(new Note
            {
                Title = "Homework",
                Detail = "Math and science",
            });

            BindingContext = this;
        }
        void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Note selectedItem = e.CurrentSelection[0] as Note;
        }

        void New_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewEntryPage());
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            System.Console.WriteLine(newText);
        }

        void OnEntryCompleted(object sender, System.EventArgs e)
        {
            string text = ((Entry)sender).Text;
        }

        public void OnClicked(object sender, System.EventArgs e)
        {
            Note temp = new Note() { Title = titleField, Detail = detailField };
            Notes.Add(temp); 
            titleField = "Enter title here";
            detailField = "Enter detail here";
            System.Console.WriteLine(Notes.Count);
        }
    }
}