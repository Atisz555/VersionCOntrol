
namespace fact_pattern2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_SelectCar = new System.Windows.Forms.Button();
            this.btn_selectBall = new System.Windows.Forms.Button();
            this.label_Next = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(36, 89);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(734, 313);
            this.mainPanel.TabIndex = 3;
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_SelectCar
            // 
            this.btn_SelectCar.Location = new System.Drawing.Point(36, 22);
            this.btn_SelectCar.Name = "btn_SelectCar";
            this.btn_SelectCar.Size = new System.Drawing.Size(75, 23);
            this.btn_SelectCar.TabIndex = 0;
            this.btn_SelectCar.Text = "Car";
            this.btn_SelectCar.UseVisualStyleBackColor = true;
            this.btn_SelectCar.Click += new System.EventHandler(this.btn_SelectCar_Click);
            // 
            // btn_selectBall
            // 
            this.btn_selectBall.Location = new System.Drawing.Point(122, 22);
            this.btn_selectBall.Name = "btn_selectBall";
            this.btn_selectBall.Size = new System.Drawing.Size(75, 23);
            this.btn_selectBall.TabIndex = 1;
            this.btn_selectBall.Text = "Ball";
            this.btn_selectBall.UseVisualStyleBackColor = true;
            this.btn_selectBall.Click += new System.EventHandler(this.btn_selectBall_Click);
            // 
            // label_Next
            // 
            this.label_Next.AutoSize = true;
            this.label_Next.Location = new System.Drawing.Point(218, 22);
            this.label_Next.Name = "label_Next";
            this.label_Next.Size = new System.Drawing.Size(70, 13);
            this.label_Next.TabIndex = 4;
            this.label_Next.Text = "Coming Soon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Next);
            this.Controls.Add(this.btn_SelectCar);
            this.Controls.Add(this.btn_selectBall);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btn_SelectCar;
        private System.Windows.Forms.Button btn_selectBall;
        private System.Windows.Forms.Label label_Next;
    }
}

