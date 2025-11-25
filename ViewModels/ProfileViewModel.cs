using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Progress_Test.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        // Split data into two columns for the Masonry effect
        public ObservableCollection<Artwork> LeftColumnArtworks { get; set; }
        public ObservableCollection<Artwork> RightColumnArtworks { get; set; }

        public string Biography { get; set; }

        // ... (Keep your existing IsBioExpanded logic) ...
        private bool _isBioExpanded;
        public bool IsBioExpanded
        {
            get => _isBioExpanded;
            set
            {
                _isBioExpanded = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(ReadMoreText));
                OnPropertyChanged(nameof(BioMaxLines));
                OnPropertyChanged(nameof(BioLineBreakMode));
            }
        }
        public string ReadMoreText => IsBioExpanded ? "Read Less" : "Read More";
        public int BioMaxLines => IsBioExpanded ? 100 : 2;
        public LineBreakMode BioLineBreakMode => IsBioExpanded ? LineBreakMode.WordWrap : LineBreakMode.TailTruncation;


        public ProfileViewModel()
        {
            Biography = "Vincent Willem van Gogh was a Dutch Post-Impressionist painter who is among the most famous and influential figures in the history of Western art. In just over a decade, he created about 2,100 artworks, including around 860 oil paintings, most of them in the last two years of his life.";

            // COLUMN 1 (LEFT)
            LeftColumnArtworks = new ObservableCollection<Artwork>
            {
                // Peach Tree (TALL / Portrait) -> Height 260
                new Artwork { Title = "Peach Tree in Blossom", Price = "$950,000", ImageUrl = "drawfive.jpeg", ImageHeight = 260 },

                // Starry Night Over the Rhone (WIDE / Landscape) -> Height 160
                new Artwork { Title = "Starry Night Over the Rhone", Price = "$1,200,000", ImageUrl = "drawone.jpeg", ImageHeight = 160 },

                // Wheat Field (WIDE) -> Height 160
                new Artwork { Title = "Wheat Field with Cypresses", Price = "$3,500,000", ImageUrl = "drawfour.jpeg", ImageHeight = 160 }
            };

            // COLUMN 2 (RIGHT)
            RightColumnArtworks = new ObservableCollection<Artwork>
            {
                 // Starry Night (WIDE) -> Height 160
                new Artwork { Title = "The Starry Night", Price = "$10,000,000", ImageUrl = "drawtwo.jpeg", ImageHeight = 160 },

                // Sunflowers (TALL / Portrait) -> Height 260
                new Artwork { Title = "Sunflowers", Price = "$5,000,000", ImageUrl = "drawsix.jpeg", ImageHeight = 260 },

                // Yellow House (WIDE) -> Height 160
                new Artwork { Title = "The Yellow House", Price = "$2,000,000", ImageUrl = "drawseven.jpeg", ImageHeight = 160 }
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        // Change 'string' to 'string?'
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    public class Artwork
    {
        public required string Title { get; set; }
        public required string Price { get; set; }
        public required string ImageUrl { get; set; }
        public double ImageHeight { get; set; } 
    }
}