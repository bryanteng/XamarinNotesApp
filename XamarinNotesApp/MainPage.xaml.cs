using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinNotesApp
{
    public partial class MainPage : ContentPage
    {
        public IList<Note> Notes { get; private set; }

        public MainPage()
        {
            InitializeComponent();

            Notes = new List<Note>();
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
    }
}