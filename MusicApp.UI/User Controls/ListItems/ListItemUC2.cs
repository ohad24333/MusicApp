using MusicApp.UI.Enums;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MusicApp.UI
{
    public partial class ListItemUC2 : UserControl
    {
      
        public ListItemUC2()
        {
            InitializeComponent();
          
        }

        public static Action<int,TypesEnum> BannerClickEvent2;


        #region Props

        private string _title;

        private string _info;

        private Image _icon;

        private Color _iconBackground;

        private int _id;

        private TypesEnum type;

        public TypesEnum Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        [Category("Custom Props")]
        public Color IconBackground
        {
            get { return _iconBackground; }
            set { _iconBackground = value; panel1.BackColor = value; }
        }


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        [Category("Custom Props")]
        public string Info
        {
            get { return _info; }
            set { _info = value; lblText.Text = value; }
        }
        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
        }

        #endregion


        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;

        }
       

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            BannerClickEvent2(this.Id, this.Type);

        }

        private void ListArtistsItemUC_MouseClick(object sender, MouseEventArgs e)
        {
            BannerClickEvent2(this.Id,this.Type);
        }

        private void lblText_Click(object sender, EventArgs e)
        {
            BannerClickEvent2(this.Id, this.Type);
        }

     
    }
}
