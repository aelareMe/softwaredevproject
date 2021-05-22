using Project.Interface;
using Project.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class StudyHelper : Form, IStudyHelper
    {
        int set_progress;

        string _studyScheduleName = "";

        int _studyProgressId = 0;

        

        StudyHelperPresenter presenter;

        public StudyHelper(int _studyProgressId, string _studyScheduleName)
        {
            InitializeComponent();
            this._studyProgressId = _studyProgressId;
            this._studyScheduleName = _studyScheduleName;
            presenter = new StudyHelperPresenter(this);
        
            lblStudyName.Text = _studyScheduleName;
            set_progress = presenter.loadCurrentProgress();
            percentTb.Text = set_progress.ToString();
            setProgress(set_progress);
        }

        public string getProgress
        {
            get
            {
                return percentTb.Text;
            }
        }

        public ProgressBar GetProgressBar
        {
            get
            {
                return progressBar;

            }
        }

        public string studyScheduleName {
            get { return _studyScheduleName; }
            set { _studyScheduleName = value; }
        }
        public int studyProgressId  {
            get { return _studyProgressId; }
            set { _studyProgressId = value; }
        }

        public int percent {
            get { return set_progress; }
            set { set_progress = value; }
        }

        private void SetBtn_Click(object sender, EventArgs e)
        {
            int.TryParse((percentTb.Text), out set_progress);
            setProgress(set_progress);
        }

        private void setProgress(int set_progress) {

            if (set_progress > 100)
            {
                percentTb.Clear();
                percentLbl.Text = "0%";
                messageBox.Text = "Invalid Input!Please Try Again.";
                MessageBox.Show("Invalid Input! Try Again.");
            }
            else
            {
                for (int i = 0; i < Convert.ToInt32(set_progress); i++)
                {
                    progressBar.Value = i;
                    percentLbl.Text = "" + Convert.ToString(set_progress) + "%";

                }

                int diff = 100 - set_progress;

                messageBox.Text = "You have studied " + set_progress + "% and a remaining of " + diff + " % to achieve highest possible score!\n";
                dispMessage(set_progress);


            }
        }

        public void dispMessage(int set_progress)
        {
            if (set_progress > 0 && set_progress <= 2)
            {
                messageBox.Text += "The secret to getting ahead is getting started.";
            }
            else if (set_progress == 3 || set_progress == 4)
            {
                messageBox.Text += "The greatest amount of wasted time is the time not getting started.";
            }
            else if (set_progress == 5 || set_progress == 6)
            {
                messageBox.Text += "One day or day one? You decide.";
            }
            else if (set_progress == 7 || set_progress == 8)
            {
                messageBox.Text += "Start by doing what's necessary; then do what's possible; and suddenly you are doing the impossible.";
            }
            else if (set_progress == 9 || set_progress == 10)
            {
                messageBox.Text += "Be stronger than your excuses.";
            }
            else if (set_progress == 11 || set_progress == 12)
            {
                messageBox.Text += "All glory comes from daring to begin.";
            }
            else if (set_progress == 13 || set_progress == 14)
            {
                messageBox.Text += "The end may look far but never stop walking.";
            }
            else if (set_progress == 15 || set_progress == 16)
            {
                messageBox.Text += "Consistency is the key. You're doing good!";
            }
            else if (set_progress == 17 || set_progress == 18)
            {
                messageBox.Text += "Whatever the mind of man can conceive and believe, it can achieve.";
            }
            else if (set_progress == 19 || set_progress == 20)
            {
                messageBox.Text += "The end may be far but do not worry, you can do it!";
            }
            else if (set_progress == 21 || set_progress == 22)
            {
                messageBox.Text += "The hill may be steep but you can climb it.";
            }
            else if (set_progress == 23 || set_progress == 24)
            {
                messageBox.Text += "Remember that you will reap what you sow. Keep it up!";
            }
            else if (set_progress == 25 || set_progress == 26)
            {
                messageBox.Text += "You're at least 25% now. Congratulations and keep persevering";
            }
            else if (set_progress == 27 || set_progress == 28)
            {
                messageBox.Text += "Try study patterns that will work for you.";
            }
            else if (set_progress == 29 || set_progress == 30)
            {
                messageBox.Text += "Not bad! All efforts deserve recognition.";
            }
            else if (set_progress == 31 || set_progress == 32)
            {
                messageBox.Text += "Remember why you're doing this and stay motivated.";
            }
            else if (set_progress == 33 || set_progress == 34)
            {
                messageBox.Text += "Progress is progress. Do not stop no matter what.";
            }
            else if (set_progress == 35 || set_progress == 36)
            {
                messageBox.Text += "Try mixing things up if they don't seem to work for you.";
            }
            else if (set_progress == 37 || set_progress == 38)
            {
                messageBox.Text += "Tough times do not last; tough people do.";
            }
            else if (set_progress == 39 || set_progress == 40)
            {
                messageBox.Text += "You only fail when you stop trying so keep it up!";
            }
            else if (set_progress == 41 || set_progress == 42)
            {
                messageBox.Text += "Good things take time.";
            }
            else if (set_progress == 43 || set_progress == 44)
            {
                messageBox.Text += "You're doing really great right now. Remember that.";
            }
            else if (set_progress == 45 || set_progress == 46)
            {
                messageBox.Text += "You're going to get it. Toughen up!";
            }
            else if (set_progress == 47 || set_progress == 48)
            {
                messageBox.Text += "You rock! Keep your spirit up!";
            }
            else if (set_progress == 49 || set_progress == 50)
            {
                messageBox.Text += "You're already halfway there. You deserve a treat.";
            }
            else if (set_progress == 51 || set_progress == 52)
            {
                messageBox.Text += "Keep going until you reach it.";
            }
            else if (set_progress == 53 || set_progress == 54)
            {
                messageBox.Text += "Believe in yourself and anything is possible.";
            }
            else if (set_progress == 55 || set_progress == 56)
            {
                messageBox.Text += "Pat yourself for all the hardwork.";
            }
            else if (set_progress == 57 || set_progress == 58)
            {
                messageBox.Text += "Rest at the end, not in the middle.";
            }
            else if (set_progress == 59 || set_progress == 60)
            {
                messageBox.Text += "Don't count the days, make the days count.";
            }
            else if (set_progress == 61 || set_progress == 62)
            {
                messageBox.Text += "You've come a long way but the journey is not yet over. Take a rest.";
            }
            else if (set_progress == 63 || set_progress == 64)
            {
                messageBox.Text += "When we strive to become better than we are, everything aound us becomes better too.";
            }
            else if (set_progress == 65 || set_progress == 66)
            {
                messageBox.Text += "You're impeccable. Go and soar!";
            }
            else if (set_progress == 67 || set_progress == 68)
            {
                messageBox.Text += "You are stronger than you know.";
            }
            else if (set_progress == 69 || set_progress == 70)
            {
                messageBox.Text += "Do not give up.";
            }
            else if (set_progress == 71 || set_progress == 72)
            {
                messageBox.Text += "Do one thing every day that scares you.";
            }
            else if (set_progress == 73 || set_progress == 74)
            {
                messageBox.Text += "Dreams don't work unless you do.";
            }
            else if (set_progress == 75 || set_progress == 76)
            {
                messageBox.Text += "Look at how great you are. You're already at least 75%. Be proud!";
            }
            else if (set_progress == 77 || set_progress == 78)
            {
                messageBox.Text += "You are destined for greatness. Believe in yourself.";
            }
            else if (set_progress == 79 || set_progress == 80)
            {
                messageBox.Text += "When you have had a taste of excellence, you cannot go back to mediocrity.";
            }
            else if (set_progress == 81 || set_progress == 82)
            {
                messageBox.Text += "You have greatness in you. Be a beast.";
            }
            else if (set_progress == 83 || set_progress == 84)
            {
                messageBox.Text += "Your greatness is not what you have. It's what you give.";
            }
            else if (set_progress == 85 || set_progress == 86)
            {
                messageBox.Text += "Keep the efforts coming. You're close to achieving your dreams.";
            }
            else if (set_progress == 87 || set_progress == 88)
            {
                messageBox.Text += "Obstacles are the cost of greatness.";
            }
            else if (set_progress == 89 || set_progress == 90)
            {
                messageBox.Text += "You did not come this far to only come this far. Go further!";
            }
            else if (set_progress == 91 || set_progress == 92)
            {
                messageBox.Text += "It always seems impossible until it's done.";
            }
            else if (set_progress == 93 || set_progress == 94)
            {
                messageBox.Text += "Average is not your legacy.";
            }
            else if (set_progress == 95 || set_progress == 96)
            {
                messageBox.Text += "You're shining. Keep polishing yourself.";
            }
            else if (set_progress == 97 || set_progress == 98)
            {
                messageBox.Text += "Almost there. One more push left.";
            }
            else if (set_progress == 99 || set_progress == 100)
            {
                messageBox.Text += "Congratulations! Your efforts are commendable, indeed. Now, face the world and dominate.";
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.updateScheduledEvent();
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
