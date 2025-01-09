// This project uses OpenCvSharp and OpenCV, which is licensed under the MIT License and Apache License 2.0. See LICENSE file for more details.

namespace Look_alike_Judging
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label_add_2 = new Label();
            label_add_1 = new Label();
            button_browse_2 = new Button();
            label_image_2 = new Label();
            pictureBox2 = new PictureBox();
            button_browse_1 = new Button();
            pictureBox1 = new PictureBox();
            label_image_1 = new Label();
            button_judging_start = new Button();
            label_look_alike_per = new Label();
            label_result_per = new Label();
            label_per_explain = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label_add_2
            // 
            label_add_2.AutoSize = true;
            label_add_2.Location = new Point(482, 89);
            label_add_2.Name = "label_add_2";
            label_add_2.Size = new Size(31, 15);
            label_add_2.TabIndex = 25;
            label_add_2.Text = "追加";
            // 
            // label_add_1
            // 
            label_add_1.AutoSize = true;
            label_add_1.Location = new Point(19, 88);
            label_add_1.Name = "label_add_1";
            label_add_1.Size = new Size(31, 15);
            label_add_1.TabIndex = 24;
            label_add_1.Text = "追加";
            // 
            // button_browse_2
            // 
            button_browse_2.Font = new Font("游ゴシック", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button_browse_2.Location = new Point(475, 106);
            button_browse_2.Name = "button_browse_2";
            button_browse_2.Size = new Size(45, 45);
            button_browse_2.TabIndex = 21;
            button_browse_2.Text = "🖼 ";
            button_browse_2.UseVisualStyleBackColor = true;
            button_browse_2.Click += buttonBrowse_Click2;
            // 
            // label_image_2
            // 
            label_image_2.AutoSize = true;
            label_image_2.Location = new Point(348, 9);
            label_image_2.Name = "label_image_2";
            label_image_2.Size = new Size(43, 15);
            label_image_2.TabIndex = 23;
            label_image_2.Text = "画像２";
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(269, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 200);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // button_browse_1
            // 
            button_browse_1.Font = new Font("游ゴシック", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button_browse_1.Location = new Point(12, 106);
            button_browse_1.Name = "button_browse_1";
            button_browse_1.Size = new Size(45, 45);
            button_browse_1.TabIndex = 22;
            button_browse_1.Text = "🖼 ";
            button_browse_1.UseVisualStyleBackColor = true;
            button_browse_1.Click += buttonBrowse_Click1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(63, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label_image_1
            // 
            label_image_1.AutoSize = true;
            label_image_1.Location = new Point(142, 9);
            label_image_1.Name = "label_image_1";
            label_image_1.Size = new Size(43, 15);
            label_image_1.TabIndex = 18;
            label_image_1.Text = "画像１";
            // 
            // button_judging_start
            // 
            button_judging_start.Location = new Point(205, 233);
            button_judging_start.Name = "button_judging_start";
            button_judging_start.Size = new Size(123, 30);
            button_judging_start.TabIndex = 17;
            button_judging_start.Text = "判定開始";
            button_judging_start.UseVisualStyleBackColor = true;
            button_judging_start.Click += judgingButton_Click;
            // 
            // label_look_alike_per
            // 
            label_look_alike_per.AutoSize = true;
            label_look_alike_per.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label_look_alike_per.Location = new Point(0, 275);
            label_look_alike_per.Name = "label_look_alike_per";
            label_look_alike_per.Size = new Size(199, 37);
            label_look_alike_per.TabIndex = 26;
            label_look_alike_per.Text = "そっくりさん度は…";
            // 
            // label_result_per
            // 
            label_result_per.AutoSize = true;
            label_result_per.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label_result_per.Location = new Point(195, 275);
            label_result_per.Name = "label_result_per";
            label_result_per.Size = new Size(44, 37);
            label_result_per.TabIndex = 28;
            label_result_per.Text = "　";
            // 
            // label_per_explain
            // 
            label_per_explain.AutoSize = true;
            label_per_explain.Location = new Point(370, 233);
            label_per_explain.Name = "label_per_explain";
            label_per_explain.Size = new Size(161, 105);
            label_per_explain.TabIndex = 29;
            label_per_explain.Text = " 100%~95% … 同一人物？\r\n94.9%~90% … ほぼ同一人物\r\n89.9%~80% … かなりそっくりさん\r\n79.9%~70% … そっくりさん\r\n69.9%~60% … ややそっくりさん\r\n59.9%~50% … 似てるかも?\r\n49.9%~  0% … 似てない";
            label_per_explain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 345);
            Controls.Add(label_per_explain);
            Controls.Add(label_result_per);
            Controls.Add(label_look_alike_per);
            Controls.Add(label_add_2);
            Controls.Add(label_add_1);
            Controls.Add(button_browse_2);
            Controls.Add(label_image_2);
            Controls.Add(pictureBox2);
            Controls.Add(button_browse_1);
            Controls.Add(pictureBox1);
            Controls.Add(label_image_1);
            Controls.Add(button_judging_start);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "そっくりさん判定";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_add_2;
        private Label label_add_1;
        private Button button_browse_2;
        private Label label_image_2;
        private PictureBox pictureBox2;
        private Button button_browse_1;
        private PictureBox pictureBox1;
        private Label label_image_1;
        private Button button_judging_start;
        private Label label_look_alike_per;
        private Label label_result_per;
        private Label label_per_explain;
    }
}
