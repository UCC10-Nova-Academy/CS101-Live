using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_AccessModifiers
{
    // public access örneği

    // 2 tane metot olacak bu sınıfın içinde
    // 1. üzerine gelen parametrelere göre bu class içinde tanımlı olan TutorialID(int) ve TutorialName(string) deüisgenlerin değerini atasın . setTutorial
    // 2.Bana en son girilen bilginin TutorialName.. bilgisini getirsin .. getTutorial
     

    // Yani bu yazılacak metotları ana programdan (Program.cs) çağıracak/kullanacak şekilde ayarlayın...ayrı bir .cs dosyası içinde olacak sekilde




    internal class clsTutorials
    {
        int TutorialID;
        string TutorialName;

        public void setTutorial(int pid,string pname)
        {
            this.TutorialID = pid;
            this.TutorialName = pname;
        }

        public string getTutorial()
        {
            return this.TutorialName;
        }
    }
}
