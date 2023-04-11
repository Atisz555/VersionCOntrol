using fact_pattern2.Abstraction;
using fact_pattern2.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fact_pattern2
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        private Toy _nextToy;
        private IToyFactory _factory;

        public IToyFactory Factory
        {
            get { return _factory; }
            set { _factory = value; DisplayNext(); }
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new BallFactory();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var toy = Factory.CreateNew();
            _toys.Add(toy);
            toy.Left = -toy.Width;
            mainPanel.Controls.Add(toy);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var toy in _toys)
            {
                toy.MoveToy();
                if (maxPosition < toy.Left)
                {   
                    maxPosition = toy.Left;
                }
            }
            if (maxPosition > 2000)
            {
                var oldToy = _toys[0];
                mainPanel.Controls.Remove(oldToy);
                _toys.Remove(oldToy);
            }
        }

        private void btn_SelectCar_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void btn_selectBall_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }

        private void DisplayNext()
        {
            if (_nextToy != null)
                Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label_Next.Top + label_Next.Height + 20;
            _nextToy.Left = label_Next.Left;
            Controls.Add(_nextToy);
        }
    }

}
