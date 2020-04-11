using System;
using Xamarin.Forms;

namespace HackUpp.Models
{
    public class postVM
    {
        public User Publisher { get; set; }
        public DateTime Date { get; set; }
        public ImageSource Photo { get; set; }
        public string Title { get; set; }
        public int Vote { get; set; }               
        public string Description { get; set; }
        public string Subtitle { get; set; }

    }
}
