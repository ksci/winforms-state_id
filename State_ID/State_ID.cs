using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.appData;

namespace WindowsFormsApp1
{
    public partial class State_ID : Form
    {
        public State_ID()
        {
            InitializeComponent();
        }

        public List<State> GetStates()
        {
            var rand = new Random();
            List<int> state_nums = new List<int>(rand.Next(50));

            while (state_nums.Count() < 6)
            {
                var next = rand.Next(50);
                if (!state_nums.Contains(next))
                {
                    state_nums.Add(next);
                }
            }
            var states = new List<State>();
            foreach (var state in state_nums)
            {
                states.Add(StateRepository.States[state]);
            }

            return states;            
        }

        public void CreateQuestion(List<State> states)
        {
            var rand = new Random();
            var state_index = rand.Next(6);
            State correct_state = states[state_index];

            var incorrect_states = states.GetEnumerator();
            var buttons = QuestionBox.Controls.OfType<Button>().GetEnumerator();

            using (var e1 = incorrect_states)
            using (var e2 = buttons)
            {
                while (e1.MoveNext() && e2.MoveNext())
                {
                    var state = e1.Current;
                    var button = e2.Current;

                    button.Text = state.Name;
                }
            }
            StateRepository.correctAnswer = correct_state;
            StateRepository.pastStates.Add(correct_state);

            LoadNewPict(correct_state);
            //correctState.Text = correct_state.Name;

        }

        private void LoadNewPict(State state)
        {
            // You should replace the bold image
            // in the sample below with an icon of your own choosing.  
            // Note the escape character used (@) when specifying the path. 
            var path = state.PictureUrl;
            var directory = System.IO.Directory.GetCurrentDirectory();
            stateMap.Image = Image.FromFile(directory + path);
        }
        public void EvaluateAnswer(string name)
        {
            var correct = CheckAnswer(name);
            if (correct)
            {
                correctState.Text = "Correct!";
            }
            else
            {
                correctState.Text = "Incorrect!";
            }
        }


        public bool CheckAnswer(string name)
        {
            if (name == StateRepository.correctAnswer.Name)
            {
                return true;
            }
            return false;
        }

        private void newQuestionButton_Click(object sender, EventArgs e)
        {
            var states = GetStates();
            CreateQuestion(states);
            correctState.Text = "";
        }

        private void AnswerButton1_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            EvaluateAnswer(button.Text);
        }

        private void AnswerButton2_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            EvaluateAnswer(button.Text);
        }

        private void AnswerButton3_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            EvaluateAnswer(button.Text);
        }

        private void AnswerButton4_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            EvaluateAnswer(button.Text);
        }

        private void AnswerButton5_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            EvaluateAnswer(button.Text);
        }

        private void AnswerButton6_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            EvaluateAnswer(button.Text);
        }
    }
}
