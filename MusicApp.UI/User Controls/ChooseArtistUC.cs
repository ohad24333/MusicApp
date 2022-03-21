using MusicApp.Entities.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MusicApp.UI.User_Controls
{
    public partial class ChooseArtistUC : UserControl
    {
        public List<Artist> Artists { get; set; } = new List<Artist>();
        public ChooseArtistUC()
        {
            InitializeComponent();
            comboxSearchBy.Items.Add("Name");
            comboxSearchBy.Items.Add("Id");
            comboxSearchBy.SelectedIndex = 1;
        }

        public static Action<List<Artist>> EditArtistFound;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (comboxSearchBy.SelectedItem)
            {
                case "Name":
                    Artists = MusicForm.UserManager.SearchArtists(txtSearchInsert.Text);


                    break;
                case "Id":
                    Artists.Clear();
                    Artist artist = MusicForm.UserManager.SearchArtist(int.Parse(txtSearchInsert.Text));
                    if (artist != null)
                    {
                        Artists.Add(artist);
                    }
                    else
                    {
                        MessageBox.Show("Id Is Invalid");
                    }
                    break;
                default:
                    break;
            }
            if (Artists == null)
            {
                MessageBox.Show("Atrist didnt found");
            }
            else
            {
                EditArtistFound(Artists);
            }
        }

       
    }
}
