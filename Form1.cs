using System.Media;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> listSongs = new List<string>();
        SoundPlayer sp = new SoundPlayer();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开文件";
            ofd.InitialDirectory = @"C:\Users\VEY\Desktop\Pictures";
            ofd.Multiselect = true;
            ofd.Filter = "音乐|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            string[] path = ofd.FileNames;
            for(int i = 0; i < path.Length; i++)
            {
                listMusicView.Items.Add(Path.GetFileName(path[i]));
                listSongs.Add(path[i]);
            }
        }

        private void listMusicView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sp.SoundLocation = listSongs[listMusicView.SelectedIndex];
            sp.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int index = listMusicView.SelectedIndex;
            index++;
            if(index == listMusicView.Items.Count)
            {
                index = 0;
            }

            listMusicView.SelectedIndex = index;

            sp.SoundLocation = listSongs[index];
            sp.Play();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int index = listMusicView.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = listMusicView.Items.Count - 1;
            }

            listMusicView.SelectedIndex = index;
            

            sp.SoundLocation = listSongs[index];
            sp.Play();
        }
    }
}