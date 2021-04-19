using Project.Interface;
using Project.Object;
using Project.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Presenter
{
    class MainPagePresenter
    {
        IMainPage iMainPage;
        public MainPagePresenter(IMainPage iMainPage)  {
            this.iMainPage = iMainPage;

        }

        public void showAddSubjects() {
            Add_Subject open_add_subject = new Add_Subject(iMainPage.userInfo);
            open_add_subject.Show();
        }

        public UserInfObject getUserObj() {
            return iMainPage.userInfo;
        }


        public void showTaskScheduler() {
            ActSched scheduler = new ActSched(iMainPage.userInfo);
            scheduler.Show();
        }

        public void showStudyHelper() {
            StudyHelper studyHelper = new StudyHelper();
            studyHelper.Show();
        }


    }
}
