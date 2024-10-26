using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Tra_Cứu_Điểm_Sinh_Viên
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<string, string> studentScores = new Dictionary<string, string>
        {
            { "SV001", "8.5" },
            { "SV002", "7.0" },
            { "SV003", "9.0" },
            { "SV004", "6.5" },
            { "SV005", "5.0" },
            { "SV006", "3.5" },
            { "SV007", "4.0" }
        };
        private void btn_tracuu_Click(object sender, EventArgs e)
        {
            string studentID = txt_tracuu.Text.Trim();
            if (studentScores.ContainsKey(studentID))
            {
                string score = studentScores[studentID];
                txt_diem.Text = $"{score}";
            }
            else
            {
                txt_diem.Text = "NO";
            }
        }
    }
}
