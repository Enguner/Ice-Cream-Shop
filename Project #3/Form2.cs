using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project__3
{
    public partial class Form2 : Form
    {

        public Form2(string data)
        {
            InitializeComponent();
            label2.Text = data;
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(481, 72);
            label1.TabIndex = 0;
            label1.Text = "Heres Your Order:";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(52, 113);
            label2.Name = "label2";
            label2.Size = new Size(818, 364);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // btnOk
            // 
            btnOk.Location = new Point(313, 644);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(320, 63);
            btnOk.TabIndex = 2;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // Form2
            // 
            ClientSize = new Size(933, 739);
            Controls.Add(btnOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Display Order";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Button btnOk;
        private Label label2;

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
