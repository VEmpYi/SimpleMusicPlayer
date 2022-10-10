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
        SoundPlayer sp = new();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "打开文件";
            ofd.InitialDirectory = @"C:\Users\VEY\Desktop\Picture";
            ofd.Multiselect = true;
            ofd.Filter = "音乐|*.wav|所有文件|*.*";
            ofd.ShowDialog();
            string[] path = ofd.FileNames;
            for(int i = 0; i < path.Length; i++)
            {
                listMusicView.Items.Add(Path.GetFileNameWithoutExtension(path[i]));
                listSongs.Add(path[i]);
            }
        }

        private void listMusicView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            sp.SoundLocation = listSongs[listMusicView.SelectedIndex];
            sp.PlayLooping();
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
            sp.PlayLooping();
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
            sp.PlayLooping();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            listSongs.Clear();
            listMusicView.Items.Clear();
        }
        



        private void cMS_listMV_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

            if (listMusicView.SelectedIndex == -1)
            {
                delSingleSong.Visible = false;
            }
            else
            {
                delSingleSong.Visible = true;
            }
            
        }

        private void delAllSongs_Click(object sender, EventArgs e)
        {
            listSongs.Clear();
            listMusicView.Items.Clear();
        }

        private void delSingleSong_Click(object sender, EventArgs e)
        {
            int index = listMusicView.SelectedIndex;
            listSongs.Remove(listSongs[index]);
            listMusicView.Items.RemoveAt(index);
        }
    }
}