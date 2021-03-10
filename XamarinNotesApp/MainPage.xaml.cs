using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinNotesApp
{
    public partial class MainPage : ContentPage
    {
        public IList<Note> Notes { get; set; }
        public string titleField { get; set; }

        public string detailField { get; set; }

        public MainPage()
        {
            InitializeComponent();

            titleField = "Enter title here";
            detailField = "Enter detail here";

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

        void New_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new NewEntryPage());
        }

        public void OnClicked(object sender, System.EventArgs e)
        {
            Notes.Add(new Note
            {
                Title = titleField,
                Detail = detailField
            });
            titleField = "Enter title here";
            detailField = "Enter detail here";
        }
    }
}