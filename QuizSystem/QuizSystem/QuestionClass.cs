using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizSystem
{
    class QuestionClass
    {
        private string subject;
        private string question;
        private string option1;
        private string option2;
        private string option3;
        private string option4;
        private string answer;

        public string Subject
        {
            get
            {
                return subject;
            }

            set
            {
                subject = value;
            }
        }

        public string Question
        {
            get
            {
                return question;
            }

            set
            {
                question = value;
            }
        }

        public string Option1
        {
            get
            {
                return option1;
            }

            set
            {
                option1 = value;
            }
        }

        public string Option2
        {
            get
            {
                return option2;
            }

            set
            {
                option2 = value;
            }
        }

        public string Option3
        {
            get
            {
                return option3;
            }

            set
            {
                option3 = value;
            }
        }

        public string Option4
        {
            get
            {
                return option4;
            }

            set
            {
                option4 = value;
            }
        }

        public string Answer
        {
            get
            {
                return answer;
            }

            set
            {
                answer = value;
            }
        }
    }
}
