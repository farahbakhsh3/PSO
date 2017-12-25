using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace PSO
{
    public partial class frmPlotPSO : Form
    {
        double[,,] plotSwarmPositions;
        double[,] plotGlobalPositions;
        public int maxIter;
        public int maxSwarm;
        public bool _Closing = false;
        public PlotStatus PlotStatusN = PlotStatus.Play;

        public frmPlotPSO(double[,,] PlotSwarmPsition, double[,] PlotGlobalPosition)
        {
            InitializeComponent();
            plotSwarmPositions = (double[,,])PlotSwarmPsition.Clone();
            plotGlobalPositions = (double[,])PlotGlobalPosition.Clone();
            maxIter = plotSwarmPositions.GetLength(0);
            maxSwarm = plotSwarmPositions.GetLength(1);
        }

        public void PauseForMilliSeconds(int T)
        {
            DateTime TimeA = DateTime.Now;
            DateTime TimeB = TimeA.AddMilliseconds((double)T);

            while (TimeB >= TimeA)
            {
                Application.DoEvents();
                TimeA = DateTime.Now;
            }
        }

        public int GetIterN()
        {
            int i = chartPSO.Series[0].Points.Count ;
            return i;
        }

        void ShowTitle()
        {
            this.Text = "Iter: " + (GetIterN()-1) + "  Of  " + (maxIter-1)  + "  --    Swarm Size:  " + maxSwarm;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeriesChartType chType = new SeriesChartType();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    chType = SeriesChartType.Spline;
                    break;
                case 1:
                    chType = SeriesChartType.Point;
                    break;
                case 2:
                    chType = SeriesChartType.Line;
                    break;
            }
            for (int Swarm = 0; Swarm < maxSwarm; Swarm++)
            {
                chartPSO.Series[Swarm].ChartType = chType;
            }
        }

        private void frmPlotPSO_Shown(object sender, EventArgs e)
        {
            InitChart();
            UpdatePlotControls();
            PlayPlot();
        }

        void InitChart()
        {
            Random _MarkerStyle = new Random();

            chartPSO.Series.Clear();
            for (int i = 0; i < maxSwarm; i++)
            {
                chartPSO.Series.Add("Swarm(" + i + ")");
                chartPSO.Series[i].ChartType = SeriesChartType.Spline;
                chartPSO.Series[i].MarkerStyle = (MarkerStyle)_MarkerStyle.Next(1, 10);
                chartPSO.Series[i].MarkerSize = 10;
            }
            chartPSO.Series.Add("GlobalPosition");
            chartPSO.Series[maxSwarm].ChartType = SeriesChartType.Point;
            chartPSO.Series[maxSwarm].MarkerStyle = MarkerStyle.Circle;
            chartPSO.Series[maxSwarm].Color = Color.Black;
            chartPSO.Series[maxSwarm].MarkerSize = 20;
        }

        private void frmPlotPSO_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Closing = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PlotSwarmIter_RemoveAll();
        }

        void PlotSwarmIter_RemoveAll()
        {
            for (int Swarm = 0; Swarm < maxSwarm; Swarm++)
            {
                chartPSO.Series[Swarm].Points.Clear();
            }
            chartPSO.Series[maxSwarm].Points.Clear();
            PlotSwarmIter_Point();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            PlotSwarmIter_Remove();
        }

        void PlotSwarmIter_Remove()
        {
            if (GetIterN() <= 1)
                return;

            int i = GetIterN() - 1;
            for (int Swarm = 0; Swarm < maxSwarm; Swarm++)            
                chartPSO.Series[Swarm].Points.RemoveAt(i );

            i = GetIterN() - 1;
            chartPSO.Series[maxSwarm].Points.Clear();
            chartPSO.Series[maxSwarm].Points.AddXY(plotGlobalPositions[i , 0], plotGlobalPositions[i, 1]);

            ShowTitle();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            PlotSwarmIter_Point();
        }

        void PlotSwarmIter_Point()
        {
            int iterN = GetIterN();
            if (iterN >= maxIter)
                return;
            for (int Swarm = 0; Swarm < maxSwarm; Swarm++)
            {
                chartPSO.Series[Swarm].Points.AddXY(plotSwarmPositions[iterN, Swarm, 0], plotSwarmPositions[iterN, Swarm, 1]);
            }
            chartPSO.Series[maxSwarm].Points.Clear();
            chartPSO.Series[maxSwarm].Points.AddXY(plotGlobalPositions[iterN, 0], plotGlobalPositions[iterN, 1]);

            iterN = Math.Min(iterN + 1, maxIter - 1);
            ShowTitle();
        }

        private void btnPLay_Click(object sender, EventArgs e)
        {
            PlayPlot();
        }

        void PlayPlot()
        {
            int iterN = GetIterN();
            _Closing = false;
            if (iterN >= maxIter)
                return;
            PlotStatusN = PlotStatus.Play;
            UpdatePlotControls();
            for (int iter = iterN; iter < maxIter; iter++)
            {
                if (_Closing)
                {
                    _Closing = false;
                    return;
                }
                PlotSwarmIter_Point();
                PauseForMilliSeconds(Math.Max((Math.Min((maxIter - iter) / maxSwarm, 70)), 30));
            }
            PlotStatusN = PlotStatus.Pause;
            UpdatePlotControls();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PlotStatusN = PlotStatus.Pause;
            UpdatePlotControls();
            _Closing = true;
        }
        void UpdatePlotControls()
        {
            switch (PlotStatusN)
            {
                case PlotStatus.Play:
                    btnBack.Enabled = false;
                    btnPrev.Enabled = false;
                    btnPLay.Enabled = false;
                    btnNext.Enabled = false;
                    break;
                case PlotStatus.Pause:
                    btnBack.Enabled = true;
                    btnPrev.Enabled = true;
                    btnPLay.Enabled = true;
                    btnNext.Enabled = true;
                    break;
            }
        }
    }
    public enum PlotStatus
    {
        Play, Pause
    }
}